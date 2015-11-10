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
            vm.AdjustHeight(ActualHeight - 100*2);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            MainWindowVM vm = DataContext as MainWindowVM;
            vm.AdjustHeight(ActualHeight - 100 * 2);
        }
    }

    public class Sample : INotifyPropertyChanged
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

        public string Color { get; set; }
        public double ButtonHeight { get; set; }
        public double TextHeight { get; set; }

        public Sample(string color, double buttonHeight=30, double textHeight=20)
        {
            Color = color;
            ButtonHeight = buttonHeight;
            TextHeight = textHeight;
        }

        public void RaiseEvent()
        {
            RaisePropertyChanged("ButtonHeight");
            RaisePropertyChanged("TextHeight");
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
        private ObservableCollection<Sample> _samples = new ObservableCollection<Sample>();

        public void Initialize()
        {
            Samples.Add(new Sample("Red"));
            Samples.Add(new Sample("Blue"));
            Samples.Add(new Sample("Green"));
            Samples.Add(new Sample("Yellow"));
        }

        public void AdjustHeight(double panelHeight)
        {
            if (Samples.Count == 0)
            {
                return;
            }

            double height = panelHeight / Samples.Count;
            foreach (Sample sample in Samples)
            {
                sample.TextHeight = height / 3;
                sample.ButtonHeight = height - sample.TextHeight;
                sample.RaiseEvent();
            }
        }
    }
}
