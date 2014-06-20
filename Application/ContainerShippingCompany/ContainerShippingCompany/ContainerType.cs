using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShippingCompany
{
    public class ContainerType
    {
        public int id;
        public string name;
        public int valuable;
        public int chilled;

        public ContainerType() { }
        
        public ContainerType(int id, string name, int valuable, int chilled)
        {
            this.id = id;
            this.name = name;
            this.valuable = valuable;
            this.chilled = chilled;
        }

        public static List<ContainerType> GetAll()
        {
            List<ContainerType> containerTypes = new List<ContainerType>();

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT * FROM CONTAINER_TYPE");

                db.OpenConnection();
                db.ExecuteCommand();

                OracleDataReader dr = db.DataReader;

                while (dr.Read())
                {
                    int id = dr.GetValueByColumn<int>("ID");
                    string name = dr.GetValueByColumn<string>("NAME");
                    int valuable = dr.GetValueByColumn<int>("VALUABLE");
                    int chilled = dr.GetValueByColumn<int>("CHILLED");

                    containerTypes.Add(new ContainerType(id, name, valuable, chilled));
                }
            }
            finally
            {
                db.CloseConnection();
            }

            return containerTypes;
        }

    }
}
