using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DTP_app.Views
{
    /// <summary>
    /// Interaction logic for PersonUserControl.xaml
    /// </summary>
    public partial class PersonUserControl : UserControl
    {
        public PersonUserControl()
        {
            InitializeComponent();
        }

        private void ContextMenu_Opened(object sender, RoutedEventArgs e)
        {
            var contextMenu = sender as ContextMenu;
            var border = (contextMenu.Items[1] as Border); // Беремо другий елемент, який є Border

            if (border != null)
            {
                var storyboard = (Storyboard)FindResource("ShowDataGridStoryboard");
                storyboard.Begin();
            }
        }
    }
}
