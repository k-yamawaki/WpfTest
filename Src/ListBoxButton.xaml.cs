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

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for ListBoxButton.xaml
    /// </summary>
    public partial class ListBoxButton : UserControl
    {
        public ListBoxButton()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ListBoxButtonVM vm = DataContext as ListBoxButtonVM;
            vm.Initialize();
        }

        private void xListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listbox = sender as ListBox;

            // 選択アイテムを調べる
            //ListBoxButtonItem item = e.AddedItems[0] as ListBoxButtonItem;
            //MessageBox.Show(item.Name);

            // 選択解除
            //listbox.UnselectAll();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
        }

        private void xListBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ListBox listbox = sender as ListBox;
        }

        private void xListBox_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            ListBox listbox = sender as ListBox;
        }
    }
}
