using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTP_app.ViewModels
{
    public class VictimViewModel : ViewModelBase
    {
        private string _PassportId;
        private  VictimStatus _Status = VictimStatus.Uninjured;
        private int _AccidentId;
        public string PassportId { 
            get { return _PassportId; }
            set {
                _PassportId = value;
                OnPropertyChange("PassportId");
            }
        }

        public VictimStatus Status
        {
            get { return _Status; }
            set
            {
                _Status = value;
                OnPropertyChange("Status");
            }
        }

        public int AccidentId
        {
            get { return _AccidentId; }
            set
            {
                _AccidentId = value;
                OnPropertyChange("AccidentId");
            }
        }
    }
}

public enum VictimStatus
{
    Uninjured,
    LightlyInjured,
    SeriouslyInjured,
    Deceased
}
