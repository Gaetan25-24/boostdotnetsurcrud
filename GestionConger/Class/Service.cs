using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionConger.Class
{
    internal class Service
    {
        private string nom_serv;
        private string imputation;

        public Service()
        {

        }

        public Service(string nom_serv)
        {
            this.nom_serv = nom_serv;
        }

        public Service(string nom_serv, string imputation)
        {
            this.Nom_serv = nom_serv;
            this.Imputation = imputation;
        }

        public string Nom_serv { get => nom_serv; set => nom_serv = value; }
        public string Imputation { get => imputation; set => imputation = value; }
    }
}
