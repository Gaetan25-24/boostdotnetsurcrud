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
    public partial class DemandeRefuser : UserControl
    {
        private string connectionString = "Server=localhost; Database=gestioncongeannuel; Uid=root; Password=";
        public DemandeRefuser()
        {
            InitializeComponent();
            lbNom.Visible = false;
            txtNomRecupere.Visible = false;
            btnOk.Visible = false;
        }

        private void DemandeRefuser_Load(object sender, EventArgs e)
        {
            afficheTable();
        }
        public void affichebouton()
        {
            btnDecharge.Visible = true;
            btnAccepter.Visible = true;
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
            tableDemandeRefuser.Columns.Insert(0, checkboxColumn);

            tableDemandeRefuser.ColumnCount = 6;
            tableDemandeRefuser.Columns[1].Name = "Matricule";
            tableDemandeRefuser.Columns[2].Name = "Nom";
            tableDemandeRefuser.Columns[3].Name = "Prénom";
            tableDemandeRefuser.Columns[4].Name = "Conger de l'année";
            tableDemandeRefuser.Columns[5].Name = "Service Employeur";

            foreach (DataGridViewColumn column in tableDemandeRefuser.Columns)
            {
                if (column.Name != "checkboxColumn")
                {
                    column.ReadOnly = true;
                }
            }

            GestionSalarier s1 = new GestionSalarier();
            List<GestionSalarier> infopersonne = s1.RecupererCongeRefuser();
            foreach (GestionSalarier info in infopersonne)
            {
                tableDemandeRefuser.Rows.Add(false,info.Matricule, info.Nom, info.Prenom, info.AnneeConge, info.NomService);
            }

        }
        public void chargerTable()
        {
            if (!tableDemandeRefuser.Columns.Contains("checkboxColumn"))
            {
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.HeaderText = "Select";
                checkboxColumn.Name = "checkboxColumn";
                tableDemandeRefuser.Columns.Insert(0, checkboxColumn);
            }

            if (tableDemandeRefuser.Columns.Count == 1)
            {
                tableDemandeRefuser.ColumnCount = 6;
                tableDemandeRefuser.Columns[1].Name = "Matricule";
                tableDemandeRefuser.Columns[2].Name = "Nom";
                tableDemandeRefuser.Columns[3].Name = "Prénom";
                tableDemandeRefuser.Columns[4].Name = "Conger de l'année";
                tableDemandeRefuser.Columns[5].Name = "Service Employeur";

                foreach (DataGridViewColumn column in tableDemandeRefuser.Columns)
                {
                    if (column.Name != "checkboxColumn")
                    {
                        column.ReadOnly = true;
                    }
                }
            }
            tableDemandeRefuser.Rows.Clear();
            GestionSalarier s1 = new GestionSalarier();
            List<GestionSalarier> infopersonne = s1.RecupererCongeRefuser();
            foreach (GestionSalarier info in infopersonne)
            {
                tableDemandeRefuser.Rows.Add(false, info.Matricule, info.Nom, info.Prenom, info.AnneeConge, info.NomService);
            }
        }

        private List<Tuple<string, int>> ListGetSelectRows = new List<Tuple<string, int>>();
        private void GetSelectRows()
        {

            foreach (DataGridViewRow row in tableDemandeRefuser.Rows)
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

        private void UpdateSelectRows()
        {
            List<Tuple<string, int>> ListMatriculesAnnee = new List<Tuple<string, int>>();

            foreach (DataGridViewRow row in tableDemandeRefuser.Rows)
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
        private void btnAccepter_Click(object sender, EventArgs e)
        {
            etat = "Accepter";
            UpdateSelectRows();
        }
        private void btnDecharge_Click(object sender, EventArgs e)
        {
            bool isCheckboxSelected = false;

            foreach (DataGridViewRow row in tableDemandeRefuser.Rows)
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
                btnAccepter.Visible = false;
                lbNom.Visible = true;
                txtNomRecupere.Visible = true;
                btnOk.Visible = true;
            }
            else
            {
                MessageBox.Show("Aucune ligne sélectionnée .");
            }
        }

        private void txtNomRecupere_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '\'' || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            string nom_recup;
            DateTime datedecharge = DateTime.Today; 
            DateTime heure = DateTime.Now;
            nom_recup = txtNomRecupere.Text;
            etat = $"Demande Rejetée\nDéchargée le : {datedecharge:dd-MM-yyyy} à {heure:HH:mm:ss} par {nom_recup}.";
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

        private void btnAjout_Click(object sender, EventArgs e)
        {
            GetSelectRows();
        }

        private void txtRecherche_KeyUp(object sender, KeyEventArgs e)
        {

            if (!tableDemandeRefuser.Columns.Contains("checkboxColumn"))
            {
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.HeaderText = "Select";
                checkboxColumn.Name = "checkboxColumn";
                tableDemandeRefuser.Columns.Insert(0, checkboxColumn);
            }

            if (tableDemandeRefuser.Columns.Count == 1)
            {
                tableDemandeRefuser.ColumnCount = 6;
                tableDemandeRefuser.Columns[1].Name = "Matricule";
                tableDemandeRefuser.Columns[2].Name = "Nom";
                tableDemandeRefuser.Columns[3].Name = "Prénom";
                tableDemandeRefuser.Columns[4].Name = "Congé de l'année";
                tableDemandeRefuser.Columns[5].Name = "Service Employeur";

                foreach (DataGridViewColumn column in tableDemandeRefuser.Columns)
                {
                    if (column.Name != "checkboxColumn")
                    {
                        column.ReadOnly = true;
                    }
                }
            }

            tableDemandeRefuser.Rows.Clear();

            String search = "%" + txtRecherche.Text + "%";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            string query = "SELECT IM_per, nom_per, prenom_per, annee_cg, nom_serv FROM personne JOIN conge  ON personne.id_per = conge.id_per JOIN service  ON personne.id_serv = service.id_serv WHERE (IM_per LIKE '" + search + "' or nom_per LIKE '" + search + "%') AND etat_demande ='Refuser' ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                string Matricule = data["IM_per"].ToString();
                string Nom = data["nom_per"].ToString();
                string Prenom = data["prenom_per"].ToString();
                int AnneeConge = Convert.ToInt32(data["annee_cg"]);
                string NomService = data["nom_serv"].ToString();
                tableDemandeRefuser.Rows.Add(false, Matricule, Nom, Prenom, AnneeConge, NomService);
            }
        }

        private void btnRetoure_Click(object sender, EventArgs e)
        {
            btnDecharge.Visible = true;
            btnAccepter.Visible = true;
            lbNom.Visible = false;
            txtNomRecupere.Visible = false;
            btnOk.Visible = false;
            chargerTable();
        }
    }
}
