using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using YcHighChartsMvc.Model.Chart;
using System.Web.Script.Serialization;
using YcHighChartsMvc.Model.Chart.SeriesStlye;

namespace YcHighCharts
{
    /// <summary>
    /// name:wujc 2014-07-08
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {
        protected string chartJs = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            //配置列表
            List<chartConfig> chartConfig_list = new List<chartConfig>();
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

            if (chartConfig_list != null)
            {
                //折线图
                this.chartJs += "<script>";
                this.chartJs += "$(function () {$('#canvasDiv').highcharts({chart: {type: '" + chartConfig_list[0].Type + "'},";
                this.chartJs += "title: {text:  '" + chartConfig_list[0].Title + "'},";
                this.chartJs += "subtitle: {text: '" + chartConfig_list[0].Subtitle + "'},";
                this.chartJs += "xAxis: {categories: " + chartConfig_list[0].XAxis.CategoriesJson + "},";
                this.chartJs += "yAxis: {title: {text: '" + chartConfig_list[0].YAxis.Title + "'},";
                this.chartJs += "labels: {formatter: function () {return this.value + '次'}}},";
                this.chartJs += "tooltip: {crosshairs: true,shared: true},";
                this.chartJs += "plotOptions: {spline: {marker: {radius: 4,lineColor: '#666666',lineWidth: 1}}},";
                this.chartJs += "series: " + chartConfig_list[0].SeriesJson + "});";
                //饼形图
                this.chartJs += "$('#canvasDiv1').highcharts({chart: {plotBackgroundColor: null,plotBorderWidth: null,plotShadow: false},";
                this.chartJs += "title: {text: '" + chartConfig_list[1].Title + "'},";
                this.chartJs += "subtitle: {text: '" + chartConfig_list[1].Subtitle + "'},";
                this.chartJs += "tooltip: {pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'},";
                this.chartJs += "plotOptions: {pie: {allowPointSelect: true,cursor: 'pointer',dataLabels: {enabled: true,color: '#000000',connectorColor: '#000000',format: '<b>{point.name}</b>: {point.percentage:.1f} %'},showInLegend: true},},";
                this.chartJs += "series: " + chartConfig_list[1].SeriesJson + " });";
                //极地蛛网图
                this.chartJs += "$('#canvasDiv2').highcharts({chart: {polar: true,type: '" + chartConfig_list[2].Type + "'},";
                this.chartJs += "title: {text: '" + chartConfig_list[2].Title + "'},";
                this.chartJs += "pane: {size: '80%'},";
                this.chartJs += "xAxis: {categories: " + chartConfig_list[2].XAxis.CategoriesJson + ",tickmarkPlacement: 'on',lineWidth: 0},";
                this.chartJs += "yAxis: {gridLineInterpolation: 'polygon',lineWidth: 0,min: 0},";
                this.chartJs += "tooltip: {shared: true,pointFormat: '<span style=\"color:{series.color}\">{series.name}: <b>${point.y:,.0f}</b><br>'},";
                this.chartJs += "series: " + chartConfig_list[2].SeriesJson + " });";
                //柱状图
                this.chartJs += "$('#canvasDiv3').highcharts({chart: {type:'" + chartConfig_list[3].Type + "'},";
                this.chartJs += "title: {text:'" + chartConfig_list[3].Title + "'},";
                this.chartJs += " subtitle: {text: '" + chartConfig_list[3].Title + "'},";
                this.chartJs += "xAxis: {categories:" + chartConfig_list[3].XAxis.CategoriesJson + "},";
                this.chartJs += "yAxis: { min: 0,title: { text: '" + chartConfig_list[3].YAxis.Title + "' } },";
                this.chartJs += "tooltip: { shared: true, useHTML: true},";
                this.chartJs += "plotOptions: {column: { pointPadding: 0.2, borderWidth: 0  } },";
                this.chartJs += "series: " + chartConfig_list[3].SeriesJson + "});";
                //双饼图
                this.chartJs += "$('#canvasDiv4').highcharts({chart: {type: '" + chartConfig_list[4].Type + "',options3d: {enabled: true,alpha: 45}},";
                this.chartJs += "title: {text: '" + chartConfig_list[4].Title + "'},";
                this.chartJs += "subtitle: {text: '" + chartConfig_list[4].Subtitle + "'},";
                this.chartJs += "plotOptions: {pie: {innerSize: 100,depth: 45}},";
                this.chartJs += "series: " + chartConfig_list[4].SeriesJson + "});";
                //条形图
                this.chartJs += "$('#canvasDiv5').highcharts({chart: {type: 'bar'},";
                this.chartJs += "title:{text: '" + chartConfig_list[0].Title + "'},";
                this.chartJs += "subtitle: {text: '" + chartConfig_list[0].Subtitle + "'},";
                this.chartJs += "xAxis:{categories: " + chartConfig_list[0].XAxis.CategoriesJson + ",title:{text: null}},";
                this.chartJs += "yAxis: {title: {text: '" + chartConfig_list[0].YAxis.Title + "'},labels:{overflow: 'justify'}},";
                this.chartJs += "plotOptions: {bar: {dataLabels: {enabled: true}}},";
                this.chartJs += "legend: {layout: 'vertical',align: 'right',verticalAlign: 'top',x: -40, y: 100,floating: true,borderWidth: 1,backgroundColor: '#FFFFFF',shadow: true},credits: {enabled: false},";
                this.chartJs += "series: " + chartConfig_list[0].SeriesJson + "});";

                this.chartJs += "});</script>";
            }
        }
    }
}