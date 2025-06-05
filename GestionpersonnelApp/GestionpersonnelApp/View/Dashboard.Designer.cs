namespace GestionpersonnelApp.Model
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            btnAbsence = new Button();
            btnPersonnel = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(431, 88);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 0;
            label1.Text = "Bienvenue dans l'Application ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 249);
            label2.Name = "label2";
            label2.Size = new Size(344, 20);
            label2.TabIndex = 1;
            label2.Text = "Veuillez choisir une action dans le Menu à gauche !";
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnAbsence);
            panel1.Controls.Add(btnPersonnel);
            panel1.Location = new Point(22, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 308);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(67, 218);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Déconnexion ";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnAbsence
            // 
            btnAbsence.Location = new Point(67, 135);
            btnAbsence.Name = "btnAbsence";
            btnAbsence.Size = new Size(94, 29);
            btnAbsence.TabIndex = 1;
            btnAbsence.Text = "Absence ";
            btnAbsence.UseVisualStyleBackColor = true;
            btnAbsence.Click += button2_Click;
            // 
            // btnPersonnel
            // 
            btnPersonnel.Location = new Point(67, 57);
            btnPersonnel.Name = "btnPersonnel";
            btnPersonnel.Size = new Size(94, 29);
            btnPersonnel.TabIndex = 0;
            btnPersonnel.Text = "Personnel ";
            btnPersonnel.UseVisualStyleBackColor = true;
            btnPersonnel.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 70);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "Menu";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Dashboard";
            Text = "Tableau de Bord ";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button button3;
        private Button btnAbsence;
        private Button btnPersonnel;
        private Label label3;
    }
}