namespace GestionConger.FormulairePanel
{
    partial class FormConge
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
            this.panelInfoConger = new System.Windows.Forms.Panel();
            this.lbMatricul = new System.Windows.Forms.Label();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.txtNombreJours = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAnneeDernier = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtIm = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnnuler = new FontAwesome.Sharp.IconButton();
            this.btnEnvoyer = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panelInfoConger.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfoConger
            // 
            this.panelInfoConger.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelInfoConger.Controls.Add(this.lbMatricul);
            this.panelInfoConger.Controls.Add(this.cbService);
            this.panelInfoConger.Controls.Add(this.txtNombreJours);
            this.panelInfoConger.Controls.Add(this.label9);
            this.panelInfoConger.Controls.Add(this.txtAnneeDernier);
            this.panelInfoConger.Controls.Add(this.label8);
            this.panelInfoConger.Controls.Add(this.txtAnnee);
            this.panelInfoConger.Controls.Add(this.txtPrenom);
            this.panelInfoConger.Controls.Add(this.txtIm);
            this.panelInfoConger.Controls.Add(this.txtNom);
            this.panelInfoConger.Controls.Add(this.label7);
            this.panelInfoConger.Controls.Add(this.label6);
            this.panelInfoConger.Controls.Add(this.lbNom);
            this.panelInfoConger.Controls.Add(this.label1);
            this.panelInfoConger.Controls.Add(this.label2);
            this.panelInfoConger.Location = new System.Drawing.Point(12, 53);
            this.panelInfoConger.Name = "panelInfoConger";
            this.panelInfoConger.Size = new System.Drawing.Size(954, 384);
            this.panelInfoConger.TabIndex = 4;
            // 
            // lbMatricul
            // 
            this.lbMatricul.AutoSize = true;
            this.lbMatricul.Location = new System.Drawing.Point(26, 14);
            this.lbMatricul.Name = "lbMatricul";
            this.lbMatricul.Size = new System.Drawing.Size(0, 13);
            this.lbMatricul.TabIndex = 25;
            // 
            // cbService
            // 
            this.cbService.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbService.DropDownHeight = 250;
            this.cbService.FormattingEnabled = true;
            this.cbService.IntegralHeight = false;
            this.cbService.Location = new System.Drawing.Point(325, 207);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(200, 21);
            this.cbService.TabIndex = 24;
            this.cbService.SelectionChangeCommitted += new System.EventHandler(this.cbService_SelectionChangeCommitted);
            // 
            // txtNombreJours
            // 
            this.txtNombreJours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreJours.Location = new System.Drawing.Point(723, 110);
            this.txtNombreJours.Name = "txtNombreJours";
            this.txtNombreJours.Size = new System.Drawing.Size(150, 20);
            this.txtNombreJours.TabIndex = 23;
            this.txtNombreJours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreJours_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label9.Location = new System.Drawing.Point(729, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nombre du jour de congé ";
            // 
            // txtAnneeDernier
            // 
            this.txtAnneeDernier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAnneeDernier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtAnneeDernier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnneeDernier.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtAnneeDernier.Location = new System.Drawing.Point(624, 263);
            this.txtAnneeDernier.Name = "txtAnneeDernier";
            this.txtAnneeDernier.Size = new System.Drawing.Size(121, 20);
            this.txtAnneeDernier.TabIndex = 21;
            this.txtAnneeDernier.Click += new System.EventHandler(this.txtAnneeDernier_Click);
            this.txtAnneeDernier.TextChanged += new System.EventHandler(this.txtAnneeDernier_TextChanged);
            this.txtAnneeDernier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnneeDernier_KeyPress);
            this.txtAnneeDernier.Leave += new System.EventHandler(this.txtAnneeDernier_Leave);
            this.txtAnneeDernier.MouseEnter += new System.EventHandler(this.txtAnneeDernier_MouseEnter);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label8.Location = new System.Drawing.Point(677, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "à";
            // 
            // txtAnnee
            // 
            this.txtAnnee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAnnee.Location = new System.Drawing.Point(624, 208);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(121, 20);
            this.txtAnnee.TabIndex = 19;
            this.txtAnnee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnnee_KeyPress);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrenom.Location = new System.Drawing.Point(486, 110);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(200, 20);
            this.txtPrenom.TabIndex = 17;
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrenom_KeyPress);
            // 
            // txtIm
            // 
            this.txtIm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIm.Location = new System.Drawing.Point(16, 110);
            this.txtIm.Name = "txtIm";
            this.txtIm.Size = new System.Drawing.Size(200, 20);
            this.txtIm.TabIndex = 16;
            this.txtIm.TextChanged += new System.EventHandler(this.txtIm_TextChanged);
            this.txtIm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIm_KeyPress);
            this.txtIm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIm_KeyUp);
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNom.Location = new System.Drawing.Point(253, 110);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 20);
            this.txtNom.TabIndex = 10;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label7.Location = new System.Drawing.Point(635, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Congé annuel de l\'année \r\n";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label6.Location = new System.Drawing.Point(337, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Service employeur ";
            // 
            // lbNom
            // 
            this.lbNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbNom.Location = new System.Drawing.Point(270, 80);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(43, 17);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricule";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(495, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom ";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(66)))));
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAnnuler.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAnnuler.IconColor = System.Drawing.Color.Black;
            this.btnAnnuler.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnnuler.Location = new System.Drawing.Point(336, 460);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(123, 37);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnEnvoyer.FlatAppearance.BorderSize = 0;
            this.btnEnvoyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEnvoyer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEnvoyer.IconColor = System.Drawing.Color.Black;
            this.btnEnvoyer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnvoyer.Location = new System.Drawing.Point(529, 460);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(123, 37);
            this.btnEnvoyer.TabIndex = 6;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = false;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(338, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 22);
            this.label3.TabIndex = 7;
            this.label3.Tag = "";
            this.label3.Text = "AJOUTER UN CONGE ANNUEL";
            // 
            // FormConge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 532);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.panelInfoConger);
            this.Name = "FormConge";
            this.Text = "FormConge";
            this.panelInfoConger.ResumeLayout(false);
            this.panelInfoConger.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInfoConger;
        private System.Windows.Forms.TextBox txtAnneeDernier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtIm;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreJours;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnAnnuler;
        private FontAwesome.Sharp.IconButton btnEnvoyer;
        protected System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Label lbMatricul;
        private System.Windows.Forms.Label label3;
    }
}