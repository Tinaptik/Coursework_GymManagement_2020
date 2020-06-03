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
using GymManagement.UI;

namespace GymManagement
{
    public partial class FormStaff : Form
    {
        TrainersDB trainersDB;

        public FormStaff()
        {
            InitializeComponent();

            trainersDB = new TrainersDB();

            ShowTrainers(trainersDB.trainers);
        }
        public void ShowTrainers(List<Trainer> trainers)
        {
            listTrainers.Items.Clear();
            foreach (Trainer trainer in trainers)
            {
                ListViewItem row = new ListViewItem(trainer.ID.ToString());
                row.SubItems.Add(trainer.Surname);
                row.SubItems.Add(trainer.Name);
                row.SubItems.Add(trainer.Patronymic);
                row.SubItems.Add(trainer.PhoneNumber);
                if (trainer?.TrainingProgram?.Name?.ToString() == null)
                {                    
                    continue;
                }
                row.SubItems.Add(trainer.TrainingProgram.Name.ToString());
                row.SubItems.Add(trainer.Salary.ToString());
                row.Tag = trainer;
                listTrainers.Items.Add(row);
            }
        }

        private void buttonNewTrainer_Click(object sender, EventArgs e)
        {
            new FormAddTrainer(trainersDB.AddTrainer()).Show();
        }

        private void buttonDeleteTrainer_Click(object sender, EventArgs e)
        {
            if (listTrainers.SelectedIndices.Count == 0)
                return;
            Trainer trainer = (Trainer)listTrainers.SelectedItems[0].Tag;
            if (MessageBox.Show("Точно удалить тренера?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                trainersDB.RemoveTrainer(trainer);
                trainersDB.SaveTrainer();
                ShowTrainers(trainersDB.trainers);
            }
        }

        private void buttonUpdateList_Click(object sender, EventArgs e)
        {
            trainersDB.SaveTrainer();
            ShowTrainers(trainersDB.trainers);
        }

        private void buttonSaveTrainer_Click(object sender, EventArgs e)
        {
            if (listTrainers.SelectedIndices.Count == 0)
                return;
            Trainer trainer = (Trainer)listTrainers.SelectedItems[0].Tag;
            trainer.Name = textName.Text;
            trainer.Surname = textSurname.Text;
            trainer.Patronymic = textPatronymic.Text;
            trainer.PhoneNumber = textPhoneNumber.Text;
            trainer.TrainingProgram = (TrainingProgram)comboTrainingProgram.SelectedItem;
            trainer.Salary = int.Parse(textSalary.Text);
            trainersDB.SaveTrainer();
            ShowTrainers(trainersDB.trainers);
        }

        private void listTrainers_DoubleClick(object sender, EventArgs e)
        {
            if (listTrainers.SelectedIndices.Count == 0)
                return;
            Trainer trainer = (Trainer)listTrainers.SelectedItems[0].Tag;
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
    }
}
