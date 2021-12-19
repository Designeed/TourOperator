using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourOperator.Classes.DataConnection;
using TourOperator.Data;
using TourOperator.Forms;

namespace TourOperator
{
    public partial class AuthFrom : Form
    {
        readonly private TourOperatorEntities db = Helper.GetContext();
        public AuthFrom()
        {
            InitializeComponent();
            ShowIcon = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((db.Clients.ToList().Find(x => txtBoxLogin.Text == x.Email && txtBoxPassword.Text == x.Password) != null))
            {
                this.Visible = false;
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }

            else
                ShowTitle();

            //this.Visible = false;
            //MainForm mainForm = new MainForm();
            //mainForm.Show();
        }

        async void ShowTitle()
        {
            lblAttention.Visible = true;
            btnLogin.Enabled = false;
            await Task.Run(() => Thread.Sleep(1500));

            lblAttention.Visible = false;
            btnLogin.Enabled = true;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RegForm regfrom = new RegForm();
            regfrom.ShowDialog();

            if (regfrom.DialogResult == DialogResult.Cancel)
                this.Visible = true;
            
        }

        private void AuthFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin.PerformClick();
        }
    }
}
