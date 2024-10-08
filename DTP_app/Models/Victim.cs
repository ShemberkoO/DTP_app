using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DTP_app.Models
{
    [DataContract]
    public class Victim
    {
        [DataMember]
        public string PassportId { get; set; }
        [DataMember]
        public VictimStatus Status { get; set; }
        [DataMember]
        public int AccidentId { get; set; }
    }
}
