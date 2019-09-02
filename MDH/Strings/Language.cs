using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDH.Strings
{
    public class Language
    {
        //public string ISO_639_1_code { get; } = string.Empty;
        //public string ISO_639_2T_code { get; } = string.Empty;
        //public string ISO_639_2B_code { get; } = string.Empty;
        //public string ISO_639_3_code { get; } = string.Empty;

        public string Code { get; } = string.Empty;
        public string EnglishName { get; } = string.Empty;
        public string NativeName { get; } = string.Empty;

        #region Constractor
        //private Language(string Code)
        //{
        //    this.Code = Code;
        //}

        private Language(string Code, string EnglishName)
        {
            this.Code = Code;
            this.EnglishName = EnglishName;
        }

        //private Language(string Code, string EnglishName, string NativeName)
        //{
        //    this.Code = Code;
        //    this.EnglishName = EnglishName;
        //    this.NativeName = NativeName;
        //}

        //private Language(string ISO_639_1_code)
        //{
        //    this.ISO_639_1_code = ISO_639_1_code;
        //}

        //public Language(string ISO_639_1_code, string ISO_639_2T_code, string ISO_639_2B_code, string ISO_639_3_code, string ISO_639_5_code)
        //private Language(string ISO_639_1_code, string ISO_639_2T_code, string ISO_639_2B_code, string ISO_639_3_code)
        //{
        //    this.ISO_639_1_code = ISO_639_1_code;
        //    this.ISO_639_2T_code = ISO_639_2T_code;
        //    this.ISO_639_2B_code = ISO_639_2B_code;
        //    this.ISO_639_3_code = ISO_639_3_code;
        //    //this.ISO_639_5_code = ISO_639_5_code;
        //}
        #endregion

        #region Languages
        public static Language Auto_Detect = new Language("auto", "Auto Detect");
        public static Language Afrikaans = new Language("af", "Afrikaans");
        public static Language Albanian = new Language("sq", "Albanian");
        public static Language Amharic = new Language("am", "Amharic");
        public static Language Arabic = new Language("ar", "Arabic");
        public static Language Armenian = new Language("hy", "Armenian");
        public static Language Azerbaijani = new Language("az", "Azerbaijani");
        public static Language Basque = new Language("eu", "Basque");
        public static Language Belarusian = new Language("be", "Belarusian");
        public static Language Bengali = new Language("bn", "Bengali");
        public static Language Bosnian = new Language("bs", "Bosnian");
        public static Language Bulgarian = new Language("bg", "Bulgarian");
        public static Language Catalan = new Language("ca", "Catalan");
        public static Language Cebuano = new Language("ceb", "Cebuano");
        public static Language Chichewa = new Language("ny", "Chichewa");
        public static Language Chinese = new Language("zh-CN", "Chinese");
        public static Language Corsican = new Language("co", "Corsican");
        public static Language Croatian = new Language("hr", "Croatian");
        public static Language Czech = new Language("cs", "Czech");
        public static Language Danish = new Language("da", "Danish");
        public static Language Dutch = new Language("nl", "Dutch");
        public static Language English = new Language("en", "English");
        public static Language Esperanto = new Language("eo", "Esperanto");
        public static Language Estonian = new Language("et", "Estonian");
        public static Language Filipino = new Language("tl", "Filipino");
        public static Language Finnish = new Language("fi", "Finnish");
        public static Language French = new Language("fr", "French");
        public static Language Frisian = new Language("fy", "Frisian");
        public static Language Galician = new Language("gl", "Galician");
        public static Language Georgian = new Language("ka", "Georgian");
        public static Language German = new Language("de", "German");
        public static Language Greek = new Language("el", "Greek");
        public static Language Gujarati = new Language("gu", "Gujarati");
        public static Language Haitian_Creole = new Language("ht", "Haitian Creole");
        public static Language Hausa = new Language("ha", "Hausa");
        public static Language Hawaiian = new Language("haw", "Hawaiian");
        public static Language Hebrew = new Language("iw", "Hebrew");
        public static Language Hindi = new Language("hi", "Hindi");
        public static Language Hmong = new Language("hmn", "Hmong");
        public static Language Hungarian = new Language("hu", "Hungarian");
        public static Language Icelandic = new Language("is", "Icelandic");
        public static Language Igbo = new Language("ig", "Igbo");
        public static Language Indonesian = new Language("id", "Indonesian");
        public static Language Irish = new Language("ga", "Irish");
        public static Language Italian = new Language("it", "Italian");
        public static Language Japanese = new Language("ja", "Japanese");
        public static Language Javanese = new Language("jw", "Javanese");
        public static Language Kannada = new Language("kn", "Kannada");
        public static Language Kazakh = new Language("kk", "Kazakh");
        public static Language Khmer = new Language("km", "Khmer");
        public static Language Korean = new Language("ko", "Korean");
        public static Language Kurdish = new Language("ku", "Kurdish");
        public static Language Kurmanji = new Language("ku", "Kurmanji");
        public static Language Kyrgyz = new Language("ky", "Kyrgyz");
        public static Language Lao = new Language("lo", "Lao");
        public static Language Latin = new Language("la", "Latin");
        public static Language Latvian = new Language("lv", "Latvian");
        public static Language Lithuanian = new Language("lt", "Lithuanian");
        public static Language Luxembourgish = new Language("lb", "Luxembourgish");
        public static Language Macedonian = new Language("mk", "Macedonian");
        public static Language Malagasy = new Language("mg", "Malagasy");
        public static Language Malay = new Language("ms", "Malay");
        public static Language Malayalam = new Language("ml", "Malayalam");
        public static Language Maltese = new Language("mt", "Maltese");
        public static Language Maori = new Language("mi", "Maori");
        public static Language Marathi = new Language("mr", "Marathi");
        public static Language Mongolian = new Language("mn", "Mongolian");
        public static Language Myanmar = new Language("my", "Myanmar");
        public static Language Burmese = new Language("my", "Burmese");
        public static Language Nepali = new Language("ne", "Nepali");
        public static Language Norwegian = new Language("no", "Norwegian");
        public static Language Pashto = new Language("ps", "Pashto");
        public static Language Persian = new Language("fa", "Persian");
        public static Language Polish = new Language("pl", "Polish");
        public static Language Portuguese = new Language("pt", "Portuguese");
        public static Language Punjabi = new Language("pa", "Punjabi");
        public static Language Romanian = new Language("ro", "Romanian");
        public static Language Russian = new Language("ru", "Russian");
        public static Language Samoan = new Language("sm", "Samoan");
        public static Language Scots_Gaelic = new Language("gd", "Scots Gaelic");
        public static Language Serbian = new Language("sr", "Serbian");
        public static Language Sesotho = new Language("st", "Sesotho");
        public static Language Shona = new Language("sn", "Shona");
        public static Language Sindhi = new Language("sd", "Sindhi");
        public static Language Sinhala = new Language("si", "Sinhala");
        public static Language Slovak = new Language("sk", "Slovak");
        public static Language Slovenian = new Language("sl", "Slovenian");
        public static Language Somali = new Language("so", "Somali");
        public static Language Spanish = new Language("es", "Spanish");
        public static Language Sundanese = new Language("su", "Sundanese");
        public static Language Swahili = new Language("sw", "Swahili");
        public static Language Swedish = new Language("sv", "Swedish");
        public static Language Tajik = new Language("tg", "Tajik");
        public static Language Tamil = new Language("ta", "Tamil");
        public static Language Telugu = new Language("te", "Telugu");
        public static Language Thai = new Language("th", "Thai");
        public static Language Turkish = new Language("tr", "Turkish");
        public static Language Ukrainian = new Language("uk", "Ukrainian");
        public static Language Urdu = new Language("ur", "Urdu");
        public static Language Uzbek = new Language("uz", "Uzbek");
        public static Language Vietnamese = new Language("vi", "Vietnamese");
        public static Language Welsh = new Language("cy", "Welsh");
        public static Language Xhosa = new Language("xh", "Xhosa");
        public static Language Yiddish = new Language("yi", "Yiddish");
        public static Language Yoruba = new Language("yo", "Yoruba");
        public static Language Zulu = new Language("zu", "Zulu");
        #endregion
    }
}

