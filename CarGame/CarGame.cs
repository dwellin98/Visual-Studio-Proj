using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class CarGame : Form
    {
        public CarGame()
        {
            InitializeComponent();
            Gameoverlbl.Visible = false;
            Restartbtn.Visible = false;



        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            movieline(gamespeed);
            car_speed(gamespeed);
            coin_speed(gamespeed);
            collected_coins();
            game_over();

        }

        int x, y;
        readonly Random r = new Random();


        void movieline(int speed)
        {
            if (pictureBox3.Top >= 500)
            {pictureBox3.Top = 0;}
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }

            if (pictureBox5.Top >= 500)
            { pictureBox5.Top = 0; }
            else { pictureBox5.Top += speed; }

            if (pictureBox5.Top >= 500)
            { pictureBox5.Top = 0; }
            else { pictureBox5.Top += speed; }

            if (pictureBox6.Top >= 500)
            { pictureBox6.Top = 0; }
            else { pictureBox6.Top += speed; }

            if (pictureBox7.Top >= 500)
            { pictureBox7.Top = 0; }
            else { pictureBox7.Top += speed; }
        }
        void game_over()
        {
            if(pictureBox17.Bounds.IntersectsWith(Car1.Bounds) || pictureBox17.Bounds.IntersectsWith(Car2.Bounds) || pictureBox17.Bounds.IntersectsWith(Car3.Bounds))
                {
                timer1.Enabled = false;
                Gameoverlbl.Visible = true;
                Restartbtn.Visible = true;
                    
                  }
        }

        int points = 0;

        //var coins = new List<Label> { coin1, coin2, coin3, coin4 };
        void collected_coins()
        {
            
            List<PictureBox> coins = new List<PictureBox> { coin1, coin2, coin3, coin4, coin5, coin6 };
            foreach (var coin in coins)
            {
                if (pictureBox17.Bounds.IntersectsWith(coin.Bounds)
    
               // pictureBox17.Bounds.IntersectsWith(coin1.Bounds) || pictureBox17.Bounds.IntersectsWith(coin2.Bounds)
               //|| pictureBox17.Bounds.IntersectsWith(coin3.Bounds) || pictureBox17.Bounds.IntersectsWith(coin4.Bounds)
               //|| pictureBox17.Bounds.IntersectsWith(coin5.Bounds) || pictureBox17.Bounds.IntersectsWith(coin6.Bounds)
                    )
                {

                    points +=1;
                    coin.Visible = false;


                }
                Pointslbl.Text = points.ToString();
            }

        }



        void car_speed(int speed)
        {
            if (Car1.Top >= 500)
            { x = r.Next(50,200);
                y = r.Next(0, 0);
                Car1.Location = new Point(x, y);
            }
            else { Car1.Top += speed; }

            if (Car2.Top >= 500)
            {x = r.Next(200, 400);
                y = r.Next(0, 0);
                Car2.Location = new Point(x, y);
            }
            else { Car2.Top += speed; }

            if (Car3.Top >= 500)
            { x = r.Next(200, 400);
                y = r.Next(0, 0);
                Car3.Location = new Point(x, y);
            }
            else { Car3.Top += speed; }
        }
        void coin_speed(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(50, 300);
                y = r.Next(0, 0);
                coin1.Location = new Point(x, y);
                coin1.Visible = true;
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = r.Next(50, 300);
                y = r.Next(0, 0);
                coin2.Location = new Point(x, y);
                coin2.Visible = true;
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = r.Next(50, 300);
                y = r.Next(0, 0);
                coin3.Location = new Point(x, y);
                
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 500)
            {
                x = r.Next(50, 300);
                y = r.Next(0, 0);
                coin4.Location = new Point(x, y);
                coin4.Visible = true;
            }
            else { coin4.Top += speed; }
            if (coin5.Top >= 500)
            {
                x = r.Next(50, 300);
                y = r.Next(0, 0);
                coin5.Location = new Point(x, y);
                coin5.Visible = true;
            }
            else { coin5.Top += speed; }

            if (coin6.Top >= 500)
            {
                x = r.Next(50, 300);
                y = r.Next(0, 0);
                coin6.Location = new Point(x, y);
                coin6.Visible = true;
            }
            else { coin6.Top += speed; }

        }

        private void pictureBox17_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {pictureBox17.Left += -1;}

            if(e.KeyCode== Keys.Right)
            { pictureBox17.Left += 1; }
        }
        int gamespeed = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CarGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                if(pictureBox17.Left>47)
                { pictureBox17.Left += -gamespeed; }

            if (e.KeyCode == Keys.Right)
                if (pictureBox17.Left<350)
                { pictureBox17.Left += gamespeed; }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { gamespeed++; }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 1)
                { gamespeed--; }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void CarGame_Load(object sender, EventArgs e)
        {

        }

        private void Restartbtn_Click(object sender, EventArgs e)
        {

            Application.Restart();
            Restartbtn.Visible = false;
        }
    }
}
