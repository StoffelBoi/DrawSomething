namespace DrawSomething
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
            this.draw = new System.Windows.Forms.PictureBox();
            this.cmdsenden = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cmdcolor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.draw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // draw
            // 
            this.draw.BackColor = System.Drawing.Color.White;
            this.draw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.draw.Location = new System.Drawing.Point(13, 13);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(474, 341);
            this.draw.TabIndex = 0;
            this.draw.TabStop = false;
            // 
            // cmdsenden
            // 
            this.cmdsenden.Location = new System.Drawing.Point(494, 331);
            this.cmdsenden.Name = "cmdsenden";
            this.cmdsenden.Size = new System.Drawing.Size(148, 23);
            this.cmdsenden.TabIndex = 1;
            this.cmdsenden.Text = "Senden";
            this.cmdsenden.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(494, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(494, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(148, 287);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 360);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(173, 45);
            this.trackBar1.TabIndex = 4;
            // 
            // cmdcolor
            // 
            this.cmdcolor.Location = new System.Drawing.Point(192, 361);
            this.cmdcolor.Name = "cmdcolor";
            this.cmdcolor.Size = new System.Drawing.Size(148, 41);
            this.cmdcolor.TabIndex = 5;
            this.cmdcolor.Text = "Farbe auswählen";
            this.cmdcolor.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(346, 360);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 42);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 414);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdcolor);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdsenden);
            this.Controls.Add(this.draw);
            this.Name = "Form1";
            this.Text = "Draw Something";
            ((System.ComponentModel.ISupportInitialize)(this.draw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox draw;
        private System.Windows.Forms.Button cmdsenden;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button cmdcolor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

