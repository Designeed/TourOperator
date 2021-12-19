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

namespace TourOperator.Forms.AllInsCompForm
{
    public partial class AddInsCompForm : Form
    {
        readonly private TourOperatorEntities db = Helper.GetContext();
        public AddInsCompForm()
        {
            InitializeComponent();
            ShowIcon = false;
        }

        private void btnAddComp_Click(object sender, EventArgs e)
        {
            if (Validation.txtBoxIsEmpty(txtBoxDescription, txtBoxNameComp) == true)
                MessageBox.Show("Заполните все поля");

            else
            {
                try
                {
                    InsuranceCompany InsComp = new InsuranceCompany
                    {
                        CompanyName = txtBoxNameComp.Text,
                        Description = txtBoxDescription.Text
                    };

                    db.InsuranceCompany.Add(InsComp);
                    db.SaveChanges();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nbtnAddComp in AddInsCompform");
                }
            }
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            txtBoxDescription.Clear();
            txtBoxNameComp.Clear();
        }
    }
}
