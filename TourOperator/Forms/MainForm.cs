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
using TourOperator.Forms.AllClientForm;
using TourOperator.Classes.ClientPageCS;
using TourOperator.Classes.InsCompCS;
using TourOperator.Classes.CarrierCompCS;

namespace TourOperator.Forms
{
    public partial class MainForm : Form
    {
        readonly private TourOperatorEntities db = Helper.GetContext();
        private int _idCompany;
        public int IdCompany { get => _idCompany; set => _idCompany = value; }

        public MainForm()
        {
            InitializeComponent();
            ShowIcon = false;
            listViewClient.Columns.RemoveAt(listViewClient.Columns.Count - 1);
            listViewIncComp.Columns.RemoveAt(listViewIncComp.Columns.Count - 1);
            listViewCarrierCompany.Columns.RemoveAt(listViewCarrierCompany.Columns.Count - 1);
            listViewInsServices.Columns.RemoveAt(listViewInsServices.Columns.Count - 1);
            listViewCarrierServices.Columns.RemoveAt(listViewCarrierServices.Columns.Count - 1);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            RemoveTab();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void RemoveTab()
        {
            while (tabControl.TabCount != 0)
                tabControl.TabPages[0].Parent = null;
        }

        //
        #region Боковое меню
        private void btnClient_Click(object sender, EventArgs e)
        {
            RemoveTab();
            listViewClient.Items.Clear();
            tabPageClient.Parent = tabControl;

            List<Clients> listClients = db.Clients.ToList();

            for (int i = 0; i < listClients.Count; i++)
            {
                if (listClients[i].SecondName.Equals("admin", StringComparison.OrdinalIgnoreCase) == false)
                {
                    listViewClient.Items.Add(new ListViewItem(new string[] {
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

            for (int i = 0; i < listViewClient.Columns.Count; i++)
                listViewClient.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnInsCompany_Click(object sender, EventArgs e)
        {
            RemoveTab();
            listViewIncComp.Items.Clear();
            tabPageInsCompany.Parent = tabControl;

            List<InsuranceCompany> listCompany = db.InsuranceCompany.ToList();

            for (int i = 0; i < listCompany.Count; i++)
            {
                listViewIncComp.Items.Add(new ListViewItem(new string[] {
                    listCompany[i].CompanyName,
                    listCompany[i].Description,
                    Convert.ToString(listCompany[i].IdInsuranceCompany)
                }));
            }

            for (int i = 0; i < listViewIncComp.Columns.Count; i++)
                listViewIncComp.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnCarrierCompany_Click(object sender, EventArgs e)
        {
            RemoveTab();
            listViewCarrierCompany.Items.Clear();
            tabPageCarrierCompany.Parent = tabControl;

            List<CarrierCompany> listCompany = db.CarrierCompany.ToList();

            for (int i = 0; i < listCompany.Count; i++)
            {
                listViewCarrierCompany.Items.Add(new ListViewItem(new string[] {
                    listCompany[i].CompanyName,
                    listCompany[i].Description,
                    Convert.ToString(listCompany[i].IdCarrierCompany)
                }));
            }

            for (int i = 0; i < listViewCarrierCompany.Columns.Count; i++)
                listViewCarrierCompany.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        #region Логика сервисов страхования
        private void btnInsService_Click(object sender, EventArgs e)
        {
            RemoveTab();
            comboBoxInsCompany.Items.Clear();
            listViewInsServices.Items.Clear();
            tabPageInsServices.Parent = tabControl;

            List<InsuranceCompany> listInsCompany = db.InsuranceCompany.ToList();

            for (int i = 0; i < listInsCompany.Count; i++)
                comboBoxInsCompany.Items.Add(listInsCompany[i].CompanyName);
        }

        private void comboBoxInsCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                InsuranceCompany insuranceCompany = db.InsuranceCompany.ToList().Find(Name => comboBoxInsCompany.GetItemText(comboBoxInsCompany.SelectedItem) == Name.CompanyName);
                List<ServicesInsuranceCompany> serviceCompany = db.ServicesInsuranceCompany.ToList();

                listViewInsServices.Items.Clear();

                int id = insuranceCompany.IdInsuranceCompany;
                for (int i = 0; i < serviceCompany.Count; i++)
                {
                    if (serviceCompany[i].IdInsuranceCompany == id)
                    {
                        listViewInsServices.Items.Add(new ListViewItem(new string[] {
                        serviceCompany[i].Service,
                        serviceCompany[i].Description,
                        Convert.ToString(serviceCompany[i].Cost),
                        Convert.ToString(serviceCompany[i].IdIncuranceService)
                        }));
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            for (int i = 0; i < listViewCarrierServices.Columns.Count; i++)
                listViewInsServices.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        #endregion

        #region Логика сервисов перевозчиков
        private void btnCarrierService_Click(object sender, EventArgs e)
        {
            RemoveTab();
            listViewCarrierServices.Items.Clear();
            comboBoxCarrierCompany.Items.Clear();
            tabPageCarrierServices.Parent = tabControl;

            List<CarrierCompany> listCarrierCompany = db.CarrierCompany.ToList();

            for (int i = 0; i < listCarrierCompany.Count; i++)
                comboBoxCarrierCompany.Items.Add(listCarrierCompany[i].CompanyName);

        }

        private void comboBoxCarrierCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CarrierCompany carrierCompany = db.CarrierCompany.ToList().Find(Name => comboBoxCarrierCompany.GetItemText(comboBoxCarrierCompany.SelectedItem) == Name.CompanyName);
                List<ServicesCarrierCompany> serviceCompany = db.ServicesCarrierCompany.ToList();

                listViewCarrierServices.Items.Clear();

                int id = carrierCompany.IdCarrierCompany;
                for (int i = 0; i < serviceCompany.Count; i++)
                {
                    if (serviceCompany[i].IdCarrierCompany == id)
                    {
                        listViewCarrierServices.Items.Add(new ListViewItem(new string[] {
                        serviceCompany[i].Service,
                        serviceCompany[i].Description,
                        Convert.ToString(serviceCompany[i].Cost),
                        Convert.ToString(serviceCompany[i].IdCarrierService)
                        }));
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            for (int i = 0; i < listViewCarrierServices.Columns.Count; i++)
                listViewCarrierServices.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        #endregion


        #endregion

        #region Нижняя панель с кнопками
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageClient)
            {
                ClientOperation.AddClient(listViewClient);
            }

            else if (tabControl.SelectedTab == tabPageInsCompany)
            {
                InsCompOperation.AddCompany(listViewIncComp);
            }

            else if (tabControl.SelectedTab == tabPageCarrierCompany)
            {
                CarrierCompanyOperation.AddCompany(listViewCarrierCompany);
            }

            else if (tabControl.SelectedTab == tabPageInsServices && comboBoxInsCompany.SelectedItem != null)
            {
                GetIdCompany();
                InsServiceOperation.AddService(listViewInsServices, IdCompany);
            }

            else if (tabControl.SelectedTab == tabPageCarrierServices && comboBoxCarrierCompany.SelectedItem != null)
            {
                GetIdCompany();
                CarrierServiceOperation.AddService(listViewCarrierServices, IdCompany);
            }
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageClient && listViewClient.SelectedItems.Count > 0)
            {
                ClientOperation.EditeClient(listViewClient);
            }

            else if (tabControl.SelectedTab == tabPageInsCompany && listViewIncComp.SelectedItems.Count > 0)
            {
                InsCompOperation.EditeCompany(listViewIncComp);
            }

            else if (tabControl.SelectedTab == tabPageCarrierCompany && listViewCarrierCompany.SelectedItems.Count > 0)
            {
                CarrierCompanyOperation.EditeCompany(listViewCarrierCompany);
            }

            else if (tabControl.SelectedTab == tabPageInsServices && comboBoxInsCompany.SelectedItem != null)
            {
                GetIdCompany();
                InsServiceOperation.EditeService(listViewInsServices, IdCompany);
            }

            else if (tabControl.SelectedTab == tabPageCarrierServices && comboBoxCarrierCompany.SelectedItem != null)
            {
                GetIdCompany();
                CarrierServiceOperation.EditeService(listViewCarrierServices, IdCompany);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageClient && listViewClient.SelectedItems.Count > 0)
            {
                ClientOperation.DeleteClient(listViewClient);
            }

            else if (tabControl.SelectedTab == tabPageInsCompany && listViewIncComp.SelectedItems.Count > 0)
            {
                InsCompOperation.DeleteCompany(listViewIncComp);
            }

            else if (tabControl.SelectedTab == tabPageCarrierCompany && listViewCarrierCompany.SelectedItems.Count > 0)
            {
                CarrierCompanyOperation.DeleteCompany(listViewCarrierCompany);
            }

            else if (tabControl.SelectedTab == tabPageInsServices && listViewInsServices.SelectedItems.Count > 0)
            {
                InsServiceOperation.DeleteService(listViewInsServices);
            }

            else if (tabControl.SelectedTab == tabPageCarrierServices && listViewCarrierServices.SelectedItems.Count > 0)
            {
                CarrierServiceOperation.DeleteService(listViewCarrierServices);
            }
        }

        #endregion

        private void GetIdCompany()
        {
            if (tabControl.SelectedTab == tabPageInsServices)
            {
                InsuranceCompany insCompany = db.InsuranceCompany.ToList().Find(Name => comboBoxInsCompany.GetItemText(comboBoxInsCompany.SelectedItem) == Name.CompanyName);
                List<ServicesInsuranceCompany> serviceCompany = db.ServicesInsuranceCompany.ToList();
                IdCompany = insCompany.IdInsuranceCompany;
            }

            else if (tabControl.SelectedTab == tabPageCarrierServices)
            {
                CarrierCompany carrierCompany = db.CarrierCompany.ToList().Find(Name => comboBoxCarrierCompany.GetItemText(comboBoxCarrierCompany.SelectedItem) == Name.CompanyName);
                List<ServicesCarrierCompany> serviceCompany = db.ServicesCarrierCompany.ToList();
                IdCompany = carrierCompany.IdCarrierCompany;
            }
        }
    }
}
