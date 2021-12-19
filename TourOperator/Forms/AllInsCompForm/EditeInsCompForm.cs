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

namespace TourOperator.Forms.AllInsCompForm
{
    public partial class EditeInsCompForm : Form
    {
        private int _id;
        public int Id { get => _id; set => _id = value; }

        private TourOperatorEntities db = Helper.GetContext();
        public EditeInsCompForm(int id)
        {
            InitializeComponent();
            ShowIcon = false;

            Id = id;
        }
        private void EditeInsCompForm_Load(object sender, EventArgs e)
        {
            var company = db.InsuranceCompany.Find(Id);
            txtBoxNameComp.Text = company.CompanyName;
            txtBoxDescription.Text = company.Description;
        }

        private void btnEditeComp_Click(object sender, EventArgs e)
        {
            try
            {
                InsuranceCompany company = new InsuranceCompany();
                company = db.InsuranceCompany.Find(Id);

                company.CompanyName = txtBoxNameComp.Text;
                company.Description = txtBoxDescription.Text;

                db.SaveChanges();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nbtnEditeComp in EditeCompForm");
            }
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            txtBoxNameComp.Clear();
            txtBoxDescription.Clear();
        }

    }
}
