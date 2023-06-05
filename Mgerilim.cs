using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryProgram
{
    public partial class Mgerilim : Form
    {
        public Mgerilim()
        {
            InitializeComponent();
        }
        IncomeDal IncomeDal = new IncomeDal();
        void Yukle()
        {
            dataGridView1.DataSource = IncomeDal.GetIncome();
        }
        private void Mgerilim_Load(object sender, EventArgs e)
        {
            Yukle();
        }
    }
}
