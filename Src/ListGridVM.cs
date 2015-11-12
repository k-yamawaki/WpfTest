using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfTest
{
    public class ListGridVM : ViewModelBase
    {
        public ObservableCollection<GridItem> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                RaisePropertyChanged("Items");
            }
        }
        private ObservableCollection<GridItem> _items = new ObservableCollection<GridItem>();

        public void Initalize()
        {
            _items.Add(new GridItem(0, 0, "Red"));
            _items.Add(new GridItem(1, 0, "Yellow"));
            _items.Add(new GridItem(0, 1, "Blue"));
            _items.Add(new GridItem(1, 1, "Green"));
        }
    }

    public class GridItem
    {
        public int ColumnIndex { get; set; }
        public int RowIndex { get; set; }
        public string Background { get; set; }

        public GridItem(int column, int row, string background)
        {
            ColumnIndex = column;
            RowIndex = row;
            Background = background;
        }
    }
}
