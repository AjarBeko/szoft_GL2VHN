using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adatkotesek2
{
    public partial class Szerkeszt : Form
    {
        public CountryData CountryData;
        public Szerkeszt()
        {
            InitializeComponent();
        }

        private void Szerkeszt_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = CountryData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
