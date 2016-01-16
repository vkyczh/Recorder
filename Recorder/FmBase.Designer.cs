namespace Recorder
{
    partial class FmBase
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
            this.pTitltle = new System.Windows.Forms.Panel();
            this.lbClose = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pContainer = new System.Windows.Forms.Panel();
            this.pTitltle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitltle
            // 
            this.pTitltle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(87)))), ((int)(((byte)(168)))));
            this.pTitltle.Controls.Add(this.lbClose);
            this.pTitltle.Controls.Add(this.lbTitle);
            this.pTitltle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitltle.Location = new System.Drawing.Point(0, 0);
            this.pTitltle.Margin = new System.Windows.Forms.Padding(0);
            this.pTitltle.Name = "pTitltle";
            this.pTitltle.Size = new System.Drawing.Size(516, 32);
            this.pTitltle.TabIndex = 0;
            // 
            // lbClose
            // 
            this.lbClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbClose.Image = global::Recorder.Properties.Resources.iconfont_close;
            this.lbClose.Location = new System.Drawing.Point(484, 0);
            this.lbClose.Margin = new System.Windows.Forms.Padding(5);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(32, 32);
            this.lbClose.TabIndex = 2;
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            this.lbClose.MouseEnter += new System.EventHandler(this.lbClose_MouseEnter);
            this.lbClose.MouseLeave += new System.EventHandler(this.lbClose_MouseLeave);
            // 
            // lbTitle
            // 
            this.lbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(516, 32);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "标题";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pContainer
            // 
            this.pContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(0, 32);
            this.pContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(516, 373);
            this.pContainer.TabIndex = 1;
            // 
            // FmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 405);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pTitltle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmBase";
            this.Text = "FmBase";
            this.pTitltle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitltle;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbClose;
    }
}