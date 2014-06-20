using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShippingCompany
{
    public class Container
    {
        private Database db = new Database();
        public int id { get; set; }
        public int weight { get; set; }
        public Costumer costumer;
        public ContainerType containerType;
        public int positionX;
        public int positionY;
        public int positionZ;

        //for future use
        string gpscode;

        public Container() { }

        public Container(int id, int weight, ContainerType containertype, Costumer costumer)
        {
            this.id = id;
            this.weight = weight;
            this.containerType = containertype;
            this.costumer = costumer;
        }

        //For future use - not jet implemented
        public bool Add(Costumer costumer, ContainerType containerType, int weight, string gpscode)
        {
            try
            {
                db.OpenConnection();

                db.CreateCommand("INSERT INTO CONTAINERS (ADDITIONALWEIGHT, COSTUMER_ID, CONTAINER_TYPE_ID, GPSCODE) VALUES (:weight, :costumer_id, :container_type_id, :gpscode);");
                db.AddParameter("weight", weight);
                db.AddParameter("costumer_id", costumer.id);
                db.AddParameter("container_type_id", containerType.id);
                db.AddParameter("gpscode", gpscode);

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

        public bool Add(Costumer costumer,ContainerType containerType, int weight)
        {
            try
            {
                db.OpenConnection();

                db.CreateCommand("INSERT INTO CONTAINERS (ADDITIONALWEIGHT, STATUS, COSTUMERS_ID, CONTAINER_TYPE_ID) VALUES (:weight, :status, :costumer_id, :container_type_id)");
                db.AddParameter("weight", weight);
                db.AddParameter("status", "Niet ingepland");
                db.AddParameter("costumer_id", costumer.id);
                db.AddParameter("container_type_id", containerType.id);

                db.ExecuteCommand();
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                db.CloseConnection();
            }

            return true;
        }

        public bool Delete(int id)
        {
            try
            {
                db.OpenConnection();

                db.CreateCommand("DELETE FROM CONTAINERS WHERE ID = :id");
                db.AddParameter("id", id);

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

        public Container GetContainerById(int id)
        {
            Container container = new Container();
            try
            {
                db.OpenConnection();

                db.CreateCommand("SELECT * FROM CONTAINER WHERE ID = :id");
                db.AddParameter("id", id);
                
                db.OpenConnection();
                db.ExecuteCommand();

                OracleDataReader dr = db.DataReader;

                while (dr.Read())
                {
                    int Cid = dr.GetValueByColumn<int>("ID");
                    int weight = dr.GetValueByColumn<int>("ADDITIONALWEIGHT");
                    int type_id = dr.GetValueByColumn<int>("CONTAINER_TYPE_ID");
                    int cus_id = dr.GetValueByColumn<int>("COSTUMERS_ID");

                    db.CreateCommand("SELECT * FROM CONTAINER_TYPE WHERE ID = :id");
                    db.AddParameter("id", type_id);

                    db.OpenConnection();
                    db.ExecuteCommand();

                    OracleDataReader datar = db.DataReader;

                    while (datar.Read())
                    {
                        int typeid = datar.GetValueByColumn<int>("ID");
                        string name = datar.GetValueByColumn<string>("NAME");
                        int valauble = datar.GetValueByColumn<int>("VALUABLE");
                        int chilled = datar.GetValueByColumn<int>("CHILLED");

                        containerType = new ContainerType(typeid,name,valauble,chilled);
                    }

                    db.CreateCommand("SELECT * FROM COSTUMERS WHERE ID = :id");
                    db.AddParameter("id", cus_id);

                    db.OpenConnection();
                    db.ExecuteCommand();

                    datar = db.DataReader;

                    while (datar.Read())
                    {
                        int cusid = datar.GetValueByColumn<int>("ID");
                        string comname = datar.GetValueByColumn<string>("COMPANYNAME");
                        string conname = datar.GetValueByColumn<string>("CONTACTNAME");
                        int kvknumber = datar.GetValueByColumn<int>("KVKNUMBER");

                        costumer = new Costumer(cusid, comname, conname, kvknumber);
                    }

                    container = new Container(id, weight, containerType, costumer);
                }
            }
            finally
            {
                db.CloseConnection();
            }

            return container;
        }

        public List<Container> GetNonShippedContainerList()
        {
            List<Container> containers = new List<Container>();

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT * FROM CONTAINERS WHERE STATUS = :status");
                db.AddParameter("status", "Niet ingepland");

                db.OpenConnection();
                db.ExecuteCommand();

                OracleDataReader dr = db.DataReader;

                while (dr.Read())
                {
                    int id = dr.GetValueByColumn<int>("ID");
                    int weight = dr.GetValueByColumn<int>("ADDITIONALWEIGHT");
                    int type_id = dr.GetValueByColumn<int>("CONTAINER_TYPE_ID");
                    int cus_id = dr.GetValueByColumn<int>("COSTUMERS_ID");

                    db.CreateCommand("SELECT * FROM CONTAINER_TYPE WHERE ID = :id");
                    db.AddParameter("id", type_id);

                    db.OpenConnection();
                    db.ExecuteCommand();

                    OracleDataReader datar = db.DataReader;

                    while (datar.Read())
                    {
                        int typeid = datar.GetValueByColumn<int>("ID");
                        string name = datar.GetValueByColumn<string>("NAME");
                        int valauble = datar.GetValueByColumn<int>("VALUABLE");
                        int chilled = datar.GetValueByColumn<int>("CHILLED");

                        containerType = new ContainerType(typeid,name,valauble,chilled);
                    }

                    db.CreateCommand("SELECT * FROM COSTUMERS WHERE ID = :id");
                    db.AddParameter("id", cus_id);

                    db.OpenConnection();
                    db.ExecuteCommand();

                    datar = db.DataReader;

                    while (datar.Read())
                    {
                        int cusid = datar.GetValueByColumn<int>("ID");
                        string comname = datar.GetValueByColumn<string>("COMPANYNAME");
                        string conname = datar.GetValueByColumn<string>("CONTACTNAME");
                        int kvknumber = datar.GetValueByColumn<int>("KVKNUMBER");

                        costumer = new Costumer(cusid, comname, conname, kvknumber);
                    }

                    containers.Add(new Container(id, weight, containerType, costumer));
                }
            }
            finally
            {
                db.CloseConnection();
            }

            return containers;
        }


        public List<Container> GetNonShippedContainerList(Costumer costumer)
        {
            List<Container> containers = new List<Container>();

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT * FROM CONTAINERS WHERE COSTUMERS_ID = :id AND STATUS = :status");
                db.AddParameter("id", costumer.id);
                db.AddParameter("status", "Niet ingepland");

                db.OpenConnection();
                db.ExecuteCommand();

                OracleDataReader dr = db.DataReader;

                while (dr.Read())
                {
                    int id = dr.GetValueByColumn<int>("ID");
                    int weight = dr.GetValueByColumn<int>("ADDITIONALWEIGHT");
                    int type_id = dr.GetValueByColumn<int>("CONTAINER_TYPE_ID");

                    db.CreateCommand("SELECT * FROM CONTAINER_TYPE WHERE ID = :id");
                    db.AddParameter("id", type_id);

                    db.OpenConnection();
                    db.ExecuteCommand();

                    dr = db.DataReader;

                    while (dr.Read())
                    {
                        int typeid = dr.GetValueByColumn<int>("ID");
                        string name = dr.GetValueByColumn<string>("NAME");
                        int valauble = dr.GetValueByColumn<int>("VALUABLE");
                        int chilled = dr.GetValueByColumn<int>("CHILLED");

                        containerType = new ContainerType(typeid, name, valauble, chilled);
                    }

                    containers.Add(new Container(id, weight, containerType, costumer));
                }
            }
            finally
            {
                db.CloseConnection();
            }

            return containers;
        }

        public void ChangeStatusToShipped(int id)
        {
            try
            {
                db.OpenConnection();

                db.CreateCommand("UPDATE SET STATUS=:status FROM CONTAINER WHERE ID = :id");
                db.AddParameter("id", id);
                db.AddParameter("status", "Ingepland voor transport");

                db.OpenConnection();
                db.ExecuteCommand();
            }
            finally
            {
                db.CloseConnection();
            }
        }

    }
}