//public enum Language
//{
//    Auto_Detect = 0,
//    Afrikaans = 1,
//    Albanian = 2,
//    Amharic = 3,
//    Arabic = 4,
//    Armenian = 5,
//    Azerbaijani = 6,
//    Basque = 7,
//    Belarusian = 8,
//    Bengali = 9,
//    Bosnian = 10,
//    Bulgarian = 11,
//    Catalan = 12,
//    Cebuano = 13,
//    Chichewa = 14,
//    Chinese = 15,
//    Corsican = 16,
//    Croatian = 17,
//    Czech = 18,
//    Danish = 19,
//    Dutch = 20,
//    English = 21,
//    Esperanto = 22,
//    Estonian = 23,
//    Filipino = 24,
//    Finnish = 25,
//    French = 26,
//    Frisian = 27,
//    Galician = 28,
//    Georgian = 29,
//    German = 30,
//    Greek = 31,
//    Gujarati = 32,
//    Haitian_Creole = 33,
//    Hausa = 34,
//    Hawaiian = 35,
//    Hebrew = 36,
//    Hindi = 37,
//    Hmong = 38,
//    Hungarian = 39,
//    Icelandic = 40,
//    Igbo = 41,
//    Indonesian = 42,
//    Irish = 43,
//    Italian = 44,
//    Japanese = 45,
//    Javanese = 46,
//    Kannada = 47,
//    Kazakh = 48,
//    Khmer = 49,
//    Korean = 50,
//    Kurdish = 51,
//    Kurmanji = 52,
//    Kyrgyz = 53,
//    Lao = 54,
//    Latin = 55,
//    Latvian = 56,
//    Lithuanian = 57,
//    Luxembourgish = 58,
//    Macedonian = 59,
//    Malagasy = 60,
//    Malay = 61,
//    Malayalam = 62,
//    Maltese = 63,
//    Maori = 64,
//    Marathi = 65,
//    Mongolian = 66,
//    Myanmar = 67,
//    Burmese = 68,
//    Nepali = 69,
//    Norwegian = 70,
//    Pashto = 71,
//    Persian = 72,
//    Polish = 73,
//    Portuguese = 74,
//    Punjabi = 75,
//    Romanian = 76,
//    Russian = 77,
//    Samoan = 78,
//    Scots_Gaelic = 79,
//    Serbian = 80,
//    Sesotho = 81,
//    Shona = 82,
//    Sindhi = 83,
//    Sinhala = 84,
//    Slovak = 85,
//    Slovenian = 86,
//    Somali = 87,
//    Spanish = 88,
//    Sundanese = 89,
//    Swahili = 90,
//    Swedish = 91,
//    Tajik = 92,
//    Tamil = 93,
//    Telugu = 94,
//    Thai = 95,
//    Turkish = 96,
//    Ukrainian = 97,
//    Urdu = 98,
//    Uzbek = 99,
//    Vietnamese = 100,
//    Welsh = 101,
//    Xhosa = 102,
//    Yiddish = 103,
//    Yoruba = 104,
//    Zulu = 105
//}

