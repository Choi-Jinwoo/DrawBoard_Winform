using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingBoard
{
    public partial class Form1 : Form
    {
        private readonly Color backgroundColor = Color.Beige;
        private Graphics graphics;
        private int preX;
        private int preY;
        private bool isPenDown = false;
        private Color penColor = Color.Black;
        private decimal penThick;

        public Form1()
        {
            InitializeComponent();
            graphics = pnBoard.CreateGraphics();
        }

        private void onPnBoardMouseDown(object sender, MouseEventArgs e)
        {
            preX = e.X;
            preY = e.Y;
            isPenDown = true;
        }

        private void onPnBoardMouseMove(object sender, MouseEventArgs e)
        {
            if (isPenDown == false) return;

            Pen pen = new Pen(penColor, (float)penThick);
            
            graphics.DrawLine(pen, preX, preY, e.X, e.Y);
            preX = e.X;
            preY = e.Y;
        }

        private void onPnBoardMouseUp(object sender, MouseEventArgs e)
        {
            isPenDown = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(backgroundColor); ;
        }

        private void nudPenThick_ValueChanged(object sender, EventArgs e)
        {
            if (nudPenThick.Value < 1)
            {
                nudPenThick.Value = 1;
            }

            penThick = nudPenThick.Value;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            penColor = Color.Red;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            penColor = Color.Blue;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            penColor = Color.Black;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            penColor = Color.White;
        }

        private void pbEraser_Click(object sender, EventArgs e)
        {
            penColor = backgroundColor;
        }

        private void pbUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pnBoard.BackgroundImage = Image.FromFile(openFileDialog.FileName);
                pnBoard.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void pbSave_Click(object sender, EventArgs e)    
        {
            int width = pnBoard.Size.Width;
            int height= pnBoard.Size.Height;
            Bitmap saveBm = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(saveBm))
            {
                // g.CopyFromScreen(PointToScreen(pnBoard.Location, new Point(0, 0), pnBoard.Size));
            }

            pnBoard.DrawToBitmap(saveBm, new Rectangle(0, 0, width, height));
            saveBm.Save($"D:\\DrawBoard\\{DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss-fff")}.bmp", ImageFormat.Bmp);
        }
    }
}
