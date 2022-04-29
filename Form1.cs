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
            if (!chart1.Size.IsEmpty)
            { 
               chart1.Series[0].Points.Clear();
            }

            //int widthPictureBox = pictureBox1.Width;
            double startOfSegmentX = -5, endOfSegmentX = 7, startOfSegmentY = -5, endOfSegmentY = 5, sizeOfSegmentX, step;
            int t = 0;

            List<List<double>> masCoordinates = new List<List<double>>();
            List<double> row = new List<double>();

            startOfSegmentX = Convert.ToDouble(textBoxStartX.Text);
            endOfSegmentX = Convert.ToDouble(textBoxEndX.Text);
            startOfSegmentY = Convert.ToDouble(textBoxStartY.Text);
            endOfSegmentY = Convert.ToDouble(textBoxEndY.Text);

            /*Graphics graphics = pictureBox1.CreateGraphics();

            graphics.Clear(Color.White); // Очистка от старых рисунков

            Pen pen = new Pen(Color.Black, 3f);

            Point[] points = new Point[1000];
*/
            sizeOfSegmentX = endOfSegmentX - startOfSegmentX;
            step = sizeOfSegmentX / 100.0;

            
            // построение массива точек
            for (double x = startOfSegmentX + startOfSegmentX * 0.1; x < sizeOfSegmentX; x += step)
            {
                /*row.Add(x);
                row.Add(CoordinateGraphicsFunc(x, Convert.ToDouble(textBoxA1.Text), Convert.ToDouble(textBoxF1.Text), Convert.ToDouble(textBoxA2.Text), Convert.ToDouble(textBoxF2.Text)));*/
                masCoordinates.Add(new List<double>());
                masCoordinates[t].Add(x);
                masCoordinates[t].Add(CoordinateGraphicsFunc(x, Convert.ToDouble(textBoxA1.Text), Convert.ToDouble(textBoxF1.Text), Convert.ToDouble(textBoxA2.Text), Convert.ToDouble(textBoxF2.Text)));
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
            //double a1 = Convert.ToDouble(textBoxA1.Text), a2 = Convert.ToDouble(textBoxA2.Text), f1 = Convert.ToDouble(textBoxF1.Text), f2 = Convert.ToDouble(textBoxF2.Text);

                /*for (int i = 0; i < points.Length; i+=1)
                {
       
                var num = CoordinateGraphicsFunc(x, 1.0, 1.0, 1.0, 2.0);
                // var num = GraphicsFunc(i, a1, f1, a2, f2);
                masCoordinates[i] = num;
                points[i] = new Point(x, (int)(num + 150));
                x += 0.1;
                }

                graphics.DrawLines(pen, points);
*/
                
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemPlus_Click(object sender, EventArgs e)
        {
           // double 
        }
    }
}
