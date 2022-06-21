using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;


namespace Canyon_Bomber
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();

            InitializeGame();


        }
        //All of these lists are represent the bombs, blocks, and planes
        List<Bombs1> bombs = new List<Bombs1>();
        List<Bombs2> bombs2 = new List<Bombs2>();
        List<Block> blocksGray = new List<Block>();
        List<Block> blocksColours = new List<Block>();
        PlayerYellow yellow;
        PlayerRed red;
        Size screenSize;
        Bombs1 bomb;
        Bombs2 bomb2;
        Block block;
        // All of variables
        int shotOk1 = 5;
        int shotOk2 = 5;
        int counterYellow = 0;
        int counterRed = 0;
        public static int score1 = 0;
        public static int score2 = 0;
        public static int livesYellow = 3;
        public static int livesRed = 3;
        bool spacebarDown = false;
        bool enterkeyDown = false;



        public void InitializeGame()
        {
            // This is where the yellow plane will spawn in
            screenSize = new Size(this.Width, this.Height);

            int x = 50;
            int y = 125;

            // Creating the speed of the planes
            yellow = new PlayerYellow(x, y, 3);

            screenSize = new Size(this.Width, this.Height);

            x = 770;
            y = 150;

            red = new PlayerRed(x, y, -3);
            //Block b = new Block(150, 150, 10, Color.Red);
            //blocks.Add(b);  
            LoadLevel(1);
        }

        public void LoadLevel(int level)
        {

            XmlReader reader = XmlReader.Create($"Resources/Level{level}.xml");

            blocksGray.Clear();
            string x, y, hp, colour;


            while (reader.Read())
            {
                reader.ReadToFollowing("x");
                x = reader.ReadString();

                reader.ReadToFollowing("y");
                y = reader.ReadString();

                reader.ReadToFollowing("hp");
                hp = reader.ReadString();

                reader.ReadToFollowing("colour");
                colour = reader.ReadString();

                if (x != "" && colour == "Gray")
                {
                    blocksGray.Add(new Block(Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(hp), Color.FromName($"{colour}")));
                }
                if (x != "" && colour == "Blue")
                {
                    blocksColours.Add(new Block(Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(hp), Color.FromName($"{colour}")));
                }
                if (x != "" && colour == "HotTrack")
                {
                    blocksColours.Add(new Block(Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(hp), Color.FromName($"{colour}")));
                }
                if (x != "" && colour == "Green")
                {
                    blocksColours.Add(new Block(Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(hp), Color.FromName($"{colour}")));
                }
                if (x != "" && colour == "LimeGreen")
                {
                    blocksColours.Add(new Block(Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(hp), Color.FromName($"{colour}")));
                }



            }
            reader.Close();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            // Creating the plane 
            // e.Graphics.FillEllipse(Brushes.Yellow, yellow.x, yellow.y, yellow.height, yellow.width);
            e.Graphics.DrawImage(Properties.Resources.bombing_canyons_cropped_removebg_preview, yellow.x, yellow.y, yellow.height, yellow.width);

            e.Graphics.DrawImage(Properties.Resources.Red_Bomber1_removebg_preview, red.x, red.y, red.height, red.width);

            //Drawing each bomb on the screen
            foreach (Bombs1 b in bombs)
            {
                e.Graphics.FillEllipse(Brushes.Yellow, b.x, b.y, b.size, b.size);
            }

            foreach (Bombs2 b in bombs2)
            {
                e.Graphics.FillEllipse(Brushes.Red, b.x, b.y, b.size, b.size);
            }
            
            //Drawing each brick to the screen
            foreach (Block b in blocksGray)
            {
                e.Graphics.FillRectangle(new SolidBrush(b.colour), b.x, b.y, b.width, b.height);

            }
            foreach (Block b in blocksColours)
            {
                e.Graphics.FillRectangle(new SolidBrush(b.colour), b.x, b.y, b.width, b.height);

            }

            e.Graphics.FillRectangle(Brushes.Gray, 0, this.Height - 125, this.Width, 125);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            // Telling the yellow plane to move
            yellow.Move(screenSize);

            red.Move(screenSize);
            //If space bar is down create a yellow bomb

            shotOk1--;

            shotOk2--;

            //If the space bar is down and the timer is at 0 then drop a bomb
            if (spacebarDown == true && shotOk1 <= 0)
            {

                bomb = new Bombs1(yellow.x, yellow.y + 5, 2, 5);
                bombs.Add(bomb);

                shotOk1 = 50;
            }

            if (enterkeyDown == true && shotOk2 <= 0)
            {

                bomb2 = new Bombs2(red.x, red.y + 5, -2, 5);
                bombs2.Add(bomb2);

                shotOk2 = 50;
            }

            // Telling all bombs on the screen to move
            foreach (Bombs1 b in bombs)
            {
                b.Move(screenSize);
            }
            
            foreach (Bombs2 b in bombs2)
            {
                b.Move(screenSize);
            }




            foreach (Bombs1 b in bombs)
            {
                foreach (Block bl in blocksColours)
                {
                    if (b.Collision(bl))
                    {
                        blocksColours.Remove(bl);
                        score1++;
                        counterYellow++;
                        break;
                    }
                }

            }

            foreach (Bombs2 b in bombs2)
            {
                foreach (Block bl in blocksColours)
                {
                    if (b.Collision(bl))
                    {
                        blocksColours.Remove(bl);
                        score2++;
                        counterRed++;
                        break;
                    }
                }

            }

            foreach (Bombs1 b in bombs)
            {
                foreach (Block bg in blocksGray)
                {
                    if (b.Collision(bg))
                    {
                        bombs.Remove(b);

                        if (counterYellow == 0)
                        {
                            livesYellow--;


                        }
                        counterYellow = 0;
                        return;
                    }
                }

            }

            foreach (Bombs2 b in bombs2)
            {
                foreach (Block bg in blocksGray)
                {
                    if (b.Collision(bg))
                    {
                        bombs2.Remove(b);

                        if (counterRed == 0)
                        {
                            livesRed--;


                        }
                        counterRed = 0;
                        return;
                    }
                }

            }

            if (livesYellow == 2)
            {
                pictureBox3.Visible = false;
            }
            else if (livesYellow == 1)
            {
                pictureBox2.Visible = false;
            }
            else if (livesYellow == 0)
            {

                Form1.ChangeScreen(this, new GameOverScreen());
                gameTimer.Enabled = false;
            }

            if (livesRed == 2)
            {
                pictureBox6.Visible = false;
            }
            else if (livesRed == 1)
            {
                pictureBox5.Visible = false;
            }
            else if (livesRed == 0)
            {

                Form1.ChangeScreen(this, new GameOverScreen());
                gameTimer.Enabled = false;
            }

            scoreYellow.Text = $"{score1}";
            scoreRed.Text = $"{score2}";




            // Updates the screen
            Refresh();


        }
    

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spacebarDown = false;
                    break;
                case Keys.Enter:
                    enterkeyDown = false;
                    break;
            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spacebarDown = true;
                    break;
                case Keys.Enter:
                    enterkeyDown = true;
                    break;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void button90_Click(object sender, EventArgs e)
        {

        }
    }
}
