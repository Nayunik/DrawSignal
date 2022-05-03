﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MathNet.Numerics.IntegralTransforms;

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
            return   ampl1 * Math.Sin(2.0 * Math.PI * freq1 * x) + ampl2 * Math.Sin(2.0 * Math.PI * freq2 * x);
        }

        Signal globalSignal = new Signal();

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

                double startOfSegmentX = -5, endOfSegmentX = 5, startOfSegmentY = -5, endOfSegmentY = 5, sizeOfSegmentX, step,
                amplitude1, amplitude2, frequency1, frequency2;

                amplitude1 = Convert.ToDouble(textBoxA1.Text);
                amplitude2 = Convert.ToDouble(textBoxA2.Text);
                frequency1 = Convert.ToDouble(textBoxF1.Text);
                frequency2 = Convert.ToDouble(textBoxF2.Text);

                // Создание нового объекта класса Signal
                globalSignal.frequency1 = frequency1;
                globalSignal.amplitude1 = amplitude1;
                globalSignal.frequency2 = frequency2;
                globalSignal.amplitude2 = amplitude2;

                startOfSegmentX = Convert.ToDouble(textBoxStartX.Text);
                endOfSegmentX = Convert.ToDouble(textBoxEndX.Text);
                startOfSegmentY = Convert.ToDouble(textBoxStartY.Text);
                endOfSegmentY = Convert.ToDouble(textBoxEndY.Text);

                // Присвоение диапазона сигнала
                globalSignal.startOfCoordinateX = startOfSegmentX;
                globalSignal.endOfCoordinateX = endOfSegmentX;

                sizeOfSegmentX = endOfSegmentX - startOfSegmentX;
                step = sizeOfSegmentX / 100.0;

                chart1.ChartAreas[0].AxisX.Minimum = startOfSegmentX;
                chart1.ChartAreas[0].AxisX.Maximum = endOfSegmentX;
                chart1.ChartAreas[0].AxisY.Minimum = startOfSegmentY;
                chart1.ChartAreas[0].AxisY.Maximum = endOfSegmentY;

                // построение графика 
                for (double x = startOfSegmentX; x < endOfSegmentX; x += step)
                {
                    double coordinateY = CoordinateGraphicsFunc(x, globalSignal.amplitude1, globalSignal.frequency1, globalSignal.amplitude2, globalSignal.frequency2);
                    globalSignal.masCoordinateSignalX.Add(x);
                    globalSignal.masCoordinateSignalY.Add(coordinateY);
                    chart1.Series[0].Points.AddXY(x, coordinateY);
                }

                chart1.Series[0].Name = globalSignal.amplitude1 + "*sin(2*Pi*" + globalSignal.frequency1 + "*x)*" + globalSignal.amplitude2 + "*sin(2*Pi*" + globalSignal.frequency2 + "+x)";
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
                if (chart1.Series.Count != 0)
                {
                    chart1.Series[0].Points.Clear();
                }
                else
                {
                    chart1.Series.Add("Series1");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }

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

                int t = 0;

                List<List<double>> masCoordinates = new List<List<double>>();

                               
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
        /// <summary>
        /// Функция для построения амплитудного спектра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDPF_Click(object sender, EventArgs e)
        {
            globalSignal.samplingFrequency = Convert.ToDouble(textBoxFreq.Text); // samples - частота дискретизации
                       
            FormDPF formDPF = new FormDPF();
            formDPF.OpenForm(globalSignal, false);
            formDPF.Show();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxFreq.Text != "")
            {
                globalSignal.samplingFrequency = Convert.ToDouble(textBoxFreq.Text); // частота дискретизации 
            }

            FormDPF formDPF = new FormDPF();
            formDPF.OpenForm(globalSignal, true);
            formDPF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (chart2.Series.Count != 0)
            {
                chart2.Series[0].Points.Clear();
            }
            else
            {
                chart2.Series.Add("Series1");
                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }

            double startOfSegmentX, endOfSegmentX, startOfSegmentY, endOfSegmentY, sizeOfSegmentX,  step,
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

            step = sizeOfSegmentX / 100.0;

            int t = 0;

            List<List<double>> masXui = new List<List<double>>();
            List<double> row = new List<double>();

            List<List<double>> masObrIN = new List<List<double>>();
            List<double> masObrOUT = new List<double>();
            List<double> masObrOUT3 = new List<double>();



            double samples; // samples - частота дискретизации 

            samples = Convert.ToDouble(textBoxFreq.Text);



            //                длина отрезка и частота дискретизации
            for (double x = startOfSegmentX; x < endOfSegmentX; x += 1 / samples)
            {

                masObrIN.Add(new List<double>());
                masObrIN[t].Add(CoordinateGraphicsFunc(x, amplitude1, frequency1, amplitude2, frequency2));

                masObrIN[t].Add(0.0);

                t++;
            }

            List<double> masOUT1 = new List<double>();
            List<double> masOUT2 = new List<double>();

            int N = Convert.ToInt32(samples * sizeOfSegmentX);



            t = 0;
            for (double k = 0; k < N; k += 1)
            {
                masObrOUT3 = ClassDFT.IFFT(masOUT1, masOUT2, k);
                masXui.Add(new List<double>());
                masXui[t].Add(masObrOUT3[0]);
                masXui[t].Add(masObrOUT3[1]);
                t++;

            }
            t = 0;
            for (double x = startOfSegmentX; x < endOfSegmentX; x += step)
            {
                if(t < masXui.Count)
                {

                chart2.Series[0].Points.AddXY(x, masXui[t][0]);
                }
                t++;
            }

*/
            t = 0;
            chart2.ChartAreas[0].AxisX.Minimum = startOfSegmentX;
            chart2.ChartAreas[0].AxisX.Maximum = endOfSegmentX;
            chart2.ChartAreas[0].AxisY.Minimum = startOfSegmentY;
            chart2.ChartAreas[0].AxisY.Maximum = endOfSegmentY;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chart2.Series.Count != 0)
            {
                chart2.Series[0].Points.Clear();
            }
            else
            {
                chart2.Series.Add("Series1");
                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }

            double startOfSegmentX, endOfSegmentX, startOfSegmentY, endOfSegmentY, sizeOfSegmentX,
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

            int t = 0;

            List<List<double>> masIN = new List<List<double>>();
            List<double> masOUT = new List<double>();



            double samples; // samples - частота дискретизации 

            samples = Convert.ToDouble(textBoxFreq.Text);



            //                длина отрезка и частота дискретизации
            for (double x = startOfSegmentX; x < endOfSegmentX; x += 1 / samples)
            {

                masIN.Add(new List<double>());
                masIN[t].Add(CoordinateGraphicsFunc(x, amplitude1, frequency1, amplitude2, frequency2));

                masIN[t].Add(0.0);

                t++;
            }


            List<double> masOUT1 = new List<double>();
            List<double> masOUT2 = new List<double>();

            int N = Convert.ToInt32(samples * sizeOfSegmentX);


            // подсчет комплексных чисел
            for (double k = 0; k < N; k += 1)
            {
                masOUT = ClassDFT.FFT(masIN, k);
                masOUT1.Add(masOUT[0]);
                masOUT2.Add(masOUT[1]);
                int op = 0;

            }



 int counter = 0;

            for (int i = 0; i < masOUT1.Count; i++)
            {
                double Ak = Math.Sqrt(Math.Pow(masOUT1[i], 2) + Math.Pow(masOUT2[i], 2));

                chart2.Series[0].Points.AddXY(i, Ak);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chart1.Series.Count != 0)
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[0].Name = "";
            }
            
        }
    }
}
