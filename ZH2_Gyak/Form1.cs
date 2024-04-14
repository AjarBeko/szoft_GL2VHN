using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace ZH2_Gyak
{
    public partial class Form1 : Form
    {
        BindingList<Vizsgakérdés> kérdések = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat_coma.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Vizsgakérdés>();

                foreach (var item in tömb)
                {
                    kérdések.Add(item);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vizsgakérdésBindingSource.DataSource = kérdések;
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(kérdések);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (vizsgakérdésBindingSource.Current == null) return;

            if (MessageBox.Show("Biztosan törli a kérdést?", "Oldal törlése", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                vizsgakérdésBindingSource.RemoveCurrent();
            }
        }

        private void Addnew_Click(object sender, EventArgs e)
        {
            FormAddNew fan = new FormAddNew();
            if (fan.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (vizsgakérdésBindingSource.Current == null) return;
            
            FormEditData fed = new FormEditData();
            fed.ÚjVizsgaKérdés = (Vizsgakérdés)vizsgakérdésBindingSource.Current;

            fed.ShowDialog();

        }
    }
}
