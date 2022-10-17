
namespace GraphicsLab2
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
            this.firstBtn = new System.Windows.Forms.Button();
            this.secondBtn = new System.Windows.Forms.Button();
            this.thirdBtn = new System.Windows.Forms.Button();
            this.fourthImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(286, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // firstBtn
            // 
            this.firstBtn.Location = new System.Drawing.Point(13, 13);
            this.firstBtn.Name = "firstBtn";
            this.firstBtn.Size = new System.Drawing.Size(256, 77);
            this.firstBtn.TabIndex = 1;
            this.firstBtn.Text = "First Img";
            this.firstBtn.UseVisualStyleBackColor = true;
            this.firstBtn.Click += new System.EventHandler(this.firstBtn_Click);
            // 
            // secondBtn
            // 
            this.secondBtn.Location = new System.Drawing.Point(13, 96);
            this.secondBtn.Name = "secondBtn";
            this.secondBtn.Size = new System.Drawing.Size(256, 77);
            this.secondBtn.TabIndex = 2;
            this.secondBtn.Text = "Second Img";
            this.secondBtn.UseVisualStyleBackColor = true;
            this.secondBtn.Click += new System.EventHandler(this.secondBtn_Click);
            // 
            // thirdBtn
            // 
            this.thirdBtn.Location = new System.Drawing.Point(12, 179);
            this.thirdBtn.Name = "thirdBtn";
            this.thirdBtn.Size = new System.Drawing.Size(256, 77);
            this.thirdBtn.TabIndex = 3;
            this.thirdBtn.Text = "Third Img";
            this.thirdBtn.UseVisualStyleBackColor = true;
            this.thirdBtn.Click += new System.EventHandler(this.thirdBtn_Click);
            // 
            // fourthImg
            // 
            this.fourthImg.Location = new System.Drawing.Point(12, 262);
            this.fourthImg.Name = "fourthImg";
            this.fourthImg.Size = new System.Drawing.Size(256, 77);
            this.fourthImg.TabIndex = 4;
            this.fourthImg.Text = "Fourth Img";
            this.fourthImg.UseVisualStyleBackColor = true;
            this.fourthImg.Click += new System.EventHandler(this.fourthImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 500);
            this.Controls.Add(this.fourthImg);
            this.Controls.Add(this.thirdBtn);
            this.Controls.Add(this.secondBtn);
            this.Controls.Add(this.firstBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button firstBtn;
        private System.Windows.Forms.Button secondBtn;
        private System.Windows.Forms.Button thirdBtn;
        private System.Windows.Forms.Button fourthImg;
    }
}

