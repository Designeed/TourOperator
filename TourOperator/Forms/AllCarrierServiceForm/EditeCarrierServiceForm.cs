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

namespace TourOperator.Forms.AllCarrierServiceForm
{
    public partial class EditeCarrierServiceForm : Form
    {
        private int _id;
        public int IdService { get => _id; set => _id = value; }

        readonly private TourOperatorEntities db = Helper.GetContext();
        public EditeCarrierServiceForm(int Id)
        {
            InitializeComponent();
            ShowIcon = false;

            IdService = Id;
        }

        private void EditeCarrierServiceForm_Load(object sender, EventArgs e)
        {
            var carrierService = db.ServicesCarrierCompany.Find(IdService);
            txtBoxService.Text = carrierService.Service;
            txtBoxDescription.Text = carrierService.Description;
            txtBoxCost.Text = Convert.ToString(carrierService.Cost);
        }

        private void btnEditeService_Click(object sender, EventArgs e)
        {
            try
            {
                ServicesCarrierCompany carrierService = new ServicesCarrierCompany();
                carrierService = db.ServicesCarrierCompany.Find(IdService);

                carrierService.Service = txtBoxService.Text;
                carrierService.Description = txtBoxDescription.Text;

                decimal.TryParse(txtBoxCost.Text, out decimal Cost);
                carrierService.Cost = Cost;

                db.SaveChanges();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nbtnEditeService in EditeCarrierServiceForm");
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
