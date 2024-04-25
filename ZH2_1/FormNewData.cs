using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_1
{
    public partial class FormNewData : Form
    {
        public VizsgaKerdesek ÚjKérdések = new();
        public FormNewData()
        {
            InitializeComponent();
        }

        private void FormNewData_Load(object sender, EventArgs e)
        {
            vizsgaKerdesekBindingSource.DataSource = ÚjKérdések;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
