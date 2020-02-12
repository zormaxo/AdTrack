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
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTel3 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoK1 = new System.Windows.Forms.RadioButton();
            this.rdoV1 = new System.Windows.Forms.RadioButton();
            this.rdoD1 = new System.Windows.Forms.RadioButton();
            this.rdoD2 = new System.Windows.Forms.RadioButton();
            this.rdoV2 = new System.Windows.Forms.RadioButton();
            this.rdoK2 = new System.Windows.Forms.RadioButton();
            this.rdoD3 = new System.Windows.Forms.RadioButton();
            this.rdoV3 = new System.Windows.Forms.RadioButton();
            this.rdoK3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.lvwCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwCompany.HideSelection = false;
            this.lvwCompany.Location = new System.Drawing.Point(12, 115);
            this.lvwCompany.Name = "lvwCompany";
            this.lvwCompany.Size = new System.Drawing.Size(341, 401);
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
            this.bsStandartToolStrip1.Size = new System.Drawing.Size(944, 31);
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
            this.txtFilter.Size = new System.Drawing.Size(341, 20);
            this.txtFilter.TabIndex = 11;
            this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(232, 35);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 12;
            // 
            // txtExp
            // 
            this.txtExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExp.Location = new System.Drawing.Point(426, 118);
            this.txtExp.Multiline = true;
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(415, 68);
            this.txtExp.TabIndex = 13;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress1.Location = new System.Drawing.Point(8, 19);
            this.txtAddress1.Multiline = true;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(468, 75);
            this.txtAddress1.TabIndex = 14;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress2.Location = new System.Drawing.Point(8, 19);
            this.txtAddress2.Multiline = true;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(468, 80);
            this.txtAddress2.TabIndex = 15;
            // 
            // txtAddress3
            // 
            this.txtAddress3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress3.Location = new System.Drawing.Point(6, 19);
            this.txtAddress3.Multiline = true;
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(468, 80);
            this.txtAddress3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Açıklama";
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(456, 35);
            this.txtTel1.Mask = "(000) 000 00 00";
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(100, 20);
            this.txtTel1.TabIndex = 21;
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(456, 61);
            this.txtTel2.Mask = "(000) 000 00 00";
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(100, 20);
            this.txtTel2.TabIndex = 22;
            // 
            // txtTel3
            // 
            this.txtTel3.Location = new System.Drawing.Point(456, 87);
            this.txtTel3.Mask = "(000) 000 00 00";
            this.txtTel3.Name = "txtTel3";
            this.txtTel3.Size = new System.Drawing.Size(100, 20);
            this.txtTel3.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Telefon 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefon 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Telefon 3";
            // 
            // rdoK1
            // 
            this.rdoK1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoK1.AutoSize = true;
            this.rdoK1.Location = new System.Drawing.Point(480, 20);
            this.rdoK1.Name = "rdoK1";
            this.rdoK1.Size = new System.Drawing.Size(90, 17);
            this.rdoK1.TabIndex = 27;
            this.rdoK1.TabStop = true;
            this.rdoK1.Text = "Kuyumcukent";
            this.rdoK1.UseVisualStyleBackColor = true;
            // 
            // rdoV1
            // 
            this.rdoV1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoV1.AutoSize = true;
            this.rdoV1.Location = new System.Drawing.Point(480, 43);
            this.rdoV1.Name = "rdoV1";
            this.rdoV1.Size = new System.Drawing.Size(77, 17);
            this.rdoV1.TabIndex = 28;
            this.rdoV1.TabStop = true;
            this.rdoV1.Text = "Vizyonpark";
            this.rdoV1.UseVisualStyleBackColor = true;
            // 
            // rdoD1
            // 
            this.rdoD1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoD1.AutoSize = true;
            this.rdoD1.Checked = true;
            this.rdoD1.Location = new System.Drawing.Point(480, 66);
            this.rdoD1.Name = "rdoD1";
            this.rdoD1.Size = new System.Drawing.Size(50, 17);
            this.rdoD1.TabIndex = 29;
            this.rdoD1.TabStop = true;
            this.rdoD1.Text = "Diğer";
            this.rdoD1.UseVisualStyleBackColor = true;
            // 
            // rdoD2
            // 
            this.rdoD2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoD2.AutoSize = true;
            this.rdoD2.Checked = true;
            this.rdoD2.Location = new System.Drawing.Point(482, 67);
            this.rdoD2.Name = "rdoD2";
            this.rdoD2.Size = new System.Drawing.Size(50, 17);
            this.rdoD2.TabIndex = 32;
            this.rdoD2.TabStop = true;
            this.rdoD2.Text = "Diğer";
            this.rdoD2.UseVisualStyleBackColor = true;
            // 
            // rdoV2
            // 
            this.rdoV2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoV2.AutoSize = true;
            this.rdoV2.Location = new System.Drawing.Point(482, 44);
            this.rdoV2.Name = "rdoV2";
            this.rdoV2.Size = new System.Drawing.Size(77, 17);
            this.rdoV2.TabIndex = 31;
            this.rdoV2.TabStop = true;
            this.rdoV2.Text = "Vizyonpark";
            this.rdoV2.UseVisualStyleBackColor = true;
            // 
            // rdoK2
            // 
            this.rdoK2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoK2.AutoSize = true;
            this.rdoK2.Location = new System.Drawing.Point(482, 21);
            this.rdoK2.Name = "rdoK2";
            this.rdoK2.Size = new System.Drawing.Size(90, 17);
            this.rdoK2.TabIndex = 30;
            this.rdoK2.TabStop = true;
            this.rdoK2.Text = "Kuyumcukent";
            this.rdoK2.UseVisualStyleBackColor = true;
            // 
            // rdoD3
            // 
            this.rdoD3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoD3.AutoSize = true;
            this.rdoD3.Checked = true;
            this.rdoD3.Location = new System.Drawing.Point(480, 65);
            this.rdoD3.Name = "rdoD3";
            this.rdoD3.Size = new System.Drawing.Size(50, 17);
            this.rdoD3.TabIndex = 35;
            this.rdoD3.TabStop = true;
            this.rdoD3.Text = "Diğer";
            this.rdoD3.UseVisualStyleBackColor = true;
            // 
            // rdoV3
            // 
            this.rdoV3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoV3.AutoSize = true;
            this.rdoV3.Location = new System.Drawing.Point(480, 42);
            this.rdoV3.Name = "rdoV3";
            this.rdoV3.Size = new System.Drawing.Size(77, 17);
            this.rdoV3.TabIndex = 34;
            this.rdoV3.TabStop = true;
            this.rdoV3.Text = "Vizyonpark";
            this.rdoV3.UseVisualStyleBackColor = true;
            // 
            // rdoK3
            // 
            this.rdoK3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoK3.AutoSize = true;
            this.rdoK3.Location = new System.Drawing.Point(480, 19);
            this.rdoK3.Name = "rdoK3";
            this.rdoK3.Size = new System.Drawing.Size(90, 17);
            this.rdoK3.TabIndex = 33;
            this.rdoK3.TabStop = true;
            this.rdoK3.Text = "Kuyumcukent";
            this.rdoK3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtAddress3);
            this.groupBox1.Controls.Add(this.rdoD3);
            this.groupBox1.Controls.Add(this.rdoV3);
            this.groupBox1.Controls.Add(this.rdoK3);
            this.groupBox1.Location = new System.Drawing.Point(365, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 107);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adres 3";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtAddress2);
            this.groupBox2.Controls.Add(this.rdoK2);
            this.groupBox2.Controls.Add(this.rdoD2);
            this.groupBox2.Controls.Add(this.rdoV2);
            this.groupBox2.Location = new System.Drawing.Point(365, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 108);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rdoK1);
            this.groupBox3.Controls.Add(this.rdoV1);
            this.groupBox3.Controls.Add(this.rdoD1);
            this.groupBox3.Controls.Add(this.txtAddress1);
            this.groupBox3.Location = new System.Drawing.Point(365, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 100);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adres 1";
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 528);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTel3);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lvwCompany);
            this.Controls.Add(this.bsStandartToolStrip1);
            this.Controls.Add(this.txtCoName);
            this.Name = "CompanyForm";
            this.Text = "Firma Yönetimi";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BigSoft.Framework.Controls.BsListView lvwCompany;
        private BigSoft.Framework.Controls.BsStandartToolStrip bsStandartToolStrip1;
        private System.Windows.Forms.TextBox txtCoName;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTel1;
        private System.Windows.Forms.MaskedTextBox txtTel2;
        private System.Windows.Forms.MaskedTextBox txtTel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoK1;
        private System.Windows.Forms.RadioButton rdoV1;
        private System.Windows.Forms.RadioButton rdoD1;
        private System.Windows.Forms.RadioButton rdoD2;
        private System.Windows.Forms.RadioButton rdoV2;
        private System.Windows.Forms.RadioButton rdoK2;
        private System.Windows.Forms.RadioButton rdoD3;
        private System.Windows.Forms.RadioButton rdoV3;
        private System.Windows.Forms.RadioButton rdoK3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}