//string LanguageCodeByLanguage(Language language)
//{
//    string code = "en";
//    switch (language)
//    {
//        case Language.Auto_Detect:
//            code = "auto";
//            break;
//        case Language.Afrikaans:
//            code = "af";
//            break;
//        case Language.Albanian:
//            code = "sq";
//            break;
//        case Language.Amharic:
//            code = "am";
//            break;
//        case Language.Arabic:
//            code = "ar";
//            break;
//        case Language.Armenian:
//            code = "hy";
//            break;
//        case Language.Azerbaijani:
//            code = "az";
//            break;
//        case Language.Basque:
//            code = "eu";
//            break;
//        case Language.Belarusian:
//            code = "be";
//            break;
//        case Language.Bengali:
//            code = "bn";
//            break;
//        case Language.Bosnian:
//            code = "bs";
//            break;
//        case Language.Bulgarian:
//            code = "bg";
//            break;
//        case Language.Catalan:
//            code = "ca";
//            break;
//        case Language.Cebuano:
//            code = "ceb";
//            break;
//        case Language.Chichewa:
//            code = "ny";
//            break;
//        case Language.Chinese:
//            code = "zh-CN";
//            break;
//        case Language.Corsican:
//            code = "co";
//            break;
//        case Language.Croatian:
//            code = "hr";
//            break;
//        case Language.Czech:
//            code = "cs";
//            break;
//        case Language.Danish:
//            code = "da";
//            break;
//        case Language.Dutch:
//            code = "nl";
//            break;
//        case Language.English:
//            code = "en";
//            break;
//        case Language.Esperanto:
//            code = "eo";
//            break;
//        case Language.Estonian:
//            code = "et";
//            break;
//        case Language.Filipino:
//            code = "tl";
//            break;
//        case Language.Finnish:
//            code = "fi";
//            break;
//        case Language.French:
//            code = "fr";
//            break;
//        case Language.Frisian:
//            code = "fy";
//            break;
//        case Language.Galician:
//            code = "gl";
//            break;
//        case Language.Georgian:
//            code = "ka";
//            break;
//        case Language.German:
//            code = "de";
//            break;
//        case Language.Greek:
//            code = "el";
//            break;
//        case Language.Gujarati:
//            code = "gu";
//            break;
//        case Language.Haitian_Creole:
//            code = "ht";
//            break;
//        case Language.Hausa:
//            code = "ha";
//            break;
//        case Language.Hawaiian:
//            code = "haw";
//            break;
//        case Language.Hebrew:
//            code = "iw";
//            break;
//        case Language.Hindi:
//            code = "hi";
//            break;
//        case Language.Hmong:
//            code = "hmn";
//            break;
//        case Language.Hungarian:
//            code = "hu";
//            break;
//        case Language.Icelandic:
//            code = "is";
//            break;
//        case Language.Igbo:
//            code = "ig";
//            break;
//        case Language.Indonesian:
//            code = "id";
//            break;
//        case Language.Irish:
//            code = "ga";
//            break;
//        case Language.Italian:
//            code = "it";
//            break;
//        case Language.Japanese:
//            code = "ja";
//            break;
//        case Language.Javanese:
//            code = "jw";
//            break;
//        case Language.Kannada:
//            code = "kn";
//            break;
//        case Language.Kazakh:
//            code = "kk";
//            break;
//        case Language.Khmer:
//            code = "km";
//            break;
//        case Language.Korean:
//            code = "ko";
//            break;
//        case Language.Kurdish:
//        case Language.Kurmanji:
//            code = "ku";
//            break;
//        case Language.Kyrgyz:
//            code = "ky";
//            break;
//        case Language.Lao:
//            code = "lo";
//            break;
//        case Language.Latin:
//            code = "la";
//            break;
//        case Language.Latvian:
//            code = "lv";
//            break;
//        case Language.Lithuanian:
//            code = "lt";
//            break;
//        case Language.Luxembourgish:
//            code = "lb";
//            break;
//        case Language.Macedonian:
//            code = "mk";
//            break;
//        case Language.Malagasy:
//            code = "mg";
//            break;
//        case Language.Malay:
//            code = "ms";
//            break;
//        case Language.Malayalam:
//            code = "ml";
//            break;
//        case Language.Maltese:
//            code = "mt";
//            break;
//        case Language.Maori:
//            code = "mi";
//            break;
//        case Language.Marathi:
//            code = "mr";
//            break;
//        case Language.Mongolian:
//            code = "mn";
//            break;
//        case Language.Myanmar:
//        case Language.Burmese:
//            code = "my";
//            break;
//        case Language.Nepali:
//            code = "ne";
//            break;
//        case Language.Norwegian:
//            code = "no";
//            break;
//        case Language.Pashto:
//            code = "ps";
//            break;
//        case Language.Persian:
//            code = "fa";
//            break;
//        case Language.Polish:
//            code = "pl";
//            break;
//        case Language.Portuguese:
//            code = "pt";
//            break;
//        case Language.Punjabi:
//            code = "pa";
//            break;
//        case Language.Romanian:
//            code = "ro";
//            break;
//        case Language.Russian:
//            code = "ru";
//            break;
//        case Language.Samoan:
//            code = "sm";
//            break;
//        case Language.Scots_Gaelic:
//            code = "gd";
//            break;
//        case Language.Serbian:
//            code = "sr";
//            break;
//        case Language.Sesotho:
//            code = "st";
//            break;
//        case Language.Shona:
//            code = "sn";
//            break;
//        case Language.Sindhi:
//            code = "sd";
//            break;
//        case Language.Sinhala:
//            code = "si";
//            break;
//        case Language.Slovak:
//            code = "sk";
//            break;
//        case Language.Slovenian:
//            code = "sl";
//            break;
//        case Language.Somali:
//            code = "so";
//            break;
//        case Language.Spanish:
//            code = "es";
//            break;
//        case Language.Sundanese:
//            code = "su";
//            break;
//        case Language.Swahili:
//            code = "sw";
//            break;
//        case Language.Swedish:
//            code = "sv";
//            break;
//        case Language.Tajik:
//            code = "tg";
//            break;
//        case Language.Tamil:
//            code = "ta";
//            break;
//        case Language.Telugu:
//            code = "te";
//            break;
//        case Language.Thai:
//            code = "th";
//            break;
//        case Language.Turkish:
//            code = "tr";
//            break;
//        case Language.Ukrainian:
//            code = "uk";
//            break;
//        case Language.Urdu:
//            code = "ur";
//            break;
//        case Language.Uzbek:
//            code = "uz";
//            break;
//        case Language.Vietnamese:
//            code = "vi";
//            break;
//        case Language.Welsh:
//            code = "cy";
//            break;
//        case Language.Xhosa:
//            code = "xh";
//            break;
//        case Language.Yiddish:
//            code = "yi";
//            break;
//        case Language.Yoruba:
//            code = "yo";
//            break;
//        case Language.Zulu:
//            code = "zu";
//            break;
//        default:
//            break;
//    }
//    return code;
//}

