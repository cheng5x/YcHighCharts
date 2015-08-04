using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YcHighChartsMvc.Model.Chart.Base;

namespace YcHighChartsMvc.Model.Chart.SeriesStlye
{
    public class seriesList : Series
    {
        private List<double> _data;
        /// <summary>
        /// 数据
        /// </summary>
        public List<double> data
        {
            get { return _data; }
            set { _data = value; }
        }
    }
}
