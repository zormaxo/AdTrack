using BigSoft.Framework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdTrackForm
{
    public partial class AboutForm : BsForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            label1.Text = "14.10.2019 - Ömer Kocadere";
            label2.Text = "\n1. Nevzat Sudaş\n" +
                "2. Ahmet Kocadere\n" +
                "3. Ömer Kocadere\n" +
                "4. Yaren Yıldız";
        }
    }
}