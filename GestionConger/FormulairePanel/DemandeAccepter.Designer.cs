namespace GestionConger.FormulairePanel
{
    partial class DemandeAccepter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEntete = new System.Windows.Forms.Panel();
            this.lbTitre = new System.Windows.Forms.Label();
            this.btnRefuser = new FontAwesome.Sharp.IconButton();
            this.btnDecocher = new FontAwesome.Sharp.IconButton();
            this.btnCochertous = new FontAwesome.Sharp.IconButton();
            this.tableDemandeAccepter = new System.Windows.Forms.DataGridView();
            this.btnPrefet = new FontAwesome.Sharp.IconButton();
            this.panelEntete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDemandeAccepter)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEntete
            // 
            this.panelEntete.Controls.Add(this.lbTitre);
            this.panelEntete.Location = new System.Drawing.Point(0, 3);
            this.panelEntete.Name = "panelEntete";
            this.panelEntete.Size = new System.Drawing.Size(994, 35);
            this.panelEntete.TabIndex = 2;
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbTitre.Location = new System.Drawing.Point(24, 10);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(137, 15);
            this.lbTitre.TabIndex = 0;
            this.lbTitre.Text = "Les Demandes Accepter";
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
            this.btnRefuser.Location = new System.Drawing.Point(27, 44);
            this.btnRefuser.Name = "btnRefuser";
            this.btnRefuser.Size = new System.Drawing.Size(98, 29);
            this.btnRefuser.TabIndex = 8;
            this.btnRefuser.Text = "Refuser";
            this.btnRefuser.UseVisualStyleBackColor = false;
            this.btnRefuser.Click += new System.EventHandler(this.btnRefuser_Click);
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
            this.btnDecocher.Location = new System.Drawing.Point(262, 47);
            this.btnDecocher.Name = "btnDecocher";
            this.btnDecocher.Size = new System.Drawing.Size(93, 23);
            this.btnDecocher.TabIndex = 10;
            this.btnDecocher.Text = "Décocher tous";
            this.btnDecocher.UseVisualStyleBackColor = false;
            this.btnDecocher.Click += new System.EventHandler(this.btnDecocher_Click);
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
            this.btnCochertous.Location = new System.Drawing.Point(169, 47);
            this.btnCochertous.Name = "btnCochertous";
            this.btnCochertous.Size = new System.Drawing.Size(75, 23);
            this.btnCochertous.TabIndex = 9;
            this.btnCochertous.Text = "Cocher tous";
            this.btnCochertous.UseVisualStyleBackColor = false;
            this.btnCochertous.Click += new System.EventHandler(this.btnCochertous_Click);
            // 
            // tableDemandeAccepter
            // 
            this.tableDemandeAccepter.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.tableDemandeAccepter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tableDemandeAccepter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDemandeAccepter.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableDemandeAccepter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableDemandeAccepter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableDemandeAccepter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDemandeAccepter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tableDemandeAccepter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDemandeAccepter.DefaultCellStyle = dataGridViewCellStyle9;
            this.tableDemandeAccepter.EnableHeadersVisualStyles = false;
            this.tableDemandeAccepter.Location = new System.Drawing.Point(30, 79);
            this.tableDemandeAccepter.Name = "tableDemandeAccepter";
            this.tableDemandeAccepter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableDemandeAccepter.RowHeadersVisible = false;
            this.tableDemandeAccepter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableDemandeAccepter.Size = new System.Drawing.Size(941, 321);
            this.tableDemandeAccepter.TabIndex = 13;
            // 
            // btnPrefet
            // 
            this.btnPrefet.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrefet.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPrefet.FlatAppearance.BorderSize = 0;
            this.btnPrefet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrefet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrefet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnPrefet.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPrefet.IconColor = System.Drawing.Color.Black;
            this.btnPrefet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrefet.Location = new System.Drawing.Point(384, 44);
            this.btnPrefet.Name = "btnPrefet";
            this.btnPrefet.Size = new System.Drawing.Size(158, 29);
            this.btnPrefet.TabIndex = 14;
            this.btnPrefet.Text = "Envoyer au prefecture";
            this.btnPrefet.UseVisualStyleBackColor = false;
            this.btnPrefet.Click += new System.EventHandler(this.btnPrefet_Click);
            // 
            // DemandeAccepter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnPrefet);
            this.Controls.Add(this.tableDemandeAccepter);
            this.Controls.Add(this.btnDecocher);
            this.Controls.Add(this.btnCochertous);
            this.Controls.Add(this.btnRefuser);
            this.Controls.Add(this.panelEntete);
            this.Name = "DemandeAccepter";
            this.Size = new System.Drawing.Size(997, 405);
            this.Load += new System.EventHandler(this.DemandeAccepter_Load);
            this.panelEntete.ResumeLayout(false);
            this.panelEntete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDemandeAccepter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEntete;
        private System.Windows.Forms.Label lbTitre;
        private FontAwesome.Sharp.IconButton btnRefuser;
        private FontAwesome.Sharp.IconButton btnDecocher;
        private FontAwesome.Sharp.IconButton btnCochertous;
        private System.Windows.Forms.DataGridView tableDemandeAccepter;
        private FontAwesome.Sharp.IconButton btnPrefet;
    }
}
