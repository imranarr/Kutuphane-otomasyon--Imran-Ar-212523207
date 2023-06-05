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
    public partial class Mşiir : Form
    {
        public Mşiir()
        {
            InitializeComponent();
        }
        PoetryDal poetryDal = new PoetryDal();
        void Yukle()
        {
            dataGridView1.DataSource = poetryDal.GetPoetries();
        }
        private void Mşiir_Load(object sender, EventArgs e)
        {
            Yukle();
        }
    }
}
