using LoadoutDrop.View.UserControls.Page;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoadoutDrop.View.UserControls.Domain
{
    /// <summary>
    /// Interaction logic for AppMenuBar.xaml
    /// </summary>
    public partial class AppMenuBar : UserControl
    {
        public AppMenuBar()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            var modalWindow = new AboutWindow
            {
                Owner = Application.Current.MainWindow
            };
            modalWindow.ShowDialog();
        }
    }
}
