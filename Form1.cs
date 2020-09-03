using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Management_System
{
    public partial class Form1 : Form
    {
        int mousex = 0;
        int mousey = 0;
        bool mousedown;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {//443, 275
                mousex = MousePosition.X - 200;
                mousey = MousePosition.Y - 40;
                this.SetDesktopLocation(mousex, mousey);

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);

            {
             
                if (progressBar1.Value < 100)
                {
                    progressBar1.Value++;
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
