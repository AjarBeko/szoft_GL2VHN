namespace KigyosJáték
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int fejX = 100;
        int fejY = 100;
        int irány_x = 1;
        int irány_y = 0;
        int lépésszám;
        int hossz = 5;
        List<KígyóElem> kígyó = new List<KígyóElem>();


        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;
            fejX += irány_x * KígyóElem.Méret;
            fejY += irány_y * KígyóElem.Méret;

            foreach (Object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fejY && k.Left == fejX)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }

                if (item is Kaja)
                {
                    Kaja kj = (Kaja)item;
                    if (kj.Top == fejY && kj.Left == fejX)
                    {
                        hossz++;
                        Controls.Remove(kj);
                    }
                }

                if(item is Méreg)
                {
                    Méreg mé = (Méreg)item;
                    if(mé.Top == fejY && mé.Left == fejX)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }
            if (kígyó.Count > hossz)
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            KígyóElem ke = new KígyóElem();
            ke.Top = fejY;
            ke.Left = fejX;
            kígyó.Add(ke);

            if (lépésszám % 2 == 0) { ke.BackColor = Color.LightGreen; }
            

            if (lépésszám % 20 == 0)
            {
                Kaja K = new Kaja();
                Random rnd = new Random();
                K.Left = rnd.Next(this.ClientSize.Width / KígyóElem.Méret) * KígyóElem.Méret;
                K.Top = rnd.Next(this.ClientSize.Height / KígyóElem.Méret) * KígyóElem.Méret;
                Controls.Add(K);
            }
            if (lépésszám % 20 == 0)
            {
                Méreg M = new Méreg();
                Random rnd = new Random();
                M.Left = rnd.Next(this.ClientSize.Width / KígyóElem.Méret) * KígyóElem.Méret;
                M.Top = rnd.Next(this.ClientSize.Height / KígyóElem.Méret) * KígyóElem.Méret;
                Controls.Add(M);
            }


            Controls.Add(ke);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}