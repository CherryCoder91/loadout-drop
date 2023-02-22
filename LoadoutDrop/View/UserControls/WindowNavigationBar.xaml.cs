using LoadoutDrop.Windows;
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

namespace LoadoutDrop.View.UserControls
{
    /// <summary>
    /// Interaction logic for WindowNavigationBar.xaml
    /// </summary>
    public partial class WindowNavigationBar : UserControl
    {
        public WindowNavigationBar()
        {
            InitializeComponent();
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            var modalWindow = new AboutWindow
            {
                Owner = App.Current.MainWindow

            };
            modalWindow.ShowDialog();
        }
    }
}
