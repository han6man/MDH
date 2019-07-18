/*
 *	Created/modified in 2011 by Simon Baer
 *	
 *  Licensed under the Code Project Open License (CPOL).
 */

using MDH.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            popupNotifier1.TitleText = txtTitle.Text;
            popupNotifier1.ContentText = txtText.Text;
            popupNotifier1.ShowCloseButton = chkClose.Checked;
            popupNotifier1.ShowOptionsButton = chkMenu.Checked;
            popupNotifier1.ShowGrip = chkGrip.Checked;
            popupNotifier1.Delay = int.Parse(txtDelay.Text);
            popupNotifier1.AnimationInterval = int.Parse(txtInterval.Text);
            popupNotifier1.AnimationDuration = int.Parse(txtAnimationDuration.Text);
            popupNotifier1.TitlePadding = new Padding(int.Parse(txtPaddingTitle.Text));
            popupNotifier1.ContentPadding = new Padding(int.Parse(txtPaddingContent.Text));
            popupNotifier1.ImagePadding = new Padding(int.Parse(txtPaddingIcon.Text));
            popupNotifier1.Scroll = chkScroll.Checked;
            
            if (chkIcon.Checked)
            {
                popupNotifier1.Image = Properties.Resources._157_GetPermission_48x48_72;
            }
            else
            {
                popupNotifier1.Image = null;
            }

            popupNotifier1.Popup();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopupNotifier popupNotifier = new PopupNotifier();
            // 
            // popupNotifier
            // 
            popupNotifier.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            popupNotifier.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popupNotifier.ContentText = null;
            popupNotifier.GradientPower = 300;
            popupNotifier.HeaderHeight = 20;
            popupNotifier.Image = null;
            popupNotifier.OptionsMenu = this.contextMenuStrip1;
            popupNotifier.Size = new System.Drawing.Size(400, 100);
            popupNotifier.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            popupNotifier.TitleText = null;
            //
            popupNotifier.TitleText = txtTitle.Text;
            popupNotifier.ContentText = txtText.Text;
            popupNotifier.ShowCloseButton = chkClose.Checked;
            popupNotifier.ShowOptionsButton = chkMenu.Checked;
            popupNotifier.ShowGrip = chkGrip.Checked;
            popupNotifier.Delay = int.Parse(txtDelay.Text);
            popupNotifier.AnimationInterval = int.Parse(txtInterval.Text);
            popupNotifier.AnimationDuration = int.Parse(txtAnimationDuration.Text);
            popupNotifier.TitlePadding = new Padding(int.Parse(txtPaddingTitle.Text));
            popupNotifier.ContentPadding = new Padding(int.Parse(txtPaddingContent.Text));
            popupNotifier.ImagePadding = new Padding(int.Parse(txtPaddingIcon.Text));
            popupNotifier.Scroll = chkScroll.Checked;

            if (chkIcon.Checked)
            {
                popupNotifier.Image = Properties.Resources._157_GetPermission_48x48_72;
            }
            else
            {
                popupNotifier.Image = null;
            }

            popupNotifier.Popup();
        }
    }
}
