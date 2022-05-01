using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoslab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CoordinateGraphicsFunc(double x, double ampl1, double freq1, double ampl2, double freq2)
        {
            return ampl1 * Math.Sin(2.0 * Math.PI * freq1 * x) + ampl2 * Math.Sin(2.0 * Math.PI * freq2 * x);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxA1.Text != "" && textBoxA2.Text != "" && textBoxEndX.Text != "" && textBoxStartX.Text != "" && textBoxEndY.Text != "" && textBoxStartY.Text != "")
            {
                
                if (chart1.Series.Count != 0)
                {
                    chart1.Series[0].Points.Clear();
                }
                else
                {
                    chart1.Series.Add("Series1");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }

                double startOfSegmentX = -5, endOfSegmentX = 7, startOfSegmentY = -5, endOfSegmentY = 5, sizeOfSegmentX, step,
                amplitude1, amplitude2, frequency1, frequency2; 
                int t = 0;

                List<List<double>> masCoordinates = new List<List<double>>();

                amplitude1 = Convert.ToDouble(textBoxA1.Text);
                amplitude2 = Convert.ToDouble(textBoxA2.Text);
                frequency1 = Convert.ToDouble(textBoxF1.Text);
                frequency2 = Convert.ToDouble(textBoxF2.Text);

                startOfSegmentX = Convert.ToDouble(textBoxStartX.Text);
                endOfSegmentX = Convert.ToDouble(textBoxEndX.Text);
                startOfSegmentY = Convert.ToDouble(textBoxStartY.Text);
                endOfSegmentY = Convert.ToDouble(textBoxEndY.Text);

                sizeOfSegmentX = endOfSegmentX - startOfSegmentX;
                step = sizeOfSegmentX / 100.0;


                // построение массива точек
                for (double x = startOfSegmentX; x < endOfSegmentX; x += step)
                {
                    masCoordinates.Add(new List<double>());
                    masCoordinates[t].Add(x);
                    masCoordinates[t].Add(CoordinateGraphicsFunc(x, amplitude1, frequency1, amplitude2, frequency2));
                    t++;
                }

                chart1.ChartAreas[0].AxisX.Minimum = startOfSegmentX;
                chart1.ChartAreas[0].AxisX.Maximum = endOfSegmentX;
                chart1.ChartAreas[0].AxisY.Minimum = startOfSegmentY;
                chart1.ChartAreas[0].AxisY.Maximum = endOfSegmentY;

                foreach (List<double> coordinate in masCoordinates)
                {
                    chart1.Series[0].Points.AddXY(coordinate[0], coordinate[1]);
                }
                chart1.Series[0].Name = amplitude1 + "*sin(2*Pi*" + frequency1 + "*x)*" + amplitude2 + "*sin(2*Pi*" + frequency2 + "+x)";
                chart1.ChartAreas[0].AxisX.Title = "t, сек";
                chart1.ChartAreas[0].AxisY.Title = "Частота, Гц";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }

        private void toolStripMenuItemPlus_Click(object sender, EventArgs e)
        {

            // Условие на текстбоксы
            if (textBoxA1.Text != "" && textBoxA2.Text != "" && textBoxEndX.Text != "" && textBoxStartX.Text != "" && textBoxEndY.Text != "" && textBoxStartY.Text != "")
            {
                double startOfSegmentX, endOfSegmentX, startOfSegmentY, endOfSegmentY, sizeOfSegmentX, step,
                amplitude1, amplitude2, frequency1, frequency2;

                amplitude1 = Convert.ToDouble(textBoxA1.Text);
                amplitude2 = Convert.ToDouble(textBoxA2.Text);
                frequency1 = Convert.ToDouble(textBoxF1.Text);
                frequency2 = Convert.ToDouble(textBoxF2.Text);

                startOfSegmentX = Convert.ToDouble(textBoxStartX.Text);
                endOfSegmentX = Convert.ToDouble(textBoxEndX.Text);
                startOfSegmentY = Convert.ToDouble(textBoxStartY.Text);
                endOfSegmentY = Convert.ToDouble(textBoxEndY.Text);

                startOfSegmentX /= 2;
                endOfSegmentX /= 2;
                startOfSegmentY /= 2;
                endOfSegmentY /= 2;

                textBoxStartX.Text = "" + startOfSegmentX;
                textBoxEndX.Text = ""+endOfSegmentX;
                textBoxStartY.Text = "" + startOfSegmentY;
                textBoxEndY.Text = "" + endOfSegmentY;

                if (chart1.Series.Count != 0)
                {
                    chart1.Series[0].Points.Clear();
                }
                else
                {
                    chart1.Series.Add("Series1");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }


                int t = 0;

                List<List<double>> masCoordinates = new List<List<double>>();
                List<double> row = new List<double>();

                               
                sizeOfSegmentX = endOfSegmentX - startOfSegmentX;
                step = sizeOfSegmentX / 100.0;


                // построение массива точек
                for (double x = startOfSegmentX + startOfSegmentX * 0.1; x < endOfSegmentX; x += step)
                {
                   
                    masCoordinates.Add(new List<double>());
                    masCoordinates[t].Add(x);
                    masCoordinates[t].Add(CoordinateGraphicsFunc(x, amplitude1, frequency1, amplitude2, frequency2));
                    t++;
                }

                chart1.ChartAreas[0].AxisX.Minimum = startOfSegmentX;
                chart1.ChartAreas[0].AxisX.Maximum = endOfSegmentX;
                chart1.ChartAreas[0].AxisY.Minimum = startOfSegmentY;
                chart1.ChartAreas[0].AxisY.Maximum = endOfSegmentY;

                foreach (List<double> coordinate in masCoordinates)
                {
                    chart1.Series[0].Points.AddXY(coordinate[0], coordinate[1]);

                }

                chart1.Series[0].Name = amplitude1 + "*sin(2*Pi*" + frequency1 + "*x)*" + amplitude2 + "*sin(2*Pi*" + frequency2 + "+x)";
                chart1.ChartAreas[0].AxisX.Title = "t, сек";
                chart1.ChartAreas[0].AxisY.Title = "Частота, Гц";
            }
        }

        private void toolStripMenuItemMinus_Click(object sender, EventArgs e)
        {
            // Условие на текстбоксы
            if (textBoxA1.Text != "" && textBoxA2.Text != "" && textBoxEndX.Text != "" && textBoxStartX.Text != "" && textBoxEndY.Text != "" && textBoxStartY.Text != "")
            {
                double startOfSegmentX, endOfSegmentX, startOfSegmentY, endOfSegmentY, sizeOfSegmentX, step,
                amplitude1, amplitude2, frequency1, frequency2;

                amplitude1 = Convert.ToDouble(textBoxA1.Text);
                amplitude2 = Convert.ToDouble(textBoxA2.Text);
                frequency1 = Convert.ToDouble(textBoxF1.Text);
                frequency2 = Convert.ToDouble(textBoxF2.Text);

                startOfSegmentX = Convert.ToDouble(textBoxStartX.Text);
                endOfSegmentX = Convert.ToDouble(textBoxEndX.Text);
                startOfSegmentY = Convert.ToDouble(textBoxStartY.Text);
                endOfSegmentY = Convert.ToDouble(textBoxEndY.Text);

                startOfSegmentX *= 2;
                endOfSegmentX *= 2;
                startOfSegmentY *= 2;
                endOfSegmentY *= 2;

                textBoxStartX.Text = "" + startOfSegmentX;
                textBoxEndX.Text = "" + endOfSegmentX;
                textBoxStartY.Text = "" + startOfSegmentY;
                textBoxEndY.Text = "" + endOfSegmentY;

                if (chart1.Series.Count != 0)
                {
                    chart1.Series[0].Points.Clear();
                }
                else
                {
                    chart1.Series.Add("Series1");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }


                int t = 0;

                List<List<double>> masCoordinates = new List<List<double>>();
                List<double> row = new List<double>();


                sizeOfSegmentX = endOfSegmentX - startOfSegmentX;
                step = sizeOfSegmentX / 100.0;


                // построение массива точек
                for (double x = startOfSegmentX; x < endOfSegmentX; x += step)
                {

                    masCoordinates.Add(new List<double>());
                    masCoordinates[t].Add(x);
                    masCoordinates[t].Add(CoordinateGraphicsFunc(x, amplitude1, frequency1, amplitude2, frequency2));
                    t++;
                }

                chart1.ChartAreas[0].AxisX.Minimum = startOfSegmentX;
                chart1.ChartAreas[0].AxisX.Maximum = endOfSegmentX;
                chart1.ChartAreas[0].AxisY.Minimum = startOfSegmentY;
                chart1.ChartAreas[0].AxisY.Maximum = endOfSegmentY;

                foreach (List<double> coordinate in masCoordinates)
                {
                    chart1.Series[0].Points.AddXY(coordinate[0], coordinate[1]);

                }
                chart1.Series[0].Name = amplitude1 + "*sin(2*Pi*" + frequency1 + "*x)*" + amplitude2 + "*sin(2*Pi*" + frequency2 + "+x)";
                chart1.ChartAreas[0].AxisX.Title = "t, сек";
                chart1.ChartAreas[0].AxisY.Title = "Частота, Гц";
            }
        }

        private void ToolStripMenuItemMainSize_Click(object sender, EventArgs e)
        {
            if (textBoxA1.Text != "" && textBoxA2.Text != "" && textBoxEndX.Text != "" && textBoxStartX.Text != "" && textBoxEndY.Text != "" && textBoxStartY.Text != "")
            {
                if (chart1.Series.Count != 0)
                {
                    chart1.Series[0].Points.Clear();
                }
                else
                {
                    chart1.Series.Add("Series1");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }

                //int widthPictureBox = pictureBox1.Width;
                double startOfSegmentX = -5, endOfSegmentX = 7, startOfSegmentY = -5, endOfSegmentY = 5, sizeOfSegmentX, step,
                amplitude1, amplitude2, frequency1, frequency2;
                int t = 0;

                List<List<double>> masCoordinates = new List<List<double>>();
                List<double> row = new List<double>();

                amplitude1 = Convert.ToDouble(textBoxA1.Text);
                amplitude2 = Convert.ToDouble(textBoxA2.Text);
                frequency1 = Convert.ToDouble(textBoxF1.Text);
                frequency2 = Convert.ToDouble(textBoxF2.Text);

                textBoxStartX.Text = "" + startOfSegmentX;
                textBoxEndX.Text = "" + endOfSegmentX;
                textBoxStartY.Text = "" + startOfSegmentY;
                textBoxEndY.Text = "" + endOfSegmentY;


                sizeOfSegmentX = endOfSegmentX - startOfSegmentX;
                step = sizeOfSegmentX / 100.0;


                // построение массива точек
                for (double x = startOfSegmentX; x < sizeOfSegmentX; x += step)
                {

                    masCoordinates.Add(new List<double>());
                    masCoordinates[t].Add(x);
                    masCoordinates[t].Add(CoordinateGraphicsFunc(x, amplitude1, frequency1, amplitude2, frequency2));
                    t++;
                }

                chart1.ChartAreas[0].AxisX.Minimum = startOfSegmentX;
                chart1.ChartAreas[0].AxisX.Maximum = endOfSegmentX;
                chart1.ChartAreas[0].AxisY.Minimum = startOfSegmentY;
                chart1.ChartAreas[0].AxisY.Maximum = endOfSegmentY;

                foreach (List<double> coordinate in masCoordinates)
                {
                    chart1.Series[0].Points.AddXY(coordinate[0], coordinate[1]);

                }
                chart1.Series[0].Name = amplitude1 + "*sin(2*Pi*" + frequency1 + "*x)*" + amplitude2 + "*sin(2*Pi*" + frequency2 + "+x)";
                chart1.ChartAreas[0].AxisX.Title = "t, сек";
                chart1.ChartAreas[0].AxisY.Title = "Частота, Гц";
            }
        }

        private void toolStripMenuItemLeft_Click(object sender, EventArgs e)
        {
            if (textBoxA1.Text != "" && textBoxA2.Text != "" && textBoxEndX.Text != "" && textBoxStartX.Text != "" && textBoxEndY.Text != "" && textBoxStartY.Text != "")
            {
                double startOfSegmentX, endOfSegmentX, sizeOfSegmentX, step,
                amplitude1, amplitude2, frequency1, frequency2;

                amplitude1 = Convert.ToDouble(textBoxA1.Text);
                amplitude2 = Convert.ToDouble(textBoxA2.Text);
                frequency1 = Convert.ToDouble(textBoxF1.Text);
                frequency2 = Convert.ToDouble(textBoxF2.Text);

                startOfSegmentX = Convert.ToDouble(textBoxStartX.Text);
                endOfSegmentX = Convert.ToDouble(textBoxEndX.Text);

                sizeOfSegmentX = endOfSegmentX - startOfSegmentX;

                startOfSegmentX -= sizeOfSegmentX * 0.1;
                endOfSegmentX -= sizeOfSegmentX * 0.1;


                textBoxStartX.Text = "" + startOfSegmentX;
                textBoxEndX.Text = "" + endOfSegmentX;


                if (chart1.Series.Count != 0)
                {
                    chart1.Series[0].Points.Clear();
                }
                else
                {
                    chart1.Series.Add("Series1");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }


                int t = 0;

                List<List<double>> masCoordinates = new List<List<double>>();
                List<double> row = new List<double>();


                step = sizeOfSegmentX / 100.0;


                // построение массива точек
                for (double x = startOfSegmentX; x < endOfSegmentX; x += step)
                {

                    masCoordinates.Add(new List<double>());
                    masCoordinates[t].Add(x);
                    masCoordinates[t].Add(CoordinateGraphicsFunc(x, amplitude1, frequency1, amplitude2, frequency2));
                    t++;
                }

                chart1.ChartAreas[0].AxisX.Minimum = startOfSegmentX;
                chart1.ChartAreas[0].AxisX.Maximum = endOfSegmentX;

                foreach (List<double> coordinate in masCoordinates)
                {
                    chart1.Series[0].Points.AddXY(coordinate[0], coordinate[1]);

                }
                chart1.Series[0].Name = amplitude1 + "*sin(2*Pi*" + frequency1 + "*x)*" + amplitude2 + "*sin(2*Pi*" + frequency2 + "+x)";
                chart1.ChartAreas[0].AxisX.Title = "t, сек";
                chart1.ChartAreas[0].AxisY.Title = "Частота, Гц";
            }
        }

        private void toolStripMenuItemRight_Click(object sender, EventArgs e)
        {

            if (textBoxA1.Text != "" && textBoxA2.Text != "" && textBoxEndX.Text != "" && textBoxStartX.Text != "" && textBoxEndY.Text != "" && textBoxStartY.Text != "")
            {
                double startOfSegmentX, endOfSegmentX, sizeOfSegmentX, step,
                amplitude1, amplitude2, frequency1, frequency2;

                amplitude1 = Convert.ToDouble(textBoxA1.Text);
                amplitude2 = Convert.ToDouble(textBoxA2.Text);
                frequency1 = Convert.ToDouble(textBoxF1.Text);
                frequency2 = Convert.ToDouble(textBoxF2.Text);

                startOfSegmentX = Convert.ToDouble(textBoxStartX.Text);
                endOfSegmentX = Convert.ToDouble(textBoxEndX.Text);

                sizeOfSegmentX = endOfSegmentX - startOfSegmentX;

                startOfSegmentX += sizeOfSegmentX * 0.1;
                endOfSegmentX += sizeOfSegmentX * 0.1;


                textBoxStartX.Text = "" + startOfSegmentX;
                textBoxEndX.Text = "" + endOfSegmentX;


                if (chart1.Series.Count != 0)
                {
                    chart1.Series[0].Points.Clear();
                }
                else
                {
                    chart1.Series.Add("Series1");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }


                int t = 0;

                List<List<double>> masCoordinates = new List<List<double>>();
                List<double> row = new List<double>();


                
                step = sizeOfSegmentX / 100.0;


                // построение массива точек
                for (double x = startOfSegmentX; x < endOfSegmentX; x += step)
                {

                    masCoordinates.Add(new List<double>());
                    masCoordinates[t].Add(x);
                    masCoordinates[t].Add(CoordinateGraphicsFunc(x, amplitude1, frequency1, amplitude2, frequency2));
                    t++;
                }

                chart1.ChartAreas[0].AxisX.Minimum = startOfSegmentX;
                chart1.ChartAreas[0].AxisX.Maximum = endOfSegmentX;

                foreach (List<double> coordinate in masCoordinates)
                {
                    chart1.Series[0].Points.AddXY(coordinate[0], coordinate[1]);

                }
                chart1.Series[0].Name = amplitude1 + "*sin(2*Pi*" + frequency1 + "*x)*" + amplitude2 + "*sin(2*Pi*" + frequency2 + "+x)";
                chart1.ChartAreas[0].AxisX.Title = "t, сек";
                chart1.ChartAreas[0].AxisY.Title = "Частота, Гц";
            }

        }

        private void ToolStripMenuItemUp_Click(object sender, EventArgs e)
        {
            if (textBoxA1.Text != "" && textBoxA2.Text != "" && textBoxEndX.Text != "" && textBoxStartX.Text != "" && textBoxEndY.Text != "" && textBoxStartY.Text != "")
            {
                double startOfSegmentX, endOfSegmentX, startOfSegmentY, endOfSegmentY, sizeOfSegmentX, sizeOfSegmentY, step,
                amplitude1, amplitude2, frequency1, frequency2;

                amplitude1 = Convert.ToDouble(textBoxA1.Text);
                amplitude2 = Convert.ToDouble(textBoxA2.Text);
                frequency1 = Convert.ToDouble(textBoxF1.Text);
                frequency2 = Convert.ToDouble(textBoxF2.Text);

                startOfSegmentX = Convert.ToDouble(textBoxStartX.Text);
                endOfSegmentX = Convert.ToDouble(textBoxEndX.Text);
                startOfSegmentY = Convert.ToDouble(textBoxStartY.Text);
                endOfSegmentY = Convert.ToDouble(textBoxEndY.Text);

                sizeOfSegmentX = endOfSegmentX - startOfSegmentX;
                sizeOfSegmentY = endOfSegmentY - startOfSegmentY;
                
                startOfSegmentY += sizeOfSegmentY * 0.1;
                endOfSegmentY += sizeOfSegmentY * 0.1;


                textBoxStartY.Text = "" + startOfSegmentY;
                textBoxEndY.Text = "" + endOfSegmentY;

                if (chart1.Series.Count != 0)
                {
                    chart1.Series[0].Points.Clear();
                }
                else
                {
                    chart1.Series.Add("Series1");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }


                int t = 0;

                List<List<double>> masCoordinates = new List<List<double>>();
                List<double> row = new List<double>();


                step = sizeOfSegmentX / 100.0;


                // построение массива точек
                for (double x = startOfSegmentX; x < endOfSegmentX; x += step)
                {

                    masCoordinates.Add(new List<double>());
                    masCoordinates[t].Add(x);
                    masCoordinates[t].Add(CoordinateGraphicsFunc(x, amplitude1, frequency1, amplitude2, frequency2));
                    t++;
                }

                chart1.ChartAreas[0].AxisX.Minimum = startOfSegmentX;
                chart1.ChartAreas[0].AxisX.Maximum = endOfSegmentX;
                chart1.ChartAreas[0].AxisY.Minimum = startOfSegmentY;
                chart1.ChartAreas[0].AxisY.Maximum = endOfSegmentY;

                foreach (List<double> coordinate in masCoordinates)
                {
                    chart1.Series[0].Points.AddXY(coordinate[0], coordinate[1]);

                }
                chart1.Series[0].Name = amplitude1 + "*sin(2*Pi*" + frequency1 + "*x)*" + amplitude2 + "*sin(2*Pi*" + frequency2 + "+x)";
                chart1.ChartAreas[0].AxisX.Title = "t, сек";
                chart1.ChartAreas[0].AxisY.Title = "Частота, Гц";
            }
        }

        private void ToolStripMenuItemUnder_Click(object sender, EventArgs e)
        {
            if (textBoxA1.Text != "" && textBoxA2.Text != "" && textBoxEndX.Text != "" && textBoxStartX.Text != "" && textBoxEndY.Text != "" && textBoxStartY.Text != "")
            {
                double startOfSegmentX, endOfSegmentX, startOfSegmentY, endOfSegmentY, sizeOfSegmentX, sizeOfSegmentY, step,
                amplitude1, amplitude2, frequency1, frequency2;

                amplitude1 = Convert.ToDouble(textBoxA1.Text);
                amplitude2 = Convert.ToDouble(textBoxA2.Text);
                frequency1 = Convert.ToDouble(textBoxF1.Text);
                frequency2 = Convert.ToDouble(textBoxF2.Text);

                startOfSegmentX = Convert.ToDouble(textBoxStartX.Text);
                endOfSegmentX = Convert.ToDouble(textBoxEndX.Text);
                startOfSegmentY = Convert.ToDouble(textBoxStartY.Text);
                endOfSegmentY = Convert.ToDouble(textBoxEndY.Text);

                sizeOfSegmentX = endOfSegmentX - startOfSegmentX;
                sizeOfSegmentY = endOfSegmentY - startOfSegmentY;

                startOfSegmentY -= sizeOfSegmentY * 0.1;
                endOfSegmentY -= sizeOfSegmentY * 0.1;


                textBoxStartY.Text = "" + startOfSegmentY;
                textBoxEndY.Text = "" + endOfSegmentY;

                if (chart1.Series.Count != 0)
                {
                    chart1.Series[0].Points.Clear();
                }
                else
                {
                    chart1.Series.Add("Series1");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }


                int t = 0;

                List<List<double>> masCoordinates = new List<List<double>>();
                List<double> row = new List<double>();


                step = sizeOfSegmentX / 100.0;


                // построение массива точек
                for (double x = startOfSegmentX; x < endOfSegmentX; x += step)
                {

                    masCoordinates.Add(new List<double>());
                    masCoordinates[t].Add(x);
                    masCoordinates[t].Add(CoordinateGraphicsFunc(x, amplitude1, frequency1, amplitude2, frequency2));
                    t++;
                }

                chart1.ChartAreas[0].AxisX.Minimum = startOfSegmentX;
                chart1.ChartAreas[0].AxisX.Maximum = endOfSegmentX;
                chart1.ChartAreas[0].AxisY.Minimum = startOfSegmentY;
                chart1.ChartAreas[0].AxisY.Maximum = endOfSegmentY;

                foreach (List<double> coordinate in masCoordinates)
                {
                    chart1.Series[0].Points.AddXY(coordinate[0], coordinate[1]);

                }
                chart1.Series[0].Name = amplitude1 + "*sin(2*Pi*" + frequency1 + "*x)*" + amplitude2 + "*sin(2*Pi*" + frequency2 + "+x)";
                chart1.ChartAreas[0].AxisX.Title = "t, сек";
                chart1.ChartAreas[0].AxisY.Title = "Частота, Гц";
            }
        }

        private void buttonDPF_Click(object sender, EventArgs e)
        {
            if (chart2.Series.Count != 0)
            {
                chart2.Series[0].Points.Clear();
            }
            else
            {
                chart2.Series.Add("Series1");
                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }

            double startOfSegmentX, endOfSegmentX, startOfSegmentY, endOfSegmentY, sizeOfSegmentX, sizeOfSegmentY, step,
                amplitude1, amplitude2, frequency1, frequency2;

            

            amplitude1 = Convert.ToDouble(textBoxA1.Text);
            amplitude2 = Convert.ToDouble(textBoxA2.Text);
            frequency1 = Convert.ToDouble(textBoxF1.Text);
            frequency2 = Convert.ToDouble(textBoxF2.Text);

            startOfSegmentX = Convert.ToDouble(textBoxStartX.Text);
            endOfSegmentX = Convert.ToDouble(textBoxEndX.Text);
            startOfSegmentY = Convert.ToDouble(textBoxStartY.Text);
            endOfSegmentY = Convert.ToDouble(textBoxEndY.Text);

            sizeOfSegmentX = endOfSegmentX - startOfSegmentX;
            sizeOfSegmentY = endOfSegmentY - startOfSegmentY;

            int t = 0;

            List<List<double>> masCoordinates = new List<List<double>>();
            List<double> row = new List<double>();

            List<List<double>> masIN = new List<List<double>>();
            List<double> masOUT = new List<double>();

            step = sizeOfSegmentX / 100.0;

            for (double x = 0; x < 100; x += 1)
            {

                masIN.Add(new List<double>());
                masIN[t].Add(CoordinateGraphicsFunc(x, amplitude1, frequency1, amplitude2, frequency2));
                masIN[t].Add(0.0);

                t++;
            }

            /*FormDPF formDPF = new FormDPF();
            formDPF.Show();*/


            List<double> masOUT1 = new List<double>();
            List<double> masOUT2 = new List<double>();
            for (double k = 0; k < 100; k +=1)
            {
                masOUT = ClassDFT.FFT(masIN, k);
                masOUT1.Add(masOUT[0] / 10);
                masOUT2.Add(masOUT[1] / 10);

            }


            /*chart1.ChartAreas[0].AxisX.Minimum = startOfSegmentX;
            chart1.ChartAreas[0].AxisX.Maximum = endOfSegmentX;
            chart1.ChartAreas[0].AxisY.Minimum = startOfSegmentY;
            chart1.ChartAreas[0].AxisY.Maximum = endOfSegmentY;*/


            int counter = 0;

            foreach (double coordinate in masOUT1)
            {
                
                chart2.Series[0].Points.AddXY(counter, coordinate);
                counter++;
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (chart2.Series.Count != 0)
            {
                chart2.Series[0].Points.Clear();
            }
            else
            {
                chart2.Series.Add("Series1");
                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }

            double startOfSegmentX, endOfSegmentX, startOfSegmentY, endOfSegmentY, sizeOfSegmentX, sizeOfSegmentY, step,
                amplitude1, amplitude2, frequency1, frequency2;



            amplitude1 = Convert.ToDouble(textBoxA1.Text);
            amplitude2 = Convert.ToDouble(textBoxA2.Text);
            frequency1 = Convert.ToDouble(textBoxF1.Text);
            frequency2 = Convert.ToDouble(textBoxF2.Text);

            startOfSegmentX = Convert.ToDouble(textBoxStartX.Text);
            endOfSegmentX = Convert.ToDouble(textBoxEndX.Text);
            startOfSegmentY = Convert.ToDouble(textBoxStartY.Text);
            endOfSegmentY = Convert.ToDouble(textBoxEndY.Text);

            sizeOfSegmentX = endOfSegmentX - startOfSegmentX;
            sizeOfSegmentY = endOfSegmentY - startOfSegmentY;

            int t = 0;

            List<List<double>> masCoordinates = new List<List<double>>();
            List<double> row = new List<double>();

            List<List<double>> masIN = new List<List<double>>();
            List<double> masOUT = new List<double>();

            step = sizeOfSegmentX / 100.0;

            for (double x = 0; x < 100; x += 1)
            {

                masIN.Add(new List<double>());
                masIN[t].Add(CoordinateGraphicsFunc(x, amplitude1, frequency1, amplitude2, frequency2));
                masIN[t].Add(0.0);

                t++;
            }

            /*FormDPF formDPF = new FormDPF();
            formDPF.Show();*/


            List<double> masOUT1 = new List<double>();
            List<double> masOUT2 = new List<double>();
            for (double k = 0; k < 100; k += 1)
            {
                masOUT = ClassDFT.IFFT(masIN, k);
                masOUT1.Add(masOUT[0] / 10);
                masOUT2.Add(masOUT[1] / 10);

            }


            /*chart1.ChartAreas[0].AxisX.Minimum = startOfSegmentX;
            chart1.ChartAreas[0].AxisX.Maximum = endOfSegmentX;
            chart1.ChartAreas[0].AxisY.Minimum = startOfSegmentY;
            chart1.ChartAreas[0].AxisY.Maximum = endOfSegmentY;*/


            int counter = 0;

            foreach (double coordinate in masOUT1)
            {

                chart2.Series[0].Points.AddXY(counter, coordinate);
                counter++;
            }

        }
    }
}
