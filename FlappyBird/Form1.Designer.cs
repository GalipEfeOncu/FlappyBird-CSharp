namespace FlappyBird
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
            this.components = new System.ComponentModel.Container();
            this.pictureBird = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBird
            // 
            this.pictureBird.BackColor = System.Drawing.Color.Transparent;
            this.pictureBird.Image = global::FlappyBird.Properties.Resources.yellowbird_midflap;
            this.pictureBird.Location = new System.Drawing.Point(236, 198);
            this.pictureBird.Name = "pictureBird";
            this.pictureBird.Size = new System.Drawing.Size(68, 48);
            this.pictureBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBird.TabIndex = 0;
            this.pictureBird.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 5;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pictureGround
            // 
            this.pictureGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureGround.Image = global::FlappyBird.Properties.Resources._base;
            this.pictureGround.Location = new System.Drawing.Point(0, 489);
            this.pictureGround.Name = "pictureGround";
            this.pictureGround.Size = new System.Drawing.Size(1014, 125);
            this.pictureGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGround.TabIndex = 1;
            this.pictureGround.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1014, 614);
            this.Controls.Add(this.pictureGround);
            this.Controls.Add(this.pictureBird);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBird;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureGround;
    }
}

