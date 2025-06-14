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
    public partial class ListePersonne : UserControl
    {
        private string url = "database=gestioncongeannuel; server=localhost; user id = root; pwd=";
        public ListePersonne()
        {
            InitializeComponent();
            afficheTable();
        }
        public void afficheTable()
        {

            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Select";
            checkboxColumn.Name = "checkboxColumn";
            tablePers.Columns.Insert(0, checkboxColumn);

            tablePers.ColumnCount = 4;
            tablePers.Columns[1].Name = "Matricule";
            tablePers.Columns[2].Name = "Nom";
            tablePers.Columns[3].Name = "Prénom";

            foreach (DataGridViewColumn column in tablePers.Columns)
            {
                if (column.Name != "checkboxColumn")
                {
                    column.ReadOnly = true;
                }
            }

            GestionSalarier s1 = new GestionSalarier();
            List<GestionSalarier> infopersonne = s1.RecupererPersonne(); 
            foreach (GestionSalarier info in infopersonne)
            {
                tablePers.Rows.Add(false, info.Matricule, info.Nom, info.Prenom);
            }
        }
        public void chargerTable()
        {
            if (!tablePers.Columns.Contains("checkboxColumn"))
            {
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.HeaderText = "Select";
                checkboxColumn.Name = "checkboxColumn";
                tablePers.Columns.Insert(0, checkboxColumn);
            }

            if (tablePers.Columns.Count == 1)
            {
                tablePers.ColumnCount = 8;
                tablePers.Columns[1].Name = "Matricule";
                tablePers.Columns[2].Name = "Nom";
                tablePers.Columns[3].Name = "Prénom";

                foreach (DataGridViewColumn column in tablePers.Columns)
                {
                    if (column.Name != "checkboxColumn")
                    {
                        column.ReadOnly = true;
                    }
                }
            }
            tablePers.Rows.Clear();
            GestionSalarier s1 = new GestionSalarier();
            List<GestionSalarier> infopersonne = s1.RecupererPersonne();
            foreach (GestionSalarier info in infopersonne)
            {
                tablePers.Rows.Add(false, info.Matricule, info.Nom, info.Prenom);
            }

        }

        private void txtRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            if (!tablePers.Columns.Contains("checkboxColumn"))
            {
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.HeaderText = "Select";
                checkboxColumn.Name = "checkboxColumn";
                tablePers.Columns.Insert(0, checkboxColumn);
            }

            if (tablePers.Columns.Count == 1)
            {
                tablePers.ColumnCount = 4;
                tablePers.Columns[1].Name = "Matricule";
                tablePers.Columns[2].Name = "Nom";
                tablePers.Columns[3].Name = "Prénom";

                foreach (DataGridViewColumn column in tablePers.Columns)
                {
                    if (column.Name != "checkboxColumn")
                    {
                        column.ReadOnly = true;
                    }
                }
            }

            tablePers.Rows.Clear();

            String search = "%" + txtRecherche.Text + "%";
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            string query = "SELECT IM_per, nom_per, prenom_per FROM personne WHERE IM_per LIKE '" + search + "' or nom_per LIKE '" + search + "%' ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                string Matricule = data["IM_per"].ToString();
                string Nom = data["nom_per"].ToString();
                string Prenom = data["prenom_per"].ToString();
                tablePers.Rows.Add(false, Matricule, Nom, Prenom);
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
        private void DeleteSelectRows()
        {
            List<string> listeMatricules = new List<string>();

            foreach (DataGridViewRow row in tablePers.Rows)
            {
                // Vérifier si la ligne contient une checkbox sélectionnée
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells["checkboxColumn"];
                if (checkbox.Value != null && (bool)checkbox.Value)
                {
                    // Ajouter le matricule de la ligne à la liste
                    string matricule = row.Cells["Matricule"].Value.ToString();
                    listeMatricules.Add(matricule);
                }
            }

            if (listeMatricules.Count > 0)
            {
                SupprimerDansDatabase(listeMatricules);
            }
            else
            {
                MessageBox.Show("Aucune ligne sélectionnée.");
            }
        }

        private void SupprimerDansDatabase(List<string> matricules)
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
                    foreach (var matricule in matricules)
                    {
                        string selectQuery = "SELECT id_per FROM personne WHERE IM_per = @matricule ";
                        MySqlCommand selectCmd = new MySqlCommand(selectQuery, con);
                        selectCmd.Parameters.AddWithValue("@matricule", matricule);

                        object result = selectCmd.ExecuteScalar();
                        if (result != null)
                        {
                            int id = Convert.ToInt32(result);

                            string deleteQuery = "DELETE FROM personne WHERE id_per = @id ";
                            MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, con);
                            deleteCmd.Parameters.AddWithValue("@id", id);
                            int rowsAffected = deleteCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Matricule non trouvé : " + matricules);
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
            finally
            {
                con.Close();
            }
        }

        private void ListePersonne_Load(object sender, EventArgs e)
        {

        }

        private void btnCochertous_Click(object sender, EventArgs e)
        {
            checkboxacocher(tablePers, true);
        }

        private void btnDecocher_Click(object sender, EventArgs e)
        {
            checkboxacocher(tablePers, false);
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            DeleteSelectRows();
        }
    }
}
