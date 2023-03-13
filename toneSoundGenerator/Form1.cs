using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toneSoundGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Beep(640, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.Beep(540, 100);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.Beep(440, 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.Beep(340, 100);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Console.Beep(240, 100);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.Beep(140, 100);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.Beep(40, 100);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.Beep(740, 100);
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
                for (int i = 1; i < 10; i++)
                {
                    Console.Beep(74 * i - i  , 100 + i*2-i);
                }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 50; i++)
            {
                Console.Beep(i*40, 500-(i*10)+2);
            }
        }
    }
}
