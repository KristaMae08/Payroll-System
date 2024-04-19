using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_username.Text == "admin" && txt_password.Text == "admin")
            {
                timer1.Start();
                progressBar1.Show();
            }
            else if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Please fill up all fields");
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(35);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                Mainform a = new Mainform();
                this.Hide();
                a.Show();
            }
        }
    }
}
