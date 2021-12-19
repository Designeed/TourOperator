using System;
using System.Windows.Forms;
using TourOperator.Classes;
using TourOperator.Classes.DataConnection;
using TourOperator.Data;

namespace TourOperator.Forms
{
    public partial class AddClientForm : Form
    {
        readonly private TourOperatorEntities db = Helper.GetContext();

        public AddClientForm()
        {
            InitializeComponent();
            ShowIcon = false;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (Validation.txtBoxIsEmpty(txtBoxFirstName, txtBoxSecondName, txtBoxCountry, txtBoxCity, txtBoxPhone, txtBoxEmail, txtBoxPassword) == true)
                MessageBox.Show("Заполните все поля");

            else if (Validation.ValidationEmail(txtBoxEmail.Text) == false)
                MessageBox.Show("Неверно введена почта");
            
            else
            {
                try
                {
                    Clients client = new Clients
                    {
                        FirstName = txtBoxFirstName.Text,
                        SecondName = txtBoxSecondName.Text,
                        Country = txtBoxCountry.Text,
                        City = txtBoxCity.Text,
                        Phone = txtBoxPhone.Text,
                        Email = txtBoxEmail.Text,
                        Password = txtBoxPassword.Text
                    };

                    db.Clients.Add(client);
                    db.SaveChanges();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nbtnAddClient in AddClientForm");
                }
            }
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
    }
}
