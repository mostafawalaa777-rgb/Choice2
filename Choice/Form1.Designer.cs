namespace Choice
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pb1Boy = new System.Windows.Forms.RadioButton();
            this.Pb2Girl = new System.Windows.Forms.RadioButton();
            this.Pb3Pen = new System.Windows.Forms.RadioButton();
            this.PbBook = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.pictureBox1.Image = global::Choice.Properties.Resources.Book;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(651, 475);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pb1Boy
            // 
            this.Pb1Boy.AutoSize = true;
            this.Pb1Boy.BackColor = System.Drawing.Color.White;
            this.Pb1Boy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pb1Boy.ForeColor = System.Drawing.Color.Maroon;
            this.Pb1Boy.Location = new System.Drawing.Point(309, 540);
            this.Pb1Boy.Name = "Pb1Boy";
            this.Pb1Boy.Size = new System.Drawing.Size(70, 29);
            this.Pb1Boy.TabIndex = 2;
            this.Pb1Boy.TabStop = true;
            this.Pb1Boy.Tag = "Boy";
            this.Pb1Boy.Text = "Boy";
            this.Pb1Boy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pb1Boy.UseVisualStyleBackColor = false;
            this.Pb1Boy.CheckedChanged += new System.EventHandler(this.Boy_CheckedChanged);
            // 
            // Pb2Girl
            // 
            this.Pb2Girl.AutoSize = true;
            this.Pb2Girl.BackColor = System.Drawing.Color.White;
            this.Pb2Girl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pb2Girl.ForeColor = System.Drawing.Color.Maroon;
            this.Pb2Girl.Location = new System.Drawing.Point(437, 540);
            this.Pb2Girl.Name = "Pb2Girl";
            this.Pb2Girl.Size = new System.Drawing.Size(66, 29);
            this.Pb2Girl.TabIndex = 3;
            this.Pb2Girl.TabStop = true;
            this.Pb2Girl.Tag = "Girl";
            this.Pb2Girl.Text = "Girl";
            this.Pb2Girl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pb2Girl.UseVisualStyleBackColor = false;
            this.Pb2Girl.CheckedChanged += new System.EventHandler(this.Pb2Girl_CheckedChanged);
            // 
            // Pb3Pen
            // 
            this.Pb3Pen.AutoSize = true;
            this.Pb3Pen.BackColor = System.Drawing.Color.White;
            this.Pb3Pen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pb3Pen.ForeColor = System.Drawing.Color.Maroon;
            this.Pb3Pen.Location = new System.Drawing.Point(180, 540);
            this.Pb3Pen.Name = "Pb3Pen";
            this.Pb3Pen.Size = new System.Drawing.Size(71, 29);
            this.Pb3Pen.TabIndex = 4;
            this.Pb3Pen.TabStop = true;
            this.Pb3Pen.Tag = "Pen";
            this.Pb3Pen.Text = "Pen";
            this.Pb3Pen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pb3Pen.UseVisualStyleBackColor = false;
            this.Pb3Pen.CheckedChanged += new System.EventHandler(this.Pb3Pen_CheckedChanged);
            // 
            // PbBook
            // 
            this.PbBook.AutoSize = true;
            this.PbBook.BackColor = System.Drawing.Color.White;
            this.PbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbBook.ForeColor = System.Drawing.Color.Maroon;
            this.PbBook.Location = new System.Drawing.Point(40, 540);
            this.PbBook.Name = "PbBook";
            this.PbBook.Size = new System.Drawing.Size(82, 29);
            this.PbBook.TabIndex = 5;
            this.PbBook.TabStop = true;
            this.PbBook.Tag = "Book";
            this.PbBook.Text = "Book";
            this.PbBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PbBook.UseVisualStyleBackColor = false;
            this.PbBook.CheckedChanged += new System.EventHandler(this.PbBook_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.Font = new System.Drawing.Font("Ravie", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Book";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox2.Image = global::Choice.Properties.Resources.Book;
            this.pictureBox2.Location = new System.Drawing.Point(781, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(657, 475);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.Font = new System.Drawing.Font("Ravie", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(789, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Book";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Book",
            "Pen",
            "Boy",
            "Girle"});
            this.comboBox1.Location = new System.Drawing.Point(990, 545);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Ravie", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(788, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "Choice";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 630);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbBook);
            this.Controls.Add(this.Pb3Pen);
            this.Controls.Add(this.Pb2Girl);
            this.Controls.Add(this.Pb1Boy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton Pb1Boy;
        private System.Windows.Forms.RadioButton Pb2Girl;
        private System.Windows.Forms.RadioButton Pb3Pen;
        private System.Windows.Forms.RadioButton PbBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}

