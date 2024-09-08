namespace Carrier
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Extra = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.AI = new System.Windows.Forms.Timer(this.components);
            this.hitbox1 = new System.Windows.Forms.PictureBox();
            this.SSZealous = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Aircraft = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hitbox2 = new System.Windows.Forms.PictureBox();
            this.hitbox3 = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hitbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSZealous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aircraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitbox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Extra
            // 
            this.Extra.Enabled = true;
            this.Extra.Interval = 10;
            this.Extra.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // AI
            // 
            this.AI.Enabled = true;
            this.AI.Interval = 250;
            this.AI.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // hitbox1
            // 
            this.hitbox1.Image = global::Carrier.Properties.Resources.Screenshot_2024_05_09_190715;
            this.hitbox1.Location = new System.Drawing.Point(459, 55);
            this.hitbox1.Name = "hitbox1";
            this.hitbox1.Size = new System.Drawing.Size(15, 14);
            this.hitbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hitbox1.TabIndex = 11;
            this.hitbox1.TabStop = false;
            this.hitbox1.Visible = false;
            this.hitbox1.Click += new System.EventHandler(this.hitbox1_Click);
            // 
            // SSZealous
            // 
            this.SSZealous.Image = global::Carrier.Properties.Resources.USS_Zealous;
            this.SSZealous.Location = new System.Drawing.Point(1603, 937);
            this.SSZealous.Name = "SSZealous";
            this.SSZealous.Size = new System.Drawing.Size(111, 29);
            this.SSZealous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SSZealous.TabIndex = 10;
            this.SSZealous.TabStop = false;
            this.SSZealous.Tag = "SSZealous";
            this.SSZealous.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Carrier.Properties.Resources.Kaga;
            this.pictureBox1.Location = new System.Drawing.Point(249, 544);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Carrier.Properties.Resources.Akrysto;
            this.pictureBox6.Location = new System.Drawing.Point(183, 358);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(131, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.pictureBox6_MouseLeave);
            this.pictureBox6.MouseHover += new System.EventHandler(this.pictureBox6_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Carrier.Properties.Resources.HFS_CVL_Syvaryn;
            this.pictureBox3.Location = new System.Drawing.Point(173, 320);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // Aircraft
            // 
            this.Aircraft.Image = global::Carrier.Properties.Resources.DiveBomberSquadron1;
            this.Aircraft.Location = new System.Drawing.Point(122, 12);
            this.Aircraft.Name = "Aircraft";
            this.Aircraft.Size = new System.Drawing.Size(31, 24);
            this.Aircraft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Aircraft.TabIndex = 4;
            this.Aircraft.TabStop = false;
            this.Aircraft.Visible = false;
            this.Aircraft.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Carrier.Properties.Resources.Novoatoll;
            this.pictureBox8.Location = new System.Drawing.Point(862, 544);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(165, 140);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Carrier.Properties.Resources.target;
            this.pictureBox7.Location = new System.Drawing.Point(61, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(43, 57);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Carrier.Properties.Resources.target;
            this.pictureBox4.Location = new System.Drawing.Point(39, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Carrier.Properties.Resources.target;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // hitbox2
            // 
            this.hitbox2.Image = global::Carrier.Properties.Resources.Screenshot_2024_05_09_190715;
            this.hitbox2.Location = new System.Drawing.Point(512, 55);
            this.hitbox2.Name = "hitbox2";
            this.hitbox2.Size = new System.Drawing.Size(15, 14);
            this.hitbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hitbox2.TabIndex = 12;
            this.hitbox2.TabStop = false;
            this.hitbox2.Visible = false;
            // 
            // hitbox3
            // 
            this.hitbox3.Image = global::Carrier.Properties.Resources.Screenshot_2024_05_09_190715;
            this.hitbox3.Location = new System.Drawing.Point(568, 55);
            this.hitbox3.Name = "hitbox3";
            this.hitbox3.Size = new System.Drawing.Size(15, 14);
            this.hitbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hitbox3.TabIndex = 13;
            this.hitbox3.TabStop = false;
            this.hitbox3.Visible = false;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hitbox3);
            this.Controls.Add(this.hitbox2);
            this.Controls.Add(this.hitbox1);
            this.Controls.Add(this.SSZealous);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Aircraft);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox8);
            this.Name = "Form1";
            this.Text = "dw";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.hitbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSZealous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aircraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitbox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox Aircraft;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer Extra;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox SSZealous;
        private System.Windows.Forms.Timer AI;
        private System.Windows.Forms.PictureBox hitbox1;
        private System.Windows.Forms.PictureBox hitbox2;
        private System.Windows.Forms.PictureBox hitbox3;
        private System.Windows.Forms.Timer timer3;
    }
}

