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
    public partial class DramForm : Form
    {
        public DramForm()
        {
            InitializeComponent();
        }
        DreamDal dreamDal = new DreamDal();
        void YukleD()
        {
            dataGridView2.DataSource=dreamDal.GetAllDreams();
        }
        void SilD()
        {
            BookNameText1.Clear();
            WriterNameText1.Clear();
            WriterSurnameText1.Clear();
            NumberPagesText1.Clear();
            SummaryText1.Clear();
        }

        private void SaveBtnDram_Click(object sender, EventArgs e)
        {
            Dream dream = new Dream
            {
                Name = BookNameText1.Text,
                WriterName = WriterNameText1.Text,
                WriterSurname = WriterSurnameText1.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText1.Text),
                Summary = SummaryText1.Text,
            };
            dreamDal.AddDream(dream);
            YukleD();
            MessageBox.Show("Kitap Başarıyla Eklendi.");
            SilD();
        }


        private void DramForm_Load(object sender, EventArgs e)
        {
            YukleD();
        }

        private void UpdateBtnDram_Click(object sender, EventArgs e)
        {
            Dream dream = new Dream
            {
                Name = BookNameText1.Text,
                WriterName = WriterNameText1.Text,
                WriterSurname = WriterSurnameText1.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText1.Text),
                Summary = SummaryText1.Text
            };
            dreamDal.UpdateDream(dream);
            YukleD();
            MessageBox.Show("Kitap Başarıyla Güncellendi.");
            SilD();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            BookNameText1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            WriterNameText1.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            WriterSurnameText1.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            NumberPagesText1.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            SummaryText1.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
        }

        private void DelBTnDram_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            dreamDal.DeleteDream(id);
            MessageBox.Show("Kitap Başarıyla Silindi.");
            YukleD();
            SilD();
        }
    }
}
