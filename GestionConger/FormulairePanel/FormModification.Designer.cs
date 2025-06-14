namespace GestionConger.FormulairePanel
{
    partial class FormModification
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIM = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModifi = new FontAwesome.Sharp.IconButton();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIdCg = new System.Windows.Forms.TextBox();
            this.txtJours = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IM :";
            // 
            // txtIM
            // 
            this.txtIM.Location = new System.Drawing.Point(143, 48);
            this.txtIM.Name = "txtIM";
            this.txtIM.Size = new System.Drawing.Size(191, 20);
            this.txtIM.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(143, 96);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(191, 20);
            this.txtNom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(143, 149);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(191, 20);
            this.txtPrenom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prénom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Service :";
            // 
            // btnModifi
            // 
            this.btnModifi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnModifi.FlatAppearance.BorderSize = 0;
            this.btnModifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnModifi.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModifi.IconColor = System.Drawing.Color.Black;
            this.btnModifi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModifi.Location = new System.Drawing.Point(143, 323);
            this.btnModifi.Name = "btnModifi";
            this.btnModifi.Size = new System.Drawing.Size(97, 35);
            this.btnModifi.TabIndex = 10;
            this.btnModifi.Text = "Modifier";
            this.btnModifi.UseVisualStyleBackColor = false;
            this.btnModifi.Click += new System.EventHandler(this.btnModifi_Click);
            // 
            // cbService
            // 
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(143, 241);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(191, 21);
            this.cbService.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(48, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(45, 20);
            this.txtId.TabIndex = 12;
            // 
            // txtIdCg
            // 
            this.txtIdCg.Location = new System.Drawing.Point(12, 12);
            this.txtIdCg.Name = "txtIdCg";
            this.txtIdCg.Size = new System.Drawing.Size(26, 20);
            this.txtIdCg.TabIndex = 13;
            // 
            // txtJours
            // 
            this.txtJours.Location = new System.Drawing.Point(183, 202);
            this.txtJours.Name = "txtJours";
            this.txtJours.Size = new System.Drawing.Size(122, 20);
            this.txtJours.TabIndex = 15;
            this.txtJours.TextChanged += new System.EventHandler(this.txtJours_TextChanged);
            this.txtJours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJours_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nombre de Jours :";
            // 
            // FormModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 404);
            this.Controls.Add(this.txtJours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdCg);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbService);
            this.Controls.Add(this.btnModifi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIM);
            this.Controls.Add(this.label1);
            this.Name = "FormModification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModification";
            this.Load += new System.EventHandler(this.FormModification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIM;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnModifi;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIdCg;
        private System.Windows.Forms.TextBox txtJours;
        private System.Windows.Forms.Label label6;
    }
}