using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AutoMapper;
using DTP_app;
using DTP_app.Models;
using DTP_app.ViewModels;

namespace DtpApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private DataModel _data;
        private DataViewModel _viewModel;
        private IMapper _mapper;
        public App()
        {
            InitializeAutoMapper();
            _data = DataModel.Load();
            _viewModel = _mapper.Map<DataViewModel>(_data);

            var window = new MainWindow() { DataContext = _viewModel };
            window.InitializeComponent();
            window.Show();

        }

        private void InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataModel, DataViewModel>();
                cfg.CreateMap<DataViewModel, DataModel>();

                cfg.CreateMap<Accident, AccidentViewModel>();
                cfg.CreateMap<AccidentViewModel, Accident>();

                cfg.CreateMap<Victim, VictimViewModel>();
                cfg.CreateMap<VictimViewModel, Victim>();

                cfg.CreateMap<Person, PersonViewModel>();
                cfg.CreateMap<PersonViewModel, Person>();

                cfg.CreateMap<Transport, TransportViewModel>();
                cfg.CreateMap<TransportViewModel, Transport>();
            });

            _mapper = config.CreateMapper();
        }

        public IMapper GetMapper()
        {
            return _mapper;
        }
        protected override void OnExit(ExitEventArgs e)
        {

            _data = _mapper.Map<DataModel>(_viewModel);
            _data.Save();
            base.OnExit(e);
        }
    }
}
