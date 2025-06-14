using GestionConger.Class;
using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace GestionConger.FormulairePanel
{
    public partial class FormModification : Form
    {
        private string url = "database=gestioncongeannuel; server=localhost; user id=root; pwd=";
        private int id;
        private int idCg;
        private string matricule;
        private string nom;
        private string prenom;
        private int anneeConge;
        private float nbrJours;
        private string serviceEmployeur;

        public FormModification(int id, int idcg, string matricule, string nom, string prenom, int anneeConge, float jours, string serviceEmployeur)
        {
            InitializeComponent();
            this.Text = String.Empty;
            txtId.Visible = false;
            txtIdCg.Visible = false;

            this.id = id;
            this.idCg = idcg;
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.anneeConge = anneeConge;
            this.nbrJours = jours;
            this.serviceEmployeur = serviceEmployeur;
            afficheService();
        }
        private bool CongesDejaDemande(MySqlConnection con, int id_per, int annee)
        {
            string query = "SELECT COUNT(*) FROM conge WHERE id_per = '"+id_per+"' AND annee_cg = '"+annee+"' ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        private void btnModifi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIM.Text) || string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPrenom.Text))
            {
                MessageBox.Show("Veuillez rensaigner tous les champs.");
                return;
            }
            if (txtIM.Text.Length != 6)
            {
                MessageBox.Show("Le matricule doit comporter exactement 6 caractères.");
                return;
            }
            if (cbService.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un service employeur.");
                return;
            }
            string idtxt = txtId.Text;
            string idCgtxt = txtIdCg.Text;
            int id, idCg;
            string im = txtIM.Text;
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string joursTxt = txtJours.Text;
            float jrs;
            if (!int.TryParse(idtxt, out id))
            {
                return;
            }
            if (!int.TryParse(idCgtxt, out idCg))
            {
                return;
            }
            if (!float.TryParse(joursTxt, NumberStyles.Float, CultureInfo.InvariantCulture, out jrs))
            {
                MessageBox.Show("Veuillez entrer un nombre de jours valide.");
                return;
            }
            if (jrs > 30)
            {
                MessageBox.Show("Veuillez vérifier le nombre de jours entré.");
                return;
            }
            ModelService serviceSelectionner = (ModelService)cbService.SelectedItem;
            int idServ = serviceSelectionner.Id;
            MySqlConnection con = new MySqlConnection(url);
            try
            {
                con.Open();

                string updatePer = "UPDATE personne SET IM_per='" + im + "',nom_per='" + nom + "',prenom_per='" + prenom + "',id_serv='" + idServ + "' WHERE id_per='" + id + "' ";
                string updateConge = "UPDATE conge SET nbr_jrs=@jrs WHERE id_cg='" + idCg + "' ";
                MySqlCommand cmdper = new MySqlCommand(updatePer, con);
                MySqlCommand cmdconge = new MySqlCommand(updateConge, con);
                cmdconge.Parameters.AddWithValue("@jrs", jrs);

                cmdper.ExecuteNonQuery();
                cmdconge.ExecuteNonQuery();
                MessageBox.Show("Modification réussie.");
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void afficheService()
        {
            MySqlConnection con = new MySqlConnection(url);
            MySqlCommand afficheService = new MySqlCommand("SELECT * FROM service", con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = afficheService.ExecuteReader();
                cbService.Items.Clear();
                while (myReader.Read())
                {
                    int id = myReader.GetInt32(myReader.GetOrdinal("id_serv"));
                    string nom = myReader.GetString("nom_serv");
                    cbService.Items.Add(new ModelService(id, nom));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void FormModification_Load(object sender, EventArgs e)
        {
            txtIM.Text = matricule;
            txtId.Text = id.ToString();
            txtIdCg.Text = idCg.ToString();
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            txtJours.Text = nbrJours.ToString();

            if (cbService.Items.Count > 0)
            {
                foreach (ModelService service in cbService.Items)
                {
                    if (service.Nom == serviceEmployeur)
                    {
                        cbService.SelectedItem = service;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un service employeur.");
            }
        }

        private void txtJours_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJours_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
