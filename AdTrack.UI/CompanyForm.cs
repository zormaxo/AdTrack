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
        private List<Status> statusList;

        public CompanyForm()
        {
            InitializeComponent();
            lvwCompany.GenerateListView(4);
        }

        #region Events

        private void BsStandartToolStrip1_OkGetButtonClicked(object sender, EventArgs e)
        {
            bsStandartToolStrip1.DisableUpdateDelete();
            SearchList();
        }

        private void BsStandartToolStrip1_OkSaveButtonClicked(object sender, EventArgs e)
        {
            string name = txtCoName.Text.Trim();
            int status = cmbStatus.SelectedIndex == 0 ? 1 : cmbStatus.SelectedIndex;
            string explanation = txtExp.Text;
            string address1 = txtAddress1.Text;
            string address2 = txtAddress2.Text;
            string address3 = txtAddress3.Text;
            string tel1 = txtTel1.Text;
            string tel2 = txtTel2.Text;
            string tel3 = txtTel3.Text;

            BsNewResult result = BsCommon.Validate(txtCoName);
            if (result.OpType != OpType.Successful)
            {
                BsMessageBox.Show(result);
                return;
            }

            Company obj = new Company
            {
                CompanyName = name,
                StatusId = status,
                Explanation = explanation,
                Address1 = address1,
                Address2 = address2,
                Address3 = address3,
                Telephone1 = tel1,
                Telephone2 = tel2,
                Telephone3 = tel3
            };

            OCompanySave save = new OCompanySave(obj);
            result = save.Execute();
            BsMessageBox.Show(result);
            GetFormReady();
        }

        private void BsStandartToolStrip1_OkUpdateButtonClicked(object sender, EventArgs e)
        {
            string name = txtCoName.Text.Trim();
            int status = cmbStatus.SelectedIndex == 0 ? 1 : cmbStatus.SelectedIndex;
            string explanation = txtExp.Text;
            string address1 = txtAddress1.Text;
            string address2 = txtAddress2.Text;
            string address3 = txtAddress3.Text;
            string tel1 = txtTel1.Text;
            string tel2 = txtTel2.Text;
            string tel3 = txtTel3.Text;

            BsNewResult result = BsCommon.Validate(txtCoName);
            if (result.OpType != OpType.Successful)
            {
                BsMessageBox.Show(result);
                return;
            }

            Company obj = new Company
            {
                CompanyId = selectedItem.CompanyId,
                CompanyName = name,
                StatusId = status,
                Explanation = explanation,
                Address1 = address1,
                Address2 = address2,
                Address3 = address3,
                Telephone1 = tel1,
                Telephone2 = tel2,
                Telephone3 = tel3
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
                bsStandartToolStrip1.DisableUpdateDelete();
                return;
            }

            selectedItem = (Company)lvwCompany.SelectedItems[0].Tag;
            txtCoName.Text = selectedItem.CompanyName;
            cmbStatus.SelectedIndex = selectedItem.StatusId;
            txtExp.Text = selectedItem.Explanation;
            txtAddress1.Text = selectedItem.Address1;
            txtAddress2.Text = selectedItem.Address2;
            txtAddress3.Text = selectedItem.Address3;
            txtTel1.Text = selectedItem.Telephone1;
            txtTel2.Text = selectedItem.Telephone2;
            txtTel3.Text = selectedItem.Telephone3;

            bsStandartToolStrip1.EnableUpdateDelete();
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
                string[] row = { i.ToString(), obj.CompanyName, obj.StatusName, obj.Explanation };
                ListViewItem item = new ListViewItem(row) { Tag = obj };
                lvwCompany.Items.Add(item);
                i++;
            }
        }

        #endregion Events

        private void GetFormReady()
        {
            BsCommon.ClearControls(this);
            bsStandartToolStrip1.DisableUpdateDelete();
            FillCompanyList(); PopulateStatusCombo();
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
                    string[] row = { i.ToString(), obj.CompanyName, obj.StatusName, obj.Explanation };
                    ListViewItem item = new ListViewItem(row) { Tag = obj };
                    lvwCompany.Items.Add(item);
                    i++;
                }
            }
            lvwCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void PopulateStatusCombo()
        {
            OStatusGet get = new OStatusGet();
            get.Execute();
            statusList = get.StatusList;
            statusList.Add(new Status { StatusId = 0, StatusName = "Hepsi" });
            statusList = statusList.OrderBy(a => a.StatusId).ToList();

            cmbStatus.DataSource = statusList;
            cmbStatus.DisplayMember = "StatusName";
            cmbStatus.ValueMember = "StatusId";
        }

        public void SearchList()
        {
            string pattern = txtCoName.Text.Trim().ToLower();
            int status = cmbStatus.SelectedIndex;
            lvwCompany.Items.Clear();

            List<Company> patternList;
            if (status == 0)
            {
                patternList = companyList.Where(a => a.CompanyName.ToLower().Contains(pattern)).ToList();
            }
            else
            {
                patternList = companyList.Where(a => a.CompanyName.ToLower().Contains(pattern) &&
                                                a.StatusId == status).ToList();
            }

            int i = 1;
            foreach (Company obj in patternList)
            {
                string[] row = { i.ToString(), obj.CompanyName, obj.StatusId.ToString(), obj.Explanation };
                ListViewItem item = new ListViewItem(row) { Tag = obj };
                lvwCompany.Items.Add(item);
                i++;
            }
        }
    }
}