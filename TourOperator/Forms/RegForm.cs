using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourOperator.Classes;
using TourOperator.Classes.DataConnection;
using TourOperator.Data;

namespace TourOperator.Forms
{
    public partial class RegForm : Form
    {
        private TourOperatorEntities db = Helper.GetContext();

        public RegForm()
        {
            InitializeComponent();
            ShowIcon = false;
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            txtBoxFirstName.Clear();
            txtBoxSecondName.Clear();
            txtBoxCountry.Clear();
            txtBoxCity.Clear();
            txtBoxPhone.Clear();
            txtBoxPassword.Clear();
            txtBoxEmail.Clear();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation.txtBoxIsEmpty(txtBoxFirstName, txtBoxSecondName, txtBoxCountry, txtBoxCity, txtBoxPhone, txtBoxEmail, txtBoxPassword) == true)
                MessageBox.Show("Заполните все поля");

            else if (Validation.ValidationEmail(txtBoxEmail.Text) == false)
                MessageBox.Show("Неверно введена почта");

            else
            {
                try
                {
                    Clients client = new Clients();

                    client.FirstName = txtBoxFirstName.Text;
                    client.SecondName = txtBoxSecondName.Text;
                    client.Country = txtBoxCountry.Text;
                    client.City = txtBoxCity.Text;
                    client.Phone = txtBoxPhone.Text;
                    client.Email = txtBoxEmail.Text;
                    client.Password = txtBoxPassword.Text;

                    db.Clients.Add(client);
                    db.SaveChanges();

                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
