using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeCRUD
{
    public partial class Show : Form
    {
        public Show()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-O2JBNB95;Initial Catalog=ExeCrud;User ID=sa;Password=***********");

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.sp_motor_Insert '"+int.Parse(textBox1.Text)+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"'  ,con);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
