using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianFireGame
{
    public partial class Form1 : Form
    {
        Code codeObject = new Code();
        int shoot = 0,fire=0,scndShoot=0,scndFire=0,count=0;
        public Form1()
        {
            InitializeComponent();
            //starting the game and load the all button 
            //pictureBox1.ImageLocation = "RussianEmpty.jpg";
            pictureBox1.Image = RussianFireGame.Properties.Resources.RussianEmpty;
            fire = codeObject.fire();
            // load the random no in the memory to fire
            scndFire=codeObject.Scndfire();

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //this is the starting button of the game to play the game 
            StartButton.Visible = false;
            //visible the group box to play 
            groupBox1.Visible = true;
        }

        private void playMoreButton_Click(object sender, EventArgs e)
        {
            // this button is used to play one more time the whole game 
            groupBox1.Visible = true;
            //pictureBox1.ImageLocation = "RussianEmpty.jpg";
            pictureBox1.Image = RussianFireGame.Properties.Resources.RussianEmpty;
            //re generate the bullet fire random no in the memory
            fire = codeObject.fire();
            scndFire = codeObject.Scndfire();
            ShotAwayButton.Enabled = true;
            FireButton.Enabled = true;
            playMoreButton.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            //load the first image in thge memory to show th eempty bullet or loading the image
            //pictureBox1.ImageLocation = codeObject.load();
            pictureBox1.Image = RussianFireGame.Properties.Resources.RussianLoad;

        }


        private void SpinButton_Click(object sender, EventArgs e)
        {
            //spin the gun to load the bullet and ready to fire 
            //pictureBox1.ImageLocation = codeObject.Spin();
            pictureBox1.Image = RussianFireGame.Properties.Resources.RussianSpin;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(RussianFireGame.Properties.Resources.fake);
            player.Play();
        }

        private void ShotAwayButton_Click(object sender, EventArgs e)
        {
            //this is use to to play the second event of the game like shoot away 
            scndShoot++;
            //pictureBox1.ImageLocation = codeObject.Shoot();
            pictureBox1.Image = RussianFireGame.Properties.Resources.RussianFire;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(RussianFireGame.Properties.Resources.volume);
            player.Play();

            if (scndShoot == scndFire)
            {
                
               
                count++;
                scndFire = codeObject.Scndfire();
                if (count<1) {
                    MessageBox.Show("you won the game 100 dollars ");
                }
            }
            else {
               
            }
            if (count<1) {
                
                MessageBox.Show("you won 100 dollarss ");
                if (scndShoot == scndFire)
                {
                    MessageBox.Show("you are the winner of this game");
                }
                else {
                    MessageBox.Show("you are the winner");
                }

                groupBox1.Visible = false;
                shoot = 0; fire = 0; scndShoot = 0; scndFire = 0; count = 6;
                playMoreButton.Visible = true;
                ShotAwayButton.Enabled = false;
            }

        }

        private void FireButton_Click(object sender, EventArgs e)
        {
            shoot++;
            //this code is used to  generate the 2 fire and u have only 6 triiger once 

            //pictureBox1.ImageLocation=codeObject.Shoot();
            pictureBox1.Image = RussianFireGame.Properties.Resources.RussianFire;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(RussianFireGame.Properties.Resources.shoot);
            player.Play();


            if (shoot==fire)
            {

               
                //fire = codeObject.fire();
            }
            else {
               
            }
            if (shoot>=6) {
                MessageBox.Show("you losse the game");
                MessageBox.Show("You have one more chance to play click Shoot Away  button");
                //pictureBox1.ImageLocation = "RussianEmpty.jpg";
                pictureBox1.Image = RussianFireGame.Properties.Resources.RussianEmpty;
               
            }
            //MessageBox.Show("" + shoot);
            //after using teh all bullet the fire button will disable automatically now turn to shootaway button to fire 
            FireButton.Enabled = true;

        }
    }
}
