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
    public partial class MDram : Form
    {
        public MDram()
        {
            InitializeComponent();
        }
        
        DreamDal DreamDal = new DreamDal();
        void yükle()
        {
            dataGridView1.DataSource=DreamDal.GetAllDreams();
        }
        
        private void MDram_Load(object sender, EventArgs e)
        {
            yükle();    
        }
    }
}
