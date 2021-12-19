using System;
using System.Windows.Forms;
using TourOperator.Classes;
using TourOperator.Classes.DataConnection;
using TourOperator.Data;

namespace TourOperator.Forms
{
    public partial class AddClientForm : Form
    {
        private TourOperatorEntities db = Helper.GetContext();

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

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
