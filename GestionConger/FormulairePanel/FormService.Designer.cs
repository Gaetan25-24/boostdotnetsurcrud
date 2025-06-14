namespace GestionConger.FormulairePanel
{
    partial class FormService
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomServ = new System.Windows.Forms.TextBox();
            this.btnSup = new FontAwesome.Sharp.IconButton();
            this.btnModifi = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAjout = new FontAwesome.Sharp.IconButton();
            this.labelNomRecuperer = new System.Windows.Forms.Label();
            this.tableServ = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableServ)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(235, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du Service :";
            // 
            // txtNomServ
            // 
            this.txtNomServ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomServ.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNomServ.Location = new System.Drawing.Point(379, 38);
            this.txtNomServ.Name = "txtNomServ";
            this.txtNomServ.Size = new System.Drawing.Size(262, 20);
            this.txtNomServ.TabIndex = 1;
            this.txtNomServ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomServ_KeyPress);
            // 
            // btnSup
            // 
            this.btnSup.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSup.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnSup.IconColor = System.Drawing.Color.Red;
            this.btnSup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSup.IconSize = 50;
            this.btnSup.Location = new System.Drawing.Point(448, 97);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(53, 53);
            this.btnSup.TabIndex = 3;
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnModifi
            // 
            this.btnModifi.BackColor = System.Drawing.SystemColors.Control;
            this.btnModifi.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnModifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifi.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnModifi.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnModifi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModifi.Location = new System.Drawing.Point(550, 97);
            this.btnModifi.Name = "btnModifi";
            this.btnModifi.Size = new System.Drawing.Size(53, 53);
            this.btnModifi.TabIndex = 4;
            this.btnModifi.UseVisualStyleBackColor = false;
            this.btnModifi.Click += new System.EventHandler(this.btnModifi_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableServ);
            this.panel1.Location = new System.Drawing.Point(206, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 348);
            this.panel1.TabIndex = 5;
            // 
            // btnAjout
            // 
            this.btnAjout.BackColor = System.Drawing.SystemColors.Control;
            this.btnAjout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjout.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAjout.IconColor = System.Drawing.Color.DimGray;
            this.btnAjout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAjout.Location = new System.Drawing.Point(333, 97);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(53, 53);
            this.btnAjout.TabIndex = 6;
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // labelNomRecuperer
            // 
            this.labelNomRecuperer.AutoSize = true;
            this.labelNomRecuperer.Location = new System.Drawing.Point(83, 97);
            this.labelNomRecuperer.Name = "labelNomRecuperer";
            this.labelNomRecuperer.Size = new System.Drawing.Size(0, 13);
            this.labelNomRecuperer.TabIndex = 7;
            // 
            // tableServ
            // 
            this.tableServ.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.tableServ.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableServ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableServ.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableServ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableServ.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableServ.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableServ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableServ.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableServ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableServ.EnableHeadersVisualStyles = false;
            this.tableServ.Location = new System.Drawing.Point(0, 0);
            this.tableServ.Name = "tableServ";
            this.tableServ.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableServ.RowHeadersVisible = false;
            this.tableServ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableServ.Size = new System.Drawing.Size(524, 348);
            this.tableServ.TabIndex = 8;
            this.tableServ.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableServ_CellClick_2);
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(978, 532);
            this.Controls.Add(this.labelNomRecuperer);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModifi);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.txtNomServ);
            this.Controls.Add(this.label1);
            this.Name = "FormService";
            this.Text = "FormService";
            this.Load += new System.EventHandler(this.FormService_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableServ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomServ;
        private FontAwesome.Sharp.IconButton btnSup;
        private FontAwesome.Sharp.IconButton btnModifi;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAjout;
        private System.Windows.Forms.Label labelNomRecuperer;
        private System.Windows.Forms.DataGridView tableServ;
    }
}