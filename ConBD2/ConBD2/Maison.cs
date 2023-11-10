using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConBD2
{
    internal class Maison
    {
            
            private int ID;
            private String categorie;
            private double prix;
            private String ville;
            private int proprietaireID;

            public Maison(int ID, String categorie, double prix, String ville, int proprietaireID)
            {
                this.ID = ID;
                this.categorie = categorie;
                this.prix = prix;
                this.ville = ville;
                this.proprietaireID = proprietaireID;
            }

            
    }

}