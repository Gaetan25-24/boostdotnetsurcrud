namespace GestionConger.FormulairePanel
{
    partial class FormConsultation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIMConsult = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableIMConsultation = new System.Windows.Forms.DataGridView();
            this.btnConsulter = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableIMConsultation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(78, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entrer l\'ID à consulter :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIMConsult
            // 
            this.txtIMConsult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIMConsult.Location = new System.Drawing.Point(346, 131);
            this.txtIMConsult.Name = "txtIMConsult";
            this.txtIMConsult.Size = new System.Drawing.Size(130, 20);
            this.txtIMConsult.TabIndex = 3;
            this.txtIMConsult.Click += new System.EventHandler(this.txtIMConsult_Click);
            this.txtIMConsult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIMConsult_KeyPress);
            this.txtIMConsult.Leave += new System.EventHandler(this.txtIMConsult_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.picture);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnConsulter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIMConsult);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 529);
            this.panel1.TabIndex = 4;
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(353, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(234, 104);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 6;
            this.picture.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableIMConsultation);
            this.panel2.Location = new System.Drawing.Point(46, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 337);
            this.panel2.TabIndex = 5;
            // 
            // tableIMConsultation
            // 
            this.tableIMConsultation.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.tableIMConsultation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableIMConsultation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableIMConsultation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableIMConsultation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableIMConsultation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableIMConsultation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableIMConsultation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableIMConsultation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableIMConsultation.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableIMConsultation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableIMConsultation.EnableHeadersVisualStyles = false;
            this.tableIMConsultation.Location = new System.Drawing.Point(0, 0);
            this.tableIMConsultation.Name = "tableIMConsultation";
            this.tableIMConsultation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableIMConsultation.RowHeadersVisible = false;
            this.tableIMConsultation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableIMConsultation.Size = new System.Drawing.Size(864, 337);
            this.tableIMConsultation.TabIndex = 10;
            // 
            // btnConsulter
            // 
            this.btnConsulter.BackColor = System.Drawing.SystemColors.Control;
            this.btnConsulter.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsulter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(31)))), ((int)(((byte)(26)))));
            this.btnConsulter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConsulter.IconColor = System.Drawing.Color.Black;
            this.btnConsulter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsulter.Location = new System.Drawing.Point(482, 129);
            this.btnConsulter.Name = "btnConsulter";
            this.btnConsulter.Size = new System.Drawing.Size(41, 23);
            this.btnConsulter.TabIndex = 4;
            this.btnConsulter.Text = "OK";
            this.btnConsulter.UseVisualStyleBackColor = false;
            this.btnConsulter.Click += new System.EventHandler(this.btnConsulter_Click);
            // 
            // FormConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 532);
            this.Controls.Add(this.panel1);
            this.Name = "FormConsultation";
            this.Text = "FormConsultation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableIMConsultation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIMConsult;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnConsulter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tableIMConsultation;
        private System.Windows.Forms.PictureBox picture;
    }
}