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

namespace Manage_My_Pharma
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-CUALQGE\\SQLEXPRESS;Initial Catalog=managemypharma;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            try
            {
                if (textBox2.Text == textBox3.Text)
                { 
                SqlCommand cmd = new SqlCommand("insert into login_u values ('" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')", cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();
                    MessageBox.Show("inscription avec succes");
                }
            }
            catch
            {
                MessageBox.Show("une erreur d ajoute");
            }
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new connecter();
            f1.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void user_Load(object sender, EventArgs e)
        {

        }
    }
}
