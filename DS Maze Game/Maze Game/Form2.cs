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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int count;
        private void Form2_Load(object sender, EventArgs e)
        {
            string[] filedata = File.ReadAllLines("score.txt");
            int[] scorearr = new int[(filedata.Length / 2)];
            string[] namearr = new string[(filedata.Length / 2)];
            int counter = 1;
            for (int i = 1; i < filedata.Length && counter<=filedata.Length/2; i = i + 2)
            {
                scorearr[count] =Convert.ToInt32(filedata[i]);
                count++;
                counter++;
            }
            count = 0;
            counter = 1;
            for (int i = 0; i < filedata.Length && counter <= filedata.Length / 2; i=i+2)
            {
                namearr[count] = filedata[i];
                count++;
                counter++;
            }

            for (int i = 0; i < scorearr.Length; i++)
            {
                for (int j = scorearr.Length - 1; j > 0; j--)
                {
                    if (scorearr[j] > scorearr[j - 1])
                    {
                        int temp = 0;
                        string temp2;
                        temp = scorearr[j];
                        temp2 = namearr[j];
                        scorearr[j] = scorearr[j - 1];
                        namearr[j] = namearr[j - 1];
                        scorearr[j - 1] = temp;
                        namearr[j - 1] = temp2;
                    }
                }
            }

            counter = 0;
            for (int i = 0; i <= scorearr.Length - 1; i++)
            {
                dataGridView1.Rows.Add(namearr[counter], scorearr[counter]);
                counter++;
            }


            //Array.Sort(scorearr);
            //count = scorearr.Length-1;
            //for (int j = 0; j < scorearr.Length; j++)
            //{
            //    for (int i = filedata.Length-1; i >=0; i--)
            //    {
            //        if (scorearr[count] == Convert.ToInt32(filedata[i]));
            //        {
            //            dataGridView1.Rows.Add(filedata[i-1], scorearr[count]);
            //            count--;
            //            break;
            //        }
            //    }
            //}
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
