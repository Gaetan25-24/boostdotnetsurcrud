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
    public partial class DemandeEnCours : UserControl
    {
        public DemandeEnCours()
        {
            InitializeComponent();
        }

        private void tableDemandeEnCours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DemandeEnCours_Load(object sender, EventArgs e)
        {
            afficheTable();
        }
        public void afficheTable()
        {
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Select";
            checkboxColumn.Name = "checkboxColumn";
            tableDemandeEnCours.Columns.Insert(0, checkboxColumn);

            tableDemandeEnCours.ColumnCount = 7;
            tableDemandeEnCours.Columns[1].Name = "Matricule";
            tableDemandeEnCours.Columns[2].Name = "Nom";
            tableDemandeEnCours.Columns[3].Name = "Prénom";
            tableDemandeEnCours.Columns[4].Name = "Conger de l'année";
            tableDemandeEnCours.Columns[5].Name = "Nombre de jours";
            tableDemandeEnCours.Columns[6].Name = "Service Employeur";

            foreach (DataGridViewColumn column in tableDemandeEnCours.Columns)
            {
                if (column.Name != "checkboxColumn")
                {
                    column.ReadOnly = true;
                }
            }

            GestionSalarier s1 = new GestionSalarier();
            List<GestionSalarier> infopersonne = s1.RecupererCongeEnAttente();
            foreach (GestionSalarier info in infopersonne)
            {
                tableDemandeEnCours.Rows.Add(false,info.Matricule, info.Nom, info.Prenom, info.AnneeConge, info.jours, info.NomService);
            }

        }
        public void chargerTable()
        {
            if (!tableDemandeEnCours.Columns.Contains("checkboxColumn"))
            {
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.HeaderText = "Select";
                checkboxColumn.Name = "checkboxColumn";
                tableDemandeEnCours.Columns.Insert(0, checkboxColumn);
            }

            if (tableDemandeEnCours.Columns.Count == 1)
            {
                tableDemandeEnCours.ColumnCount = 6;
                tableDemandeEnCours.Columns[1].Name = "Matricule";
                tableDemandeEnCours.Columns[2].Name = "Nom";
                tableDemandeEnCours.Columns[3].Name = "Prénom";
                tableDemandeEnCours.Columns[4].Name = "Conger de l'année";
                tableDemandeEnCours.Columns[5].Name = "Service Employeur";

                foreach (DataGridViewColumn column in tableDemandeEnCours.Columns)
                {
                    if (column.Name != "checkboxColumn")
                    {
                        column.ReadOnly = true;
                    }
                }
            }
            tableDemandeEnCours.Rows.Clear();
            GestionSalarier s1 = new GestionSalarier();
            List<GestionSalarier> infopersonne = s1.RecupererCongeEnAttente();
            foreach (GestionSalarier info in infopersonne)
            {
                tableDemandeEnCours.Rows.Add(false, info.Matricule, info.Nom, info.Prenom, info.AnneeConge, info.NomService);
            }
        }

        private void UpdateSelectedRows()
        {
            List<Tuple<string, int>> ListMatriculesAnnee = new List<Tuple<string, int>>();

            foreach (DataGridViewRow row in tableDemandeEnCours.Rows)
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
                UpdateInformationInDatabase(ListMatriculesAnnee);
            }
            else
            {
                MessageBox.Show("Aucune ligne sélectionnée.");
            }
        }


        private String etat;

        private void UpdateInformationInDatabase(List<Tuple<string, int>> matriculesAndYears)
        {
            string connectionString = "Server=localhost; Database=gestioncongeannuel; Uid=root; Password=";

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
            UpdateSelectedRows();
        }

        private void btnRefuser_Click(object sender, EventArgs e)
        {
            etat = "Refuser";
            UpdateSelectedRows();
        }

        private void tableDemandeEnCours_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
