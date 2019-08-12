using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapGeneratorTool
{
    public partial class GeneratedBitmapForm : Form
    {
        public GeneratedBitmapForm(Image image, int width, int height)
        {
            InitializeComponent();
            GeneratedBitmapPictureBox.Image = image;
            this.Width = width;
            this.Height = height;
        }

        private void GeneratedBitmapForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
