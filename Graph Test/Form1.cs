using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Graph_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Point> squares = new List<Point>();
            for (int i = 0; i < 11; i++)
            {
                squares.Add(new Point(i, i * i));
            }
            drawGraph(squares, "x", "x squared");
        }

        void drawGraph(List<Point> points, string XAxisTitle="x", string YAxisTitle="y")
        {
            chart1.ChartAreas[0].AxisX.Title = "time / s";
            chart1.ChartAreas[0].AxisY.Title = "distance / m";
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            Series series1 = new Series
            {
                Name = "Line",
                Color = Color.Blue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,
                BorderWidth = 2
            };
            Series series2 = new Series
            {
                Name = "Points",
                Color = Color.Red,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Point,
                BorderWidth = 2
            };
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            for (int i = 0; 1 < 11; i++)
            {
                series1.Points.AddXY(i, i * i);
                series2.Points.AddXY(i, i * i);
            }
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
