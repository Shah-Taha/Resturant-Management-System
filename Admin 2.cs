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
    public partial class Admin_2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=rms1;User ID=sa;Password=aptech");
        public Admin_2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
         con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from menuu where id'" + textBox8+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record has been inserted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
             con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from menuu where id'" + textBox8 + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from menuu ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            con.Close();
        }
        }

       
    }

