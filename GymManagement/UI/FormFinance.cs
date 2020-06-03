using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using GymManagement.Business_logic;

namespace GymManagement
{
    public partial class FormFinance : Form
    {
        ClientsDB clientsDB;
        DateTime dateStart = new DateTime(2010, 10, 10);
        DateTime dateFinish = new DateTime(2100, 10, 10);


        public FormFinance()
        {
            InitializeComponent();

            clientsDB = new ClientsDB();

            ShowClientsFinance(clientsDB.clients);
        }

        public void ShowClientsFinance(List<Client> clients)
        {
            listClientsFinance.Items.Clear();
            foreach(Client client in clients)
            {
                if (DateTime.Now > client.AbonementFinish)
                {
                    client.GymAccess = false;
                }
            }
            foreach (Client client in clients)
            {
                ListViewItem row = new ListViewItem(client.ID.ToString());
                row.SubItems.Add(client.Surname);
                row.SubItems.Add(client.Name);
                if (client?.TrainingProgram?.Name?.ToString() == null || client?.Trainer?.Surname?.ToString() == null)
                {
                    continue;
                }
                row.SubItems.Add(client.TrainingProgram.Name.ToString());
                row.SubItems.Add(client.Account.ToString());
                if(client.AbonementStart == dateStart)
                {
                    row.SubItems.Add("абонемент не куплен");
                }
                else
                {
                    row.SubItems.Add(client.AbonementStart.ToString());
                }
                if (client.AbonementFinish == dateFinish)
                {
                    row.SubItems.Add("абонемент не куплен");
                }
                else
                {
                    row.SubItems.Add(client.AbonementFinish.ToString());
                }
                if(client.GymAccess == true)
                {
                    row.SubItems.Add("есть");
                }
                else
                {
                    row.SubItems.Add("нет");
                }                
                row.Tag = client;
                listClientsFinance.Items.Add(row);
            }
        }

        private void buttonUpdateList_Click(object sender, EventArgs e)
        {
            clientsDB.SaveClient();
            ShowClientsFinance(clientsDB.clients);
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            if (listClientsFinance.SelectedIndices.Count == 0)
                return;
            Client client = (Client)listClientsFinance.SelectedItems[0].Tag;
            client.Account += int.Parse(textDepositSum.Text);
            clientsDB.SaveClient();
            ShowClientsFinance(clientsDB.clients);
        }

        private void buttonSellAbonement_Click(object sender, EventArgs e)
        {
            if (listClientsFinance.SelectedIndices.Count == 0)
                return;
            Client client = (Client)listClientsFinance.SelectedItems[0].Tag;
            if(client.Account >= int.Parse(textAbonementPrice.Text))
            {
                client.Account -= int.Parse(textAbonementPrice.Text);
                client.GymAccess = true;
                client.AbonementStart = DateTime.Today;
                client.AbonementFinish = DateTime.Today;
                if (comboAbonementTerm.Text == "1 тренировка")
                {
                    client.AbonementFinish = client.AbonementFinish.AddMonths(1);
                }
                if (comboAbonementTerm.Text == "8 тренировок")
                {
                    client.AbonementFinish = client.AbonementFinish.AddMonths(1);
                }
                if (comboAbonementTerm.Text == "12 тренировок")
                {
                    client.AbonementFinish = client.AbonementFinish.AddMonths(1);
                }
                if (comboAbonementTerm.Text == "1 месяц")
                {
                    client.AbonementFinish = client.AbonementFinish.AddMonths(1);
                }
                if (comboAbonementTerm.Text == "3 месяца")
                {
                    client.AbonementFinish = client.AbonementFinish.AddMonths(3);
                }
                if (comboAbonementTerm.Text == "6 месяцев")
                {
                    client.AbonementFinish = client.AbonementFinish.AddMonths(6);
                }
                if (comboAbonementTerm.Text == "1 год")
                {
                    client.AbonementFinish = client.AbonementFinish.AddYears(1);
                }
            }
            clientsDB.SaveClient();
            ShowClientsFinance(clientsDB.clients);


        }

        private void listClientsFinance_DoubleClick(object sender, EventArgs e)
        {
            if (listClientsFinance.SelectedIndices.Count == 0)
                return;
            Client client = (Client)listClientsFinance.SelectedItems[0].Tag;
            textID.Text = client.ID.ToString();
            textClientID.Text = client.ID.ToString();
        }

        private void comboAbonementTerm_TextChanged(object sender, EventArgs e)
        {
            if (listClientsFinance.SelectedIndices.Count == 0)
                return;
            Client client = (Client)listClientsFinance.SelectedItems[0].Tag;
            if (comboAbonementTerm.Text == "1 тренировка")
            {
                textAbonementPrice.Text = client.TrainingProgram.Price1Train.ToString();
            }
            if (comboAbonementTerm.Text == "8 тренировок")
            {
                textAbonementPrice.Text = client.TrainingProgram.Price8Trains.ToString();
            }
            if (comboAbonementTerm.Text == "12 тренировок")
            {
                textAbonementPrice.Text = client.TrainingProgram.Price12Trains.ToString();
            }
            if (comboAbonementTerm.Text == "1 месяц")
            {
                textAbonementPrice.Text = client.TrainingProgram.Price1Month.ToString();
            }
            if (comboAbonementTerm.Text == "3 месяца")
            {
                textAbonementPrice.Text = client.TrainingProgram.Price3Months.ToString();
            }
            if (comboAbonementTerm.Text == "6 месяцев")
            {
                textAbonementPrice.Text = client.TrainingProgram.Price6Months.ToString();
            }
            if (comboAbonementTerm.Text == "1 год")
            {
                textAbonementPrice.Text = client.TrainingProgram.Price1Year.ToString();
            }


        }

        private void listClientsFinance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listClientsFinance.SelectedIndices.Count == 0)
                return;
            Client client = (Client)listClientsFinance.SelectedItems[0].Tag;
            comboAbonementTerm.Text = null;
            textAbonementPrice.Text = null;
        }
    }
}
