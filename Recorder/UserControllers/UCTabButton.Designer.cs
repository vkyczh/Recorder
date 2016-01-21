namespace Recorder.UserControllers
{
    partial class UCTabButton
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ucBtnClose = new Recorder.UCButton();
            this.pContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.Size = new System.Drawing.Size(105, 24);
            this.lbText.MouseEnter += new System.EventHandler(this.lbText_MouseEnter);
            this.lbText.MouseLeave += new System.EventHandler(this.lbText_MouseLeave);
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.ucBtnClose);
            this.pContainer.Location = new System.Drawing.Point(0, 0);
            this.pContainer.Size = new System.Drawing.Size(105, 24);
            this.pContainer.Controls.SetChildIndex(this.lbText, 0);
            this.pContainer.Controls.SetChildIndex(this.ucBtnClose, 0);
            // 
            // ucBtnClose
            // 
            this.ucBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucBtnClose.InnerBackgroundImage = global::Recorder.Properties.Resources.iconfont_close;
            this.ucBtnClose.Location = new System.Drawing.Point(81, 0);
            this.ucBtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnClose.Name = "ucBtnClose";
            this.ucBtnClose.Padding = new System.Windows.Forms.Padding(5);
            this.ucBtnClose.Size = new System.Drawing.Size(24, 24);
            this.ucBtnClose.TabIndex = 1;
            this.ucBtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnClose.Tip = null;
            this.ucBtnClose.UCText = "";
            this.ucBtnClose.Visible = false;
            this.ucBtnClose.Click += new System.EventHandler(this.ucBtnClose_Click);
            // 
            // UCTabButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UCTabButton";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(105, 24);
            this.pContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCButton ucBtnClose;

    }
}
