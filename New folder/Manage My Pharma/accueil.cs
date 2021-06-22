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
    public partial class accueil : Form
    {
        public accueil()
        {
            InitializeComponent();
        }SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-CUALQGE\\SQLEXPRESS;Initial Catalog=managemypharma;Integrated Security=True");

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new produit();
            f3.Show();
        }

        private void faireUneVenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f5 = new vente();
            f5.Show();
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new connecter();
            f1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from vente ",cnx) ;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
            }
            cnx.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from vente ", cnx);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
            }
            cnx.Close();

        }

        
    }
}
