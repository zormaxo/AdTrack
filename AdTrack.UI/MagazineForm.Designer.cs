namespace AdTrack.UI
{
    partial class MagazineForm
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
            this.bsStandartToolStrip1 = new BigSoft.Framework.Controls.BsStandartToolStrip();
            this.txtMaName = new System.Windows.Forms.TextBox();
            this.lvwMagazine = new BigSoft.Framework.Controls.BsListView(this.components);
            this.SuspendLayout();
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
            this.bsStandartToolStrip1.TabIndex = 6;
            this.bsStandartToolStrip1.OkGetButtonClicked += new System.EventHandler(this.BsStandartToolStrip1_OkGetButtonClicked);
            this.bsStandartToolStrip1.OkUpdateButtonClicked += new System.EventHandler(this.BsStandartToolStrip1_OkUpdateButtonClicked);
            this.bsStandartToolStrip1.OkDeleteButtonClicked += new System.EventHandler(this.BsStandartToolStrip1_OkDeleteButtonClicked);
            this.bsStandartToolStrip1.OkSaveButtonClicked += new System.EventHandler(this.BsStandartToolStrip1_OkSaveButtonClicked);
            // 
            // txtMaName
            // 
            this.txtMaName.Location = new System.Drawing.Point(12, 36);
            this.txtMaName.Name = "txtMaName";
            this.txtMaName.Size = new System.Drawing.Size(214, 20);
            this.txtMaName.TabIndex = 2;
            this.txtMaName.TextChanged += new System.EventHandler(this.TxtMaName_TextChanged);
            // 
            // lvwMagazine
            // 
            this.lvwMagazine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwMagazine.HideSelection = false;
            this.lvwMagazine.Location = new System.Drawing.Point(12, 116);
            this.lvwMagazine.Name = "lvwMagazine";
            this.lvwMagazine.Size = new System.Drawing.Size(860, 333);
            this.lvwMagazine.TabIndex = 7;
            this.lvwMagazine.UseCompatibleStateImageBehavior = false;
            this.lvwMagazine.SelectedIndexChanged += new System.EventHandler(this.LvwMagazine_SelectedIndexChanged);
            // 
            // MagazineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.lvwMagazine);
            this.Controls.Add(this.bsStandartToolStrip1);
            this.Controls.Add(this.txtMaName);
            this.Name = "MagazineForm";
            this.Text = "Dergi Yönetimi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BigSoft.Framework.Controls.BsStandartToolStrip bsStandartToolStrip1;
        private System.Windows.Forms.TextBox txtMaName;
        private BigSoft.Framework.Controls.BsListView lvwMagazine;
    }
}

