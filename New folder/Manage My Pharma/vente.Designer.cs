
namespace Manage_My_Pharma
{
    partial class vente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RefVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_refVente = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2_Total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1_Qte = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1_RefProduit = new System.Windows.Forms.ComboBox();
            this.button_vider = new System.Windows.Forms.Button();
            this.button_chercher = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Qte)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-108, -34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label_refVente);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox2_Total);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown1_Qte);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1_RefProduit);
            this.groupBox1.Controls.Add(this.button_vider);
            this.groupBox1.Controls.Add(this.button_chercher);
            this.groupBox1.Controls.Add(this.button_modifier);
            this.groupBox1.Controls.Add(this.button_ajouter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1056, 580);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 23);
            this.textBox1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "reference vente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefVente,
            this.DateVente,
            this.RefProduit,
            this.Qnt,
            this.PrixUnitaire,
            this.Total});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(66, 317);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(919, 239);
            this.dataGridView1.TabIndex = 27;
            // 
            // RefVente
            // 
            this.RefVente.DataPropertyName = "RefVente";
            this.RefVente.HeaderText = "Référence Vente";
            this.RefVente.MinimumWidth = 8;
            this.RefVente.Name = "RefVente";
            this.RefVente.Width = 150;
            // 
            // DateVente
            // 
            this.DateVente.DataPropertyName = "DateVente";
            this.DateVente.HeaderText = "Date vente";
            this.DateVente.MinimumWidth = 8;
            this.DateVente.Name = "DateVente";
            this.DateVente.Width = 150;
            // 
            // RefProduit
            // 
            this.RefProduit.DataPropertyName = "RefProduit";
            this.RefProduit.HeaderText = "Référence Produit";
            this.RefProduit.MinimumWidth = 8;
            this.RefProduit.Name = "RefProduit";
            this.RefProduit.Width = 150;
            // 
            // Qnt
            // 
            this.Qnt.DataPropertyName = "Qnt";
            this.Qnt.HeaderText = "Quantité";
            this.Qnt.MinimumWidth = 8;
            this.Qnt.Name = "Qnt";
            this.Qnt.Width = 150;
            // 
            // PrixUnitaire
            // 
            this.PrixUnitaire.DataPropertyName = "PrixUnitaire";
            this.PrixUnitaire.HeaderText = "Prix unitaire";
            this.PrixUnitaire.MinimumWidth = 8;
            this.PrixUnitaire.Name = "PrixUnitaire";
            this.PrixUnitaire.Width = 150;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.Width = 150;
            // 
            // label_refVente
            // 
            this.label_refVente.AutoSize = true;
            this.label_refVente.Location = new System.Drawing.Point(513, 38);
            this.label_refVente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_refVente.Name = "label_refVente";
            this.label_refVente.Size = new System.Drawing.Size(0, 15);
            this.label_refVente.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(397, 16);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 23);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // textBox2_Total
            // 
            this.textBox2_Total.Location = new System.Drawing.Point(554, 227);
            this.textBox2_Total.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2_Total.Name = "textBox2_Total";
            this.textBox2_Total.Size = new System.Drawing.Size(85, 23);
            this.textBox2_Total.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total à payer";
            // 
            // numericUpDown1_Qte
            // 
            this.numericUpDown1_Qte.Location = new System.Drawing.Point(213, 173);
            this.numericUpDown1_Qte.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1_Qte.Name = "numericUpDown1_Qte";
            this.numericUpDown1_Qte.Size = new System.Drawing.Size(111, 23);
            this.numericUpDown1_Qte.TabIndex = 19;
            this.numericUpDown1_Qte.ValueChanged += new System.EventHandler(this.numericUpDown1_Qte_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quantité";
            // 
            // comboBox1_RefProduit
            // 
            this.comboBox1_RefProduit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1_RefProduit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1_RefProduit.FormattingEnabled = true;
            this.comboBox1_RefProduit.Location = new System.Drawing.Point(213, 132);
            this.comboBox1_RefProduit.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1_RefProduit.Name = "comboBox1_RefProduit";
            this.comboBox1_RefProduit.Size = new System.Drawing.Size(109, 23);
            this.comboBox1_RefProduit.TabIndex = 16;
            this.comboBox1_RefProduit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_RefProduit_SelectedIndexChanged);
            // 
            // button_vider
            // 
            this.button_vider.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_vider.Location = new System.Drawing.Point(386, 257);
            this.button_vider.Margin = new System.Windows.Forms.Padding(2);
            this.button_vider.Name = "button_vider";
            this.button_vider.Size = new System.Drawing.Size(95, 29);
            this.button_vider.TabIndex = 12;
            this.button_vider.Text = "Vider";
            this.button_vider.UseVisualStyleBackColor = true;
            this.button_vider.Click += new System.EventHandler(this.button_vider_Click);
            // 
            // button_chercher
            // 
            this.button_chercher.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_chercher.Location = new System.Drawing.Point(262, 257);
            this.button_chercher.Margin = new System.Windows.Forms.Padding(2);
            this.button_chercher.Name = "button_chercher";
            this.button_chercher.Size = new System.Drawing.Size(95, 29);
            this.button_chercher.TabIndex = 10;
            this.button_chercher.Text = "Chercher";
            this.button_chercher.UseVisualStyleBackColor = true;
            this.button_chercher.Click += new System.EventHandler(this.button_chercher_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modifier.Location = new System.Drawing.Point(143, 261);
            this.button_modifier.Margin = new System.Windows.Forms.Padding(2);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(95, 26);
            this.button_modifier.TabIndex = 9;
            this.button_modifier.Text = "Supprimer";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajouter.Location = new System.Drawing.Point(22, 259);
            this.button_ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(95, 28);
            this.button_ajouter.TabIndex = 8;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "reference produit";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1152, 584);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "vente";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Qte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_refVente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2_Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1_Qte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1_RefProduit;
        private System.Windows.Forms.Button button_vider;
        private System.Windows.Forms.Button button_chercher;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}