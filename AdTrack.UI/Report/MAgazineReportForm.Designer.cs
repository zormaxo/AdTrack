namespace AdTrackForm.Report
{
    partial class MagazineReportForm
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
            this.lvwMagazine = new BigSoft.Framework.Controls.BsListView(this.components);
            this.bsStandartToolStrip1 = new BigSoft.Framework.Controls.BsStandartToolStrip();
            this.lvwSum = new BigSoft.Framework.Controls.BsListView(this.components);
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 36);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(277, 20);
            this.txtFilter.TabIndex = 14;
            this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // lvwMagazine
            // 
            this.lvwMagazine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwMagazine.HideSelection = false;
            this.lvwMagazine.Location = new System.Drawing.Point(12, 89);
            this.lvwMagazine.Name = "lvwMagazine";
            this.lvwMagazine.Size = new System.Drawing.Size(277, 460);
            this.lvwMagazine.TabIndex = 13;
            this.lvwMagazine.UseCompatibleStateImageBehavior = false;
            this.lvwMagazine.SelectedIndexChanged += new System.EventHandler(this.LvwMagazine_SelectedIndexChanged);
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
            // lvwSum
            // 
            this.lvwSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwSum.HideSelection = false;
            this.lvwSum.Location = new System.Drawing.Point(339, 89);
            this.lvwSum.Name = "lvwSum";
            this.lvwSum.Size = new System.Drawing.Size(305, 460);
            this.lvwSum.TabIndex = 18;
            this.lvwSum.UseCompatibleStateImageBehavior = false;
            // 
            // MagazineReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 561);
            this.Controls.Add(this.lvwSum);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lvwMagazine);
            this.Controls.Add(this.bsStandartToolStrip1);
            this.Name = "MagazineReportForm";
            this.Text = "Degi Raporu";
            this.Load += new System.EventHandler(this.CompanyReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private BigSoft.Framework.Controls.BsListView lvwMagazine;
        private BigSoft.Framework.Controls.BsStandartToolStrip bsStandartToolStrip1;
        private BigSoft.Framework.Controls.BsListView lvwSum;
    }
}