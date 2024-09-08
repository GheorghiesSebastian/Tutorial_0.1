using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Carrier
{
    public partial class Form1 : Form
    {
        int Yint;
        int Xint;

        bool Syvaryn = false;
        bool Karan = false;
        bool Akrysto = false;

        bool clicked1 = false;
        bool clicked2 = false;
        bool clicked3 = false;

        int TarXk;
        int TarYk;
        int TarXs;
        int TarYs;
        int TarXa;
        int TarYa;

        bool KarPl;
        bool AkrPl;
        bool SyvaPl;

        int hit;
        public Form1()
        { 
            InitializeComponent();
            KeyPreview = true;

            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox7.Visible = false;

            pictureBox1.BackColor = Color.Transparent;

        }

        class Carrier
        {
            public int speed;
            public int PosX;
            public int PosY;

        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("C:\\Users\\Sebi\\source\\repos\\Carrier\\OSTs\\ost1beginning.wav");
            sp.PlayLooping();

            Bitmap bip1 = new Bitmap(pictureBox1.Image);
            Bitmap bip2 = new Bitmap(pictureBox3.Image);
            Bitmap bip3 = new Bitmap(pictureBox6.Image);
            Bitmap bip4 = new Bitmap(SSZealous.Image);

            // Example color 153, 180, 209

            bip1.MakeTransparent(Color.FromArgb(153, 180, 209));
            bip2.MakeTransparent(Color.FromArgb(153, 180, 209));
            bip3.MakeTransparent(Color.FromArgb(153, 180, 209));
            bip4.MakeTransparent(Color.FromArgb(153, 180, 209));

            pictureBox1.Image = bip1;
            pictureBox3.Image = bip2;
            pictureBox6.Image = bip3;
            SSZealous.Image = bip4;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            KarPl = true;
            SyvaPl = false;
            AkrPl = false;

            clicked1 = true;
            clicked2 = false;
            clicked3 = false;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Visible = true;

            Random CaptainSound = new Random();

            int sound = CaptainSound.Next(0, 6);

            if (sound == 0)
            {

                SoundPlayer spkaga = new SoundPlayer("C:\\Users\\Sebi\\source\\repos\\Carrier\\OSTs\\340151cbf73a4c0eba10a0f07daab1c7.wav");
                Task task1 = Task.Run(() => spkaga.Play());

            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            KarPl = false;
            SyvaPl = true;
            AkrPl = false;

            Syvaryn = true;
            clicked2 = true;
            clicked1 = false;
            clicked3 = false;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Visible = true;
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            KarPl = false;
            SyvaPl = false;
            AkrPl = true;

            Akrysto = true;
            clicked3 = true;
            clicked2 = false;
            clicked1 = false;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox7.Visible = true;
        }




        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox1.Location.X+65, pictureBox1.Location.Y-78);
            pictureBox2.Visible = true;
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Location = new Point(pictureBox3.Location.X + 65, pictureBox3.Location.Y - 78);
            pictureBox4.Visible = true;
        }
        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Location = new Point(pictureBox6.Location.X + 65, pictureBox6.Location.Y - 78);
            pictureBox7.Visible = true;
        }





        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.Visible = false;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.Visible = false;
        }
        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox7.Visible = false;
        }






        public void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Xint = Cursor.Position.X - 91;
            Yint = Cursor.Position.Y - 45;

            if (clicked1 == true)
            {
                TarXk = Xint;
                TarYk = Yint;

                Karan = true;
                hitbox1.Location = new Point(Xint+80, Yint+10);
            }

            if (clicked2 == true)
            {
                TarXs = Xint;
                TarYs = Yint;

                Syvaryn = true;
                hitbox2.Location = new Point(Xint + 80, Yint + 10);
            }

            if (clicked3 == true)
            {
                TarXa = Xint;
                TarYa = Yint;

                Akrysto = true;
                hitbox3.Location = new Point(Xint + 80, Yint + 10);
            }

            clicked1 = false;
            clicked2 = false;
            clicked3 = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Karan == true)
            {
                int speed = 2;

                int dx = TarXk - pictureBox1.Location.X;
                int dy = TarYk - pictureBox1.Location.Y;

                double distance = Math.Sqrt(dx * dx + dy * dy);

                double directionX = dx / distance;
                double directionY = dy / distance;

                int newX = pictureBox1.Location.X + (int)(directionX * speed*2);
                int newY = pictureBox1.Location.Y + (int)(directionY * speed*2);

                pictureBox1.Location = new Point(newX, newY);

                bool overlap = pictureBox1.Bounds.IntersectsWith(hitbox1.Bounds);

                if (overlap == true)
                {
                    Karan = false;
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Syvaryn == true)
            {
                int speed = 2; 

                int dx = TarXs - pictureBox3.Location.X;
                int dy = TarYs - pictureBox3.Location.Y;

                double distance = Math.Sqrt(dx * dx + dy * dy);

                double directionX = dx / distance;
                double directionY = dy / distance;

                int newX = pictureBox3.Location.X + (int)(directionX * speed*2);
                int newY = pictureBox3.Location.Y + (int)(directionY * speed*2);

                pictureBox3.Location = new Point(newX, newY);

                bool overlap = pictureBox3.Bounds.IntersectsWith(hitbox2.Bounds);

                if (overlap == true)
                {

                    Syvaryn = false;
                }
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Akrysto == true)
            {
                int speed = 2;

                int dx = TarXa - pictureBox6.Location.X;
                int dy = TarYa - pictureBox6.Location.Y;

                double distance = Math.Sqrt(dx * dx + dy * dy);

                double directionX = dx / distance;
                double directionY = dy / distance;

                int newX = pictureBox6.Location.X + (int)(directionX * speed * 2);
                int newY = pictureBox6.Location.Y + (int)(directionY * speed * 2);

                pictureBox6.Location = new Point(newX, newY);

                bool overlap = pictureBox6.Bounds.IntersectsWith(hitbox3.Bounds);

                if (overlap == true)
                {

                    Akrysto = false;
                }
            }
        }


  

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.BorderStyle == BorderStyle.FixedSingle)
            {
                pictureBox2.Visible = true;
            }
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Location = new Point(pictureBox1.Location.X + 40, pictureBox1.Location.Y - 78);
            }


            if (pictureBox3.BorderStyle == BorderStyle.FixedSingle)
            {
                pictureBox4.Visible = true;
            }

            if (pictureBox4.Visible == true)
            {
                pictureBox4.Location = new Point(pictureBox3.Location.X + 65, pictureBox3.Location.Y - 78);
            }



            if (pictureBox6.BorderStyle == BorderStyle.FixedSingle)
            {
                pictureBox7.Visible = true;
            }

            if (pictureBox7.Visible == true)
            {
                pictureBox7.Location = new Point(pictureBox6.Location.X + 40, pictureBox6.Location.Y - 78);
            }

            foreach (Control controls in Controls)
            {
                if (controls.Name == "Aircraft2")
                {
                    PictureBox AircraftHitbox = new PictureBox();

                    AircraftHitbox.Visible = false;
                    AircraftHitbox.Location = new Point(controls.Location.X, controls.Location.Y);
                    AircraftHitbox.Size = controls.Size;

                    bool start = true;
                    bool overlapped = SSZealous.Bounds.IntersectsWith(AircraftHitbox.Bounds);
                    if (overlapped == true && start == true)
                    {
                        controls.Name = "Aircraft2end";

                        Random beta = new Random();

                        int lol = beta.Next(2, 3);

                        if (lol == 1)
                        {
                            SSZealous.Visible = false;
                        }
                        if (lol == 2 || lol == 3)
                        {
                            ++hit;
                            if (hit == 1)
                            {
                                SSZealous.ImageLocation = "C:\\Users\\Sebi\\source\\repos\\Carrier\\Resources\\USSZealousHit1.png";
                            }
                            else if (hit == 2)
                            {
                                SSZealous.ImageLocation = "C:\\Users\\Sebi\\source\\repos\\Carrier\\Resources\\USSZealousHit2.png";
                            }
                            else if (hit == 3)
                            {
                                SSZealous.ImageLocation = "C:\\Users\\Sebi\\source\\repos\\Carrier\\Resources\\USSZealousHit3.png";
                            }
                            else if (hit == 4)
                            {
                                SSZealous.ImageLocation = "C:\\Users\\Sebi\\source\\repos\\Carrier\\Resources\\USSZealousList1.png";
                            }
                            else if (hit == 5)
                            {
                                SSZealous.Visible = false;
                            }
                        }
                    }

                }
            }
        }





        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            /* Point point2 = new Point(pictureBox1.Location.X - 80, pictureBox1.Location.Y - 40);
            Point point1 = new Point(Xint = Cursor.Position.X - 91, Yint = Cursor.Position.Y - 45);
            Pen pen = new Pen(Color.DarkRed, 5);
            e.Graphics.DrawLine(pen, point1, point2);*/

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Aircraft.Location = new Point(5000, 5000);
            
        }

        public async void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int Aintx;
            int Ainty;

            bool SyvaPl2 = true;
            bool KarPl2 = true;
            bool AkrPl2 = true;

            if (e.KeyCode == Keys.A)
            {
                Aintx = Cursor.Position.X - 91;
                Ainty = Cursor.Position.Y - 45;

                if (SyvaPl == true || SyvaPl2 == true)
                {
                    PictureBox Aircraft2 = new PictureBox();

                    if (SyvaPl == true)
                    {
                        Aircraft2.Image = Aircraft.Image;
                        Aircraft2.SizeMode = PictureBoxSizeMode.StretchImage;
                        Aircraft2.Name = "Aircraft2";
                        Aircraft2.Visible = true;
                        Aircraft2.Size = new Size(31, 24);
                        Aircraft2.Location = new Point(pictureBox3.Location.X + 40, pictureBox3.Location.Y);
                        Controls.Add(Aircraft2);

                        bool otherlap1 = false;
                        bool otherlap2 = false;

                        if (Aircraft2.Location.X == Aintx)
                        {
                            otherlap1 = true;
                        }
                        if (Aircraft2.Location.Y == Ainty)
                        {
                            otherlap2 = true;
                        }

                        while (otherlap1 == false || otherlap2 == false)
                        {
                            await Task.Delay(100);
                            int speed = 2;

                            int dx = Aintx - Aircraft2.Location.X;
                            int dy = Ainty - Aircraft2.Location.Y;

                            double distance = Math.Sqrt(dx * dx + dy * dy);

                            double directionX = dx / distance;
                            double directionY = dy / distance;

                            int newX = Aircraft2.Location.X + (int)(directionX * speed * 2);
                            int newY = Aircraft2.Location.Y + (int)(directionY * speed * 2);

                            Aircraft2.Location = new Point(newX, newY);
                        }

                    }
                }
                if (KarPl == true || KarPl2 == true)
                {
                    PictureBox Aircraft2 = new PictureBox();

                    if (KarPl == true)
                    {
                        Aircraft2.Image = Aircraft.Image;
                        Aircraft2.SizeMode = PictureBoxSizeMode.StretchImage;
                        Aircraft2.Visible = true;
                        Aircraft2.Name = "Aircraft2";
                        Aircraft2.Size = new Size(31, 24);
                        Aircraft2.Location = new Point(pictureBox1.Location.X + 40, pictureBox1.Location.Y);
                        Controls.Add(Aircraft2);

                        bool otherlap1 = false;
                        bool otherlap2 = false;

                        if (Aircraft2.Location.X == Aintx)
                        {
                            otherlap1 = true;
                        }
                        if (Aircraft2.Location.Y == Ainty)
                        {
                            otherlap2 = true;
                        }

                        while (otherlap1 == false || otherlap2 == false)
                        {
                            await Task.Delay(100);
                            int speed = 2;

                            int dx = Aintx - Aircraft2.Location.X;
                            int dy = Ainty - Aircraft2.Location.Y;

                            double distance = Math.Sqrt(dx * dx + dy * dy);

                            double directionX = dx / distance;
                            double directionY = dy / distance;

                            int newX = Aircraft2.Location.X + (int)(directionX * speed * 2);
                            int newY = Aircraft2.Location.Y + (int)(directionY * speed * 2);

                            Aircraft2.Location = new Point(newX, newY);
                        }
                    }
                }
                        
                if (AkrPl == true || AkrPl2 == true)
                {
                    PictureBox Aircraft2 = new PictureBox();

                    if (AkrPl == true)
                    {
                        Aircraft2.Image = Aircraft.Image;
                        Aircraft2.SizeMode = PictureBoxSizeMode.StretchImage;
                        Aircraft2.Visible = true;
                        Aircraft2.Name = "Aircraft2";
                        Aircraft2.Size = new Size(31, 24);
                        Aircraft2.Location = new Point(pictureBox6.Location.X + 40, pictureBox6.Location.Y);
                        Controls.Add(Aircraft2);

                        bool otherlap1 = false;
                        bool otherlap2 = false;

                        if (Aircraft2.Location.X == Aintx)
                        {
                            otherlap1 = true;
                        }
                        if (Aircraft2.Location.Y == Ainty)
                        {
                            otherlap2 = true;
                        }

                        while (otherlap1 == false || otherlap2 == false)
                        {
                            await Task.Delay(100);
                            int speed = 2;

                            int dx = Aintx - Aircraft2.Location.X;
                            int dy = Ainty - Aircraft2.Location.Y;

                            double distance = Math.Sqrt(dx * dx + dy * dy);

                            double directionX = dx / distance;
                            double directionY = dy / distance;

                            int newX = Aircraft2.Location.X + (int)(directionX * speed * 2);
                            int newY = Aircraft2.Location.Y + (int)(directionY * speed * 2);

                            Aircraft2.Location = new Point(newX, newY);
                        }
                    }
                }
            }

            if (e.KeyCode == Keys.G)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image =  Aircraft.Image;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(31, 25);
                pictureBox.Location = new Point(Cursor.Position.X-20, Cursor.Position.Y-35);
                Controls.Add(pictureBox);
            }
        }

        /*Timer whilez = new Timer();
        whilez.Enabled = true;
        whilez.Interval = 50;*/

        /*private void timer6_Tick(object sender, EventArgs e)
        {
            if (Akrysto == true)
            {
                if (Gammax == true)
                {
                    int firstDecimal = 0;
                    int secondDecimal = 0;
                    int convint;

                    decimal ZetaY = (decimal)W / H;


                    string deci = ZetaY.ToString();

                    string[] deciparts = deci.Split(',');

                    if (deciparts.Length > 1)
                    {
                        if (deciparts[1].Length > 0)
                        {
                            firstDecimal = int.Parse(deciparts[1][0].ToString());
                            if (deciparts[1].Length > 1)
                            {
                                secondDecimal = int.Parse(deciparts[1][1].ToString());
                            }
                        }
                    }

                    convint = W / H;

                    timer6.Interval = 18;
                    timer5.Interval = ((convint * 10 + firstDecimal) * 10 + secondDecimal) * 18 / 100;
                    Gammax = false;
                }
                if (pictureBox6.Location.X != TarXa)
                {
                    if (pictureBox6.Location.X > TarXa)
                    {
                        pictureBox6.Location = new Point(pictureBox6.Location.X-1, pictureBox6.Location.Y);
                    }
                    else if (pictureBox6.Location.X < TarXa)
                    {
                        pictureBox6.Location = new Point(pictureBox6.Location.X+1, pictureBox6.Location.Y);
                    }
                }
            }
        }*/

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (SSZealous.Location.X != 12)
            {
                if (SSZealous.Location.X > 12)
                {
                    SSZealous.Location = new Point(SSZealous.Location.X - 1, SSZealous.Location.Y);
                }
                else if (SSZealous.Location.X < 12)
                {
                    SSZealous.Location = new Point(SSZealous.Location.X + 1, SSZealous.Location.Y);
                }
            }
            if (SSZealous.Location.Y != 12)
            {
                if (SSZealous.Location.Y > 12)
                {
                    SSZealous.Location = new Point(SSZealous.Location.X, SSZealous.Location.Y-1);
                }
                else if (SSZealous.Location.Y < 12)
                {
                    SSZealous.Location = new Point(SSZealous.Location.X, SSZealous.Location.Y+1);
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void hitbox1_Click(object sender, EventArgs e)
        {

        }
    }
}
