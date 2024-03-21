namespace Hajokk
{
    public partial class Form1 : Form
    {
        List<K�rd�sek> �sszesK�rd�s;
        List<K�rd�sek> Aktu�lisK�rd�sek;
        int Aktu�lisK�rd�s = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            �sszesK�rd�s = K�rd�sBet�lt�s();
            Aktu�lisK�rd�sek = new List<K�rd�sek>();

            for (int i = 0; i < 7; i++)
            {
                Aktu�lisK�rd�sek.Add(�sszesK�rd�s[0]);
                �sszesK�rd�s.RemoveAt(0);
            }
            dataGridView1.DataSource = Aktu�lisK�rd�sek;

            K�rd�smegjelen�t�s(Aktu�lisK�rd�sek[Aktu�lisK�rd�s]);
        }

        void K�rd�smegjelen�t�s(K�rd�sek k�rd�sek)
        {
            label1.Text = k�rd�sek.K�rd�sSz�veg;
            V�lG1.Text = k�rd�sek.V�lasz1;
            V�lG2.Text = k�rd�sek.V�lasz2;
            V�lG3.Text = k�rd�sek.V�lasz3;

            if (string.IsNullOrEmpty(k�rd�sek.URL))
            {

                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + k�rd�sek.URL);
            }
        }

        List<K�rd�sek> K�rd�sBet�lt�s()
        {
            List<K�rd�sek> k�rd�sek = new List<K�rd�sek>();

            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] t�mb = sor.Split("\t");
                    if (t�mb.Length != 7) continue;
                    K�rd�sek k = new K�rd�sek();
                    k.K�rd�sSz�veg = t�mb[1];
                    k.V�lasz1 = t�mb[2];
                    k.V�lasz2 = t�mb[3];
                    k.V�lasz3 = t�mb[4];
                    k.URL = t�mb[5];
                    int.TryParse(t�mb[6], out int j�v�lasz);
                    k.HelyesV�lasz = j�v�lasz;
                    k�rd�sek.Add(k);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            return k�rd�sek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            K�rd�smegjelen�t�s(Aktu�lisK�rd�sek[Aktu�lisK�rd�s++]);
            if (Aktu�lisK�rd�s == 7)
            {
                Aktu�lisK�rd�s = 0;
            }
        }


        private void V�lG1_Click(object sender, EventArgs e)
        {
            if (Aktu�lisK�rd�sek[Aktu�lisK�rd�s].HelyesV�lasz == 1)
            {
                V�lG1.BackColor = Color.Green;
            }
            else
            {
                V�lG2.BackColor = Color.Red;
                V�lG3.BackColor = Color.Red;
            }

        }

        private void V�lG2_Click(object sender, EventArgs e)
        {
            if (Aktu�lisK�rd�sek[Aktu�lisK�rd�s].HelyesV�lasz == 2)
            {
                V�lG2.BackColor = Color.Green;
            }
            else
            {
                V�lG1.BackColor = Color.Red;
                V�lG3.BackColor = Color.Red;
            }

        }

        private void V�lG3_Click(object sender, EventArgs e)
        {
            if (Aktu�lisK�rd�sek[Aktu�lisK�rd�s].HelyesV�lasz == 3)
            {
                V�lG3.BackColor = Color.Green;
            }
            else
            {
                V�lG2.BackColor = Color.Red;
                V�lG1.BackColor = Color.Red;
            }

        }


    }
}