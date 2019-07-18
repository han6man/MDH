using MDH.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region Start SplashScreen
            SplashScreen.ShowSplashScreen();
            Application.DoEvents();
            SplashScreen.SetStatus("Loading module 1");
            System.Threading.Thread.Sleep(500);
            SplashScreen.SetStatus("Loading module 2");
            System.Threading.Thread.Sleep(300);
            SplashScreen.SetStatus("Loading module 3");
            System.Threading.Thread.Sleep(900);
            SplashScreen.SetStatus("Loading module 4");
            System.Threading.Thread.Sleep(100);
            SplashScreen.SetStatus("Loading module 5");
            System.Threading.Thread.Sleep(400);
            SplashScreen.SetStatus("Loading module 6");
            System.Threading.Thread.Sleep(50);
            SplashScreen.SetStatus("Loading module 7");
            System.Threading.Thread.Sleep(240);
            SplashScreen.SetStatus("Loading module 8");
            System.Threading.Thread.Sleep(900);
            SplashScreen.SetStatus("Loading module 9");
            System.Threading.Thread.Sleep(240);
            SplashScreen.SetStatus("Loading module 10");
            System.Threading.Thread.Sleep(90);
            SplashScreen.SetStatus("Loading module 11");
            System.Threading.Thread.Sleep(1000);
            SplashScreen.SetStatus("Loading module 12");
            System.Threading.Thread.Sleep(100);
            SplashScreen.SetStatus("Loading module 13");
            System.Threading.Thread.Sleep(500);
            SplashScreen.SetStatus("Loading module 14", false);
            System.Threading.Thread.Sleep(1000);
            SplashScreen.SetStatus("Loading module 14a", false);
            System.Threading.Thread.Sleep(1000);
            SplashScreen.SetStatus("Loading module 14b", false);
            System.Threading.Thread.Sleep(1000);
            SplashScreen.SetStatus("Loading module 14c", false);
            System.Threading.Thread.Sleep(1000);
            SplashScreen.SetStatus("Loading module 15");
            System.Threading.Thread.Sleep(20);
            SplashScreen.SetStatus("Loading module 16");
            System.Threading.Thread.Sleep(450);
            SplashScreen.SetStatus("Loading module 17");
            System.Threading.Thread.Sleep(240);
            SplashScreen.SetStatus("Loading module 18");
            System.Threading.Thread.Sleep(90);
            #endregion

            Application.Run(new Form1());
        }
    }
}
