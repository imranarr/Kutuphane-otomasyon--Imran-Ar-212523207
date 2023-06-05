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
    public partial class Tarihi : Form
    {
        public Tarihi()
        {
            InitializeComponent();
        }

        HistoryDal historyDal = new HistoryDal();
        void YukleH()
        {
            dataGridView5.DataSource = historyDal.GetAllHistory();
        }
        void SilH()
        {
            BookNameText4.Clear();
            WriterNameText4.Clear();
            WriterSurnameText4.Clear();
            NumberPagesText4.Clear();
            SummaryText4.Clear();
        }

        private void SaveBtnTarih_Click(object sender, EventArgs e)
        {
            History history = new History()
            {
                Name = BookNameText4.Text,
                WriterName = WriterNameText4.Text,
                WriterSurname = WriterSurnameText4.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText4.Text),
                Summary = SummaryText4.Text
            };
            historyDal.AddHistory(history);
            YukleH();
            MessageBox.Show("Kitap Başarıyla Eklendi");
            SilH();
        }

        private void UpdateBtnTarih_Click(object sender, EventArgs e)
        {
            History history = new History
            {
                Name = BookNameText4.Text,
                WriterName = WriterNameText4.Text,
                WriterSurname = WriterSurnameText4.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText4.Text),
                Summary = SummaryText4.Text
            };
            historyDal.AddHistory(history);
            YukleH();
            MessageBox.Show("Kitap Başarıyla Güncellendi");
            SilH();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView5.CurrentRow.Cells[0].Value.ToString();
            BookNameText4.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
            WriterNameText4.Text = dataGridView5.CurrentRow.Cells[2].Value.ToString();
            WriterSurnameText4.Text = dataGridView5.CurrentRow.Cells[3].Value.ToString();
            NumberPagesText4.Text = dataGridView5.CurrentRow.Cells[4].Value.ToString();
            SummaryText4.Text = dataGridView5.CurrentRow.Cells[5].Value.ToString();
        }

        private void Tarihi_Load(object sender, EventArgs e)
        {
            YukleH();
        }

        private void DelBTnTarih_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView5.CurrentRow.Cells[0].Value);
            historyDal.DeleteHistory(id);
            MessageBox.Show("Müşteri başarıyla Silindi");
            YukleH();
            SilH();
        }
    }
}
