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
    public partial class FormDPF : Form
    {
        private Signal globalSignalDPF = new Signal();

        // Переменная mode отвечает за выбранный вариант спектра: 0 - амплитудный, 1 - фазовый
        
        private bool _mode;
        public FormDPF()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {

            //ClassDFT.fft();
        }

        public double CoordinateGraphicsFunc(double x, double ampl1, double freq1, double ampl2, double freq2)
        {
            return ampl1 * Math.Sin(2.0 * Math.PI * freq1 * x) + ampl2 * Math.Sin(2.0 * Math.PI * freq2 * x);
        }

        private void FormDPF_Load(object sender, EventArgs e)
        {
           

        }

        public void OpenForm(Signal signal, bool mode)
        {
            globalSignalDPF = signal;
            _mode = mode;

            if (_mode)
            {
                // Фазовый
                if (chart1.Series.Count != 0)
                {
                    chart1.Series[0].Points.Clear();
                }
                else
                {
                    chart1.Series.Add("Series1");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }

                double sizeOfSegmentX;

                sizeOfSegmentX = globalSignalDPF.endOfCoordinateX - globalSignalDPF.startOfCoordinateX;

                List<double> masIN = new List<double>();

                //                длина отрезка и частота дискретизации
                for (double x = globalSignalDPF.startOfCoordinateX; x < globalSignalDPF.endOfCoordinateX; x += 1 / globalSignalDPF.samplingFrequency)
                {


                    masIN.Add(CoordinateGraphicsFunc(x, globalSignalDPF.amplitude1, globalSignalDPF.frequency1, globalSignalDPF.amplitude2, globalSignalDPF.frequency2));

                }


                List<double> masOut = new List<double>();

                int N = Convert.ToInt32(globalSignalDPF.samplingFrequency * sizeOfSegmentX);

                globalSignalDPF.masRealNumberPhaseSpectrum = new List<double>();
                globalSignalDPF.masImaginaryNumberPhaseSpectrum = new List<double>();

                // подсчет комплексных чисел
                for (int k = 0; k < N; k++)
                {


                    masOut = ClassDFT.FFT0(masIN, k);
                    globalSignalDPF.masRealNumberPhaseSpectrum.Add(masOut[0]);
                    globalSignalDPF.masImaginaryNumberPhaseSpectrum.Add(masOut[1]);

                    double Fk = Math.Atan2(globalSignalDPF.masImaginaryNumberPhaseSpectrum[k], globalSignalDPF.masRealNumberPhaseSpectrum[k]);

                    chart1.Series[0].Points.AddXY(k, Fk);
                }

                this.Text = "Фазовый спектр";
                label4.Text += "\r\n" + globalSignalDPF.samplingFrequency;
            }
            else
            {
                // Амплитудный
                if (chart1.Series.Count != 0)
                {
                    chart1.Series[0].Points.Clear();
                }
                else
                {
                    chart1.Series.Add("Series1");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }

                double sizeOfSegmentX;

                sizeOfSegmentX = globalSignalDPF.endOfCoordinateX - globalSignalDPF.startOfCoordinateX;

                List<double> masIN = new List<double>();

                //                длина отрезка и частота дискретизации
                for (double x = globalSignalDPF.startOfCoordinateX; x < globalSignalDPF.endOfCoordinateX; x += 1 / globalSignalDPF.samplingFrequency)
                {


                    masIN.Add(CoordinateGraphicsFunc(x, globalSignalDPF.amplitude1, globalSignalDPF.frequency1, globalSignalDPF.amplitude2, globalSignalDPF.frequency2));

                }


                List<double> masOut = new List<double>();

                int N = Convert.ToInt32(globalSignalDPF.samplingFrequency * sizeOfSegmentX);

                globalSignalDPF.masRealNumberAmplitudeSpectrum = new List<double>();
                globalSignalDPF.masImaginaryNumberAmplitudeSpectrum = new List<double>();

                // подсчет комплексных чисел
                for (int k = 0; k < N; k++)
                {

                    masOut = ClassDFT.FFT0(masIN, k);
                    globalSignalDPF.masRealNumberAmplitudeSpectrum.Add(masOut[0]);
                    globalSignalDPF.masImaginaryNumberAmplitudeSpectrum.Add(masOut[1]);

                    double Ak = Math.Sqrt(Math.Pow(globalSignalDPF.masRealNumberAmplitudeSpectrum[k], 2) + Math.Pow(globalSignalDPF.masImaginaryNumberAmplitudeSpectrum[k], 2));

                    chart1.Series[0].Points.AddXY(k, Ak);
                }

                this.Text = "Амплитудный спектр";
                label4.Text += "\r\n" + globalSignalDPF.samplingFrequency;

            }

        }
    }
}
