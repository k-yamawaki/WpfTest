using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTest
{
    /// <summary>
    /// プロパティグリッドでプロパティを設定するクラス
    /// </summary>
    public class PropertyGridSample
    {
        /// <summary>
        /// コレクションエディタで設定するプロパティ
        /// </summary>
        public List<Sample> Samples { get; set; }
    }

    /// <summary>
    /// サンプル
    /// </summary>
    public class Sample
    {
        public string Content { get; set; }

        /// <summary>
        /// メンバーに表示する文字列を返す
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (string.IsNullOrEmpty(Content))
            {
                return "Sample";
            }
            return Content;
        }
    }
}
