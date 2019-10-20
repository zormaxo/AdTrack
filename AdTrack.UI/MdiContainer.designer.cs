using BigSoft.Framework.Controls;

namespace AdTrack.UI
{
    partial class MdiContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMagazine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateMag = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateDate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFirma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompanyReport = new System.Windows.Forms.ToolStripMenuItem();
            this.okTabBrowser = new BigSoft.Framework.Controls.BsTabBrowser();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMagazine,
            this.menuFirma,
            this.menuAd,
            this.tsmiReport,
            this.menuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(995, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuMagazine
            // 
            this.menuMagazine.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreateMag,
            this.menuCreateDate});
            this.menuMagazine.Name = "menuMagazine";
            this.menuMagazine.Size = new System.Drawing.Size(47, 20);
            this.menuMagazine.Text = "&Dergi";
            // 
            // menuCreateMag
            // 
            this.menuCreateMag.Name = "menuCreateMag";
            this.menuCreateMag.Size = new System.Drawing.Size(152, 22);
            this.menuCreateMag.Text = "Dergi Yönetimi";
            this.menuCreateMag.Click += new System.EventHandler(this.MenuCreateMag_Click);
            // 
            // menuCreateDate
            // 
            this.menuCreateDate.Name = "menuCreateDate";
            this.menuCreateDate.Size = new System.Drawing.Size(152, 22);
            this.menuCreateDate.Text = "Tarih Yönetimi";
            this.menuCreateDate.Click += new System.EventHandler(this.MenuCreateDate_Click);
            // 
            // menuFirma
            // 
            this.menuFirma.Name = "menuFirma";
            this.menuFirma.Size = new System.Drawing.Size(49, 20);
            this.menuFirma.Text = "&Firma";
            this.menuFirma.Click += new System.EventHandler(this.MenuFirma_Click);
            // 
            // menuAd
            // 
            this.menuAd.Name = "menuAd";
            this.menuAd.Size = new System.Drawing.Size(58, 20);
            this.menuAd.Text = "&Reklam";
            this.menuAd.Click += new System.EventHandler(this.MenuAd_Click);
            // 
            // tsmiReport
            // 
            this.tsmiReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCompanyReport});
            this.tsmiReport.Name = "tsmiReport";
            this.tsmiReport.Size = new System.Drawing.Size(50, 20);
            this.tsmiReport.Text = "&Rapor";
            // 
            // menuCompanyReport
            // 
            this.menuCompanyReport.Name = "menuCompanyReport";
            this.menuCompanyReport.Size = new System.Drawing.Size(180, 22);
            this.menuCompanyReport.Text = "Firma";
            this.menuCompanyReport.Click += new System.EventHandler(this.MenuCompanyReport_Click);
            // 
            // okTabBrowser
            // 
            this.okTabBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.okTabBrowser.Location = new System.Drawing.Point(0, 24);
            this.okTabBrowser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okTabBrowser.Name = "okTabBrowser";
            this.okTabBrowser.Size = new System.Drawing.Size(995, 22);
            this.okTabBrowser.TabIndex = 21;
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(69, 20);
            this.menuAbout.Text = "&Hakkında";
            this.menuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // MdiContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::AdTrackForm.Properties.Resources.g30;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(995, 603);
            this.Controls.Add(this.okTabBrowser);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MdiContainer";
            this.Text = "Medya Takip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BsTabBrowser okTabBrowser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMagazine;
        private System.Windows.Forms.ToolStripMenuItem menuFirma;
        private System.Windows.Forms.ToolStripMenuItem menuAd;
        private System.Windows.Forms.ToolStripMenuItem tsmiReport;
        private System.Windows.Forms.ToolStripMenuItem menuCompanyReport;
        private System.Windows.Forms.ToolStripMenuItem menuCreateMag;
        private System.Windows.Forms.ToolStripMenuItem menuCreateDate;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
    }
}