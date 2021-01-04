
using System.Drawing;
using System.Windows.Forms;

namespace DrawingBoard
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnBoard = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbBlue = new System.Windows.Forms.Label();
            this.nudPenThick = new System.Windows.Forms.NumericUpDown();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbUploadImage = new System.Windows.Forms.PictureBox();
            this.pbEraser = new System.Windows.Forms.PictureBox();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPenThick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUploadImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEraser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBoard
            // 
            this.pnBoard.BackColor = System.Drawing.Color.Beige;
            this.pnBoard.Location = new System.Drawing.Point(96, 27);
            this.pnBoard.Name = "pnBoard";
            this.pnBoard.Size = new System.Drawing.Size(677, 393);
            this.pnBoard.TabIndex = 0;
            this.pnBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onPnBoardMouseDown);
            this.pnBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onPnBoardMouseMove);
            this.pnBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onPnBoardMouseUp);
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.pbSave);
            this.pnMenu.Controls.Add(this.pbUploadImage);
            this.pnMenu.Controls.Add(this.pbEraser);
            this.pnMenu.Controls.Add(this.btnBlue);
            this.pnMenu.Controls.Add(this.btnBlack);
            this.pnMenu.Controls.Add(this.btnWhite);
            this.pnMenu.Controls.Add(this.btnRed);
            this.pnMenu.Controls.Add(this.btnClear);
            this.pnMenu.Controls.Add(this.lbBlue);
            this.pnMenu.Controls.Add(this.nudPenThick);
            this.pnMenu.Location = new System.Drawing.Point(13, 27);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(77, 393);
            this.pnMenu.TabIndex = 1;
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.ForeColor = System.Drawing.Color.White;
            this.btnBlue.Location = new System.Drawing.Point(1, 32);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 23);
            this.btnBlue.TabIndex = 9;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.ForeColor = System.Drawing.Color.White;
            this.btnBlack.Location = new System.Drawing.Point(2, 61);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(75, 23);
            this.btnBlack.TabIndex = 8;
            this.btnBlack.Text = "Black";
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhite.ForeColor = System.Drawing.Color.Black;
            this.btnWhite.Location = new System.Drawing.Point(3, 90);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(75, 23);
            this.btnWhite.TabIndex = 7;
            this.btnWhite.Text = "White";
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.ForeColor = System.Drawing.Color.White;
            this.btnRed.Location = new System.Drawing.Point(2, 3);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 23);
            this.btnRed.TabIndex = 6;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(2, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbBlue
            // 
            this.lbBlue.Location = new System.Drawing.Point(0, 0);
            this.lbBlue.Name = "lbBlue";
            this.lbBlue.Size = new System.Drawing.Size(100, 23);
            this.lbBlue.TabIndex = 10;
            // 
            // nudPenThick
            // 
            this.nudPenThick.AutoSize = true;
            this.nudPenThick.ForeColor = System.Drawing.Color.Black;
            this.nudPenThick.Location = new System.Drawing.Point(14, 131);
            this.nudPenThick.Name = "nudPenThick";
            this.nudPenThick.Size = new System.Drawing.Size(51, 25);
            this.nudPenThick.TabIndex = 3;
            this.nudPenThick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPenThick.ValueChanged += new System.EventHandler(this.nudPenThick_ValueChanged);
            // 
            // pbSave
            // 
            this.pbSave.Image = global::DrawingBoard.Properties.Resources.diskette;
            this.pbSave.Location = new System.Drawing.Point(14, 254);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(51, 29);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSave.TabIndex = 13;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // pbUploadImage
            // 
            this.pbUploadImage.Image = global::DrawingBoard.Properties.Resources.burst;
            this.pbUploadImage.Location = new System.Drawing.Point(3, 209);
            this.pbUploadImage.Name = "pbUploadImage";
            this.pbUploadImage.Size = new System.Drawing.Size(76, 39);
            this.pbUploadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUploadImage.TabIndex = 12;
            this.pbUploadImage.TabStop = false;
            this.pbUploadImage.Click += new System.EventHandler(this.pbUploadImage_Click);
            // 
            // pbEraser
            // 
            this.pbEraser.Image = global::DrawingBoard.Properties.Resources.eraser;
            this.pbEraser.Location = new System.Drawing.Point(24, 162);
            this.pbEraser.Name = "pbEraser";
            this.pbEraser.Size = new System.Drawing.Size(26, 41);
            this.pbEraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEraser.TabIndex = 11;
            this.pbEraser.TabStop = false;
            this.pbEraser.Click += new System.EventHandler(this.pbEraser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnBoard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPenThick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUploadImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEraser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnBoard;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Label lbBlue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown nudPenThick;
        private Button btnRed;
        private Button btnBlue;
        private Button btnBlack;
        private Button btnWhite;
        private PictureBox pbEraser;
        private PictureBox pbUploadImage;
        private PictureBox pbSave;
    }
}

