namespace GestionConger.FormulairePanel
{
    partial class DemandeEnCours
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
            this.lbTitre = new System.Windows.Forms.Label();
            this.panelEntete = new System.Windows.Forms.Panel();
            this.btnRefuser = new FontAwesome.Sharp.IconButton();
            this.btnAccepter = new FontAwesome.Sharp.IconButton();
            this.tableDemandeEnCours = new System.Windows.Forms.DataGridView();
            this.panelEntete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDemandeEnCours)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbTitre.Location = new System.Drawing.Point(24, 10);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(140, 15);
            this.lbTitre.TabIndex = 0;
            this.lbTitre.Text = "Les Demandes En Cours";
            // 
            // panelEntete
            // 
            this.panelEntete.Controls.Add(this.lbTitre);
            this.panelEntete.Location = new System.Drawing.Point(3, 3);
            this.panelEntete.Name = "panelEntete";
            this.panelEntete.Size = new System.Drawing.Size(994, 35);
            this.panelEntete.TabIndex = 3;
            // 
            // btnRefuser
            // 
            this.btnRefuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnRefuser.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRefuser.FlatAppearance.BorderSize = 0;
            this.btnRefuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefuser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRefuser.IconColor = System.Drawing.Color.Black;
            this.btnRefuser.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRefuser.Location = new System.Drawing.Point(186, 44);
            this.btnRefuser.Name = "btnRefuser";
            this.btnRefuser.Size = new System.Drawing.Size(98, 29);
            this.btnRefuser.TabIndex = 6;
            this.btnRefuser.Text = "Refuser";
            this.btnRefuser.UseVisualStyleBackColor = false;
            this.btnRefuser.Click += new System.EventHandler(this.btnRefuser_Click);
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
            this.btnAccepter.Location = new System.Drawing.Point(30, 44);
            this.btnAccepter.Name = "btnAccepter";
            this.btnAccepter.Size = new System.Drawing.Size(98, 29);
            this.btnAccepter.TabIndex = 5;
            this.btnAccepter.Text = "Accepter";
            this.btnAccepter.UseVisualStyleBackColor = false;
            this.btnAccepter.Click += new System.EventHandler(this.btnAccepter_Click);
            // 
            // tableDemandeEnCours
            // 
            this.tableDemandeEnCours.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.tableDemandeEnCours.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableDemandeEnCours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDemandeEnCours.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableDemandeEnCours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableDemandeEnCours.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableDemandeEnCours.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDemandeEnCours.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableDemandeEnCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDemandeEnCours.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableDemandeEnCours.EnableHeadersVisualStyles = false;
            this.tableDemandeEnCours.Location = new System.Drawing.Point(30, 79);
            this.tableDemandeEnCours.Name = "tableDemandeEnCours";
            this.tableDemandeEnCours.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableDemandeEnCours.RowHeadersVisible = false;
            this.tableDemandeEnCours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableDemandeEnCours.Size = new System.Drawing.Size(941, 321);
            this.tableDemandeEnCours.TabIndex = 10;
            this.tableDemandeEnCours.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDemandeEnCours_CellContentClick_1);
            // 
            // DemandeEnCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableDemandeEnCours);
            this.Controls.Add(this.btnRefuser);
            this.Controls.Add(this.btnAccepter);
            this.Controls.Add(this.panelEntete);
            this.Name = "DemandeEnCours";
            this.Size = new System.Drawing.Size(997, 405);
            this.Load += new System.EventHandler(this.DemandeEnCours_Load);
            this.panelEntete.ResumeLayout(false);
            this.panelEntete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDemandeEnCours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.Panel panelEntete;
        private FontAwesome.Sharp.IconButton btnRefuser;
        private FontAwesome.Sharp.IconButton btnAccepter;
        private System.Windows.Forms.DataGridView tableDemandeEnCours;
    }
}
