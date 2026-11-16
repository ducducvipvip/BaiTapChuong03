using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaiTapChuong03
{
    public partial class TurnOnForm : Form
    {
        private Process? _tienTrinhServer;
        public TurnOnForm()
        {
            InitializeComponent();
        }
        private void TurnOnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void serverBtn_Click_1(object sender, EventArgs e)
        {
            if (_tienTrinhServer != null && !_tienTrinhServer.HasExited)
            {
                MessageBox.Show("Server đang chạy rồi");
                return;
            }

            var psi = new ProcessStartInfo(Environment.ProcessPath!)
            {
                UseShellExecute = false
            };
            psi.ArgumentList.Add("server");
            _tienTrinhServer = Process.Start(psi);
        }

        private void clientBtn_Click_1(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
