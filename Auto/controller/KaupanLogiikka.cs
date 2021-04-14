using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Autokauppa.model;
using System.Data;

namespace Autokauppa.controller
{
    public class KaupanLogiikka
    {
        DatabaseHallinta dbModel = new DatabaseHallinta();

        public bool TestDatabaseConnection()
        {
            bool toimiiko = dbModel.connectDatabase();
            return toimiiko;
        }

        public bool saveAuto(model.Auto newAuto)
        {
            bool didItGoIntoDatabase = dbModel.saveAutoIntoDatabase(newAuto);
            return didItGoIntoDatabase;
        }

        public List<AutonMerkki> getAllAutoMakers()
        {

            return dbModel.getAllAutoMakersFromDatabase();
        }

        public List<AutonMalli> getAutoModels(int makerId)
        {

            return dbModel.getAutoModelsByMakerId(makerId);
        }
        public List<string> getAutoColor()
        {
            return dbModel.getAutocolorDB();
        }

        public List<string> getAutoGas()
        {
            return dbModel.getAutogasDB();
        }

    }
}