//        void LngCodeName()
//        {
//            //get the language name from the language code
//            Console.WriteLine(new CultureInfo("en").DisplayName);
//            Console.WriteLine(new CultureInfo("en").EnglishName);
//            Console.WriteLine(new CultureInfo("en").NativeName);
//            Console.WriteLine(new CultureInfo("en").Name);
//            Console.WriteLine(new CultureInfo("en").ThreeLetterISOLanguageName);
//            Console.WriteLine(new CultureInfo("en").ThreeLetterWindowsLanguageName);
//            Console.WriteLine(new CultureInfo("en").TwoLetterISOLanguageName);
//            //get the language name from the language code
//            var allCultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
//            var en = allCultures.FirstOrDefault(c => c.Name == "en").DisplayName;
//            var de = allCultures.FirstOrDefault(c => c.Name == "de").DisplayName;

//            #region Get Culture Names
//            // get culture names
//            List<string> list = new List<string>();
//            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
//            {
//                string specName = "(none)";
//                try
//                {
//                    specName = CultureInfo.CreateSpecificCulture(ci.Name).Name;
//                }
//                catch (ArgumentException)
//                {
//                    specName = "(no associated specific culture)";
//                }
//                list.Add(String.Format("{0,-12}{1,-12}{2}", ci.Name, specName, ci.EnglishName));
//            }

