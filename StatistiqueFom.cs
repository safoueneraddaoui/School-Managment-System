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


namespace Ecole
{
    public partial class StatistiqueFom : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\radda\Documents\Schooldb.mdf;Integrated Security=True;Connect Timeout=30");

        public StatistiqueFom()
        {
            InitializeComponent();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }

        private void StatistiqueFom_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from AdminTB", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AdminLab.Text = dt.Rows[0][0].ToString();
            Con.Close();


            Con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("Select count(*) from TeacherTB", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            EnseignantLab.Text = dt1.Rows[0][0].ToString();
            Con.Close();


            Con.Open();
            SqlDataAdapter sda2 = new SqlDataAdapter("Select count(*) from ParentTB", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            ParentLab.Text = dt2.Rows[0][0].ToString();
            Con.Close();


            Con.Open();
            SqlDataAdapter sda3 = new SqlDataAdapter("Select count(*) from StudentTB", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            EleveLab.Text = dt3.Rows[0][0].ToString();
            Con.Close();


            Con.Open();
            SqlDataAdapter sda4 = new SqlDataAdapter("Select count(*) from ClassTB", Con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            ClasseLab.Text = dt4.Rows[0][0].ToString();
            Con.Close();
        }
    }
}
