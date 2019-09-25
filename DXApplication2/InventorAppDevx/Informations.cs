using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace InventorAppDevx
{
    public partial class Informations : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Informations()
        {
            InitializeComponent();
        }

        private void Informations_Load(object sender, EventArgs e)
        {
            lblLastEntered.Text = Properties.Settings.Default.lastEnteredDate.ToString();
        }
    }
}