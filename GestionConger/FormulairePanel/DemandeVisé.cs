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
using System.Windows.Forms;

namespace GestionConger.FormulairePanel
{
    public partial class DemandeVisé : UserControl
    {
        private string connectionString = "Server=localhost; Database=gestioncongeannuel; Uid=root; Password=";
        public DemandeVisé()
        {
            InitializeComponent();
            lbNom.Visible = false;
            txtNomRecupere.Visible = false;
            btnOk.Visible = false;
        }

        public void affichebouton()
        {
            btnDecharge.Visible = true;
            lbNom.Visible = false;
            txtNomRecupere.Visible = false;
            txtNomRecupere.Text = "";
            btnOk.Visible = false;

        }
        public void afficheTable()
        {
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Select";
            checkboxColumn.Name = "checkboxColumn";
            tableDemandeVise.Columns.Insert(0, checkboxColumn);

            tableDemandeVise.ColumnCount = 6;
            tableDemandeVise.Columns[1].Name = "Matricule";
            tableDemandeVise.Columns[2].Name = "Nom";
            tableDemandeVise.Columns[3].Name = "Prénom";
            tableDemandeVise.Columns[4].Name = "Conger de l'année";
            tableDemandeVise.Columns[5].Name = "Service Employeur";

            foreach (DataGridViewColumn column in tableDemandeVise.Columns)
            {
                if (column.Name != "checkboxColumn")
                {
                    column.ReadOnly = true;
                }
            }

            GestionSalarier s1 = new GestionSalarier();
            List<GestionSalarier> infopersonne = s1.RecupererCongeVise();
            foreach (GestionSalarier info in infopersonne)
            {
                tableDemandeVise.Rows.Add(false, info.Matricule, info.Nom, info.Prenom, info.AnneeConge, info.NomService);
            }

        }
        private void txtRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            if (!tableDemandeVise.Columns.Contains("checkboxColumn"))
            {
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.HeaderText = "Select";
                checkboxColumn.Name = "checkboxColumn";
                tableDemandeVise.Columns.Insert(0, checkboxColumn);
            }

            if (tableDemandeVise.Columns.Count == 1)
            {
                tableDemandeVise.ColumnCount = 6;
                tableDemandeVise.Columns[1].Name = "Matricule";
                tableDemandeVise.Columns[2].Name = "Nom";
                tableDemandeVise.Columns[3].Name = "Prénom";
                tableDemandeVise.Columns[4].Name = "Congé de l'année";
                tableDemandeVise.Columns[5].Name = "Service Employeur";

                foreach (DataGridViewColumn column in tableDemandeVise.Columns)
                {
                    if (column.Name != "checkboxColumn")
                    {
                        column.ReadOnly = true;
                    }
                }
            }

            tableDemandeVise.Rows.Clear();

