using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShippingCompany
{
    public class Destination
    {
        public int id;
        public string name;
        public string land;

        public Destination() { }

        public Destination(int id, string name, string land) 
        {
            this.id = id;
            this.name = name;
            this.land = land;
        }

        //Return all destinations in a list
        public static List<Destination> GetAll()
        {
            List<Destination> destinations = new List<Destination>();

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT * FROM DESTINATIONS");

                db.OpenConnection();
                db.ExecuteCommand();

                OracleDataReader dr = db.DataReader;

                while (dr.Read())
                {
                    int id = dr.GetValueByColumn<int>("ID");
                    string name = dr.GetValueByColumn<string>("NAME");
                    string land = dr.GetValueByColumn<string>("LAND");


                    destinations.Add(new Destination(id, name, land));
                }
            }
            catch (Exception ex)
            {
                //If database error return unsuccesfull
                return null;
            }
            finally
            {
                //Always close connection
                db.CloseConnection();
            }

            return destinations;
        }
    }
}
