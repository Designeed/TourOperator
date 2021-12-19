using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourOperator.Classes.DataConnection;
using TourOperator.Data;
using TourOperator.Forms;
using TourOperator.Forms.AllInsCompForm;

namespace TourOperator.Classes.InsCompCS
{
    class InsCompOperation
    {
        private static TourOperatorEntities db = Helper.GetContext();

        public static void AddCompany(ListView listView)
        {
            try
            {
                AddInsCompForm addInsCompForm = new AddInsCompForm();
                addInsCompForm.ShowDialog();

                if (addInsCompForm.DialogResult == DialogResult.OK)
                {
                    UpdateListView(listView);
                    MessageBox.Show("Компания была успешно добавлена", "Статус добавления");
                }

                else
                {
                    MessageBox.Show("Компания не была добавлена");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInsCompOperation.AddInsComp");
            }
        }

        public static void EditeCompany(ListView listView)
        {
            try
            {
                InsuranceCompany insuranceCompany = new InsuranceCompany();

                insuranceCompany = db.InsuranceCompany.Find(Convert.ToInt32(listView.SelectedItems[0].SubItems[listView.Items[0].SubItems.Count - 1].Text));

                EditeInsCompForm editeInsComp = new EditeInsCompForm(insuranceCompany.IdInsuranceCompany);
                editeInsComp.ShowDialog();

                if (editeInsComp.DialogResult == DialogResult.OK)
                {
                    UpdateListView(listView);
                    MessageBox.Show("Компания была успешно отредактирована", "Редактирование компании");
                }

                else
                {
                    MessageBox.Show("Компания не была отредактирована", "Редактирование компании");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInsCompOperation.EditeInsComp");
            }
        }

        public static void DeleteCompany(ListView listView)
        {
            try
            {
                InsuranceCompany insuranceCompany = new InsuranceCompany();

                insuranceCompany = db.InsuranceCompany.Find(Convert.ToInt32(listView.SelectedItems[0].SubItems[listView.Items[0].SubItems.Count - 1].Text));
                db.InsuranceCompany.Remove(insuranceCompany);
                db.SaveChanges();
                UpdateListView(listView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInsCompOperation.DeleteInsComp");
            }
        }

        private static void UpdateListView(ListView listView)
        {
            listView.Items.Clear();

            List<InsuranceCompany> listCompany = db.InsuranceCompany.ToList();

            for (int i = 0; i < listCompany.Count; i++)
            {
                 listView.Items.Add(new ListViewItem(new string[] {
                     listCompany[i].CompanyName,
                     listCompany[i].Description,
                     Convert.ToString(listCompany[i].IdInsuranceCompany)
                 }));
            }

            for (int i = 0; i < listView.Columns.Count; i++)
                listView.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
