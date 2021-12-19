using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TourOperator.Classes.DataConnection;
using TourOperator.Data;
using TourOperator.Forms;
using TourOperator.Forms.AllClientForm;

namespace TourOperator.Classes.ClientPageCS
{
    class ClientOperation
    {
        readonly private static TourOperatorEntities db = Helper.GetContext();
        public static void AddClient(ListView listView)
        {
            try
            {
                AddClientForm addClientForm = new AddClientForm();
                addClientForm.ShowDialog();

                if (addClientForm.DialogResult == DialogResult.OK)
                {
                    UpdateListView(listView);
                    MessageBox.Show("Клиент был успешно добавлен", "Статус добавления");
                }

                else
                {
                    MessageBox.Show("Клиент не был добавлен");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nClientOperation.AddClient");
            }
        }
        public static void EditeClient(ListView listView)
        {
            try
            {
                Clients clients = new Clients();

                clients = db.Clients.Find(Convert.ToInt32(listView.SelectedItems[0].SubItems[listView.Items[0].SubItems.Count - 1].Text));

                EditeClientForm editeClientForm = new EditeClientForm(clients.IdClient);
                editeClientForm.ShowDialog();

                if (editeClientForm.DialogResult == DialogResult.OK)
                {
                    UpdateListView(listView);
                    MessageBox.Show("Клиент успешно отредактирован", "Редактирование клиента");
                }

                else
                {
                    MessageBox.Show("Клиент не был отредактирован", "Редактирование клиента");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nClientOperation.EditeClient");
            }
        }

        public static void DeleteClient(ListView listView)
        {
            try
            {
                Clients clients = new Clients();

                clients = db.Clients.Find(Convert.ToInt32(listView.SelectedItems[0].SubItems[listView.Items[0].SubItems.Count - 1].Text));
                db.Clients.Remove(clients);
                db.SaveChanges();
                UpdateListView(listView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nClientOperation.DeleteClient");
            }
        }

        private static void UpdateListView(ListView listView)
        {
            listView.Items.Clear();

            List<Clients> listClients = db.Clients.ToList();

            for (int i = 0; i < listClients.Count; i++)
            {
                if (listClients[i].SecondName.Equals("admin", StringComparison.OrdinalIgnoreCase) == false)
                {
                    listView.Items.Add(new ListViewItem(new string[] {
                        listClients[i].SecondName,
                        listClients[i].FirstName,
                        listClients[i].Country,
                        listClients[i].City,
                        listClients[i].Phone,
                        listClients[i].Email,
                        Convert.ToString(listClients[i].IdClient)
                    }));
                }
            }

            for (int i = 0; i < listView.Columns.Count; i++)
                listView.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
