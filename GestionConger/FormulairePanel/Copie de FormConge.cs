using GestionConger.Class;
using GestionConger.Gestion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace GestionConger.FormulairePanel
{
    public partial class FormConge : Form
    {
        private string url = "database=gestioncongeannuel; server=localhost; user id = root; pwd=";
        public FormConge()
        {
            InitializeComponent();
            afficheService();
            lbMatricul.Visible = false;
            txtAnneeDernier.Text = "Facultative";
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '\'' || char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '\'' || char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtIndice_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtGrade_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtIm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtIm.Text.Length >= 6)
            {
                 if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (char.IsNumber(e.KeyChar))
                    e.Handled = false;
                else if (char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void txtAnnee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAnnee.Text.Length >= 4)
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (char.IsNumber(e.KeyChar))
                    e.Handled = false;
                else if (char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }

        }

        private void txtAnneeDernier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAnneeDernier.Text.Length >= 4)
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (char.IsNumber(e.KeyChar))
                    e.Handled = false;
                else if (char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void rtxtService_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombreJours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtIm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {

        }
        private bool CongesDejaDemande(MySqlConnection con, int id_per, int annee)
        {
            string query = "SELECT COUNT(*) FROM conge WHERE id_per = '"+id_per+"' AND annee_cg = '"+annee+"' ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        private bool DemandePourAnneeUlterieure(MySqlConnection con, int id_per, int annee)
        {
            string query = "SELECT COUNT(*) FROM conge WHERE id_per = '"+id_per+"' AND annee_cg > '"+annee+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }


        private void btnEnvoyer_Click_1(object sender, EventArgs e)
        {
            // Vérification si les TextBoxes ne sont pas vides
            if (string.IsNullOrWhiteSpace(txtIm.Text) || string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) || string.IsNullOrWhiteSpace(txtNombreJours.Text) ||
                string.IsNullOrWhiteSpace(txtAnnee.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return;
            }
            if (txtIm.Text.Length != 6)
            {
                MessageBox.Show("Le matricule doit comporter exactement 6 caractères.");
                return;
            }
            if (cbService.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un service employeur.");
                return;
            }

            string im = txtIm.Text;
            string nom = txtNom.Text;
            TextInfo textnom = new CultureInfo("fr-FR", false).TextInfo;
            string Nom = textnom.ToTitleCase(nom);

            string prenom = txtPrenom.Text;
            TextInfo textprenom = new CultureInfo("fr-FR", false).TextInfo;
            string Prenom = textprenom.ToTitleCase(prenom);
            string jrsTxt = txtNombreJours.Text;
            string anneTxt = txtAnnee.Text;
            float jrs;
            int anne;

            if (!float.TryParse(jrsTxt, NumberStyles.Float, CultureInfo.InvariantCulture, out jrs))
            {
                MessageBox.Show("Veuillez entrer un nombre de jours valide.");
                return;
            }

            if (!int.TryParse(anneTxt, out anne) || anne < 1900 || anne > DateTime.Now.Year)
            {
                MessageBox.Show("Veuillez entrer une année valide.");
                return;
            }

            if (jrs > 30)
            {
                MessageBox.Show("Veuillez vérifier le nombre de jours entré.");
                return;
            }

            DateTime datedemande = DateTime.Today;
            ModelService serviceSelectionner = (ModelService)cbService.SelectedItem;
            int idServ = serviceSelectionner.Id;
            Personne p1 = new Personne(im, Nom, Prenom, idServ);
            GestionSalarier gp = new GestionSalarier();
            MySqlConnection con = new MySqlConnection(url);

            try
            {
                con.Open();

                string queryPersonne = "SELECT id_per FROM personne WHERE IM_per = '"+im+"'"; 
                MySqlCommand cmdPersonne = new MySqlCommand(queryPersonne, con);
                MySqlDataReader reader = cmdPersonne.ExecuteReader();

                int idp;
                if (reader.Read())
                {
                    idp = reader.GetInt32(reader.GetOrdinal("id_per"));
                    reader.Close();
                }
                else
                {
                    reader.Close();

                    // Ajouter la nouvelle personne si n'existe pas
                    string insertPersonQuery = "INSERT INTO personne (IM_per, nom_per, prenom_per, id_serv) VALUES (@matricule, @nom, @prenom, @idServ)";
                    MySqlCommand cmdInsertPerson = new MySqlCommand(insertPersonQuery, con);
                    cmdInsertPerson.Parameters.AddWithValue("@matricule", im);
                    cmdInsertPerson.Parameters.AddWithValue("@nom", Nom);
                    cmdInsertPerson.Parameters.AddWithValue("@prenom", Prenom);
                    cmdInsertPerson.Parameters.AddWithValue("@idServ", idServ);
                    cmdInsertPerson.ExecuteNonQuery();

                    idp = (int)cmdInsertPerson.LastInsertedId;
                }
                //verifier si le champs ne contient pas des chiffre
                if (!txtAnneeDernier.Text.Any(char.IsDigit))
                {
                    if (CongesDejaDemande(con, idp, anne))
                    {
                        MessageBox.Show(im + " a déjà fait une demande de congé pour l'année " + anne);
                        return;
                    }

                    if (DemandePourAnneeUlterieure(con, idp, anne))
                    {
                        MessageBox.Show("Impossible de faire ce démande car " + im + " a déjà fait une demande de congé pour une année ultérieure.");
                        return;
                    }
                    string etat = "En Cours De Traitement.";
                    InsertConge(con, jrs, anne, datedemande,etat, idp);
                    MessageBox.Show("Bravo, congé ajouté avec succès !");
                    effacherChamps();
                }
                else
                {
                    string anneDernierTxt = txtAnneeDernier.Text;
                    int anneDernier;

                    if (!int.TryParse(anneDernierTxt, out anneDernier) || anneDernier < 1900 || anneDernier > DateTime.Now.Year)
                    {
                        MessageBox.Show("Veuillez entrer une année valide.");
                        return;
                    }

                    if (anne >= anneDernier)
                    {
                        MessageBox.Show("Vérifiez les deux années.");
                        return;
                    }

                    int res = anneDernier - anne;

                    for (int i = 0; i <= res; i++)
                    {
                        if (CongesDejaDemande(con, idp, anne))
                        {
                            MessageBox.Show(im + " a déjà fait une demande de congé pour l'année " + anne);
                            return;
                        }
                        string etat = "En Cours De Traitement.";
                        InsertConge(con, jrs, anne, datedemande,etat, idp);
                        anne++;
                    }

                    MessageBox.Show("Bravo, congé ajouté avec succès !");
                    effacherChamps();
                    txtAnneeDernier.Text = "Facultative";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void effacherChamps()
        {
            txtIm.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtNombreJours.Text = string.Empty;
            txtAnnee.Text = string.Empty;
            cbService.SelectedItem = null;
            if (!txtAnneeDernier.Text.Any(char.IsDigit))
            {
                return;
            }
            txtAnneeDernier.Text = String.Empty;
        }
        private void InsertConge(MySqlConnection con, float jrs, int annee, DateTime dateDemande,string etat, int idPer)
        {
            string query = "INSERT INTO conge (nbr_jrs, annee_cg, date_demande,etat_demande, id_per) VALUES (@nbr_jrs, @annee_cg, @date_demande,@etat_demande, @id_per)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nbr_jrs", jrs);
            cmd.Parameters.AddWithValue("@annee_cg", annee);
            cmd.Parameters.AddWithValue("@date_demande", dateDemande);
            cmd.Parameters.AddWithValue("@etat_demande", etat);
            cmd.Parameters.AddWithValue("@id_per", idPer);
            cmd.ExecuteNonQuery();
        }

        public void afficheService()
        {
            MySqlConnection con = new MySqlConnection(url);
            MySqlCommand afficheService = new MySqlCommand("SELECT * FROM service",con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = afficheService.ExecuteReader();
                while (myReader.Read())
                {
                    int id = myReader.GetInt32(myReader.GetOrdinal("id_serv"));
                    string nom = myReader.GetString("nom_serv");
                    cbService.Items.Add(new ModelService(id,nom));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbService_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            effacherChamps();
        }

        private void txtAnneeDernier_Leave(object sender, EventArgs e)
        {
            String s = txtAnneeDernier.Text;
            if (string.IsNullOrWhiteSpace(s))
            {
                txtAnneeDernier.Text = "Facultative";
            }
        }

        private void txtAnneeDernier_MouseEnter(object sender, EventArgs e)
        {
        }
        private void txtAnneeDernier_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAnneeDernier_Click(object sender, EventArgs e)
        {
            txtAnneeDernier.Text = "";
        }

        private void txtIm_KeyUp(object sender, KeyEventArgs e)
        {
            string im = txtIm.Text;
            MySqlConnection con = new MySqlConnection(url);
            try
            {
                con.Open();

                if (txtIm.Text.Length != 6)
                {
                    txtNom.Text = "";
                    txtPrenom.Text = "";
                    cbService.SelectedItem = null;

                    return;
                }
                string req = "SELECT nom_per,prenom_per,nom_serv FROM service JOIN personne ON service.id_serv=personne.id_serv WHERE IM_per='" + im + "'";
                MySqlCommand cmd = new MySqlCommand(req, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string nom = reader.GetString("nom_per");
                    string prenom = reader.GetString("prenom_per");
                    string serv = reader.GetString("nom_serv");

                    txtNom.Text = nom;
                    txtPrenom.Text = prenom;
                    if (cbService.Items.Count > 0)
                    {
                        foreach (ModelService service in cbService.Items)
                        {
                            if (service.Nom == serv)
                            {
                                cbService.SelectedItem = service;
                                break;
                            }
                        }
                    }
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
