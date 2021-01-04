using DrawingBoard.Enum;
using DrawingBoard.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingBoard.View
{
    public partial class BoardView : Form
    {
        private BoardViewModel boardViewModel;

        public BoardView()
        {
            InitializeComponent();
            boardViewModel = new BoardViewModel(pnBoard);
        }

        private void pnBoard_MouseDown(object sender, MouseEventArgs e)
        {
            boardViewModel.StartDrawing(new Point(e.X, e.Y));
        }

        private void pnBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (boardViewModel.IsDrawing)
            {
                boardViewModel.Draw(new Point(e.X, e.Y));
            }
        }

        private void pnBoard_MouseUp(object sender, MouseEventArgs e)
        {
            boardViewModel.EndDrawing(new Point(e.X, e.Y));
        }

        private void pbColorPicker_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                boardViewModel.SetPenColor(colorPicker.Color);
            }
        }

        private void tbPenThickness_Scroll(object sender, EventArgs e)
        {
            boardViewModel.SetPenThickness((sender as TrackBar).Value);
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            boardViewModel.ClearBoard();
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            boardViewModel.DrawStatus = DrawStatus.RECTANGLE;
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            boardViewModel.DrawStatus = DrawStatus.PEN_DOWN;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            boardViewModel.IsEraser = true;
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.IBeam;
            boardViewModel.DrawStatus = DrawStatus.TEXT;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            boardViewModel.DrawStatus = DrawStatus.IMAGE;
            boardViewModel.LoadImage();
        }
    }
}
