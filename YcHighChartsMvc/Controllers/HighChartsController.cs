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
    public class HighChartsController : Controller
    {
        //
        // GET: /HighCharts/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HighCharts()
        {
            //配置列表
            List<chartConfig> chartConfig_list = new List<Model.Chart.chartConfig>();
            //json转换
            JavaScriptSerializer _ser = new JavaScriptSerializer();

            //模拟数据
            List<seriesCustom> _series_list = new List<seriesCustom>();

            //seriesCustom _series = new seriesCustom()
            //{
            //    name = "Browser share",
            //    data = "[Firefox,45.0],[IE,26.8],{name: Chr,y: 12.8,sliced: true,selected: true},[Safari,8.5],[Opera,6.2],[Others,0.7]"
            //};
            //_series_list.Add(_series);

            seriesCustom _series = new seriesCustom()
            {
                name = "测试数据",
                data = "[|测试数据1|,45.0],[|测试数据2|,26.8],[|测试数据3|,8.5],[|测试数据4|,6.2],[|测试数据5|,0.7]"
            };
            _series_list.Add(_series);

            string _json = _ser.Serialize(_series_list);
            //模拟配置
            chartConfig _chartConfig1 = new chartConfig()
            {
                Title = "2014年信息日志月接触次数分析图",
                SeriesJson = _json.Replace("\"[", "[[").Replace("]\"", "]]").Replace("|", "'")
            };
            chartConfig_list.Add(_chartConfig1);

            return View(chartConfig_list);
        }
        
    }
}
