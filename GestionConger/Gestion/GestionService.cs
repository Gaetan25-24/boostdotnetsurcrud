using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GestionConger.Class;
using MySql.Data.MySqlClient;

namespace GestionConger.Gestion
{
    internal class GestionService
    {
        private string url = "database=gestioncongeannuel; server=localhost; user id=root; pwd=";
        public string NomServ { get; set; }
        public void afficheService()
        {
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            MySqlCommand affiche = new MySqlCommand("SELECT nom_serv FROM service",con);
            affiche.ExecuteReader();
        }
        public void addService(Service obj)
        {
            MySqlConnection conex = new MySqlConnection(url);
            conex.Open();
            MySqlCommand salarier = new MySqlCommand("INSERT INTO service(nom_serv) values('" + obj.Nom_serv + "')", conex);
            salarier.ExecuteNonQuery();
            conex.Close();
        }

        public void supprimerServ(string id)
        {
            MySqlConnection conex = new MySqlConnection(url);
            try
            {
                conex.Open();
                    string req = "DELETE FROM service WHERE id_serv='" + id + "'";
                    MySqlCommand deleteSrv = new MySqlCommand(req, conex);
                    deleteSrv.ExecuteNonQuery();
                conex.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void modifiServ( string nouveauNom,string id)
        {
            MySqlConnection conex = new MySqlConnection(url);
            try
            {
                conex.Open();
                    string req = "UPDATE service SET nom_serv ='" + nouveauNom + "' WHERE id_serv='" + id + "'";
                    MySqlCommand deleteSrv = new MySqlCommand(req, conex);
                    deleteSrv.ExecuteNonQuery();
                
                conex.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<GestionService> RecupererService()
        {
            List<GestionService> list = new List<GestionService>();
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            string query = " SELECT * FROM service";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                GestionService info = new GestionService();

                info.NomServ = data["nom_serv"].ToString();

                list.Add(info);
            }

            return list;
        }
    }
}
