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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DIGITAL/DIGITAL;Initial Catalog=rms1;User ID=sa;Password=aptech");
       
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType =CommandType.Text;
            cmd.CommandText = "insert into menuu values('" + textBox8.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record has been inserted");

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
       
        }
    }
}
