using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecole
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            EleveForm eleve = new EleveForm();
            eleve.Show();
            this.Hide();
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            EnseignantForm ef = new EnseignantForm();
            ef.Show();
            this.Hide();
        }

        private void gunaCircleButton3_Click(object sender, EventArgs e)
        {
            ParentForm pf = new ParentForm();
            pf.Show();
            this.Hide();
        }

        private void gunaCircleButton4_Click(object sender, EventArgs e)
        {
            ClasseForm cf = new ClasseForm();
            cf.Show();
            this.Hide();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void gunaCircleButton5_Click(object sender, EventArgs e)
        {
            StatistiqueFom sf = new StatistiqueFom();
            sf.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaCircleButton6_Click(object sender, EventArgs e)
        {
            AdminForm mf = new AdminForm();
            mf.Show();
            this.Hide();
        }

        private void gunaCircleButton5_Click_1(object sender, EventArgs e)
        {
            StatistiqueFom sf = new StatistiqueFom();
            sf.Show();
            this.Hide();
        }
    }
}
