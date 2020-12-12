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
            checkBox1.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
        }
        public static int score = 0;
        public static Random rnd = new Random();
        public static String colors = "";
        public static int number = 0;
        public static string gateType = "";
        public static int totalSeconds = 5;
        public static string nota = "";
        public static string notb = "";
        //Dissabled features that might be available in future updates
        
        public void Start()
        {
            totalSeconds = 5;
            timer1.Start();
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
            nota = TrueFalse(rnd.Next(0, 1));
            notb = TrueFalse(rnd.Next(0, 1));
            label3.Text = ("(" + nota + colors + " " + gateType +
                            gateType + " " + notb + number + ")");
        }
        public void ReStart()
        {
            score = 0;
            button4.Text = "Score = " + score;
            Start();

            
        }
        public void Timer()
        {
            if (checkBox2.Checked)
            {
                textBox1.Enabled = true;
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                textBox1.Enabled = false;
                textBox1.Text = "";
            }
        }
        public String TrueFalse(int a)
        {
            if(a == 0)
            {
                return "!";
            }
            else
            {
                return " ";
            }
        }
        public void dissableButtons()
        {
            button3.Enabled = false;
            button3.BackColor = Color.LightCoral;
            button2.Enabled = false;
            button2.BackColor = Color.Khaki;
        }
        public bool compareColor(Color a, Color b, string negation)
        {
            if (negation == "!")
            {
                if (a != b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (a == b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool compareNumber(string a, string b, string negation)
        {
            if (negation == "!")
            {
                if (a != b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (a == b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ReStart();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (gateType == "|")
            {
                if(compareColor(button5.BackColor,Color.FromName(colors),nota)||
                    compareNumber(button5.Text, number.ToString(), notb))
                {
                    score = score + 1;
                    button4.Text = "Score = " + score;
                    Start();

                }
                else
                {
                    dissableButtons();
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
                    dissableButtons();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (gateType == "|")
            {
                if (compareColor(button5.BackColor, Color.FromName(colors), nota) &&
                    compareNumber(button5.Text, number.ToString(), notb)) 
                {
                    score = score + 1;
                    button4.Text = "Score = " + score;
                    Start();
                }
                else
                {
                    dissableButtons();

                }
            }
            else if (gateType == "&&")
            {
                if (compareColor(button5.BackColor, Color.FromName(colors), nota) ||
                    compareNumber(button5.Text, number.ToString(), notb))
                {
                    score = score + 1;
                    button4.Text = "Score = " + score;
                    Start();
                }
                else
                {
                    dissableButtons();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);
                textBox1.Text = ("Time left: " + seconds + " seconds.");
                totalSeconds--;
            }
            else
            {
                this.timer1.Stop();
                textBox1.Text = ("Time's up!");
                dissableButtons();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) Start(); Timer();
        }
    }
}
