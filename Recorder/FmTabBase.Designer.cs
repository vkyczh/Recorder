namespace Recorder
{
    partial class FmTabBase
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
            this.pToolBar = new System.Windows.Forms.Panel();
            this.pTabBaseContainer = new System.Windows.Forms.Panel();
            this.ucTabContainer1 = new Recorder.UserControllers.UCTabContainer();
            this.pContainer.SuspendLayout();
            this.pTabBaseContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.pTabBaseContainer);
            this.pContainer.Controls.Add(this.pToolBar);
            this.pContainer.Size = new System.Drawing.Size(851, 440);
            this.pContainer.Controls.SetChildIndex(this.pToolBar, 0);
            this.pContainer.Controls.SetChildIndex(this.pTabBaseContainer, 0);
            // 
            // pToolBar
            // 
            this.pToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(87)))), ((int)(((byte)(168)))));
            this.pToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pToolBar.Location = new System.Drawing.Point(3, 0);
            this.pToolBar.Margin = new System.Windows.Forms.Padding(0);
            this.pToolBar.Name = "pToolBar";
            this.pToolBar.Size = new System.Drawing.Size(845, 35);
            this.pToolBar.TabIndex = 3;
            // 
            // pTabBaseContainer
            // 
            this.pTabBaseContainer.Controls.Add(this.ucTabContainer1);
            this.pTabBaseContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTabBaseContainer.Location = new System.Drawing.Point(3, 35);
            this.pTabBaseContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pTabBaseContainer.Name = "pTabBaseContainer";
            this.pTabBaseContainer.Size = new System.Drawing.Size(845, 402);
            this.pTabBaseContainer.TabIndex = 4;
            // 
            // ucTabContainer1
            // 
            this.ucTabContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTabContainer1.Location = new System.Drawing.Point(0, 0);
            this.ucTabContainer1.Name = "ucTabContainer1";
            this.ucTabContainer1.SelectedTabInfo = null;
            this.ucTabContainer1.Size = new System.Drawing.Size(845, 402);
            this.ucTabContainer1.TabIndex = 0;
            // 
            // FmTabBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 472);
            this.Name = "FmTabBase";
            this.Text = "FmTabBase";
            this.Load += new System.EventHandler(this.FmTabBase_Load);
            this.pContainer.ResumeLayout(false);
            this.pTabBaseContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pToolBar;
        private System.Windows.Forms.Panel pTabBaseContainer;
        private UserControllers.UCTabContainer ucTabContainer1;
    }
}