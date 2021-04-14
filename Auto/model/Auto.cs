using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class Auto
    {
        private int id;
        private decimal hinta;
        private DateTime rekisteri_paivamaara;
        private decimal moottorin_tilavuus;
        private int mittarilukema;
        private int autonmerkki_id;
        private int autonmalli_id;
        private int varit_id;
        private int polttoaine_id;


        public int Id { get => id; set => id = value; }
        public decimal Hinta { get => hinta; set => hinta = value; }
        public DateTime Rekisteri_paivamaara { get => rekisteri_paivamaara; set => rekisteri_paivamaara = value; }
        public decimal Moottorin_tilavuus { get => moottorin_tilavuus; set => moottorin_tilavuus = value; }
        public int Mittarilukema { get => mittarilukema; set => mittarilukema = value; }
        public int Autonmerkki_id { get => autonmerkki_id; set => autonmerkki_id = value; }
        public int Autonmalli_id { get => autonmalli_id; set => autonmalli_id = value; }
        public int Varit_id { get => varit_id; set => varit_id = value; }
        public int Polttoaine_id { get => polttoaine_id; set => polttoaine_id = value; }
    }

    public class AutonMalli
    {
        private int id;
        private string auton_mallin_nimi;
        private int autonmerkkiId;

        public int Id { get => id; set => id = value; }
        public string Auton_mallin_nimi { get => auton_mallin_nimi; set => auton_mallin_nimi = value; }
        public int AutonmerkkiId { get => autonmerkkiId; set => autonmerkkiId = value; }
    }

    public class AutonMerkki
    {
        private int id;
        private string merkki;

        public int Id { get => id; set => id = value; }
        public string Merkki { get => merkki; set => merkki = value; }
    }

    public class Polttoaine
    {
        private int id;
        private string polttoaineen_nimi;

        public int Id { get => id; set => id = value; }
        public string Polttoaineen_nimi { get => polttoaineen_nimi; set => polttoaineen_nimi = value; }
    }

    public class Varit
    {
        private int id;
        private string varin_nimi;

        public int Id { get => id; set => id = value; }
        public string Varin_nimi { get => varin_nimi; set => varin_nimi = value; }
    }
}