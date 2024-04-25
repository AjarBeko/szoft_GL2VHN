using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigyosJáték
{
    internal class Méreg : PictureBox
    {
        public static int Méret = 20;
        public Méreg()
        {
            Height = Méret;
            Width = Méret;
            BackColor = Color.DarkGoldenrod;
        }
    }
}