//            list.Sort();  // sort by name

//            // write to console
//            Console.WriteLine("CULTURE   SPEC.CULTURE  ENGLISH NAME");
//            Console.WriteLine("--------------------------------------------------------------");
//            foreach (string str in list)
//                Console.WriteLine(str);
//            #region Output            
//            //****************************************************************
//            // [Output]
//            // CULTURE   SPEC.CULTURE  ENGLISH NAME
//            // --------------------------------------------------------------
//            //                         Invariant Language (Invariant Country)
//            // af          af-ZA       Afrikaans
//            // af-ZA       af-ZA       Afrikaans (South Africa)
//            // ar          ar-SA       Arabic
//            // ar-AE       ar-AE       Arabic (U.A.E.)
//            // ar-BH       ar-BH       Arabic (Bahrain)
//            // ar-DZ       ar-DZ       Arabic (Algeria)
//            // ar-EG       ar-EG       Arabic (Egypt)
//            // ar-IQ       ar-IQ       Arabic (Iraq)
//            // ar-JO       ar-JO       Arabic (Jordan)
//            // ar-KW       ar-KW       Arabic (Kuwait)
//            // ar-LB       ar-LB       Arabic (Lebanon)
//            // ar-LY       ar-LY       Arabic (Libya)
//            // ar-MA       ar-MA       Arabic (Morocco)
//            // ar-OM       ar-OM       Arabic (Oman)
//            // ar-QA       ar-QA       Arabic (Qatar)
//            // ar-SA       ar-SA       Arabic (Saudi Arabia)
//            // ar-SY       ar-SY       Arabic (Syria)
//            // ar-TN       ar-TN       Arabic (Tunisia)
//            // ar-YE       ar-YE       Arabic (Yemen)
//            // az          az-Latn-AZ  Azeri
//            // az-Cyrl-AZ  az-Cyrl-AZ  Azeri (Cyrillic, Azerbaijan)
//            // az-Latn-AZ  az-Latn-AZ  Azeri (Latin, Azerbaijan)
//            // be          be-BY       Belarusian
//            // be-BY       be-BY       Belarusian (Belarus)
//            // bg          bg-BG       Bulgarian
//            // bg-BG       bg-BG       Bulgarian (Bulgaria)
//            // bs-Latn-BA  bs-Latn-BA  Bosnian (Bosnia and Herzegovina)
//            // ca          ca-ES       Catalan
//            // ca-ES       ca-ES       Catalan (Catalan)
//            // cs          cs-CZ       Czech
//            // cs-CZ       cs-CZ       Czech (Czech Republic)
//            // cy-GB       cy-GB       Welsh (United Kingdom)
//            // da          da-DK       Danish
//            // da-DK       da-DK       Danish (Denmark)
//            // de          de-DE       German
//            // de-AT       de-AT       German (Austria)
//            // de-DE       de-DE       German (Germany)
//            // de-CH       de-CH       German (Switzerland)
//            // de-LI       de-LI       German (Liechtenstein)
//            // de-LU       de-LU       German (Luxembourg)
//            // dv          dv-MV       Divehi
//            // dv-MV       dv-MV       Divehi (Maldives)
//            // el          el-GR       Greek
//            // el-GR       el-GR       Greek (Greece)
//            // en          en-US       English
//            // en-029      en-029      English (Caribbean)
//            // en-AU       en-AU       English (Australia)
//            // en-BZ       en-BZ       English (Belize)
//            // en-CA       en-CA       English (Canada)
//            // en-GB       en-GB       English (United Kingdom)
//            // en-IE       en-IE       English (Ireland)
//            // en-JM       en-JM       English (Jamaica)
//            // en-NZ       en-NZ       English (New Zealand)
//            // en-PH       en-PH       English (Republic of the Philippines)
//            // en-TT       en-TT       English (Trinidad and Tobago)
//            // en-US       en-US       English (United States)
//            // en-ZA       en-ZA       English (South Africa)
//            // en-ZW       en-ZW       English (Zimbabwe)
//            // es          es-ES       Spanish
//            // es-AR       es-AR       Spanish (Argentina)
//            // es-BO       es-BO       Spanish (Bolivia)
//            // es-CL       es-CL       Spanish (Chile)
//            // es-CO       es-CO       Spanish (Colombia)
//            // es-CR       es-CR       Spanish (Costa Rica)
//            // es-DO       es-DO       Spanish (Dominican Republic)
//            // es-EC       es-EC       Spanish (Ecuador)
//            // es-ES       es-ES       Spanish (Spain)
//            // es-GT       es-GT       Spanish (Guatemala)
//            // es-HN       es-HN       Spanish (Honduras)
//            // es-MX       es-MX       Spanish (Mexico)
//            // es-NI       es-NI       Spanish (Nicaragua)
//            // es-PA       es-PA       Spanish (Panama)
//            // es-PE       es-PE       Spanish (Peru)
//            // es-PR       es-PR       Spanish (Puerto Rico)
//            // es-PY       es-PY       Spanish (Paraguay)
//            // es-SV       es-SV       Spanish (El Salvador)
//            // es-UY       es-UY       Spanish (Uruguay)
//            // es-VE       es-VE       Spanish (Venezuela)
//            // et          et-EE       Estonian
//            // et-EE       et-EE       Estonian (Estonia)
//            // eu          eu-ES       Basque
//            // eu-ES       eu-ES       Basque (Basque)
//            // fa          fa-IR       Persian
//            // fa-IR       fa-IR       Persian (Iran)
//            // fi          fi-FI       Finnish
//            // fi-FI       fi-FI       Finnish (Finland)
//            // fo          fo-FO       Faroese
//            // fo-FO       fo-FO       Faroese (Faroe Islands)
//            // fr          fr-FR       French
//            // fr-BE       fr-BE       French (Belgium)
//            // fr-CA       fr-CA       French (Canada)
//            // fr-FR       fr-FR       French (France)
//            // fr-CH       fr-CH       French (Switzerland)
//            // fr-LU       fr-LU       French (Luxembourg)
//            // fr-MC       fr-MC       French (Principality of Monaco)
//            // gl          gl-ES       Galician
//            // gl-ES       gl-ES       Galician (Galician)
//            // gu          gu-IN       Gujarati
//            // gu-IN       gu-IN       Gujarati (India)
//            // he          he-IL       Hebrew
//            // he-IL       he-IL       Hebrew (Israel)
//            // hi          hi-IN       Hindi
//            // hi-IN       hi-IN       Hindi (India)
//            // hr          hr-HR       Croatian
//            // hr-BA       hr-BA       Croatian (Bosnia and Herzegovina)
//            // hr-HR       hr-HR       Croatian (Croatia)
//            // hu          hu-HU       Hungarian
//            // hu-HU       hu-HU       Hungarian (Hungary)
//            // hy          hy-AM       Armenian
//            // hy-AM       hy-AM       Armenian (Armenia)
//            // id          id-ID       Indonesian
//            // id-ID       id-ID       Indonesian (Indonesia)
//            // is          is-IS       Icelandic
//            // is-IS       is-IS       Icelandic (Iceland)
//            // it          it-IT       Italian
//            // it-CH       it-CH       Italian (Switzerland)
//            // it-IT       it-IT       Italian (Italy)
//            // ja          ja-JP       Japanese
//            // ja-JP       ja-JP       Japanese (Japan)
//            // ka          ka-GE       Georgian
//            // ka-GE       ka-GE       Georgian (Georgia)
//            // kk          kk-KZ       Kazakh
//            // kk-KZ       kk-KZ       Kazakh (Kazakhstan)
//            // kn          kn-IN       Kannada
//            // kn-IN       kn-IN       Kannada (India)
//            // ko          ko-KR       Korean
//            // kok         kok-IN      Konkani
//            // kok-IN      kok-IN      Konkani (India)
//            // ko-KR       ko-KR       Korean (Korea)
//            // ky          ky-KG       Kyrgyz
//            // ky-KG       ky-KG       Kyrgyz (Kyrgyzstan)
//            // lt          lt-LT       Lithuanian
//            // lt-LT       lt-LT       Lithuanian (Lithuania)
//            // lv          lv-LV       Latvian
//            // lv-LV       lv-LV       Latvian (Latvia)
//            // mi-NZ       mi-NZ       Maori (New Zealand)
//            // mk          mk-MK       Macedonian
//            // mk-MK       mk-MK       Macedonian (Former Yugoslav Republic of Macedonia)
//            // mn          mn-MN       Mongolian
//            // mn-MN       mn-MN       Mongolian (Cyrillic, Mongolia)
//            // mr          mr-IN       Marathi
//            // mr-IN       mr-IN       Marathi (India)
//            // ms          ms-MY       Malay
//            // ms-BN       ms-BN       Malay (Brunei Darussalam)
//            // ms-MY       ms-MY       Malay (Malaysia)
//            // mt-MT       mt-MT       Maltese (Malta)
//            // nb-NO       nb-NO       Norwegian, Bokmal (Norway)
//            // nl          nl-NL       Dutch
//            // nl-BE       nl-BE       Dutch (Belgium)
//            // nl-NL       nl-NL       Dutch (Netherlands)
//            // nn-NO       nn-NO       Norwegian, Nynorsk (Norway)
//            // no          nb-NO       Norwegian
//            // ns-ZA       ns-ZA       Northern Sotho (South Africa)
//            // pa          pa-IN       Punjabi
//            // pa-IN       pa-IN       Punjabi (India)
//            // pl          pl-PL       Polish
//            // pl-PL       pl-PL       Polish (Poland)
//            // pt          pt-BR       Portuguese
//            // pt-BR       pt-BR       Portuguese (Brazil)
//            // pt-PT       pt-PT       Portuguese (Portugal)
//            // quz-BO      quz-BO      Quechua (Bolivia)
//            // quz-EC      quz-EC      Quechua (Ecuador)
//            // quz-PE      quz-PE      Quechua (Peru)
//            // ro          ro-RO       Romanian
//            // ro-RO       ro-RO       Romanian (Romania)
//            // ru          ru-RU       Russian
//            // ru-RU       ru-RU       Russian (Russia)
//            // sa          sa-IN       Sanskrit
//            // sa-IN       sa-IN       Sanskrit (India)
//            // se-FI       se-FI       Sami (Northern) (Finland)
//            // se-NO       se-NO       Sami (Northern) (Norway)
//            // se-SE       se-SE       Sami (Northern) (Sweden)
//            // sk          sk-SK       Slovak
//            // sk-SK       sk-SK       Slovak (Slovakia)
//            // sl          sl-SI       Slovenian
//            // sl-SI       sl-SI       Slovenian (Slovenia)
//            // sma-NO      sma-NO      Sami (Southern) (Norway)
//            // sma-SE      sma-SE      Sami (Southern) (Sweden)
//            // smj-NO      smj-NO      Sami (Lule) (Norway)
//            // smj-SE      smj-SE      Sami (Lule) (Sweden)
//            // smn-FI      smn-FI      Sami (Inari) (Finland)
//            // sms-FI      sms-FI      Sami (Skolt) (Finland)
//            // sq          sq-AL       Albanian
//            // sq-AL       sq-AL       Albanian (Albania)
//            // sr          sr-Latn-CS  Serbian
//            // sr-Cyrl-BA  sr-Cyrl-BA  Serbian (Cyrillic) (Bosnia and Herzegovina)
//            // sr-Cyrl-CS  sr-Cyrl-CS  Serbian (Cyrillic, Serbia)
//            // sr-Latn-BA  sr-Latn-BA  Serbian (Latin) (Bosnia and Herzegovina)
//            // sr-Latn-CS  sr-Latn-CS  Serbian (Latin, Serbia)
//            // sv          sv-SE       Swedish
//            // sv-FI       sv-FI       Swedish (Finland)
//            // sv-SE       sv-SE       Swedish (Sweden)
//            // sw          sw-KE       Kiswahili
//            // sw-KE       sw-KE       Kiswahili (Kenya)
//            // syr         syr-SY      Syriac
//            // syr-SY      syr-SY      Syriac (Syria)
//            // ta          ta-IN       Tamil
//            // ta-IN       ta-IN       Tamil (India)
//            // te          te-IN       Telugu
//            // te-IN       te-IN       Telugu (India)
//            // th          th-TH       Thai
//            // th-TH       th-TH       Thai (Thailand)
//            // tn-ZA       tn-ZA       Tswana (South Africa)
//            // tr          tr-TR       Turkish
//            // tr-TR       tr-TR       Turkish (Turkey)
//            // tt          tt-RU       Tatar
//            // tt-RU       tt-RU       Tatar (Russia)
//            // uk          uk-UA       Ukrainian
//            // uk-UA       uk-UA       Ukrainian (Ukraine)
//            // ur          ur-PK       Urdu
//            // ur-PK       ur-PK       Urdu (Islamic Republic of Pakistan)
//            // uz          uz-Latn-UZ  Uzbek
//            // uz-Cyrl-UZ  uz-Cyrl-UZ  Uzbek (Cyrillic, Uzbekistan)
//            // uz-Latn-UZ  uz-Latn-UZ  Uzbek (Latin, Uzbekistan)
//            // vi          vi-VN       Vietnamese
//            // vi-VN       vi-VN       Vietnamese (Vietnam)
//            // xh-ZA       xh-ZA       Xhosa (South Africa)
//            // zh-CN       zh-CN       Chinese (People's Republic of China)
//            // zh-HK       zh-HK       Chinese (Hong Kong S.A.R.)
//            // zh-CHS      (none)      Chinese (Simplified)
//            // zh-CHT      (none)      Chinese (Traditional)
//            // zh-MO       zh-MO       Chinese (Macao S.A.R.)
//            // zh-SG       zh-SG       Chinese (Singapore)
//            // zh-TW       zh-TW       Chinese (Taiwan)
//            // zu-ZA       zu-ZA       Zulu (South Africa)
//            //****************************************************************/
//            #endregion
//            #endregion

