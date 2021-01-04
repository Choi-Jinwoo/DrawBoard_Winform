
namespace DrawingBoard.View
{
    partial class BoardView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnBoard = new System.Windows.Forms.Panel();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.tbPenThickness = new System.Windows.Forms.TrackBar();
            this.lbColorPicker = new System.Windows.Forms.Label();
            this.lbThickness = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.PictureBox();
            this.btnEraser = new System.Windows.Forms.PictureBox();
            this.btnRect = new System.Windows.Forms.PictureBox();
            this.btnText = new System.Windows.Forms.PictureBox();
            this.btnPen = new System.Windows.Forms.PictureBox();
            this.pbClear = new System.Windows.Forms.PictureBox();
            this.pbColorPicker = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbPenThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBoard
            // 
            this.pnBoard.BackColor = System.Drawing.Color.White;
            this.pnBoard.Location = new System.Drawing.Point(150, 0);
            this.pnBoard.Name = "pnBoard";
            this.pnBoard.Size = new System.Drawing.Size(650, 450);
            this.pnBoard.TabIndex = 0;
            this.pnBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnBoard_MouseDown);
            this.pnBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnBoard_MouseMove);
            this.pnBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnBoard_MouseUp);
            // 
            // tbPenThickness
            // 
            this.tbPenThickness.Location = new System.Drawing.Point(8, 112);
            this.tbPenThickness.Name = "tbPenThickness";
            this.tbPenThickness.Size = new System.Drawing.Size(132, 56);
            this.tbPenThickness.TabIndex = 2;
            this.tbPenThickness.Scroll += new System.EventHandler(this.tbPenThickness_Scroll);
            // 
            // lbColorPicker
            // 
            this.lbColorPicker.AutoSize = true;
            this.lbColorPicker.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbColorPicker.Location = new System.Drawing.Point(44, 9);
            this.lbColorPicker.Name = "lbColorPicker";
            this.lbColorPicker.Size = new System.Drawing.Size(54, 20);
            this.lbColorPicker.TabIndex = 3;
            this.lbColorPicker.Text = "색상표";
            // 
            // lbThickness
            // 
            this.lbThickness.AutoSize = true;
            this.lbThickness.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbThickness.Location = new System.Drawing.Point(49, 92);
            this.lbThickness.Name = "lbThickness";
            this.lbThickness.Size = new System.Drawing.Size(39, 20);
            this.lbThickness.TabIndex = 4;
            this.lbThickness.Text = "굵기";
            // 
            // btnImage
            // 
            this.btnImage.Image = global::DrawingBoard.Properties.Resources.free_icon_image_gallery_3342137;
            this.btnImage.Location = new System.Drawing.Point(12, 256);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(56, 32);
            this.btnImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnImage.TabIndex = 14;
            this.btnImage.TabStop = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Image = global::DrawingBoard.Properties.Resources.free_icon_eraser_2607889;
            this.btnEraser.Location = new System.Drawing.Point(74, 188);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(65, 28);
            this.btnEraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEraser.TabIndex = 13;
            this.btnEraser.TabStop = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnRect
            // 
            this.btnRect.Image = global::DrawingBoard.Properties.Resources.free_icon_stop_square_filled_button_57066;
            this.btnRect.Location = new System.Drawing.Point(9, 225);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(62, 25);
            this.btnRect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRect.TabIndex = 12;
            this.btnRect.TabStop = false;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnText
            // 
            this.btnText.Image = global::DrawingBoard.Properties.Resources.text;
            this.btnText.Location = new System.Drawing.Point(78, 220);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(51, 31);
            this.btnText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnText.TabIndex = 11;
            this.btnText.TabStop = false;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnPen
            // 
            this.btnPen.Image = global::DrawingBoard.Properties.Resources.pen;
            this.btnPen.Location = new System.Drawing.Point(8, 188);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(63, 25);
            this.btnPen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPen.TabIndex = 9;
            this.btnPen.TabStop = false;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // pbClear
            // 
            this.pbClear.Image = global::DrawingBoard.Properties.Resources.clear;
            this.pbClear.Location = new System.Drawing.Point(117, 411);
            this.pbClear.Name = "pbClear";
            this.pbClear.Size = new System.Drawing.Size(23, 23);
            this.pbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClear.TabIndex = 5;
            this.pbClear.TabStop = false;
            this.pbClear.Click += new System.EventHandler(this.pbClear_Click);
            // 
            // pbColorPicker
            // 
            this.pbColorPicker.Image = global::DrawingBoard.Properties.Resources.color_palette;
            this.pbColorPicker.Location = new System.Drawing.Point(44, 30);
            this.pbColorPicker.Name = "pbColorPicker";
            this.pbColorPicker.Size = new System.Drawing.Size(54, 33);
            this.pbColorPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbColorPicker.TabIndex = 1;
            this.pbColorPicker.TabStop = false;
            this.pbColorPicker.Click += new System.EventHandler(this.pbColorPicker_Click);
            // 
            // BoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnEraser);
            this.Controls.Add(this.btnRect);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnPen);
            this.Controls.Add(this.pbClear);
            this.Controls.Add(this.lbThickness);
            this.Controls.Add(this.lbColorPicker);
            this.Controls.Add(this.pbColorPicker);
            this.Controls.Add(this.pnBoard);
            this.Controls.Add(this.tbPenThickness);
            this.Name = "BoardView";
            this.Text = "BoardView";
            ((System.ComponentModel.ISupportInitialize)(this.tbPenThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBoard;
        private System.Windows.Forms.PictureBox pbColorPicker;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.TrackBar tbPenThickness;
        private System.Windows.Forms.Label lbColorPicker;
        private System.Windows.Forms.Label lbThickness;
        private System.Windows.Forms.PictureBox pbClear;
        private System.Windows.Forms.PictureBox btnPen;
        private System.Windows.Forms.PictureBox btnText;
        private System.Windows.Forms.PictureBox btnRect;
        private System.Windows.Forms.PictureBox btnEraser;
        private System.Windows.Forms.PictureBox btnImage;
    }
}