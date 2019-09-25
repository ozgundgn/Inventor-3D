namespace InventorAppDevx
{
    partial class Model
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnBringModel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelName = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.txtAfod = new DevExpress.XtraEditors.TextEdit();
            this.txtAft = new DevExpress.XtraEditors.TextEdit();
            this.txtAfp = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAfid = new DevExpress.XtraEditors.TextEdit();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::InventorAppDevx.WaitForm1), true, true);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnBringModel});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(892, 152);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnBringModel
            // 
            this.btnBringModel.Caption = "Bring Model";
            this.btnBringModel.Id = 1;
            this.btnBringModel.ImageOptions.ImageUri.Uri = "Redo";
            this.btnBringModel.Name = "btnBringModel";
            this.btnBringModel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBringModel_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBringModel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Brings the Default Model";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 537);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(892, 40);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtModelName);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.btnCreate);
            this.groupControl1.Controls.Add(this.txtAfod);
            this.groupControl1.Controls.Add(this.txtAft);
            this.groupControl1.Controls.Add(this.txtAfp);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtAfid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 152);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(892, 385);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Create Custom Model";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(33, 183);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(110, 16);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "(Auger Flight Pitch)";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(33, 84);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(176, 16);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "(Auger Flight Inner Dimension)";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(33, 116);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(178, 16);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "(Auger Flight Outer Dimension)";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 151);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(139, 16);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "(Auger Flight Thickness)";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(744, 242);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 33);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh Properties";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 7.8F);
            this.label6.Location = new System.Drawing.Point(271, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Units of parameters are mm";
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(299, 239);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(173, 22);
            this.txtModelName.TabIndex = 5;
            this.txtModelName.Tag = "Model Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Model Name";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(33, 286);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(455, 49);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtAfod
            // 
            this.txtAfod.EditValue = "";
            this.txtAfod.Location = new System.Drawing.Point(299, 113);
            this.txtAfod.Name = "txtAfod";
            this.txtAfod.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAfod.Properties.Mask.EditMask = "n2";
            this.txtAfod.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAfod.Properties.Mask.PlaceHolder = ' ';
            this.txtAfod.Size = new System.Drawing.Size(173, 22);
            this.txtAfod.TabIndex = 2;
            this.txtAfod.Tag = "A_F_O_D";
            // 
            // txtAft
            // 
            this.txtAft.Location = new System.Drawing.Point(299, 145);
            this.txtAft.Name = "txtAft";
            this.txtAft.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAft.Properties.Mask.EditMask = "n2";
            this.txtAft.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAft.Properties.Mask.PlaceHolder = ' ';
            this.txtAft.Size = new System.Drawing.Size(173, 22);
            this.txtAft.TabIndex = 3;
            this.txtAft.Tag = "A_F_T";
            // 
            // txtAfp
            // 
            this.txtAfp.Location = new System.Drawing.Point(299, 177);
            this.txtAfp.Name = "txtAfp";
            this.txtAfp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAfp.Properties.Mask.EditMask = "n2";
            this.txtAfp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAfp.Properties.Mask.PlaceHolder = ' ';
            this.txtAfp.Size = new System.Drawing.Size(173, 22);
            this.txtAfp.TabIndex = 4;
            this.txtAfp.Tag = "A_F_P";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "A_F_O_D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "A_F_P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "A_F_T";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "A_F_I_D";
            // 
            // txtAfid
            // 
            this.txtAfid.Location = new System.Drawing.Point(299, 81);
            this.txtAfid.Name = "txtAfid";
            this.txtAfid.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAfid.Properties.Mask.EditMask = "n2";
            this.txtAfid.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAfid.Properties.Mask.PlaceHolder = ' ';
            this.txtAfid.Size = new System.Drawing.Size(173, 22);
            this.txtAfid.TabIndex = 1;
            this.txtAfid.Tag = "A_F_I_D";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 577);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Model";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Model";
            this.Load += new System.EventHandler(this.Model_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfid.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnBringModel;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtModelName;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.TextEdit txtAfod;
        private DevExpress.XtraEditors.TextEdit txtAft;
        private DevExpress.XtraEditors.TextEdit txtAfp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtAfid;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}