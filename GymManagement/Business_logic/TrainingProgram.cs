using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Business_logic
{
    [DataContract]
    public class TrainingProgram
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Price1Train { get; set; }
        [DataMember]
        public int Price8Trains { get; set; }
        [DataMember]
        public int Price12Trains { get; set; }
        [DataMember]
        public int Price1Month { get; set; }
        [DataMember]
        public int Price3Months { get; set; }
        [DataMember]
        public int Price6Months { get; set; }
        [DataMember]
        public int Price1Year { get; set; }
    }
}
