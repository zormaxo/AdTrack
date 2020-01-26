using AdTrack.Business;
using AdTrack.Data.Model;
using AdTrack.Util;
using BigSoft.Framework.Controls;
using BigSoft.Framework.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace AdTrackForm.Report
{
    public partial class CompanyReportForm : BsForm
    {
        private List<CompanyReport> _companyReportList;
        private List<CompanyReport> _companyDetaiList;
        private List<CompanyReport> _sumList;
        private int _selectedCompanyId;
        private List<int> _statusList;

        public CompanyReportForm()
        {
            InitializeComponent();
            lvwCompany.GenerateListView(4);
            lvwDetails.GenerateListView(5);
            lvwSum.GenerateListView(3);
        }

        #region Events

        private void BsStandartToolStrip1_OkGetButtonClicked(object sender, EventArgs e)
        {
            GetFormReady();
        }

        private void LvwCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwCompany.SelectedItems.Count < 1)
            {
                lvwDetails.Items.Clear();
                return;
            }
            _selectedCompanyId = Convert.ToInt32(lvwCompany.SelectedItems[0].SubItems[4].Text);
            FillDetailList();
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            string pattern = txtFilter.Text.Trim();
            List<CompanyReport> patternList = _companyReportList.Where(a => a.CompanyName.ToLower().Contains(pattern.ToLower())).ToList();
            WriteToList(patternList);
        }

        private void CompanyReportForm_Load(object sender, EventArgs e)
        {
            dtpEnd.Value = DateTime.Now;
            GetFormReady();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            bool fair = chkFair.Checked;
            OCompanyAddressGet get = new OCompanyAddressGet(dtpStart.Value, dtpEnd.Value, _statusList, fair);
            get.Execute();
            Common.WriteDtToExcel(get.List, "Firma Adresleri", "CompanyName", "StatusName", "AddressText", "TownName", "AdCount");
            BsMessageBox.ShowSuccess("Excel dosyası oluşturuldu.");
        }

        #endregion Events

        private void GetFormReady()
        {
            BsCommon.ClearControls(this);
            FillStatusList();
            GetCompanyList();
        }

        private void FillStatusList()
        {
            _statusList = new List<int>();
            if (chkGenel.Checked)
                _statusList.Add(1);
            if (chkFuar.Checked)
                _statusList.Add(2);
            if (chkVermez.Checked)
                _statusList.Add(3);
        }

        private void GetCompanyList()
        {
            bool fair = chkFair.Checked;
            OCompanyReportGet get = new OCompanyReportGet(dtpStart.Value, dtpEnd.Value, _statusList, fair);
            get.Execute();
            _companyReportList = get.List;
            WriteToList(_companyReportList);
            Common.WriteDtToExcel(_companyReportList, "Firma Raporu", "CompanyName", "AdCount");
        }

        private void FillDetailList()
        {
            bool fair = chkFair.Checked;
            OCompanyDetailGet get = new OCompanyDetailGet(_selectedCompanyId, dtpStart.Value, dtpEnd.Value, fair);
            get.Execute();
            _companyDetaiList = get.List;
            _sumList = get.SumList;
            DataTable table1 = Common.ConvertToDatatable(_companyDetaiList, "MagazineName", "Date", "PageDesc");
            DataTable table2 = Common.ConvertToDatatable(_sumList, "MagazineName", "AdCount");
            Common.WriteDsToExcel("Detay Rapor", table1, table2);
            PopulateDetailList(_companyDetaiList);
            PopulateSumList(_sumList);
        }

        private void PopulateDetailList(List<CompanyReport> list)
        {
            lvwDetails.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(list[i].Date.Month);
                string year = list[i].Date.Year.ToString();
                string[] row = { (i + 1).ToString(), list[i].MagazineName, year, monthName, list[i].PageDesc };
                ListViewItem item = new ListViewItem(row);
                lvwDetails.Items.Add(item);
            }
            lvwDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void PopulateSumList(List<CompanyReport> list)
        {
            lvwSum.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string[] row = { (i + 1).ToString(), list[i].MagazineName, list[i].AdCount.ToString() };
                ListViewItem item = new ListViewItem(row);
                lvwSum.Items.Add(item);
            }
            lvwSum.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void WriteToList(List<CompanyReport> list)
        {
            lvwCompany.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string[] row = { (i + 1).ToString(), list[i].CompanyName, list[i].AdCount.ToString(), list[i].StatusName, list[i].CompanyId.ToString() };
                ListViewItem item = new ListViewItem(row);
                lvwCompany.Items.Add(item);
            }
            lvwCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}