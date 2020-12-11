/*
88888888ba  88888888ba  88888888888 888888888888 888888888888 88888888888 88           
88      "8b 88      "8b 88               88               ,88 88          88           
88      ,8P 88      ,8P 88               88             ,88"  88          88           
88aaaaaa8P' 88aaaaaa8P' 88aaaaa          88           ,88"    88aaaaa     88           
88""""""8b, 88""""88'   88"""""          88         ,88"      88"""""     88           
88      `8b 88    `8b   88               88       ,88"        88          88           
88      a8P 88     `8b  88               88      88"          88          88           
88888888P"  88      `8b 88888888888      88      888888888888 88888888888 88888888888  
                                                                                       
                                                                                       
                                                                        
  ,ad8888ba,        db        88b            d88 88888888888 ad88888ba
d8"'    `"8b       d88b       888b          d888 88         d8"     "8b
d8'               d8'`8b      88`8b        d8'88 88         Y8,          
88               d8'  `8b     88 `8b     d8' 88 88aaaaa    `Y8aaaaa,    
88      88888   d8YaaaaY8b    88  `8b  d8'   88 88"""""      `"""""8b,  
Y8,        88  d8""""""""8b   88   `8b d8'   88 88                 `8b  
 Y8a.    .a88 d8'        `8b  88    `888'    88 88           Y8a a8P
  `"Y88888P" d8'          `8b 88     `8'     88 88888888888 "Y88888P"   
  */
