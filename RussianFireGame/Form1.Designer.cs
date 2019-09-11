namespace RussianFireGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShotAwayButton = new System.Windows.Forms.Button();
            this.FireButton = new System.Windows.Forms.Button();
            this.SpinButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playMoreButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(352, 220);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(108, 53);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ShotAwayButton);
            this.groupBox1.Controls.Add(this.FireButton);
            this.groupBox1.Controls.Add(this.SpinButton);
            this.groupBox1.Controls.Add(this.LoadButton);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(170, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 434);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // ShotAwayButton
            // 
            this.ShotAwayButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShotAwayButton.Location = new System.Drawing.Point(228, 375);
            this.ShotAwayButton.Name = "ShotAwayButton";
            this.ShotAwayButton.Size = new System.Drawing.Size(125, 37);
            this.ShotAwayButton.TabIndex = 4;
            this.ShotAwayButton.Text = "ShootAway";
            this.ShotAwayButton.UseVisualStyleBackColor = true;
            this.ShotAwayButton.Click += new System.EventHandler(this.ShotAwayButton_Click);
            // 
            // FireButton
            // 
            this.FireButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FireButton.Location = new System.Drawing.Point(122, 375);
            this.FireButton.Name = "FireButton";
            this.FireButton.Size = new System.Drawing.Size(87, 37);
            this.FireButton.TabIndex = 3;
            this.FireButton.Text = "Shoot";
            this.FireButton.UseVisualStyleBackColor = true;
            this.FireButton.Click += new System.EventHandler(this.FireButton_Click);
            // 
            // SpinButton
            // 
            this.SpinButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinButton.Location = new System.Drawing.Point(228, 328);
            this.SpinButton.Name = "SpinButton";
            this.SpinButton.Size = new System.Drawing.Size(91, 41);
            this.SpinButton.TabIndex = 2;
            this.SpinButton.Text = "Spin";
            this.SpinButton.UseVisualStyleBackColor = true;
            this.SpinButton.Click += new System.EventHandler(this.SpinButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Location = new System.Drawing.Point(122, 328);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(87, 41);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // playMoreButton
            // 
            this.playMoreButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playMoreButton.Location = new System.Drawing.Point(8, 347);
            this.playMoreButton.Name = "playMoreButton";
            this.playMoreButton.Size = new System.Drawing.Size(103, 69);
            this.playMoreButton.TabIndex = 5;
            this.playMoreButton.Text = "PlayMore";
            this.playMoreButton.UseVisualStyleBackColor = true;
            this.playMoreButton.Visible = false;
            this.playMoreButton.Click += new System.EventHandler(this.playMoreButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playMoreButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SpinButton;
        private System.Windows.Forms.Button ShotAwayButton;
        private System.Windows.Forms.Button FireButton;
        private System.Windows.Forms.Button playMoreButton;
    }
}

