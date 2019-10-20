using AdTrack.Business;
using AdTrack.Data.Model;
using BigSoft.Framework.Controls;
using BigSoft.Framework.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdTrackForm
{
    public partial class CompanyForm : BsForm
    {
        private Company selectedItem;
        private List<Company> companyList;

        public CompanyForm()
        {
            InitializeComponent();
            lvwCompany.GenerateListView(2);
        }

        #region Events

        private void BsStandartToolStrip1_OkGetButtonClicked(object sender, EventArgs e)
        {
            bsStandartToolStrip1.DisableButtons();
            SearchList();
        }

        private void BsStandartToolStrip1_OkSaveButtonClicked(object sender, EventArgs e)
        {
            string companyName = txtCoName.Text.Trim();
            BsNewResult result = BsCommon.Validate(txtCoName);
            if (result.OpType != OpType.Successful)
            {
                BsMessageBox.Show(result);
                return;
            }

            OCompanySave save = new OCompanySave(companyName);
            result = save.Execute();
            BsMessageBox.Show(result);
            GetFormReady();
        }

        private void BsStandartToolStrip1_OkUpdateButtonClicked(object sender, EventArgs e)
        {
            string name = txtCoName.Text.Trim();
            BsNewResult result = BsCommon.Validate(txtCoName);
            if (result.OpType != OpType.Successful)
            {
                BsMessageBox.Show(result);
                return;
            }

            Company obj = new Company
            {
                CompanyId = selectedItem.CompanyId,
                CompanyName = name
            };

            OCompanyUpdate update = new OCompanyUpdate(obj);
            result = update.Execute();
            BsMessageBox.Show(result);
            GetFormReady();
        }

        private void BsStandartToolStrip1_OkDeleteButtonClicked(object sender, EventArgs e)
        {
            OCompanyDelete delete = new OCompanyDelete(selectedItem.CompanyId);
            BsNewResult result = delete.Execute();
            BsMessageBox.Show(result);
            GetFormReady();
        }

        private void LvwCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwCompany.SelectedItems.Count < 1)
            {
                bsStandartToolStrip1.DisableButtons();
                return;
            }

            selectedItem = (Company)lvwCompany.SelectedItems[0].Tag;
            txtCoName.Text = selectedItem.CompanyName;

            bsStandartToolStrip1.EnableButtons();
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            GetFormReady();
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            string pattern = txtFilter.Text.Trim();
            lvwCompany.Items.Clear();

            List<Company> patternList = companyList.Where(a => a.CompanyName.ToLower().Contains(pattern.ToLower())).ToList();
            int i = 1;
            foreach (Company obj in patternList)
            {
                string[] row = { i.ToString(), obj.CompanyName };
                ListViewItem item = new ListViewItem(row) { Tag = obj };
                lvwCompany.Items.Add(item);
                i++;
            }
        }

        #endregion Events

        private void GetFormReady()
        {
            BsCommon.ClearControls(this);
            bsStandartToolStrip1.DisableButtons();
            FillCompanyList();
        }

        private void FillCompanyList()
        {
            OCompanyGet companyGet = new OCompanyGet();
            companyGet.Execute();
            companyList = companyGet.CompanyList.OrderBy(x => x.CompanyName).ToList();

            lvwCompany.Items.Clear();
            if (companyList != null)
            {
                int i = 1;
                foreach (Company obj in companyList)
                {
                    string[] row = { i.ToString(), obj.CompanyName };
                    ListViewItem item = new ListViewItem(row) { Tag = obj };
                    lvwCompany.Items.Add(item);
                    i++;
                }
            }
            lvwCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public void SearchList()
        {
            string pattern = txtCoName.Text.Trim();
            lvwCompany.Items.Clear();

            List<Company> patternList = companyList.Where(a => a.CompanyName.ToLower().Contains(pattern.ToLower())).ToList();
            int i = 1;
            foreach (Company obj in patternList)
            {
                string[] row = { i.ToString(), obj.CompanyName };
                ListViewItem item = new ListViewItem(row) { Tag = obj };
                lvwCompany.Items.Add(item);
                i++;
            }
        }
    }
}