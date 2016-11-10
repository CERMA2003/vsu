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
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();

            this.button6.Visible = false;
            this.button7.Visible = false;
            this.button8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoricalEvents facts;
            facts = new HistoricalEvents();
            facts.Show();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button6.Visible = true;
            this.button7.Visible = true;
            this.button8.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutTheApps ata;
            ata = new AboutTheApps();
            ata.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoricalEvents hE;
            hE = new HistoricalEvents();
            hE.Show();
           
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FactsInterface facts;
            facts = new FactsInterface();
            facts.tabControl1.SelectedIndex = 0;
            facts.Show();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FactsInterface facts;
            facts = new FactsInterface();
            facts.tabControl1.SelectedIndex = 1;
            facts.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            RightToDoInterface  pag;
            pag = new RightToDoInterface ();
            pag.Show();
        }
    }
}
