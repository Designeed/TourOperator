using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourOperator.Classes.DataConnection;
using TourOperator.Data;
using TourOperator.Forms.AllCarrierServiceForm;

namespace TourOperator.Classes.CarrierCompCS
{
    class CarrierServiceOperation
    {
        private static int _idCompany;
        public static int IdCompany { get => _idCompany; set => _idCompany = value; }

        private static TourOperatorEntities db = Helper.GetContext();

        public static void AddService(ListView listView, int Id)
        {
            IdCompany = Id;
            try
            {
                AddCarrierServiceForm addCarrierServiceForm = new AddCarrierServiceForm(IdCompany);
                addCarrierServiceForm.ShowDialog();

                if (addCarrierServiceForm.DialogResult == DialogResult.OK)
                {
                    UpdateListView(listView);
                    MessageBox.Show("Сервис был успешно добавлен", "Статус добавления");
                }

                else
                {
                    MessageBox.Show("Сервис не был добавлен");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nCarrierServiceCompOperation.AddService");
            }
        }

        public static void EditeService(ListView listView, int idCompany)
        {
            IdCompany = idCompany;
            try
            {
                ServicesCarrierCompany carrierService = new ServicesCarrierCompany();

                carrierService = db.ServicesCarrierCompany.Find(Convert.ToInt32(listView.SelectedItems[0].SubItems[listView.Items[0].SubItems.Count - 1].Text));

                EditeCarrierServiceForm editeCarrierService = new EditeCarrierServiceForm(carrierService.IdCarrierService);
                editeCarrierService.ShowDialog();

                if (editeCarrierService.DialogResult == DialogResult.OK)
                {
                    UpdateListView(listView);
                    MessageBox.Show("Сервис был успешно отредактирован", "Статус редактирования");
                }

                else
                {
                    MessageBox.Show("Сервис не был отредактирован", "Статус редактирования");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nCarrierServiceOperation.EditeService");
            }
        }

        public static void DeleteService(ListView listView)
        {
            try
            {
                ServicesCarrierCompany carrierService = new ServicesCarrierCompany();

                carrierService = db.ServicesCarrierCompany.Find(Convert.ToInt32(listView.SelectedItems[0].SubItems[listView.Items[0].SubItems.Count - 1].Text));
                db.ServicesCarrierCompany.Remove(carrierService);
                db.SaveChanges();
                UpdateListView(listView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nCarrierServiceOperation.DeleteService");
            }
        }

        private static void UpdateListView(ListView listView)
        {
            listView.Items.Clear();

            List<ServicesCarrierCompany> listService = db.ServicesCarrierCompany.ToList();

            for (int i = 0; i < listService.Count; i++)
            {
                if (listService[i].IdCarrierCompany == IdCompany)
                {
                    listView.Items.Add(new ListViewItem(new string[] {
                        listService[i].Service,
                        listService[i].Description,
                        Convert.ToString(listService[i].Cost),
                        Convert.ToString(listService[i].IdCarrierService)
                        }));
                }
            }

            for (int i = 0; i < listView.Columns.Count; i++)
                listView.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
