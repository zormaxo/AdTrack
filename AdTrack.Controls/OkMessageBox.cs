using System;
using System.Drawing;
using System.Windows.Forms;
using Framework.Util;

namespace Framework.Controls
{
    public partial class OkMessageBox : Form
    {
        public static bool IsProcedd;
        private OkMessageBox()
        {
            InitializeComponent();
            btnTamam.Select();
        }

        private OkMessageBox(string message, BoxType boxType, Exception ex = null)
            : this()
        {
            switch (boxType)
            {
                case BoxType.Success:
                    Text = "Başarılı";
                    txtMessage.Text = message;
                    btnTamam.Location = btnDetay.Location;
                    pbxIcon.Image = Resource.popup_success;
                    txtMessage.ForeColor = Color.Blue;
                    break;
                case BoxType.Warning:
                    Text = "Uyarı";
                    txtMessage.Text = message;
                    btnTamam.Focus();
                    pbxIcon.Image = Resource.popup_warn;
                    break;
                case BoxType.SystemError:
                    Text = "Sistem Hatası";
                    txtMessage.Text = message;
                    if (ex != null) txtDetail.Text = ex.ToString();
                    btnDetay.Visible = true;
                    btnTamam.Focus();
                    break;
                case BoxType.Question:
                    Text = "Soru";
                    txtMessage.Text = message;
                    btnTamam.Text = "Yes";
                    btnDetay.Visible = false;
                    btnNo.Visible = true;
                    pbxIcon.Image = Resource.popup_question;
                    txtMessage.ForeColor = Color.DarkOrange;
                    break;
            }
        }
     
        private void btnDetay_Click(object sender, EventArgs e)
        {
            Height = 430;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            IsProcedd = true;
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            IsProcedd = false;
            Close();
        }

        public static void Ask(string message)
        {
            OkMessageBox box = new OkMessageBox(message, BoxType.Question);
            box.ShowDialog();
        }

        public static void Show(OkNewResult result)
        {
            OkMessageBox box;
            switch (result.OpType)
            {
                case OpType.Successful:
                    box = new OkMessageBox(result.Message, BoxType.Success);
                    box.ShowDialog();
                    break;
                case OpType.UserError:
                    box = new OkMessageBox(result.Message, BoxType.Warning);
                    box.ShowDialog();
                    break;
                case OpType.SystemError:
                    box = new OkMessageBox(result.Message, BoxType.SystemError, result.Exception);
                    box.ShowDialog();
                    break;
            }
        }

        public static void ShowError(string message)
        {
            OkMessageBox box = new OkMessageBox(message, BoxType.Warning);
            box.ShowDialog();
        }
    }

    enum BoxType
    {
        Success,
        Warning,
        SystemError,
        Question
    }
}
