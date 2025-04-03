namespace Giocodellanno
{
    partial class bicipiti
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(40, 75);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(337, 23);
            button1.TabIndex = 0;
            button1.Text = "Curl con manubri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(41, 137);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(336, 23);
            button2.TabIndex = 1;
            button2.Text = "Curl con bilanciere (o barra EZ)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(41, 203);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(336, 23);
            button3.TabIndex = 2;
            button3.Text = "Curl a martello (Hammer Curl)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(40, 269);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(336, 23);
            button4.TabIndex = 3;
            button4.Text = "Curl concentrato";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(45, 341);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(332, 23);
            button5.TabIndex = 4;
            button5.Text = "Curl con cavo (Cable Curl)";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(571, 75);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(76, 72);
            button6.TabIndex = 5;
            button6.Text = " apri DIARIO";
            button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1f4aa;
            pictureBox1.Location = new System.Drawing.Point(459, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(224, 207);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // bicipiti
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(714, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "bicipiti";
            Text = "bicipiti";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}