﻿namespace AppDevAssignment
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscellaneousForm = new System.Windows.Forms.PictureBox();
            this.totalReportForm = new System.Windows.Forms.PictureBox();
            this.partialReportForm = new System.Windows.Forms.PictureBox();
            this.individualReportForm = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miscellaneousForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalReportForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partialReportForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualReportForm)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
            // 
            // miscellaneousForm
            // 
            this.miscellaneousForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miscellaneousForm.Image = ((System.Drawing.Image)(resources.GetObject("miscellaneousForm.Image")));
            this.miscellaneousForm.Location = new System.Drawing.Point(312, 241);
            this.miscellaneousForm.Name = "miscellaneousForm";
            this.miscellaneousForm.Size = new System.Drawing.Size(232, 173);
            this.miscellaneousForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.miscellaneousForm.TabIndex = 1;
            this.miscellaneousForm.TabStop = false;
            this.miscellaneousForm.Click += new System.EventHandler(this.MiscellaneousForm_Click);
            // 
            // totalReportForm
            // 
            this.totalReportForm.Image = ((System.Drawing.Image)(resources.GetObject("totalReportForm.Image")));
            this.totalReportForm.Location = new System.Drawing.Point(312, 40);
            this.totalReportForm.Name = "totalReportForm";
            this.totalReportForm.Size = new System.Drawing.Size(232, 173);
            this.totalReportForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.totalReportForm.TabIndex = 2;
            this.totalReportForm.TabStop = false;
            this.totalReportForm.Click += new System.EventHandler(this.TotalReportForm_Click);
            // 
            // partialReportForm
            // 
            this.partialReportForm.Image = ((System.Drawing.Image)(resources.GetObject("partialReportForm.Image")));
            this.partialReportForm.Location = new System.Drawing.Point(12, 40);
            this.partialReportForm.Name = "partialReportForm";
            this.partialReportForm.Size = new System.Drawing.Size(232, 173);
            this.partialReportForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.partialReportForm.TabIndex = 3;
            this.partialReportForm.TabStop = false;
            this.partialReportForm.Click += new System.EventHandler(this.PartialReportForm_Click);
            // 
            // individualReportForm
            // 
            this.individualReportForm.Image = ((System.Drawing.Image)(resources.GetObject("individualReportForm.Image")));
            this.individualReportForm.Location = new System.Drawing.Point(12, 241);
            this.individualReportForm.Name = "individualReportForm";
            this.individualReportForm.Size = new System.Drawing.Size(232, 173);
            this.individualReportForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.individualReportForm.TabIndex = 4;
            this.individualReportForm.TabStop = false;
            this.individualReportForm.Click += new System.EventHandler(this.IndividualReportForm_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.individualReportForm);
            this.Controls.Add(this.partialReportForm);
            this.Controls.Add(this.totalReportForm);
            this.Controls.Add(this.miscellaneousForm);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miscellaneousForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalReportForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partialReportForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualReportForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.PictureBox miscellaneousForm;
        private System.Windows.Forms.PictureBox totalReportForm;
        private System.Windows.Forms.PictureBox partialReportForm;
        private System.Windows.Forms.PictureBox individualReportForm;
    }
}