using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DTP_app.Models
{
    [DataContract]
    public class Person
    {

        [DataMember]
        public string PassportId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Patronymic { get; set; }
        [DataMember]
        public string RegistrationAdress { get; set; }
    }
}
