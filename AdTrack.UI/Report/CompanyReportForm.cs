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
        private List<CompanyReport> companyReportList;
        private List<CompanyReport> companyDetaiList;
        private List<CompanyReport> sumList;
        private int selectedCompanyId;
        private DateTime startDate;
        private DateTime endDate;
        private List<int> statusList;

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
            selectedCompanyId = Convert.ToInt32(lvwCompany.SelectedItems[0].SubItems[4].Text);
            FillDetailList();
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            string pattern = txtFilter.Text.Trim();
            List<CompanyReport> patternList = companyReportList.Where(a => a.CompanyName.ToLower().Contains(pattern.ToLower())).ToList();
            PopulateCompanyList(patternList);
        }

        private void CompanyReportForm_Load(object sender, EventArgs e)
        {
            dtpEnd.Value = DateTime.Now;
            GetFormReady();
        }

        #endregion Events

        private void GetFormReady()
        {
            statusList = new List<int>();
            BsCommon.ClearControls(this);
            lvwDetails.Items.Clear();
            lvwSum.Items.Clear();
            startDate = dtpStart.Value;
            endDate = dtpEnd.Value;
            PopulateStatusList();
            FillCompanyList();
        }

        private void PopulateStatusList()
        {
            if (chkGenel.Checked)
                statusList.Add(1);
            if (chkFuar.Checked)
                statusList.Add(2);
            if (chkVermez.Checked)
                statusList.Add(3);
        }

        private void FillCompanyList()
        {
            OCompanyReportGet get = new OCompanyReportGet(startDate, endDate, statusList);
            get.Execute();
            companyReportList = get.List;
            PopulateCompanyList(companyReportList);
            Common.WriteDtToExcel(companyReportList, "Firma Raporu", "CompanyName", "AdCount");
        }

        private void FillDetailList()
        {
            OCompanyDetailGet get = new OCompanyDetailGet(selectedCompanyId, startDate, endDate, statusList);
            get.Execute();
            companyDetaiList = get.List;
            sumList = get.SumList;
            DataTable table1 = Common.ConvertToDatatable(companyDetaiList, "MagazineName", "Date", "PageDesc");
            DataTable table2 = Common.ConvertToDatatable(sumList, "MagazineName", "AdCount");
            Common.WriteDsToExcel("Detay Rapor", table1, table2);
            PopulateDetailList(companyDetaiList);
            PopulateSumList(sumList);
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

        private void PopulateCompanyList(List<CompanyReport> list)
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