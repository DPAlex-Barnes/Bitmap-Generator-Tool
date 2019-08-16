﻿using System;
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
        int bitsPerPixel = 24;
        Screen[] screens;
        List<GeneratedBitmapForm> forms;
        List<byte[]> images = new List<byte[]>();
        List<PictureBox> pictureboxes = new List<PictureBox>();

        public mainForm()
        {
            InitializeComponent();

            widthValueTextBox.Text = Screen.PrimaryScreen.Bounds.Width.ToString();
            heightValueTextBox.Text = Screen.PrimaryScreen.Bounds.Height.ToString();
            screens = Screen.AllScreens;
            pictureboxes.Add(ImportedImageOnePictureBox);
            pictureboxes.Add(ImportedImageTwoPictureBox);
            pictureboxes.Add(ImportedImageThreePictureBox);
            pictureboxes.Add(ImportedImageFourPictureBox);
            pictureboxes.Add(ImportedImageFivePictureBox);
            pictureboxes.Add(ImportedImageSixPictureBox);
            //bppComboBox.Items.Add(24);
            //bppComboBox.Items.Add(32);

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            images = new List<byte[]>();
            foreach(PictureBox picture in pictureboxes)
            {
                picture.Image = null;
            }
            widthValueTextBox.Text = Screen.PrimaryScreen.Bounds.Width.ToString();
            heightValueTextBox.Text = Screen.PrimaryScreen.Bounds.Height.ToString();
            redLowTextBox.Text = "0";
            redHighTextBox.Text = "255";
            greenLowTextBox.Text = "0";
            greenHighTextBox.Text = "255";
            blueLowTextBox.Text = "0";
            blueHighTextBox.Text = "255";
            ImportedImageGroupBox.Visible = false;
            setColourGroupBox.Visible = true;
            
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            if (setColourGroupBox.Visible)
            {
                if (ValidateInput())
                {
                    ParseTextBoxes();
                    
                    byte[] bitmapBytes = CreateBitmap(bitsPerPixel);
                    Image picture = GetImage(bitmapBytes);
                    forms = new List<GeneratedBitmapForm>();

                    for (int i = 0; i < screens.Length; i++)
                    {
                        forms.Add(new GeneratedBitmapForm(picture, imageWidth, imageHeight));
                        //GeneratedBitmapForm bitmapWindow = new GeneratedBitmapForm(picture, imageWidth, imageHeight);
                        forms[i].Location = screens[i].Bounds.Location;
                        forms[i].Show();
                        Console.WriteLine($"Form: {forms[i].Location} ");
                    }
                }
            }
            else if (ImportedImageGroupBox.Visible)
            {
                forms = new List<GeneratedBitmapForm>();

                for (int i = 0; i < images.Count; i++)
                {
                    Image picture = GetImage(images[i]);
                    forms.Add(new GeneratedBitmapForm(picture, picture.Width, picture.Height));
                    //GeneratedBitmapForm bitmapWindow = new GeneratedBitmapForm(picture, imageWidth, imageHeight);
                    forms[i].Location = screens[i].Bounds.Location;
                    forms[i].Show();
                    Console.WriteLine($"Form: {forms[i].Location} ");
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                byte[] bitmapBytes = CreateBitmap(bitsPerPixel);
                               SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter += "Bitmap Files(*.bmp) | *.bmp | All files(*.*) | *.* "; 
                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFile.FileName, bitmapBytes);
                }
            }
        }


        private void ImportImageButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Yes;
            OpenFileDialog image = new OpenFileDialog();
            int count = images.Count;
            do
            {
                if (image.ShowDialog() == DialogResult.OK)
                {
                    byte[] selectedImage = File.ReadAllBytes(image.FileName);
                    images.Add(selectedImage);
                    pictureboxes[count].Image = GetImage(images[count]);

                    setColourGroupBox.Visible = false;
                    ImportedImageGroupBox.Visible = true;
                    
                }

                count++;

                if(count < 6)
                {
                    result = MessageBox.Show("Select Another?", "Open", MessageBoxButtons.YesNo);
                }

            } while (result == DialogResult.Yes && count < 6);
            
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

        private Image GetImage(byte[] bitmapArray)
        {
            using (MemoryStream stream = new MemoryStream(bitmapArray))
            {
                return Image.FromStream(stream);
            }
        }

        private byte[] CreateBitmap(int bits)
        {
            BitmapCreator bitmapCreator = new BitmapCreator(imageWidth, imageHeight);

            if(bits == 24)
            {
                return bitmapCreator.GenerateEightBitVerticalGradiant(redLow, redHigh, greenLow, greenHigh, blueLow, blueHigh);

            }
            else if (bits == 32)
            {
                return bitmapCreator.GenerateTenBitVerticalGradient(redLow, redHigh, greenLow, greenHigh, blueLow, blueHigh, 255, 255);
            }
            else
            {
                return new byte[256];
            }
        }

    }
}
