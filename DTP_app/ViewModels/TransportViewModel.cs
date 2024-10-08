using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DTP_app.ViewModels
{
    public class TransportViewModel:ViewModelBase
        {

        private int _Id;
        public int Id {
            get { return _Id; }
            set
            {
                _Id = value;
                OnPropertyChange("Id");
            }
        }


        private string _Type;
        public string Type {

            get { return _Type; }
            set
            {
                _Type = value;
                OnPropertyChange("Type");
            }
        }


        private string _RegistrationNumber;
        public string RegistrationNumber
        {

            get { return _RegistrationNumber; }
            set
            {
                _RegistrationNumber = value;
                OnPropertyChange("RegistrationNumber");
            }
        }

        private string _Model;
        public string Model
        {

            get { return _Model; }
            set
            {
                _Model = value;
                OnPropertyChange("Model");
            }
        }

        private string _Brand;
        public string Brand
        {

            get { return _Brand; }
            set
            {
                _Brand = value;
                OnPropertyChange("Brand");
            }
        }

        private string _OwnerId;
        public string OwnerId
        {

            get { return _OwnerId; }
            set
            {
                _OwnerId = value;
                OnPropertyChange("OwnerId");
            }
        }

        private DateTime _YearOfManufacture;
        public DateTime YearOfManufacture
        {

            get { return _YearOfManufacture; }
            set
            {
                _YearOfManufacture = value;
                OnPropertyChange("YearOfManufacture");
            }
        }
    }

}
