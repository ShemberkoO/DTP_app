using DTP_app.ViewModels;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DTP_app.Views
{
    public partial class VictimsUserControl : UserControl
    {
        public ICommand ChangeStatusCommand { get; set; }

        public VictimsUserControl()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var selected = (VictimViewModel)Peoples.SelectedItem;

            if (selected != null)
            {
                selected.Status = (VictimStatus)(((int)selected.Status + 1) % Enum.GetValues(typeof(VictimStatus)).Length);
                Peoples.Items.Refresh();
            }
        }

    }
}
