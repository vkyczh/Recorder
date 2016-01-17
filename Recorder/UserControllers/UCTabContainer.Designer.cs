namespace Recorder.UserControllers
{
    partial class UCTabContainer
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
            this.pTabButtonContainer = new System.Windows.Forms.Panel();
            this.pTabPageContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pTabButtonContainer
            // 
            this.pTabButtonContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(87)))), ((int)(((byte)(168)))));
            this.pTabButtonContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTabButtonContainer.Location = new System.Drawing.Point(0, 0);
            this.pTabButtonContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pTabButtonContainer.Name = "pTabButtonContainer";
            this.pTabButtonContainer.Size = new System.Drawing.Size(524, 24);
            this.pTabButtonContainer.TabIndex = 0;
            // 
            // pTabPageContainer
            // 
            this.pTabPageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTabPageContainer.Location = new System.Drawing.Point(0, 24);
            this.pTabPageContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pTabPageContainer.Name = "pTabPageContainer";
            this.pTabPageContainer.Size = new System.Drawing.Size(524, 321);
            this.pTabPageContainer.TabIndex = 1;
            // 
            // UCTabContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pTabPageContainer);
            this.Controls.Add(this.pTabButtonContainer);
            this.Name = "UCTabContainer";
            this.Size = new System.Drawing.Size(524, 345);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTabButtonContainer;
        private System.Windows.Forms.Panel pTabPageContainer;
    }
}
