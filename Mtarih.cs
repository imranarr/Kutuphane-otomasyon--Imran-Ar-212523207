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
    public partial class Mtarih : Form
    {
        public Mtarih()
        {
            InitializeComponent();
        }
        HistoryDal historyDal = new HistoryDal();
        void Yukle()
        {
            dataGridView1.DataSource = historyDal.GetAllHistory();
        }
        private void Mtarih_Load(object sender, EventArgs e)
        {
            Yukle();
        }
    }
}
