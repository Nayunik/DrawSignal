using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoslab2
{
    class Signal
    {

        // Переменные для построения графика сигнала - A1 * sin(2 * Pi * F1 * x) + A2 * sin(2 * Pi * F2 * x)

        public double frequency1;
        public double frequency2;
        public double amplitude1;
        public double amplitude2;

        // Массивы с координатами X и Y графика -  A1 * sin(2 * Pi * F1 * x) + A2 * sin(2 * Pi * F2 * x)

        public List<double> masCoordinateSignalX;
        public List<double> masCoordinateSignalY;

        // Массивы содержащие действительную и мнимую часть комплексного числа для амплитудного спектра

        public List<double> masRealNumberAmplitudeSpectrum;
        public List<double> masImaginaryNumberAmplitudeSpectrum;

        // Массивы содержащие действительную и мнимую часть комплексного числа для фазового спектра

        public List<double> masRealNumberPhaseSpectrum;
        public List<double> masImaginaryNumberPhaseSpectrum;


    }
}
