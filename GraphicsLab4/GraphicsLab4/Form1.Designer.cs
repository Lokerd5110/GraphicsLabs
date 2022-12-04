
namespace GraphicsLab4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.squareX = new System.Windows.Forms.TextBox();
            this.squareY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.squareR = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addSquare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.figureCounter = new System.Windows.Forms.Label();
            this.drawOne = new System.Windows.Forms.Button();
            this.drawAll = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.visionR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.visionY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.visionX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Square";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "x:";
            // 
            // squareX
            // 
            this.squareX.Location = new System.Drawing.Point(114, 19);
            this.squareX.Name = "squareX";
            this.squareX.Size = new System.Drawing.Size(30, 20);
            this.squareX.TabIndex = 6;
            // 
            // squareY
            // 
            this.squareY.Location = new System.Drawing.Point(175, 19);
            this.squareY.Name = "squareY";
            this.squareY.Size = new System.Drawing.Size(30, 20);
            this.squareY.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "y:";
            // 
            // squareR
            // 
            this.squareR.Location = new System.Drawing.Point(235, 19);
            this.squareR.Name = "squareR";
            this.squareR.Size = new System.Drawing.Size(30, 20);
            this.squareR.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(213, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "r:";
            // 
            // addSquare
            // 
            this.addSquare.Location = new System.Drawing.Point(271, 17);
            this.addSquare.Name = "addSquare";
            this.addSquare.Size = new System.Drawing.Size(75, 22);
            this.addSquare.TabIndex = 21;
            this.addSquare.Text = "Add";
            this.addSquare.UseVisualStyleBackColor = true;
            this.addSquare.Click += new System.EventHandler(this.addSquare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(374, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Figures added;";
            // 
            // figureCounter
            // 
            this.figureCounter.AutoSize = true;
            this.figureCounter.Location = new System.Drawing.Point(179, 104);
            this.figureCounter.Name = "figureCounter";
            this.figureCounter.Size = new System.Drawing.Size(13, 13);
            this.figureCounter.TabIndex = 26;
            this.figureCounter.Text = "0";
            // 
            // drawOne
            // 
            this.drawOne.Location = new System.Drawing.Point(22, 124);
            this.drawOne.Name = "drawOne";
            this.drawOne.Size = new System.Drawing.Size(150, 52);
            this.drawOne.TabIndex = 27;
            this.drawOne.Text = "Draw One";
            this.drawOne.UseVisualStyleBackColor = true;
            this.drawOne.Click += new System.EventHandler(this.drawOne_Click);
            // 
            // drawAll
            // 
            this.drawAll.Location = new System.Drawing.Point(196, 124);
            this.drawAll.Name = "drawAll";
            this.drawAll.Size = new System.Drawing.Size(150, 52);
            this.drawAll.TabIndex = 28;
            this.drawAll.Text = "Draw All";
            this.drawAll.UseVisualStyleBackColor = true;
            this.drawAll.Click += new System.EventHandler(this.drawAll_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(22, 183);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(324, 52);
            this.clear.TabIndex = 29;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Vision:";
            // 
            // visionR
            // 
            this.visionR.Location = new System.Drawing.Point(235, 50);
            this.visionR.Name = "visionR";
            this.visionR.Size = new System.Drawing.Size(30, 20);
            this.visionR.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "r:";
            // 
            // visionY
            // 
            this.visionY.Location = new System.Drawing.Point(175, 50);
            this.visionY.Name = "visionY";
            this.visionY.Size = new System.Drawing.Size(30, 20);
            this.visionY.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "y:";
            // 
            // visionX
            // 
            this.visionX.Location = new System.Drawing.Point(114, 50);
            this.visionX.Name = "visionX";
            this.visionX.Size = new System.Drawing.Size(30, 20);
            this.visionX.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "x:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.visionR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.visionY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.visionX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.drawAll);
            this.Controls.Add(this.drawOne);
            this.Controls.Add(this.figureCounter);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addSquare);
            this.Controls.Add(this.squareR);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.squareY);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.squareX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox squareX;
        private System.Windows.Forms.TextBox squareY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox squareR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button addSquare;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label figureCounter;
        private System.Windows.Forms.Button drawOne;
        private System.Windows.Forms.Button drawAll;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox visionR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox visionY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox visionX;
        private System.Windows.Forms.Label label6;
    }
}

