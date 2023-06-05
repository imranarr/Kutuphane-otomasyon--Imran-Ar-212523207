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
    public partial class Misafir : Form
    {
        public Misafir()
        {
            InitializeComponent();
        }

        private void Aksiyonpic1_Click(object sender, EventArgs e)
        {
            MAksiyonForm mAksiyon = new MAksiyonForm();
            mAksiyon.Show();
        }

        private void AşkPic1_Click(object sender, EventArgs e)
        {
            MAşkF mAşkF = new MAşkF();
            mAşkF.Show();
        }

        private void DramPic1_Click(object sender, EventArgs e)
        {
            MDram mDram = new MDram();
            mDram.Show();
        }

        private void KorkuPic1_Click(object sender, EventArgs e)
        {
            MKorku mKorku = new MKorku();
            mKorku.Show();
        }

        private void TarihiPic1_Click(object sender, EventArgs e)
        {
            Mtarih mTarihi = new Mtarih();
            mTarihi.Show();
        }

        private void DedektifiyePic1_Click(object sender, EventArgs e)
        {
            Mdedektif mdedektif = new Mdedektif();
            mdedektif.Show();
        }

        private void GerilimPic1_Click(object sender, EventArgs e)
        {
            Mgerilim mgerilim = new Mgerilim();
            mgerilim.Show();
        }

        private void ŞiirPic1_Click(object sender, EventArgs e)
        {
            Mşiir mşiir = new Mşiir();
            mşiir.Show();
        }
    }
}
