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
    public partial class FactsInterface : Form
    {
        public int TabPages = 0;
        public int TabPages1 = 0;
        public FactsInterface()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1;
            frm1 = new Form1();
            frm1.Show();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sqbutton2_Click(object sender, EventArgs e)
        {
            this.sqbutton1.BackColor = Color.Green;
            this.sqbutton2.BackColor = Color.Red;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sqbutton1_Click(object sender, EventArgs e)
        {
            this.sqbutton1.BackColor = Color.Green;

        }

        private void sqbutton3_Click(object sender, EventArgs e)
        {
            this.sqbutton1.BackColor = Color.Green;
            this.sqbutton3.BackColor = Color.Red;
        }

        private void sqbutton4_Click(object sender, EventArgs e)
        {
            
            this.sqbutton1.BackColor = Color.Green;
            this.sqbutton4.BackColor = Color.Red;
            
        }

        private void buttonLog4_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonLog3_Click(object sender, EventArgs e)
        {
          
            
        }

        private void buttonLog2_Click(object sender, EventArgs e)
        {
          if (TabPages1 == 0)
           {
                this.buttonLog2.Enabled = false;

           }
          else
          {
              this.buttonLog2.Enabled = true;
                TabPages1 = TabPages1 - 1;
                this.tabControl1.SelectedIndex = 0;
                this.tabControl3.SelectedIndex = TabPages1;
          }
        }

        private void buttonLog1_Click(object sender, EventArgs e)
        {
            this.buttonLog2.Enabled = true;
                TabPages1 = TabPages1 + 1;
                this.tabControl1.SelectedIndex = 0;
                this.tabControl3.SelectedIndex = TabPages1;
            
        }

        private void home1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1;
            frm1 = new Form1();
            frm1.Show();
        }
        private void buttonLog4_Click_1(object sender, EventArgs e)
        {
            if (TabPages == 0)
            {
                this.buttonLog4.Enabled = false;

            }
            else
            {
                this.buttonLog4.Enabled = true;
                TabPages = TabPages - 1;
                this.tabControl1.SelectedIndex = 1;
                this.tabControl2.SelectedIndex = TabPages;
            }
        }

        private void buttonLog3_Click_1(object sender, EventArgs e)
        {
            this.buttonLog4.Enabled = true;
            TabPages = TabPages + 1;
            this.tabControl1.SelectedIndex = 1;
            this.tabControl2.SelectedIndex = TabPages;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Film f;
            f = new Film();
            f.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Film f;
            f = new Film();
            f.Show();
        }
    }
}
