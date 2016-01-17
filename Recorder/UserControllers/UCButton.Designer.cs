namespace Recorder
{
    partial class UCButton
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
            this.components = new System.ComponentModel.Container();
            this.lbText = new System.Windows.Forms.Label();
            this.pContainer = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.BackColor = System.Drawing.Color.Transparent;
            this.lbText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbText.ForeColor = System.Drawing.Color.White;
            this.lbText.Location = new System.Drawing.Point(0, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(89, 24);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "UCButton";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbText.Click += new System.EventHandler(this.lbText_Click);
            this.lbText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UCButton_MouseDown);
            this.lbText.MouseEnter += new System.EventHandler(this.UCButton_MouseEnter);
            this.lbText.MouseLeave += new System.EventHandler(this.UCButton_MouseLeave);
            this.lbText.MouseHover += new System.EventHandler(this.lbText_MouseHover);
            this.lbText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbText_MouseMove);
            this.lbText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UCButton_MouseUp);
            // 
            // pContainer
            // 
            this.pContainer.BackColor = System.Drawing.Color.Transparent;
            this.pContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pContainer.Controls.Add(this.lbText);
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(8, 8);
            this.pContainer.Margin = new System.Windows.Forms.Padding(5);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(89, 24);
            this.pContainer.TabIndex = 1;
            // 
            // UCButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCButton";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(105, 40);
            this.Click += new System.EventHandler(this.UCButton_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UCButton_MouseDown);
            this.MouseEnter += new System.EventHandler(this.UCButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCButton_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UCButton_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UCButton_MouseUp);
            this.pContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        protected System.Windows.Forms.Label lbText;
        protected System.Windows.Forms.Panel pContainer;

    }
}
