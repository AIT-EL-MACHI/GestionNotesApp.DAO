namespace GestionNotes
{
    partial class AjouterNote
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEtudiants = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Ajouter_Note = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEtudiants
            // 
            this.dgvEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtudiants.Location = new System.Drawing.Point(640, 81);
            this.dgvEtudiants.Name = "dgvEtudiants";
            this.dgvEtudiants.RowHeadersWidth = 51;
            this.dgvEtudiants.RowTemplate.Height = 24;
            this.dgvEtudiants.Size = new System.Drawing.Size(357, 123);
            this.dgvEtudiants.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(763, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "liste etudians";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvNotes
            // 
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Location = new System.Drawing.Point(640, 445);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.RowHeadersWidth = 51;
            this.dgvNotes.RowTemplate.Height = 24;
            this.dgvNotes.Size = new System.Drawing.Size(357, 123);
            this.dgvNotes.TabIndex = 2;
            this.dgvNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(763, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liste Notes";
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(238, 81);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 4;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(238, 138);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 5;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(238, 181);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Supprimer.TabIndex = 6;
            this.Supprimer.Text = "Supprimer ";
            this.Supprimer.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(238, 526);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "SupprimerNote";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Ajouter_Note
            // 
            this.Ajouter_Note.Location = new System.Drawing.Point(238, 462);
            this.Ajouter_Note.Name = "Ajouter_Note";
            this.Ajouter_Note.Size = new System.Drawing.Size(75, 23);
            this.Ajouter_Note.TabIndex = 9;
            this.Ajouter_Note.Text = "AjouterNote";
            this.Ajouter_Note.UseVisualStyleBackColor = true;
            // 
            // AjouterNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 709);
            this.Controls.Add(this.Ajouter_Note);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEtudiants);
            this.Name = "AjouterNote";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEtudiants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Ajouter_Note;
    }
}

