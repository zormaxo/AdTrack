using AdTrack.Business;
using AdTrack.Data.Model;
using AdTrack.Util;
using BigSoft.Framework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdTrackForm.Report
{
    public partial class MagazineReportForm : BsForm
    {
        private List<Magazine> magazineList;
        private List<MagazineReport> magazineReportList;

        public MagazineReportForm()
        {
            InitializeComponent();
            lvwMagazine.GenerateListView(2);
            lvwSum.GenerateListView(3);
        }

        #region Events

        private void BsStandartToolStrip1_OkGetButtonClicked(object sender, EventArgs e)
        {
            GetFormReady();
        }

        private void LvwMagazine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMagazine.SelectedItems.Count < 1)
            {
                lvwSum.Items.Clear();
                return;
            }
            string selectedMagazineId = lvwMagazine.SelectedItems[0].SubItems[2].Text;
            FillDetailList(selectedMagazineId);
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            string pattern = txtFilter.Text.Trim();
            List<Magazine> patternList = magazineList.Where(a => a.MagazineName.ToLower().Contains(pattern.ToLower())).ToList();
            PopulateMagazineList(patternList);
        }

        private void CompanyReportForm_Load(object sender, EventArgs e)
        {
            GetFormReady();
        }

        #endregion Events

        private void GetFormReady()
        {
            FillMagazineList();
        }

        private void FillMagazineList()
        {
            OMagazineGet magazineGet = new OMagazineGet();
            magazineGet.Execute();
            magazineList = magazineGet.MagazineList.OrderBy(x => x.MagazineName).ToList();
            PopulateMagazineList(magazineList);
        }

        private void PopulateMagazineList(List<Magazine> list)
        {
            lvwMagazine.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string[] row = { (i + 1).ToString(), list[i].MagazineName, list[i].MagazineId.ToString() };
                ListViewItem item = new ListViewItem(row);
                lvwMagazine.Items.Add(item);
            }
            lvwMagazine.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void FillDetailList(string magazineId)
        {
            OMagazineReportGet get = new OMagazineReportGet(magazineId);
            get.Execute();
            magazineReportList = get.List;
            Common.WriteDtToExcel(magazineReportList, "Dergi Raporu", "CompanyName", "AdCount");
            PopulateSumList(magazineReportList);
        }

        private void PopulateSumList(List<MagazineReport> list)
        {
            lvwSum.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string[] row = { (i + 1).ToString(), list[i].CompanyName, list[i].AdCount.ToString() };
                ListViewItem item = new ListViewItem(row);
                lvwSum.Items.Add(item);
            }
            lvwSum.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}