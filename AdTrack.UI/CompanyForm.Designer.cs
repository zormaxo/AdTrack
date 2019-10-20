namespace AdTrackForm
{
    partial class CompanyForm
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
            this.txtCoName = new System.Windows.Forms.TextBox();
            this.lvwCompany = new BigSoft.Framework.Controls.BsListView(this.components);
            this.bsStandartToolStrip1 = new BigSoft.Framework.Controls.BsStandartToolStrip();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCoName
            // 
            this.txtCoName.Location = new System.Drawing.Point(12, 36);
            this.txtCoName.Name = "txtCoName";
            this.txtCoName.Size = new System.Drawing.Size(214, 20);
            this.txtCoName.TabIndex = 8;
            // 
            // lvwCompany
            // 
            this.lvwCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwCompany.HideSelection = false;
            this.lvwCompany.Location = new System.Drawing.Point(12, 115);
            this.lvwCompany.Name = "lvwCompany";
            this.lvwCompany.Size = new System.Drawing.Size(860, 334);
            this.lvwCompany.TabIndex = 10;
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
            this.bsStandartToolStrip1.OkDeleteButtonEnabled = false;
            this.bsStandartToolStrip1.OkUpdateButtonEnabled = false;
            this.bsStandartToolStrip1.Size = new System.Drawing.Size(884, 31);
            this.bsStandartToolStrip1.TabIndex = 9;
            this.bsStandartToolStrip1.OkGetButtonClicked += new System.EventHandler(this.BsStandartToolStrip1_OkGetButtonClicked);
            this.bsStandartToolStrip1.OkUpdateButtonClicked += new System.EventHandler(this.BsStandartToolStrip1_OkUpdateButtonClicked);
            this.bsStandartToolStrip1.OkDeleteButtonClicked += new System.EventHandler(this.BsStandartToolStrip1_OkDeleteButtonClicked);
            this.bsStandartToolStrip1.OkSaveButtonClicked += new System.EventHandler(this.BsStandartToolStrip1_OkSaveButtonClicked);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 89);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(214, 20);
            this.txtFilter.TabIndex = 11;
            this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lvwCompany);
            this.Controls.Add(this.bsStandartToolStrip1);
            this.Controls.Add(this.txtCoName);
            this.Name = "CompanyForm";
            this.Text = "Firma Yönetimi";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BigSoft.Framework.Controls.BsListView lvwCompany;
        private BigSoft.Framework.Controls.BsStandartToolStrip bsStandartToolStrip1;
        private System.Windows.Forms.TextBox txtCoName;
        private System.Windows.Forms.TextBox txtFilter;
    }
}