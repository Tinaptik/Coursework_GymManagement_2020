using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Business_logic
{
    [DataContract]
    public abstract class Person
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Patronymic { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public TrainingProgram TrainingProgram { get; set; }
    }
}
