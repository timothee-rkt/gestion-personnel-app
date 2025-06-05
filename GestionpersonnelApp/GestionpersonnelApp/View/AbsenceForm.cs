using GestionpersonnelApp.modele;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionpersonnelApp.Controller;
using GestionpersonnelApp.dal;


namespace GestionpersonnelApp.Model
{
    public partial class AbsenceForm : Form
    {
        private Absence absence = null;

        public AbsenceForm()
        {
            InitializeComponent();
            this.Load += AbsenceForm_Load;
        }

        // Constructeur pour la modification
        public AbsenceForm (Absence a) : this()
        {
            absence = a;
        }

        private void AbsenceForm_Load(object sender, EventArgs e)
        {
            // Remplir la liste des personnels
            comboBox1.DataSource = PersonnelController.ObtenirTous();
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "IdPersonnel";

            // Remplir la liste des motifs
            comboBox2.DataSource = MotifController.ObtenirTous();
            comboBox2.DisplayMember = "Libelle";
            comboBox2.ValueMember = "Id";

            // Si modification, pré-remplir les champs
            if (absence != null)
            {
                dateTimePicker1.Value = absence.DateDebut;
                dateTimePicker2.Value = absence.DateFin;
                comboBox1.SelectedValue = absence.IdPersonnel;
                comboBox2.SelectedValue = absence.IdMotif;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now.AddDays(1);
            }
            if (absence != null)
            {
                comboBox1.Enabled = false; // Personnel non modifiable
                comboBox2.Enabled = false; // Motif non modifiable
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime debut = dateTimePicker1.Value;
            DateTime fin = dateTimePicker2.Value;
            int idMotif = (int)comboBox2.SelectedValue;
            int idPersonnel = (int)comboBox1.SelectedValue;

            if (fin < debut)
            {
                MessageBox.Show("La date de fin doit être postérieure à la date de début.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool result;
            string message;

            if (absence == null)
                result = AbsenceController.Ajouter(debut, fin, idMotif, idPersonnel, out message);
            else
                result = AbsenceController.Modifier(absence, debut, fin, idMotif, idPersonnel, out message);

            MessageBox.Show(message, result ? "Succès" : "Erreur", MessageBoxButtons.OK, result ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (result) this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}