using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YcHighChartsMvc.Model.Chart.Base;

namespace YcHighChartsMvc.Model.Chart.SeriesStlye
{
    public class seriesCustom : Series
    {
        private string _data;
        /// <summary>
        /// 数据
        /// </summary>
        public string data
        {
            get { return _data; }
            set { _data = value; }
        }
    }
}
