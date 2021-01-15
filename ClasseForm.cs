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
    public partial class ClasseForm : Form
    {
        public ClasseForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\radda\Documents\Schooldb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from ClassTB";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ClassDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (champ_id.Text == "" || champ_nom.Text == "" || champ_desc.Text == "")
                {
                    MessageBox.Show("Info manquante");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ClassTB values(" + champ_id.Text + ",'" + champ_nom.Text + "','" + champ_desc.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Ajouter avec succes");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops ... Une erreur s'est produit");
            }
        }

        private void ClassDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            champ_id.Text = ClassDGV.SelectedRows[0].Cells[0].Value.ToString();
            champ_nom.Text = ClassDGV.SelectedRows[0].Cells[1].Value.ToString();
            champ_desc.Text = ClassDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void ClasseForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (champ_id.Text == "" || champ_nom.Text == "" || champ_desc.Text == "")
                {
                    MessageBox.Show("Info manquante");
                }
                else
                {
                    Con.Open();
                    string query = "Update ClassTB set champ_nom ='" + champ_nom.Text + "',champ_desc ='" + champ_desc.Text + "'where champ_id=" + champ_id.Text + ";";
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
                    string query = "Delete from ClassTB where champ_id =" + champ_id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Class Supprimer");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Une erreur");
            }
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

        private void classe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Ce champ doit etre comporte que des chaines de charactères et des espaces");
            }
        }

        private void desc_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Ce champ doit etre comporte que des chaines de charactères et des espaces");
            }
        }
    }
}
