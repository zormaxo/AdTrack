using AdTrackForm;
using AdTrackForm.Report;
using System;
using System.Windows.Forms;

namespace AdTrack.UI
{
    public partial class MdiContainer : Form
    {
        public MagazineForm MagazineForm { get; set; }
        public CompanyForm CompanyForm { get; set; }
        public MagazineDateForm MagazineDateForm { get; set; }
        public AdManForm AdManForm { get; set; }
        public CompanyReportForm CompanyReportForm { get; set; }
        public AboutForm AboutForm { get; set; }

        public MdiContainer()
        {
            InitializeComponent();
            okTabBrowser.SetMdiForm(this);
        }

        private void MenuCreateMag_Click(object sender, EventArgs e)
        {
            if (MagazineForm?.IsDisposed != false)
            {
                MagazineForm = new MagazineForm { MdiParent = this };
                MagazineForm.Show();
            }
            else
            {
                MagazineForm.Activate();
            }
        }

        private void MenuCreateDate_Click(object sender, EventArgs e)
        {
            if (MagazineDateForm?.IsDisposed != false)
            {
                MagazineDateForm = new MagazineDateForm { MdiParent = this };
                MagazineDateForm.Show();
            }
            else
            {
                MagazineDateForm.Activate();
            }
        }

        private void MenuFirma_Click(object sender, EventArgs e)
        {
            if (CompanyForm?.IsDisposed != false)
            {
                CompanyForm = new CompanyForm { MdiParent = this };
                CompanyForm.Show();
            }
            else
            {
                CompanyForm.Activate();
            }
        }

        private void MenuAd_Click(object sender, EventArgs e)
        {
            if (AdManForm?.IsDisposed != false)
            {
                AdManForm = new AdManForm { MdiParent = this };
                AdManForm.Show();
            }
            else
            {
                AdManForm.Activate();
            }
        }

        private void MenuCompanyReport_Click(object sender, EventArgs e)
        {
            if (CompanyReportForm?.IsDisposed != false)
            {
                CompanyReportForm = new CompanyReportForm { MdiParent = this };
                CompanyReportForm.Show();
            }
            else
            {
                CompanyReportForm.Activate();
            }
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            if (AboutForm?.IsDisposed != false)
            {
                AboutForm = new AboutForm { MdiParent = this };
                AboutForm.Show();
            }
            else
            {
                AboutForm.Activate();
            }
        }
    }
}