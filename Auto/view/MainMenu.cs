using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autokauppa.model;
using Autokauppa.controller;
using System.Data.SqlClient;

namespace Autokauppa.view
{
    public partial class MainMenu : Form
    {
        // ei tarvita täällä. Idea on, että controlleri keskustele tietokannan kanssa. Käyttöliittymän ei tarvitse tietää mistä tieto tulee. Tämä mahdollistaa eri
        // tietolähteet.
        DatabaseHallinta dbModel = new DatabaseHallinta();

        KaupanLogiikka registerHandler = new KaupanLogiikka();

        public MainMenu()
        {
            registerHandler = new KaupanLogiikka();
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            MerkkiBox.DataSource = dbModel.getAllAutoMakersFromDatabase();
            MerkkiBox.DisplayMember = "Merkki";
            MerkkiBox.ValueMember = "ID";

            int index = MerkkiBox.SelectedIndex;

            MalliBox.DataSource = dbModel.getAutoModelsByMakerId(index);
            MalliBox.DisplayMember = "Auton_mallin_nimi";
            MalliBox.ValueMember = "ID";

            List<string> autonvärit = registerHandler.getAutoColor();
            foreach (string väri in autonvärit)
            {
                VariTextBox.Items.Add(väri);
            }

            List<string> autonpa = registerHandler.getAutoGas();
            foreach (string bensa in autonpa)
            {
                BensaBox.Items.Add(bensa);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TestaaTietokantayhteytta_Click(object sender, EventArgs e)
        {
            registerHandler.TestDatabaseConnection();
        }

        private void ComboAutonmerkki_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = MerkkiBox.SelectedIndex;


            MalliBox.DataSource = dbModel.getAutoModelsByMakerId(index);
            MalliBox.DisplayMember = "Auton_mallin_nimi";
            MalliBox.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hintatextbox.Clear();
            MalliTextBox.Clear();
            TilavuusTextBox.Clear();
            MerkkiBox.ResetText();
            MalliBox.ResetText();
            VariTextBox.ResetText();
            BensaBox.ResetText();
            dateTimePicker1.ResetText();
        }

        public void Tallennabtn_Click(object sender, EventArgs e)
        {
            string valintaAuto = MerkkiBox.SelectedItem.ToString();
            string valintabensa = BensaBox.SelectedItem.ToString();
            string valintaVari = VariTextBox.SelectedItem.ToString();
            string valintaMalli = MalliBox.SelectedItem.ToString();
            Auto uusiAuto = new Auto();
            uusiAuto.Mittarilukema = Convert.ToInt32(MalliTextBox.Text);
            uusiAuto.Moottorin_tilavuus = Convert.ToDecimal(TilavuusTextBox.Text);
            uusiAuto.Hinta = Convert.ToDecimal(Hintatextbox.Text);
            uusiAuto.Rekisteri_paivamaara = Convert.ToDateTime(dateTimePicker1.Text);
            //uusiAuto.Varit_id= registerHandler.getVariId(valintaVari);
            //uusiAuto.Polttoaine_id = registerHandler.getBensaId(valintabensa);
            //uusiAuto.Autonmalli_id= registerHandler.getMalliId(valintaMalli);
            //uusiAuto.Autonmerkki_id = registerHandler.getModelID(valintaAuto);


            registerHandler.saveAuto(uusiAuto);
            TallennaComboBox.Items.Add(uusiAuto.Id);
        }
        
    }

}