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

namespace GymManagement.UI
{
    public partial class FormAddTrainer : Form
    {
        public static FormClients formClients;
        Trainer trainer;
        TrainersDB trainersDB;
        public FormAddTrainer(Trainer trainer)
        {
            InitializeComponent();
            this.trainer = trainer;
            trainersDB = new TrainersDB();

            textName.Text = trainer.Name;
            textSurname.Text = trainer.Surname;
            textPatronymic.Text = trainer.Patronymic;
            textPhoneNumber.Text = trainer.PhoneNumber;
            textSalary.Text = trainer.Salary.ToString();

            Boxes();

            

        }

        void Boxes()
        {
            comboTrainingProgram.DataSource = TrainingProgramsDB.GetInstance().GetTrainingPrograms();
            comboTrainingProgram.DisplayMember = "Name";
        }


        private void buttonNewTrainer_Click(object sender, EventArgs e)
        {
            trainer.ID = TrainersDB.GetNextID();
            trainer.Name = textName.Text;
            trainer.Surname = textSurname.Text;
            trainer.Patronymic = textPatronymic.Text;
            trainer.PhoneNumber = textPhoneNumber.Text;
            trainer.TrainingProgram = (TrainingProgram)comboTrainingProgram.SelectedItem;
            trainer.Salary = int.Parse(textSalary.Text);
            if(textSurname.Text != null || textSurname.Text != "")
            {
                trainersDB.SaveTrainer();
            }            
            ActiveForm.Close();
        }
    }
}
