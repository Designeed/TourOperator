using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourOperator.Classes.DataConnection;
using TourOperator.Data;

namespace TourOperator.Forms.AllClientForm
{
    public partial class EditeClientForm : Form
    {
        private int _id;
        readonly private TourOperatorEntities db = Helper.GetContext();
        public int Id { get => _id; set => _id = value; }

        public EditeClientForm(int id)
        {
            InitializeComponent();
            ShowIcon = false;

            Id = id;
        }

        private void EditeClientForm_Load(object sender, EventArgs e)
        {
            var client = db.Clients.Find(Id);
            txtBoxFirstName.Text = client.FirstName;
            txtBoxSecondName.Text = client.SecondName;
            txtBoxCity.Text = client.City;
            txtBoxCountry.Text = client.Country;
            txtBoxEmail.Text = client.Email;
            txtBoxPhone.Text = client.Phone;
            txtBoxPassword.Text = client.Password;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                Clients client = new Clients();
                client = db.Clients.Find(Id);

                client.FirstName = txtBoxFirstName.Text;
                client.SecondName = txtBoxSecondName.Text;
                client.Country = txtBoxCountry.Text;
                client.City = txtBoxCity.Text;
                client.Phone = txtBoxPhone.Text;
                client.Email = txtBoxEmail.Text;
                client.Password = txtBoxPassword.Text;

                db.SaveChanges();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n btnAddClient in EditeClientForm");
            }
        }
    }
}
