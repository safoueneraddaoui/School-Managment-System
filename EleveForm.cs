﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Ecole
{
    public partial class EleveForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\radda\Documents\Schooldb.mdf;Integrated Security=True;Connect Timeout=30");

        public EleveForm()
        {
            InitializeComponent();
        }

        private void Eleve_Load(object sender, EventArgs e)
        {
            Class();
            populate();
            Parent();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from StudentTB";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EleveDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (champ_id.Text == "" || champ_nom.Text == "" || champ_tel.Text == "")
                {
                    MessageBox.Show("information manquante !!!");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO StudentTB values(" + champ_id.Text + ",'" + champ_nom.Text + "','" + champ_genre.SelectedItem.ToString() + "','" + champ_ddn.Text + "','" + champ_tel.Text + "','" + champ_classe.SelectedValue.ToString() + "','" + champ_parent.SelectedValue.ToString() + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Elève Ajouter avec succes");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oop ... Une erreur s'est produit !!!");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (champ_id.Text == "" || champ_nom.Text == "" || champ_tel.Text == "")
                {
                    MessageBox.Show("information manquante !!!");
                }
                else
                {
                    Con.Open();
                    string query = "Update StudentTB set champ_nom ='" + champ_nom.Text + "',champ_genre ='" + champ_genre.SelectedItem.ToString() + "',champ_ddn ='" + champ_ddn.Text + "',champ_tel ='" + champ_tel.Text + "'where champ_id=" + champ_id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Elève modifier avec succès");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oop ... Une erreur s'est produit !!! ");
            }
        }

        private void Class()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select champ_nom from ClassTB", Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("champ_nom", typeof(string));
                dt.Load(rdr);
                champ_classe.ValueMember = "champ_nom";
                champ_classe.DataSource = dt;
                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Parent()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select champ_nom from ParentTB", Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("champ_nom", typeof(string));
                dt.Load(rdr);
                champ_parent.ValueMember = "champ_nom";
                champ_parent.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void champ_classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        private void champ_id_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void AdminDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            champ_id.Text = EleveDGV.SelectedRows[0].Cells[0].Value.ToString();
            champ_nom.Text = EleveDGV.SelectedRows[0].Cells[1].Value.ToString();
            champ_genre.SelectedItem = EleveDGV.SelectedRows[0].Cells[2].Value.ToString();
            champ_ddn.Text = EleveDGV.SelectedRows[0].Cells[3].Value.ToString();
            champ_tel.Text = EleveDGV.SelectedRows[0].Cells[4].Value.ToString();
            champ_classe.SelectedItem = EleveDGV.SelectedRows[0].Cells[5].Value.ToString();
            champ_parent.SelectedItem = EleveDGV.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (champ_id.Text == "")
                {
                    MessageBox.Show("Donner l'id");
                }
                else
                {
                    Con.Open();
                    string query = "Delete from StudentTB where champ_id =" + champ_id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Elève supprimer avec succès");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oop ... Une erreur s'est produit !!!");
            }
        }

        private void id_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ce champ doit etre un entier");
            }
        }

        private void nom_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ce champ doit etre comporte que des chaines de charactères et des espaces");
            }
        }

        private void tel_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ce champ doit etre comporte que des entier");
            }
        }
    }
}
