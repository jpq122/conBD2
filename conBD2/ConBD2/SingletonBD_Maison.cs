using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConBD2
{
    internal class SingletonBD_Maison
    {
        static SingletonBD_Maison instance = null;
        MySqlConnection con;
        ObservableCollection<Maison> listeMaisons;
    

        public SingletonBD_Maison()
        {
            con = new MySqlConnection("Server=cours.cegep3r.info; Database=a2023_420326_gr01_2260734-samuel-vinette; Uid=2260734; Pwd=2260734;");
            listeMaisons = new ObservableCollection<Maison>();
        }

        public static SingletonBD_Maison getInstance()
        {
            if (instance == null)
            {
                instance = new SingletonBD_Maison();
            }
            return instance;
        }

        public ObservableCollection<Maison> GetMaisons()
        {
            listeMaisons.Clear();
            try
            {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                con.Open();

                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {
                    string categorie = (string)r["Categorie"];
                    string prix = (double)r["Prix"];
                    string ville = (string)r["Ville"];
                    int proprietaire = (int)r["Proprietaire"];
                    Maison objmaison = new Maison {Categorie=categorie, Prix=prix, Ville=ville, ProprietaireID=proprietaire};
                    listeMaisons.Add(objmaison);
                }

                r.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }

            }
            return listeMaisons;

        }

    }
}
