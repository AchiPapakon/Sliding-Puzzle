using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sliding_Puzzle
{
    public partial class frmMain : Form
    {
        static int backboardSize = 4;
        static int pixels = 2;
        static int tileWidth;
        static System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        static bool isClickable = true;

        public static int GetSize()
        {
            return backboardSize;
        }

        // Create the pictureBoxes:
        static Tile[,] tiles = new Tile[backboardSize, backboardSize];
        // With the `tilesSimpleArray` I just want to create a simple List that will have the
        // references pointing to the original `Tile tiles` line above.
        
        public frmMain()
        {
            InitializeComponent();
            
            createGame(gameState.InitialGame);
        }

        enum gameState
        {
            InitialGame,
            NewGame,
            Restart,
            End
        }

        private void manageTimer(gameState state)
        {
            switch (state)
            {
                case gameState.InitialGame:
                    stopwatch.Start();
                    timerUpdateLabel.Start();
                    break;
                case gameState.NewGame:
                    txtTime.Text = "00:00:00"; // In order to stop the delay.
                    timerUpdateLabel.Stop(); // In order to stop the delay.
                    timerUpdateLabel.Start(); // In order to stop the delay.
                    stopwatch.Restart();
                    break;
                case gameState.Restart:
                    break;
                case gameState.End:
                    timerUpdateLabel.Stop();
                    break;
                default:
                    break;
            }
        }

        private void createGame(gameState state)
        {
            manageTimer(state);
            
            tileWidth = (int)((pnlBackboard.Width - pixels * (backboardSize + 1)) / backboardSize); ;

            for (int i = 0; i < backboardSize; i++) // Rows:
            {
                for (int j = 0; j < backboardSize; j++) // Columns:
                {
                    if (state == gameState.NewGame || state == gameState.Restart)
                    {
                        pnlBackboard.Controls.Remove(tiles[i, j].GetPicture());
                    }
                    int locationLeft = pixels + j * (pixels + tileWidth);
                    int locationTop = pixels + i * (pixels + tileWidth);
                    tiles[i, j] = new Tile(locationLeft, locationTop, i, j, this);
                    pnlBackboard.Controls.Add(tiles[i, j].GetPicture());
                }
            }
            setNeighbours(tiles); // I don't like this line here
        }

        private static bool checkOutOfBoundaries(int x, int y, int max)
        {
            if (x > -1 && x < max && y > -1 && y < max)
                return true;
            else
                return false;
        }

        private static void setNeighbours(Tile[,] in_tiles)
        {
            for (int i = 0; i < backboardSize; i++) // Rows:
            {
                for (int j = 0; j < backboardSize; j++) // Columns:
                {
                    in_tiles[i, j].Neighbour = false;
                    try
                    {
                        // North neighbour:
                        if (checkOutOfBoundaries(Tile.hidden.X - 1, Tile.hidden.Y, backboardSize))
                        {
                            in_tiles[Tile.hidden.X - 1, Tile.hidden.Y].Neighbour = true;
                        }
                        // West neightbour:
                        if (checkOutOfBoundaries(Tile.hidden.X, Tile.hidden.Y - 1, backboardSize))
                        {
                            in_tiles[Tile.hidden.X, Tile.hidden.Y - 1].Neighbour = true;
                        }
                        // East neightbour:
                        if (checkOutOfBoundaries(Tile.hidden.X, Tile.hidden.Y + 1, backboardSize))
                        {
                            in_tiles[Tile.hidden.X, Tile.hidden.Y + 1].Neighbour = true;
                        }
                        // South neightbour:
                        if (checkOutOfBoundaries(Tile.hidden.X + 1, Tile.hidden.Y, backboardSize))
                        {
                            in_tiles[Tile.hidden.X + 1, Tile.hidden.Y].Neighbour = true;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private class Tile : ITile
        {
            // Static variables:
            public static Point hidden; // Which tile is the hidden one?
            private static List<int> shuffledList = Enumerable.Range(0, frmMain.backboardSize * frmMain.backboardSize).Shuffle().ToList();
            private static int count = 0;

            private frmMain frm;
            private PictureBox pic = new PictureBox();
            private Point gridCoords; // i, j. - ie. 2,3
            private bool isNeighbour = false; // Which tiles are the 4-neighbours?
            
            public static void ResetStaticVariables(gameState state)
            {
                if (state == gameState.NewGame)
                {
                    shuffledList = Enumerable.Range(0, frmMain.backboardSize * frmMain.backboardSize).Shuffle().ToList();

                }
                else if (state == gameState.Restart)
                {
                    // Just keep the shuffledList untouched.
                }
                count = 0;
            }

            public bool Neighbour
            {
                set
                {
                    this.isNeighbour = value;
                }
                get
                {
                    return this.isNeighbour;
                }
            }

            public void Initialize()
            {
                pic.Tag = shuffledList[count].ToString();
                count++;

                pic.BackColor = Color.DarkGreen;
                pic.Size = new Size(frmMain.tileWidth, frmMain.tileWidth);
                // The PaintEventHandler is an event that's happening continuously.
                // so, when the "Tag" is changed, the drawing changes as well!
                pic.Paint += new PaintEventHandler((s, e) => pic_Paint(s, e, (string)pic.Tag));
                pic.Click += new EventHandler(swap);

                if (pic.Tag.ToString() == "0")
                {
                    setHidden();
                }
            }

            private void setHidden()
            {
                hidden = new Point(gridCoords.X, gridCoords.Y);
                // Can I do hidden = gridCoords as value and not as reference?

                pic.Visible = false;
            }

            private void swap(object sender, EventArgs e)
            {
                if (isClickable && isNeighbour) // The swap works only in the 4-neighbourhood
                {
                    // Can I do a simple swap of the objects instead of changing all of their properties?
                    tiles[hidden.X, hidden.Y].GetPicture().Visible = true; // Unhide
                    tiles[hidden.X, hidden.Y].GetPicture().Tag = pic.Tag;
                    pic.Tag = "0";
                    setHidden();
                    setNeighbours(tiles);

                    // Check if the puzzle is solved:

                    var currentSequence = new List<int>();
                    for (int i = 0; i < backboardSize; i++)
                    {
                        for (int j = 0; j < backboardSize; j++)
                        {
                            currentSequence.Add(Convert.ToInt32(tiles[i, j].GetPicture().Tag));
                        }
                    }

                    if (currentSequence[0] == 1) // Must begin with '1'
                    {
                        bool won = true;
                        for (int i = 1; i < currentSequence.Count - 1; i++)
                        {
                            if (currentSequence[i] - currentSequence[i - 1] != 1) // Must be a sequence
                            {
                                won = false;
                                break;
                            }
                        }
                        if (won)
                        {
                            isClickable = false;
                            frm.btnRestartGame.Enabled = false;

                            frm.manageTimer(gameState.End);
                            string text = "You have won the match!\n\nTime: " + frm.txtTime.Text;
                            MessageBox.Show(text, "Congratulations!");

                            frmHighScores highScores = new frmHighScores(backboardSize, frm.txtTime.Text);
                            //highScores.records.PotentialTime = frm.txtTime.Text;
                            highScores.ShowDialog();
                        }
                    }
                }
            }

            private void pic_Paint(object sender, PaintEventArgs e, string text)
            {
                using (Font myFont = new Font("Arial", 14, FontStyle.Bold))
                {
                    // Create a StringFormat object with the each line of text, and the block
                    // of text centered on the page.
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(text, myFont, Brushes.White, new Point(frmMain.tileWidth / 2, frmMain.tileWidth / 2), stringFormat);
                }
            }

            public PictureBox GetPicture()
            {
                return pic;
            }

            public Tile(int x, int y, int in_i, int in_j, frmMain frm)
            {
                this.frm = frm;
                pic.Location = new Point(x, y);
                this.gridCoords = new Point(in_i, in_j);

                Initialize();
            }

            //public Tile(byte x, byte y, byte in_i, byte in_j) :
            //    this((int)x, y, in_i, in_j)
            //{
            //
            //}
        }

        interface ITile
        {
            void Initialize();
            PictureBox GetPicture();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            isClickable = true;
            btnRestartGame.Enabled = true;
            Tile.ResetStaticVariables(gameState.NewGame);
            createGame(gameState.NewGame);
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            Tile.ResetStaticVariables(gameState.Restart);
            createGame(gameState.Restart);
        }

        private void timerUpdateLabel_Tick(object sender, EventArgs e)
        {
            // Update every second:
            // Using Math.Round because I don't want to skip 1 second or add 1 extra second.
            double seconds = Math.Round(stopwatch.ElapsedMilliseconds / 1000.0);
            double minutes = Math.Floor(seconds / 60);
            seconds %= 60;
            double hours = Math.Floor(minutes / 60);
            minutes %= 60;

            string text = (hours < 10) ? "0" + hours.ToString() : hours.ToString();
            text += (minutes < 10) ? ":0" + minutes.ToString() : ":" + minutes.ToString();
            text += (seconds < 10) ? ":0" + seconds.ToString() : ":" + seconds.ToString();
            txtTime.Text = text;
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            frmHighScores highScores = new frmHighScores();
            highScores.ShowDialog();
        }
    }
}
