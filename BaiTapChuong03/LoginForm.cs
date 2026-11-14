using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaiTapChuong03
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnMoDangKy_Click(object sender, EventArgs e)
        {
            using var registerForm = new RegisterForm();
            registerForm.ShowDialog(this);
        }
    }
}
