namespace Canyon_Bomber
{
    partial class GameOverScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.winLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.scoreYellow = new System.Windows.Forms.Label();
            this.scoreRed = new System.Windows.Forms.Label();
            this.livesYellow = new System.Windows.Forms.Label();
            this.livesRed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Black;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("ROG Fonts", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Orange;
            this.playButton.Location = new System.Drawing.Point(337, 156);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(184, 48);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play Again";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Black;
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("ROG Fonts", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.Orange;
            this.menuButton.Location = new System.Drawing.Point(337, 235);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(184, 48);
            this.menuButton.TabIndex = 2;
            this.menuButton.Text = "Main Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("ROG Fonts", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.Orange;
            this.winLabel.Location = new System.Drawing.Point(259, 25);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(324, 48);
            this.winLabel.TabIndex = 3;
            this.winLabel.Text = "Game Over";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player Yellow";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(592, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lives Remaining:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(593, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Score:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(593, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lives Remaining:";
            // 
            // scoreYellow
            // 
            this.scoreYellow.AutoSize = true;
            this.scoreYellow.BackColor = System.Drawing.Color.Transparent;
            this.scoreYellow.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreYellow.ForeColor = System.Drawing.Color.Black;
            this.scoreYellow.Location = new System.Drawing.Point(128, 185);
            this.scoreYellow.Name = "scoreYellow";
            this.scoreYellow.Size = new System.Drawing.Size(0, 19);
            this.scoreYellow.TabIndex = 10;
            // 
            // scoreRed
            // 
            this.scoreRed.AutoSize = true;
            this.scoreRed.BackColor = System.Drawing.Color.Transparent;
            this.scoreRed.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreRed.ForeColor = System.Drawing.Color.Black;
            this.scoreRed.Location = new System.Drawing.Point(686, 185);
            this.scoreRed.Name = "scoreRed";
            this.scoreRed.Size = new System.Drawing.Size(0, 19);
            this.scoreRed.TabIndex = 11;
            // 
            // livesYellow
            // 
            this.livesYellow.AutoSize = true;
            this.livesYellow.BackColor = System.Drawing.Color.Transparent;
            this.livesYellow.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesYellow.ForeColor = System.Drawing.Color.Black;
            this.livesYellow.Location = new System.Drawing.Point(236, 235);
            this.livesYellow.Name = "livesYellow";
            this.livesYellow.Size = new System.Drawing.Size(0, 19);
            this.livesYellow.TabIndex = 12;
            // 
            // livesRed
            // 
            this.livesRed.AutoSize = true;
            this.livesRed.BackColor = System.Drawing.Color.Transparent;
            this.livesRed.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesRed.ForeColor = System.Drawing.Color.Black;
            this.livesRed.Location = new System.Drawing.Point(794, 251);
            this.livesRed.Name = "livesRed";
            this.livesRed.Size = new System.Drawing.Size(0, 19);
            this.livesRed.TabIndex = 13;
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Canyon_Bomber.Properties.Resources.GameOverCanyonBomber;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.livesRed);
            this.Controls.Add(this.livesYellow);
            this.Controls.Add(this.scoreRed);
            this.Controls.Add(this.scoreYellow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.playButton);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(854, 500);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label scoreYellow;
        private System.Windows.Forms.Label scoreRed;
        private System.Windows.Forms.Label livesYellow;
        private System.Windows.Forms.Label livesRed;
    }
}
