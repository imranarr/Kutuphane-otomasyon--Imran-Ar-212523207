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
    public partial class MenüForm : Form
    {
        public MenüForm()
        {
            InitializeComponent();
        }
        private void DramPic_Click(object sender, EventArgs e)
        {
            DramForm form = new DramForm();
            form.Show();
        }

        private void Aksiyonpic_Click_1(object sender, EventArgs e)
        {
            AksiyonForm aksiyonForm = new AksiyonForm();
            aksiyonForm.Show();
        }

        private void AşkPic_Click(object sender, EventArgs e)
        {
            AşkForm aşkform= new AşkForm();
            aşkform.Show();
        }

        private void KorkuPic_Click(object sender, EventArgs e)
        {
            Korku korkuForm = new Korku();
            korkuForm.Show();
        }

        private void TarihiPic_Click(object sender, EventArgs e)
        {
            Tarihi tarihiform=new Tarihi();
            tarihiform.Show();
        }

        private void DedektifiyePic_Click(object sender, EventArgs e)
        {
            DedektifiyeForm dedektifiyeForm = new DedektifiyeForm();
            dedektifiyeForm.Show();
        }

        private void GerilimPic_Click(object sender, EventArgs e)
        {
            GerilimForm gerilimForm = new GerilimForm();
            gerilimForm.Show();

        }

        private void ŞiirPic_Click(object sender, EventArgs e)
        {
            ŞiirForm şiirForm = new ŞiirForm();
            şiirForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
