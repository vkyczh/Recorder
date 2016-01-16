namespace Recorder
{
    partial class FmMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.pTitle = new System.Windows.Forms.Panel();
            this.lbClose = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pContainer = new System.Windows.Forms.Panel();
            this.pContent = new System.Windows.Forms.Panel();
            this.pPage = new System.Windows.Forms.Panel();
            this.pEdit = new System.Windows.Forms.Panel();
            this.pList = new System.Windows.Forms.Panel();
            this.pRoot = new System.Windows.Forms.Panel();
            this.pTool = new System.Windows.Forms.Panel();
            this.lbList = new System.Windows.Forms.Label();
            this.lbEdit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pTitle.SuspendLayout();
            this.pContainer.SuspendLayout();
            this.pContent.SuspendLayout();
            this.pPage.SuspendLayout();
            this.pTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(87)))), ((int)(((byte)(168)))));
            this.pTitle.Controls.Add(this.panel1);
            this.pTitle.Controls.Add(this.lbClose);
            this.pTitle.Controls.Add(this.lbTitle);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(325, 37);
            this.pTitle.TabIndex = 1;
            // 
            // lbClose
            // 
            this.lbClose.Image = global::Recorder.Properties.Resources.iconfont_close;
            this.lbClose.Location = new System.Drawing.Point(281, 3);
            this.lbClose.Margin = new System.Windows.Forms.Padding(5);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(39, 32);
            this.lbClose.TabIndex = 1;
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
            this.lbTitle.Size = new System.Drawing.Size(325, 37);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "记录工具";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseDown);
            this.lbTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseUp);
            // 
            // pContainer
            // 
            this.pContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pContainer.Controls.Add(this.pContent);
            this.pContainer.Controls.Add(this.pTool);
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(0, 37);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(325, 503);
            this.pContainer.TabIndex = 2;
            // 
            // pContent
            // 
            this.pContent.Controls.Add(this.pPage);
            this.pContent.Controls.Add(this.pRoot);
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 40);
            this.pContent.Margin = new System.Windows.Forms.Padding(0);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(323, 461);
            this.pContent.TabIndex = 1;
            // 
            // pPage
            // 
            this.pPage.Controls.Add(this.pEdit);
            this.pPage.Controls.Add(this.pList);
            this.pPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPage.Location = new System.Drawing.Point(0, 0);
            this.pPage.Name = "pPage";
            this.pPage.Size = new System.Drawing.Size(323, 414);
            this.pPage.TabIndex = 3;
            // 
            // pEdit
            // 
            this.pEdit.BackColor = System.Drawing.Color.Transparent;
            this.pEdit.Location = new System.Drawing.Point(11, 35);
            this.pEdit.Name = "pEdit";
            this.pEdit.Size = new System.Drawing.Size(136, 208);
            this.pEdit.TabIndex = 0;
            // 
            // pList
            // 
            this.pList.BackColor = System.Drawing.Color.Transparent;
            this.pList.Location = new System.Drawing.Point(159, 35);
            this.pList.Name = "pList";
            this.pList.Size = new System.Drawing.Size(137, 208);
            this.pList.TabIndex = 1;
            // 
            // pRoot
            // 
            this.pRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(87)))), ((int)(((byte)(168)))));
            this.pRoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pRoot.Location = new System.Drawing.Point(0, 414);
            this.pRoot.Name = "pRoot";
            this.pRoot.Size = new System.Drawing.Size(323, 47);
            this.pRoot.TabIndex = 2;
            // 
            // pTool
            // 
            this.pTool.BackgroundImage = global::Recorder.Properties.Resources.LeftSelectedTab;
            this.pTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pTool.Controls.Add(this.lbList);
            this.pTool.Controls.Add(this.lbEdit);
            this.pTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTool.Location = new System.Drawing.Point(0, 0);
            this.pTool.Name = "pTool";
            this.pTool.Size = new System.Drawing.Size(323, 40);
            this.pTool.TabIndex = 0;
            // 
            // lbList
            // 
            this.lbList.BackColor = System.Drawing.Color.Transparent;
            this.lbList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbList.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(120)))), ((int)(((byte)(1)))));
            this.lbList.Location = new System.Drawing.Point(161, 0);
            this.lbList.Margin = new System.Windows.Forms.Padding(0);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(162, 40);
            this.lbList.TabIndex = 1;
            this.lbList.Text = "列表";
            this.lbList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbList.Click += new System.EventHandler(this.lbList_Click);
            // 
            // lbEdit
            // 
            this.lbEdit.BackColor = System.Drawing.Color.Transparent;
            this.lbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbEdit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(120)))), ((int)(((byte)(1)))));
            this.lbEdit.Location = new System.Drawing.Point(0, 0);
            this.lbEdit.Margin = new System.Windows.Forms.Padding(0);
            this.lbEdit.Name = "lbEdit";
            this.lbEdit.Size = new System.Drawing.Size(161, 40);
            this.lbEdit.TabIndex = 0;
            this.lbEdit.Text = "编辑";
            this.lbEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbEdit.Click += new System.EventHandler(this.lbEdit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Recorder.Properties.Resources.record;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 25);
            this.panel1.TabIndex = 8;
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 540);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FmMain_Load);
            this.pTitle.ResumeLayout(false);
            this.pContainer.ResumeLayout(false);
            this.pContent.ResumeLayout(false);
            this.pPage.ResumeLayout(false);
            this.pTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.Panel pTool;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.Label lbEdit;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Panel pList;
        private System.Windows.Forms.Panel pEdit;
        private System.Windows.Forms.Panel pPage;
        private System.Windows.Forms.Panel pRoot;
        private System.Windows.Forms.Panel panel1;
    }
}

