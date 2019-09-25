using DevExpress.XtraEditors;
using Inventor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace InventorAppDevx
{
    public partial class Model : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Inventor.Application m_InventorApp;

        UserParameters userParameters, baseParameters;
        PartDocument myDocument;

        MyInventorHelper myInventorHelper = new MyInventorHelper();
        ArrayList errorProvider;
        public string CompatibleWithSeo(string IncomingText)
        {
            System.Globalization.CultureInfo Dil = new System.Globalization.CultureInfo("tr-TR");

            IncomingText = IncomingText.Replace("ş", "s");
            IncomingText = IncomingText.Replace("Ş", "s");
            IncomingText = IncomingText.Replace("İ", "i");
            IncomingText = IncomingText.Replace("I", "i");
            IncomingText = IncomingText.Replace("ı", "i");
            IncomingText = IncomingText.Replace("ö", "o");
            IncomingText = IncomingText.Replace("Ö", "o");
            IncomingText = IncomingText.Replace("ü", "u");
            IncomingText = IncomingText.Replace("Ü", "u");
            IncomingText = IncomingText.Replace("Ç", "c");
            IncomingText = IncomingText.Replace("ç", "c");
            IncomingText = IncomingText.Replace("ğ", "g");
            IncomingText = IncomingText.Replace("Ğ", "g");
            IncomingText = IncomingText.Replace(" ", "-");
            IncomingText = IncomingText.Replace("---", "-");
            IncomingText = IncomingText.Replace("?", "");
            IncomingText = IncomingText.Replace("/", "");
            IncomingText = IncomingText.Replace(".", "");
            IncomingText = IncomingText.Replace("'", "");
            IncomingText = IncomingText.Replace("#", "");
            IncomingText = IncomingText.Replace("%", "");
            IncomingText = IncomingText.Replace("&", "");
            IncomingText = IncomingText.Replace("*", "");
            IncomingText = IncomingText.Replace("!", "");
            IncomingText = IncomingText.Replace("@", "");
            IncomingText = IncomingText.Replace("+", "");

            IncomingText = IncomingText.ToLower();
            IncomingText = IncomingText.Trim();
            return IncomingText;
        }
        public string Splitter(string text)
        {
            string[] array;
            if (text.Contains(" "))
            {

            }

            array = text.Split(' ');

            return array[0];
        }
        public static string MD5eDonustur(string metin)
        {
            MD5CryptoServiceProvider pwd = new MD5CryptoServiceProvider();
            return Sifrele(metin, pwd);
        }
        private static string Sifrele(string metin, HashAlgorithm alg)
        {
            byte[] byteDegeri = System.Text.Encoding.UTF8.GetBytes(metin);
            byte[] sifreliByte = alg.ComputeHash(byteDegeri);
            return Convert.ToBase64String(sifreliByte);
        }


        public Model()
        {
            InitializeComponent();
        }

        private void btnBringModel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();


            m_InventorApp = myInventorHelper.getInventorApp();
            if (m_InventorApp.OpenDocumentsDisplay)
            {
                m_InventorApp.Documents.CloseAll();
            }
            myDocument = myInventorHelper.openDocument(m_InventorApp);

            userParameters = myDocument.ComponentDefinition.Parameters.UserParameters;


            string A_F_İ_D = userParameters["A_F_İ_D"].Expression;
            string A_F_O_D = userParameters["A_F_O_D"].Expression;
            string A_F_T = userParameters["A_F_T"].Expression;
            string A_F_P = userParameters["A_F_P"].Expression;

            txtAfid.EditValue = Splitter(A_F_İ_D);
            txtAfod.EditValue = Splitter(A_F_O_D);
            txtAft.EditValue = Splitter(A_F_T);
            txtAfp.EditValue = Splitter(A_F_P);

            splashScreenManager1.CloseWaitForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.trialNumber = 3;
            Properties.Settings.Default.control = true;
            Properties.Settings.Default.Save();
        }


        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void Model_Load(object sender, EventArgs e)
        {
            
            if (!Properties.Settings.Default.control)
            {


            }
            else if (Properties.Settings.Default.control && Properties.Settings.Default.trialNumber == 0)
            {
                EnterKey ent = new EnterKey();
                ent.ShowDialog();
          

            }
            else if (Properties.Settings.Default.control)
            {

                SortedList<int, string> sifreler = new SortedList<int, string>();

                for (int i = 0; i < 3; i++)
                {
                    sifreler.Add(i, MD5eDonustur(i.ToString()));
                    
                }
                int sayi = -1;
               
                foreach (KeyValuePair<int, string> item in sifreler.Reverse())
                {
                    if (System.IO.Directory.Exists(System.IO.Path.GetTempPath() + item.Value.ToString()))
                    {
                        sayi = item.Key;
                    }
                }
                if (sayi !=-1)
                {
                    Properties.Settings.Default.trialNumber = sayi;
                    Properties.Settings.Default.Save();
                }
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (m_InventorApp == null)
            {
                XtraMessageBox.Show("To open the Inventor, click the 'Bring Model' button", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            if (Properties.Settings.Default.control)
            {

                if (Properties.Settings.Default.trialNumber == 0)
                {
                    XtraMessageBox.Show("Product has expired.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                    System.Windows.Forms.Application.Exit();

                    return;
                }
                Properties.Settings.Default.trialNumber--;
                Properties.Settings.Default.Save();
                int sayi = Properties.Settings.Default.trialNumber;
         

                string dirName = MD5eDonustur(sayi.ToString());
                string h = System.IO.Path.GetTempPath() + dirName;
                System.IO.Directory.CreateDirectory(h);

                DialogResult res = XtraMessageBox.Show("Last " + sayi + " entries left. To enter the application key click OK.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (res == DialogResult.OK)
                {
                    EnterKey ent = new EnterKey();
                    ent.ShowDialog();
                }
            }


            //userParameters.AddByExpression("NewParam2", "3 in", UnitsTypeEnum.kDefaultDisplayLengthUnits);
            errorProvider = new ArrayList();

            foreach (Control cnt in groupControl1.Controls)
            {

                if (cnt.GetType().ToString() == typeof(DevExpress.XtraEditors.TextEdit).ToString())
                {

                    if (string.IsNullOrEmpty(cnt.Text))
                    {
                        errorProvider.Add(cnt.Tag);
                    }
                    else if (cnt.Tag.ToString() != "Model Name" && Convert.ToDouble(cnt.Text) == 0)
                    {
                        errorProvider.Add(cnt.Tag);
                    }

                }
            }
            if (errorProvider.Count > 0)
            {
                object[] array = errorProvider.ToArray();
                string message = string.Join(",", array);
                XtraMessageBox.Show("Please fill the " + message + " fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            splashScreenManager1.ShowWaitForm();

            if (m_InventorApp.ActiveView == null)
            {
                myDocument = myInventorHelper.openDocument(m_InventorApp);

                userParameters = myDocument.ComponentDefinition.Parameters.UserParameters;
            }

            userParameters["A_F_İ_D"].Value = Convert.ToDouble(txtAfid.Text) / 10;
            userParameters["A_F_O_D"].Value = Convert.ToDouble(txtAfod.Text) / 10;
            userParameters["A_F_T"].Value = Convert.ToDouble(txtAft.Text) / 10;
            userParameters["A_F_P"].Value = Convert.ToDouble(txtAfp.Text) / 10;

            string modelName = CompatibleWithSeo(txtModelName.EditValue.ToString());

            var newDocument = (SheetMetalComponentDefinition)myDocument.ComponentDefinition;

            newDocument.UseSheetMetalStyleThickness = false;
            // Get a reference to the parameter controlling the thickness.
            Parameter oThicknessParam = default(Parameter);
            oThicknessParam = newDocument.Thickness;
            oThicknessParam.Value = Convert.ToDouble(txtAft.EditValue.ToString()) / 10;

            splashScreenManager1.SetWaitFormDescription(" The Parameters are being read");

            if (!Directory.Exists("C:\\FGInventor"))
                Directory.CreateDirectory("C:\\FGInventor");

            Random rn = new Random();
            int number = rn.Next(0, 1000);

            if (!System.IO.Directory.Exists("C:\\FGInventor\\" + modelName + "-" + number))
            {
                System.IO.Directory.CreateDirectory("C:\\FGInventor\\" + modelName + "-" + number);
            }

            FlatPattern flat = newDocument.FlatPattern;
            DataIO dt = newDocument.DataIO;
            myDocument.Update();
            myDocument.SaveAs("C:\\FGInventor\\" + modelName + "-" + number + "\\" + modelName + ".ipt", true);

            dt.WriteDataToFile("FLAT PATTERN DXF?AcadVersion=2000", "C:\\FGInventor\\" + modelName + "-" + number + "\\" + modelName + ".dwg"); //AcadVersion=R12 sadece dxf için

            dt.WriteDataToFile("FLAT PATTERN DXF?AcadVersion=R12", "C:\\FGInventor\\" + modelName + "-" + number + "\\" + modelName + ".dxf"); //AcadVersion=R12 sadece dxf için       

            // kalıp çzellikleri


            PartDocument baseDocument;
            baseDocument = myInventorHelper.openDocument(m_InventorApp, "Bending_Mold");

            baseParameters = baseDocument.ComponentDefinition.Parameters.UserParameters;

            if (baseParameters != null)
            {
                baseParameters["A_F_İ_D"].Value = Convert.ToDouble(txtAfid.Text) / 10;
                baseParameters["A_F_O_D"].Value = Convert.ToDouble(txtAfod.Text) / 10;
                baseParameters["A_F_T"].Value = Convert.ToDouble(txtAft.Text) / 10;
                baseParameters["A_F_P"].Value = Convert.ToDouble(txtAfp.Text) / 10;



                var newBaseDocument = (SheetMetalComponentDefinition)myDocument.ComponentDefinition;
                newBaseDocument.UseSheetMetalStyleThickness = false;

                Parameter obaseThicknessParam = default(Parameter);
                obaseThicknessParam = newBaseDocument.Thickness;

                obaseThicknessParam.Value = Convert.ToDouble(txtAft.EditValue.ToString()) / 10;

                splashScreenManager1.SetWaitFormDescription("Models are being saved.");
                FlatPattern baseFlat = newBaseDocument.FlatPattern;
                DataIO dtBase = newBaseDocument.DataIO;
                baseDocument.Update();
                baseDocument.SaveAs("C:\\FGInventor\\" + modelName + "-" + number + "\\Base-" + modelName + ".ipt", true);

                dtBase.WriteDataToFile("FLAT PATTERN DXF?AcadVersion=2000", "C:\\FGInventor\\" + modelName + "-" + number + "\\Base-" + modelName + ".dwg"); //AcadVersion=R12 sadece dxf için

                dtBase.WriteDataToFile("FLAT PATTERN DXF?AcadVersion=R12", "C:\\FGInventor\\" + modelName + "-" + number + "\\Base-" + modelName + ".dxf"); //AcadVersion=R12 sadece dxf için       


                newDocument.FlatPattern.ExitEdit();
                splashScreenManager1.CloseWaitForm();

                //Inventor.View view = m_InventorApp.ActiveView;
                //view.SaveAsBitmap(CommonLayer.DirectoryPath + "\\FGInventor\\" + modelName + "-" + number + "\\Base-" + modelName + ".jpg", 700, 500);

                //add file for trail version control



                XtraMessageBox.Show("Files are created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);


            }
            else
            {
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("Parameters are empty!");
            }
        }

    }
}