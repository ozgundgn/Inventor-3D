using DevExpress.XtraEditors;
using Inventor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventorAppDevx
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
  
        public Form1()
        {
            InitializeComponent();
        }
        DateTime sonGiris = DateTime.Now;
        private void Form1_Load(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();

            Model mdl = new Model();
            mdl.MdiParent = this;
            mdl.Show();
            // eger propertiesler dolmuşşsa enterkey sayfasını açılıp buraya donuyor;

            if(Properties.Settings.Default.control && Properties.Settings.Default.trialNumber == 0)
            {
                System.Windows.Forms.Application.Exit();
                return;
            }
            splashScreenManager1.CloseWaitForm();
            Informations a = new Informations();
            a.lblLastEntered.Text = Properties.Settings.Default.lastEnteredDate.ToString();
          
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
          
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.Name == "Model")
                {
                    form.Activate();
                    return;
                }
            }
            splashScreenManager1.ShowWaitForm();
            Model mdl = new Model();
            mdl.Text = "Model";
            mdl.Name = "Model";
            mdl.MdiParent = this;
            mdl.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.Name == "Informations")
                {
                    form.Activate();
                    return;
                }
            }

            splashScreenManager1.ShowWaitForm();
            Informations info = new Informations();
            info.Text = "Informations";
            info.MdiParent = this;
            info.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.lastEnteredDate = sonGiris;
            Properties.Settings.Default.Save();
        }
    }
}
