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
    public partial class AşkForm : Form
    {
        public AşkForm()
        {
            InitializeComponent();
        }
        LoveDal loveDal = new LoveDal();
        void YukleL()
        {
            dataGridView3.DataSource = loveDal.GetAllLove();
        }
        void SilL()
        {
            BookNameText2.Clear();
            WriterNameText2.Clear();
            WriterSurnameText2.Clear();
            NumberPagesText2.Clear();
            SummaryText2.Clear();
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            BookNameText2.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            WriterNameText2.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            WriterSurnameText2.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            NumberPagesText2.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            SummaryText2.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
        }

        private void AşkForm_Load_1(object sender, EventArgs e)
        {
            YukleL();
        }
        private void SaveBtnAşk_Click_1(object sender, EventArgs e)
        {
            Love love = new Love
            {
                Name = BookNameText2.Text,
                WriterName = WriterNameText2.Text,
                WriterSurname = WriterSurnameText2.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText2.Text),
                Summary = SummaryText2.Text
            };
            loveDal.AddLove(love);
            YukleL();
            MessageBox.Show("Kitap Başarıyla Eklendi");
            SilL();

        }

        private void DelBTnAşk_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);
            loveDal.DeleteLove(id);
            MessageBox.Show("Müşteri başarıyla Silindi");
            YukleL();
            SilL();
        }

        private void UpdateBtnAşk_Click_1(object sender, EventArgs e)
        {
            Love love = new Love
            {
                Name = BookNameText2.Text,
                WriterName = WriterNameText2.Text,
                WriterSurname = WriterSurnameText2.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText2.Text),
                Summary = SummaryText2.Text
            };
            loveDal.AddLove(love);
            YukleL();
            MessageBox.Show("Kitap Başarıyla Güncellendi");
            SilL();

        }
    }
}
