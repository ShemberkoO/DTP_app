using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTP_app.ViewModels
{
    public class AccidentViewModel: ViewModelBase
    {
        private int _Id;
        public int Id { 
            get { return _Id; } 
            set { 

                _Id = value;
                OnPropertyChange("Id");
            } 
        }
        private DateTime _Date;
        public DateTime Date { 
            get { return _Date; } 
            set { 
                _Date = value;
                OnPropertyChange("Date");
            }
        }
        private string _Location;
        public string Location { 
            get { return _Location; } 
            set{
                _Location = value;
                OnPropertyChange("Location");
            }
        }
        private string _Description;
        public string Description { 
            get { return _Description;  }
            set {
                _Description = value;
                OnPropertyChange("Description");
            }
        }

    }
}
