using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShippingCompany
{
    public class Costumer
    {
        public int id;
        public string companyName;
        public string personName;
        public int kvkNumber;
        public Costumer moederbedrijf;

        public Costumer() { }
        public Costumer(int id, string companyname, string companyperson, int kvknumber)
        {
            this.id = id;
            this.companyName = companyname;
            this.personName = companyperson;
            this.kvkNumber = kvknumber;
        }

        public static List<Costumer> GetAll()
        {
            List<Costumer> costumers = new List<Costumer>();

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT * FROM COSTUMERS");

                db.OpenConnection();
                db.ExecuteCommand();

                OracleDataReader dr = db.DataReader;

                while (dr.Read())
                {
                    int id = dr.GetValueByColumn<int>("ID");
                    string companyname = dr.GetValueByColumn<string>("COMPANYNAME");
                    string companyperson = dr.GetValueByColumn<string>("CONTACTNAME");
                    int kvknumber = dr.GetValueByColumn<int>("KVKNUMBER");

                    costumers.Add(new Costumer(id, companyname, companyperson, kvknumber));
                }
            }
            finally
            {
                db.CloseConnection();
            }

            return costumers;
        }

        public bool Add(Costumer costumer, string company, string contact, int kvk)
        {
            Database db = new Database();

            try
            {
                db.OpenConnection();

                db.CreateCommand("INSERT INTO COSTUMERS (COMPANYNAME, CONTACTNAME, KVKNUMBER, COSTUMERS_ID) VALUES (:companyname, :contactname, :kvknumber, :costumer_id)");
                db.AddParameter("companyname", company);
                db.AddParameter("contactname", contact);
                db.AddParameter("kvknumber", kvk);
                db.AddParameter("costumer_id", costumer.id);

                db.ExecuteCommand();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                db.CloseConnection();
            }

            return true;
        }

    }
}
