using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShippingCompany
{
    public class Costumer
    {
        public string companyName;
        public string personName;

        public List<Costumer> GetAllCostumers()
        {
            List<Costumer> costumers = new List<Costumer>();
            Costumer costumer = new Costumer();
            costumer.companyName = "test01";
            costumer.personName = "testen01";

            costumers.Add(costumer);
            
            //todo
            return costumers;
        }
    }
}
