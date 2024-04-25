using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_Gyak
{
    public partial class FormEditData : Form
    {
        public Vizsgakérdés ÚjVizsgaKérdés = new();
        public FormEditData()
        {
            InitializeComponent();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditData_Load(object sender, EventArgs e)
        {
            vizsgakérdésBindingSource.DataSource = ÚjVizsgaKérdés;
        }
    }
}
