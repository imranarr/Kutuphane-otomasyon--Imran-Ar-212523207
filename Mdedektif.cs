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
    public partial class Mdedektif : Form
    {
        public Mdedektif()
        {
            InitializeComponent();
        }
        DetectiveDal detectiveDal = new DetectiveDal();
        void Yukle()
        {
            dataGridView1.DataSource = detectiveDal.GetDetectives();
        }
        private void Mdedektif_Load(object sender, EventArgs e)
        {
            Yukle();
        }
    }
}