//            #region MyRegion
//            // Creates and initializes the CultureInfo which uses the international sort.
//            CultureInfo myCIintl = new CultureInfo("es-ES", false);

//            // Creates and initializes the CultureInfo which uses the traditional sort.
//            CultureInfo myCItrad = new CultureInfo(0x040A, false);

//            // Displays the properties of each culture.
//            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "PROPERTY", "INTERNATIONAL", "TRADITIONAL");
//            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "CompareInfo", myCIintl.CompareInfo, myCItrad.CompareInfo);
//            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "DisplayName", myCIintl.DisplayName, myCItrad.DisplayName);
//            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "EnglishName", myCIintl.EnglishName, myCItrad.EnglishName);
//            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "IsNeutralCulture", myCIintl.IsNeutralCulture, myCItrad.IsNeutralCulture);
//            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "IsReadOnly", myCIintl.IsReadOnly, myCItrad.IsReadOnly);
//            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "LCID", myCIintl.LCID, myCItrad.LCID);
//            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Name", myCIintl.Name, myCItrad.Name);
//            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "NativeName", myCIintl.NativeName, myCItrad.NativeName);
//            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Parent", myCIintl.Parent, myCItrad.Parent);
//            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "TextInfo", myCIintl.TextInfo, myCItrad.TextInfo);
//            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "ThreeLetterISOLanguageName", myCIintl.ThreeLetterISOLanguageName, myCItrad.ThreeLetterISOLanguageName);
//            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "ThreeLetterWindowsLanguageName", myCIintl.ThreeLetterWindowsLanguageName, myCItrad.ThreeLetterWindowsLanguageName);
//            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "TwoLetterISOLanguageName", myCIintl.TwoLetterISOLanguageName, myCItrad.TwoLetterISOLanguageName);
//            Console.WriteLine();

