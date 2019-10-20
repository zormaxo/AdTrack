using AdTrack.Business;
using AdTrack.Data.Model;
using BigSoft.Framework.Controls;
using BigSoft.Framework.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdTrack.UI
{
    public partial class MagazineForm : BsForm
    {
        private Magazine selectedMagazine;
        private List<Magazine> magazineList;

        public MagazineForm()
        {
            InitializeComponent();
            lvwMagazine.GenerateListView(2);
        }

        #region Events

        private void BsStandartToolStrip1_OkGetButtonClicked(object sender, EventArgs e)
        {
            bsStandartToolStrip1.DisableButtons();
            SearchList();
        }

        private void BsStandartToolStrip1_OkSaveButtonClicked(object sender, EventArgs e)
        {
            string magazineName = txtMaName.Text.Trim();
            BsNewResult result = BsCommon.Validate(txtMaName);
            txtMaName.Clear();
            if (result.OpType != OpType.Successful)
            {
                BsMessageBox.Show(result);
                return;
            }

            OMagazineSave magazineSave = new OMagazineSave(magazineName);
            result = magazineSave.Execute();
            BsMessageBox.Show(result);
            GetFormReady();
        }

        private void BsStandartToolStrip1_OkDeleteButtonClicked(object sender, EventArgs e)
        {
            OMagazineDelete magazineDelete = new OMagazineDelete(selectedMagazine.MagazineId);
            BsNewResult result = magazineDelete.Execute();
            BsMessageBox.Show(result);
            GetFormReady();
        }

        private void BsStandartToolStrip1_OkUpdateButtonClicked(object sender, EventArgs e)
        {
            string magazineName = txtMaName.Text.Trim();
            BsNewResult result = BsCommon.Validate(txtMaName);
            if (result.OpType != OpType.Successful)
            {
                BsMessageBox.Show(result);
                return;
            }

            Magazine magazine = new Magazine
            {
                MagazineId = selectedMagazine.MagazineId,
                MagazineName = magazineName
            };

            OMagazineUpdate magazineUpdate = new OMagazineUpdate(magazine);
            result = magazineUpdate.Execute();
            BsMessageBox.Show(result);
            GetFormReady();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetFormReady();
        }

        private void LvwMagazine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMagazine.SelectedItems.Count < 1)
            {
                bsStandartToolStrip1.DisableButtons();
                return;
            }
            selectedMagazine = (Magazine)lvwMagazine.SelectedItems[0].Tag;
            txtMaName.Text = selectedMagazine.MagazineName;

            bsStandartToolStrip1.EnableButtons();
        }

        private void TxtMaName_TextChanged(object sender, EventArgs e)
        {
            //string pattern = txtMaName.Text.Trim();
            //lvwMagazine.Items.Clear();

            //List<Magazine> patternList = magazineList.Where(a => a.MagazineName.ToLower().Contains(pattern.ToLower())).ToList();
            //int i = 1;
            //foreach (Magazine obj in patternList)
            //{
            //    string[] row = { i.ToString(), obj.MagazineName };
            //    ListViewItem item = new ListViewItem(row) { Tag = obj };
            //    lvwMagazine.Items.Add(item);
            //    i++;
            //}
        }

        #endregion Events

        private void GetFormReady()
        {
            BsCommon.ClearControls(this);
            bsStandartToolStrip1.DisableButtons();
            FillMagazineList();
        }

        private void FillMagazineList()
        {
            OMagazineGet magazineGet = new OMagazineGet();
            magazineGet.Execute();
            magazineList = magazineGet.MagazineList.OrderBy(x => x.MagazineName).ToList();

            lvwMagazine.Items.Clear();

            if (magazineList != null)
            {
                int i = 1;
                foreach (Magazine obj in magazineList)
                {
                    string[] row = { i.ToString(), obj.MagazineName };
                    ListViewItem item = new ListViewItem(row) { Tag = obj };
                    lvwMagazine.Items.Add(item);
                    i++;
                }
            }
            lvwMagazine.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public void SearchList()
        {
            string pattern = txtMaName.Text.Trim();
            lvwMagazine.Items.Clear();

            List<Magazine> patternList = magazineList.Where(a => a.MagazineName.ToLower().Contains(pattern.ToLower())).ToList();
            int i = 1;
            foreach (Magazine obj in patternList)
            {
                string[] row = { i.ToString(), obj.MagazineName };
                ListViewItem item = new ListViewItem(row) { Tag = obj };
                lvwMagazine.Items.Add(item);
                i++;
            }
        }
    }
}