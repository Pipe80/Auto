using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace Autokauppa.model
{
    public class DatabaseHallinta
    {
        string conInfo;
        public SqlConnection dataYhteys = new SqlConnection();
        SqlDataReader justCom;
        SqlCommand command;


        public DatabaseHallinta()
        {
            conInfo = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Autot;Integrated Security=True;";
        }

        public bool connectDatabase()
        {
            dataYhteys.ConnectionString = conInfo;

            try
            {
                dataYhteys.Open();
                Console.WriteLine("Tietokantayhteys onnistui!!");
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Virhe:" + e);
                dataYhteys.Close();
                return false;

            }

        }

        public void disconnectDatabase()
        {
            dataYhteys.Close();
        }

        public List<AutonMerkki> getAllAutoMakersFromDatabase()
        {
            List<AutonMerkki> listmerkki = new List<AutonMerkki>();
            connectDatabase();

            command = new SqlCommand("select * from dbo.AutonMerkki", dataYhteys);
            justCom = command.ExecuteReader();

            while (justCom != null && justCom.Read())
            {

                AutonMerkki merkki = new AutonMerkki()
                {
                    Id = (int)justCom["ID"],
                    Merkki = justCom["Merkki"].ToString()
                };
                listmerkki.Add(merkki);
            }

            disconnectDatabase();

            return listmerkki;

        }
        public bool saveAutoIntoDatabase(Auto tallennaAuto)
        {
      
            dataYhteys = new SqlConnection();
            dataYhteys.ConnectionString = conInfo;
            string sql = "insert into Auto ([Hinta], [Rekisteri_paivamaara], [Moottorin_tilavuus], [Mittarilukema], [AutonMerkkiID], [AutonMalliID], [VaritID], [PolttoaineID]), values(@Hinta, @Rekisteri_paivamaara, @Moottorin_tilavuus, @Mittarilukema, @AutonMerkkiID, @AutonMalliID, @VaritID, @PolttoaineID)";
            dataYhteys.Open();
            using (SqlCommand tallennappa = new SqlCommand(sql, dataYhteys))
            {
                tallennappa.Parameters.Add("@Hinta", System.Data.SqlDbType.Decimal).Value = tallennaAuto.Hinta;
                tallennappa.Parameters.Add("@Rekisteri_paivamaara", System.Data.SqlDbType.DateTime).Value = tallennaAuto.Rekisteri_paivamaara;
                tallennappa.Parameters.Add("@Moottorin_Tilavuus", System.Data.SqlDbType.Decimal).Value = tallennaAuto.Moottorin_tilavuus;
                tallennappa.Parameters.Add("@Mittarilukema", System.Data.SqlDbType.Int).Value = tallennaAuto.Mittarilukema;
                tallennappa.Parameters.Add("@AutonMerkkiID", System.Data.SqlDbType.Int).Value = tallennaAuto.Autonmerkki_id;
                tallennappa.Parameters.Add("@AutonMalliID", System.Data.SqlDbType.Int).Value = tallennaAuto.Autonmalli_id;
                tallennappa.Parameters.Add("@VaritID", System.Data.SqlDbType.Int).Value = tallennaAuto.Varit_id;
                tallennappa.Parameters.Add("@PolttoaineID", System.Data.SqlDbType.Int).Value = tallennaAuto.Polttoaine_id;
            }
            bool palaute = false;
            dataYhteys.Close();
            return palaute;
        }

        public List<AutonMalli> getAutoModelsByMakerId(int makerId)
        {
            List<AutonMalli> malliTwo = new List<AutonMalli>();
            connectDatabase();
            command = new SqlCommand("select * from dbo.AutonMallit where AutonMerkkiID = " + makerId, dataYhteys);
            justCom = command.ExecuteReader();

            while (justCom != null && justCom.Read())
            {
                AutonMalli malli = new AutonMalli()
                {
                    Id = (int)justCom["ID"],
                    Auton_mallin_nimi = justCom["Auton_mallin_nimi"].ToString(),
                    AutonmerkkiId = (int)justCom["AutonMerkkiID"]
                };
                malliTwo.Add(malli);
            }
            disconnectDatabase();
            return malliTwo;

        }

        public List<string> getAutogasDB()
        {
            List<string> pentsa = new List<string>();
            dataYhteys = new SqlConnection();
            dataYhteys.ConnectionString = conInfo;
            dataYhteys.Open();
            using (SqlCommand selectBensa = new SqlCommand("Select Polttoaineen_Nimi from Polttoaine", dataYhteys))
            {
                using (SqlDataReader dr = selectBensa.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        pentsa.Add(dr[0].ToString());
                    }
                }
            }
            dataYhteys.Close();
            return pentsa;
        }
        public List <string> getAutocolorDB()
        {
            List<string> colorReturn = new List<string>();
            dataYhteys = new SqlConnection();
            dataYhteys.ConnectionString = conInfo;
            dataYhteys.Open();
            using (SqlCommand vareja = new SqlCommand("Select Varin_Nimi from Varit", dataYhteys))
            {
                using (SqlDataReader dr = vareja.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        colorReturn.Add(dr[0].ToString());
                    }
                }
            }
            dataYhteys.Close();

            return colorReturn;
        

        }
    }
}