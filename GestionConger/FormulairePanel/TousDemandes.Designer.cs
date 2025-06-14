namespace GestionConger.FormulairePanel
{
    partial class TousDemandes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitre = new System.Windows.Forms.Label();
            this.panelEntete = new System.Windows.Forms.Panel();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnSup = new FontAwesome.Sharp.IconButton();
            this.btnCochertous = new FontAwesome.Sharp.IconButton();
            this.btnDecocher = new FontAwesome.Sharp.IconButton();
            this.btnModifier = new FontAwesome.Sharp.IconButton();
            this.tableTousDemande = new System.Windows.Forms.DataGridView();
            this.panelEntete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableTousDemande)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbTitre.Location = new System.Drawing.Point(24, 10);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(115, 15);
            this.lbTitre.TabIndex = 0;
            this.lbTitre.Text = "Tous Les Demandes";
            // 
            // panelEntete
            // 
            this.panelEntete.Controls.Add(this.txtRecherche);
            this.panelEntete.Controls.Add(this.lbTitre);
            this.panelEntete.Location = new System.Drawing.Point(0, 0);
            this.panelEntete.Name = "panelEntete";
            this.panelEntete.Size = new System.Drawing.Size(994, 35);
            this.panelEntete.TabIndex = 1;
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.SystemColors.Control;
            this.txtRecherche.Location = new System.Drawing.Point(250, 8);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(136, 20);
            this.txtRecherche.TabIndex = 1;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            this.txtRecherche.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRecherche_KeyUp);
            // 
            // btnSup
            // 
            this.btnSup.FlatAppearance.BorderSize = 0;
            this.btnSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSup.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnSup.IconColor = System.Drawing.Color.Red;
            this.btnSup.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnSup.IconSize = 25;
            this.btnSup.Location = new System.Drawing.Point(234, 42);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(27, 29);
            this.btnSup.TabIndex = 5;
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnCochertous
            // 
            this.btnCochertous.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCochertous.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCochertous.FlatAppearance.BorderSize = 0;
            this.btnCochertous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCochertous.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCochertous.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCochertous.IconColor = System.Drawing.Color.Black;
            this.btnCochertous.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCochertous.Location = new System.Drawing.Point(24, 47);
            this.btnCochertous.Name = "btnCochertous";
            this.btnCochertous.Size = new System.Drawing.Size(75, 23);
            this.btnCochertous.TabIndex = 6;
            this.btnCochertous.Text = "Cocher tous";
            this.btnCochertous.UseVisualStyleBackColor = false;
            this.btnCochertous.Click += new System.EventHandler(this.btnCochertous_Click);
            // 
            // btnDecocher
            // 
            this.btnDecocher.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDecocher.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDecocher.FlatAppearance.BorderSize = 0;
            this.btnDecocher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecocher.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDecocher.IconColor = System.Drawing.Color.Black;
            this.btnDecocher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDecocher.Location = new System.Drawing.Point(117, 47);
            this.btnDecocher.Name = "btnDecocher";
            this.btnDecocher.Size = new System.Drawing.Size(93, 23);
            this.btnDecocher.TabIndex = 7;
            this.btnDecocher.Text = "Décocher tous";
            this.btnDecocher.UseVisualStyleBackColor = false;
            this.btnDecocher.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnModifier.IconColor = System.Drawing.Color.Gray;
            this.btnModifier.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnModifier.IconSize = 28;
            this.btnModifier.Location = new System.Drawing.Point(267, 42);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(27, 29);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // tableTousDemande
            // 
            this.tableTousDemande.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.tableTousDemande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableTousDemande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableTousDemande.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableTousDemande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableTousDemande.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableTousDemande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableTousDemande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tableTousDemande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableTousDemande.DefaultCellStyle = dataGridViewCellStyle6;
            this.tableTousDemande.EnableHeadersVisualStyles = false;
            this.tableTousDemande.Location = new System.Drawing.Point(24, 77);
            this.tableTousDemande.Name = "tableTousDemande";
            this.tableTousDemande.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableTousDemande.RowHeadersVisible = false;
            this.tableTousDemande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableTousDemande.Size = new System.Drawing.Size(941, 321);
            this.tableTousDemande.TabIndex = 9;
            // 
            // TousDemandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableTousDemande);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnDecocher);
            this.Controls.Add(this.btnCochertous);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.panelEntete);
            this.Name = "TousDemandes";
            this.Size = new System.Drawing.Size(997, 405);
            this.Load += new System.EventHandler(this.TousDemandes_Load);
            this.panelEntete.ResumeLayout(false);
            this.panelEntete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableTousDemande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.Panel panelEntete;
        private System.Windows.Forms.TextBox txtRecherche;
        private FontAwesome.Sharp.IconButton btnSup;
        private FontAwesome.Sharp.IconButton btnCochertous;
        private FontAwesome.Sharp.IconButton btnDecocher;
        private FontAwesome.Sharp.IconButton btnModifier;
        private System.Windows.Forms.DataGridView tableTousDemande;
    }
}
