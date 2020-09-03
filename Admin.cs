using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Resturant_Management_System
{
    public partial class Admin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=rms1;User ID=sa;Password=aptech");
       
        public Admin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update menuu where id ='" + textBox8.Text + "'where Name='" + textBox1.Text + "'where lastName='" + textBox2.Text + "'where pass='" + textBox3.Text + "'where reenter='" + textBox4.Text + "'where Email='" + textBox5.Text + "'where gender='" + textBox6.Text + "'where Age='" + textBox7.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record has been updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_2 ad = new Admin_2();
            this.Hide();
            ad.Show();
       
        }
    }
}
