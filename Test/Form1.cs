using MDH.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        private bool m_bLayoutCalled = false;
        private DateTime m_dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            if (m_bLayoutCalled == false)
            {
                m_bLayoutCalled = true;
                m_dt = DateTime.Now;
                this.Activate();
                SplashScreen.CloseForm();
            }
        }

        void SaveData()
        {
            for (int i = 0; i <= 500; i++)
            {
                Thread.Sleep(10);//simulator
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (WaitForm waitForm = new WaitForm(SaveData))
            {
                waitForm.ShowDialog(this);
            }
        }

        private void Popup_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show(new NotImplementedException().Message);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();
            
            popup.TitleText = "BE HAPPY";
            popup.ContentText = "Thank you " + popup.Delay;
            popup.Delay = int.MaxValue;
            popup.Image = Properties.Resources.info;
            popup.ShowCloseButton = true;
            popup.ShowGrip = true;
            popup.ShowOptionsButton = true;
            popup.OptionsMenu = contextMenuStrip1;
            popup.Click += Popup_Click;
            popup.Popup();// show
        }
        
    }
}
