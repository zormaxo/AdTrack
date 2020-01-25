using System.Drawing;
using System.Windows.Forms;

namespace BigSoft.Framework.Util
{
    public static class BsCommon
    {
        public static BsNewResult Validate(params Control[] controls)
        {
            BsNewResult result = new BsNewResult();

            foreach (Control control in controls)
            {
                if (control is TextBox box)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        control.BackColor = Color.AntiqueWhite;
                        result.OpType = OpType.UserError;
                        result.Message = "Gerekli alanları doldurun.";
                    }
                    else
                    {
                        control.BackColor = Color.White;
                    }
                    continue;
                }

                if (control is ListView lstView)
                {
                    if (lstView.SelectedItems.Count == 0)
                    {
                        control.BackColor = Color.AntiqueWhite;
                        result.OpType = OpType.UserError;
                        result.Message = "Gerekli alanları doldurun.";
                    }
                    else
                    {
                        control.BackColor = Color.White;
                    }
                    continue;
                }

                if (control is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1)
                    {
                        control.BackColor = Color.AntiqueWhite;
                        result.OpType = OpType.UserError;
                        result.Message = "Gerekli alanları doldurun.";
                    }
                    else
                    {
                        control.BackColor = Color.White;
                    }
                }
            }

            return result;
        }

        public static void ClearControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox box)
                {
                    box.Clear();
                }
                if (control is MaskedTextBox mbox)
                {
                    mbox.Clear();
                }
                if (control is ListView view)
                {
                    view.Items.Clear();
                }
            }
        }
    }
}