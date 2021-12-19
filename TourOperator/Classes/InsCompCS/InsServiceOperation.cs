using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourOperator.Classes.DataConnection;
using TourOperator.Data;
using TourOperator.Forms.AllInsServiceForm;

namespace TourOperator.Classes.InsCompCS
{
    class InsServiceOperation
    {
        private static int _idCompany;
        public static int IdCompany { get => _idCompany; set => _idCompany = value; }

        private static TourOperatorEntities db = Helper.GetContext();

        public static void AddService(ListView listView, int Id)
        {
            IdCompany = Id;
            try
            {
                AddInsServiceForm addInsServiceForm = new AddInsServiceForm(IdCompany);
                addInsServiceForm.ShowDialog();

                if (addInsServiceForm.DialogResult == DialogResult.OK)
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
                MessageBox.Show(ex.Message + "\nInsServiceCompOperation.AddService");
            }
        }

        public static void EditeService(ListView listView, int idCompany)
        {
            IdCompany = idCompany;
            try
            {
                ServicesInsuranceCompany insService = new ServicesInsuranceCompany();

                insService = db.ServicesInsuranceCompany.Find(Convert.ToInt32(listView.SelectedItems[0].SubItems[listView.Items[0].SubItems.Count - 1].Text));

                EditeInsServiceForm editeInsService = new EditeInsServiceForm(insService.IdIncuranceService);
                editeInsService.ShowDialog();

                if (editeInsService.DialogResult == DialogResult.OK)
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
                MessageBox.Show(ex.Message + "\nInsServiceOperation.EditeService");
            }
        }

        public static void DeleteService(ListView listView)
        {
            try
            {
                ServicesInsuranceCompany insService = new ServicesInsuranceCompany();

                insService = db.ServicesInsuranceCompany.Find(Convert.ToInt32(listView.SelectedItems[0].SubItems[listView.Items[0].SubItems.Count - 1].Text));
                db.ServicesInsuranceCompany.Remove(insService);
                db.SaveChanges();
                UpdateListView(listView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInsServiceOperation.DeleteService");
            }
        }

        private static void UpdateListView(ListView listView)
        {
            listView.Items.Clear();

            List<ServicesInsuranceCompany> listService = db.ServicesInsuranceCompany.ToList();

            for (int i = 0; i < listService.Count; i++)
            {
                if (listService[i].IdInsuranceCompany == IdCompany)
                {
                    listView.Items.Add(new ListViewItem(new string[] {
                        listService[i].Service,
                        listService[i].Description,
                        Convert.ToString(listService[i].Cost),
                        Convert.ToString(listService[i].IdIncuranceService)
                        }));
                }
            }

            for (int i = 0; i < listView.Columns.Count; i++)
                listView.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
