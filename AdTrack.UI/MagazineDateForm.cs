using AdTrack.Business;
using AdTrack.Data.Model;
using BigSoft.Framework.Controls;
using BigSoft.Framework.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace AdTrackForm
{
    public partial class MagazineDateForm : BsForm
    {
        private Magazine selectedMagazine;
        private int selectedYear;
        private int addedMonth;
        private int deletedMonth;
        private int selectedMagazineIndex;
        private int selectedYearIndex;

        public MagazineDateForm()
        {
            InitializeComponent();
            lvwMagazine.GenerateListView(2);
            lvwYear.GenerateListView(1);
            lvwMonth.GenerateListView(2);
            lvwExist.GenerateListView(2);
        }

        #region Events

        private void BsStandartToolStrip1_OkSaveButtonClicked(object sender, EventArgs e)
        {
            MagazineDate obj = new MagazineDate
            {
                MagazineId = selectedMagazine.MagazineId,
                Date = new DateTime(selectedYear, addedMonth, 1)
            };
            OMagazineDateSave save = new OMagazineDateSave(obj);
            BsNewResult result = save.Execute();
            BsMessageBox.Show(result);
            GetFormReady();
        }

        private void BsStandartToolStrip1_OkDeleteButtonClicked(object sender, EventArgs e)
        {
            MagazineDate obj = new MagazineDate
            {
                MagazineId = selectedMagazine.MagazineId,
                Date = new DateTime(selectedYear, deletedMonth, 1)
            };
            OMagazineDateDelete delete = new OMagazineDateDelete(obj);
            BsNewResult result = delete.Execute();
            BsMessageBox.Show(result);
            GetFormReady();
        }

        private void BsStandartToolStrip1_OkGetButtonClicked(object sender, EventArgs e)
        {
            selectedMagazine = null;
            GetFormReady();
        }

        private void LvwMonth_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvwMonth.SelectedItems.Count < 1)
            {
                bsStandartToolStrip1.DisableSave();
            }
            else
            {
                bsStandartToolStrip1.EnableSave();
                bsStandartToolStrip1.DisableUpdateDelete();
            }
        }

        private void LvwExist_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvwExist.SelectedItems.Count < 1)
            {
                bsStandartToolStrip1.DisableUpdateDelete();
            }
            else
            {
                bsStandartToolStrip1.EnableUpdateDelete();
                bsStandartToolStrip1.DisableSave();
            }
        }

        private void LvwMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMonth.SelectedItems.Count < 1)
            {
                bsStandartToolStrip1.DisableSave();
                addedMonth = 0;
                return;
            }
            bsStandartToolStrip1.EnableSave();
            bsStandartToolStrip1.DisableUpdateDelete();
            addedMonth = Convert.ToInt32(lvwMonth.SelectedItems[0].SubItems[2].Text);
        }

        private void LvwExist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwExist.SelectedItems.Count < 1)
            {
                bsStandartToolStrip1.DisableUpdateDelete();
                deletedMonth = 0;
                return;
            }
            bsStandartToolStrip1.EnableUpdateDelete();
            bsStandartToolStrip1.DisableSave();
            deletedMonth = Convert.ToInt32(lvwExist.SelectedItems[0].SubItems[2].Text);
        }

        private void LvwMagazine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMagazine.SelectedItems.Count < 1)
            {
                lvwExist.Items.Clear();
                lvwMonth.Items.Clear();
                selectedMagazine = null;
                return;
            }

            selectedMagazine = (Magazine)lvwMagazine.SelectedItems[0].Tag;
            selectedMagazineIndex = lvwMagazine.SelectedIndices[0];

            FillMonthList();
        }

        private void LvwYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwYear.SelectedItems.Count < 1)
            {
                lvwExist.Items.Clear();
                lvwMonth.Items.Clear();
                selectedYear = 0;
                return;
            }

            selectedYear = Convert.ToInt32(lvwYear.SelectedItems[0].Text);
            selectedYearIndex = lvwYear.SelectedIndices[0];
            FillMonthList();
        }

        private void MagazineDateForm_Load(object sender, EventArgs e)
        {
            GetFormReady();
        }

        #endregion Events

        private void GetFormReady()
        {
            BsCommon.ClearControls(this);
            bsStandartToolStrip1.DisableUpdateDelete();
            bsStandartToolStrip1.DisableSave();
            FillMagazineList();
            FillYearList();

            if (selectedMagazine != null)
            {
                lvwMagazine.Items[selectedMagazineIndex].Selected = true;
                lvwYear.Items[selectedYearIndex].Selected = true;
            }
        }

        private void FillMagazineList()
        {
            OMagazineGet get = new OMagazineGet();
            get.Execute();
            List<Magazine> magazineList = get.MagazineList;

            if (magazineList != null)
            {
                int i = 1;
                foreach (Magazine obj in get.MagazineList)
                {
                    string[] row = { i.ToString(), obj.MagazineName };
                    ListViewItem item = new ListViewItem(row) { Tag = obj };
                    lvwMagazine.Items.Add(item);
                    i++;
                }
            }
            lvwMagazine.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void FillYearList()
        {
            lvwYear.Items.Clear();
            lvwYear.Items.Add(new ListViewItem(new string[] { "2020" }));
            lvwYear.Items.Add(new ListViewItem(new string[] { "2019" }));
            lvwYear.Items.Add(new ListViewItem(new string[] { "2018" }));
            lvwYear.Items.Add(new ListViewItem(new string[] { "2017" }));
            lvwYear.Items.Add(new ListViewItem(new string[] { "2016" }));
            //lvwYear.Items[0].Selected = true;
            //selectedYear = Convert.ToInt32(lvwYear.SelectedItems[0].Text);
        }

        private void FillMonthList()
        {
            if (selectedMagazine == null || selectedYear == 0)
                return;

            lvwExist.Items.Clear();
            lvwMonth.Items.Clear();

            MagazineDate obj = new MagazineDate
            {
                MagazineId = selectedMagazine.MagazineId,
                Date = new DateTime(selectedYear, 1, 1)
            };

            OMagazineDateGet get = new OMagazineDateGet(obj);
            get.Execute();
            List<MagazineDate> objList = get.ObjList;

            List<int> months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //Kayıtlı aylar dolduruluyor
            int i = 1;
            foreach (MagazineDate maObj in objList)
            {
                months.Remove(maObj.Date.Month);
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(maObj.Date.Month);

                string[] row = { i.ToString(), monthName, maObj.Date.Month.ToString() };
                ListViewItem item = new ListViewItem(row);
                lvwExist.Items.Add(item);
                i++;
            }

            //Kayıtlı olmayan aylar dolduruluyor
            i = 1;
            foreach (int a in months)
            {
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(a);

                string[] row = { i.ToString(), monthName, a.ToString() };
                ListViewItem item = new ListViewItem(row);
                lvwMonth.Items.Add(item);
                i++;
            }

            lvwExist.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvwMonth.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}