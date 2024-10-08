using DTP_app;
using DTP_app.Models;
using DTP_app.ViewModels;
using DTP_app.Views;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

public class DataViewModel : ViewModelBase
{

    public DataViewModel()
    {
        SetControlVisibility = new Command(ControlVisibility);
        ChangeVictimStatus = new Command(ChangeStatus);
    }

    private string _visibleControle = "Victims";

    public string visibleControle
    {
        get { return _visibleControle; }
        set
        {
            _visibleControle = value;
            OnPropertyChange("visibleControle");
        }
    }

    private VictimViewModel _SelectedVictim;
    public VictimViewModel SelectedVictim
    {
        get { return _SelectedVictim; }
        set
        {
            _SelectedVictim = value;
            OnPropertyChange("SelectedVictim");
        }
    }

    private PersonViewModel _SelectedPerson;
    public PersonViewModel SelectedPerson
    {
        get { return _SelectedPerson; }
        set
        {
            _SelectedPerson = value;
            OnPropertyChange("selectedPersonAccidents");
            OnPropertyChange("SelectedPerson");
        }
    }


    public Command ChangeVictimStatus { get; set; }

    public void ChangeStatus(object args)
    {
        

        if (SelectedVictim != null)
        {
            SelectedVictim.Status = (VictimStatus)(((int)SelectedVictim.Status + 1) % Enum.GetValues(typeof(VictimStatus)).Length);
        }
    }
    public Command SetControlVisibility { get; set; }

    public void ControlVisibility(object args)
    {
        visibleControle = args.ToString();
    }


    public ObservableCollection<AccidentViewModel> selectedPersonAccidents
    {
        get
        {
            ObservableCollection<AccidentViewModel> _selectedPersonAccidents = new ObservableCollection<AccidentViewModel>() ;
            if (SelectedPerson != null)
            {
                _selectedPersonAccidents = new ObservableCollection<AccidentViewModel>(
                    Accidents.Where(accident =>
                        Victims.Any(victim =>
                            victim.PassportId == SelectedPerson.PassportId &&
                            victim.AccidentId == accident.Id)
                    )
                );
            }
            return _selectedPersonAccidents;
        }
    }
    private ObservableCollection<PersonViewModel> _People;
    public ObservableCollection<PersonViewModel> People
    {
        get { return _People; }
        set
        {
            _People = value;
            OnPropertyChange("People");
        }
    }

    private ObservableCollection<VictimViewModel> _Victims;
    public ObservableCollection<VictimViewModel> Victims
    {
        get { return _Victims; }
        set
        {
            _Victims = value;
            OnPropertyChange("Victims");
        }
    }

    private ObservableCollection<TransportViewModel> _Transports;
    public ObservableCollection<TransportViewModel> Transports
    {
        get { return _Transports; }
        set
        {
            _Transports = value;
            OnPropertyChange("Transports");
        }
    }

    private ObservableCollection<AccidentViewModel> _Accidents;
    public ObservableCollection<AccidentViewModel> Accidents
    {
        get { return _Accidents; }
        set
        {
            _Accidents = value;
            OnPropertyChange("Accidents");
        }
    }
}
