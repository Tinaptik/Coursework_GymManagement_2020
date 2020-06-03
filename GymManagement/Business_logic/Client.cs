using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement.Business_logic
{
    [DataContract]
    public class Client : Person
    {        
        [DataMember]
        public Trainer Trainer { get; set; }
        [DataMember]
        public int Account { get; set; } = 0;
        [DataMember]
        public bool GymAccess { get; set; } = false;
        [DataMember]
        public DateTime AbonementStart { get; set; } = new DateTime (2010, 10, 10);
        [DataMember]
        public DateTime AbonementFinish { get; set; } = new DateTime(2100, 10, 10);

    }
}
