
namespace GraphicsLab3
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
            this.label1 = new System.Windows.Forms.Label();
            this.rValue = new System.Windows.Forms.TextBox();
            this.aValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(375, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "R:";
            // 
            // rValue
            // 
            this.rValue.Location = new System.Drawing.Point(76, 21);
            this.rValue.Name = "rValue";
            this.rValue.Size = new System.Drawing.Size(25, 20);
            this.rValue.TabIndex = 2;
            // 
            // aValue
            // 
            this.aValue.Location = new System.Drawing.Point(173, 22);
            this.aValue.Name = "aValue";
            this.aValue.Size = new System.Drawing.Size(25, 20);
            this.aValue.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(148, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "𝛼:";
            // 
            // bValue
            // 
            this.bValue.Location = new System.Drawing.Point(282, 22);
            this.bValue.Name = "bValue";
            this.bValue.Size = new System.Drawing.Size(25, 20);
            this.bValue.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "𝛽:";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(12, 67);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(346, 41);
            this.drawButton.TabIndex = 7;
            this.drawButton.Text = "draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.bValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rValue;
        private System.Windows.Forms.TextBox aValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button drawButton;
    }
}

