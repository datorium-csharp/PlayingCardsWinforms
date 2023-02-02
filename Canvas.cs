using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayingCardsWinforms
{
    public partial class Form1 : Form
    {

        List<PictureBox> cards = new List<PictureBox>();
        Random rand = new Random();
        bool flipped = false;
        bool mouseHold = false;
        int deltaX = 0;
        int deltaY = 0;

        string[] fileNames = null;

        public Form1()
        {
            InitializeComponent();
            InitializeCanvas();
        }

        private void InitializeCanvas()
        {
            this.BackColor = Color.Green;
            this.Text = "Image gallery";
        }


        private string SelectFolder()
        {
            var selectFolderDialog = new FolderBrowserDialog();
            var result = selectFolderDialog.ShowDialog();

            if ( result == DialogResult.OK)
            {
                return selectFolderDialog.SelectedPath;
            }

            return null;
        }


        private void createCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var folderPath = SelectFolder();
            fileNames = Directory.GetFiles(folderPath);

            foreach(var fileName in fileNames)
            {
                var card = new PictureBox();
                card.Width = 100;
                card.Height = 200;

                card.Image = Image.FromFile(fileName);
                card.SizeMode = PictureBoxSizeMode.StretchImage;

                card.Top = rand.Next(400);
                card.Left = rand.Next(800);

                card.MouseDown += Card_MouseDown;
                card.MouseUp += Card_MouseUp;
                card.MouseMove += Card_MouseMove;

                cards.Add(card);
                this.Controls.Add(card);
            }
        }


        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            var card = (PictureBox)sender;
            if (e.Button == MouseButtons.Right)
            {
                card.Left = 400;
                card.Top = 400;
            }
            else if(e.Button == MouseButtons.Left)
            {
                mouseHold = true;                
                deltaX = e.X;
                deltaY = e.Y;
            }
        }

        private void Card_MouseUp(object sender, MouseEventArgs e)
        {
            mouseHold = false;
        }

        private void Card_MouseMove(object sender, MouseEventArgs e)
        {
            if(!mouseHold)
            {
                return;
            }

            var card = (PictureBox)sender;
            card.Left = card.Left + e.X - deltaX;
            card.Top = card.Top + e.Y - deltaY;
        }


        private void actionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flipCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (flipped == false)
            {
                foreach (var card in cards)
                {
                    card.Image = Properties.Resources.card_back_red;
                }
                flipped = true;
            }
            else
            {
                foreach (var card in cards)
                {
                    card.Image = Properties.Resources.queen_of_diamonds2;
                }
                flipped = false;
            }       
        }

        private void deckCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int collumns = 0; collumns < 9; collumns++)
            {
                for (int rows = 0; rows < 4; rows++)
                {
                    cards[count].Left = cards[count].Width + cards[count].Width * collumns;
                    cards[count].Top = cards[count].Height * rows;
                    count++;
                }
            }
        }

        private void stackCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const int SHIFT = 2;
            const int DISPLACEMENT = 50;

            for (int i = 0; i < fileNames.Count(); i++)
            {
                cards[i].Top = i * SHIFT + DISPLACEMENT;
                cards[i].Left= i * SHIFT + DISPLACEMENT; ;
            }
        }

        private void loadCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
    }
}
