using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Business_logic
{
    [DataContract]
    public class Trainer : Person
    {
        [DataMember]
        public int Salary { get; set; }
    }
}
