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
    public partial class KayıtForm : Form
    {
        public KayıtForm()
        {
            InitializeComponent();
        }
        UserDal userDal = new UserDal();    
        private void SaveUserSingin_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                UserName = UserNameNew.Text,
                Password = UserPasswordNew.Text

            };
            userDal.AddUser(user);
            MessageBox.Show("Başarıyla Eklendi");

        }

        private void BackForm1_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
