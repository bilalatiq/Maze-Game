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

namespace Maze_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox5.Visible = false;
            pictureBox8.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        public Form3 ff3 = new Form3();
        public int ScoreValue;
        public int timer = 1000;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                pictureBox2.Top -= 10;
                pictureBox2.Image = Properties.Resources.ezgif_2_df0651033b11;
            }
            if (e.KeyCode == Keys.Down)
            {
                pictureBox2.Top += 10;
                pictureBox2.Image = Properties.Resources.ezgif_2_28931b33aceb;
            }
            if (e.KeyCode == Keys.Right)
            {
                pictureBox2.Left += 10;
                pictureBox2.Image = Properties.Resources.zRERkjv;
            }
            if (e.KeyCode == Keys.Left)
            {
                pictureBox2.Left -= 10;
                pictureBox2.Image = Properties.Resources.ezgif_2_fbc68f72b7db;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
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
                case 900:
                    pictureBox5.Visible = true;
                    break;
                case 850:
                    pictureBox5.Visible = false;
                    break;
                case 500:
                    pictureBox8.Visible = true;
                    break;
                case 450:
                    pictureBox8.Visible = false;
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
                            if (pictureBox2.Bounds.IntersectsWith(c.Bounds))
                            {
                                timer1.Enabled = false;
                                this.Hide();
                                MessageBox.Show("You Loose!!!!");
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
                            if (pictureBox2.Bounds.IntersectsWith(c.Bounds))
                            {                         
                                ScoreValue += 100;
                                label48.Text = ScoreValue.ToString();
                                c.Dispose();
                                break;
                            }
                        }
                        else if (c.Tag.ToString() == "diamond")
                        {
                            if (pictureBox2.Bounds.IntersectsWith(c.Bounds))
                            {
                                ScoreValue += 500;
                                label48.Text = ScoreValue.ToString();
                                c.Dispose();
                                break;
                            }
                        }
                        else if (c.Tag.ToString() == "key")
                        {
                            if (pictureBox2.Bounds.IntersectsWith(c.Bounds))
                            {
                                timer = 1000;
                                label51.Text = timer.ToString();
                                c.Dispose();
                                break;
                            }
                        }
                        else if (c.Tag.ToString() == "goal")
                        {
                            if (pictureBox2.Bounds.IntersectsWith(c.Bounds))
                            {
                                timer1.Enabled = false;
                                this.Hide();
                                MessageBox.Show("Level Easy Win");
                                Form6 ff6 = new Form6(ScoreValue);
                                ff6.Show();
                                break;
                            }
                        }
                    }              
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
