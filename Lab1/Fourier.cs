using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Lab2
{
    static class Fourier
    {    
        public static void dft(ref Complex[] X, out Complex[] Y, int sign, int N)
        {
            Y = new Complex[N];
            for (int k = 0; k < N; k++)
            {
                for (int i = 0; i < N; i++)
                {
                    var phase = (sign * 2 * (Math.PI / N) * k * i);
                    var w = new Complex((float)Math.Cos(phase), (float)Math.Sin(phase));
                    Y[k] += (X[i] * w);
                }
                if(sign == -1)
                {
                   Y[k] /= N;
                }
            }
        }

        public static Complex[] fft(Complex[] X, int sign)
        {
            if (X.Length == 1)
            {
                return X;
            }
            Complex[] evens = new Complex[X.Length / 2];
            Complex[] odds = new Complex[X.Length / 2];
            for (int k = 0, j = 0; k < X.Length; k += 2, j++)
            {
                evens[j] = X[k];
                odds[j] = X[k + 1];
            }
            evens = fft(evens, sign);
            odds = fft(odds, sign);
            Complex w1 = new Complex((float)Math.Cos(2 * Math.PI / X.Length), (float)Math.Sin(sign * 2 * Math.PI / X.Length));
            Complex w = 1;
            Complex[] newX = new Complex[X.Length];
            for (int i = 0; i < X.Length/2; i++)
            {
                newX[i] = evens[i] + w * odds[i];
                newX[i + X.Length / 2] = evens[i] - w * odds[i];
                w *= w1;
            }
            return newX;
        }
    }
}
