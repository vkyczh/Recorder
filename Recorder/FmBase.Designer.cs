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
            this.pTitleTop = new System.Windows.Forms.Panel();
            this.pTitleLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pTitleRight = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pContainer = new System.Windows.Forms.Panel();
            this.pBorderBottom = new System.Windows.Forms.Panel();
            this.pBorderRight = new System.Windows.Forms.Panel();
            this.pBorderRightBottom = new System.Windows.Forms.Panel();
            this.pBorderLeft = new System.Windows.Forms.Panel();
            this.pBorderLeftDottom = new System.Windows.Forms.Panel();
            this.ucBtnNail = new Recorder.UCButton();
            this.ucBtnMinimize = new Recorder.UCButton();
            this.ucBtnSize = new Recorder.UCButton();
            this.ucBtnClose = new Recorder.UCButton();
            this.pTitltle.SuspendLayout();
            this.pContainer.SuspendLayout();
            this.pBorderRight.SuspendLayout();
            this.pBorderLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitltle
            // 
            this.pTitltle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(87)))), ((int)(((byte)(168)))));
            this.pTitltle.Controls.Add(this.pTitleTop);
            this.pTitltle.Controls.Add(this.pTitleLeft);
            this.pTitltle.Controls.Add(this.ucBtnNail);
            this.pTitltle.Controls.Add(this.panel1);
            this.pTitltle.Controls.Add(this.ucBtnMinimize);
            this.pTitltle.Controls.Add(this.ucBtnSize);
            this.pTitltle.Controls.Add(this.ucBtnClose);
            this.pTitltle.Controls.Add(this.pTitleRight);
            this.pTitltle.Controls.Add(this.lbTitle);
            this.pTitltle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitltle.Location = new System.Drawing.Point(0, 0);
            this.pTitltle.Margin = new System.Windows.Forms.Padding(0);
            this.pTitltle.Name = "pTitltle";
            this.pTitltle.Size = new System.Drawing.Size(516, 32);
            this.pTitltle.TabIndex = 0;
            // 
            // pTitleTop
            // 
            this.pTitleTop.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.pTitleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitleTop.Location = new System.Drawing.Point(3, 0);
            this.pTitleTop.Margin = new System.Windows.Forms.Padding(0);
            this.pTitleTop.Name = "pTitleTop";
            this.pTitleTop.Size = new System.Drawing.Size(382, 3);
            this.pTitleTop.TabIndex = 8;
            this.pTitleTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitleTop_MouseDown);
            this.pTitleTop.MouseLeave += new System.EventHandler(this.ReleaseResizeStatusHandle);
            this.pTitleTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pResize_MouseMove);
            this.pTitleTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReleaseResizeStatusHandle);
            // 
            // pTitleLeft
            // 
            this.pTitleLeft.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pTitleLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pTitleLeft.Location = new System.Drawing.Point(0, 0);
            this.pTitleLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pTitleLeft.Name = "pTitleLeft";
            this.pTitleLeft.Size = new System.Drawing.Size(3, 32);
            this.pTitleLeft.TabIndex = 0;
            this.pTitleLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitleLeft_MouseDown);
            this.pTitleLeft.MouseLeave += new System.EventHandler(this.ReleaseResizeStatusHandle);
            this.pTitleLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pResize_MouseMove);
            this.pTitleLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReleaseResizeStatusHandle);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Recorder.Properties.Resources.record;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(7, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 25);
            this.panel1.TabIndex = 6;
            // 
            // pTitleRight
            // 
            this.pTitleRight.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.pTitleRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pTitleRight.Location = new System.Drawing.Point(513, 0);
            this.pTitleRight.Margin = new System.Windows.Forms.Padding(0);
            this.pTitleRight.Name = "pTitleRight";
            this.pTitleRight.Size = new System.Drawing.Size(3, 32);
            this.pTitleRight.TabIndex = 1;
            this.pTitleRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitleRight_MouseDown);
            this.pTitleRight.MouseLeave += new System.EventHandler(this.ReleaseResizeStatusHandle);
            this.pTitleRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pResize_MouseMove);
            this.pTitleRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReleaseResizeStatusHandle);
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new System.Windows.Forms.Padding(40, 2, 2, 2);
            this.lbTitle.Size = new System.Drawing.Size(516, 32);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "标题";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.pBorderBottom);
            this.pContainer.Controls.Add(this.pBorderRight);
            this.pContainer.Controls.Add(this.pBorderLeft);
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(0, 32);
            this.pContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(516, 373);
            this.pContainer.TabIndex = 1;
            // 
            // pBorderBottom
            // 
            this.pBorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(87)))), ((int)(((byte)(168)))));
            this.pBorderBottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.pBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBorderBottom.Location = new System.Drawing.Point(3, 370);
            this.pBorderBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pBorderBottom.Name = "pBorderBottom";
            this.pBorderBottom.Size = new System.Drawing.Size(510, 3);
            this.pBorderBottom.TabIndex = 2;
            this.pBorderBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBorderBottom_MouseDown);
            this.pBorderBottom.MouseLeave += new System.EventHandler(this.ReleaseResizeStatusHandle);
            this.pBorderBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pResize_MouseMove);
            this.pBorderBottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReleaseResizeStatusHandle);
            // 
            // pBorderRight
            // 
            this.pBorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(87)))), ((int)(((byte)(168)))));
            this.pBorderRight.Controls.Add(this.pBorderRightBottom);
            this.pBorderRight.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.pBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBorderRight.Location = new System.Drawing.Point(513, 0);
            this.pBorderRight.Margin = new System.Windows.Forms.Padding(0);
            this.pBorderRight.Name = "pBorderRight";
            this.pBorderRight.Size = new System.Drawing.Size(3, 373);
            this.pBorderRight.TabIndex = 1;
            this.pBorderRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBorderRight_MouseDown);
            this.pBorderRight.MouseLeave += new System.EventHandler(this.ReleaseResizeStatusHandle);
            this.pBorderRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pResize_MouseMove);
            this.pBorderRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReleaseResizeStatusHandle);
            // 
            // pBorderRightBottom
            // 
            this.pBorderRightBottom.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pBorderRightBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBorderRightBottom.Location = new System.Drawing.Point(0, 341);
            this.pBorderRightBottom.Name = "pBorderRightBottom";
            this.pBorderRightBottom.Size = new System.Drawing.Size(3, 32);
            this.pBorderRightBottom.TabIndex = 3;
            this.pBorderRightBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBorderRightBottom_MouseDown);
            this.pBorderRightBottom.MouseLeave += new System.EventHandler(this.ReleaseResizeStatusHandle);
            this.pBorderRightBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pResize_MouseMove);
            this.pBorderRightBottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReleaseResizeStatusHandle);
            // 
            // pBorderLeft
            // 
            this.pBorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(87)))), ((int)(((byte)(168)))));
            this.pBorderLeft.Controls.Add(this.pBorderLeftDottom);
            this.pBorderLeft.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.pBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBorderLeft.Location = new System.Drawing.Point(0, 0);
            this.pBorderLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pBorderLeft.Name = "pBorderLeft";
            this.pBorderLeft.Size = new System.Drawing.Size(3, 373);
            this.pBorderLeft.TabIndex = 0;
            this.pBorderLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBorderLeft_MouseDown);
            this.pBorderLeft.MouseLeave += new System.EventHandler(this.ReleaseResizeStatusHandle);
            this.pBorderLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pResize_MouseMove);
            this.pBorderLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReleaseResizeStatusHandle);
            // 
            // pBorderLeftDottom
            // 
            this.pBorderLeftDottom.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.pBorderLeftDottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBorderLeftDottom.Location = new System.Drawing.Point(0, 341);
            this.pBorderLeftDottom.Margin = new System.Windows.Forms.Padding(0);
            this.pBorderLeftDottom.Name = "pBorderLeftDottom";
            this.pBorderLeftDottom.Size = new System.Drawing.Size(3, 32);
            this.pBorderLeftDottom.TabIndex = 0;
            this.pBorderLeftDottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBorderLeftDottom_MouseDown);
            this.pBorderLeftDottom.MouseLeave += new System.EventHandler(this.ReleaseResizeStatusHandle);
            this.pBorderLeftDottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pResize_MouseMove);
            this.pBorderLeftDottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReleaseResizeStatusHandle);
            // 
            // ucBtnNail
            // 
            this.ucBtnNail.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnNail.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucBtnNail.InnerBackgroundImage = global::Recorder.Properties.Resources.nail;
            this.ucBtnNail.Location = new System.Drawing.Point(385, 0);
            this.ucBtnNail.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnNail.Name = "ucBtnNail";
            this.ucBtnNail.Padding = new System.Windows.Forms.Padding(8);
            this.ucBtnNail.Size = new System.Drawing.Size(32, 32);
            this.ucBtnNail.TabIndex = 5;
            this.ucBtnNail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnNail.Tip = "最前";
            this.ucBtnNail.UCText = "";
            this.ucBtnNail.Click += new System.EventHandler(this.ucBtnNail_Click);
            // 
            // ucBtnMinimize
            // 
            this.ucBtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucBtnMinimize.InnerBackgroundImage = global::Recorder.Properties.Resources.minmize;
            this.ucBtnMinimize.Location = new System.Drawing.Point(417, 0);
            this.ucBtnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnMinimize.Name = "ucBtnMinimize";
            this.ucBtnMinimize.Padding = new System.Windows.Forms.Padding(8);
            this.ucBtnMinimize.Size = new System.Drawing.Size(32, 32);
            this.ucBtnMinimize.TabIndex = 4;
            this.ucBtnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnMinimize.Tip = "最小化";
            this.ucBtnMinimize.UCText = "";
            this.ucBtnMinimize.Click += new System.EventHandler(this.ucBtnMinimize_Click);
            // 
            // ucBtnSize
            // 
            this.ucBtnSize.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucBtnSize.InnerBackgroundImage = global::Recorder.Properties.Resources.downResize;
            this.ucBtnSize.Location = new System.Drawing.Point(449, 0);
            this.ucBtnSize.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnSize.Name = "ucBtnSize";
            this.ucBtnSize.Padding = new System.Windows.Forms.Padding(8);
            this.ucBtnSize.Size = new System.Drawing.Size(32, 32);
            this.ucBtnSize.TabIndex = 3;
            this.ucBtnSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnSize.Tip = "最大化";
            this.ucBtnSize.UCText = "";
            this.ucBtnSize.Click += new System.EventHandler(this.ucBtnSize_Click);
            // 
            // ucBtnClose
            // 
            this.ucBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucBtnClose.InnerBackgroundImage = global::Recorder.Properties.Resources.iconfont_close;
            this.ucBtnClose.Location = new System.Drawing.Point(481, 0);
            this.ucBtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnClose.Name = "ucBtnClose";
            this.ucBtnClose.Padding = new System.Windows.Forms.Padding(8);
            this.ucBtnClose.Size = new System.Drawing.Size(32, 32);
            this.ucBtnClose.TabIndex = 2;
            this.ucBtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnClose.Tip = "关闭";
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmBase";
            this.Load += new System.EventHandler(this.FmBase_Load);
            this.SizeChanged += new System.EventHandler(this.FmBase_SizeChanged);
            this.pTitltle.ResumeLayout(false);
            this.pContainer.ResumeLayout(false);
            this.pBorderRight.ResumeLayout(false);
            this.pBorderLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitltle;
        private System.Windows.Forms.Label lbTitle;
        private UCButton ucBtnClose;
        private UCButton ucBtnSize;
        private UCButton ucBtnMinimize;
        private System.Windows.Forms.Panel panel1;
        private UCButton ucBtnNail;
        private System.Windows.Forms.Panel pBorderLeft;
        private System.Windows.Forms.Panel pBorderBottom;
        private System.Windows.Forms.Panel pBorderRight;
        private System.Windows.Forms.Panel pTitleLeft;
        private System.Windows.Forms.Panel pTitleTop;
        private System.Windows.Forms.Panel pTitleRight;
        private System.Windows.Forms.Panel pBorderRightBottom;
        private System.Windows.Forms.Panel pBorderLeftDottom;
        protected System.Windows.Forms.Panel pContainer;
    }
}