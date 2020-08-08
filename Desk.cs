using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mime;

namespace Cards
{
    public partial class Desk : Form
    {
        private string folderPath = null;
        private string[] fileNames = null;
        private Random rand = new Random();
        private List<PictureBox> cards = new List<PictureBox>();

        public Desk()
        {
            InitializeComponent();
            InitializeDesk();
        }

        private void InitializeDesk()
        {
            this.BackColor = Color.Green;
        }

        private void LoadCards_Click(object sender, EventArgs e)
        {
            PictureBox filePictureBox = null;

            folderPath = SelectFolder();

            if(folderPath == null)
            {
                return;
            }

            fileNames = Directory.GetFiles(folderPath);

            foreach (var fileName in fileNames)
            {
                filePictureBox = new PictureBox()
                {
                    Height = 100,
                    Width = 70,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Left = rand.Next(0, 400),
                    Top = rand.Next(50, 300),
                    Image = Image.FromFile(fileName)
                };

                filePictureBox.Click += Card_Click;
                this.Controls.Add(filePictureBox);
                cards.Add(filePictureBox);
            }
        }

        private string SelectFolder()
        {
            var selectFolderDialog = new FolderBrowserDialog();
            DialogResult result = selectFolderDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(selectFolderDialog.SelectedPath))
            {
                return selectFolderDialog.SelectedPath;
            }
            return null;
        }

        private void StackCards_Click(object sender, EventArgs e)
        {
            foreach (var card in cards)
            {
                card.Location = new Point(100, 100);
            }
        }

        private void DeckCards_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int x = 1; x < 10; x++)
            {
                for (int y = 1; y < 7; y++)
                {
                    cards[counter].Location = new Point(x * 75, y * 105);
                    counter++;
                }
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            var card = (PictureBox)sender;
            card.Location = new Point(20, 30);
            card.BringToFront();
        }
    }
}
