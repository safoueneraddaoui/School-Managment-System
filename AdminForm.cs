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
    public partial class AdminForm : Form
    {
        //Connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\radda\Documents\Schooldb.mdf;Integrated Security=True;Connect Timeout=30");
        
        public AdminForm()
        {
            InitializeComponent();
            
        }

        
        //methode d'affichage
        private void populate()
        {
            Con.Open();
            string query = "select * from AdminTB";
            //extraire les données
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);

            //mise a jour des tb
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            var ds = new DataSet();

            sda.Fill(ds);

            AdminDGV.DataSource = ds.Tables[0];

            Con.Close();    
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*public void verif_int(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }*/

        /*public void verif_char(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
            else if (char.IsControl(e.KeyChar))
                e.Handled = true;
            else e.Handled = false;
        }*/
        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (champ_id.Text == "" || champ_nom.Text == "" || champ_mdp.Text == "")
                {
                    MessageBox.Show("Info manquante");
                }
                else
                {
                    Con.Open();
                    string query = "Update AdminTB set champ_nom ='" + champ_nom.Text + "',champ_mdp ='" + champ_mdp.Text + "'where champ_id=" + champ_id.Text + ";";
                    // permet d'interroger et d'envoyer des commandes à une base de données
                    SqlCommand cmd = new SqlCommand(query, Con);
                    //effectuer des opérations sur notre base
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

        private void AdminForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(champ_id.Text =="" || champ_nom.Text =="" || champ_mdp.Text == "")
                {
                    MessageBox.Show("Info manquante");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO AdminTB values(" +champ_id.Text + ",'" + champ_nom.Text + "','" + champ_mdp.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Ajouter avec succes");
                    Con.Close();
                    populate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops ... Une erreur s'est produit");
            }

        }

        private void AdminDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
            champ_id.Text = AdminDGV.SelectedRows[0].Cells[0].Value.ToString();
            champ_nom.Text = AdminDGV.SelectedRows[0].Cells[1].Value.ToString();
            champ_mdp.Text = AdminDGV.SelectedRows[0].Cells[2].Value.ToString();
           
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if( champ_id.Text == "")
                {
                    MessageBox.Show("Donner l'id");
                }
                else
                {
                    Con.Open();
                    string query = "Delete from AdminTB where champ_id =" + champ_id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Supprimer");
                    Con.Close();
                    populate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Une erreur");
            }
        }

        private void champ_nom_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void champ_id_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void champ_mdp_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void champ_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ce champ doit etre un entier");
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

        private void champ_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ce champ doit etre comporte que des chaines de charactères et des espaces");
            }
        }

        private void mdp_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Ce champ doit etre comporte que des chaines de charactères et des espaces");
            }
        }
    }
}


