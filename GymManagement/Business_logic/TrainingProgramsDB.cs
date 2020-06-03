using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Business_logic
{
    class TrainingProgramsDB
    {
        public List<TrainingProgram> trainingPrograms = new List<TrainingProgram>();

        public static int AutoIncrement = 0;

        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<TrainingProgram>));

        public static TrainingProgramsDB instance;

        public static TrainingProgramsDB GetInstance()
        {
            if (instance == null)
                instance = new TrainingProgramsDB();
            return instance;
        }

        public static int GetNextID()
        {
            return AutoIncrement++;
        }

        public void SaveTrainingProgram()
        {
            using (FileStream stream = new FileStream("trainingProgram.json", FileMode.Create, FileAccess.Write))
            {
                stream.Write(BitConverter.GetBytes(AutoIncrement), 0, 4);
                jsonSerializer.WriteObject(stream, trainingPrograms);
            }
        }

        public TrainingProgramsDB()
        {
            if (!File.Exists("trainingProgram.json"))
                return;
            using (FileStream stream = new FileStream("trainingProgram.json", FileMode.Open, FileAccess.ReadWrite))
            {
                byte[] array = new byte[4];
                stream.Read(array, 0, 4);
                AutoIncrement = BitConverter.ToInt32(array, 0);
                trainingPrograms = (List<TrainingProgram>)jsonSerializer.ReadObject(stream);
            }
        }

        public TrainingProgram AddTrainingProgram()
        {
            var trainingProgram = new TrainingProgram { ID = AutoIncrement++ };
            trainingPrograms.Add(trainingProgram);
            return trainingProgram;
        }

        public List<TrainingProgram> GetTrainingPrograms()
        {
            return trainingPrograms.Select(s => s)?.ToList();
        }

        public void RemoveTrainingProgram(TrainingProgram trainingProgram)
        {
            trainingPrograms.Remove(trainingProgram);
        }
    }
}
