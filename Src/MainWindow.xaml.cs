using System.Collections.ObjectModel;
using System.Windows;

namespace WpfTest
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

    /// <summary>
    /// MainWindow ViewModel
    /// </summary>
    public class MainWindowVM : ViewModelBase
    {
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
