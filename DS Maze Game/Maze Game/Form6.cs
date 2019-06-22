using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class Form6 : Form
    {
        public Form6(int ScoreValue)
        {
            this.ScoreValue = ScoreValue;
            InitializeComponent();
        }
        public Form3 ff3 = new Form3();
        public int ScoreValue;
        public int timer = 5000;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer--;
            label51.Text = timer.ToString();
            switch (timer)
            {
                case 1:
                    this.Hide();
                    MessageBox.Show("You Loose!!!");
                    ff3.Show();
                    break;
                case 4950:
                    pictureBox8.Visible = true;
                    break;
                case 4900:
                    pictureBox8.Visible = false;
                    break;
                case 4800:
                    pictureBox9.Visible = true;
                    break;
                case 4750:
                    pictureBox9.Visible = false;
                    break;
                case 4650:
                    pictureBox10.Visible = true;
                    break;
                case 4600:
                    pictureBox10.Visible = false;
                    break;
                case 4000:
                    pictureBox11.Visible = true;
                    break;
                case 3950:
                    pictureBox11.Visible = false;
                    break;
                default:
                    break;
            }           
           
                foreach (Control c in this.Controls)
                {
                    if (c.Tag != null)
                    {
                        if (c.Tag.ToString() == "wall")
                        {
                            if (pictureBox5.Bounds.IntersectsWith(c.Bounds))
                            {
                                timer1.Enabled = false;
                                this.Hide();
                                MessageBox.Show("You Loose!!!");
                                ff3.Show();
                                StreamWriter sw = new StreamWriter("score.txt", true);
                                sw.WriteLine(User_Info.name);
                                sw.WriteLine(label48.Text);
                                sw.Close();
                                break;
                            }
                        }
                        else if (c.Tag.ToString() == "strawberry")
                        {
                            if (pictureBox5.Bounds.IntersectsWith(c.Bounds))
                            {
                                ScoreValue += 100;
                                label48.Text = ScoreValue.ToString();
                                c.Dispose();
                                break;
                            }
                        }
                        else if (c.Tag.ToString() == "diamond")
                        {
                            if (pictureBox5.Bounds.IntersectsWith(c.Bounds))
                            {
                                ScoreValue += 500;
                                label48.Text = ScoreValue.ToString();
                                c.Dispose();
                                break;
                            }
                        }
                        else if (c.Tag.ToString() == "key")
                        {
                            if (pictureBox5.Bounds.IntersectsWith(c.Bounds))
                            {
                                timer = 5000;
                                label51.Text = timer.ToString();
                                c.Dispose();
                                break;
                            }
                        }
                        else if (c.Tag.ToString() == "goal")
                        {
                            if (pictureBox5.Bounds.IntersectsWith(c.Bounds))
                            {
                                timer1.Enabled = false;
                                StreamWriter sw = new StreamWriter("score.txt", true);
                                sw.WriteLine(User_Info.name);
                                sw.WriteLine(label48.Text);
                                sw.Close();
                                this.Hide();
                                MessageBox.Show("Level Hard Win\nYou Are Champ!!!");
                                ff3.Show();
                                break;

                            }
                        }
                    }
                }

            
        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                pictureBox5.Top -= 10;
                pictureBox5.Image = Properties.Resources.ezgif_2_df0651033b11;
            }
            if (e.KeyCode == Keys.Down)
            {
                pictureBox5.Top += 10;
                pictureBox5.Image = Properties.Resources.ezgif_2_28931b33aceb;
            }
            if (e.KeyCode == Keys.Right)
            {
                pictureBox5.Left += 10;
                pictureBox5.Image = Properties.Resources.zRERkjv;
            }
            if (e.KeyCode == Keys.Left)
            {
                pictureBox5.Left -= 10;
                pictureBox5.Image = Properties.Resources.ezgif_2_fbc68f72b7db;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label48.Text = ScoreValue.ToString();
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
