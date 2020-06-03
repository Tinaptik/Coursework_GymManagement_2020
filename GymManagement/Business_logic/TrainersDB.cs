using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Business_logic
{
    public class TrainersDB
    {
        public List<Trainer> trainers = new List<Trainer>();

        public static int AutoIncrement = 0;

        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Trainer>));

        public static TrainersDB instance;

        public static TrainersDB GetInstance()
        {
            if (instance == null)
                instance = new TrainersDB();
            return instance;
        }

        public static int GetNextID()
        {
            return AutoIncrement++;
        }

        public void SaveTrainer()
        {
            using (FileStream stream = new FileStream("trainer.json", FileMode.Create, FileAccess.Write))
            {
                stream.Write(BitConverter.GetBytes(AutoIncrement), 0, 4);
                jsonSerializer.WriteObject(stream, trainers);
            }
        }

        public TrainersDB()
        {
            if (!File.Exists("trainer.json"))
                return;
            using (FileStream stream = new FileStream("trainer.json", FileMode.Open, FileAccess.Read))
            {
                byte[] array = new byte[4];
                stream.Read(array, 0, 4);
                AutoIncrement = BitConverter.ToInt32(array, 0);
                trainers = (List<Trainer>)jsonSerializer.ReadObject(stream);
            }
        }

        public Trainer AddTrainer()
        {
            var trainer = new Trainer { ID = AutoIncrement++ };
            trainers.Add(trainer);
            return trainer;
        }

        public List<Trainer> GetTrainers()
        {
            return trainers.Select(s => s)?.ToList();
        }

        public void RemoveTrainer(Trainer trainer)
        {
            trainers.Remove(trainer);
        }
    }
}
