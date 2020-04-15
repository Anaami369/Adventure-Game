namespace Adventure_Game
{
    partial class AdventureGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdventureGame));
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.redButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.Color.Transparent;
            this.blueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.Color.White;
            this.blueLabel.Location = new System.Drawing.Point(81, 310);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(707, 50);
            this.blueLabel.TabIndex = 3;
            this.blueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Transparent;
            this.redLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.redLabel.ForeColor = System.Drawing.Color.White;
            this.redLabel.Location = new System.Drawing.Point(84, 383);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(704, 50);
            this.redLabel.TabIndex = 4;
            this.redLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(371, 298);
            this.outputLabel.TabIndex = 5;
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Transparent;
            this.redButton.BackgroundImage = global::Adventure_Game.Properties.Resources.red_button;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.Image = global::Adventure_Game.Properties.Resources.red_button;
            this.redButton.Location = new System.Drawing.Point(15, 383);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(60, 60);
            this.redButton.TabIndex = 2;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Transparent;
            this.blueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueButton.Image = global::Adventure_Game.Properties.Resources.blue_button;
            this.blueButton.Location = new System.Drawing.Point(15, 310);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(60, 60);
            this.blueButton.TabIndex = 1;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Adventure_Game.Properties.Resources.river_bank;
            this.pictureBox.Location = new System.Drawing.Point(396, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(392, 295);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // AdventureGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdventureGame";
            this.Text = "Adventure Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

