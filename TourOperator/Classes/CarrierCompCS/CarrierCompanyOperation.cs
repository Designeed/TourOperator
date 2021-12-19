using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourOperator.Classes.DataConnection;
using TourOperator.Data;
using TourOperator.Forms.AllCarrierCompany;

namespace TourOperator.Classes.CarrierCompCS
{
    class CarrierCompanyOperation
    {
        readonly private static TourOperatorEntities db = Helper.GetContext();
        public static void AddCompany(ListView listView)
        {
            try
            {
                AddCarrierCompanyForm addCarrierCompanypForm = new AddCarrierCompanyForm();
                addCarrierCompanypForm.ShowDialog();

                if (addCarrierCompanypForm.DialogResult == DialogResult.OK)
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
                MessageBox.Show(ex.Message + "\nCarrierCompanypOperation.AddCompany");
            }
        }

        public static void EditeCompany(ListView listView)
        {
            try
            {
                CarrierCompany carrierCompany = new CarrierCompany();

                carrierCompany = db.CarrierCompany.Find(Convert.ToInt32(listView.SelectedItems[0].SubItems[listView.Items[0].SubItems.Count - 1].Text));

                EditeCarrierCompanyForm editeCarrier = new EditeCarrierCompanyForm(carrierCompany.IdCarrierCompany);
                editeCarrier.ShowDialog();

                if (editeCarrier.DialogResult == DialogResult.OK)
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
                MessageBox.Show(ex.Message + "\nCarrierCompany.EditeCompany");
            }
        }

        public static void DeleteCompany(ListView listView)
        {
            try
            {
                CarrierCompany carrierCompany = new CarrierCompany();

                carrierCompany = db.CarrierCompany.Find(Convert.ToInt32(listView.SelectedItems[0].SubItems[listView.Items[0].SubItems.Count - 1].Text));
                db.CarrierCompany.Remove(carrierCompany);
                db.SaveChanges();
                UpdateListView(listView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nCarrierCompanyOperation.DeleteCompany");
            }
        }

        private static void UpdateListView(ListView listView)
        {
            listView.Items.Clear();

            List<CarrierCompany> listCompany = db.CarrierCompany.ToList();

            for (int i = 0; i < listCompany.Count; i++)
            {
                listView.Items.Add(new ListViewItem(new string[] {
                     listCompany[i].CompanyName,
                     listCompany[i].Description,
                     Convert.ToString(listCompany[i].IdCarrierCompany)
                 }));
            }

            for (int i = 0; i < listView.Columns.Count; i++)
                listView.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
