using AMNEVH.Models.OrgEntities;
using System.Configuration;

namespace AMNEVH.Models
{
    public class BusinessLayer
    {
        Executer executer;
        string connectionString = "";
        public BusinessLayer()
        {
            this.connectionString = System.Configuration.ConfigurationManager.AppSettings.Get("RWA");
            executer = new Executer();
        }
      
    }
}