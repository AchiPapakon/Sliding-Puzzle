namespace Sliding_Puzzle
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.pic00 = new System.Windows.Forms.PictureBox();
            this.pnlBackboard = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.timerUpdateLabel = new System.Windows.Forms.Timer(this.components);
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic00)).BeginInit();
            this.pnlBackboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic00
            // 
            this.pic00.BackColor = System.Drawing.Color.Red;
            this.pic00.Location = new System.Drawing.Point(33, 80);
            this.pic00.Name = "pic00";
            this.pic00.Size = new System.Drawing.Size(57, 87);
            this.pic00.TabIndex = 0;
            this.pic00.TabStop = false;
            this.pic00.Visible = false;
            // 
            // pnlBackboard
            // 
            this.pnlBackboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBackboard.Controls.Add(this.pic00);
            this.pnlBackboard.Location = new System.Drawing.Point(147, 50);
            this.pnlBackboard.Name = "pnlBackboard";
            this.pnlBackboard.Size = new System.Drawing.Size(440, 440);
            this.pnlBackboard.TabIndex = 0;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnNewGame.Location = new System.Drawing.Point(613, 440);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(114, 50);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.TabStop = false;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnRestartGame.Location = new System.Drawing.Point(12, 440);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(114, 50);
            this.btnRestartGame.TabIndex = 1;
            this.btnRestartGame.TabStop = false;
            this.btnRestartGame.Text = "Restart";
            this.btnRestartGame.UseVisualStyleBackColor = true;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(278, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time";
            this.label1.Visible = false;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtTime.Location = new System.Drawing.Point(325, 513);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(100, 26);
            this.txtTime.TabIndex = 3;
            this.txtTime.TabStop = false;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerUpdateLabel
            // 
            this.timerUpdateLabel.Interval = 1000;
            this.timerUpdateLabel.Tick += new System.EventHandler(this.timerUpdateLabel_Tick);
            // 
            // btnHighScores
            // 
            this.btnHighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnHighScores.Location = new System.Drawing.Point(613, 50);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(114, 50);
            this.btnHighScores.TabIndex = 0;
            this.btnHighScores.TabStop = false;
            this.btnHighScores.Text = "High Scores";
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnOptions.Location = new System.Drawing.Point(613, 117);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(114, 50);
            this.btnOptions.TabIndex = 4;
            this.btnOptions.TabStop = false;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(739, 567);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pnlBackboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Sliding Puzzle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic00)).EndInit();
            this.pnlBackboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic00;
        private System.Windows.Forms.Panel pnlBackboard;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerUpdateLabel;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnOptions;
    }
}