//            // Compare two strings using myCIintl.
//            Console.WriteLine("Comparing \"llegar\" and \"lugar\"");
//            Console.WriteLine("   With myCIintl.CompareInfo.Compare: {0}", myCIintl.CompareInfo.Compare("llegar", "lugar"));
//            Console.WriteLine("   With myCItrad.CompareInfo.Compare: {0}", myCItrad.CompareInfo.Compare("llegar", "lugar"));

//            /*
//This code produces the following output.

//PROPERTY                       INTERNATIONAL                                  TRADITIONAL              
//CompareInfo                    CompareInfo - es-ES                            CompareInfo - es-ES_tradnl
//DisplayName                    Spanish (Spain)                                Spanish (Spain)          
//EnglishName                    Spanish (Spain, International Sort)            Spanish (Spain, Traditional Sort)
//IsNeutralCulture               False                                          False                    
//IsReadOnly                     False                                          False                    
//LCID                           3082                                           1034                     
//Name                           es-ES                                          es-ES                    
//NativeName                     Español (España, alfabetización internacional) Español (España, alfabetización tradicional)
//Parent                         es                                             es                       
//TextInfo                       TextInfo - es-ES                               TextInfo - es-ES_tradnl  
//ThreeLetterISOLanguageName     spa                                            spa                      
//ThreeLetterWindowsLanguageName ESN                                            ESP                      
//TwoLetterISOLanguageName       es                                             es                       

//Comparing "llegar" and "lugar"
//   With myCIintl.CompareInfo.Compare: -1
//   With myCItrad.CompareInfo.Compare: 1

//*/
//            #endregion
//        }