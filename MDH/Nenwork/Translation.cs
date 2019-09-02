using Awesomium.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace MDH.Network
{
    public static class Translation
    {
        private static string Tr(string textToTranslate, string fromLng, string toLng)
        {
            string html = string.Empty;
            bool finishedLoading = false;

            WebConfig config = WebConfig.Default;
            if (!WebCore.IsInitialized)
            {
                WebCore.Initialize(config);
            }
            
            Uri url = new Uri(String.Format("https://translate.google.com/#view=home&op=translate&sl={0}&tl={1}&text={2}", fromLng, toLng, textToTranslate));

            WebPreferences prefs = WebPreferences.Default;
            //prefs.ProxyConfig = "198.1.99.26:3128";

            using (WebSession session = WebCore.CreateWebSession(prefs))
            {
                // WebView implements IDisposable. Here we demonstrate
                // wrapping it in a using statement.
                using (WebView webView = WebCore.CreateWebView(1366, 768, session, WebViewType.Offscreen))
                {
                    // Load a URL.
                    webView.Source = url;
                    //WebCore.Run();
                    // This event is fired when a frame in the
                    // page finished loading.
                    webView.LoadingFrameComplete += (s, e) =>
                    {
                        // The main frame usually finishes loading last for a given page load.
                        if (e.IsMainFrame)
                            finishedLoading = true;

                    };
                    while (!finishedLoading)
                    {
                        Thread.Sleep(100);
                        // A Console application does not have a synchronization
                        // context, thus auto-update won't be enabled on WebCore.
                        // We need to manually call Update here.
                        WebCore.Update();
                    }

                    html = webView.HTML;
                    int substringIndex = html.IndexOf("<span title=\"\">");
                    if (substringIndex == -1)
                    {
                        return null;
                    }
                    html = html.Substring(substringIndex + 15);

                    substringIndex = html.IndexOf("</span></span>");
                    if (substringIndex == -1)
                    {
                        return null;
                    }
                    html = html.Remove(substringIndex);

                    html = html.Replace("<br>", "\r\n");
                    html = html.Replace("</span>", "");
                    html = html.Replace("<span title=\"\">", "");
                } // Destroy and dispose the view.
            } // Release and dispose the session.            

            // Shut down Awesomium before exiting.
            //WebCore.Shutdown();
            return html;
        }

        /// <summary>
        /// Translate Text using Google Translate API's
        /// Google URL - http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}
        /// http://www.google.com/translate_t?hl=en&ie=UTF8&text=text&langpair=en|ru
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="languagePair">2 letter Language Pair, delimited by "|".
        /// E.g. "ar|en" language pair means to translate from Arabic to English</param>
        /// <returns>Translated to String</returns>
        private static string TranslateText(string input, string languagePair)
        {
            string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);
            WebClient webClient = new WebClient();
            webClient.Encoding = System.Text.Encoding.UTF8;
            //HttpRequest + HttpResponse
            string result = webClient.DownloadString(url);
            result = result.Substring(result.IndexOf("id=result_box") + 22, result.IndexOf("id=result_box") + 500);
            result = result.Substring(0, result.IndexOf("</div"));
            return result;
        }
        private static string TranslateText2(string input, string languagePair)
        {
            string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            //result = result.Substring(result.IndexOf("<span title=\"") + "<span title=\"".Length);
            //result = result.Substring(result.IndexOf(">") + 1);
            //result = result.Substring(0, result.IndexOf("</span>"));
            return result.Trim();
        }
        private static string TranslateText3(string input, string languagePair)
        {
            string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);
            WebClient webClient = new WebClient();
            //webClient.Encoding = System.Text.Encoding.Default;
            webClient.Encoding = System.Text.Encoding.UTF8;
            string result = webClient.DownloadString(url);
            //result = result.Substring(result.IndexOf("TRANSLATED_TEXT"));
            //result = result.Substring(result.IndexOf("'") + 1);
            //result = result.Substring(0, result.IndexOf("'"));
            return result;
        }

        private static String Translate(String word)
        {
            var toLanguage = "ru";//Russian
            var fromLanguage = "en";//English
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(word)}";
            var webClient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            var result = webClient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                return result;
            }
            catch
            {
                return "Error";
            }
        }

        /// <summary>
        /// Translates a string into another language using Google's translate API JSON calls.
        /// <seealso>Class TranslationServices</seealso>
        /// </summary>
        /// <param name="Text">Text to translate. Should be a single word or sentence.</param>
        /// <param name="FromCulture">
        /// Two letter culture (en of en-us, fr of fr-ca, de of de-ch, iw of he-il)
        /// </param>
        /// <param name="ToCulture">
        /// Two letter culture (as for FromCulture)
        /// </param>
        private static string TranslateGoogle(string text, string fromCulture, string toCulture)
        {
            fromCulture = fromCulture.ToLower();
            toCulture = toCulture.ToLower();

            // normalize the culture in case something like en-us was passed 
            // retrieve only en since Google doesn't support sub-locales
            string[] tokens = fromCulture.Split('-');
            if (tokens.Length > 1)
                fromCulture = tokens[0];

            // normalize ToCulture
            tokens = toCulture.Split('-');
            if (tokens.Length > 1)
                toCulture = tokens[0];

            string url = string.Format(@"http://translate.google.com/translate_a/t?client=j&text={0}&hl=en&sl={1}&tl={2}",
                                       HttpUtility.UrlEncode(text), fromCulture, toCulture);

            // Retrieve Translation with HTTP GET call
            string html = null;
            try
            {
                WebClient web = new WebClient();

                // MUST add a known browser user agent or else response encoding doen't return UTF-8 (WTF Google?)
                web.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                web.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");

                // Make sure we have response encoding to UTF-8
                web.Encoding = Encoding.UTF8;
                html = web.DownloadString(url);
            }
            catch (Exception ex)
            {
                //this.ErrorMessage = Westwind.Globalization.Resources.Resources.ConnectionFailed + ": " + ex.GetBaseException().Message;
                return null;
            }

            // Extract out trans":"...[Extracted]...","from the JSON string
            string result = Regex.Match(html, "trans\":(\".*?\"),\"", RegexOptions.IgnoreCase).Groups[1].Value;

            if (string.IsNullOrEmpty(result))
            {
                //this.ErrorMessage = Westwind.Globalization.Resources.Resources.InvalidSearchResult;
                return null;
            }

            //return WebUtils.DecodeJsString(result);

            // Result is a JavaScript string so we need to deserialize it properly
            JavaScriptSerializer ser = new JavaScriptSerializer();
            return ser.Deserialize(result, typeof(string)) as string;
        }
    }
}
