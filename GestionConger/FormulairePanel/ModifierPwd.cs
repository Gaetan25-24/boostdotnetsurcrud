using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionConger.FormulairePanel
{
    public partial class ModifierPwd : UserControl
    {
        private string url = "database=gestioncongeannuel; server=localhost; user id = root; pwd=";
        public ModifierPwd()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            string Ancienmdp = txtAncien.Text;
            string newmdp = txtNauveau.Text;
            string confirmMdp = txtConfirm.Text;
            string user = txtNom.Text;

            if (string.IsNullOrEmpty(Ancienmdp) || string.IsNullOrEmpty(newmdp) || string.IsNullOrEmpty(confirmMdp))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (newmdp != confirmMdp)
            {
                MessageBox.Show("Le nouveau mot de passe et la confirmation ne correspondent pas.");
                return;
            }
            if(newmdp.Length < 6)
            {
                MessageBox.Show("Le mot de passe doit comporte au moins 6 caractères.");
                return;
            }
            if (newmdp.Length > 15)
            {
                MessageBox.Show("Le mot de passe est trop long.");
                return;
            }
            if (user.Length > 30)
            {
                MessageBox.Show("Le nom d'utilisateur est trop long.");
                return;
            }
            MySqlConnection con = new MySqlConnection(url);
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM inscription WHERE pwd = '"+Ancienmdp+"'";
                MySqlCommand cmd = new MySqlCommand(query, con);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1) // Si l'ancien mot de passe est correct
                {
                    string updateQuery = "UPDATE inscription SET pwd = '"+newmdp+"', user='"+user+"' WHERE pwd = '"+Ancienmdp+"'";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Votre mot de passe a été modifié avec succès.");
                        txtAncien.Text = "";
                        txtConfirm.Text = "";
                        txtNauveau.Text = "";
                        txtNom.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Une erreur s'est produite lors de la modification du mot de passe.");
                    }
                }
                else
                {
                    MessageBox.Show("L'ancien mot de passe est incorrect.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
