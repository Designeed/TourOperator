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

namespace TourOperator.Forms.AllCarrierServiceForm
{
    public partial class AddCarrierServiceForm : Form
    {
        private int _idCompany;
        public int IdCompany { get => _idCompany; set => _idCompany = value; }

        readonly private TourOperatorEntities db = Helper.GetContext();
        public AddCarrierServiceForm(int Id)
        {
            InitializeComponent();
            ShowIcon = false;

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
                    ServicesCarrierCompany carrierService = new ServicesCarrierCompany
                    {
                        Service = txtBoxService.Text,
                        Description = txtBoxDescription.Text,
                        IdCarrierCompany = IdCompany
                    };

                    decimal.TryParse(txtBoxCost.Text, out decimal Cost);
                    carrierService.Cost = Cost;

                    db.ServicesCarrierCompany.Add(carrierService);
                    db.SaveChanges();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nbtnAddService in AddCarrierServiceForm");
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
