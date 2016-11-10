using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PlayAGame : Form
    {
        public PlayAGame()
        {
            InitializeComponent();
        }

        private void circlebutton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main;
            main = new Form1();
            main.Show();
        }

        private void circlebutton1_Click(object sender, EventArgs e)
        {
            this.circlebutton1.Enabled = false;
            this.circlebutton2.Enabled = false;
            this.circlebutton3.Enabled = true;
            this.circlebutton4.Enabled = true;
}

        private void PlayAGame_Load(object sender, EventArgs e)
        {

        }
        private void PlayAGame_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void tabPage1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void PlayAGame_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= pictureBox1.Location.X && x <= pictureBox1.Location.X + pictureBox1.Width && y >= pictureBox1.Location.Y && y <= pictureBox1.Location.Y + pictureBox1.Height)
            {

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                pictureBox1.Image = Image.FromFile(files[0]);

            }
        }

        private void tabPage1_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= pictureBox1.Location.X && x <= pictureBox1.Location.X + pictureBox1.Width && y >= pictureBox1.Location.Y && y <= pictureBox1.Location.Y + pictureBox1.Height)
            {

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                pictureBox1.Image = Image.FromFile(files[0]);

            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

    }
}
