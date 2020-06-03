using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Business_logic
{
    public class ClientsDB
    {
        public List<Client> clients = new List<Client>();

        public static int AutoIncrement = 0;

        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Client>));

        public static ClientsDB instance;

        public static ClientsDB GetInstance()
        {
            if (instance == null)
                instance = new ClientsDB();
            return instance;
        }

        public static int GetNextID()
        {
            return AutoIncrement++;
        }

        public void SaveClient()
        {
            using (FileStream stream = new FileStream("client.json", FileMode.Create, FileAccess.Write))
            {
                stream.Write(BitConverter.GetBytes(AutoIncrement), 0, 4);
                jsonSerializer.WriteObject(stream, clients);
            }
        }

        public ClientsDB()
        {
            if (!File.Exists("client.json"))
                return;
            using (FileStream stream = new FileStream("client.json", FileMode.Open, FileAccess.ReadWrite))
            {
                byte[] array = new byte[4];
                stream.Read(array, 0, 4);
                AutoIncrement = BitConverter.ToInt32(array, 0);
                clients = (List<Client>)jsonSerializer.ReadObject(stream);
            }
        }

        public Client AddClient()
        {
            var client = new Client { ID = AutoIncrement++ };
            clients.Add(client);
            return client;
        }

        public void RemoveClient(Client client)
        {
            clients.Remove(client);
        }
    }
}
