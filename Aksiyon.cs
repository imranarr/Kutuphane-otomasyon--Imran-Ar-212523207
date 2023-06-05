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
    public partial class AksiyonForm : Form
    {
        public AksiyonForm()
        {
            InitializeComponent();
        }
        ActionDal actionDal = new ActionDal();
        void Yukle()
        {
            dataGridView1.DataSource = actionDal.GetAllAction();
        }
        void Sil()
        {
            BookNameText.Clear();
            WriterNameText.Clear();
            WriterSurnameText.Clear();
            NumberPagesText.Clear();
            SummaryText.Clear();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Action action = new Action
            {
                Name = BookNameText.Text,
                WriterName = WriterNameText.Text,
                WriterSurname = WriterSurnameText.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText.Text),
                Summary = SummaryText.Text
            };
            actionDal.AddAction(action);
            Yukle();
            MessageBox.Show("Kitap Başarıyla Eklendi");
            Sil();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Action action = new Action
            {
                Name = BookNameText.Text,
                WriterName = WriterNameText.Text,
                WriterSurname = WriterSurnameText.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText.Text),
                Summary = SummaryText.Text
            };
            actionDal.AddAction(action);
            Yukle();
            MessageBox.Show("Kitap Başarıyla Güncellendi");
            Sil();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            BookNameText.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            WriterNameText.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            WriterSurnameText.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            NumberPagesText.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            SummaryText.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void AksiyonForm_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void DelBTn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            actionDal.DeleteAction(id);
            MessageBox.Show("Müşteri başarıyla Silindi");
            Yukle();
            Sil();
        }
    }
}
