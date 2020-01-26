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
        private Company _selectedItem;
        private List<Company> _companyList;
        private List<Status> _statusList;

        public CompanyForm()
        {
            InitializeComponent();
            lvwCompany.GenerateListView(4);
        }

        #region Events

        private void BsStandartToolStrip1_OkGetButtonClicked(object sender, EventArgs e)
        {
            bsStandartToolStrip1.DisableUpdateDelete();
            SearchListItems();
        }

        private void BsStandartToolStrip1_OkSaveButtonClicked(object sender, EventArgs e)
        {
            BsNewResult result = BsCommon.Validate(txtCoName);
            if (result.OpType != OpType.Successful)
            {
                BsMessageBox.Show(result);
                return;
            }
            Company obj = FillObject();

            OCompanySave save = new OCompanySave(obj);
            result = save.Execute();
            BsMessageBox.Show(result);
            GetFormReady();
        }

        private void BsStandartToolStrip1_OkUpdateButtonClicked(object sender, EventArgs e)
        {
            BsNewResult result = BsCommon.Validate(txtCoName);
            if (result.OpType != OpType.Successful)
            {
                BsMessageBox.Show(result);
                return;
            }

            Company obj = FillObject();
            OCompanyUpdate update = new OCompanyUpdate(obj);
            result = update.Execute();
            BsMessageBox.Show(result);
            GetFormReady();
        }

        private void BsStandartToolStrip1_OkDeleteButtonClicked(object sender, EventArgs e)
        {
            OCompanyDelete delete = new OCompanyDelete(_selectedItem.CompanyId);
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

            _selectedItem = (Company)lvwCompany.SelectedItems[0].Tag;
            txtCoName.Text = _selectedItem.CompanyName;
            cmbStatus.SelectedIndex = _selectedItem.StatusId;
            txtExp.Text = _selectedItem.Explanation;

            OAddressGet address = new OAddressGet(_selectedItem.CompanyId);
            address.Execute();

            if (address.AddressList.Count > 0)
            {
                txtAddress1.Text = address.AddressList[0].AddressText;
                switch (address.AddressList[0].Town)
                {
                    case 1:
                        rdoK1.Checked = true;
                        break;

                    case 2:
                        rdoV1.Checked = true;
                        break;

                    case 3:
                        rdoD1.Checked = true;
                        break;
                }
            }

            if (address.AddressList.Count > 1)
            {
                txtAddress2.Text = address.AddressList[1].AddressText;
                switch (address.AddressList[1].Town)
                {
                    case 1:
                        rdoK2.Checked = true;
                        break;

                    case 2:
                        rdoV2.Checked = true;
                        break;

                    case 3:
                        rdoD2.Checked = true;
                        break;
                }
            }

            if (address.AddressList.Count > 2)
            {
                txtAddress3.Text = address.AddressList[2].AddressText;
                switch (address.AddressList[2].Town)
                {
                    case 1:
                        rdoK3.Checked = true;
                        break;

                    case 2:
                        rdoV3.Checked = true;
                        break;

                    case 3:
                        rdoD3.Checked = true;
                        break;
                }
            }

            if (address.AddressList.Count == 0)
            {
                txtAddress1.Text = string.Empty;
                txtAddress2.Text = string.Empty;
                txtAddress3.Text = string.Empty;
            }

            OTelephoneGet tel = new OTelephoneGet(_selectedItem.CompanyId);
            tel.Execute();

            if (tel.TelephoneList.Count > 0)
                txtTel1.Text = tel.TelephoneList[0].TelNumber;
            if (tel.TelephoneList.Count > 1)
                txtTel2.Text = tel.TelephoneList[1].TelNumber;
            if (tel.TelephoneList.Count > 2)
                txtTel3.Text = tel.TelephoneList[2].TelNumber;

            if (tel.TelephoneList.Count == 0)
            {
                txtTel1.Text = string.Empty;
                txtTel2.Text = string.Empty;
                txtTel3.Text = string.Empty;
            }

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

            List<Company> patternList = _companyList.Where(a => a.CompanyName.ToLower().Contains(pattern.ToLower())).ToList();
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
            FillCompanyList();
            FillStatusCombo();
        }

        private void FillCompanyList()
        {
            OCompanyGet companyGet = new OCompanyGet();
            companyGet.Execute();
            _companyList = companyGet.CompanyList.OrderBy(x => x.CompanyName).ToList();

            lvwCompany.Items.Clear();
            WriteToList(_companyList);
            lvwCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void FillStatusCombo()
        {
            OStatusGet get = new OStatusGet();
            get.Execute();
            _statusList = get.StatusList;
            _statusList.Add(new Status { StatusId = 0, StatusName = "Hepsi" });
            _statusList = _statusList.OrderBy(a => a.StatusId).ToList();

            cmbStatus.DataSource = _statusList;
            cmbStatus.DisplayMember = "StatusName";
            cmbStatus.ValueMember = "StatusId";
        }

        public void SearchListItems()
        {
            string pattern = txtCoName.Text.Trim().ToLower();
            int status = cmbStatus.SelectedIndex;
            lvwCompany.Items.Clear();

            List<Company> patternList;
            if (status == 0)
            {
                patternList = _companyList.Where(a => a.CompanyName.ToLower().Contains(pattern)).ToList();
            }
            else
            {
                patternList = _companyList.Where(a => a.CompanyName.ToLower().Contains(pattern) &&
                                                a.StatusId == status).ToList();
            }

            WriteToList(patternList);
        }

        private void WriteToList(List<Company> list)
        {
            int i = 1;
            foreach (Company obj in list)
            {
                string[] row = { i.ToString(), obj.CompanyName, obj.StatusName, obj.Explanation };
                ListViewItem item = new ListViewItem(row) { Tag = obj };
                lvwCompany.Items.Add(item);
                i++;
            }
        }

        private Company FillObject()
        {
            Company obj = new Company
            {
                CompanyId = _selectedItem == null ? 0 : _selectedItem.CompanyId,
                CompanyName = _selectedItem.CompanyName,
                NewCompanyName = txtCoName.Text.Trim(),
                StatusId = cmbStatus.SelectedIndex == 0 ? 1 : cmbStatus.SelectedIndex,
                Explanation = txtExp.Text,
                Address1 = new Address { AddressText = txtAddress1.Text },
                Address2 = new Address { AddressText = txtAddress2.Text },
                Address3 = new Address { AddressText = txtAddress3.Text },
                Telephone1 = txtTel1.Text,
                Telephone2 = txtTel2.Text,
                Telephone3 = txtTel3.Text
            };

            if (rdoK1.Checked)
                obj.Address1.Town = 1;
            if (rdoV1.Checked)
                obj.Address1.Town = 2;
            if (rdoD1.Checked)
                obj.Address1.Town = 3;

            if (rdoK2.Checked)
                obj.Address1.Town = 1;
            if (rdoV2.Checked)
                obj.Address2.Town = 2;
            if (rdoD2.Checked)
                obj.Address2.Town = 3;

            if (rdoK3.Checked)
                obj.Address3.Town = 1;
            if (rdoV3.Checked)
                obj.Address3.Town = 2;
            if (rdoD3.Checked)
                obj.Address3.Town = 3;
            return obj;
        }
    }
}