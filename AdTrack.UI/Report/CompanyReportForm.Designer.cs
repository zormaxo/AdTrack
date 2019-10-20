namespace AdTrackForm.Report
{
    partial class CompanyReportForm
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
            this.components = new System.ComponentModel.Container();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lvwCompany = new BigSoft.Framework.Controls.BsListView(this.components);
            this.bsStandartToolStrip1 = new BigSoft.Framework.Controls.BsStandartToolStrip();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwDetails = new BigSoft.Framework.Controls.BsListView(this.components);
            this.lvwSum = new BigSoft.Framework.Controls.BsListView(this.components);
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 63);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(277, 20);
            this.txtFilter.TabIndex = 14;
            this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // lvwCompany
            // 
            this.lvwCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwCompany.HideSelection = false;
            this.lvwCompany.Location = new System.Drawing.Point(12, 89);
            this.lvwCompany.Name = "lvwCompany";
            this.lvwCompany.Size = new System.Drawing.Size(277, 460);
            this.lvwCompany.TabIndex = 13;
            this.lvwCompany.UseCompatibleStateImageBehavior = false;
            this.lvwCompany.SelectedIndexChanged += new System.EventHandler(this.LvwCompany_SelectedIndexChanged);
            // 
            // bsStandartToolStrip1
            // 
            this.bsStandartToolStrip1.AutoSize = true;
            this.bsStandartToolStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bsStandartToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.bsStandartToolStrip1.Margin = new System.Windows.Forms.Padding(2);
            this.bsStandartToolStrip1.Name = "bsStandartToolStrip1";
            this.bsStandartToolStrip1.OkClearButtonVisible = false;
            this.bsStandartToolStrip1.OkDeleteButtonEnabled = false;
            this.bsStandartToolStrip1.OkDeleteButtonVisible = false;
            this.bsStandartToolStrip1.OkSaveButtonVisible = false;
            this.bsStandartToolStrip1.OkUpdateButtonEnabled = false;
            this.bsStandartToolStrip1.OkUpdateButtonVisible = false;
            this.bsStandartToolStrip1.Size = new System.Drawing.Size(859, 31);
            this.bsStandartToolStrip1.TabIndex = 12;
            this.bsStandartToolStrip1.OkGetButtonClicked += new System.EventHandler(this.BsStandartToolStrip1_OkGetButtonClicked);
            // 
            // cbxYear
            // 
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Location = new System.Drawing.Point(125, 36);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(164, 21);
            this.cbxYear.TabIndex = 15;
            this.cbxYear.SelectedIndexChanged += new System.EventHandler(this.CbxYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Yıl Seçimi";
            // 
            // lvwDetails
            // 
            this.lvwDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwDetails.HideSelection = false;
            this.lvwDetails.Location = new System.Drawing.Point(312, 89);
            this.lvwDetails.Name = "lvwDetails";
            this.lvwDetails.Size = new System.Drawing.Size(277, 460);
            this.lvwDetails.TabIndex = 17;
            this.lvwDetails.UseCompatibleStateImageBehavior = false;
            // 
            // lvwSum
            // 
            this.lvwSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwSum.HideSelection = false;
            this.lvwSum.Location = new System.Drawing.Point(612, 89);
            this.lvwSum.Name = "lvwSum";
            this.lvwSum.Size = new System.Drawing.Size(235, 460);
            this.lvwSum.TabIndex = 18;
            this.lvwSum.UseCompatibleStateImageBehavior = false;
            // 
            // CompanyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 561);
            this.Controls.Add(this.lvwSum);
            this.Controls.Add(this.lvwDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxYear);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lvwCompany);
            this.Controls.Add(this.bsStandartToolStrip1);
            this.Name = "CompanyReportForm";
            this.Text = "Firma Raporu";
            this.Load += new System.EventHandler(this.CompanyReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private BigSoft.Framework.Controls.BsListView lvwCompany;
        private BigSoft.Framework.Controls.BsStandartToolStrip bsStandartToolStrip1;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.Label label1;
        private BigSoft.Framework.Controls.BsListView lvwDetails;
        private BigSoft.Framework.Controls.BsListView lvwSum;
    }
}