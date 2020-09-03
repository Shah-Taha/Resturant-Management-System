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
    public partial class _01Welcome : Form
    {
        public _01Welcome()
        {
            InitializeComponent();
        }
        int mousex = 0;
        int mousey = 0;
        bool mousedown;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Form1 f = new Form1();
                f.Visible = true;
                this.Hide();
            }
            if (radioButton2.Checked == true)
            {
                Admin a = new Admin();
                a.Visible = true;
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
