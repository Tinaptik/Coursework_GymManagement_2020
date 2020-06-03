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
    public partial class FormAddTrainingProgram : Form
    {
        public static FormTrainingPrograms formTrainingPrograms;
        TrainingProgram trainingProgram;
        TrainingProgramsDB trainingProgramsDB;

        public FormAddTrainingProgram(TrainingProgram trainingProgram)
        {
            InitializeComponent();
            this.trainingProgram = trainingProgram;
            trainingProgramsDB = new TrainingProgramsDB();

            textName.Text = trainingProgram.Name;
            text1Train.Text = trainingProgram.Price1Train.ToString();
            text8Trains.Text = trainingProgram.Price8Trains.ToString();
            text12Trains.Text = trainingProgram.Price12Trains.ToString();
            text1Month.Text = trainingProgram.Price1Month.ToString();
            text3Months.Text = trainingProgram.Price3Months.ToString();
            text6Months.Text = trainingProgram.Price6Months.ToString();
            text1Year.Text = trainingProgram.Price1Year.ToString();
        }

        private void buttonNewTrainingProgram_Click(object sender, EventArgs e)
        {
            trainingProgram.ID = TrainingProgramsDB.GetNextID();
            trainingProgram.Name = textName.Text;
            trainingProgram.Price1Train = int.Parse(text1Train.Text);
            trainingProgram.Price8Trains = int.Parse(text8Trains.Text);
            trainingProgram.Price12Trains = int.Parse(text12Trains.Text);
            trainingProgram.Price1Month = int.Parse(text1Month.Text);
            trainingProgram.Price3Months = int.Parse(text3Months.Text);
            trainingProgram.Price6Months = int.Parse(text6Months.Text);
            trainingProgram.Price1Year = int.Parse(text1Year.Text);
            trainingProgramsDB.SaveTrainingProgram();
            ActiveForm.Close();
        }
    }
}
