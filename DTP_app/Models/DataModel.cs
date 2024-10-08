using DTP_app.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DTP_app.Models
{
    [DataContract]
    public class DataModel
    {
        private static string dataPath = "../data.dat";
        [DataMember]
        public IEnumerable<Person> People { get; set; }
        [DataMember]
        public IEnumerable<Victim> Victims { get; set; }
        [DataMember]
        public IEnumerable<Transport> Transports { get; set; }
        [DataMember]
        public IEnumerable<Accident> Accidents { get; set; }
  

        DataModel() {

            People = new List<Person>() { 
                new Person() { PassportId = "sas11", FirstName = "first", LastName= "Lasr",
                               Patronymic= "Patron", RegistrationAdress = "Live here" } };
            Victims = new List<Victim>();
            Transports = new List<Transport>();
            Accidents = new List<Accident>();
  

        }


        public  static DataModel Load()
        {
            if (File.Exists(dataPath))
            {
                return DataSerializer.DeserializeData(dataPath);
            }
            return new DataModel();
        }

        public void Save()
        {
            DataSerializer.SerializeData(dataPath, this);
        }
    }
}
