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
    public partial class ŞiirForm : Form
    {
        public ŞiirForm()
        {
            InitializeComponent();
        }
        PoetryDal poetryDal = new PoetryDal();
        void YukleP()
        {
            dataGridView10.DataSource = poetryDal.GetPoetries();
        }
        void SilP()
        {
            BookNameText9.Clear();
            WriterNameText9.Clear();
            WriterSurnameText9.Clear();
            NumberPagesText9.Clear();
            SummaryText9.Clear();
        }
        private void SaveBtnŞiir_Click(object sender, EventArgs e)
        {

            Poetry poetry = new Poetry
            {
                Name = BookNameText9.Text,
                WriterName = WriterNameText9.Text,
                WriterSurname = WriterSurnameText9.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText9.Text),
                Summary = SummaryText9.Text,
            };
            poetryDal.AddPoetries(poetry);
            YukleP();
            MessageBox.Show("Kitap Başarıyla Eklendi.");
            SilP();
        }
        private void UpdateBtnŞiir_Click(object sender, EventArgs e)
        {
            Poetry poetry = new Poetry
            {
                Name = BookNameText9.Text,
                WriterName = WriterNameText9.Text,
                WriterSurname = WriterSurnameText9.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText9.Text),
                Summary = SummaryText9.Text
            };
            poetryDal.UpdatePoetries(poetry);
            YukleP();
            MessageBox.Show("Kitap Başarıyla Güncellendi.");
            SilP();
        }
        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox10.Text = dataGridView10.CurrentRow.Cells[0].Value.ToString();
            BookNameText9.Text = dataGridView10.CurrentRow.Cells[1].Value.ToString();
            WriterNameText9.Text = dataGridView10.CurrentRow.Cells[2].Value.ToString();
            WriterSurnameText9.Text = dataGridView10.CurrentRow.Cells[3].Value.ToString();
            NumberPagesText9.Text = dataGridView10.CurrentRow.Cells[4].Value.ToString();
            SummaryText9.Text = dataGridView10.CurrentRow.Cells[5].Value.ToString();
        }
        private void DelBTnŞiir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView10.CurrentRow.Cells[0].Value);
            poetryDal.DeletePoetries(id);
            MessageBox.Show("Kitap Başarıyla Silindi.");
            YukleP();
            SilP();
        }

        private void ŞiirForm_Load(object sender, EventArgs e)
        {
            YukleP() ;
        }
    }
    
}
