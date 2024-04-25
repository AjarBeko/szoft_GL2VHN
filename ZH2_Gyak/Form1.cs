using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace ZH2_Gyak
{
    public partial class Form1 : Form
    {
        BindingList<Vizsgak�rd�s> k�rd�sek = new();
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
                var t�mb = csv.GetRecords<Vizsgak�rd�s>();

                foreach (var item in t�mb)
                {
                    k�rd�sek.Add(item);
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
            vizsgak�rd�sBindingSource.DataSource = k�rd�sek;
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
                    csv.WriteRecords(k�rd�sek);
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
            if (vizsgak�rd�sBindingSource.Current == null) return;

            if (MessageBox.Show("Biztosan t�rli a k�rd�st?", "Oldal t�rl�se", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                vizsgak�rd�sBindingSource.RemoveCurrent();
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
            if (vizsgak�rd�sBindingSource.Current == null) return;
            
            FormEditData fed = new FormEditData();
            fed.�jVizsgaK�rd�s = (Vizsgak�rd�s)vizsgak�rd�sBindingSource.Current;

            fed.ShowDialog();

        }
    }
}
