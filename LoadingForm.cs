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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }
        int start = 0;
        private void TimerLoad_Tick(object sender, EventArgs e)
        {
            start += 1;
            LoadBar.Value = start;
            if (LoadBar.Value == 100)
            {
                LoadBar.Value = 0;
                TimerLoad.Stop();
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();

            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            TimerLoad.Start();
        }

        private void LoadBar_progressChanged(object sender, EventArgs e)
        {

        }
    }
}
