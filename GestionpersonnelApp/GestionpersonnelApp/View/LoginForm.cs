using GestionpersonnelApp.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionpersonnelApp.Model
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string pwd = textBox2.Text;

            if (Authcontroller.SeConnecter(login, pwd, out string message))
            {
                MessageBox.Show(message, "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // connexion réussie, ouvrir la fenêtre principale 
            }
            else
            {
                MessageBox.Show(message, "Identifiants incorrects", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
