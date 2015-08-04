using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YcHighChartsMvc.Model.Chart
{
    /// <summary>
    /// 图表配置
    /// </summary>
    public class chartConfig
    {
        private string type;
        /// <summary>
        /// 样式
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string _title;
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _subtitle;
        /// <summary>
        /// 副标题
        /// </summary>
        public string Subtitle
        {
            get { return _subtitle; }
            set { _subtitle = value; }
        }

        private xAxis _xAxis;
        /// <summary>
        /// X轴
        /// </summary>
        public xAxis XAxis
        {
            get { return _xAxis; }
            set { _xAxis = value; }
        }

        private yAxis _yAxis;
        /// <summary>
        /// Y轴
        /// </summary>
        public yAxis YAxis
        {
            get { return _yAxis; }
            set { _yAxis = value; }
        }

        private string _seriesJson;
        /// <summary>
        /// 图系列数据
        /// </summary>
        public string SeriesJson
        {
            get { return _seriesJson; }
            set { _seriesJson = value; }
        }
    }
}
