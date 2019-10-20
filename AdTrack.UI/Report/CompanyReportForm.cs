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
        private string selectedYear;

        public CompanyReportForm()
        {
            InitializeComponent();
            lvwCompany.GenerateListView(3);
            lvwDetails.GenerateListView(5);
            lvwSum.GenerateListView(3);
        }

        #region Events

        private void BsStandartToolStrip1_OkGetButtonClicked(object sender, EventArgs e)
        {
            GetFormReady();
        }

        private void CbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedYear = cbxYear.SelectedItem.ToString();
            lvwDetails.Items.Clear();
            lvwSum.Items.Clear();
            FillCompanyList(selectedYear);
        }

        private void LvwCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwCompany.SelectedItems.Count < 1)
            {
                lvwDetails.Items.Clear();
                return;
            }
            selectedCompanyId = Convert.ToInt32(lvwCompany.SelectedItems[0].SubItems[3].Text);
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
            GetFormReady();
        }

        #endregion Events

        private void GetFormReady()
        {
            BsCommon.ClearControls(this);
            bsStandartToolStrip1.DisableButtons();
            FillYearList();
        }

        private void FillCompanyList(string selectedYear)
        {
            OCompanyReportGet get = new OCompanyReportGet(selectedYear);
            get.Execute();
            companyReportList = get.List;
            PopulateCompanyList(companyReportList);
        }

        private void FillYearList()
        {
            List<int> years = Common.GetYears();
            cbxYear.Items.Clear();
            cbxYear.Items.Add("Hepsi");

            foreach (int item in years)
                cbxYear.Items.Add(item);

            cbxYear.SelectedIndex = 0;
        }

        private void FillDetailList()
        {
            OCompanyDetailGet get = new OCompanyDetailGet(selectedCompanyId, selectedYear);
            get.Execute();
            companyDetaiList = get.List;
            sumList = get.SumList;
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
                string[] row = { (i + 1).ToString(), list[i].CompanyName, list[i].AdCount.ToString(), list[i].CompanyId.ToString() };
                ListViewItem item = new ListViewItem(row);
                lvwCompany.Items.Add(item);
            }
            lvwCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}