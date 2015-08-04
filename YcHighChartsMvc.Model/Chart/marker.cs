using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YcHighChartsMvc.Model.Chart
{
    /// <summary>
    /// 标记
    /// </summary>
    public class marker
    {
        private string _symbol;
        /// <summary>
        /// 图标(ex: "url(/demo/img/sun.png)")
        /// </summary>
        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }
    }
}
