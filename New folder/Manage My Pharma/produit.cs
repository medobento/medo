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
    public partial class produit : Form
    {
        public produit()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-CUALQGE\\SQLEXPRESS;Initial Catalog=managemypharma;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new accueil();
            f2.Show();

        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            cnx.Open();
            try { 
            SqlCommand cmd = new SqlCommand("insert into produit values ('" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5_qnt.Text + "')",cnx) ;
            cmd.ExecuteNonQuery();
            cnx.Close();
            }
            catch
            {
                MessageBox.Show("une erreur d ajoute");
            }
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("update produit set prix='" + textBox3.Text + "',libelle='" + textBox4.Text + "',quantite='" + textBox5_qnt.Text + "'where referance ='" + textBox1.Text + "'", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void button_chercher_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from produit where referance='" + textBox1.Text + "'", cnx);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                textBox3.Text = dr[1].ToString();
                textBox4.Text = dr[2].ToString();
                textBox5_qnt.Text = dr[3].ToString();
            }
            cnx.Close();
        }

        private void button_vider_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5_qnt.Clear();
            dataGridView1.Rows.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from produit ", cnx);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
            cnx.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            cnx.Open();
            SqlCommand cmd = new SqlCommand("delete from produit where referance ='" + textBox1.Text + "'", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            }
            catch
            {
                MessageBox.Show("esseyè de supprimer  les ventes qui correspand a ce produit");
            }
        }
    }
}
