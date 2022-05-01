
namespace S4ta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ground = new System.Windows.Forms.PictureBox();
            this.hut = new System.Windows.Forms.PictureBox();
            this.tree = new System.Windows.Forms.PictureBox();
            this.moon = new System.Windows.Forms.PictureBox();
            this.sleight = new System.Windows.Forms.PictureBox();
            this.Snowflakes = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snowflakes)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-11, 732);
            this.ground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1053, 292);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // hut
            // 
            this.hut.Image = ((System.Drawing.Image)(resources.GetObject("hut.Image")));
            this.hut.Location = new System.Drawing.Point(721, 575);
            this.hut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hut.Name = "hut";
            this.hut.Size = new System.Drawing.Size(220, 181);
            this.hut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hut.TabIndex = 1;
            this.hut.TabStop = false;
            // 
            // tree
            // 
            this.tree.Image = ((System.Drawing.Image)(resources.GetObject("tree.Image")));
            this.tree.Location = new System.Drawing.Point(349, 655);
            this.tree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(104, 154);
            this.tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree.TabIndex = 2;
            this.tree.TabStop = false;
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(37, 15);
            this.moon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(193, 149);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 3;
            this.moon.TabStop = false;
            // 
            // sleight
            // 
            this.sleight.Image = ((System.Drawing.Image)(resources.GetObject("sleight.Image")));
            this.sleight.Location = new System.Drawing.Point(-11, 682);
            this.sleight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sleight.Name = "sleight";
            this.sleight.Size = new System.Drawing.Size(275, 118);
            this.sleight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sleight.TabIndex = 4;
            this.sleight.TabStop = false;
            // 
            // Snowflakes
            // 
            this.Snowflakes.Image = ((System.Drawing.Image)(resources.GetObject("Snowflakes.Image")));
            this.Snowflakes.Location = new System.Drawing.Point(775, 34);
            this.Snowflakes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Snowflakes.Name = "Snowflakes";
            this.Snowflakes.Size = new System.Drawing.Size(232, 198);
            this.Snowflakes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Snowflakes.TabIndex = 5;
            this.Snowflakes.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(-11, 956);
            this.Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(201, 58);
            this.Score.TabIndex = 6;
            this.Score.Text = "Score: 0";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.SystemColors.HotTrack;
            this.playAgain.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.Location = new System.Drawing.Point(234, 273);
            this.playAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(346, 185);
            this.playAgain.TabIndex = 8;
            this.playAgain.Text = "PLAY AGAIN";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1031, 1010);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Snowflakes);
            this.Controls.Add(this.sleight);
            this.Controls.Add(this.moon);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.hut);
            this.Controls.Add(this.ground);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snowflakes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox hut;
        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.PictureBox sleight;
        private System.Windows.Forms.PictureBox Snowflakes;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button playAgain;
    }
}

