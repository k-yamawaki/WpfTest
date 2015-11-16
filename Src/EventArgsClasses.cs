using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfTest
{
    /// <summary>
    /// カスタムルートイベント
    /// </summary>
    public class CustomizedRoutedEventArgs : RoutedEventArgs
    {
        /// <summary>
        /// タグ
        /// </summary>
        public object Tag { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="routedEvent"></param>
        /// <param name="source"></param>
        /// <param name="tag"></param>
        public CustomizedRoutedEventArgs(RoutedEvent routedEvent, object source, object tag)
        {
            RoutedEvent = routedEvent;
            Source = source;
            Tag = tag;
        }
    }
}
