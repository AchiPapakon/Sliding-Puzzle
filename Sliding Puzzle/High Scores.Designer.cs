namespace Sliding_Puzzle
{
    partial class frmHighScores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid2x2 = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblHighScores = new System.Windows.Forms.Label();
            this.lbl2x2 = new System.Windows.Forms.Label();
            this.lbl3x3 = new System.Windows.Forms.Label();
            this.grid3x3 = new System.Windows.Forms.DataGridView();
            this.lbl4x4 = new System.Windows.Forms.Label();
            this.grid4x4 = new System.Windows.Forms.DataGridView();
            this.lbl5x5 = new System.Windows.Forms.Label();
            this.grid5x5 = new System.Windows.Forms.DataGridView();
            this.lbl6x6 = new System.Windows.Forms.Label();
            this.grid6x6 = new System.Windows.Forms.DataGridView();
            this.lbl7x7 = new System.Windows.Forms.Label();
            this.grid7x7 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid2x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid3x3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid4x4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid5x5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid6x6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid7x7)).BeginInit();
            this.SuspendLayout();
            // 
            // grid2x2
            // 
            this.grid2x2.AllowUserToAddRows = false;
            this.grid2x2.AllowUserToDeleteRows = false;
            this.grid2x2.AllowUserToResizeColumns = false;
            this.grid2x2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid2x2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid2x2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid2x2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid2x2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid2x2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2x2.Enabled = false;
            this.grid2x2.Location = new System.Drawing.Point(12, 104);
            this.grid2x2.Name = "grid2x2";
            this.grid2x2.ReadOnly = true;
            this.grid2x2.RowHeadersVisible = false;
            this.grid2x2.Size = new System.Drawing.Size(280, 162);
            this.grid2x2.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnReset.Location = new System.Drawing.Point(356, 530);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(171, 37);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset High Scores";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblHighScores
            // 
            this.lblHighScores.AutoSize = true;
            this.lblHighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblHighScores.Location = new System.Drawing.Point(292, 9);
            this.lblHighScores.Name = "lblHighScores";
            this.lblHighScores.Size = new System.Drawing.Size(286, 55);
            this.lblHighScores.TabIndex = 2;
            this.lblHighScores.Text = "High Scores";
            // 
            // lbl2x2
            // 
            this.lbl2x2.AutoSize = true;
            this.lbl2x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl2x2.Location = new System.Drawing.Point(122, 76);
            this.lbl2x2.Name = "lbl2x2";
            this.lbl2x2.Size = new System.Drawing.Size(59, 25);
            this.lbl2x2.TabIndex = 3;
            this.lbl2x2.Text = "2 x 2";
            // 
            // lbl3x3
            // 
            this.lbl3x3.AutoSize = true;
            this.lbl3x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl3x3.Location = new System.Drawing.Point(408, 76);
            this.lbl3x3.Name = "lbl3x3";
            this.lbl3x3.Size = new System.Drawing.Size(59, 25);
            this.lbl3x3.TabIndex = 5;
            this.lbl3x3.Text = "3 x 3";
            // 
            // grid3x3
            // 
            this.grid3x3.AllowUserToAddRows = false;
            this.grid3x3.AllowUserToDeleteRows = false;
            this.grid3x3.AllowUserToResizeColumns = false;
            this.grid3x3.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid3x3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grid3x3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid3x3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid3x3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid3x3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid3x3.Enabled = false;
            this.grid3x3.Location = new System.Drawing.Point(298, 104);
            this.grid3x3.Name = "grid3x3";
            this.grid3x3.ReadOnly = true;
            this.grid3x3.RowHeadersVisible = false;
            this.grid3x3.Size = new System.Drawing.Size(280, 162);
            this.grid3x3.TabIndex = 4;
            // 
            // lbl4x4
            // 
            this.lbl4x4.AutoSize = true;
            this.lbl4x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl4x4.Location = new System.Drawing.Point(694, 76);
            this.lbl4x4.Name = "lbl4x4";
            this.lbl4x4.Size = new System.Drawing.Size(59, 25);
            this.lbl4x4.TabIndex = 7;
            this.lbl4x4.Text = "4 x 4";
            // 
            // grid4x4
            // 
            this.grid4x4.AllowUserToAddRows = false;
            this.grid4x4.AllowUserToDeleteRows = false;
            this.grid4x4.AllowUserToResizeColumns = false;
            this.grid4x4.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid4x4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid4x4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid4x4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid4x4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid4x4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid4x4.Enabled = false;
            this.grid4x4.Location = new System.Drawing.Point(584, 104);
            this.grid4x4.Name = "grid4x4";
            this.grid4x4.ReadOnly = true;
            this.grid4x4.RowHeadersVisible = false;
            this.grid4x4.Size = new System.Drawing.Size(280, 162);
            this.grid4x4.TabIndex = 6;
            // 
            // lbl5x5
            // 
            this.lbl5x5.AutoSize = true;
            this.lbl5x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl5x5.Location = new System.Drawing.Point(122, 300);
            this.lbl5x5.Name = "lbl5x5";
            this.lbl5x5.Size = new System.Drawing.Size(59, 25);
            this.lbl5x5.TabIndex = 9;
            this.lbl5x5.Text = "5 x 5";
            // 
            // grid5x5
            // 
            this.grid5x5.AllowUserToAddRows = false;
            this.grid5x5.AllowUserToDeleteRows = false;
            this.grid5x5.AllowUserToResizeColumns = false;
            this.grid5x5.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid5x5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grid5x5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid5x5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid5x5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid5x5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid5x5.Enabled = false;
            this.grid5x5.Location = new System.Drawing.Point(12, 328);
            this.grid5x5.Name = "grid5x5";
            this.grid5x5.ReadOnly = true;
            this.grid5x5.RowHeadersVisible = false;
            this.grid5x5.Size = new System.Drawing.Size(280, 162);
            this.grid5x5.TabIndex = 8;
            // 
            // lbl6x6
            // 
            this.lbl6x6.AutoSize = true;
            this.lbl6x6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl6x6.Location = new System.Drawing.Point(408, 300);
            this.lbl6x6.Name = "lbl6x6";
            this.lbl6x6.Size = new System.Drawing.Size(59, 25);
            this.lbl6x6.TabIndex = 11;
            this.lbl6x6.Text = "6 x 6";
            // 
            // grid6x6
            // 
            this.grid6x6.AllowUserToAddRows = false;
            this.grid6x6.AllowUserToDeleteRows = false;
            this.grid6x6.AllowUserToResizeColumns = false;
            this.grid6x6.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid6x6.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grid6x6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid6x6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid6x6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grid6x6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid6x6.Enabled = false;
            this.grid6x6.Location = new System.Drawing.Point(298, 328);
            this.grid6x6.Name = "grid6x6";
            this.grid6x6.ReadOnly = true;
            this.grid6x6.RowHeadersVisible = false;
            this.grid6x6.Size = new System.Drawing.Size(280, 162);
            this.grid6x6.TabIndex = 10;
            // 
            // lbl7x7
            // 
            this.lbl7x7.AutoSize = true;
            this.lbl7x7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl7x7.Location = new System.Drawing.Point(694, 300);
            this.lbl7x7.Name = "lbl7x7";
            this.lbl7x7.Size = new System.Drawing.Size(59, 25);
            this.lbl7x7.TabIndex = 13;
            this.lbl7x7.Text = "7 x 7";
            // 
            // grid7x7
            // 
            this.grid7x7.AllowUserToAddRows = false;
            this.grid7x7.AllowUserToDeleteRows = false;
            this.grid7x7.AllowUserToResizeColumns = false;
            this.grid7x7.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid7x7.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.grid7x7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid7x7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid7x7.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grid7x7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid7x7.Enabled = false;
            this.grid7x7.Location = new System.Drawing.Point(584, 328);
            this.grid7x7.Name = "grid7x7";
            this.grid7x7.ReadOnly = true;
            this.grid7x7.RowHeadersVisible = false;
            this.grid7x7.Size = new System.Drawing.Size(280, 162);
            this.grid7x7.TabIndex = 12;
            // 
            // frmHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 579);
            this.Controls.Add(this.lbl7x7);
            this.Controls.Add(this.grid7x7);
            this.Controls.Add(this.lbl6x6);
            this.Controls.Add(this.grid6x6);
            this.Controls.Add(this.lbl5x5);
            this.Controls.Add(this.grid5x5);
            this.Controls.Add(this.lbl4x4);
            this.Controls.Add(this.grid4x4);
            this.Controls.Add(this.lbl3x3);
            this.Controls.Add(this.grid3x3);
            this.Controls.Add(this.lbl2x2);
            this.Controls.Add(this.lblHighScores);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grid2x2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHighScores";
            this.Load += new System.EventHandler(this.High_Scores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid2x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid3x3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid4x4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid5x5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid6x6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid7x7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid2x2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblHighScores;
        private System.Windows.Forms.Label lbl2x2;
        private System.Windows.Forms.Label lbl3x3;
        private System.Windows.Forms.DataGridView grid3x3;
        private System.Windows.Forms.Label lbl4x4;
        private System.Windows.Forms.DataGridView grid4x4;
        private System.Windows.Forms.Label lbl5x5;
        private System.Windows.Forms.DataGridView grid5x5;
        private System.Windows.Forms.Label lbl6x6;
        private System.Windows.Forms.DataGridView grid6x6;
        private System.Windows.Forms.Label lbl7x7;
        private System.Windows.Forms.DataGridView grid7x7;
    }
}