/*
  ,ad8888ba,   ,ad8888ba,   88888888ba,   88888888888 88888888ba
 d8"'    `"8b d8"'    `"8b  88      `"8b  88          88      "8b
d8'          d8'        `8b 88        `8b 88          88      ,8P      
88           88          88 88         88 88aaaaa     88aaaaaa8P' 888  
88           88          88 88         88 88"""""     88""""88'   888  
Y8,          Y8,        ,8P 88         8P 88          88    `8b
 Y8a.    .a8P Y8a.    .a8P  88      .a8P  88          88     `8b  888  
  `"Y8888Y"'   `"Y8888Y"'   88888888Y"'   88888888888 88      `8b 888  
                                                                       
                                                                       
                                                     
888888888888  , ad8888ba,   88888888ba  88      a8P
         ,88 d8"'    `"8b  88      "8b 88    ,88'    
       ,88" d8'        `8b 88      ,8P 88  ,88"      
     ,88"   88          88 88aaaaaa8P' 88,d88'       
   ,88"     88          88 88""""88'   8888"88,
 ,88"       Y8,        ,8P 88    `8b   88P   Y8b     
88"          Y8a.    .a8P  88     `8b  88     "88,
888888888888  `"Y8888Y"'   88      `8b 88       Y8b  
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SpaceUFO
{
    public partial class SpaceUFO : Form

    {
        // Windows Media player for sounds fx, and music background !
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootgMedia;
        WindowsMediaPlayer explosion;
        WindowsMediaPlayer gameover_sound;
        WindowsMediaPlayer playerexplosion;
        WindowsMediaPlayer buttonbip;

        // Boxes for stars & munitions
        PictureBox[] stars;
        PictureBox[] munitions;
        PictureBox[] enemies;
     // PictureBox[] asteroid;
        PictureBox[] enemiesMunition;
     // PictureBox[] playerExplode;

        // Speed of ... the background, player ship, & munitions going out the ship
        int backgroundspeed;
        int PlayerSpeed;
        int MunitionsSpeed;
        int enemiesSpeed;
        int enemiesMunitionSpeed;

        // Game variable 

        int score;
        int level;
        int difficulty;
        bool pause;
        bool GameIsOver;

        // Random var
        Random rnd;

        public SpaceUFO() //SpaceUFO Constructor
        {
            InitializeComponent();
            // var initialised
            pause = false;
            GameIsOver = false;
            score = 0;
            level = 1;
            difficulty = 9;

            backgroundspeed = 6;
            stars = new PictureBox[15];

            rnd = new Random();
            PlayerSpeed = 4;
            MunitionsSpeed = 20;
            munitions = new PictureBox[3];
            enemiesSpeed = 4;
            enemiesMunitionSpeed = 4;
            StopTimers();
        }

        ~SpaceUFO() // destructor
        {
            score = 0;
            level = 0;
            difficulty = 0;
            backgroundspeed = 0;
            PlayerSpeed = 0;
            MunitionsSpeed = 0;
            enemiesSpeed =0;
            enemiesMunitionSpeed=0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Loads image of the flare getting out the spaceship when press fire
            Image munition = Image.FromFile(@"pics\fire.png");
            Image enemie_One = Image.FromFile("pics\\ships\\spaceShips_001.png");
            Image enemie_Two = Image.FromFile("pics\\ships\\spaceShips_002.png");
            Image enemie_Three = Image.FromFile("pics\\ships\\spaceShips_003.png");
            Image boss_One = Image.FromFile("pics\\ships\\spaceShips_004.png");
            Image boss_Two = Image.FromFile("pics\\ships\\spaceShips_005.png");

          //Image enemie_Explosion = Image.FromFile("");
          //Image player_Explosion = Image.FromFile("pics\\explosion.png");
          //  Image asteroid_One = Image.FromFile("pics\\asteroids\\asteroid_one.png");
           Image asteroid_One = Image.FromFile("pics\\asteroids\\asteroid_anim.gif");
            enemies = new PictureBox[11];

            //playerExplode = new PictureBox[3];
//            asteroid = new PictureBox[3];
/*
            for (int i = 0; i < asteroid.Length; i++)
            {
                asteroid[i] = new PictureBox();
                asteroid[i].Size = new Size(35, 35);
                asteroid[i].SizeMode = PictureBoxSizeMode.Zoom;
                asteroid[i].BorderStyle = BorderStyle.None;
                asteroid[i].BackColor = Color.Transparent;
                this.Controls.Add(asteroid[i]);
                asteroid[i].Location = new Point((i + 1) * 70, -10);
            }
*/
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(35, 35);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].BackColor = Color.Transparent;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i +1) * 70, -50);
            }

            //initialize enemies

            enemies[0].Image = boss_One;
            enemies[1].Image = enemie_One;
            enemies[2].Image = enemie_Two;
            //enemies[3].Image = enemie_Two;
            enemies[3].Image = asteroid_One;
            enemies[4].Image = enemie_Three;
            //enemies[5].Image = enemie_Two;
            enemies[5].Image = asteroid_One;
            enemies[6].Image = enemie_Two;
            enemies[7].Image = enemie_One;
            enemies[8].Image = enemie_Three;
            enemies[9].Image = boss_Two;
            //enemies[9].Image = asteroid_One;  
            //playerExplode[2].Image = player_Explosion;
            //playerExplode[0] = new PictureBox();


            for (int i = 0; i < munitions.Length; i++)
            {
                munitions[i] = new PictureBox();
                munitions[i].Size = new Size(15,15);
                munitions[i].Image = munition;
                munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                munitions[i].BorderStyle = BorderStyle.None;
                munitions[i].BackColor = Color.Transparent;
                this.Controls.Add(munitions[i]);
            }
            // WMP pointer
            gameMedia = new WindowsMediaPlayer();
            shootgMedia = new WindowsMediaPlayer();
            explosion = new WindowsMediaPlayer();
            gameover_sound = new WindowsMediaPlayer();
            playerexplosion = new WindowsMediaPlayer();
            buttonbip = new WindowsMediaPlayer();

            // Load all the effect sound !
            gameMedia.URL = "soundsfx\\GameSong.mp3";
            shootgMedia.URL = "soundsfx\\shot.mp3";
            explosion.URL = "soundsfx\\boom.mp3";
            gameover_sound.URL = "soundsfx\\gameover.wav";
            playerexplosion.URL = "soundsfx\\playerexplosion.mp3";
            buttonbip.URL = "soundsfx\\buttonbip.wav";

            // Setting up sounds
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 7;
            shootgMedia.settings.volume = 1;
            explosion.settings.volume = 6;
            gameover_sound.settings.volume = 20;
            playerexplosion.settings.volume = 15;
            buttonbip.settings.volume = 20;

            // Disable sounds
            gameover_sound.controls.stop();
            playerexplosion.controls.stop();
            shootgMedia.controls.stop();
            explosion.controls.stop();
            buttonbip.controls.stop();

            for ( int i = 0; i <stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 800), rnd.Next(-10, 400));

                if (i%2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stars[i]);
            }

            // enemies munitions

            enemiesMunition = new PictureBox[10];

            for (int i = 0; i < enemiesMunition.Length; i++ )
            {
                enemiesMunition[i] = new PictureBox();
                enemiesMunition[i].Size = new Size(2, 25);
                enemiesMunition[i].Visible = false;
                enemiesMunition[i].BackColor = Color.Red;

                int x = rnd.Next(0, 10);
                enemiesMunition[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 10);
                this.Controls.Add(enemiesMunition[i]);
            }
           
            //gameMedia.controls.play();

        }

        private void Move_Bg_Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i<stars.Length / 2; i++)
            {

                stars[i].Top += backgroundspeed;
                if  (stars[i].Top > this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }

            for (int i = stars.Length /2; i <stars.Length ; i++)
            {
                stars[i].Top += backgroundspeed-2;
                if (stars[i].Top > this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }
      /*
        private void UpdateMoveTimer_Tick(object sender, EventArgs e)
        {

        }
      */  
      private void setParam(int pScore,int pLevel, int pDifficulty)
        {
            score = pScore;
            level = pLevel;
            difficulty = pDifficulty;
        }

      private void RightMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 780)
            {
                Player.Left += PlayerSpeed;
            }
        }

        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10)
            {
                Player.Left -= PlayerSpeed;
            }
        }

        private void DownMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 580)
            {
                Player.Top += PlayerSpeed;
            }
        }

        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 100)
            {
                Player.Top -= PlayerSpeed;
            }
        }

        private void SpaceUFO_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    RightMoveTimer.Start();
                }

                if (e.KeyCode == Keys.Left)
                {
                    LeftMoveTimer.Start();
                }

                if (e.KeyCode == Keys.Down)
                {
                    DownMoveTimer.Start();
                }

                if (e.KeyCode == Keys.Up)
                {
                    UpMoveTimer.Start();
                }
            }

        }

        private void SpaceUFO_KeyUp(object sender, KeyEventArgs e)
        {

            RightMoveTimer.Stop();
            LeftMoveTimer.Stop();  
            DownMoveTimer.Stop();
            UpMoveTimer.Stop();

            if (e.KeyCode == Keys.Escape) // press esc then escape from the game
            {
              Environment.Exit(1);
            }

            if (e.KeyCode == Keys.Space) // Press space to pause
            {
                if (!GameIsOver)
                {
                    if (pause) // pause = false
                    {
                        StartTimers();
                        label.Visible = false;
                        gameMedia.controls.play();
                        pause = false;
                    }

                    else
                    {
                        label.Location = new Point(this.Width / 2 - 60, 250);
                        label.Text = "PAUSE";
                        label.Visible = true;
                        gameMedia.controls.pause();
                        StopTimers();
                        pause = true;
                    }                 
                }
            }

        }

        private void MoveMunitionTimer_Tick(object sender, EventArgs e)
        {
            shootgMedia.controls.play();

            for (int i=0; i < munitions.Length; i++)
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top  -= MunitionsSpeed;

                    Collision();
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            }
        }

        private void MoveEnemiesTimer_Tick(object sender, EventArgs e)
        {
           MoveEnemies(enemies, enemiesSpeed);
        }
        
        private void MoveEnemies(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++ )
            {
                array[i].Visible = true;
                array[i].Top += speed;
                
                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200); 
                }
            }
        }

        private void Collision()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if(munitions[0].Bounds.IntersectsWith(enemies[i].Bounds)
                    || munitions[1].Bounds.IntersectsWith(enemies[i].Bounds)
                    || munitions[2].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.controls.play();
                    //Will put an anim of the explosion of the enemies here !
                    //
                    //
                    // EnemiesExplosionBox.Location = enemies[i].Location;
                    // EnemiesExplosionBox.Visible = true;
                       pictureBox2.Location = enemies[i].Location;
                       pictureBox2.Visible = true;
             
                    score += 1;
                    label_score.Text = (score < 10) ? "0" + score.ToString(): score.ToString();

                    if (score %50 == 0)
                    {
                        level += 1;
                        label_level.Text = (level < 10) ? "0" + level.ToString() : level.ToString();

                        if (enemiesSpeed <= 10 && enemiesMunitionSpeed <= 10 && difficulty >= 0)
                        {
                            difficulty--;
                            enemiesSpeed++;
                            enemiesMunitionSpeed++;
                        }

                        if (level == 100)
                        {
                            GameOver("SUPER  GAMER !");
                        }
                    }
                    enemies[i].Location = new Point((i + 1) * 50, -100);
               
                }

                /*
                if (Player.Bounds.IntersectsWith(asteroid[i].Bounds))
                {
                    explosion.settings.volume = 40;
                    explosion.controls.play();
                    //Will put an anim of the explosion of the player here !
                    //
                    //
                    Player.Visible = false;
                    GameOver("GAME OVER");
                }
                */

                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.settings.volume = 60;
                    explosion.controls.play();
                    //Will put an anim of the explosion of the player here !
                    //
                    //
                    Player.Visible = false;

                    ExplosionBox.Location = enemies[i].Location;
                    ExplosionBox.Visible = true;
                   
                    //label.Location = new Point(this.Width / 2 - 100, 25);
                    
                    GameOver("GAME OVER");
                }
            }
        }

        private void GameOver(string str)
        {
            gameMedia.controls.stop();
            playerexplosion.controls.play();
            gameover_sound.controls.play();
            label.Visible = true;
            label.Text = str.Trim();
            pictureBox2.Visible = false;
            ReplayButton.Visible = true;
            QUITTER.Visible = true;
            //
            Graphics g = this.CreateGraphics();
            // drawing a string
            Font myFont = new Font("Fixedsys", 10);
            g.DrawString("1", myFont, Brushes.Gray, 100, 100);
            // erasing a string
            g.DrawString("1", myFont, Brushes.Black, 100, 100);

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;

            //pause = false;
            //
            //PlayerSpeed = 0;
            //Reset of the game parameters
            PlayerSpeed = 4;
            MunitionsSpeed = 20;
            enemiesSpeed = 4;
            enemiesMunitionSpeed = 4;

            StopTimers();
            RightMoveTimer.Stop();
            LeftMoveTimer.Stop();
            DownMoveTimer.Stop();
            UpMoveTimer.Stop();

        }

        private void StopTimers() //Stop the timers
        {
            MoveBgTimer.Stop();
            MoveEnemiesTimer.Stop();
            MoveMunitionTimer.Stop();
            EnemieMunitionTimer.Stop();
        }

        private void StartTimers() // Start the timers
        {
            MoveBgTimer.Start();
            MoveEnemiesTimer.Start();
            MoveMunitionTimer.Start();
            EnemieMunitionTimer.Start();
        }

        private void EnemieMunitionTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemiesMunition.Length - difficulty; i++)
            {
                if(enemiesMunition[i].Top < this.Height)
                {
                    enemiesMunition[i].Visible = true;
                    enemiesMunition[i].Top += enemiesMunitionSpeed;

                    CollisionWithEnemiesMunitions();
                }
                else
                {
                    enemiesMunition[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    enemiesMunition[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);
                }
            }
        }

        private void CollisionWithEnemiesMunitions()
        {
            for (int i = 0; i < enemiesMunition.Length; i++)
            {
                if (enemiesMunition[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    enemiesMunition[i].Visible = false;
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    Player.Visible = false;

                    ExplosionBox.Location = Player.Location;                
                    ExplosionBox.Visible = true;
                    pictureBox2.Location = enemies[i].Location;
                    pictureBox2.Visible = true;
                    /*
                    float z;
                    for (z = 0.5f; z < 2.0; z++)
                    {
                        ExplosionBox.Scale(z);
                    //  Thread.Sleep(1000);
                       
                    }
                    z++;
                    */
                    //  Thread.Sleep(1000);
                    GameOver("GAME OVER");
                   // Thread.Sleep(1000);
                }
            }

        }

        private void ReplayButton_Click(object sender, EventArgs e)
        {
           
            this.Controls.Clear();
            InitializeComponent();
            buttonbip.controls.play();

            setParam(0, 0, 9);

            BeginButton.Visible = false;
            BeginButton.Enabled = false;
            //pause = false;

            Form1_Load(e, e);
            
        }

        private void QUITTER_Click(object sender, EventArgs e)
        {
             buttonbip.controls.play();
             Thread.Sleep(1500);
             Environment.Exit(1);
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            StartTimers();
            buttonbip.controls.play();
            BeginButton.Visible = false;
            BeginButton.Enabled = false;
            
            //gameMedia.controls.play();
          
            
        }
    }
}
