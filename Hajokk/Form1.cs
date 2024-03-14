namespace Hajokk
{
    public partial class Form1 : Form
    {
        List<Kérdések> ÖsszesKérdés;
        List<Kérdések> AktuálisKérdések;
        int AktuálisKérdés = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ÖsszesKérdés = KérdésBetöltés();
            AktuálisKérdések = new List<Kérdések>();

            for (int i = 0; i < 7; i++)
            {
                AktuálisKérdések.Add(ÖsszesKérdés[0]);
                ÖsszesKérdés.RemoveAt(0);
            }
            dataGridView1.DataSource = AktuálisKérdések;

            Kérdésmegjelenítés(AktuálisKérdések[AktuálisKérdés]);
        }

        void Kérdésmegjelenítés(Kérdések kérdések)
        {
            label1.Text = kérdések.KérdésSzöveg;
            válaszGomb1.Text = kérdések.Válasz1;
            válaszGomb2.Text = kérdések.Válasz2;
            válaszGomb3.Text = kérdések.Válasz3;

            if (string.IsNullOrEmpty(kérdések.URL))
            {

                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdések.URL);
            }
        }

        List<Kérdések> KérdésBetöltés()
        {
            List<Kérdések> kérdések = new List<Kérdések>();

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] tömb = sor.Split("\t");
                if (tömb.Length != 7) continue;
                Kérdések k = new Kérdések();
                k.KérdésSzöveg = tömb[1];
                k.Válasz1 = tömb[2];
                k.Válasz2 = tömb[3];
                k.Válasz3 = tömb[4];
                k.URL = tömb[5];
                int.TryParse(tömb[6], out int jóválasz);
                k.HelyesVálasz = jóválasz;
                kérdések.Add(k);
            }
            sr.Close();
            return kérdések;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kérdésmegjelenítés(AktuálisKérdések[AktuálisKérdés++]);
            if (AktuálisKérdés == 7)
            {
                AktuálisKérdés = 0;
            }
        }


        private void válaszGomb1_Click(object sender, EventArgs e)
        {
            if (AktuálisKérdések[AktuálisKérdés].HelyesVálasz == 1)
            {
                válaszGomb1.BackColor  = Color.Green;
            }
            else
            {
                válaszGomb2.BackColor = Color.Red;
                válaszGomb3.BackColor = Color.Red;
            }

        }

        private void válaszGomb2_Click(object sender, EventArgs e)
        {
            if (AktuálisKérdések[AktuálisKérdés].HelyesVálasz == 2)
            {
                válaszGomb2.BackColor = Color.Green;
            }
            else
            {
                válaszGomb1.BackColor = Color.Red;
                válaszGomb3.BackColor = Color.Red;
            }

        }

        private void válaszGomb3_Click(object sender, EventArgs e)
        {
            if (AktuálisKérdések[AktuálisKérdés].HelyesVálasz == 3)
            {
                válaszGomb3.BackColor = Color.Green;
            }
            else
            {
                válaszGomb2.BackColor = Color.Red;
                válaszGomb1.BackColor = Color.Red;
            }

        }
    }
}