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
using System.Data.Sql;

namespace Ecole
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\radda\Documents\Schooldb.mdf;Integrated Security=True;Connect Timeout=30");

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (champ_id.Text == "" || champ_nom.Text == "" || champ_tel.Text == "")
                {
                    MessageBox.Show("Info manquante");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ParentTB values(" + champ_id.Text + ",'" + champ_nom.Text + "','" + champ_tel.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Parent Ajouter avec succes");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops ... Une erreur s'est produit");
            }
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from ParentTB";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ParentDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (champ_id.Text == "" || champ_nom.Text == "" || champ_tel.Text == "")
                {
                    MessageBox.Show("Info manquante");
                }
                else
                {
                    Con.Open();
                    string query = "Update ParentTB set champ_nom ='" + champ_nom.Text + "',champ_tel ='" + champ_tel.Text + "'where champ_id=" + champ_id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modifier avec succès");
                    Con.Close();
                    populate();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oop ... Une erreur s'est produit ");
            }
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
                    string query = "Delete from ParentTB where champ_id =" + champ_id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Supprimer");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Une erreur");
            }
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ParentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            champ_id.Text = ParentDGV.SelectedRows[0].Cells[0].Value.ToString();
            champ_nom.Text = ParentDGV.SelectedRows[0].Cells[1].Value.ToString();
            champ_tel.Text = ParentDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Ce champ doit etre comporte que des chaines de charactères et des espaces");
            }
        }
    }
}
