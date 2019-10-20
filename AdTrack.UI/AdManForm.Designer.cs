namespace AdTrackForm
{
    partial class AdManForm
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
            this.lvwExist = new BigSoft.Framework.Controls.BsListView(this.components);
            this.lvwYear = new BigSoft.Framework.Controls.BsListView(this.components);
            this.lvwMagazine = new BigSoft.Framework.Controls.BsListView(this.components);
            this.bsStandartToolStrip1 = new BigSoft.Framework.Controls.BsStandartToolStrip();
            this.lvwAllCompany = new BigSoft.Framework.Controls.BsListView(this.components);
            this.txtAll = new BigSoft.Framework.Controls.BsTextBox(this.components);
            this.txtAd = new BigSoft.Framework.Controls.BsTextBox(this.components);
            this.lvwAdList = new BigSoft.Framework.Controls.BsListView(this.components);
            this.lblMagazine = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.rbtKapak = new System.Windows.Forms.RadioButton();
            this.rbtKapakIci = new System.Windows.Forms.RadioButton();
            this.rbtArkaKapak = new System.Windows.Forms.RadioButton();
            this.rbt2Pages = new System.Windows.Forms.RadioButton();
            this.rbt1Page = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lvwExist
            // 
            this.lvwExist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwExist.HideSelection = false;
            this.lvwExist.Location = new System.Drawing.Point(309, 36);
            this.lvwExist.Name = "lvwExist";
            this.lvwExist.Size = new System.Drawing.Size(111, 413);
            this.lvwExist.TabIndex = 19;
            this.lvwExist.UseCompatibleStateImageBehavior = false;
            this.lvwExist.SelectedIndexChanged += new System.EventHandler(this.LvwExist_SelectedIndexChanged);
            // 
            // lvwYear
            // 
            this.lvwYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwYear.HideSelection = false;
            this.lvwYear.Location = new System.Drawing.Point(225, 36);
            this.lvwYear.Name = "lvwYear";
            this.lvwYear.Size = new System.Drawing.Size(78, 413);
            this.lvwYear.TabIndex = 18;
            this.lvwYear.UseCompatibleStateImageBehavior = false;
            this.lvwYear.SelectedIndexChanged += new System.EventHandler(this.LvwYear_SelectedIndexChanged);
            // 
            // lvwMagazine
            // 
            this.lvwMagazine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwMagazine.HideSelection = false;
            this.lvwMagazine.Location = new System.Drawing.Point(12, 36);
            this.lvwMagazine.Name = "lvwMagazine";
            this.lvwMagazine.Size = new System.Drawing.Size(207, 413);
            this.lvwMagazine.TabIndex = 17;
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
            this.bsStandartToolStrip1.OkSaveButtonEnabled = false;
            this.bsStandartToolStrip1.OkUpdateButtonEnabled = false;
            this.bsStandartToolStrip1.OkUpdateButtonVisible = false;
            this.bsStandartToolStrip1.Size = new System.Drawing.Size(1046, 31);
            this.bsStandartToolStrip1.TabIndex = 16;
            this.bsStandartToolStrip1.OkGetButtonClicked += new System.EventHandler(this.BsStandartToolStrip1_OkGetButtonClicked);
            this.bsStandartToolStrip1.OkSaveButtonClicked += new System.EventHandler(this.BsStandartToolStrip1_OkSaveButtonClicked);
            // 
            // lvwAllCompany
            // 
            this.lvwAllCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwAllCompany.HideSelection = false;
            this.lvwAllCompany.Location = new System.Drawing.Point(782, 94);
            this.lvwAllCompany.Name = "lvwAllCompany";
            this.lvwAllCompany.Size = new System.Drawing.Size(250, 355);
            this.lvwAllCompany.TabIndex = 20;
            this.lvwAllCompany.UseCompatibleStateImageBehavior = false;
            this.lvwAllCompany.SelectedIndexChanged += new System.EventHandler(this.LvwAllCompany_SelectedIndexChanged);
            // 
            // txtAll
            // 
            this.txtAll.Location = new System.Drawing.Point(782, 68);
            this.txtAll.Name = "txtAll";
            this.txtAll.Size = new System.Drawing.Size(250, 20);
            this.txtAll.TabIndex = 21;
            this.txtAll.TextChanged += new System.EventHandler(this.TxtAll_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(426, 68);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(250, 20);
            this.txtAd.TabIndex = 23;
            this.txtAd.TextChanged += new System.EventHandler(this.TxtAd_TextChanged);
            // 
            // lvwAdList
            // 
            this.lvwAdList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwAdList.HideSelection = false;
            this.lvwAdList.Location = new System.Drawing.Point(426, 94);
            this.lvwAdList.Name = "lvwAdList";
            this.lvwAdList.Size = new System.Drawing.Size(250, 355);
            this.lvwAdList.TabIndex = 22;
            this.lvwAdList.UseCompatibleStateImageBehavior = false;
            this.lvwAdList.SelectedIndexChanged += new System.EventHandler(this.LvwAdList_SelectedIndexChanged);
            // 
            // lblMagazine
            // 
            this.lblMagazine.AutoSize = true;
            this.lblMagazine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazine.Location = new System.Drawing.Point(426, 36);
            this.lblMagazine.Name = "lblMagazine";
            this.lblMagazine.Size = new System.Drawing.Size(0, 20);
            this.lblMagazine.TabIndex = 24;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(682, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "<<";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(682, 241);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(94, 23);
            this.btnSubtract.TabIndex = 26;
            this.btnSubtract.Text = ">>";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // rbtKapak
            // 
            this.rbtKapak.AutoSize = true;
            this.rbtKapak.Location = new System.Drawing.Point(682, 94);
            this.rbtKapak.Name = "rbtKapak";
            this.rbtKapak.Size = new System.Drawing.Size(56, 17);
            this.rbtKapak.TabIndex = 27;
            this.rbtKapak.TabStop = true;
            this.rbtKapak.Text = "Kapak";
            this.rbtKapak.UseVisualStyleBackColor = true;
            // 
            // rbtKapakIci
            // 
            this.rbtKapakIci.AutoSize = true;
            this.rbtKapakIci.Location = new System.Drawing.Point(682, 117);
            this.rbtKapakIci.Name = "rbtKapakIci";
            this.rbtKapakIci.Size = new System.Drawing.Size(70, 17);
            this.rbtKapakIci.TabIndex = 28;
            this.rbtKapakIci.TabStop = true;
            this.rbtKapakIci.Text = "Kapak İçi";
            this.rbtKapakIci.UseVisualStyleBackColor = true;
            // 
            // rbtArkaKapak
            // 
            this.rbtArkaKapak.AutoSize = true;
            this.rbtArkaKapak.Location = new System.Drawing.Point(682, 140);
            this.rbtArkaKapak.Name = "rbtArkaKapak";
            this.rbtArkaKapak.Size = new System.Drawing.Size(81, 17);
            this.rbtArkaKapak.TabIndex = 29;
            this.rbtArkaKapak.TabStop = true;
            this.rbtArkaKapak.Text = "Arka Kapak";
            this.rbtArkaKapak.UseVisualStyleBackColor = true;
            // 
            // rbt2Pages
            // 
            this.rbt2Pages.AutoSize = true;
            this.rbt2Pages.Location = new System.Drawing.Point(682, 163);
            this.rbt2Pages.Name = "rbt2Pages";
            this.rbt2Pages.Size = new System.Drawing.Size(70, 17);
            this.rbt2Pages.TabIndex = 30;
            this.rbt2Pages.TabStop = true;
            this.rbt2Pages.Text = "Çift Sayfa";
            this.rbt2Pages.UseVisualStyleBackColor = true;
            // 
            // rbt1Page
            // 
            this.rbt1Page.AutoSize = true;
            this.rbt1Page.Location = new System.Drawing.Point(682, 186);
            this.rbt1Page.Name = "rbt1Page";
            this.rbt1Page.Size = new System.Drawing.Size(74, 17);
            this.rbt1Page.TabIndex = 31;
            this.rbt1Page.TabStop = true;
            this.rbt1Page.Text = "Tek Sayfa";
            this.rbt1Page.UseVisualStyleBackColor = true;
            // 
            // AdManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 461);
            this.Controls.Add(this.rbt1Page);
            this.Controls.Add(this.rbt2Pages);
            this.Controls.Add(this.rbtArkaKapak);
            this.Controls.Add(this.rbtKapakIci);
            this.Controls.Add(this.rbtKapak);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblMagazine);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lvwAdList);
            this.Controls.Add(this.txtAll);
            this.Controls.Add(this.lvwAllCompany);
            this.Controls.Add(this.lvwExist);
            this.Controls.Add(this.lvwYear);
            this.Controls.Add(this.lvwMagazine);
            this.Controls.Add(this.bsStandartToolStrip1);
            this.Name = "AdManForm";
            this.Text = "Reklam Yönetimi";
            this.Load += new System.EventHandler(this.AdManForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BigSoft.Framework.Controls.BsListView lvwExist;
        private BigSoft.Framework.Controls.BsListView lvwYear;
        private BigSoft.Framework.Controls.BsListView lvwMagazine;
        private BigSoft.Framework.Controls.BsStandartToolStrip bsStandartToolStrip1;
        private BigSoft.Framework.Controls.BsListView lvwAllCompany;
        private BigSoft.Framework.Controls.BsTextBox txtAll;
        private BigSoft.Framework.Controls.BsTextBox txtAd;
        private BigSoft.Framework.Controls.BsListView lvwAdList;
        private System.Windows.Forms.Label lblMagazine;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.RadioButton rbtKapak;
        private System.Windows.Forms.RadioButton rbtKapakIci;
        private System.Windows.Forms.RadioButton rbtArkaKapak;
        private System.Windows.Forms.RadioButton rbt2Pages;
        private System.Windows.Forms.RadioButton rbt1Page;
    }
}