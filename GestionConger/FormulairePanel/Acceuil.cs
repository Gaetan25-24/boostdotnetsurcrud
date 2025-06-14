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
using System.Windows.Forms.DataVisualization.Charting;

namespace GestionConger.FormulairePanel
{
    public partial class Acceuil : Form
    {
        private string url = "Server=localhost; Database=gestioncongeannuel; Uid=root; Password=";
        private int defaultYear = -1;
        private Timer timerBlink;
        private bool LabelVisible = true;
        private Timer timerDateTime;
        public Acceuil()
        {
            InitializeComponent();

            FillYearComboBox(); 
            cbAnne.SelectedIndexChanged += ComboBoxYear_SelectedIndexChanged;

        }

        private void TimerDateTime_Tick(object sender, EventArgs e)
        {
            string jours = DateTime.Now.ToString("dddd");
            //pour mettre en majuscule le premier lettre du jour
            string Jours = char.ToUpper(jours[0]) + jours.Substring(1).ToLower();
            labelJour.Text = Jours;
            labelDate.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void TimerBlink_Tick(object sender, EventArgs e)
        {
            LabelVisible = !LabelVisible;
            labelPhrase.Visible = LabelVisible;
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
            if (defaultYear != -1)
            {
                LoadChart(defaultYear);
            }
            labelPhrase.Text = "";

            timerBlink = new Timer();
            //temps de clignote pendant 1seconde
            timerBlink.Interval = 1000;
            timerBlink.Tick += TimerBlink_Tick;

            nbrdemandeenattente();

            labelDate.Text = "";
            labelJour.Text = "";

            timerDateTime = new Timer();
            timerDateTime.Interval = 1000;
            timerDateTime.Tick += TimerDateTime_Tick;

            timerDateTime.Start();
        }
        private void FillYearComboBox()
        {
            using (MySqlConnection con = new MySqlConnection(url))
            {
                try
                {
                    con.Open();

                    string query = @"
                        SELECT DISTINCT annee_cg AS AnneeDemande FROM conge WHERE annee_cg IS NOT NULL ORDER BY AnneeDemande desc";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cbAnne.Items.Clear();

                    while (reader.Read())
                    {
                        var year = reader["AnneeDemande"];
                        if (year != DBNull.Value)
                        {
                            string yearStr = year.ToString();
                            cbAnne.Items.Add(yearStr);

                            if (defaultYear == -1)
                            {
                                defaultYear = int.Parse(yearStr);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Valeur NULL trouvée dans la colonne AnneeDemande.");
                        }
                    }

                    if (cbAnne.Items.Count > 0)
                    {
                        cbAnne.SelectedIndex = 0;
                    }
                    else
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du remplissage du Liste : " + ex.Message);
                }
            }
        }

        private void ComboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedYear;
            if (int.TryParse(cbAnne.SelectedItem.ToString(), out selectedYear))
            {
                LoadChart(selectedYear);
            }
            else
            {
                MessageBox.Show("Erreur : Année sélectionnée invalide.");
            }
        }

        private void LoadChart(int yearFilter)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection con = new MySqlConnection(url))
            {
                try
                {
                    con.Open();

                    string query = @"
                        SELECT service.nom_serv AS ServiceEmployeur, COUNT(*) AS NombreDemandes FROM conge JOIN personne ON conge.id_per = personne.id_per
                        JOIN service ON personne.id_serv = service.id_serv WHERE annee_cg = @YearFilter GROUP BY ServiceEmployeur ORDER BY ServiceEmployeur";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@YearFilter", yearFilter);
                    adapter.Fill(dataTable);

                    chart.Series.Clear();
                    chart.ChartAreas.Clear();

                    ChartArea chartArea = new ChartArea("ChartArea1");
                    chart.ChartAreas.Add(chartArea);

                    Series series = new Series(yearFilter.ToString());
                    series.ChartType = SeriesChartType.Column;
                    chart.Series.Add(series);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string service = row["ServiceEmployeur"].ToString();
                        int count = Convert.ToInt32(row["NombreDemandes"]);
                        series.Points.AddXY(service, count);
                    }

                    chart.Titles.Clear();
                    chart.Titles.Add($"Nombre de Demandes de Congé en {yearFilter} par Service");

                    chart.ChartAreas[0].AxisX.Title = "Service Employeur";
                    chart.ChartAreas[0].AxisY.Title = "Nombre de Demandes";
                    chart.Series[0].IsValueShownAsLabel = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement du graphique : " + ex.Message);
                }
            }
        }

        private void cbAnne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void nbrdemandeenattente()
        {
            MySqlConnection con = new MySqlConnection(url);
            try
            {
                con.Open();
                string query = "SELECT COUNT(id_cg) FROM conge WHERE etat_demande='En Cours De Traitement.' ";
                MySqlCommand cmd = new MySqlCommand(query, con);
                int nbr = Convert.ToInt32(cmd.ExecuteScalar());

                labelPhrase.Text = $"Vous avez {nbr} demande(s) en attente.";
                timerBlink.Start();
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

        private void labelJour_Click(object sender, EventArgs e)
        {

        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
