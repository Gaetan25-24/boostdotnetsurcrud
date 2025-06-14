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
    public partial class TousDemandes : UserControl
    {
        string url = "Server=localhost; Database=gestioncongeannuel; Uid=root; Password=";
        public TousDemandes()
        {
            InitializeComponent();
        }

        private void TousDemandes_Load(object sender, EventArgs e)
        {
            afficheTable();
        }
        public void afficheTable()
        {

            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Select";
            checkboxColumn.Name = "checkboxColumn";
            tableTousDemande.Columns.Insert(0, checkboxColumn);

            tableTousDemande.ColumnCount = 8;
            tableTousDemande.Columns[1].Name = "Service Employeur";
            tableTousDemande.Columns[2].Name = "Matricule";
            tableTousDemande.Columns[3].Name = "Nom";
            tableTousDemande.Columns[4].Name = "Prénom";
            tableTousDemande.Columns[5].Name = "Conger de l'année";
            tableTousDemande.Columns[6].Name = "Nombre de jours";
            tableTousDemande.Columns[7].Name = "etat Demande";

            foreach (DataGridViewColumn column in tableTousDemande.Columns)
            {
                if (column.Name != "checkboxColumn")
                {
                    column.ReadOnly = true;
                }
            }

            GestionSalarier s1 = new GestionSalarier();
            List<GestionSalarier> infopersonne = s1.RecupererInformationPersonne();
            foreach(GestionSalarier info in infopersonne)
            {
                tableTousDemande.Rows.Add(false, info.NomService, info.Matricule, info.Nom, info.Prenom, info.AnneeConge, info.jours, info.Etat);
            }
        }
        public void chargerTable()
        {
            if (!tableTousDemande.Columns.Contains("checkboxColumn"))
            {
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.HeaderText = "Select";
                checkboxColumn.Name = "checkboxColumn";
                tableTousDemande.Columns.Insert(0, checkboxColumn);
            }

            if (tableTousDemande.Columns.Count == 1)
            {
                tableTousDemande.ColumnCount = 8;
                tableTousDemande.Columns[1].Name = "Service Employeur";
                tableTousDemande.Columns[2].Name = "Matricule";
                tableTousDemande.Columns[3].Name = "Nom";
                tableTousDemande.Columns[4].Name = "Prénom";
                tableTousDemande.Columns[5].Name = "Conger de l'année";
                tableTousDemande.Columns[6].Name = "Nombre de jours";
                tableTousDemande.Columns[7].Name = "etat Demande";

                foreach (DataGridViewColumn column in tableTousDemande.Columns)
                {
                    if (column.Name != "checkboxColumn")
                    {
                        column.ReadOnly = true;
                    }
                }
            }
            tableTousDemande.Rows.Clear();
            GestionSalarier s1 = new GestionSalarier();
            List<GestionSalarier> infopersonne = s1.RecupererInformationPersonne();
            foreach (GestionSalarier info in infopersonne)
            {
                tableTousDemande.Rows.Add(false, info.NomService, info.Matricule, info.Nom, info.Prenom, info.AnneeConge, info.jours, info.Etat );
            }

        }
        private void DeleteSelectRows()
        {
            List<Tuple<string, int>> selectedMatriculesAndYears = new List<Tuple<string, int>>();

            foreach (DataGridViewRow row in tableTousDemande.Rows)
            {
                // Vérifier si la ligne contient une checkbox sélectionnée
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells["checkboxColumn"];
                if (checkbox.Value != null && (bool)checkbox.Value)
                {
                    // Ajouter le matricule et l'année du congé de la ligne à la liste
                    string matricule = row.Cells["Matricule"].Value.ToString();
                    int anneeConge = Convert.ToInt32(row.Cells["Conger de l'année"].Value);
                    selectedMatriculesAndYears.Add(new Tuple<string, int>(matricule, anneeConge));
                }
            }

            if (selectedMatriculesAndYears.Count > 0)
            {
                SupprimerDansDatabase(selectedMatriculesAndYears);
            }
            else
            {
                MessageBox.Show("Aucune ligne sélectionnée.");
            }
        }

        private void SupprimerDansDatabase(List<Tuple<string, int>> matriculesAndYears)
        {
            MySqlConnection con = new MySqlConnection(url);
        
                try
                {
                    con.Open();
                DialogResult confirm = MessageBox.Show(
                    "Êtes-vous sûr de vouloir supprimer les élément sélectionné ?",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (confirm == DialogResult.Yes)
                {
                    foreach (var matriculeAndYear in matriculesAndYears)
                    {
                        string matricule = matriculeAndYear.Item1;
                        int anneeConge = matriculeAndYear.Item2;

                        string selectQuery = "SELECT id_per FROM personne WHERE IM_per = '" + matricule + "'";
                        MySqlCommand selectCmd = new MySqlCommand(selectQuery, con);

                        object result = selectCmd.ExecuteScalar();
                        if (result != null)
                        {
                            int id = Convert.ToInt32(result);

                            string deleteQuery = "DELETE FROM conge WHERE id_per = '" + id + "' AND annee_cg = '" + anneeConge + "'";
                            MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, con);
                            int rowsAffected = deleteCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Matricule non trouvé : " + matricule);
                        }
                    }
                    chargerTable();
                }
                else
                {
                    MessageBox.Show("La suppression a été annulée.", "Annulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chargerTable();
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
        }

        // methode pour cocher ou décoche tous les check box tableau
        private void checkboxacocher(DataGridView dataGridView, bool checkState)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewCheckBoxCell checkbox = row.Cells["checkboxColumn"] as DataGridViewCheckBoxCell;
                if (checkbox != null)
                {
                    checkbox.Value = checkState;
                }
            }
        }

        private void tableTousDemande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
        }

        private void btnAccepter_Click(object sender, EventArgs e)
        {
        }

        private void btnRefuser_Click(object sender, EventArgs e)
        {
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            DeleteSelectRows();
        }
        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            if (!tableTousDemande.Columns.Contains("checkboxColumn"))
            {
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.HeaderText = "Select";
                checkboxColumn.Name = "checkboxColumn";
                tableTousDemande.Columns.Insert(0, checkboxColumn);
            }

            if (tableTousDemande.Columns.Count == 1) 
            {
                tableTousDemande.ColumnCount = 7;
                tableTousDemande.Columns[1].Name = "Matricule";
                tableTousDemande.Columns[2].Name = "Nom";
                tableTousDemande.Columns[3].Name = "Prénom";
                tableTousDemande.Columns[4].Name = "Congé de l'année";
                tableTousDemande.Columns[5].Name = "État Demande";
                tableTousDemande.Columns[6].Name = "Service Employeur";

                foreach (DataGridViewColumn column in tableTousDemande.Columns)
                {
                    if (column.Name != "checkboxColumn")
                    {
                        column.ReadOnly = true;
                    }
                }
            }

            tableTousDemande.Rows.Clear();

            String search = "%" + txtRecherche.Text + "%";
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            string query = "SELECT IM_per, nom_per, prenom_per, annee_cg, etat_demande, nom_serv FROM personne JOIN conge  ON personne.id_per = conge.id_per JOIN service  ON personne.id_serv = service.id_serv WHERE IM_per LIKE '" + search + "' or nom_per LIKE '" + search + "%' or annee_cg LIKE '" + search + "%' ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader data = cmd.ExecuteReader();

            while(data.Read())
            {
                string Matricule = data["IM_per"].ToString();
                string Nom = data["nom_per"].ToString();
                string  Prenom = data["prenom_per"].ToString();
                int AnneeConge = Convert.ToInt32(data["annee_cg"]);
                string Etat = data["etat_demande"].ToString();
                string NomService = data["nom_serv"].ToString();
                tableTousDemande.Rows.Add(false, NomService, Matricule, Nom, Prenom, AnneeConge, Etat);
            }
        }
        private bool veriferCheckboxSelectionner(DataGridView dgv)
        {
            int selectedCount = 0;
            DataGridViewRow selectedRow = null;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells["checkboxColumn"];
                if (checkbox.Value != null && (bool)checkbox.Value)
                {
                    selectedCount++;
                    selectedRow = row;
                }
            }

            if (selectedCount == 1)
            {
                return true;
            }
            else if (selectedCount == 0)
            {
                MessageBox.Show("Veuillez sélectionner une seule ligne.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Vous ne pouvez sélectionner qu'une seule ligne à la fois.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            checkboxacocher(tableTousDemande, false);
        }

        private void btnCochertous_Click(object sender, EventArgs e)
        {
            checkboxacocher(tableTousDemande, true);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (veriferCheckboxSelectionner(tableTousDemande))
            {
                DataGridViewRow selectedRow = null;
                foreach (DataGridViewRow row in tableTousDemande.Rows)
                {
                    DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells["checkboxColumn"];
                    if (checkbox.Value != null && (bool)checkbox.Value)
                    {
                        selectedRow = row;
                        break;
                    }
                }

                if (selectedRow != null)
                {
                    string matricule = selectedRow.Cells["Matricule"].Value.ToString();
                    string nom = selectedRow.Cells["Nom"].Value.ToString();
                    string prenom = selectedRow.Cells["Prénom"].Value.ToString();
                    int anneeConge = Convert.ToInt32(selectedRow.Cells["Conger de l'année"].Value); 
                    float jours = Convert.ToSingle(selectedRow.Cells["Nombre de jours"].Value);
                    string serviceEmployeur = selectedRow.Cells["Service Employeur"].Value.ToString();

                    MySqlConnection con = new MySqlConnection(url);
                    try
                    {
                        con.Open();

                        string queryPersonne = "SELECT id_per FROM personne WHERE IM_per = '"+matricule+"'";
                        MySqlCommand cmdPersonne = new MySqlCommand(queryPersonne, con);
                        MySqlDataReader reader = cmdPersonne.ExecuteReader();

                        int idp, idCg;
                        if (reader.Read())
                        {
                            idp = reader.GetInt32(reader.GetOrdinal("id_per"));
                            reader.Close();

                            string queryCg = "SELECT id_cg FROM conge WHERE id_per ='"+idp+"' AND annee_cg ='"+anneeConge+"' ";
                            MySqlCommand cmdCg = new MySqlCommand(queryCg, con);
                            MySqlDataReader r = cmdCg.ExecuteReader();
                            if (r.Read())
                            {
                                idCg = r.GetInt32(r.GetOrdinal("id_cg"));
                                r.Close();

                                FormModification formMod = new FormModification(idp, idCg, matricule, nom, prenom, anneeConge, jours, serviceEmployeur);
                                
                                if (formMod.ShowDialog() == DialogResult.OK)
                                {
                                    chargerTable();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Congé non trouvé.");
                                r.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Congé non trouvé.");
                            reader.Close(); 
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
            }
        }
    }
}
