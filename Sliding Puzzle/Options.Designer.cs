namespace Sliding_Puzzle
{
    partial class frmOptions
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
            this.grpBoardSize = new System.Windows.Forms.GroupBox();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.radio5 = new System.Windows.Forms.RadioButton();
            this.radio6 = new System.Windows.Forms.RadioButton();
            this.radio7 = new System.Windows.Forms.RadioButton();
            this.grpBoardSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoardSize
            // 
            this.grpBoardSize.Controls.Add(this.radio7);
            this.grpBoardSize.Controls.Add(this.radio6);
            this.grpBoardSize.Controls.Add(this.radio5);
            this.grpBoardSize.Controls.Add(this.radio4);
            this.grpBoardSize.Controls.Add(this.radio3);
            this.grpBoardSize.Controls.Add(this.radio2);
            this.grpBoardSize.Location = new System.Drawing.Point(12, 12);
            this.grpBoardSize.Name = "grpBoardSize";
            this.grpBoardSize.Size = new System.Drawing.Size(255, 123);
            this.grpBoardSize.TabIndex = 0;
            this.grpBoardSize.TabStop = false;
            this.grpBoardSize.Text = "Board Size";
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(20, 30);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(48, 17);
            this.radio2.TabIndex = 0;
            this.radio2.TabStop = true;
            this.radio2.Text = "2 x 2";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(100, 30);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(48, 17);
            this.radio3.TabIndex = 1;
            this.radio3.TabStop = true;
            this.radio3.Text = "3 x 3";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Location = new System.Drawing.Point(190, 30);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(48, 17);
            this.radio4.TabIndex = 2;
            this.radio4.TabStop = true;
            this.radio4.Text = "4 x 4";
            this.radio4.UseVisualStyleBackColor = true;
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.Location = new System.Drawing.Point(20, 85);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(48, 17);
            this.radio5.TabIndex = 3;
            this.radio5.TabStop = true;
            this.radio5.Text = "5 x 5";
            this.radio5.UseVisualStyleBackColor = true;
            // 
            // radio6
            // 
            this.radio6.AutoSize = true;
            this.radio6.Location = new System.Drawing.Point(100, 85);
            this.radio6.Name = "radio6";
            this.radio6.Size = new System.Drawing.Size(48, 17);
            this.radio6.TabIndex = 4;
            this.radio6.TabStop = true;
            this.radio6.Text = "6 x 6";
            this.radio6.UseVisualStyleBackColor = true;
            // 
            // radio7
            // 
            this.radio7.AutoSize = true;
            this.radio7.Location = new System.Drawing.Point(190, 85);
            this.radio7.Name = "radio7";
            this.radio7.Size = new System.Drawing.Size(48, 17);
            this.radio7.TabIndex = 5;
            this.radio7.TabStop = true;
            this.radio7.Text = "7 x 7";
            this.radio7.UseVisualStyleBackColor = true;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 143);
            this.Controls.Add(this.grpBoardSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOptions";
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOptions_FormClosed);
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.grpBoardSize.ResumeLayout(false);
            this.grpBoardSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoardSize;
        private System.Windows.Forms.RadioButton radio7;
        private System.Windows.Forms.RadioButton radio6;
        private System.Windows.Forms.RadioButton radio5;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio2;
    }
}