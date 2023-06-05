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
    public partial class GerilimForm : Form
    {
        public GerilimForm()
        {
            InitializeComponent();
        }
        IncomeDal ıncomeDal = new IncomeDal();
        void YukleI()
        {
            dataGridView9.DataSource = ıncomeDal.GetIncome();
        }
        void SilI()
        {
            BookNameText8.Clear();
            WriterNameText8.Clear();
            WriterSurnameText8.Clear();
            NumberPagesText8.Clear();
            SummaryText8.Clear();
        }

        private void SaveBtnIncome_Click(object sender, EventArgs e)
        {
            Income ıncome = new Income
            {
                Name = BookNameText8.Text,
                WriterName = WriterNameText8.Text,
                WriterSurname = WriterSurnameText8.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText8.Text),
                Summary = SummaryText8.Text
            };
            ıncomeDal.AddIncome(ıncome);
            YukleI();
            MessageBox.Show("Kitap Başarıyla Eklendi");
            SilI();
        }

        private void UpdateBtnIncome_Click(object sender, EventArgs e)
        {

            Income ıncome = new Income
            {
                Name = BookNameText8.Text,
                WriterName = WriterNameText8.Text,
                WriterSurname = WriterSurnameText8.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText8.Text),
                Summary = SummaryText8.Text
            };
            ıncomeDal.AddIncome(ıncome);
            YukleI();
            MessageBox.Show("Kitap Başarıyla Güncellendi");
            SilI();
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox9.Text = dataGridView9.CurrentRow.Cells[0].Value.ToString();
            BookNameText8.Text = dataGridView9.CurrentRow.Cells[1].Value.ToString();
            WriterNameText8.Text = dataGridView9.CurrentRow.Cells[2].Value.ToString();
            WriterSurnameText8.Text = dataGridView9.CurrentRow.Cells[3].Value.ToString();
            NumberPagesText8.Text = dataGridView9.CurrentRow.Cells[4].Value.ToString();
            SummaryText8.Text = dataGridView9.CurrentRow.Cells[5].Value.ToString();
        }

        private void DelBTnIncome_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView9.CurrentRow.Cells[0].Value);
            ıncomeDal.DeleteIncome(id);
            MessageBox.Show("Müşteri başarıyla Silindi");
            YukleI();
            SilI();
        }

        private void GerilimForm_Load(object sender, EventArgs e)
        {
            YukleI();
        }
    }
}
