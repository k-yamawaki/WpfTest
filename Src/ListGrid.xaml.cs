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
    /// Interaction logic for ListGrid.xaml
    /// </summary>
    public partial class ListGrid : UserControl
    {
        /// <summary>
        /// カスタマイズルーテッドイベントデリゲート
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void CustomizedRoutedEventHander(object sender, CustomizedRoutedEventArgs e);

        /// <summary>
        /// カスタマイズルーテッドイベント
        /// </summary>
        public static readonly RoutedEvent CustomizedEvent = EventManager.RegisterRoutedEvent(
            "Customized"
            , RoutingStrategy.Bubble
            , typeof(RoutedEventHandler)
            , typeof(ListGrid)
            );

        public event RoutedEventHandler Customized
        {
            add { AddHandler(CustomizedEvent, value); }
            remove { RemoveHandler(CustomizedEvent, value); }
        }

        public ListGrid()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ListGridVM vm = DataContext as ListGridVM;
            vm.Initalize();
        }

        /// <summary>
        /// キャンバスマウスダウン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Canvas ctrl = sender as Canvas;
            GridItem vm = ctrl.DataContext as GridItem;
            CustomizedRoutedEventArgs ea = new CustomizedRoutedEventArgs(CustomizedEvent, this, vm.Background);
            RaiseEvent(ea);
        }
    }
}
