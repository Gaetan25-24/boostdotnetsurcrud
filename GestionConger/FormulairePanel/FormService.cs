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
using System.Windows.Forms;

namespace GestionConger.FormulairePanel
{
    public partial class FormService : Form
    {
        private string url = "database=gestioncongeannuel; server=localhost; user id=root; pwd=";
        public FormService()
        {
            InitializeComponent();
            labelNomRecuperer.Visible = false; 
            tableServ.CellClick += new DataGridViewCellEventHandler(tableServ_CellClick);
        }

        private void txtNomServ_KeyPress(object sender, KeyPressEventArgs e)
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
        public void afficheTable()
        {
            tableServ.ColumnCount = 1;
            tableServ.Columns[0].Name = "Service";
            tableServ.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in tableServ.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            GestionService s1 = new GestionService();
            List<GestionService> infopersonne = s1.RecupererService();
            foreach (GestionService info in infopersonne)
            {
                tableServ.Rows.Add(info.NomServ);
            }
        }
        public void effacheChamp()
        {
            txtNomServ.Text = "";
            labelNomRecuperer.Text = "";
        }
        public void chargerTable()
        {
            if (tableServ.Columns.Count == 1)
            {
                tableServ.ColumnCount = 1;
                tableServ.Columns[0].Name = "Service";
                tableServ.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            tableServ.Rows.Clear();
            foreach (DataGridViewColumn column in tableServ.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            GestionService s1 = new GestionService();
            List<GestionService> infopersonne = s1.RecupererService();
            foreach (GestionService info in infopersonne)
            {
                tableServ.Rows.Add(info.NomServ);
            }
        }
        private bool ServiceDejaDemande(string nomServ)
        {
            using (MySqlConnection con = new MySqlConnection(url))
            {
                con.Open();
                string req = "SELECT nom_serv FROM service WHERE nom_serv = @nomServ";
                MySqlCommand cmd = new MySqlCommand(req, con);
                cmd.Parameters.AddWithValue("@nomServ", nomServ);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }
        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomServ.Text))
            {
                MessageBox.Show("Veuillez renseigner tous le champs.");
                return;
            }
            string nomServ = txtNomServ.Text;
            if (ServiceDejaDemande(nomServ))
            {
                MessageBox.Show(nomServ + " éxiste déjà.");
                effacheChamp();
                return;
            }
            Service s1 = new Service(nomServ);
            GestionService gp = new GestionService();
            try
            {
                gp.addService(s1);
                chargerTable();
                effacheChamp();
                MessageBox.Show("Service bien ajouté.");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormService_Load(object sender, EventArgs e)
        {
            afficheTable();
        }
        private void tableServ_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void tableServ_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void tableServ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            if (txtNomServ.Text == "")
            {
                MessageBox.Show("Veuilllez sélectionner un enregistrement");
                return;
            }
            string idServ = labelNomRecuperer.Text;
            GestionService gp = new GestionService();
            try
            {
                gp.supprimerServ(idServ);
                chargerTable();
                effacheChamp();
                MessageBox.Show("Suppression evec succes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModifi_Click(object sender, EventArgs e)
        {
            if(txtNomServ.Text == "")
            {
                MessageBox.Show("Veuilllez sélectionner un enregistrement");
                return;
            }
            string serv = txtNomServ.Text;
            string idServ = labelNomRecuperer.Text;
            GestionService gp = new GestionService();
            try
            {
                gp.modifiServ(serv, idServ);
                chargerTable();
                effacheChamp();
                MessageBox.Show("Modification avec succes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tableServ_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tableServ_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tableServ.Rows[e.RowIndex];

                txtNomServ.Text = row.Cells["Service"].Value.ToString();
                string service = txtNomServ.Text;

                MySqlConnection con = new MySqlConnection(url);
                try
                {
                    con.Open();

                    string queryPersonne = "SELECT id_serv FROM service WHERE nom_serv = @service";
                    MySqlCommand cmdPersonne = new MySqlCommand(queryPersonne, con);
                    cmdPersonne.Parameters.AddWithValue("@service", service);

                    MySqlDataReader reader = cmdPersonne.ExecuteReader();
                    if (reader.Read())
                    {
                        int id = reader.GetInt32("id_serv");
                        labelNomRecuperer.Text = id.ToString();
                    }
                    reader.Close();
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
