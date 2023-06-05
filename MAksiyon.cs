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
    public partial class MAksiyonForm : Form
    {
        public MAksiyonForm()
        {
            InitializeComponent();
        }
        ActionDal actionDal = new ActionDal();
        void Yuklema()
        {
            dataGridViewM1.DataSource = actionDal.GetAllAction();
        }

        private void MAksiyon_Load(object sender, EventArgs e)
        {
            Yuklema();
        }
    }
}
