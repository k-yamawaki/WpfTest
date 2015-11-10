using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTest
{
    public class ListCanvasVM : ViewModelBase
    {
        /// <summary>
        /// キャンバス高さ
        /// </summary>
        public double CanvasHeight
        {
            get { return _canvasHeight; }
            set
            {
                if (_canvasHeight != value)
                {
                    _canvasHeight = value;
                    RaisePropertyChanged("CanvasHeight");
                }
            }
        }
        private double _canvasHeight;
    }
}
