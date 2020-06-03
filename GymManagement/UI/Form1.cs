using GymManagement.Business_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace GymManagement.Forms
{
    public partial class Form1 : Form
    {
        public static FormClients formClients;
        Client client;
        ClientsDB clientsDB;
        
        public Form1(Client client)
        {
            InitializeComponent();
            this.client = client;
            clientsDB = new ClientsDB();

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

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            client.ID = ClientsDB.GetNextID();
            client.Name = textName.Text;
            client.Surname = textSurname.Text;
            client.Patronymic = textPatronymic.Text;
            client.PhoneNumber = textPhoneNumber.Text;
            client.TrainingProgram = (TrainingProgram)comboTrainingProgram.SelectedItem;
            client.Trainer = (Trainer)comboTrainer.SelectedItem;
            if(comboTrainer.SelectedItem != null)
            {
                clientsDB.SaveClient();
            }
                                         
            ActiveForm.Close();
        }
    }
}
