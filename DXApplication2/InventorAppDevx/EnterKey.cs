using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace InventorAppDevx
{
    public partial class EnterKey : DevExpress.XtraEditors.XtraForm
    {
        public EnterKey()
        {
            InitializeComponent();
        }
 

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKey.Text))
            {
                if (txtKey.Text == Properties.Settings.Default.Key)
                {
                    Properties.Settings.Default.control = false;
                    Properties.Settings.Default.Key = "Y65H-HB56-09CA";
                    Properties.Settings.Default.Save();
                    XtraMessageBox.Show("Product Key is valid.Thank you:)", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    XtraMessageBox.Show("Wrong Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                XtraMessageBox.Show("Fill the text.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
       
        }

        //private void EnterKey_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    //if (Properties.Settings.Default.control && Properties.Settings.Default.trialNumber==0)
        //    //{
        //    //    Application.Exit();
        //    //    return;
        //    //}
        //}

        private void EnterKey_Load(object sender, EventArgs e)
        {

        }
    }
}