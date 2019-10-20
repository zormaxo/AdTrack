using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Framework.Controls
{
    public sealed partial class OkStandartToolStrip : UserControl
    {
        public event EventHandler OkGetButtonClicked;
        public event EventHandler OkUpdateButtonClicked;
        public event EventHandler OkDeleteButtonClicked;
        public event EventHandler OkSaveButtonClicked;
        public event EventHandler OkSearchButtonClicked;
        public event EventHandler OkRefreshButtonClicked;

        public OkStandartToolStrip()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
        }

        private Control GetForm()
        {
            Control parent = Parent;
            while (parent != null)
            {
                if (parent is Form)
                    break;
                parent = parent.Parent;
            }
            try
            {
                if (parent != null)
                    return parent;
            }
            catch (Exception ex)
            {
                OkMessageBox.ShowError(ex.ToString());
            }
            return null;
        }

        private void tsbGet_Click(object sender, EventArgs e)
        {
            if (tsbGet != null)
                if (OkGetButtonClicked != null) OkGetButtonClicked(sender, e);
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            Form parentForm = (Form)GetForm();
            if (parentForm != null)
                parentForm.Close();
        }

        private void tsbClear_Click_1(object sender, EventArgs e)
        {
            Control form = ((((ToolStripButton)sender).Owner).Parent).Parent;
            ClearControls(form);
        }

        private void ClearControls(Control form)
        {
            foreach (Control c in form.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    ((TextBox)c).Clear();
                else if (c.GetType() == typeof(CheckBox))
                    ((CheckBox)c).Checked = false;
                else if (c.GetType() == typeof (ComboBox))
                {
                    ((ComboBox)c).SelectedIndex = -1;
                    ((ComboBox) c).Text = "";
                }
                else if (c.GetType() == typeof(ListBox))
                    ((ListBox)c).Items.Clear();
                else if (c.GetType() == typeof(ListView))
                    ((ListView)c).Items.Clear();
                else if (c.GetType() == typeof(OkListView))
                {
                    OkListView okListView = c as OkListView;
                    if (okListView == null) continue;
                    for (int i = 0; i < okListView.SelectedIndices.Count; i++)
                    {
                        okListView.Items[okListView.SelectedIndices[i]].Selected = false;
                    }
                }
                else if (c.GetType() == typeof(RadioButton))
                    ((RadioButton)c).Checked = false;
                else if (c.GetType() == typeof(GroupBox))
                    ClearControls(c);
                else if (c.GetType() == typeof(Panel))
                    ClearControls(c);
            }

            tsbUpdate.Enabled = false;
            tsbDelete.Enabled = false;
        }

        private void tsbSave_Click_1(object sender, EventArgs e)
        {
            if (OkSaveButtonClicked != null)
                OkSaveButtonClicked(sender, e);
        }

        private void tsbUpdate_Click_1(object sender, EventArgs e)
        {
            if (OkUpdateButtonClicked != null)
                OkUpdateButtonClicked(sender, e);
        }

        private void tsbDelete_Click_1(object sender, EventArgs e)
        {
            OkMessageBox.Ask("Are you sure want to delete?");
            if (!OkMessageBox.IsProcedd) return;
            if (OkDeleteButtonClicked != null)
                OkDeleteButtonClicked(sender, e);
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            if (OkSearchButtonClicked != null)
                OkSearchButtonClicked(sender, e);
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            if (OkRefreshButtonClicked != null)
                OkRefreshButtonClicked(sender, e);
        }

        #region Button Visible Status

        [Category("Visible")]
        [DefaultValue(true)]
        public bool OkGetButtonVisible
        {
            get { return tsbGet.Visible; }
            set { tsbGet.Visible = value; }
        }

        [Category("Visible")]
        [DefaultValue(false)]
        public bool OkSearchButtonVisible
        {
            get { return tsbSearch.Visible; }
            set { tsbSearch.Visible = value; }
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool OkSaveButtonVisible
        {
            get { return tsbSave.Visible; }
            set { tsbSave.Visible = value; }
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool OkUpdateButtonVisible
        {
            get { return tsbUpdate.Visible; }
            set { tsbUpdate.Visible = value; }
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool OkDeleteButtonVisible
        {
            get { return tsbDelete.Visible; }
            set { tsbDelete.Visible = value; }
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool OkClearButtonVisible
        {
            get { return tsbClear.Visible; }
            set { tsbClear.Visible = value; }
        }

        [Category("Visible")]
        [DefaultValue(false)]
        public bool OkRefreshButtonVisible
        {
            get { return tsbRefresh.Visible; }
            set { tsbRefresh.Visible = value; }
        }

        #endregion

        #region Button Enabled Status

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkGetButtonEnabled
        {
            get { return tsbGet.Enabled; }
            set { tsbGet.Enabled = value; }
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkSearchButtonEnabled
        {
            get { return tsbSearch.Enabled; }
            set { tsbSearch.Enabled = value; }
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkSaveButtonEnabled
        {
            get { return tsbSave.Enabled; }
            set { tsbSave.Enabled = value; }
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkUpdateButtonEnabled
        {
            get { return tsbUpdate.Enabled; }
            set { tsbUpdate.Enabled = value; }
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkDeleteButtonEnabled
        {
            get { return tsbDelete.Enabled; }
            set { tsbDelete.Enabled = value; }
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkClearButtonEnabled
        {
            get { return tsbClear.Enabled; }
            set { tsbClear.Enabled = value; }
        }

        #endregion

        public void EnableButtons()
        {
            tsbUpdate.Enabled = true;
            tsbDelete.Enabled = true;
        }


    }
}
