using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pablo_C_Sharp
{
    public partial class ImageForm : Form
    {
        private static ImageForm instance;

        private ImageForm(string _imagePath, Rectangle _dstRect)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.SetBounds(_dstRect.X, _dstRect.Y, _dstRect.Width, _dstRect.Height);

            try
            {
                Image backimage = Image.FromFile(_imagePath);
                this.pictureBox.Image = backimage;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Nie odnaleziono obrazu!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static ImageForm getInstance(string imagePath, Rectangle destinationRectangle)
        {
            if (instance == null)
            {
                instance = new ImageForm(imagePath, destinationRectangle);
            }
            return instance;
        }

        public void updateImage(string imagePath)
        {
            try
            {
                Image backimage = Image.FromFile(imagePath);
                this.pictureBox.Image = backimage;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Nie odnaleziono obrazu!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
