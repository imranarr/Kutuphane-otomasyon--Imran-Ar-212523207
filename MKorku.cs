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
    public partial class MKorku : Form
    {
        public MKorku()
        {
            InitializeComponent();
        }
        FearDal fearDal = new FearDal();
        void Yukle()
        {
            dataGridView1.DataSource = fearDal.GetAllFear();
        }
        private void MKorku_Load(object sender, EventArgs e)
        {
            Yukle();
        }
    }
}
