using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmapGeneratorTool
{
    public class BitmapCreator
    {
        public int ImageWidth { get; private set; }
        public int ImageHeight { get; private set; }
        int red;
        int green;
        int blue;
        int alpha;

        public BitmapCreator(int width, int height)
        {
            
            ImageWidth = width;
            ImageHeight = height;
        }

        public byte[] GenerateEightBitVerticalGradiant(int redLeft, int redRight, int greenLeft, int greenRight, int blueLeft, int blueRight)
        {
            int padding = ImageWidth % 4;
            byte[] bitmapBytes = EightBPCBitmapTemplate();
            int dataByteSize = 3;

            byte[] line = GetLine(ImageWidth, dataByteSize, padding, redLeft, redRight, greenLeft, greenRight, blueLeft, blueRight);

            // offset is the total byte size of the Bitmap Header and the BitmapInfoHeader
            int offset = (int)HEADEROFFSET.headerSize + (int)BITMAPINFOHEADEROFFSET.headerSize;

            for (int i = 0; i < ImageHeight; i++)
            {
                Array.Copy(line, 0, bitmapBytes, offset, line.Length);
                offset += line.Length;

            }

            return bitmapBytes;
        }

        public byte[] GenerateTenBitVerticalGradient(int redLeft, int redRight, int greenLeft, int greenRight, int blueLeft, int blueRight, int alphaLeft, int alphaRight)
        {
            int padding = 0; //ImageWidth % 4;
            byte[] bitmapBytes = ThirtyTwoBPPBitmapTemplate();
            int dataByteSize = 4;

            byte[] line = GetLine(ImageWidth, dataByteSize, padding, redLeft, redRight, greenLeft, greenRight, blueLeft, blueRight);

            int offset = 122;

            //Array.Copy(line, 0, bitmapBytes, offset, line.Length);

            for (int i = 0; i < ImageHeight; i++)
            {
                Array.Copy(line, 0, bitmapBytes, offset, line.Length);
                offset += line.Length;
            }

            return bitmapBytes;
        }
        /// <summary>
        /// Creates a template for an 8 bit bitmap 
        /// </summary>
        /// <returns>
        /// a completed 8 bit bitmap template
        /// </returns>
        private byte[] EightBPCBitmapTemplate()
        {
            byte[] dibHeader = GenerateEightBitBitmapDibHeader(ImageWidth, ImageHeight);
            byte[] bitmapHeader = GenerateBitmapHeader(dibHeader.Length);

            int totalHeadersize = dibHeader.Length + bitmapHeader.Length;

            byte[] CompletedBitmapArray = new byte[totalHeadersize + ((ImageWidth * ImageHeight) * 4)];

            Array.Copy(bitmapHeader, 0, CompletedBitmapArray, 0, bitmapHeader.Length);

            Array.Copy(dibHeader, 0, CompletedBitmapArray, bitmapHeader.Length, dibHeader.Length);

            return CompletedBitmapArray;
        }

        private byte[] ThirtyTwoBPPBitmapTemplate()
        {
            byte[] dibHeader = GenerateThirtyTwoBitHeader(ImageWidth, ImageHeight);
            byte[] bitmapHeader = GenerateBitmapHeader(dibHeader.Length);

            int totalHeaderSize = dibHeader.Length + bitmapHeader.Length;

            byte[] completedBitmapArray = new byte[totalHeaderSize + ((ImageWidth * ImageHeight)*4)];

            Array.Copy(bitmapHeader, 0, completedBitmapArray, 0, bitmapHeader.Length);

            Array.Copy(dibHeader, 0, completedBitmapArray, bitmapHeader.Length, dibHeader.Length);

            return completedBitmapArray;
        }

        /// <summary>
        /// Generates a Bitmap Header using the information from the dib header
        /// </summary>
        /// <param name="dibHeaderSize"> the size of the dib header</param>
        /// <returns>
        /// a byte array of size 14 bytes containing the bitmap header
        /// </returns>
        private byte[] GenerateBitmapHeader(int dibHeaderSize)
        {
            byte[] bitmapHeader = new byte[(int)HEADEROFFSET.headerSize];
            int imageSize = ImageWidth * ImageHeight;
            int offset = bitmapHeader.Length + dibHeaderSize;
            bitmapHeader[(int)HEADEROFFSET.headerField] = (byte)'B';
            bitmapHeader[(int)HEADEROFFSET.headerField + 1] = (byte)'M';
            //Total size of bitmap (offset + image size * number of bytes per pixel)
            Array.Copy(BitConverter.GetBytes((imageSize * 4) + offset), 0, bitmapHeader, (int)HEADEROFFSET.fileSize, 4);
            // Application specific: unused
            Array.Copy(BitConverter.GetBytes(0), 0, bitmapHeader, (int)HEADEROFFSET.reserved1, 2);
            // Application specific: unused
            Array.Copy(BitConverter.GetBytes(0), 0, bitmapHeader, (int)HEADEROFFSET.reserved2, 2);
            // Offset, Where the pixel Array starts
            Array.Copy(BitConverter.GetBytes(offset), 0, bitmapHeader, (int)HEADEROFFSET.startingAddress, 4);

            return bitmapHeader;
        }
        /// <summary>
        /// Generates a Bitmap 	BITMAPINFOHEADER DIB Header
        /// </summary>
        /// <param name="width"> Intended pixel width of bitmap image. </param>
        /// <param name="height">  Intended pixel height of bitmap image. </param>
        /// <returns>
        /// a byte array if size 40 bytes containting the DIB header. 
        /// </returns>
        private byte[] GenerateEightBitBitmapDibHeader(int width, int height)
        {

            byte[] dibHeader = new byte[(int)BITMAPINFOHEADEROFFSET.headerSize];
            // Number of bytes in DIB header
            Array.Copy(BitConverter.GetBytes(dibHeader.Length), 0, dibHeader, (int)BITMAPINFOHEADEROFFSET.numberOfBytes, 4);
            // Width of pixels
            Array.Copy(BitConverter.GetBytes(width), 0, dibHeader, (int)BITMAPINFOHEADEROFFSET.pixelWidth, 4);
            //height of pixels
            Array.Copy(BitConverter.GetBytes(height), 0, dibHeader, (int)BITMAPINFOHEADEROFFSET.pixelHeight, 4);
            //number of colour planes being used
            Array.Copy(BitConverter.GetBytes(1), 0, dibHeader, (int)BITMAPINFOHEADEROFFSET.colorPlanesUsed, 2);
            // number of bits per pixel
            Array.Copy(BitConverter.GetBytes(24), 0, dibHeader, (int)BITMAPINFOHEADEROFFSET.bitsPerPixel, 2);
            // BI_RGB, no pixel array compression used.
            Array.Copy(BitConverter.GetBytes(0), 0, dibHeader, (int)BITMAPINFOHEADEROFFSET.compressionMethod, 4);
            // Size of Raw Bitmap data including padding
            // Array.Copy(BitConverter.GetBytes((width * height) * 4), 0, dibHeader, 18, 4);
            Array.Copy(BitConverter.GetBytes(16), 0, dibHeader, (int)BITMAPINFOHEADEROFFSET.bitmapDataSize, 4);
            //Print Resolution Horizontal
            Array.Copy(BitConverter.GetBytes(0), 0, dibHeader, (int)BITMAPINFOHEADEROFFSET.printResolutionHorizontal, 4);
            //Print Resolution Vertical
            Array.Copy(BitConverter.GetBytes(0), 0, dibHeader, (int)BITMAPINFOHEADEROFFSET.printResolutionVertical, 4);
            // Number of Colours in palette
            Array.Copy(BitConverter.GetBytes(0), 0, dibHeader, (int)BITMAPINFOHEADEROFFSET.colorsInPalette, 4);
            // Number of Important Colours 0 means all colours are important
            Array.Copy(BitConverter.GetBytes(0), 0, dibHeader, (int)BITMAPINFOHEADEROFFSET.importantColors, 4);

            return dibHeader;
        }

        private byte[] GenerateThirtyTwoBitHeader(int width, int height)
        {
            byte[] dibHeader = new byte[108];

            byte[] redBitMask = {0x00, 0x00, 0xFF, 0x00 };
            byte[] greenBitMask = { 0x00, 0xFF, 0x00, 0x00 };
            byte[] blueBitMask = { 0xFF, 0x00, 0x00, 0x00 };
            byte[] alphaBitMask = { 0x00, 0x00, 0x00, 0xFF };

            // Number of bytes in DIB header
            Array.Copy(BitConverter.GetBytes(dibHeader.Length), 0, dibHeader, 0, 4);
            // Width of pixels
            Array.Copy(BitConverter.GetBytes(width), 0, dibHeader, 4, 4);
            //height of pixels
            Array.Copy(BitConverter.GetBytes(height), 0, dibHeader, 8, 4);
            //number of colour planes being used
            Array.Copy(BitConverter.GetBytes(1), 0, dibHeader, 12, 2);
            // number of bits per pixel
            Array.Copy(BitConverter.GetBytes(32), 0, dibHeader, 14, 2);
            // BI_BITFIELDS, no pixel array compression used.
            Array.Copy(BitConverter.GetBytes(3), 0, dibHeader, 16, 4);
            // Size of Raw Bitmap data including padding
            Array.Copy(BitConverter.GetBytes(16), 0, dibHeader, 20, 4);
            //Print Resolution Horizontal
            Array.Copy(BitConverter.GetBytes(0), 0, dibHeader, 24, 4);
            //Print Resolution Vertical
            Array.Copy(BitConverter.GetBytes(0), 0, dibHeader, 28, 4);
            // Number of Colours in palette
            Array.Copy(BitConverter.GetBytes(0), 0, dibHeader, 32, 4);
            // Number of Important Colours 0 means all colours are important
            Array.Copy(BitConverter.GetBytes(0), 0, dibHeader, 36, 4);
            // Red Channel bit mask
            Array.Copy(redBitMask, 0, dibHeader, 40, 4);
            // green Channel bit mask
            Array.Copy(greenBitMask, 0, dibHeader, 44, 4);
            // blue Channel bit mask
            Array.Copy(blueBitMask, 0, dibHeader, 48, 4);
            // alpha Channel bit mask
            Array.Copy(alphaBitMask, 0, dibHeader, 52, 4);
            // LCS_WINDOWS_COLOUR_SPACE
            Array.Copy(new byte[] {0x20, 0x6e, 0x69, 0x57 }, 0, dibHeader, 56, 4);
            // Colourspace endpoints (NOT USED = EMPTY)
            Array.Copy(new byte[36], 0, dibHeader, 60, 36);
            // UNUSED
            Array.Copy(new byte[4], 0, dibHeader, 96, 4);
            // UNUSED
            Array.Copy(new byte[4], 0, dibHeader, 100, 4);
            // UNUSED
            Array.Copy(new byte[4], 0, dibHeader, 104, 4);

            return dibHeader;
        }

        private int IncrementColour(int steps, int count, int min, int max)
        {
            int minColour;

            if(min < 0)
            {
                minColour = 0;
            }
            else
            {
                minColour = min;
            }
            if (steps > 0)
            {
                if ((count) % (steps) == 0)
                {
                    minColour++;

                    if (minColour > max)
                    {
                        return max;
                    }
                }
            }
         return minColour;
        }

        private int DecrementColour(int steps, int count, int min, int max)
        {
            int maxColour;

            if (min < 0)
            {
                maxColour = 0;
            }
            else
            {
                maxColour = max;
            }
            if (steps > 0)
            {
                if ((count) % (steps) == 0)
                {
                    maxColour --;

                    if (maxColour < min)
                    {
                        return min;
                    }
                }
            }
            return maxColour;
        }

        private int GetSteps(int overall, int min, int max)
        {
            if (min < max)
            {
                try
                {
                   return overall / (max - min);
                }catch(DivideByZeroException ex)
                {
                    return 0;
                }
            }
            else
            {
                try
                {
                    return overall / (min - max);
                }
                catch (DivideByZeroException ex)
                {
                    return 0;
                }
            }
        }

        private byte[] GetLine(int imageWidth, int dataByteSize, int padding, int redLeft, int redRight, int greenLeft, int greenRight, int blueLeft, int blueRight, int alphaLeft = 255, int alphaRight = 255)
        {
            byte[] line = new byte[(ImageWidth * dataByteSize) + padding];

            red = redLeft;
            green = greenLeft;
            blue = blueLeft;
            alpha = alphaLeft;

            int count = 0;

            int redSteps = GetSteps(ImageWidth, redLeft, redRight);
            int greenSteps = GetSteps(ImageWidth, greenLeft, greenRight);
            int blueSteps = GetSteps(ImageWidth, blueLeft, blueRight);
            int alphaSteps = GetSteps(ImageWidth, alphaLeft, alphaRight);


            for (int i = 0; i < line.Length - dataByteSize; i += dataByteSize)
            {
                if (red < redRight)
                {
                    red = IncrementColour(redSteps, count, red, redRight);
                }
                else if (red > redRight)
                {
                    red = DecrementColour(redSteps, count, redRight, red);
                }

                if (green < greenRight)
                {
                    green = IncrementColour(greenSteps, count, green, greenRight);
                }
                else
                {
                    green = DecrementColour(redSteps, count, greenRight, green);
                }

                if (blue < blueRight)
                {
                    blue = IncrementColour(blueSteps, count, blue, blueRight);
                }
                else
                {
                    blue = DecrementColour(redSteps, count, blueRight, blue);
                }
                if (alpha < alphaRight)
                {
                    alpha = IncrementColour(alphaSteps, count, alpha, alphaRight);
                }
                else
                {
                    alpha = DecrementColour(alphaSteps, count, alphaRight, alpha);
                }

                byte[] colour = { (byte)blue, (byte)green, (byte)red, (byte)alpha };
                Array.Copy(colour, 0, line, i, dataByteSize);

                count++;
            }


            return line;
        }

        private enum HEADEROFFSET
        {
            headerField = 0,
            fileSize = 2,
            reserved1 = 6,
            reserved2 = 8,
            startingAddress = 10,
            headerSize = 14
        }

        private enum BITMAPINFOHEADEROFFSET
        {
            numberOfBytes = 0,
            pixelWidth = 4,
            pixelHeight = 8,
            colorPlanesUsed = 12,
            bitsPerPixel = 14,
            compressionMethod = 16,
            bitmapDataSize = 20,
            printResolutionHorizontal = 24,
            printResolutionVertical = 28,
            colorsInPalette = 32,
            importantColors = 36,
            headerSize = 40
        }
    }
}
