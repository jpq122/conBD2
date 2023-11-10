using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConBD2
{
    internal class Maison
    {

        public int ID { get; set; }
        public string Categorie { get; set; }
        public double Prix { get; set; }
        public string Ville { get; set; }
        public int ProprietaireID { get; set; }

       
        public string PrixFormate => Prix.ToString("C");

        public Maison(int id, string categorie, double prix, string ville, int proprietaireID)
        {
            ID = id;
            Categorie = categorie;
            Prix = prix;
            Ville = ville;
            ProprietaireID = proprietaireID;
        }


    }

}