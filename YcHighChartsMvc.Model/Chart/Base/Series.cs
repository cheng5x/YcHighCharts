using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YcHighChartsMvc.Model.Chart.Base
{
    /// <summary>
    /// 系列数据
    /// </summary>
    public class Series
    {
        private int _index;
        /// <summary>
        /// 索引
        /// </summary>
        public int index
        {
            get { return _index; }
            set { _index = value; }
        }
        private int _legendIndex;
        /// <summary>
        /// 饼图索引
        /// </summary>
        public int legendIndex
        {
            get { return _legendIndex; }
            set { _legendIndex = value; }
        }
        private string _name;
        /// <summary>
        /// 名称
        /// </summary>
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _stack;
        /// <summary>
        /// 叠加标识
        /// </summary>
        public int stack
        {
            get { return _stack; }
            set { _stack = value; }
        }
        private string _type;
        /// <summary>
        /// 图表类型
        /// </summary>
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
