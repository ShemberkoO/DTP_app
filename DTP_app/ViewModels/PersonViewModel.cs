using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DTP_app.ViewModels
{
    public class PersonViewModel: ViewModelBase
    {

        private string _PassportId;

        public string PassportId
        {
            get { return _PassportId; }
            set
            {
                _PassportId = value;
                OnPropertyChange("PassportId");
            }
        }

        private string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                _FirstName = value;
                OnPropertyChange("FirstName");
            }
        }
        private string _LastName;

        public string LastName
        {
            get { return _LastName; }
            set
            {
                _LastName = value;
                OnPropertyChange("LastName");
            }
        }

        private string _Patronymic;

        public string Patronymic
        {
            get { return _Patronymic; }
            set
            {
                _Patronymic = value;
                OnPropertyChange("Patronymic");
            }
        }

        private string _RegistrationAdress;

        public string RegistrationAdress
        {
            get { return _RegistrationAdress; }
            set
            {
                _RegistrationAdress = value;
                OnPropertyChange("RegistrationAdress");
            }
        }
    }
}
