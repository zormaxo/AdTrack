using System.Windows.Forms;

namespace AdTrack.Controls
{
    public partial class AdListView : ListView
    {
        public AdListView()
        {
            InitializeComponent();
        }

        public void GenerateListView(int columnCount)
        {
            FullRowSelect = true;
            GridLines = true;
            View = View.Details;
            HeaderStyle = ColumnHeaderStyle.None;
            MultiSelect = false;
            Scrollable = false;

            for (int i = 0; i < columnCount; i++)
            {
                Columns.Add(i.ToString());
                Columns[i].Width = -2;
            }
        }
    }
}