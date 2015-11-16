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
            vm.AdjustHeight(ActualHeight);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            MainWindowVM vm = DataContext as MainWindowVM;
            vm.AdjustHeight(ActualHeight);
        }

        /// <summary>
        /// カスタマイズイベントを処理する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListGrid_Customized(object sender, RoutedEventArgs e)
        {
            CustomizedRoutedEventArgs ea = e as CustomizedRoutedEventArgs;
            MessageBox.Show(ea.Tag.ToString());
        }
    }

    /// <summary>
    /// MainWindow ViewModel
    /// </summary>
    public class MainWindowVM : ViewModelBase
    {
        public ObservableCollection<Sample> Samples
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
                sample.Height = height;
            }
        }
    }

    /// <summary>
    /// Item of ItemsCollection
    /// </summary>
    public class Sample : ViewModelBase
    {
        public string Color { get; set; }
        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                RaisePropertyChanged("Height");
            }
        }
        private double height;

        public Sample(string color, double height = 50)
        {
            Color = color;
            Height = height;
        }
    }

}
