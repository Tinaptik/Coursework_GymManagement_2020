using System;
using System.Collections;
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
using GymManagement.Forms;
using System.Runtime.Serialization;

namespace GymManagement
{
    public partial class FormClients : Form
    {        
        ClientsDB clientsDB;
        public static Form1 form1;

        public FormClients()
        {
            InitializeComponent();

            clientsDB = new ClientsDB();

            ShowClients(clientsDB.clients);
        }



        public void ShowClients(List<Client> clients)
        {
            listClients.Items.Clear();
            foreach (Client client in clients)
            {
                ListViewItem row = new ListViewItem(client.ID.ToString());
                row.SubItems.Add(client.Surname);
                row.SubItems.Add(client.Name);
                row.SubItems.Add(client.Patronymic);
                row.SubItems.Add(client.PhoneNumber);
                if(client?.TrainingProgram?.Name?.ToString() == null || client?.Trainer?.Surname?.ToString() == null)
                {                    
                    continue;
                }
                row.SubItems.Add(client.TrainingProgram.Name.ToString());
                row.SubItems.Add(client.Trainer.Surname.ToString());
                row.Tag = client;
                listClients.Items.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1(clientsDB.AddClient()).Show();
            
        }

        public void buttonUpdateList_Click(object sender, EventArgs e)
        {
            clientsDB.SaveClient();
            ShowClients(clientsDB.clients);
        }

        private void buttonDeleteClient_Click_1(object sender, EventArgs e)
        {
            if (listClients.SelectedIndices.Count == 0)
                return;
            Client client = (Client)listClients.SelectedItems[0].Tag;
            if (MessageBox.Show("Точно удалить клиента?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clientsDB.RemoveClient(client);
                clientsDB.SaveClient();
                ShowClients(clientsDB.clients);
            }
        }

        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
            if (listClients.SelectedIndices.Count == 0)
                return;
            Client client = (Client)listClients.SelectedItems[0].Tag;
            client.Name = textName.Text;
            client.Surname = textSurname.Text;
            client.Patronymic = textPatronymic.Text;
            client.PhoneNumber = textPhoneNumber.Text;
            client.TrainingProgram = (TrainingProgram)comboTrainingProgram.SelectedItem;
            client.Trainer = (Trainer)comboTrainer.SelectedItem;
            clientsDB.SaveClient();
            ShowClients(clientsDB.clients);
        }

        private void listClients_DoubleClick(object sender, EventArgs e)
        {
            if (listClients.SelectedIndices.Count == 0)
                return;
            Client client = (Client)listClients.SelectedItems[0].Tag;
            textName.Text = client.Name;
            textSurname.Text = client.Surname;
            textPatronymic.Text = client.Patronymic;
            textPhoneNumber.Text = client.PhoneNumber;
            Boxes();
        }

        void Boxes()
        {
            comboTrainer.DataSource = TrainersDB.GetInstance().GetTrainers();
            comboTrainer.DisplayMember = "Surname";
            comboTrainingProgram.DataSource = TrainingProgramsDB.GetInstance().GetTrainingPrograms();
            comboTrainingProgram.DisplayMember = "Name";
        }

        //public Client SelectedClient
        //{
        //    get
        //    {                
        //        return (Client)listClients.SelectedIndices;
        //    }
        //}

        //public void EditSelectedClient(string surname, string name, string patronymic, string phoneNumber)
        //{
        //    EditClient(SelectedClient, surname, name, patronymic, phoneNumber);
        //    ShowClients(clientsDB.clients);
        //}

        //private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //SelectedClientChanged?.Invoke();
        //    textSurname.Text = SelectedClient?.Surname;
        //    textName.Text = SelectedClient?.Name;
        //    textPatronymic.Text = SelectedClient?.Patronymic;
        //    textPhoneNumber.Text = SelectedClient?.PhoneNumber;
        //}

        //public void EditClient(Client selectedClient, string surname, string name, string patronymic, string phoneNumber)
        //{
        //    selectedClient.Surname = surname;
        //    selectedClient.Name = name;
        //    selectedClient.Patronymic = patronymic;
        //    selectedClient.PhoneNumber = phoneNumber;
        //    clientsDB.SaveClient();
        //}
    }
}