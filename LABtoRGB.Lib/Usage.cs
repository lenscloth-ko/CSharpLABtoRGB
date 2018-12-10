using Colourful;
using Colourful.Conversion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LABtoRGB.Lib
{
    public class Usage
    {
        /// <summary>
        /// Color conversion
        /// The ColourfulConverter facade can convert from any of the supported color spaces to any other color space.
        /// It always performs the chromatic adaptation if the input and output color space white points are different.
        /// </summary>
        private void ColorConversion()
        {
            RGBColor input = new RGBColor(1, 0, 0);

            var converter = new ColourfulConverter { WhitePoint = Illuminants.D65 };

            XYZColor output = converter.ToXYZ(input);
        } // end ColorConversion

        /// <summary>
        /// Chromatic adaptation
        /// The adaptation can be also performed alone (e.g. from CIELAB D50 to CIELAB D65).
        /// </summary>
        private void ChromaticAdaptation()
        {
            LabColor input = new LabColor(10, 20, 30, Illuminants.D50);

            var converter = new ColourfulConverter { TargetLabWhitePoint = Illuminants.D65 };

            LabColor output = converter.Adapt(input);

        } // end ChromaticAdaptation

        /// <summary>
        /// Conversion between RGB working spaces
        /// Adaptation can also convert from one RGB working space to another (e.g. from sRGB to Adobe RGB).
        /// Converter can be configured to arbitrary chromatic adaptation method, several are supported.
        /// </summary>
        private void ConversionBetweenRGBWorkingSpaces()
        {
            //RGBColor input = new RGBColor(Color.Yellow, RGBWorkingSpaces.sRGB);

            //var converter = new ColourfulConverter { TargetRGBWorkingSpace = RGBWorkingSpaces.AdobeRGB1998 };

            //RGBColor output = converter.Adapt(input);
        }

        /// <summary>
        /// CCT approximation
        /// Colourful also supports computing correlated color temperature (CCT) from chromaticity and computing chromaticity from CCT. Although these are just approximations with low precision.
        /// o obtain chromaticity of a color in any color space, use conversion to CIE xyY color space. To obtain color from chromaticity (xy), just add the luminance Y and the result is xyY.x`
        /// </summary>
        private void CCTApproximation()
        {
            //var converter = new CCTConverter();

            //ChromaticityCoordinates chromaticity = converter.GetChromaticityOfCCT(5454); // x=0.33, y=0.34

            //double cct = converter.GetCCTOfChromaticity(new ChromaticityCoordinates(0.31271, 0.32902)); // cca 6500 K 
        }


    }
}
