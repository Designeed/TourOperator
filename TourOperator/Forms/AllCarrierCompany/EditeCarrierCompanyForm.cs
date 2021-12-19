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

namespace TourOperator.Forms.AllCarrierCompany
{
    public partial class EditeCarrierCompanyForm : Form
    {
        private int _id;
        public int Id { get => _id; set => _id = value; }

        private TourOperatorEntities db = Helper.GetContext();
        public EditeCarrierCompanyForm(int id )
        {
            InitializeComponent();
            ShowIcon = false;

            Id = id;
        }
        private void EditeCarrierCompanyForm_Load(object sender, EventArgs e)
        {
            var company = db.CarrierCompany.Find(Id);
            txtBoxNameComp.Text = company.CompanyName;
            txtBoxDescription.Text = company.Description;
        }

        private void btnEditeComp_Click(object sender, EventArgs e)
        {
            try
            {
                CarrierCompany company = new CarrierCompany();
                company = db.CarrierCompany.Find(Id);

                company.CompanyName = txtBoxNameComp.Text;
                company.Description = txtBoxDescription.Text;

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
            txtBoxNameComp.Clear();
            txtBoxDescription.Clear();
        }
    }
}
