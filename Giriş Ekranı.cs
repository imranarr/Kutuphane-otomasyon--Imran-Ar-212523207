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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UserEnter_Click(object sender, EventArgs e)
        {
            string password = "admin123";
            string userName = "İmran";
            string entegredUserName = UserNametxt.Text;

            string entegredPasword=PasswordTxt.Text;
            if(password==entegredPasword&&userName==entegredUserName)
            {
                MessageBox.Show("Giriş Başarılı,İyi Çalışmalar","DİKAt");
                MenüForm form3 = new MenüForm();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Parola Hatalı !");
            }

        }

        private void UserSingin_Click(object sender, EventArgs e)
        {
            KayıtForm form2 = new KayıtForm();
            form2.Show();
        }

        private void GuestEnter_Click(object sender, EventArgs e)
        {
           Misafir misafir = new Misafir();
            misafir.Show();
        }
    }
}
