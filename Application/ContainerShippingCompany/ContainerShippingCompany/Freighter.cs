using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShippingCompany
{
    public class Freighter
    {
        public int id;
        public string shipType;
        public int maxHeight;
        public int containerRows;
        public int containersEachRow;
        public int powerSupply;

        public Freighter() { }

        public Freighter(int id, string shiptype, int maxheight, int containerrows, int containerseachrow, int powersupply) 
        {
            this.id = id;
            this.shipType = shiptype;
            this.maxHeight = maxheight;
            this.containerRows = containerrows;
            this.containersEachRow = containerseachrow;
            this.powerSupply = powersupply;
        }

        public static List<Freighter> GetAll()
        {
            List<Freighter> freighters = new List<Freighter>();

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT * FROM FREIGHTERS");

                db.OpenConnection();
                db.ExecuteCommand();

                OracleDataReader dr = db.DataReader;

                while (dr.Read())
                {
                    int id = dr.GetValueByColumn<int>("ID");
                    string type = dr.GetValueByColumn<string>("SHIPTYPE");
                    int maxheight = dr.GetValueByColumn<int>("MAXHEIGHT");
                    int containerrows = dr.GetValueByColumn<int>("CONTAINERROWS");
                    int containerseachrow = dr.GetValueByColumn<int>("CONTAINERSEACHROW");
                    int powersupply = dr.GetValueByColumn<int>("POWERSUPPLY");

                    freighters.Add(new Freighter(id, type, maxheight, containerrows, containerseachrow, powersupply));
                }
            }
            finally
            {
                db.CloseConnection();
            }

            return freighters;
        }
    }
}
