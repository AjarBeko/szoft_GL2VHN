using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigyosJáték
{
    internal class KígyóElem : PictureBox
    {
        public static int  Méret =  20;
        public KígyóElem()
        {
            Height = Méret;
            Width = Méret;
            BackColor = Color.Cyan;
        }
    }
    
}
