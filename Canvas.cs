using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void createCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            for(int i = 0; i < 36; i += 1)
            {
                PictureBox card = new PictureBox();
                card.Width = 100;
                card.Height = 200;
                card.BackColor = Color.SteelBlue;
                card.Top = rand.Next(400);
                card.Left = rand.Next(800);
                cards.Add(card);
                this.Controls.Add(card);
            }            
        }
    }
}
