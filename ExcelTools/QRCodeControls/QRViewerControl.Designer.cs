namespace ExcelTools.QRCodeControls
{
    partial class QRViewerControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.lbQRCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQRCode
            // 
            this.pbQRCode.Location = new System.Drawing.Point(0, 0);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(318, 240);
            this.pbQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQRCode.TabIndex = 0;
            this.pbQRCode.TabStop = false;
            // 
            // lbQRCode
            // 
            this.lbQRCode.AutoSize = true;
            this.lbQRCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbQRCode.Location = new System.Drawing.Point(90, 253);
            this.lbQRCode.Name = "lbQRCode";
            this.lbQRCode.Size = new System.Drawing.Size(139, 27);
            this.lbQRCode.TabIndex = 1;
            this.lbQRCode.Text = "二维码值：***";
            // 
            // QRViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbQRCode);
            this.Controls.Add(this.pbQRCode);
            this.Name = "QRViewerControl";
            this.Size = new System.Drawing.Size(324, 300);
            this.VisibleChanged += new System.EventHandler(this.QRViewerControl_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQRCode;
        private System.Windows.Forms.Label lbQRCode;
    }
}
