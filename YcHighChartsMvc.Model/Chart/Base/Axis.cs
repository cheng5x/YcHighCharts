using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YcHighChartsMvc.Model.Chart.Base
{
    /// <summary>
    /// 轴 父类
    /// </summary>
    public abstract class Axis
    {
        private string _categoriesJson;
        /// <summary>
        /// 数据
        /// </summary>
        public string CategoriesJson
        {
            get { return _categoriesJson; }
            set { _categoriesJson = value; }
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
    }
}
