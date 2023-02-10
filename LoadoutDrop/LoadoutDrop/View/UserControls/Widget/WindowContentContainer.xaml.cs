using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace LoadoutDrop.View.UserControls.Widget
{
    public partial class WindowContentContainer : UserControl
    {
        public static readonly DependencyProperty MyContentProperty = DependencyProperty.Register("MyContent", typeof(object), typeof(WindowContentContainer));
        public static readonly DependencyProperty TypeProperty = DependencyProperty.Register("Type", typeof(string), typeof(WindowContentContainer));

        //public event PropertyChangedEventHandler PropertyChanged;

        public object MyContent
        {
            get { return GetValue(MyContentProperty); }
            set { SetValue(MyContentProperty, value);
                //OnPropertyChanged();
            }
        }
        public string Type
        {
            get { return (string)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value);
                //OnPropertyChanged();
            }
        }

        public WindowContentContainer()
        {
            DataContext = this;
            InitializeComponent();
        }

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        //protected void OnPropertyChanged([CallerMemberName] string name = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}

    }
}
