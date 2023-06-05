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
    public partial class MAşkF : Form
    {
        public MAşkF()
        {
            InitializeComponent();
        }
        LoveDal LoveDal = new LoveDal();
        void Yuklema()
        {
            dataGridView1.DataSource = LoveDal.GetAllLove();
        }
        private void MAşkF_Load_1(object sender, EventArgs e)
        {
            Yuklema();
        }
    }
}
