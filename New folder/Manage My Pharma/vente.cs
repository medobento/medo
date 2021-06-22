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
    public partial class vente : Form
    {
        public vente()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-CUALQGE\\SQLEXPRESS;Initial Catalog=managemypharma;Integrated Security=True");
       
        float p;
        float t;
        int a;

        private void comboBox1_RefProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select prix from produit where referance='" + comboBox1_RefProduit.Text + "'", cnx);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                p = float.Parse(dr[0].ToString());
            }

            int q = Convert.ToInt32(numericUpDown1_Qte.Value);
             t = q * p;
            textBox2_Total.Text = t.ToString();
            cnx.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select referance from produit ", cnx);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1_RefProduit.Items.Add(dr[0]);
            }
            cnx.Close();
            dateTimePicker1.Value = DateTime.Now;

        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            
            cnx.Open();
            SqlCommand cd = new SqlCommand("select prix , quantite from produit where referance='" + comboBox1_RefProduit.Text + "'", cnx);
            SqlDataReader dr;
            dr = cd.ExecuteReader();
            while (dr.Read())
            {
                p =float.Parse(dr[0].ToString());
                a = int.Parse(dr[1].ToString());
            }
            int b = Convert.ToInt32(numericUpDown1_Qte.Value);
            int nq = a - b;
            cnx.Close();
            cnx.Open();
            if (nq >= 0) { 
             try
               {
            SqlCommand cmd = new SqlCommand("insert into vente values ('" + textBox1.Text + "', '" + DateTime.Now + "', '" + comboBox1_RefProduit.Text + "', '" + p + "','" + numericUpDown1_Qte.Value + "','" + t+ "')", cnx) ;
                cmd.ExecuteNonQuery();
                SqlCommand cmdd = new SqlCommand("update produit set quantite='" +nq + "'where referance ='" + comboBox1_RefProduit.Text + "'", cnx);
                cmdd.ExecuteNonQuery();
                MessageBox.Show("AJOUTER");

              }
              catch
              {
               MessageBox.Show("une erreur d ajoute");
               }
            }
            else
            {
                MessageBox.Show("ce produit est reptue");
            }
            cnx.Close();
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("delete from vente where ref_v ='" + textBox1.Text + "'", cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted");
            cnx.Close();
        }

        private void button_chercher_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cnx.Open();
            SqlCommand cd = new SqlCommand("select * from vente where ref_v='" + textBox1.Text + "'", cnx);
            SqlDataReader dr;
            dr = cd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
            }
            cnx.Close();
        }

        private void numericUpDown1_Qte_ValueChanged(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select prix from produit where referance='" + comboBox1_RefProduit.Text + "'", cnx);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                p = float.Parse(dr[0].ToString());
            }

            int q = Convert.ToInt32(numericUpDown1_Qte.Value);
             t = q * p;
            textBox2_Total.Text = t.ToString();
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new accueil();
            f2.Show();
        }

        private void button_vider_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        
    }
}
