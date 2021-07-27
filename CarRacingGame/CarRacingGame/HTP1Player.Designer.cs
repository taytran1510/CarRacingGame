namespace CarRacingGame
{
    partial class HTP1Player
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
            this.PicArrowKey = new System.Windows.Forms.PictureBox();
            this.lbLeft = new System.Windows.Forms.Label();
            this.lbUp = new System.Windows.Forms.Label();
            this.lbRight = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicArrowKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PicArrowKey
            // 
            this.PicArrowKey.Image = global::CarRacingGame.Properties.Resources.arrowkey;
            this.PicArrowKey.Location = new System.Drawing.Point(82, 32);
            this.PicArrowKey.Name = "PicArrowKey";
            this.PicArrowKey.Size = new System.Drawing.Size(175, 93);
            this.PicArrowKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicArrowKey.TabIndex = 0;
            this.PicArrowKey.TabStop = false;
            // 
            // lbLeft
            // 
            this.lbLeft.AutoSize = true;
            this.lbLeft.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeft.ForeColor = System.Drawing.Color.Red;
            this.lbLeft.Location = new System.Drawing.Point(4, 90);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(78, 17);
            this.lbLeft.TabIndex = 1;
            this.lbLeft.Text = "Move Left";
            // 
            // lbUp
            // 
            this.lbUp.AutoSize = true;
            this.lbUp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUp.ForeColor = System.Drawing.Color.Red;
            this.lbUp.Location = new System.Drawing.Point(140, 10);
            this.lbUp.Name = "lbUp";
            this.lbUp.Size = new System.Drawing.Size(71, 17);
            this.lbUp.TabIndex = 2;
            this.lbUp.Text = "Speed Up";
            // 
            // lbRight
            // 
            this.lbRight.AutoSize = true;
            this.lbRight.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRight.ForeColor = System.Drawing.Color.Red;
            this.lbRight.Location = new System.Drawing.Point(261, 90);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(87, 17);
            this.lbRight.TabIndex = 3;
            this.lbRight.Text = "Move Right";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 10);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Korin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "You can speed up but you can\'t slow down";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("VNI-Korin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(38, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Collect coins to increase your points";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("VNI-Korin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(64, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Your points = 1 * gamespeed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("VNI-Korin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(95, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 30);
            this.label8.TabIndex = 30;
            this.label8.Text = "LET\'S RACE!!!";
            // 
            // HTP1Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 311);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbUp);
            this.Controls.Add(this.lbLeft);
            this.Controls.Add(this.PicArrowKey);
            this.Name = "HTP1Player";
            this.Text = "1 Player Mode";
            ((System.ComponentModel.ISupportInitialize)(this.PicArrowKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicArrowKey;
        private System.Windows.Forms.Label lbLeft;
        private System.Windows.Forms.Label lbUp;
        private System.Windows.Forms.Label lbRight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}