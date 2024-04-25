using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class VillogoGomb1 : Button
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        public VillogoGomb1()
        {
            BackColor = Color.Yellow;
            MouseEnter += VillogoGomb1_MouseEnter;
            //MouseLeave += VillogoGomb1_MouseLeave;
            t.Tick += T_Tick;
        }

        private void T_Tick(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
            t.Stop();
        }

        private void VillogoGomb1_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
        }

        private void VillogoGomb1_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
            t.Interval = 1000;
            t.Start();
        }
    }
}
