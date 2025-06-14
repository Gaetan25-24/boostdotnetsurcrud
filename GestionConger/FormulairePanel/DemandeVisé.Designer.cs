namespace GestionConger.FormulairePanel
{
    partial class DemandeVisé
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEntete = new System.Windows.Forms.Panel();
            this.btnRetoure = new FontAwesome.Sharp.IconButton();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lbTitre = new System.Windows.Forms.Label();
            this.btnAjout = new FontAwesome.Sharp.IconButton();
            this.btnOk = new FontAwesome.Sharp.IconButton();
            this.txtNomRecupere = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.btnDecharge = new FontAwesome.Sharp.IconButton();
            this.tableDemandeVise = new System.Windows.Forms.DataGridView();
            this.panelEntete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDemandeVise)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEntete
            // 
            this.panelEntete.Controls.Add(this.btnRetoure);
            this.panelEntete.Controls.Add(this.txtRecherche);
            this.panelEntete.Controls.Add(this.lbTitre);
            this.panelEntete.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEntete.Location = new System.Drawing.Point(0, 0);
            this.panelEntete.Name = "panelEntete";
            this.panelEntete.Size = new System.Drawing.Size(997, 35);
            this.panelEntete.TabIndex = 5;
            // 
            // btnRetoure
            // 
            this.btnRetoure.FlatAppearance.BorderSize = 0;
            this.btnRetoure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetoure.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.btnRetoure.IconColor = System.Drawing.Color.Black;
            this.btnRetoure.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRetoure.IconSize = 25;
            this.btnRetoure.Location = new System.Drawing.Point(3, 3);
            this.btnRetoure.Name = "btnRetoure";
            this.btnRetoure.Size = new System.Drawing.Size(35, 29);
            this.btnRetoure.TabIndex = 3;
            this.btnRetoure.UseVisualStyleBackColor = true;
            this.btnRetoure.Click += new System.EventHandler(this.btnRetoure_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(236, 8);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(136, 20);
            this.txtRecherche.TabIndex = 2;
            this.txtRecherche.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRecherche_KeyUp);
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbTitre.Location = new System.Drawing.Point(44, 10);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(114, 15);
            this.lbTitre.TabIndex = 0;
            this.lbTitre.Text = "Les Demandes Visé";
            // 
            // btnAjout
            // 
            this.btnAjout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjout.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAjout.IconColor = System.Drawing.Color.Red;
            this.btnAjout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAjout.IconSize = 30;
            this.btnAjout.Location = new System.Drawing.Point(9, 41);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(29, 29);
            this.btnAjout.TabIndex = 17;
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(31)))), ((int)(((byte)(26)))));
            this.btnOk.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOk.IconColor = System.Drawing.Color.Black;
            this.btnOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOk.Location = new System.Drawing.Point(584, 44);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(33, 23);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtNomRecupere
            // 
            this.txtNomRecupere.Location = new System.Drawing.Point(373, 45);
            this.txtNomRecupere.Name = "txtNomRecupere";
            this.txtNomRecupere.Size = new System.Drawing.Size(194, 20);
            this.txtNomRecupere.TabIndex = 15;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbNom.Location = new System.Drawing.Point(189, 50);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(178, 13);
            this.lbNom.TabIndex = 14;
            this.lbNom.Text = "Entrer nom récuperateur du dossier :";
            // 
            // btnDecharge
            // 
            this.btnDecharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(66)))));
            this.btnDecharge.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDecharge.FlatAppearance.BorderSize = 0;
            this.btnDecharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecharge.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDecharge.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDecharge.IconColor = System.Drawing.Color.Black;
            this.btnDecharge.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDecharge.Location = new System.Drawing.Point(66, 42);
            this.btnDecharge.Name = "btnDecharge";
            this.btnDecharge.Size = new System.Drawing.Size(98, 29);
            this.btnDecharge.TabIndex = 13;
            this.btnDecharge.Text = "Décharge";
            this.btnDecharge.UseVisualStyleBackColor = false;
            this.btnDecharge.Click += new System.EventHandler(this.btnDecharge_Click);
            // 
            // tableDemandeVise
            // 
            this.tableDemandeVise.AllowUserToAddRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.tableDemandeVise.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.tableDemandeVise.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDemandeVise.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableDemandeVise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableDemandeVise.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableDemandeVise.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDemandeVise.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.tableDemandeVise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDemandeVise.DefaultCellStyle = dataGridViewCellStyle21;
            this.tableDemandeVise.EnableHeadersVisualStyles = false;
            this.tableDemandeVise.Location = new System.Drawing.Point(9, 77);
            this.tableDemandeVise.Name = "tableDemandeVise";
            this.tableDemandeVise.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableDemandeVise.RowHeadersVisible = false;
            this.tableDemandeVise.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableDemandeVise.Size = new System.Drawing.Size(941, 321);
            this.tableDemandeVise.TabIndex = 18;
            // 
            // DemandeVisé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableDemandeVise);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNomRecupere);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.btnDecharge);
            this.Controls.Add(this.panelEntete);
            this.Name = "DemandeVisé";
            this.Size = new System.Drawing.Size(997, 405);
            this.Load += new System.EventHandler(this.DemandeVisé_Load);
            this.panelEntete.ResumeLayout(false);
            this.panelEntete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDemandeVise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEntete;
        private FontAwesome.Sharp.IconButton btnRetoure;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lbTitre;
        private FontAwesome.Sharp.IconButton btnAjout;
        private FontAwesome.Sharp.IconButton btnOk;
        private System.Windows.Forms.TextBox txtNomRecupere;
        private System.Windows.Forms.Label lbNom;
        private FontAwesome.Sharp.IconButton btnDecharge;
        private System.Windows.Forms.DataGridView tableDemandeVise;
    }
}
