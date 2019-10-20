namespace AdTrackForm
{
    partial class MagazineDateForm
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
            this.lvwMagazine = new BigSoft.Framework.Controls.BsListView(this.components);
            this.bsStandartToolStrip1 = new BigSoft.Framework.Controls.BsStandartToolStrip();
            this.lvwYear = new BigSoft.Framework.Controls.BsListView(this.components);
            this.lvwMonth = new BigSoft.Framework.Controls.BsListView(this.components);
            this.lvwExist = new BigSoft.Framework.Controls.BsListView(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwMagazine
            // 
            this.lvwMagazine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwMagazine.HideSelection = false;
            this.lvwMagazine.Location = new System.Drawing.Point(12, 36);
            this.lvwMagazine.Name = "lvwMagazine";
            this.lvwMagazine.Size = new System.Drawing.Size(294, 413);
            this.lvwMagazine.TabIndex = 12;
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
            this.bsStandartToolStrip1.OkSaveButtonEnabled = false;
            this.bsStandartToolStrip1.OkUpdateButtonEnabled = false;
            this.bsStandartToolStrip1.OkUpdateButtonVisible = false;
            this.bsStandartToolStrip1.Size = new System.Drawing.Size(884, 31);
            this.bsStandartToolStrip1.TabIndex = 11;
            this.bsStandartToolStrip1.OkGetButtonClicked += new System.EventHandler(this.BsStandartToolStrip1_OkGetButtonClicked);
            this.bsStandartToolStrip1.OkDeleteButtonClicked += new System.EventHandler(this.BsStandartToolStrip1_OkDeleteButtonClicked);
            this.bsStandartToolStrip1.OkSaveButtonClicked += new System.EventHandler(this.BsStandartToolStrip1_OkSaveButtonClicked);
            // 
            // lvwYear
            // 
            this.lvwYear.HideSelection = false;
            this.lvwYear.Location = new System.Drawing.Point(312, 37);
            this.lvwYear.Name = "lvwYear";
            this.lvwYear.Size = new System.Drawing.Size(78, 134);
            this.lvwYear.TabIndex = 13;
            this.lvwYear.UseCompatibleStateImageBehavior = false;
            this.lvwYear.SelectedIndexChanged += new System.EventHandler(this.LvwYear_SelectedIndexChanged);
            // 
            // lvwMonth
            // 
            this.lvwMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwMonth.HideSelection = false;
            this.lvwMonth.Location = new System.Drawing.Point(517, 67);
            this.lvwMonth.Name = "lvwMonth";
            this.lvwMonth.Size = new System.Drawing.Size(183, 382);
            this.lvwMonth.TabIndex = 14;
            this.lvwMonth.UseCompatibleStateImageBehavior = false;
            this.lvwMonth.SelectedIndexChanged += new System.EventHandler(this.LvwMonth_SelectedIndexChanged);
            this.lvwMonth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvwMonth_MouseClick);
            // 
            // lvwExist
            // 
            this.lvwExist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwExist.HideSelection = false;
            this.lvwExist.Location = new System.Drawing.Point(706, 66);
            this.lvwExist.Name = "lvwExist";
            this.lvwExist.Size = new System.Drawing.Size(166, 382);
            this.lvwExist.TabIndex = 15;
            this.lvwExist.UseCompatibleStateImageBehavior = false;
            this.lvwExist.SelectedIndexChanged += new System.EventHandler(this.LvwExist_SelectedIndexChanged);
            this.lvwExist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvwExist_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kayıtlı Olmayanlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kayıtlılar";
            // 
            // MagazineDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwExist);
            this.Controls.Add(this.lvwMonth);
            this.Controls.Add(this.lvwYear);
            this.Controls.Add(this.lvwMagazine);
            this.Controls.Add(this.bsStandartToolStrip1);
            this.Name = "MagazineDateForm";
            this.Text = "Tarih Yönetimi";
            this.Load += new System.EventHandler(this.MagazineDateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BigSoft.Framework.Controls.BsListView lvwMagazine;
        private BigSoft.Framework.Controls.BsStandartToolStrip bsStandartToolStrip1;
        private BigSoft.Framework.Controls.BsListView lvwYear;
        private BigSoft.Framework.Controls.BsListView lvwMonth;
        private BigSoft.Framework.Controls.BsListView lvwExist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}