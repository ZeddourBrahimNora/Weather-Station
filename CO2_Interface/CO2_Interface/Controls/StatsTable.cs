using CO2_Interface.Data;
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

namespace CO2_Interface.Controls
{
    public partial class StatsTable : UserControl
    {
        private Queue<int> MyList;

        Series GraphPoints;
        Series maxCriticalPoints;
        Series maxWarningPoints;
        Series minWarningPoints;
        Series minCriticalPoints;

        Title GraphTitle;
        ChartArea Area;
        public StatsTable()
        {
            InitializeComponent();

            GraphBuilder();
        }
        private void Timer_200ms_Tick(object sender, EventArgs e)
        {
            InitID();

            
            if (idMenu.SelectedIndex != -1)
            {


                foreach (Data.FromSensor.Base measureObj in Data.Collections.ObjectList)
                {
                    if (measureObj.ID == (byte)idMenu.SelectedItem)
                    {

                        if (measureObj.ID != 0)
                        {

                            Data.FromSensor.Measure item = (Data.FromSensor.Measure)measureObj;

                            ResetGraph();
                            ChangeList(item);
                        }
                    }
                }
                GraphUpdate();
            }
        }

        private void GraphBuilder()
        {
            MyList = new Queue<int>();
            GraphPoints = new Series("MySerie");
            maxCriticalPoints = new Series("maxCritSeries");
            maxWarningPoints = new Series("maxWarSeries");
            minWarningPoints = new Series("minWarSeries");
            minCriticalPoints = new Series("minCritSeries");

            GraphTitle = new Title("Statistics");
            GraphTitle.ForeColor = Color.White;
            Area = new ChartArea("MyChartArea");

            maxCriticalPoints.ChartType = SeriesChartType.Spline;
            maxCriticalPoints.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(22)))));

            maxWarningPoints.ChartType = SeriesChartType.Spline;
            maxWarningPoints.Color = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));

            minWarningPoints.ChartType = SeriesChartType.Spline;
            minWarningPoints.Color = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));

            minCriticalPoints.ChartType = SeriesChartType.Spline;
            minCriticalPoints.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(22)))));
            //26, 29, 43
            GraphPoints.ChartType = SeriesChartType.Spline;
            GraphPoints.Color = System.Drawing.Color.White;


            

            Area.AxisX.InterlacedColor = System.Drawing.Color.White;
            Area.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            Area.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            Area.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            //Area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            Area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));//46; 51; 73
            Area.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));

            Area.BorderColor = System.Drawing.Color.SteelBlue;
            Area.AxisY.IsStartedFromZero = false;
            Area.AxisY.Minimum = 0;
            Area.AxisY.Maximum = 100;
            Area.AxisX.Minimum = 0;
            Area.BackGradientStyle = GradientStyle.TopBottom;



            Chart.Titles.Add(GraphTitle);
            Chart.ChartAreas.Add(Area);
            Chart.Series.Add(GraphPoints);



            Chart.Series.Add(maxCriticalPoints);
            Chart.Series.Add(maxWarningPoints);
            Chart.Series.Add(minWarningPoints);
            Chart.Series.Add(minCriticalPoints);

            // Chart.Legends.Add("Critic");

            Area.AxisX.Title = "Time";

            Area.AxisX.TitleForeColor = Color.White;
            Area.AxisY.TitleForeColor = Color.White;
            Area.AxisX.LabelStyle.ForeColor = Color.White;
            Area.AxisY.LabelStyle.ForeColor = Color.White;


            Chart.Series[0].BorderWidth = 4;//Grossi l'épaisseur du fil
            for (int i = 1; i < Chart.Series.Count; i++)
            {
                Chart.Series[i].BorderWidth = 8;
            }

        }

        private void GraphUpdate()
        {
            ResetGraph();

            foreach (Data.FromSensor.Base measureObj in Data.Collections.ObjectList)
            {
                if (measureObj.ID == (byte)idMenu.SelectedItem)
                {
                    if (measureObj.ID != 0)
                    {
                        Data.FromSensor.Measure item = (Data.FromSensor.Measure)measureObj;
                        GraphConfigUpdate(item);

                        for (int i = 0; i < MyList.Count; i++)
                        {
                            GraphPoints.Points.AddXY(i, MyList.ElementAt(i));

                            maxCriticalPoints.Points.AddXY(i, item.CriticalMax);
                            maxWarningPoints.Points.AddXY(i, item.WarningMax);
                            minWarningPoints.Points.AddXY(i, item.WarningMin);
                            minCriticalPoints.Points.AddXY(i, item.CriticalMin);
                        }
                    }
                }
            }
        }

        private void ResetGraph()
        {
            GraphPoints.Points.Clear();
            maxCriticalPoints.Points.Clear();
            maxWarningPoints.Points.Clear();
            minWarningPoints.Points.Clear();
            minCriticalPoints.Points.Clear();

        }

        private void GraphConfigUpdate(FromSensor.Measure item)
        {
            int ecart = 10;
            Chart.Titles.Clear();
            Area.AxisY.Maximum = item.HighLimit + ecart;
            Area.AxisY.Minimum = item.LowLimit - ecart;

            String titleText = "";


            if (item.Type == 1)
            {
                titleText = "CO2 Statistics";
                Area.AxisY.Title = "CO2 in PPM";
            }
            else if (item.Type == 2)
            {
                titleText = "Humidity Statistics";
                Area.AxisY.Title = "Humidity in percentage";

            }
            else if (item.Type == 3)
            {
                titleText = "Temperature Statistics";
                Area.AxisY.Title = "Temperature in degrees";
            }
                Title title = new Title(titleText);
                title.ForeColor = Color.White;
                Chart.Titles.Add(title);
          
        }

        internal void InitID()
        {

            foreach (Data.FromSensor.Base item in Data.Collections.ObjectList)
            {
                bool inIdMenu = false;
                foreach (Object asset in idMenu.Items)
                {
                    if (item.ID == (byte)asset && item.ID != 0)
                    {
                        inIdMenu = true;
                        break;
                    }
                }
                if (inIdMenu == false && item.ID != 0)
                {
                    Data.FromSensor.Measure itemMeasure = (Data.FromSensor.Measure)item;

                    if (itemMeasure.ConfigStatus == true)
                    {
                        idMenu.Items.Add(itemMeasure.ID);
                    }
                }
            }
        }

        private void TimeMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Timer_200ms.Interval = 1000;//1s pour supprimer le délai d'attente
        }

        private void ChangeList(FromSensor.Measure item)
        {
            ResetGraph();
            if (rMinutes.Checked)
            {
                MyList = item.saveGraphPointsMinutes;
            }
            else if (rHours.Checked)
            {
                MyList = item.saveGraphPointsHours;
            }
            else
            {
                MyList = item.saveGraphPointsSeconds;
            }

        }

        
    }
}
