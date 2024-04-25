using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigyosJáték
{
    internal class Kaja : PictureBox
    {
        public static int Méret = 20;
        public Kaja()
        {
            Height = Méret;
            Width = Méret;
            BackColor = Color.Red;
        }
    }
}
