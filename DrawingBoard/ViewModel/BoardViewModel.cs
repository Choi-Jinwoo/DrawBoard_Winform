using DrawingBoard.Enum;
using DrawingBoard.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingBoard.ViewModel
{
    class BoardViewModel : INotifyPropertyChanged
    {
        public bool IsEraser = false;
        private Control baseControl;
        public Graphics Graphics { get; set; }
        private Pen pen { get; set; } = new Pen(Color.Black);
        private Point prePoint { get; set; }
        private DrawStatus drawStatus { get; set; } = DrawStatus.PEN_DOWN;
        public DrawStatus DrawStatus
        {
            get => drawStatus;
            set
            {
                drawStatus = value;
                OnPropertyChanged("DrawStatus");
            }
        }

        public bool IsDrawing
        {
            get
            {
                return DrawStatus == DrawStatus.PEN_UP;
            }
        }

        private Image currentImage { get; set; }

        public BoardViewModel(Control baseControl)
        {
            this.baseControl = baseControl;
            Graphics = baseControl.CreateGraphics();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public void StartDrawing(Point point)
        {
            prePoint = point;

            if (DrawStatus == DrawStatus.PEN_DOWN)
            {
                DrawStatus = DrawStatus.PEN_UP;    
            }
            else if (DrawStatus == DrawStatus.TEXT)
            {
                TextBox tbDrawText = new TextBox();
                tbDrawText.Location = point;
                tbDrawText.Select();
                tbDrawText.Focus();
                baseControl.Controls.Add(tbDrawText);
                tbDrawText.KeyDown += (object sender, KeyEventArgs e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        string text = tbDrawText.Text;
                        tbDrawText.Dispose();
                        Graphics.DrawString(text, SystemFonts.DefaultFont, pen.Brush, point);
                    }
                    else if (e.KeyCode == Keys.Escape)
                    {
                        tbDrawText.Dispose();
                    }
                };
            }
        }

        public void Draw(Point currPoint)
        {
            Pen drawPen = (Pen)pen.Clone();
            if (IsEraser)
            {
                drawPen.Color = Color.White;
            }

            Graphics.DrawLine(drawPen, prePoint, currPoint);
            prePoint = currPoint;
        }

        public void EndDrawing(Point point)
        {
            if (DrawStatus == DrawStatus.PEN_UP)
            {
                DrawStatus = DrawStatus.PEN_DOWN;
            }
            else if (DrawStatus == DrawStatus.RECTANGLE)
            {
                Graphics.DrawRectangle(pen, createRectangle(prePoint, point));
            }
            else if (DrawStatus == DrawStatus.IMAGE)
            {
                PointSizeModel pointSize = getPointAndSize(point, prePoint);
                Image image = (Image)(new Bitmap(currentImage, pointSize.Size));
                Graphics.DrawImage(image, pointSize.Point);
            }

            if (IsEraser)
            {
                IsEraser = false;
            }
        }

        public void LoadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentImage = Image.FromFile(openFileDialog.FileName);
            }
        }

        public void SetPenColor(Color color)
        {
            pen.Color = color;
        }

        public void SetPenThickness(float thickness)
        {
            pen.Width = thickness;
        }

        public void ClearBoard()
        {
            Graphics.Clear(Color.White);
        }

        private Rectangle createRectangle(Point p1, Point p2)
        {
            PointSizeModel pointSize = getPointAndSize(p1, p2);

            return new Rectangle(pointSize.Point, pointSize.Size);
        }

        private PointSizeModel getPointAndSize(Point p1, Point p2)
        {
            int locationX = Math.Min(p1.X, p2.X);
            int locationY = Math.Min(p1.Y, p2.Y);

            int width = Math.Max(p1.X, p2.X) - locationX;
            int height = Math.Max(p1.Y, p2.Y) - locationY;

            return new PointSizeModel
            {
                Point = new Point(locationX, locationY),
                Size = new Size(width, height),
            };
        }
    }
}
