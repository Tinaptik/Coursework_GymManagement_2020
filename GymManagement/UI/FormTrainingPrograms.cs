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
    public partial class FormTrainingPrograms : Form
    {
        TrainingProgramsDB trainingProgramsDB;
        public static FormAddTrainer formAddTrainer;

        public FormTrainingPrograms()
        {
            InitializeComponent();

            trainingProgramsDB = new TrainingProgramsDB();

            ShowTrainingPrograms(trainingProgramsDB.trainingPrograms);
        }



        public void ShowTrainingPrograms(List<TrainingProgram> trainingPrograms)
        {
            listTrainingPrograms.Items.Clear();
            foreach (TrainingProgram trainingProgram in trainingPrograms)
            {
                ListViewItem row = new ListViewItem(trainingProgram.ID.ToString());
                row.SubItems.Add(trainingProgram.Name);
                row.SubItems.Add(trainingProgram.Price1Train.ToString());
                row.SubItems.Add(trainingProgram.Price8Trains.ToString());
                row.SubItems.Add(trainingProgram.Price12Trains.ToString());
                row.SubItems.Add(trainingProgram.Price1Month.ToString());
                row.SubItems.Add(trainingProgram.Price3Months.ToString());
                row.SubItems.Add(trainingProgram.Price6Months.ToString());
                row.SubItems.Add(trainingProgram.Price1Year.ToString());
                row.Tag = trainingProgram;
                listTrainingPrograms.Items.Add(row);
            }
        }

        private void buttonNewTrainingProgram_Click(object sender, EventArgs e)
        {
            new FormAddTrainingProgram(trainingProgramsDB.AddTrainingProgram()).Show();
        }

        private void buttonDeleteTrainingProgram_Click(object sender, EventArgs e)
        {
            if (listTrainingPrograms.SelectedIndices.Count == 0)
                return;
            TrainingProgram trainingProgram = (TrainingProgram)listTrainingPrograms.SelectedItems[0].Tag;
            if (MessageBox.Show("Точно удалить клиента?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                trainingProgramsDB.RemoveTrainingProgram(trainingProgram);
                trainingProgramsDB.SaveTrainingProgram();
                ShowTrainingPrograms(trainingProgramsDB.trainingPrograms);
            }
        }

        private void buttonUpdateList_Click_1(object sender, EventArgs e)
        {
            trainingProgramsDB.SaveTrainingProgram();
            ShowTrainingPrograms(trainingProgramsDB.trainingPrograms);
        }

        private void buttonSaveTrainingProgram_Click(object sender, EventArgs e)
        {
            if (listTrainingPrograms.SelectedIndices.Count == 0)
                return;
            TrainingProgram trainingProgram = (TrainingProgram)listTrainingPrograms.SelectedItems[0].Tag;
            trainingProgram.Name = textName.Text;
            trainingProgram.Price1Train = int.Parse(text1Train.Text);
            trainingProgram.Price8Trains = int.Parse(text8Trains.Text);
            trainingProgram.Price12Trains = int.Parse(text12Trains.Text);
            trainingProgram.Price1Month = int.Parse(text1Month.Text);
            trainingProgram.Price3Months = int.Parse(text3Months.Text);
            trainingProgram.Price6Months = int.Parse(text6Months.Text);
            trainingProgram.Price1Year = int.Parse(text1Year.Text);
            trainingProgramsDB.SaveTrainingProgram();
            ShowTrainingPrograms(trainingProgramsDB.trainingPrograms);
        }

        private void listTrainingPrograms_DoubleClick(object sender, EventArgs e)
        {
            if (listTrainingPrograms.SelectedIndices.Count == 0)
                return;
            TrainingProgram trainingProgram = (TrainingProgram)listTrainingPrograms.SelectedItems[0].Tag;
            textName.Text = trainingProgram.Name;
            text1Train.Text = trainingProgram.Price1Train.ToString();
            text8Trains.Text = trainingProgram.Price8Trains.ToString();
            text12Trains.Text = trainingProgram.Price12Trains.ToString();
            text1Month.Text = trainingProgram.Price1Month.ToString();
            text3Months.Text = trainingProgram.Price3Months.ToString();
            text6Months.Text = trainingProgram.Price6Months.ToString();
            text1Year.Text = trainingProgram.Price1Year.ToString();
        }
    }
}
