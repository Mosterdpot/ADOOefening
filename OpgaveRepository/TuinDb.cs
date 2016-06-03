using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveRepository
{
    public  class TuinDb
    {
        private static ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["Tuin"];
        private static DbProviderFactory factory = DbProviderFactories.GetFactory(settings.ProviderName);

        //public TuinDb()
        //{

        //}

        public DbConnection GetConnection()
        {
            var conTuin = factory.CreateConnection();
            conTuin.ConnectionString = settings.ConnectionString;
            return conTuin;
        }




    }
}
