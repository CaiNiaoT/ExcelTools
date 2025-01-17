﻿namespace ExcelTools
{
    partial class ABCToolsRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ABCToolsRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.qrCodeGroup = this.Factory.CreateRibbonGroup();
            this.btnViewQRCode = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.qrCodeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.qrCodeGroup);
            this.tab1.Label = "ABC工具";
            this.tab1.Name = "tab1";
            // 
            // qrCodeGroup
            // 
            this.qrCodeGroup.Items.Add(this.btnViewQRCode);
            this.qrCodeGroup.Label = "二维码";
            this.qrCodeGroup.Name = "qrCodeGroup";
            // 
            // btnViewQRCode
            // 
            this.btnViewQRCode.Description = "显示二维码";
            this.btnViewQRCode.Label = "显示二维码";
            this.btnViewQRCode.Name = "btnViewQRCode";
            this.btnViewQRCode.SuperTip = "点击显示二维码面板";
            this.btnViewQRCode.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnViewQRCode_Click);
            // 
            // ABCToolsRibbon
            // 
            this.Name = "ABCToolsRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibTest_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.qrCodeGroup.ResumeLayout(false);
            this.qrCodeGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup qrCodeGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnViewQRCode;
    }

    partial class ThisRibbonCollection
    {
        internal ABCToolsRibbon RibTest
        {
            get { return this.GetRibbon<ABCToolsRibbon>(); }
        }
    }
}
