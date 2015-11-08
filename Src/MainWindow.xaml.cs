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
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ListControlTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindowVM vm = DataContext as MainWindowVM;
            vm.Initialize();
        }
    }

    public class MainWindowVM : INotifyPropertyChanged
    {
        // INotifyPropertyChanged.PropertyChanged の実装
        public event PropertyChangedEventHandler PropertyChanged;

        // INotifyPropertyChanged.PropertyChangedイベントを発生させる。
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
            {
                return;
            }
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<string> Samples
        {
            get { return _samples; }
            set
            {
                _samples = value;
                RaisePropertyChanged("Samples");
            }
        }
        private ObservableCollection<string> _samples = new ObservableCollection<string>();

        public void Initialize()
        {
            Samples.Add("Red");
            Samples.Add("Blue");
            Samples.Add("Green");
            Samples.Add("Yellow");
        }
    }
}
