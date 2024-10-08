using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DTP_app.Models
{
    [DataContract]
    public class Transport
    {

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string RegistrationNumber { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public string Brand { get; set; }

        [DataMember]
        public string OwnerId { get; set; }

        [DataMember]
        public DateTime YearOfManufacture { get; set; }
    }
}
