using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourOperator.Classes;
using TourOperator.Classes.DataConnection;
using TourOperator.Data;

namespace TourOperator.Forms.AllInsServiceForm
{
    public partial class AddInsServiceForm : Form
    {
        private int _idCompany;
        public int IdCompany { get => _idCompany; set => _idCompany = value; }

        readonly private TourOperatorEntities db = Helper.GetContext();
        public AddInsServiceForm(int Id)
        {
            InitializeComponent();

            IdCompany = Id;
        }


        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (Validation.txtBoxIsEmpty(txtBoxDescription, txtBoxService, txtBoxService) == true)
                MessageBox.Show("Заполните все поля");

            else
            {
                try
                {
                    ServicesInsuranceCompany InsService = new ServicesInsuranceCompany
                    {
                        Service = txtBoxService.Text,
                        Description = txtBoxDescription.Text,
                        IdInsuranceCompany = IdCompany
                    };

                    decimal.TryParse(txtBoxCost.Text, out decimal Cost);
                    InsService.Cost = Cost;

                    db.ServicesInsuranceCompany.Add(InsService);
                    db.SaveChanges();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nbtnAddService in AddInsServiceForm");
                }
            }
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            txtBoxService.Clear();
            txtBoxDescription.Clear();
            txtBoxCost.Clear();
        }
    }
}
