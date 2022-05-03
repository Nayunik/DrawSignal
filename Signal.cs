using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoslab2
{
    public class Signal
    {
        // Переменные для построения графика сигнала - A1 * sin(2 * Pi * F1 * x) + A2 * sin(2 * Pi * F2 * x)

        public double frequency1;
        public double frequency2;
        public double amplitude1;
        public double amplitude2;

        //Переменные, задающие диапазон графика по оси Х

        public double startOfCoordinateX;
        public double endOfCoordinateX;

        //Частота дискретизации для ДПФ

        public double samplingFrequency;

        // Название сигнала
        public string signalName;

        // Массивы с координатами X и Y графика -  A1 * sin(2 * Pi * F1 * x) + A2 * sin(2 * Pi * F2 * x)

        public List<double> masCoordinateSignalX;
        public List<double> masCoordinateSignalY;

        // Массивы содержащие действительную и мнимую часть комплексного числа для амплитудного спектра

        public List<double> masRealNumberAmplitudeSpectrum;
        public List<double> masImaginaryNumberAmplitudeSpectrum;

        // Массивы содержащие действительную и мнимую часть комплексного числа для фазового спектра

        public List<double> masRealNumberPhaseSpectrum;
        public List<double> masImaginaryNumberPhaseSpectrum;

        public Signal()
        {
            masCoordinateSignalX = new List<double>();
            masCoordinateSignalY = new List<double>();
        }


        /*public Signal (double _frequency1, double _amplitude1, double _frequency2, double _amplitude2)
        {
            frequency1 = _frequency1;
            frequency2 = _frequency2;
            amplitude1 = _amplitude1;
            amplitude2 = _amplitude2;

            signalName = amplitude1 + "*sin(2*Pi*" + frequency1 + "*x)*" + amplitude2 + "*sin(2*Pi*" + frequency2 + "+x)";
        }*/
    }
}
