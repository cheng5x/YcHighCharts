using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using YcHighChartsMvc.Model.Chart;
using System.Web.Script.Serialization;
using YcHighChartsMvc.Model.Chart.SeriesStlye;

namespace YcHighChartsMvc.Controllers
{
    /// <summary>
    /// name:wujc 2013-02-13
    /// </summary>
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //配置列表
            List<chartConfig> chartConfig_list = new List<Model.Chart.chartConfig>();
            //json转换
            JavaScriptSerializer _ser = new JavaScriptSerializer();

            #region 折线
            //折线系列模拟数据
            List<seriesList> _series_list1 = new List<seriesList>();
            seriesList _series1 = new seriesList()
            {
                name = "测试数据1",
                data = new List<double>(){
                    7,8,9,10,0,1,1,2,3
                 }
            };
            _series_list1.Add(_series1);

            seriesList _series2 = new seriesList()
            {
                name = "测试数据2",
                data = new List<double>(){
                    17,28,9,10,0,11,11,2,13
                 }
            };
            _series_list1.Add(_series2);

            seriesList _series3 = new seriesList()
            {
                name = "测试数据3",
                data = new List<double>(){
                    7,28,9,1,10,1,1,2,3
                 }
            };
            _series_list1.Add(_series3);

            seriesList _series4 = new seriesList()
            {
                name = "测试数据4",
                data = new List<double>(){
                    27,18,29,21,20,11,21,2,13
                 }
            };
            _series_list1.Add(_series4);
            //折线图模拟配置
            chartConfig _chartConfig1 = new chartConfig()
            {
                Type = "spline",
                Title = "2014年信息日志月接触次数分析图",
                Subtitle = "子标题",
                XAxis = new xAxis() { Title = "月份", CategoriesJson = _ser.Serialize(new List<string>() { "一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月" }) },
                YAxis = new yAxis() { Title = "次数" },
                SeriesJson = _ser.Serialize(_series_list1)
            };
            chartConfig_list.Add(_chartConfig1);
            #endregion

            #region 饼图
            //饼图系列模拟数据
            List<seriesCustom> _series_list2 = new List<seriesCustom>();

            seriesCustom _series = new seriesCustom()
            {
                type = "pie",
                name = "测试数据",
                data = "[|测试数据1|,45.0],[|测试数据2|,26.8],[|测试数据3|,8.5],[|测试数据4|,6.2],[|测试数据5|,0.7]"
            };
            _series_list2.Add(_series);

            //饼图系列模拟配置
            string _json = _ser.Serialize(_series_list2);
            chartConfig _chartConfig2 = new chartConfig()
            {
                Title = "2014年信息日志月接触次数分析图",
                Subtitle = "子标题",
                SeriesJson = _json.Replace("\"[", "[[").Replace("]\"", "]]").Replace("|", "'")
            };
            chartConfig_list.Add(_chartConfig2);
            #endregion

            #region 极地蛛网图
            //极地蛛网图模拟数据

            //极地蛛网图模拟配置
            chartConfig _chartConfig3 = new chartConfig()
            {
                Type = "area",
                Title = "2014年信息日志月接触次数分析图",
                XAxis = new xAxis() { Title = "月份", CategoriesJson = _ser.Serialize(new List<string>() { "一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月" }) },
                SeriesJson = _ser.Serialize(_series_list1)
            };
            chartConfig_list.Add(_chartConfig3); 
            #endregion

            #region 柱状图
            //柱状图模拟数据
            ////折线系列模拟数据
            List<seriesList> _series_list3 = new List<seriesList>();
            seriesList _series5 = new seriesList()
            {
                name = "Tokyo",
                data = new List<double>(){
                    49.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4
                 }
            };
            _series_list3.Add(_series5);

            seriesList _series6 = new seriesList()
            {
                name = "New York",
                data = new List<double>(){
                    83.6, 78.8, 98.5, 93.4, 106.0, 84.5, 105.0, 104.3, 91.2, 83.5, 106.6, 92.3
                 }
            };
            _series_list3.Add(_series6);

            seriesList _series7 = new seriesList()
            {
                name = "London",
                data = new List<double>(){
                    48.9, 38.8, 39.3, 41.4, 47.0, 48.3, 59.0, 59.6, 52.4, 65.2, 59.3, 51.2
                 }
            };
            _series_list3.Add(_series7);

            seriesList _series8 = new seriesList()
            {
                name = "Berlin",
                data = new List<double>(){
                   42.4, 33.2, 34.5, 39.7, 52.6, 75.5, 57.4, 60.4, 47.6, 39.1, 46.8, 51.1
                 }
            };
            _series_list3.Add(_series8);
            //柱状图模拟配置
            chartConfig _chartConfig4 = new chartConfig()
            {
                Type = "column",
                Title = "2014年信息日志月接触次数分析图",
                Subtitle = "子标题",
                XAxis = new xAxis() { Title = "月份", CategoriesJson = _ser.Serialize(new List<string>() { "一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月" }) },
                YAxis = new yAxis() { Title = "降水 (mm)" },
                SeriesJson = _ser.Serialize(_series_list3)
            };
            chartConfig_list.Add(_chartConfig4);
            #endregion

            #region 双饼图
            ///饼图系列模拟数据
            //饼图系列模拟配置
            string _json2 = _ser.Serialize(_series_list2);
            chartConfig _chartConfig5 = new chartConfig()
            {
                Title = "2014年信息日志月接触次数分析图",
                Subtitle = "子标题",
                SeriesJson = _json2.Replace("\"[", "[[").Replace("]\"", "]]").Replace("|", "'")
            };
            chartConfig_list.Add(_chartConfig5);
            #endregion

            return View(chartConfig_list);
        }

    }
}
