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

        public BitmapCreator(int width, int height)
        {
            
            ImageWidth = width;
            ImageHeight = height;
        }

        public byte[] GenerateEightBitVerticalGradiant(int redLeft, int redRight, int greenLeft, int greenRight, int blueLeft, int blueRight)
        {
            int padding = ImageWidth % 4;
            byte[] bitmapBytes = TwentyFourBPPBitmapTemplate();

            byte[] line = new byte[(ImageWidth * 3) + padding];

            red = redLeft;
            green = greenLeft;
            blue = blueLeft;
            
            int count = 0;

            int redSteps = GetSteps(ImageWidth, redLeft, redRight);
            int greenSteps = GetSteps(ImageWidth, greenLeft, greenRight);
            int blueSteps = GetSteps(ImageWidth, blueLeft, blueRight);
            
            for (int i = 0; i < line.Length-3; i += 3)
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

                byte[] colour = { (byte)blue, (byte)green, (byte)red };
                Array.Copy(colour, 0, line, i, 3);
                count++;
            }

            // offset is the total byte size of the Bitmap Header and the BitmapInfoHeader
            int offset = 54;
            for(int i = 0; i < ImageHeight; i++)
            {
                Array.Copy(line, 0, bitmapBytes, offset, line.Length);
                offset += line.Length;

            }
            //for (int i = 54; i < bitmapBytes.Length - 3; i += 3)
            //{

            
            //    if ((count) % ImageWidth == 0)
            //    {
            //        red = redLeft;
            //        green = greenLeft;
            //        blue = blueLeft;
            //    }


            //byte[] colour = { (byte)blue, (byte)green, (byte)red };
            //Array.Copy(colour, 0, bitmapBytes, i, 3);

            //count++;

            //}

            return bitmapBytes;
        }

        /// <summary>
        /// Creates a template for an 8 bit bitmap 
        /// </summary>
        /// <returns>
        /// a completed 8 bit bitmap template
        /// </returns>
        private byte[] TwentyFourBPPBitmapTemplate()
        {
            byte[] dibHeader = GenerateBitmapDibHeader(ImageWidth, ImageHeight);
            byte[] bitmapHeader = GenerateBitmapHeader(dibHeader.Length);

            int totalHeadersize = dibHeader.Length + bitmapHeader.Length;

            byte[] CompletedBitmapArray = new byte[totalHeadersize + ((ImageWidth * ImageHeight)*4)];

            Array.Copy(bitmapHeader, 0, CompletedBitmapArray, 0, bitmapHeader.Length);

            Array.Copy(dibHeader, 0, CompletedBitmapArray, bitmapHeader.Length, dibHeader.Length);

            return CompletedBitmapArray;
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
            byte[] bitmapHeader = new byte[14];
            int imageSize = ImageWidth * ImageHeight;
            int offset = bitmapHeader.Length + dibHeaderSize;
            bitmapHeader[0] = 0x42;
            bitmapHeader[1] = 0x4D;
            //Total size of bitmap (54 + image size * number of bytes per pixel)
            Array.Copy(BitConverter.GetBytes((imageSize*4) + offset), 0, bitmapHeader, 2, 4);
            // Application specific: unused
            Array.Copy(BitConverter.GetBytes(0), 0, bitmapHeader, 6, 2);
            // Application specific: unused
            Array.Copy(BitConverter.GetBytes(0), 0, bitmapHeader, 8, 2);
            // Offset, Where the pixel Array starts
            Array.Copy(BitConverter.GetBytes(offset), 0, bitmapHeader, 10, 4);

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
        private byte[] GenerateBitmapDibHeader(int width, int height)
        {

            byte[] dibHeader = new byte[40];
            // Number of bytes in DIB header
            Array.Copy(BitConverter.GetBytes(dibHeader.Length), 0, dibHeader, 0, 4);
            // Width of pixels
            Array.Copy(BitConverter.GetBytes(width), 0, dibHeader, 4, 4);
            //height of pixels
            Array.Copy(BitConverter.GetBytes(height), 0, dibHeader, 8, 4);
            //number of colour planes being used
            Array.Copy(BitConverter.GetBytes(1), 0, dibHeader, 12, 2);
            // number of bits per pixel
            Array.Copy(BitConverter.GetBytes(24), 0, dibHeader, 14, 2);
            // BI_RGB, no pixel array compression used.
            Array.Copy(BitConverter.GetBytes(0), 0, dibHeader, 16, 4);
            // Size of Raw Bitmap data including padding
            // Array.Copy(BitConverter.GetBytes((width*height)*4), 0, dibHeader, 18, 4);
            Array.Copy(BitConverter.GetBytes(16), 0, dibHeader, 20, 4);
            //Print Resolution Horizontal
            Array.Copy(BitConverter.GetBytes(0), 0, dibHeader, 24, 4);
            //Print Resolution Vertical
            Array.Copy(BitConverter.GetBytes(0), 0, dibHeader, 28, 4);
            // Number of Colours in palette
            Array.Copy(BitConverter.GetBytes(0), 0, dibHeader, 32, 4);
            // Number of Important Colours 0 means all colours are important
            Array.Copy(BitConverter.GetBytes(0), 0, dibHeader, 36, 4);

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
        
        
    }
}
