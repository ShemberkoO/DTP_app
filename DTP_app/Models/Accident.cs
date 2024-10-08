using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DTP_app.Models
{
    [DataContract]
    public class Accident
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public string Description { get; set; }

    }
}
