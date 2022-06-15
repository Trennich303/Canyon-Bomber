using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        List<Bombs1> bombs = new List<Bombs1>();
        List<Block> blocks = new List<Block>();
        PlayerYellow yellow;
        Size screenSize;

        Bombs1 bomb;
        
        int shotOk = 5;

        bool spacebarDown = false;



        public void InitializeGame()
        {
            // This is where the yellow plane will spawn in
            screenSize = new Size(this.Width, this.Height);

            int x = 50;
            int y = 125;
            
            // Creating the speed of the planes
            yellow = new PlayerYellow(x, y, 3);

            //Block b = new Block(150, 150, 10, Color.Red);
            //blocks.Add(b);  
            LoadLevel(1);
        }

        public void LoadLevel(int level)
        {

            XmlReader reader = XmlReader.Create($"Resources/Level{level}.xml");

            blocks.Clear();
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

                if (x != "" && colour == "gray")
                {
                    blocks.Add(new Block(Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(hp), Color.FromName($"{colour}")));
                }
            }
            reader.Close();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            // Creating the plane 
           // e.Graphics.FillEllipse(Brushes.Yellow, yellow.x, yellow.y, yellow.height, yellow.width);
            e.Graphics.DrawImage(Properties.Resources.bombing_canyons_cropped, yellow.x, yellow.y, yellow.height, yellow.width);
            

            //Drawing each bomb on the screen
            foreach (Bombs1 b in bombs)
            {
                e.Graphics.FillEllipse(Brushes.Yellow, b.x, b.y, b.size, b.size);
            }
            //Drawing each brick to the screen
            foreach (Block b in blocks)
            {
                e.Graphics.FillRectangle(new SolidBrush(b.colour), b.x, b.y, b.width, b.height);
               
            }

            e.Graphics.FillRectangle(Brushes.Gray, 0, this.Height - 125, this.Width, 125);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            
            // Telling the yellow plane to move
            yellow.Move(screenSize);

            //If space bar is down create a yellow bomb

            shotOk--;
            //If the space bar is down and the timer is at 0 then drop a bomb
            if (spacebarDown == true && shotOk <= 0)
            {

                bomb = new Bombs1(yellow.x, yellow.y + 5, 4, 5);
                bombs.Add(bomb);

                shotOk = 50;
            }
            // Telling all bombs on the screen to move
            foreach (Bombs1 b in bombs)
            {
                b.Move(screenSize);
            }
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
            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spacebarDown = true;
                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
