namespace CarRacingGame
{
    partial class HowToPlay
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
            this.lbChooseMode = new System.Windows.Forms.Label();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.lbCarRace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbChooseMode
            // 
            this.lbChooseMode.AutoSize = true;
            this.lbChooseMode.Font = new System.Drawing.Font("VNI-Hobo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChooseMode.ForeColor = System.Drawing.Color.Red;
            this.lbChooseMode.Location = new System.Drawing.Point(76, 9);
            this.lbChooseMode.Name = "lbChooseMode";
            this.lbChooseMode.Size = new System.Drawing.Size(200, 37);
            this.lbChooseMode.TabIndex = 0;
            this.lbChooseMode.Text = "CHOOSE MODE";
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPlayer2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer2.Location = new System.Drawing.Point(195, 72);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(133, 61);
            this.btnPlayer2.TabIndex = 3;
            this.btnPlayer2.Text = "2 Player";
            this.btnPlayer2.UseVisualStyleBackColor = false;
            this.btnPlayer2.Click += new System.EventHandler(this.btnPlayer2_Click);
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPlayer1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer1.Location = new System.Drawing.Point(12, 72);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(133, 61);
            this.btnPlayer1.TabIndex = 2;
            this.btnPlayer1.Text = "1 Player";
            this.btnPlayer1.UseVisualStyleBackColor = false;
            this.btnPlayer1.Click += new System.EventHandler(this.btnPlayer1_Click);
            // 
            // lbCarRace
            // 
            this.lbCarRace.AutoSize = true;
            this.lbCarRace.Font = new System.Drawing.Font("VNI-Hobo", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarRace.Location = new System.Drawing.Point(125, 161);
            this.lbCarRace.Name = "lbCarRace";
            this.lbCarRace.Size = new System.Drawing.Size(84, 20);
            this.lbCarRace.TabIndex = 4;
            this.lbCarRace.Text = "Car Racing";
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 191);
            this.Controls.Add(this.lbCarRace);
            this.Controls.Add(this.btnPlayer2);
            this.Controls.Add(this.btnPlayer1);
            this.Controls.Add(this.lbChooseMode);
            this.Name = "HowToPlay";
            this.Text = "How To Play";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChooseMode;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.Label lbCarRace;
    }
}