namespace GestionConger.FormulairePanel
{
    partial class DemandeRefuser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEntete = new System.Windows.Forms.Panel();
            this.btnRetoure = new FontAwesome.Sharp.IconButton();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lbTitre = new System.Windows.Forms.Label();
            this.btnAccepter = new FontAwesome.Sharp.IconButton();
            this.btnDecharge = new FontAwesome.Sharp.IconButton();
            this.lbNom = new System.Windows.Forms.Label();
            this.txtNomRecupere = new System.Windows.Forms.TextBox();
            this.btnOk = new FontAwesome.Sharp.IconButton();
            this.btnAjout = new FontAwesome.Sharp.IconButton();
            this.tableDemandeRefuser = new System.Windows.Forms.DataGridView();
            this.panelEntete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDemandeRefuser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEntete
            // 
            this.panelEntete.Controls.Add(this.btnRetoure);
            this.panelEntete.Controls.Add(this.txtRecherche);
            this.panelEntete.Controls.Add(this.lbTitre);
            this.panelEntete.Location = new System.Drawing.Point(3, 3);
            this.panelEntete.Name = "panelEntete";
            this.panelEntete.Size = new System.Drawing.Size(994, 35);
            this.panelEntete.TabIndex = 4;
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
            this.lbTitre.Size = new System.Drawing.Size(133, 15);
            this.lbTitre.TabIndex = 0;
            this.lbTitre.Text = "Les Demandes Refuser";
            // 
            // btnAccepter
            // 
            this.btnAccepter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnAccepter.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAccepter.FlatAppearance.BorderSize = 0;
            this.btnAccepter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccepter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccepter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAccepter.IconColor = System.Drawing.Color.Black;
            this.btnAccepter.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAccepter.Location = new System.Drawing.Point(79, 44);
            this.btnAccepter.Name = "btnAccepter";
            this.btnAccepter.Size = new System.Drawing.Size(98, 29);
            this.btnAccepter.TabIndex = 6;
            this.btnAccepter.Text = "Accepter";
            this.btnAccepter.UseVisualStyleBackColor = false;
            this.btnAccepter.Click += new System.EventHandler(this.btnAccepter_Click);
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
            this.btnDecharge.Location = new System.Drawing.Point(183, 44);
            this.btnDecharge.Name = "btnDecharge";
            this.btnDecharge.Size = new System.Drawing.Size(98, 29);
            this.btnDecharge.TabIndex = 7;
            this.btnDecharge.Text = "Décharge";
            this.btnDecharge.UseVisualStyleBackColor = false;
            this.btnDecharge.Click += new System.EventHandler(this.btnDecharge_Click);
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbNom.Location = new System.Drawing.Point(306, 52);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(178, 13);
            this.lbNom.TabIndex = 8;
            this.lbNom.Text = "Entrer nom récuperateur du dossier :";
            // 
            // txtNomRecupere
            // 
            this.txtNomRecupere.Location = new System.Drawing.Point(490, 47);
            this.txtNomRecupere.Name = "txtNomRecupere";
            this.txtNomRecupere.Size = new System.Drawing.Size(194, 20);
            this.txtNomRecupere.TabIndex = 9;
            this.txtNomRecupere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomRecupere_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(31)))), ((int)(((byte)(26)))));
            this.btnOk.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOk.IconColor = System.Drawing.Color.Black;
            this.btnOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOk.Location = new System.Drawing.Point(701, 46);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(33, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjout.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAjout.IconColor = System.Drawing.Color.Red;
            this.btnAjout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAjout.IconSize = 30;
            this.btnAjout.Location = new System.Drawing.Point(28, 44);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(29, 29);
            this.btnAjout.TabIndex = 11;
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // tableDemandeRefuser
            // 
            this.tableDemandeRefuser.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.tableDemandeRefuser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableDemandeRefuser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDemandeRefuser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableDemandeRefuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableDemandeRefuser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableDemandeRefuser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDemandeRefuser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableDemandeRefuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDemandeRefuser.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableDemandeRefuser.EnableHeadersVisualStyles = false;
            this.tableDemandeRefuser.Location = new System.Drawing.Point(28, 79);
            this.tableDemandeRefuser.Name = "tableDemandeRefuser";
            this.tableDemandeRefuser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableDemandeRefuser.RowHeadersVisible = false;
            this.tableDemandeRefuser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableDemandeRefuser.Size = new System.Drawing.Size(941, 321);
            this.tableDemandeRefuser.TabIndex = 12;
            // 
            // DemandeRefuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableDemandeRefuser);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNomRecupere);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.btnDecharge);
            this.Controls.Add(this.btnAccepter);
            this.Controls.Add(this.panelEntete);
            this.Name = "DemandeRefuser";
            this.Size = new System.Drawing.Size(997, 405);
            this.Load += new System.EventHandler(this.DemandeRefuser_Load);
            this.panelEntete.ResumeLayout(false);
            this.panelEntete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDemandeRefuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEntete;
        private System.Windows.Forms.Label lbTitre;
        private FontAwesome.Sharp.IconButton btnAccepter;
        private FontAwesome.Sharp.IconButton btnDecharge;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox txtNomRecupere;
        private FontAwesome.Sharp.IconButton btnOk;
        private FontAwesome.Sharp.IconButton btnAjout;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.DataGridView tableDemandeRefuser;
        private FontAwesome.Sharp.IconButton btnRetoure;
    }
}
