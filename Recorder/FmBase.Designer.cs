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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmBase));
            this.pTitltle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucBtnMinimize = new Recorder.UCButton();
            this.ucBtnSize = new Recorder.UCButton();
            this.ucBtnClose = new Recorder.UCButton();
            this.pTitltle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitltle
            // 
            this.pTitltle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(87)))), ((int)(((byte)(168)))));
            this.pTitltle.Controls.Add(this.panel1);
            this.pTitltle.Controls.Add(this.ucBtnMinimize);
            this.pTitltle.Controls.Add(this.ucBtnSize);
            this.pTitltle.Controls.Add(this.ucBtnClose);
            this.pTitltle.Controls.Add(this.lbTitle);
            this.pTitltle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitltle.Location = new System.Drawing.Point(0, 0);
            this.pTitltle.Margin = new System.Windows.Forms.Padding(0);
            this.pTitltle.Name = "pTitltle";
            this.pTitltle.Size = new System.Drawing.Size(516, 32);
            this.pTitltle.TabIndex = 0;
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
            this.lbTitle.Padding = new System.Windows.Forms.Padding(40, 2, 2, 2);
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
            // panel1
            // 
            this.panel1.BackgroundImage = global::Recorder.Properties.Resources.record;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(7, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 25);
            this.panel1.TabIndex = 7;
            // 
            // ucBtnMinimize
            // 
            this.ucBtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucBtnMinimize.InnerBackgroundImage = global::Recorder.Properties.Resources.minmize;
            this.ucBtnMinimize.Location = new System.Drawing.Point(420, 0);
            this.ucBtnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnMinimize.Name = "ucBtnMinimize";
            this.ucBtnMinimize.Padding = new System.Windows.Forms.Padding(8);
            this.ucBtnMinimize.Size = new System.Drawing.Size(32, 32);
            this.ucBtnMinimize.TabIndex = 6;
            this.ucBtnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnMinimize.UCText = "";
            this.ucBtnMinimize.Click += new System.EventHandler(this.ucBtnMinimize_Click);
            // 
            // ucBtnSize
            // 
            this.ucBtnSize.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucBtnSize.InnerBackgroundImage = global::Recorder.Properties.Resources.downResize;
            this.ucBtnSize.Location = new System.Drawing.Point(452, 0);
            this.ucBtnSize.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnSize.Name = "ucBtnSize";
            this.ucBtnSize.Padding = new System.Windows.Forms.Padding(8);
            this.ucBtnSize.Size = new System.Drawing.Size(32, 32);
            this.ucBtnSize.TabIndex = 5;
            this.ucBtnSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnSize.UCText = "";
            this.ucBtnSize.Click += new System.EventHandler(this.ucBtnSize_Click);
            // 
            // ucBtnClose
            // 
            this.ucBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucBtnClose.InnerBackgroundImage = global::Recorder.Properties.Resources.iconfont_close;
            this.ucBtnClose.Location = new System.Drawing.Point(484, 0);
            this.ucBtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnClose.Name = "ucBtnClose";
            this.ucBtnClose.Padding = new System.Windows.Forms.Padding(8);
            this.ucBtnClose.Size = new System.Drawing.Size(32, 32);
            this.ucBtnClose.TabIndex = 4;
            this.ucBtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnClose.UCText = "";
            this.ucBtnClose.Click += new System.EventHandler(this.ucBtnClose_Click);
            // 
            // FmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 405);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pTitltle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmBase";
            this.Text = "FmBase";
            this.SizeChanged += new System.EventHandler(this.FmBase_SizeChanged);
            this.pTitltle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitltle;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Label lbTitle;
        private UCButton ucBtnClose;
        private UCButton ucBtnSize;
        private UCButton ucBtnMinimize;
        private System.Windows.Forms.Panel panel1;
    }
}