using AdTrack.Business;
using AdTrack.Data.Model;
using BigSoft.Framework.Controls;
using BigSoft.Framework.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace AdTrackForm
{
    public partial class AdManForm : BsForm
    {
        private Magazine selectedMagazine;
        private int selectedYear;
        private int selectedDateId;
        private int selectedMagazineIndex;
        private int selectedYearIndex;
        private int selectedMonthIndex;
        private List<Advertisement> companyList = new List<Advertisement>();
        private List<Advertisement> advertisementList = new List<Advertisement>();
        private int selectedAd;
        private int selectedCompany;

        public AdManForm()
        {
            InitializeComponent();
            lvwMagazine.GenerateListView(2);
            lvwYear.GenerateListView(1);
            lvwExist.GenerateListView(2);
            lvwAdList.GenerateListView(3);
            lvwAllCompany.GenerateListView(2);
        }

        #region Events

        private void BsStandartToolStrip1_OkSaveButtonClicked(object sender, EventArgs e)
        {
            if (advertisementList.Count(a => a.PageId == 1) != 1)
            {
                BsMessageBox.ShowError("Bir kapak reklamı girin");
                return;
            }
            if (advertisementList.Count(a => a.PageId == 2) != 1)
            {
                BsMessageBox.ShowError("Bir kapak içi reklamı girin");
                return;
            }
            if (advertisementList.Count(a => a.PageId == 3) != 1)
            {
                BsMessageBox.ShowError("Bir arka kapak reklamı girin");
                return;
            }

            OAdvertisementSave save = new OAdvertisementSave(advertisementList, selectedDateId);
            BsNewResult result = save.Execute();
            BsMessageBox.Show(result);
            GetFormReady();
        }

        private void BsStandartToolStrip1_OkGetButtonClicked(object sender, EventArgs e)
        {
            selectedMagazine = null;
            GetFormReady();
        }

        private void LvwMagazine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMagazine.SelectedItems.Count < 1)
            {
                ClearListViews();
                selectedMagazine = null;
                return;
            }

            selectedMagazine = (Magazine)lvwMagazine.SelectedItems[0].Tag;
            WriteLabel();
            selectedMagazineIndex = lvwMagazine.SelectedIndices[0];
            FillMonthList();
        }

        private void LvwYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwYear.SelectedItems.Count < 1)
            {
                ClearListViews();
                selectedYear = 0;
                return;
            }
            selectedYear = Convert.ToInt32(lvwYear.SelectedItems[0].Text);
            selectedYearIndex = lvwYear.SelectedIndices[0];
            WriteLabel();
            FillMonthList();
        }

        private void LvwExist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwExist.SelectedItems.Count < 1)
            {
                lblMagazine.Text = string.Empty;
                lvwAdList.Items.Clear();
                lvwAllCompany.Items.Clear();
                return;
            }

            string selectedMonth = lvwExist.SelectedItems[0].SubItems[1].Text;
            selectedDateId = Convert.ToInt32(lvwExist.SelectedItems[0].SubItems[2].Text);
            selectedMonthIndex = lvwExist.SelectedIndices[0];
            WriteLabel(selectedMonth);
            GetCompanyList();
            GetAdList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            RadioButton checkedButton = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (selectedCompany == 0 || checkedButton == null || lvwAllCompany.SelectedItems.Count == 0)
                return;

            Advertisement obj = ((Advertisement)lvwAllCompany.SelectedItems[0].Tag);
            obj.PageId = GetPageId();
            obj.PageDesc = checkedButton.Text;

            //listeye ekle
            advertisementList.Add(obj);
            //listeden çıkar
            companyList.RemoveAll(x => x.CompanyId == selectedCompany);

            ListViewItem listViewItem = lvwAllCompany.SelectedItems[0];
            int selectedIndex = lvwAllCompany.SelectedIndices[0];
            lvwAllCompany.Items.RemoveAt(selectedIndex);

            listViewItem.Tag = obj;
            if (listViewItem.SubItems.Count == 2)
                listViewItem.SubItems.Add(checkedButton.Text);
            else
                listViewItem.SubItems[2].Text = checkedButton.Text;
            lvwAdList.Items.Add(listViewItem);

            ResizeColumns(lvwAllCompany, lvwAdList);
            FocusTextBox();
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            if (selectedAd == 0)
                return;

            Advertisement obj = ((Advertisement)lvwAdList.SelectedItems[0].Tag);

            //Listviewler
            int selectedIndex = lvwAdList.SelectedIndices[0];
            ListViewItem listViewItem = lvwAdList.SelectedItems[0];
            lvwAdList.Items.RemoveAt(selectedIndex);
            lvwAllCompany.Items.Add(listViewItem);

            //listeler
            advertisementList.RemoveAll(x => x.CompanyId == selectedCompany);
            companyList.Add(obj);

            ResizeColumns(lvwAllCompany, lvwAdList);
            FocusTextBox();
        }

        private void LvwAdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwAdList.SelectedItems.Count < 1)
            {
                selectedAd = 0;
                return;
            }
            bsStandartToolStrip1.EnableSave();
            selectedAd = ((Advertisement)lvwAdList.SelectedItems[0].Tag).CompanyId;
        }

        private void LvwAllCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwAllCompany.SelectedItems.Count < 1)
            {
                selectedCompany = 0;
                return;
            }
            bsStandartToolStrip1.EnableSave();
            selectedCompany = ((Advertisement)lvwAllCompany.SelectedItems[0].Tag).CompanyId;
        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {
            string pattern = txtAd.Text.Trim();
            lvwAdList.Items.Clear();

            List<Advertisement> patternList = advertisementList.Where(a => a.CompanyName.ToLower().Contains(pattern.ToLower())).ToList();
            int i = 1;
            foreach (Advertisement obj in patternList)
            {
                string[] row = { i.ToString(), obj.CompanyName, obj.PageDesc };
                ListViewItem item = new ListViewItem(row) { Tag = obj };
                lvwAdList.Items.Add(item);
                i++;
            }
        }

        private void TxtAll_TextChanged(object sender, EventArgs e)
        {
            string pattern = txtAll.Text.Trim();
            lvwAllCompany.Items.Clear();

            List<Advertisement> patternList = companyList.Where(a => a.CompanyName.ToLower().Contains(pattern.ToLower())).ToList();
            int i = 1;
            foreach (Advertisement obj in patternList)
            {
                string[] row = { i.ToString(), obj.CompanyName };
                ListViewItem item = new ListViewItem(row) { Tag = obj };
                lvwAllCompany.Items.Add(item);
                i++;
            }
            if (lvwAllCompany.Items.Count > 0)
                lvwAllCompany.Items[0].Selected = true;
            ResizeColumns(lvwAllCompany);
        }

        private void AdManForm_Load(object sender, EventArgs e)
        {
            GetFormReady();
        }

        #endregion Events

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            List<TextBox> textBoxes = Controls.OfType<TextBox>().ToList();
            int selected = 0;
            if (lvwAllCompany.SelectedIndices.Count > 0)
                selected = lvwAllCompany.SelectedIndices[0];
            switch (keyData)
            {
                case (Keys.Alt | Keys.Z):
                case Keys.Enter:
                    BtnAdd_Click(null, null);
                    return true;

                case (Keys.Alt | Keys.C):
                case Keys.Delete:
                    if (textBoxes.Any(a => a.Focused))
                    {
                        return base.ProcessCmdKey(ref msg, keyData);
                    }
                    BtnSubtract_Click(null, null);
                    return true;

                case (Keys.Alt | Keys.X):
                    FocusTextBox();
                    return true;

                case Keys.Up:
                    selected--;
                    if (selected < 0) //check if already on the first row
                        selected = 0;
                    lvwAllCompany.Items[selected].Selected = true;
                    return true;

                case Keys.Down:
                    selected++; //Change index to the row below the current one
                    if (selected > lvwAllCompany.Items.Count - 1) //check if index out of range
                        selected = lvwAllCompany.Items.Count - 1;
                    lvwAllCompany.Items[selected].Selected = true;
                    return true;

                case Keys.D1:
                    rbtKapak.Checked = true;
                    FocusTextBox();
                    return true;

                case Keys.D2:
                    rbtKapakIci.Checked = true;
                    FocusTextBox();
                    return true;

                case Keys.D3:
                    rbtArkaKapak.Checked = true;
                    FocusTextBox();
                    return true;

                case Keys.D4:
                    rbt2Pages.Checked = true;
                    FocusTextBox();
                    return true;

                case Keys.D5:
                    rbt1Page.Checked = true;
                    FocusTextBox();
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

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
                lvwExist.Items[selectedMonthIndex].Selected = true;
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
            ResizeColumns(lvwMagazine);
        }

        private void FillYearList()
        {
            lvwYear.Items.Add(new ListViewItem(new string[] { "2020" }));
            lvwYear.Items.Add(new ListViewItem(new string[] { "2019" }));
            lvwYear.Items.Add(new ListViewItem(new string[] { "2018" }));
            lvwYear.Items.Add(new ListViewItem(new string[] { "2017" }));
            lvwYear.Items.Add(new ListViewItem(new string[] { "2016" }));
        }

        private void FillMonthList()
        {
            lvwExist.Items.Clear();
            if (selectedMagazine == null || selectedYear == 0)
                return;

            MagazineDate obj = new MagazineDate
            {
                MagazineId = selectedMagazine.MagazineId,
                Date = new DateTime(selectedYear, 1, 1)
            };

            OMagazineDateGet get = new OMagazineDateGet(obj);
            get.Execute();
            List<MagazineDate> objList = get.ObjList;

            //Kayıtlı aylar dolduruluyor
            int i = 1;
            foreach (MagazineDate maObj in objList)
            {
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(maObj.Date.Month);
                string[] row = { i.ToString(), monthName, maObj.MagazineDateId.ToString() };
                ListViewItem item = new ListViewItem(row);
                lvwExist.Items.Add(item);
                i++;
            }
            ResizeColumns(lvwMagazine);
        }

        private void GetCompanyList()
        {
            OCompanyGet companyGet = new OCompanyGet();
            companyGet.Execute();
            List<Company> list = companyGet.CompanyList.OrderBy(a => a.CompanyName).ToList();

            companyList = new List<Advertisement>();
            foreach (Company item in list)
            {
                Advertisement obj = new Advertisement() { CompanyId = item.CompanyId, CompanyName = item.CompanyName };
                companyList.Add(obj);
            }
        }

        private void GetAdList()
        {
            OAdvertisementGet get = new OAdvertisementGet(selectedDateId);
            get.Execute();
            List<Advertisement> list = get.ObjList.OrderBy(a => a.CompanyName).ToList();

            advertisementList = new List<Advertisement>();
            foreach (Advertisement item in list)
            {
                Advertisement obj = companyList.Find(x => x.CompanyId == item.CompanyId);
                companyList.Remove(obj);
                advertisementList.Add(item);
            }

            FillLists();
        }

        private void FillLists()
        {
            lvwAdList.Items.Clear();
            lvwAllCompany.Items.Clear();

            //Bütün firmalar
            if (companyList != null)
            {
                int i = 1;
                foreach (Advertisement obj in companyList)
                {
                    string[] row = { i.ToString(), obj.CompanyName };
                    ListViewItem item = new ListViewItem(row) { Tag = obj };
                    lvwAllCompany.Items.Add(item);
                    i++;
                }
            }

            //Kayıtlı reklamalar
            if (advertisementList != null)
            {
                int i = 1;
                foreach (Advertisement obj in advertisementList)
                {
                    string[] row = { i.ToString(), obj.CompanyName, obj.PageDesc };
                    ListViewItem item = new ListViewItem(row) { Tag = obj };
                    lvwAdList.Items.Add(item);
                    i++;
                }
            }

            ResizeColumns(lvwAllCompany, lvwAdList);
            selectedCompany = 0;
            selectedAd = 0;
        }

        private void ClearListViews()
        {
            lblMagazine.Text = string.Empty;
            lvwExist.Items.Clear();
            lvwAdList.Items.Clear();
            lvwAllCompany.Items.Clear();
            bsStandartToolStrip1.DisableSave();
        }

        private void WriteLabel(string selectedMonth = "")
        {
            if (selectedMagazine == null)
                return;
            lblMagazine.Text = string.Format("{0} {1} {2}", selectedMagazine.MagazineName, selectedYear, selectedMonth);
        }

        private void ResizeColumns(params ListView[] listview)
        {
            foreach (ListView view in listview)
                view.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private int GetPageId()
        {
            if (rbtKapak.Checked)
                return 1;
            if (rbtKapakIci.Checked)
                return 2;
            if (rbtArkaKapak.Checked)
                return 3;
            if (rbt2Pages.Checked)
                return 4;
            if (rbt1Page.Checked)
                return 5;
            return 0;
        }

        public void FocusTextBox()
        {
            txtAll.Focus();
            txtAll.SelectAll();
        }
    }
}