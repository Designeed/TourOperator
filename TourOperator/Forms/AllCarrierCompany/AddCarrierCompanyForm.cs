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

namespace TourOperator.Forms.AllCarrierCompany
{
    public partial class AddCarrierCompanyForm : Form
    {
        readonly private TourOperatorEntities db = Helper.GetContext();
        public AddCarrierCompanyForm()
        {
            InitializeComponent();
            ShowIcon = false;
        }

        private void btnAddComp_Click(object sender, EventArgs e)
        {
            if (Validation.txtBoxIsEmpty(txtBoxNameComp, txtBoxDescription) == true)
                MessageBox.Show("Заполните все поля");

            else
            {
                try
                {
                    CarrierCompany carrierCompany = new CarrierCompany
                    {
                        CompanyName = txtBoxNameComp.Text,
                        Description = txtBoxDescription.Text
                    };

                    db.CarrierCompany.Add(carrierCompany);
                    db.SaveChanges();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nbtnAddComp in AddCarrierCompany");
                }
            }
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            txtBoxNameComp.Clear();
            txtBoxDescription.Clear();
        }
    }
}
