using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibaryProgram
{
    public partial class Korku : Form
    {
        public Korku()
        {
            InitializeComponent();
        }
        FearDal fearDal = new FearDal();
        void YukleF()
        {
            dataGridView4.DataSource = fearDal.GetAllFear();
        }
        private void Korku_Load(object sender, EventArgs e)
        {
            YukleF();
        }
        void SilF()
        {
            BookNameText3.Clear();
            WriterNameText3.Clear();
            WriterSurnameText3.Clear();
            NumberPagesText3.Clear();
            SummaryText3.Clear();
        }

        private void SaveBtnKorku_Click(object sender, EventArgs e)
        {
            Fear fear = new Fear
            {
                Name = BookNameText3.Text,
                WriterName = WriterNameText3.Text,
                WriterSurname = WriterSurnameText3.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText3.Text),
                Summary = SummaryText3.Text
            };
            fearDal.AddFear(fear);
            YukleF();
            MessageBox.Show("Kitap Başarıyla Eklendi");
            SilF();
        }

        private void UpdateBtnKorku_Click(object sender, EventArgs e)
        {
            Fear fear = new Fear
            {
                Name = BookNameText3.Text,
                WriterName = WriterNameText3.Text,
                WriterSurname = WriterSurnameText3.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText3.Text),
                Summary = SummaryText3.Text
            };
            fearDal.AddFear(fear);
            YukleF();
            MessageBox.Show("Kitap Başarıyla Güncellendi");
            SilF();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            BookNameText3.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            WriterNameText3.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            WriterSurnameText3.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            NumberPagesText3.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
            SummaryText3.Text = dataGridView4.CurrentRow.Cells[5].Value.ToString();
        }

        private void DelBTnKorku_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value);
            fearDal.DeleteFear(id);
            MessageBox.Show("Müşteri başarıyla Silindi");
            YukleF();
            SilF();
        }
    }
}
