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
            this.lvwDetails = new BigSoft.Framework.Controls.BsListView(this.components);
            this.lvwSum = new BigSoft.Framework.Controls.BsListView(this.components);
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkGenel = new System.Windows.Forms.CheckBox();
            this.chkFuar = new System.Windows.Forms.CheckBox();
            this.chkVermez = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 88);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(168, 20);
            this.txtFilter.TabIndex = 14;
            this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // lvwCompany
            // 
            this.lvwCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwCompany.HideSelection = false;
            this.lvwCompany.Location = new System.Drawing.Point(12, 117);
            this.lvwCompany.Name = "lvwCompany";
            this.lvwCompany.Size = new System.Drawing.Size(338, 432);
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
            this.bsStandartToolStrip1.Size = new System.Drawing.Size(903, 31);
            this.bsStandartToolStrip1.TabIndex = 12;
            this.bsStandartToolStrip1.OkGetButtonClicked += new System.EventHandler(this.BsStandartToolStrip1_OkGetButtonClicked);
            // 
            // lvwDetails
            // 
            this.lvwDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwDetails.HideSelection = false;
            this.lvwDetails.Location = new System.Drawing.Point(377, 117);
            this.lvwDetails.Name = "lvwDetails";
            this.lvwDetails.Size = new System.Drawing.Size(277, 432);
            this.lvwDetails.TabIndex = 17;
            this.lvwDetails.UseCompatibleStateImageBehavior = false;
            // 
            // lvwSum
            // 
            this.lvwSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwSum.HideSelection = false;
            this.lvwSum.Location = new System.Drawing.Point(660, 117);
            this.lvwSum.Name = "lvwSum";
            this.lvwSum.Size = new System.Drawing.Size(235, 432);
            this.lvwSum.TabIndex = 18;
            this.lvwSum.UseCompatibleStateImageBehavior = false;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(70, 36);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(110, 20);
            this.dtpStart.TabIndex = 19;
            this.dtpStart.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(70, 62);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(110, 20);
            this.dtpEnd.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Başlangıç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Bitiş";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(334, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Sadece Fuar Sayıları";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkGenel
            // 
            this.chkGenel.AutoSize = true;
            this.chkGenel.Checked = true;
            this.chkGenel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenel.Location = new System.Drawing.Point(211, 41);
            this.chkGenel.Name = "chkGenel";
            this.chkGenel.Size = new System.Drawing.Size(54, 17);
            this.chkGenel.TabIndex = 25;
            this.chkGenel.Text = "Genel";
            this.chkGenel.UseVisualStyleBackColor = true;
            // 
            // chkFuar
            // 
            this.chkFuar.AutoSize = true;
            this.chkFuar.Checked = true;
            this.chkFuar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFuar.Location = new System.Drawing.Point(211, 65);
            this.chkFuar.Name = "chkFuar";
            this.chkFuar.Size = new System.Drawing.Size(47, 17);
            this.chkFuar.TabIndex = 26;
            this.chkFuar.Text = "Fuar";
            this.chkFuar.UseVisualStyleBackColor = true;
            // 
            // chkVermez
            // 
            this.chkVermez.AutoSize = true;
            this.chkVermez.Checked = true;
            this.chkVermez.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVermez.Location = new System.Drawing.Point(211, 89);
            this.chkVermez.Name = "chkVermez";
            this.chkVermez.Size = new System.Drawing.Size(61, 17);
            this.chkVermez.TabIndex = 27;
            this.chkVermez.Text = "Vermez";
            this.chkVermez.UseVisualStyleBackColor = true;
            // 
            // CompanyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 561);
            this.Controls.Add(this.chkVermez);
            this.Controls.Add(this.chkFuar);
            this.Controls.Add(this.chkGenel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lvwSum);
            this.Controls.Add(this.lvwDetails);
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
        private BigSoft.Framework.Controls.BsListView lvwDetails;
        private BigSoft.Framework.Controls.BsListView lvwSum;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkGenel;
        private System.Windows.Forms.CheckBox chkFuar;
        private System.Windows.Forms.CheckBox chkVermez;
    }
}