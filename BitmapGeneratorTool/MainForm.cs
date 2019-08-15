using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapGeneratorTool
{
    public partial class mainForm : Form
    {
        int imageWidth;
        int imageHeight;
        int redLow;
        int redHigh;
        int greenLow;
        int greenHigh;
        int blueLow;
        int blueHigh;


        public mainForm()
        {
            InitializeComponent();

            widthValueTextBox.Text = Screen.PrimaryScreen.Bounds.Width.ToString();
            heightValueTextBox.Text = Screen.PrimaryScreen.Bounds.Height.ToString();
            
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            widthValueTextBox.Text = Screen.PrimaryScreen.Bounds.Width.ToString();
            heightValueTextBox.Text = Screen.PrimaryScreen.Bounds.Height.ToString();
            redLowTextBox.Text = "0";
            redHighTextBox.Text = "255";
            greenLowTextBox.Text = "0";
            greenHighTextBox.Text = "255";
            blueLowTextBox.Text = "0";
            blueHighTextBox.Text = "255";
            
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                ParseTextBoxes();

                //if (imageWidth % 4 > 0 || imageHeight % 4 > 0)
                //{
                //    MessageBox.Show("Width or Height not divisable by 4");
                //}
                //else
                //{
                    byte[] bitmapBytes = CreateBitmap();
                    Image picture = GetBitmap(bitmapBytes);
                    GeneratedBitmapForm bitmapWindow = new GeneratedBitmapForm(picture, imageWidth, imageHeight);

                    bitmapWindow.ShowDialog();
                //}
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                byte[] bitmapBytes = CreateBitmap();

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter += "Bitmap Files(*.bmp) | *.bmp | All files(*.*) | *.* "; 
                saveFile.ShowDialog();

                File.WriteAllBytes(saveFile.FileName, bitmapBytes);
            }
        }

        private void flipColoursButton_Click(object sender, EventArgs e)
        {
            string redLow = redLowTextBox.Text;
            string greenLow = greenLowTextBox.Text;
            string blueLow = blueLowTextBox.Text;

            redLowTextBox.Text = redHighTextBox.Text;
            redHighTextBox.Text = redLow;
            greenLowTextBox.Text = greenHighTextBox.Text;
            greenHighTextBox.Text = greenLow;
            blueLowTextBox.Text = blueHighTextBox.Text;
            blueHighTextBox.Text = blueLow;

        }

        private bool ValidateInput()
        {
            bool output = true;
            int ParsedText;

            if(!int.TryParse(widthValueTextBox.Text, out ParsedText))
            {
                output = false;
            }
            if(ParsedText < 256)
            {
                MessageBox.Show("Cannot have Width Below 256");
                output = false;
            }

            if(!int.TryParse(heightValueTextBox.Text, out ParsedText))
            {
                output = false;
            }
            if (ParsedText < 256)
            {
                MessageBox.Show("Cannot have Height Below 256");
                output = false;
            }

            if (!int.TryParse(redLowTextBox.Text, out ParsedText))
            {
                output = false;
            }

            if (!int.TryParse(redHighTextBox.Text, out ParsedText))
            {
                output = false;
            }

            if (!int.TryParse(greenLowTextBox.Text, out ParsedText))
            {
                output = false;
            }

            if (!int.TryParse(greenHighTextBox.Text, out ParsedText))
            {
                output = false;
            }
            if (!int.TryParse(blueLowTextBox.Text, out ParsedText))
            {
                output = false;
            }
            if (!int.TryParse(blueHighTextBox.Text, out ParsedText))
            {
                output = false;
            }


            return output;
        }

        private void ParseTextBoxes()
        {
            imageWidth = int.Parse(widthValueTextBox.Text);
            imageHeight = int.Parse(heightValueTextBox.Text);
            redLow = int.Parse(redLowTextBox.Text);
            redHigh = int.Parse(redHighTextBox.Text);
            greenLow = int.Parse(greenLowTextBox.Text);
            greenHigh = int.Parse(greenHighTextBox.Text);
            blueLow = int.Parse(blueLowTextBox.Text);
            blueHigh = int.Parse(blueHighTextBox.Text);
        }

        private Image GetBitmap(byte[] bitmapArray)
        {
            using (MemoryStream stream = new MemoryStream(bitmapArray))
            {
                return Image.FromStream(stream);
            }
        }

        private byte[] CreateBitmap()
        {
            BitmapCreator bitmapCreator = new BitmapCreator(imageWidth, imageHeight);

            //return bitmapCreator.GenerateEightBitVerticalGradiant(redLow, redHigh, greenLow, greenHigh, blueLow, blueHigh);
            return bitmapCreator.GenerateTenBitVerticalGradient(redLow, redHigh, greenLow, greenHigh, blueLow, blueHigh, 255, 255);

        }

    }
}
