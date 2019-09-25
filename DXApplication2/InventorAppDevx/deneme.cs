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
    public partial class deneme : DevExpress.XtraEditors.XtraForm
    {
        public deneme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model mdl = new Model();
            mdl.MdiParent = this;
            mdl.Show();
      
        }
    }
}