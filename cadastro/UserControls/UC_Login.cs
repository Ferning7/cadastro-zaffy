using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro.UserControls
{
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
        }





        private void btnLogin_Click(object sender, EventArgs e)
        {
            UC_Home home = new UC_Home();
            this.Controls.Clear();
            this.Controls.Add(home);
        }

        private void linkEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_EsqueciSenha fgtPwd = new UC_EsqueciSenha();
            this.Controls.Clear();
            this.Controls.Add(fgtPwd);
        }

        private void pbEyeOpen_Click(object sender, EventArgs e)
        {

        }
        private void pbEyeClosed_Click(object sender, EventArgs e)
        {

        }
    }
}
