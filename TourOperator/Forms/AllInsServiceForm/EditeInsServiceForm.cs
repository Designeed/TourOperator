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

namespace TourOperator.Forms.AllInsServiceForm
{

    public partial class EditeInsServiceForm : Form
    {
        private int _id;
        public int IdService { get => _id; set => _id = value; }

        readonly private TourOperatorEntities db = Helper.GetContext();

        public EditeInsServiceForm(int Id)
        {
            InitializeComponent();

            IdService = Id;
        }

        private void EditeInsServiceForm_Load(object sender, EventArgs e)
        {
            var insService = db.ServicesInsuranceCompany.Find(IdService);
            txtBoxService.Text = insService.Service;
            txtBoxDescription.Text = insService.Description;
            txtBoxCost.Text = Convert.ToString(insService.Cost);
        }

        private void btnEditeService_Click(object sender, EventArgs e)
        {
            try
            {
                ServicesInsuranceCompany insService = new ServicesInsuranceCompany();
                insService = db.ServicesInsuranceCompany.Find(IdService);

                insService.Service = txtBoxService.Text;
                insService.Description = txtBoxDescription.Text;

                decimal.TryParse(txtBoxCost.Text, out decimal Cost);
                insService.Cost = Cost;

                db.SaveChanges();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nbtnEditeComp in edite form company");
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
