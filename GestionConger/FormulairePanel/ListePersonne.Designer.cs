namespace GestionConger.FormulairePanel
{
    partial class ListePersonne
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
            this.tablePers = new System.Windows.Forms.DataGridView();
            this.btnDecocher = new FontAwesome.Sharp.IconButton();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnCochertous = new FontAwesome.Sharp.IconButton();
            this.btnSup = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePers)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePers
            // 
            this.tablePers.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.tablePers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablePers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablePers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablePers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablePers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablePers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePers.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablePers.EnableHeadersVisualStyles = false;
            this.tablePers.Location = new System.Drawing.Point(59, 117);
            this.tablePers.Name = "tablePers";
            this.tablePers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablePers.RowHeadersVisible = false;
            this.tablePers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablePers.Size = new System.Drawing.Size(611, 415);
            this.tablePers.TabIndex = 10;
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
            this.btnDecocher.Location = new System.Drawing.Point(161, 71);
            this.btnDecocher.Name = "btnDecocher";
            this.btnDecocher.Size = new System.Drawing.Size(93, 23);
            this.btnDecocher.TabIndex = 14;
            this.btnDecocher.Text = "Décocher tous";
            this.btnDecocher.UseVisualStyleBackColor = false;
            this.btnDecocher.Click += new System.EventHandler(this.btnDecocher_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.SystemColors.Control;
            this.txtRecherche.Location = new System.Drawing.Point(68, 18);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(150, 20);
            this.txtRecherche.TabIndex = 11;
            this.txtRecherche.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRecherche_KeyUp);
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
            this.btnCochertous.Location = new System.Drawing.Point(68, 71);
            this.btnCochertous.Name = "btnCochertous";
            this.btnCochertous.Size = new System.Drawing.Size(75, 23);
            this.btnCochertous.TabIndex = 13;
            this.btnCochertous.Text = "Cocher tous";
            this.btnCochertous.UseVisualStyleBackColor = false;
            this.btnCochertous.Click += new System.EventHandler(this.btnCochertous_Click);
            // 
            // btnSup
            // 
            this.btnSup.FlatAppearance.BorderSize = 0;
            this.btnSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSup.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnSup.IconColor = System.Drawing.Color.Red;
            this.btnSup.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnSup.IconSize = 25;
            this.btnSup.Location = new System.Drawing.Point(278, 66);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(27, 29);
            this.btnSup.TabIndex = 12;
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(231, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Recherche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(429, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Liste des personnels";
            // 
            // ListePersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecocher);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.btnCochertous);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.tablePers);
            this.Name = "ListePersonne";
            this.Size = new System.Drawing.Size(745, 532);
            this.Load += new System.EventHandler(this.ListePersonne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablePers;
        private FontAwesome.Sharp.IconButton btnDecocher;
        private System.Windows.Forms.TextBox txtRecherche;
        private FontAwesome.Sharp.IconButton btnCochertous;
        private FontAwesome.Sharp.IconButton btnSup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
