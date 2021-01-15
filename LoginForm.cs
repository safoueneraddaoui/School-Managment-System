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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public LoginForm()
        {
            InitializeComponent();

            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\radda\Documents\Schooldb.mdf;Integrated Security=True;Connect Timeout=30";

        }



        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            /*MainForm mf = new MainForm();
            mf.Show();
            this.Hide();*/
            //ouvrir la connection
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from AdminTB";
            //lire les données a partir de sql
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            { 
                if (champ_nom.Text.Equals(dr["champ_nom"].ToString()) && champ_mdp.Text.Equals(dr["champ_mdp"].ToString()))
                {
                    //MessageBox.Show("good");
                    MainForm mf = new MainForm();
                    this.Hide();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Vérifier vos coordonnées");
                }
            }
            //fermer la connection
            con.Close();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nom_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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
