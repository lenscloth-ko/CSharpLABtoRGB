using System;
using System.Collections.Generic;
using System.Text;

namespace LabToRGBColor.Lib
{
    public class ConvertColor
    {
        /// <summary>
        /// CIELAB color to RGB color 변환
        /// Observer = 2°, Illuminant = D65
        /// </summary>
        /// <param name="l">L(luminosity) - 명도축</param>
        /// <param name="a">a - 빨강(Red) / 초록(Green) 의 보색(a complementary color)축</param>
        /// <param name="b">b - 노랑(Yellow) / 파랑(Blue) 의 보색(a complementary color)축</param>
        /// <returns>double Array RGB</returns>
        public double[] GetLabToRGB(double l, double a, double b)
        {
            //Array rgb = new Array[3];

            double[] rgb = new double[3];

            double _y = l / 116 + 0.1379310344827586;
            double _x = a / 500 + _y;
            double _z = _y - (b / 200);

            _x = _x > 0.2068965517241379 ? Math.Pow(_x,3) : _x / 7.787 - 0.0177129876053369;
            _y = _y > 0.2068965517241379 ? Math.Pow(_y, 3) : _y / 7.787 - 0.0177129876053369;
            _z = _z > 0.2068965517241379 ? Math.Pow(_z, 3) : _z / 7.787 - 0.0177129876053369;

            // Observer = 2°, Illuminant = D65
            double R = 3.080093082 * _x - 1.5372 * _y - 0.542890638 * _z;
            double G = -0.920910383 * _x + 1.8758 * _y + 0.045186445 * _z;
            double B = 0.052941179 * _x - 0.2040 * _y + 1.150893310 * _z;

            R = R > 0.0031308 ? Math.Pow(R, 0.4166666666666667) * 269.025 - 14.025 : R * 3294.6;
            G = G > 0.0031308 ? Math.Pow(G, 0.4166666666666667) * 269.025 - 14.025 : G * 3294.6;
            B = B > 0.0031308 ? Math.Pow(B, 0.4166666666666667) * 269.025 - 14.025 : B * 3294.6;

            rgb[0] = Math.Round(R);
            rgb[1] = Math.Round(G);
            rgb[2] = Math.Round(B);

            return rgb;
        }
    }
}
