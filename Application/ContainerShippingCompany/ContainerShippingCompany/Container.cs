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

        public Costumer()
        {

        }

        //For future use - not jet implemented
        public bool Add(Costumer costumer, ContainerType containerType, int weight, string gpscode)
        {
            try
            {
                db.OpenConnection();

                db.CreateCommand("INSERT INTO CONTAINER (ADDITIONALWEIGHT, COSTUMER_ID, CONTAINER_TYPE_ID, GPSCODE) VALUES (:weight, :costumer_id, :container_type_id, :gpscode);");
                db.AddParameter("weight", weight);
                db.AddParameter("costumer_id", costumer.id);
                db.AddParameter("container_type_id", containerType.id);
                db.AddParameter("gpscode", gpscode);

                db.ExecuteCommand();
                db.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Add(Costumer costumer,ContainerType containerType, int weight)
        {
            try
            {
                db.OpenConnection();

                db.CreateCommand("INSERT INTO CONTAINER (ADDITIONALWEIGHT, COSTUMER_ID, CONTAINER_TYPE_ID) VALUES (:weight, :costumer_id, :container_type_id);");
                db.AddParameter("weight", weight);
                db.AddParameter("costumer_id", costumer.id);
                db.AddParameter("container_type_id", containerType.id);

                db.ExecuteCommand();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool Delete(int id)
        {
            try
            {
                db.OpenConnection();

                db.CreateCommand("DELETE FROM CONTAINER WHERE ID = :id");
                db.AddParameter("id", id);

                db.ExecuteCommand();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public Costumer GetContainerById(int id)
        {
            Container container = null;
            try
            {
                db.OpenConnection();

                db.CreateCommand("SELECT * FROM CONTAINER WHERE ID = :id");
                db.AddParameter("id", id);

                db.ExecuteCommand();

                OracleDataReader dr = db.DataReader;

                while (dr.Read())
                {
                    string title = dr.GetValueByColumn<string>("ADDITIONALWEIGHT");
                    int parentId = dr.GetValueByColumn<int>("files_categories_id");

                    container = new Container(id, title, parentId);
                }

                return null;
            }
            catch (Exception ex)
            {
                //Error
                return null;
            }
            finally
            {
                db.CloseConnection();
            }
        }

    }
}
