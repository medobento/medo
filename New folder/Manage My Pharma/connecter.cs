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
    public partial class connecter : Form
    {
        public connecter()
        {
            InitializeComponent();
        }
        string pa;
        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-CUALQGE\\SQLEXPRESS;Initial Catalog=managemypharma;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select passe from login_u where utilisateur='"+textBox1.Text+"'", cnx);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pa = dr[0].ToString();
            }
            if (pa == textBox2.Text)
            {
                this.Hide();
                Form f2 = new accueil();
                f2.Show();
            }
            else
            {
                MessageBox.Show("MOT DE PASSE OU NOM D UTILISATEUR EST INCORRECT");
            }
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f4 = new user();
            f4.Show();
        }

        private void connecter_Load(object sender, EventArgs e)
        {

        }
    }
}
