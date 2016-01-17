namespace Recorder.UserControllers
{
    partial class UCTabPage
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
            this.pTopLine = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pTopLine
            // 
            this.pTopLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.pTopLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTopLine.Location = new System.Drawing.Point(0, 0);
            this.pTopLine.Margin = new System.Windows.Forms.Padding(0);
            this.pTopLine.Name = "pTopLine";
            this.pTopLine.Size = new System.Drawing.Size(395, 4);
            this.pTopLine.TabIndex = 0;
            // 
            // UCTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pTopLine);
            this.Name = "UCTabPage";
            this.Size = new System.Drawing.Size(395, 288);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTopLine;
    }
}
