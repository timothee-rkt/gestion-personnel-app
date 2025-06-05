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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonnelList personnelList = new PersonnelList();
            personnelList.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbsenceList absenceList = new AbsenceList();
            absenceList.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Déconnexion : ferme le dashboard et réaffiche le login
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
