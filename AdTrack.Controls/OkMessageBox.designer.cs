namespace Framework.Controls
{
    public partial class OkMessageBox
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnDetay = new System.Windows.Forms.Button();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMessage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMessage.ForeColor = System.Drawing.Color.Red;
            this.txtMessage.Location = new System.Drawing.Point(66, 12);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(404, 95);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "Hata";
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(314, 113);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 2;
            this.btnTamam.Text = "Ok";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnDetay
            // 
            this.btnDetay.Location = new System.Drawing.Point(395, 113);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(75, 23);
            this.btnDetay.TabIndex = 2;
            this.btnDetay.Text = "Detay";
            this.btnDetay.UseVisualStyleBackColor = true;
            this.btnDetay.Visible = false;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // txtDetail
            // 
            this.txtDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDetail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDetail.Location = new System.Drawing.Point(66, 159);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ReadOnly = true;
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDetail.Size = new System.Drawing.Size(404, 151);
            this.txtDetail.TabIndex = 1;
            this.txtDetail.WordWrap = false;
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(396, 114);
            this.btnNo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 22);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // pbxIcon
            // 
            this.pbxIcon.Image = global::Framework.Controls.Resource.popup_error;
            this.pbxIcon.Location = new System.Drawing.Point(2, 29);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(58, 66);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxIcon.TabIndex = 0;
            this.pbxIcon.TabStop = false;
            // 
            // OkMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 144);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnDetay);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.pbxIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OkMessageBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnDetay;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Button btnNo;
    }
}