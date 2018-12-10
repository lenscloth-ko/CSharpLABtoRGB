using Colourful;
using Colourful.Conversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace LABtoRGB.Lib
{
    public class Usage
    {
        private void RGBtoXYZ()
        {
            RGBColor input = new RGBColor(1, 0, 0);

            var converter = new ColourfulConverter { WhitePoint = Illuminants.D65 };

            XYZColor output = converter.ToXYZ(input);
        }

        private void LABColor()
        {
            LabColor input = new LabColor(10, 20, 30, Illuminants.D50);

            var converter = new ColourfulConverter { TargetLabWhitePoint = Illuminants.D65 };

            LabColor output = converter.Adapt(input);

        }
    }
}