            String search = "%" + txtRecherche.Text + "%";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            string query = "SELECT IM_per, nom_per, prenom_per, annee_cg, nom_serv FROM personne JOIN conge  ON personne.id_per = conge.id_per JOIN service  ON personne.id_serv = service.id_serv WHERE (IM_per LIKE '" + search + "' or nom_per LIKE '" + search + "%') AND etat_demande ='Démande visé' ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                string Matricule = data["IM_per"].ToString();
                string Nom = data["nom_per"].ToString();
                string Prenom = data["prenom_per"].ToString();
                int AnneeConge = Convert.ToInt32(data["annee_cg"]);
                string NomService = data["nom_serv"].ToString();
                tableDemandeVise.Rows.Add(false, Matricule, Nom, Prenom, AnneeConge, NomService);
            }
        }
        public void chargerTable()
        {
            if (!tableDemandeVise.Columns.Contains("checkboxColumn"))
            {
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.HeaderText = "Select";
                checkboxColumn.Name = "checkboxColumn";
                tableDemandeVise.Columns.Insert(0, checkboxColumn);
            }

            if (tableDemandeVise.Columns.Count == 1)
            {
                tableDemandeVise.ColumnCount = 6;
                tableDemandeVise.Columns[1].Name = "Matricule";
                tableDemandeVise.Columns[2].Name = "Nom";
                tableDemandeVise.Columns[3].Name = "Prénom";
                tableDemandeVise.Columns[4].Name = "Conger de l'année";
                tableDemandeVise.Columns[5].Name = "Service Employeur";

                foreach (DataGridViewColumn column in tableDemandeVise.Columns)
                {
                    if (column.Name != "checkboxColumn")
                    {
                        column.ReadOnly = true;
                    }
                }
            }
            tableDemandeVise.Rows.Clear();
            GestionSalarier s1 = new GestionSalarier();
            List<GestionSalarier> infopersonne = s1.RecupererCongeVise();
            foreach (GestionSalarier info in infopersonne)
            {
                tableDemandeVise.Rows.Add(false, info.Matricule, info.Nom, info.Prenom, info.AnneeConge, info.NomService);
            }
        }
        private List<Tuple<string, int>> ListGetSelectRows = new List<Tuple<string, int>>();
        private void GetSelectRows()
        {

            foreach (DataGridViewRow row in tableDemandeVise.Rows)
            {
                // Vérifier si la ligne contient une checkbox sélectionnée
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells["checkboxColumn"];
                if (checkbox.Value != null && (bool)checkbox.Value)
                {
                    // Ajouter le matricule de la ligne à la liste
                    string matricule = row.Cells["Matricule"].Value.ToString();
                    int annee = Convert.ToInt32(row.Cells["Conger de l'année"].Value);
                    var matriculeAnnee = new Tuple<string, int>(matricule, annee);

                    // Vérifier si la ligne n'est pas déjà dans la liste 
                    if (!ListGetSelectRows.Contains(matriculeAnnee))
                    {
                        ListGetSelectRows.Add(matriculeAnnee);
                    }
                }
            }
            if (ListGetSelectRows.Count == 0)
            {
                MessageBox.Show("Aucune ligne sélectionnée.");
            }

        }
        // Méthode pour annuler décharge
        private bool ConfirmerMiseAJour(List<Tuple<string, int>> selectedRows)
        {
            // message pour afficher tous matricule récupérer dans la liste
            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.AppendLine("Décharger les matricules suivants :");
            messageBuilder.AppendLine();

            foreach (var row in selectedRows)
            {
                messageBuilder.AppendLine($"- Matricule: {row.Item1} ");
            }

            messageBuilder.AppendLine();
            messageBuilder.AppendLine("Êtes-vous sûr de vouloir continuer?");

            DialogResult result = MessageBox.Show(
                messageBuilder.ToString(),
                "Confirmation de mise à jour",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return false;
            }

            return true;
        }
        private void UpdateSelectRows()
        {
            List<Tuple<string, int>> ListMatriculesAnnee = new List<Tuple<string, int>>();

            foreach (DataGridViewRow row in tableDemandeVise.Rows)
            {
                // Vérifier si la ligne contient une checkbox sélectionnée
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells["checkboxColumn"];
                if (checkbox.Value != null && (bool)checkbox.Value)
                {
                    // Ajouter le matricule de la ligne à la liste
                    string matricule = row.Cells["Matricule"].Value.ToString();
                    int annee = Convert.ToInt32(row.Cells["Conger de l'année"].Value);
                    ListMatriculesAnnee.Add(new Tuple<string, int>(matricule, annee));
                }
            }

            if (ListMatriculesAnnee.Count > 0)
            {
                UpdateInformationDatabase(ListMatriculesAnnee);
            }
            else
            {
                MessageBox.Show("Aucune ligne sélectionnée.");
            }
        }
        private String etat;

        private void UpdateInformationDatabase(List<Tuple<string, int>> matriculesAndYears)
        {

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    foreach (var matriculeAndYear in matriculesAndYears)
                    {
                        string matricule = matriculeAndYear.Item1;
                        int annee = matriculeAndYear.Item2;

                        string selectQuery = "SELECT id_per FROM personne WHERE IM_per = @matricule";
                        MySqlCommand selectCmd = new MySqlCommand(selectQuery, con);
                        selectCmd.Parameters.AddWithValue("@matricule", matricule);

                        object result = selectCmd.ExecuteScalar();
                        if (result != null)
                        {
                            int id = Convert.ToInt32(result);

                            string updateQuery = "UPDATE conge SET etat_demande='" + etat + "' WHERE id_per = '" + id + "' AND annee_cg = '" + annee + "'";
                            MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);

                            int rowsAffected = updateCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Informations mises à jour pour l'ID : " + id);
                            }
                            else
                            {
                                Console.WriteLine("Aucune mise à jour effectuée pour l'ID : " + id);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Matricule non trouvé : " + matricule);
                        }
                    }
                    chargerTable();
                    MessageBox.Show("Mise à jour effectuée avec succès.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void btnRetoure_Click(object sender, EventArgs e)
        {
            btnDecharge.Visible = true;
            lbNom.Visible = false;
            txtNomRecupere.Visible = false;
            btnOk.Visible = false;
            chargerTable();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            GetSelectRows();
        }

        private void btnDecharge_Click(object sender, EventArgs e)
        {
            bool isCheckboxSelected = false;

            foreach (DataGridViewRow row in tableDemandeVise.Rows)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells["checkboxColumn"];
                if (checkbox.Value != null && (bool)checkbox.Value)
                {
                    isCheckboxSelected = true;
                    break;
                }

            }

            // Vérifier checkbox sélectionnée ou si la liste n'est pas vide
            if (isCheckboxSelected || ListGetSelectRows.Count > 0)
            {
                btnDecharge.Visible = false;
                lbNom.Visible = true;
                txtNomRecupere.Visible = true;
                btnOk.Visible = true;
            }
            else
            {
                MessageBox.Show("Aucune ligne sélectionnée .");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string nom_recup;
            DateTime datedecharge = DateTime.Today;
            DateTime heure = DateTime.Now;
            nom_recup = txtNomRecupere.Text;
            etat = $"Démande Accepter\nDéchargée le : {datedecharge:dd-MM-yyyy} à {heure:HH:mm:ss} par {nom_recup}.";
            if (string.IsNullOrEmpty(txtNomRecupere.Text))
            {
                MessageBox.Show("Veuillez entrer le nom de la recuperateur.");
                return;
            }
            if (ListGetSelectRows.Count > 0)
            {
                if (ConfirmerMiseAJour(ListGetSelectRows))
                {
                    UpdateInformationDatabase(ListGetSelectRows);
                    ListGetSelectRows.Clear();
                    affichebouton();
                }
                else
                {
                    ListGetSelectRows.Clear();
                    MessageBox.Show("La mise à jour a été annulée.");
                    affichebouton();
                }
            }
            else
            {
                UpdateSelectRows();
                affichebouton();
            }
        }

        private void DemandeVisé_Load(object sender, EventArgs e)
        {
            afficheTable();
        }
    }
}
