using System;
using System.Drawing;

using LabToRGBColor.Lib;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //LabColor input = new LabColor(10, 20, 30);

            //RGBColor rgbColor = new RGBColor();

            //GetLabToRGB

            //rgbColor.
            //Usage ug = new Usage();
            //ug.LabToRGB(10, 20, 30);

            //RGBColor rgb = ug.LabToRGB(125, 10, 50);

            //Console.WriteLine(rgb.R);
            //Console.WriteLine(rgb.G);
            //Console.WriteLine(rgb.B);
            //Console.WriteLine(rgb.Vector);


            //LinearRGBColor LRGB = ug.LabToRGB(125, 10, 50);
            //Console.WriteLine(LRGB.R);
            //Console.WriteLine(LRGB.G);
            //Console.WriteLine(LRGB.B);

            //Color color = new Color

            ConvertColor cc = new ConvertColor();

            foreach (double item in cc.GetLabToRGB(10, 10, 10))
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(cc.GetLabToRGB(10, 10, 10));
        }
    }
}
