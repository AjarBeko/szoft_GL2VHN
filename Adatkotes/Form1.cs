using CsvHelper;
using System.ComponentModel;
using System.Globalization;
using System.Xml;

namespace Adatkotes
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void Megnyitás_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tömb = csv.GetRecords<CountryData>();
            foreach (var t in tömb)
            {
                countryList.Add(t);
            }
            sr.Close();
        }

        private void Törlés_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void Szerkesztés_Click(object sender, EventArgs e)
        {
            Szerkesztes fce = new Szerkesztes();
            fce.Data = countryDataBindingSource.Current as CountryData;
            fce.Show();
        }

        private void Mentés_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("european_countries.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(countryList);
            };
        }
    }
}