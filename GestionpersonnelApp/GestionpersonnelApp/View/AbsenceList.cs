using GestionpersonnelApp.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionpersonnelApp.Controller;

namespace GestionpersonnelApp.Model
{
    public partial class AbsenceList : Form
    {
        public AbsenceList()
        {
            InitializeComponent();
            RafraichirListe();
        }
        private void RafraichirListe()
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Absence a = (Absence)dataGridView1.SelectedRows[0].DataBoundItem;
                var confirm = MessageBox.Show("Confirmer la suppression ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    bool result = AbsenceController.Supprimer(a, out string message);
                    MessageBox.Show(message, result ? "Succès" : "Erreur", MessageBoxButtons.OK, result ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                    if (result) RafraichirListe();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbsenceForm form = new AbsenceForm();
            if (form.ShowDialog() == DialogResult.OK)
                RafraichirListe();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                Absence a = (Absence)dataGridView1.SelectedRows[0].DataBoundItem;
                AbsenceForm form = new AbsenceForm(a);
                if (form.ShowDialog() == DialogResult.OK)
                    RafraichirListe();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
