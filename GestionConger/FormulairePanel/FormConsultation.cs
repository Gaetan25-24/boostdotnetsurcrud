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
    public partial class FormConsultation : Form
    {
        private string url = "database=gestioncongeannuel; server=localhost; user id = root; pwd=";
        public FormConsultation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConsultation_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtIMConsult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtIMConsult.Text.Length >= 6)
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

        private void btnConsulter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIMConsult.Text))
            {
                tableIMConsultation.ColumnCount = 7;
                tableIMConsultation.Columns[0].Name = "Service Employeur";
                tableIMConsultation.Columns[1].Name = "Matricule";
                tableIMConsultation.Columns[2].Name = "Nom";
                tableIMConsultation.Columns[3].Name = "Prénom";
                tableIMConsultation.Columns[4].Name = "Date de démande";
                tableIMConsultation.Columns[5].Name = "Congé de l'année";
                tableIMConsultation.Columns[6].Name = "État Demande";
                tableIMConsultation.Rows.Clear();
                MessageBox.Show("Veuillez saisir un matricule à consulter.");
                return;
            }
            if (txtIMConsult.Text.Length != 6)
            {
                MessageBox.Show("Le matricule doit comporter exactement 6 caractères.");
                return;
            }
            string im = txtIMConsult.Text;
                tableIMConsultation.ColumnCount = 7;
                tableIMConsultation.Columns[0].Name = "Service Employeur";
                tableIMConsultation.Columns[1].Name = "Matricule";
                tableIMConsultation.Columns[2].Name = "Nom";
                tableIMConsultation.Columns[3].Name = "Prénom";
                tableIMConsultation.Columns[4].Name = "Date de démande";
                tableIMConsultation.Columns[5].Name = "Congé de l'année";
                tableIMConsultation.Columns[6].Name = "État Demande";

            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            string query = "SELECT IM_per, nom_per, prenom_per,date_demande, annee_cg, etat_demande, nom_serv FROM personne JOIN conge  ON personne.id_per = conge.id_per JOIN service  ON personne.id_serv = service.id_serv WHERE IM_per = '" + im + "' order by annee_cg DESC ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                string Matricule = data["IM_per"].ToString();
                string Nom = data["nom_per"].ToString();
                string Prenom = data["prenom_per"].ToString();
                string datedemande = Convert.ToDateTime(data["date_demande"]).ToString("yyyy-MM-dd");
                int AnneeConge = Convert.ToInt32(data["annee_cg"]);
                string Etat = data["etat_demande"].ToString();
                string NomService = data["nom_serv"].ToString();
                tableIMConsultation.Rows.Add(NomService,Matricule, Nom, Prenom, datedemande, AnneeConge, Etat );
                txtIMConsult.Text = "";
            }

        }

        private void txtIMConsult_Click(object sender, EventArgs e)
        {
        }

        private void txtIMConsult_Leave(object sender, EventArgs e)
        {
        }
    }
}
