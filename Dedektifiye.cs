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
    public partial class DedektifiyeForm : Form
    {
        public DedektifiyeForm()
        {
            InitializeComponent();
        }
        DetectiveDal detectiveDal = new DetectiveDal();
        void YukleD()
        {
            dataGridView6.DataSource = detectiveDal.GetDetectives();
        }
        void SilD()
        {
            BookNameText6.Clear();
            WriterNameText6.Clear();
            WriterSurnameText6.Clear();
            NumberPagesText6.Clear();
            SummaryText6.Clear();
        }

        private void SaveBtnDet_Click(object sender, EventArgs e)
        {
            Detective detective = new Detective
            {
                Name = BookNameText6.Text,
                WriterName = WriterNameText6.Text,
                WriterSurname = WriterSurnameText6.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText6.Text),
                Summary = SummaryText6.Text
            };
            detectiveDal.AddDetective(detective);
            YukleD();
            MessageBox.Show("Kitap Başarıyla Eklendi");
            SilD();
        }

        private void UpdateBtnDet_Click(object sender, EventArgs e)
        {
            Detective detective = new Detective
            {
                Name = BookNameText6.Text,
                WriterName = WriterNameText6.Text,
                WriterSurname = WriterSurnameText6.Text,
                NumberOfPages = Convert.ToInt32(NumberPagesText6.Text),
                Summary = SummaryText6.Text
            };
            detectiveDal.AddDetective(detective);
            YukleD();
            MessageBox.Show("Kitap Başarıyla Güncellendi");
            SilD();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView6.CurrentRow.Cells[0].Value.ToString();
            BookNameText6.Text = dataGridView6.CurrentRow.Cells[1].Value.ToString();
            WriterNameText6.Text = dataGridView6.CurrentRow.Cells[2].Value.ToString();
            WriterSurnameText6.Text = dataGridView6.CurrentRow.Cells[3].Value.ToString();
            NumberPagesText6.Text = dataGridView6.CurrentRow.Cells[4].Value.ToString();
            SummaryText6.Text = dataGridView6.CurrentRow.Cells[5].Value.ToString();
        }

        private void DelBTnDet_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataGridView6.CurrentRow.Cells[0].Value);
            detectiveDal.DeleteDetective(id);
            MessageBox.Show("Müşteri başarıyla Silindi");
            YukleD();
            SilD();
        }

        private void DedektifiyeForm_Load(object sender, EventArgs e)
        {
            YukleD();
        }
    }
}
