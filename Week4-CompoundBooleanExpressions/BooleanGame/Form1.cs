using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BooleanGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int score = 0;
        public static Random rnd = new Random();
        public static String colors = "";
        public static int number = 0;
        public static string gateType = "";
        public void Start()
        {
            button1.Text = "Restart";
            button2.Enabled = true;
            button2.BackColor = Color.Gold;
            button3.Enabled = true;
            button3.BackColor = Color.Tomato;
            int randomnum = rnd.Next(1, 3);
            button5.Text = randomnum.ToString();
            Color[] c = { Color.Red, Color.Green, Color.Gray, Color.Yellow };
            String[] names = { "Red", "Green", "Gray", "Yellow" };
            String[] gate = { "|", "&&" };
            button5.BackColor = c[rnd.Next(0, c.Length)];
            button5.ForeColor = button5.BackColor == c[3] ? Color.Black : Color.White;
            gateType = gate[rnd.Next(0, gate.Length)];
            colors = names[rnd.Next(0, names.Length)];
            number = randomnum;
            label3.Text = ("(" + colors + " " + gateType + gateType + " " + number + ")");
        }
        public void ReStart()
        {
            score = 0;
            button4.Text = "Score = " + score;
            Start();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ReStart();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
        }

        private void button5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gateType == "|")
            {
                if(button5.BackColor == Color.FromName(colors)||
                    button5.Text == number.ToString())
                {
                    score = score + 1;
                    button4.Text = "Score = " + score;
                    Start();

                }
                else
                {
                    button3.Enabled = false;
                    button3.BackColor = Color.LightCoral;
                    button2.Enabled = false;
                    button2.BackColor = Color.Khaki;
                }
            }
            else if(gateType == "&&")
            {
                if(button5.BackColor == Color.FromName(colors) &&
                    button5.Text == number.ToString())
                {
                    score = score + 1;
                    button4.Text = "Score = " + score;
                    Start();
                }
                else
                {

                    button3.Enabled = false;
                    button3.BackColor = Color.LightCoral;
                    button2.Enabled = false;
                    button2.BackColor = Color.Khaki;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gateType == "|")
            {
                if (button5.BackColor != Color.FromName(colors) &&
                    button5.Text != number.ToString()) 
                {
                    score = score + 1;
                    button4.Text = "Score = " + score;
                    Start();
                }
                else
                {
                    button3.Enabled = false;
                    button3.BackColor = Color.LightCoral;
                    button2.Enabled = false;
                    button2.BackColor = Color.Khaki;

                }
            }
            else if (gateType == "&&")
            {
                if (button5.BackColor != Color.FromName(colors) ||
                    button5.Text != number.ToString())
                {
                    score = score + 1;
                    button4.Text = "Score = " + score;
                    Start();
                }
                else
                {
                    button3.Enabled = false;
                    button3.BackColor = Color.LightCoral;
                    button2.Enabled = false;
                    button2.BackColor = Color.Khaki;
                }
            }
        }
    }
}
