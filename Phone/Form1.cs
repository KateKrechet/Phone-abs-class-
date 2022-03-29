using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone
{
    public partial class Form1 : Form
    {
        int RUB = 200;
        ICaller caller;
        public Form1()
        {
            InitializeComponent();
            caller=new Street();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RUB-=caller.Call(Convert.ToInt32(textBox1.Text));
            label1.Text = "Финансы: " + RUB.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            caller = new Street();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            caller = new Skype();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            caller = new Stat();
        }
    }
}
