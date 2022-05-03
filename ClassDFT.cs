using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;

using System.Numerics;

namespace scoslab2
{
    class ClassDFT
    {

        public static List<double> FFT0 (List<double> mas, double k)
        {
            List<double> masComplex = new List<double>();

            double re = 0.0, im = 0.0, xn, a2, b2, arg;
            int lenMas = mas.Count;

            for (int n = 0; n < lenMas; n++)
            {
                xn = mas[n];

                arg = 2 * Math.PI * k * n / lenMas;
                

                a2 = Math.Cos(arg);
                b2 = Math.Sin(arg);

                // xn*(cos(arg) - i*sin(arg))

                re += xn * a2;
                im -= xn * b2;

            }

          
            masComplex.Add(re);
            masComplex.Add(im);

            return masComplex;
        }

        public static List<double> FFT(List<List<double>> mas, double k)
        {
            List<double> masComplex = new List<double>();

            double re = 0.0, im = 0.0, xn, a2, b1 = 0, b2, arg;
            int n = 0;
            int lenMas = mas.Count;

            foreach (List<double> complex in mas)
            {
                xn = complex[0];

                arg = 2 * Math.PI * k * n / lenMas;
                n++;

                a2 = Math.Cos(arg);
                b2 = Math.Sin(arg);

                // xn*(cos(arg) - i*sin(arg))

                re += xn * a2;
                im -= xn * b2;

                b1++;
                /*re += (a1 * a2 - b1 * b2);
                im -= (a1 * b2 + b1 * a2);*/


            }

            masComplex.Add(re);
            masComplex.Add(im);

            return masComplex;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mas1">массив действительных частей комплексного числа</param>
        /// <param name="mas2">массив мнимых частей комплексного числа</param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static List<double> IFFT(List<double> mas1, List<double> mas2, double k)
        {
            List<double> masComplex = new List<double>();

            double re = 0.0, im = 0.0, a1, a2, b1, b2, arg;
            int n = 0;
            int lenMas = mas1.Count;

            for (int i = 0; i < lenMas; i++)
            {
                a1 = mas1[i];
                b1 = mas2[i];

                arg = 2 * Math.PI * k * n / lenMas;
                n++;

                a2 = Math.Cos(arg);
                b2 = Math.Sin(arg);

                re += (a1 * a2 - b1 * b2);
                im += (a1 * b2 + b1 * a2);

            }

            masComplex.Add(re/lenMas);
            masComplex.Add(im/lenMas);

            return masComplex;
        }

        /// <summary>
        /// Вычисление поворачивающего модуля e^(-i*2*PI*k/N)
        /// </summary>
        /// <param name="k"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        private static Complex32 w(int k, int N)
        {
            if (k % N == 0) return 1;
            double arg = -2 * Math.PI * k / N;
            return new Complex32((float)Math.Cos(arg), (float)Math.Sin(arg));
        }
        /// <summary>
        /// Возвращает спектр сигнала
        /// </summary>
        /// <param name="x">Массив значений сигнала. Количество значений должно быть степенью 2</param>
        /// <returns>Массив со значениями спектра сигнала</returns>
        public static Complex32[] fft(Complex32[] x)
        {
            Complex32[] X;
            int N = x.Length;
            if (N == 2)
            {
                X = new Complex32[2];
                X[0] = x[0] + x[1];
                X[1] = x[0] - x[1];
            }
            else
            {
                Complex32[] x_even = new Complex32[N / 2];
                Complex32[] x_odd = new Complex32[N / 2];
                for (int i = 0; i < N / 2; i++)
                {
                    x_even[i] = x[2 * i];
                    x_odd[i] = x[2 * i + 1];
                }
                Complex32[] X_even = fft(x_even);
                Complex32[] X_odd = fft(x_odd);
                X = new Complex32[N];
                for (int i = 0; i < N / 2; i++)
                {
                    X[i] = X_even[i] + w(i, N) * X_odd[i];
                    X[i + N / 2] = X_even[i] - w(i, N) * X_odd[i];
                }
            }
            return X;
        }
        /// <summary>
        /// Центровка массива значений полученных в fft (спектральная составляющая при нулевой частоте будет в центре массива)
        /// </summary>
        /// <param name="X">Массив значений полученный в fft</param>
        /// <returns></returns>
        public static Complex32[] nfft(Complex32[] X)
        {
            int N = X.Length;
            Complex32[] X_n = new Complex32[N];
            for (int i = 0; i < N / 2; i++)
            {
                X_n[i] = X[N / 2 + i];
                X_n[N / 2 + i] = X[i];
            }
            return X_n;
        }

    }
}
