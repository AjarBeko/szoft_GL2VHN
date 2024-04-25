using CsvHelper;
using System.ComponentModel;
using System.Globalization;
using System.Xml.Linq;

namespace ZH2_1
{
    public partial class Form1 : Form
    {
        BindingList<VizsgaKerdesek> kérdések = new();
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
                var tömb = csv.GetRecords<VizsgaKerdesek>();

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
            vizsgaKerdesekBindingSource.DataSource = kérdések;
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
            if (vizsgaKerdesekBindingSource.Current == null) return;

            if (MessageBox.Show("Töröl bizti?", "Törlés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                vizsgaKerdesekBindingSource.RemoveCurrent();
            }



        }

        private void new_data_Click(object sender, EventArgs e)
        {
            FormNewData fnd = new FormNewData();
            if (fnd.ShowDialog() == DialogResult.OK)
            {
                fnd.ShowDialog();
            }

        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (vizsgaKerdesekBindingSource.Current == null) return;
            /*if (vizsgaKerdesekBindingSource.Current is VizsgaKerdesek)
            {
                FormEdit fed = new FormEdit();
                fed.ÚjVizsgaKérdés = (VizsgaKerdesek)vizsgaKerdesekBindingSource.Current;
    
                fed.ShowDialog();
            }*/


        }
    }
}
