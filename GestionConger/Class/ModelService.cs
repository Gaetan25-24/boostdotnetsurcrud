using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionConger.Class
{
    internal class ModelService
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        // Constructeur, ToString, etc.
        public ModelService(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }

        public override string ToString()
        {
            return Nom; // Cela permet d'afficher correctement le nom dans la combobox
        }
    }
}
