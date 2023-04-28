using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    internal class DIP
    {
    }

    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess() {}

        public string GetCustomerNameDataAccess()
        {
            return "Customer Name";
        }
    }

    //Solution
    //Now both classes are dependent on abstractions
    public interface ICustomerDataAccess
    {
        string GetCustomerNameDataAccess();
    }

    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerName()
        {
            return new CustomerDataAccess();
        }

    }
    //This class(high-level module) dependent on Data Access class(low-level module)
    //Tightly-coupled
    //there should be abstractions in-between, non-conrete class - can't create objects of another class -> interface, abstract
    public class CustomerBL
    {
        public CustomerBL() {}

        public void GetCustomerNameBL()
        {
            //CustomerDataAccess obj= new CustomerDataAccess();
            //obj.GetCustomerNameDataAccess();

            ICustomerDataAccess obj = DataAccessFactory.GetCustomerName();
            obj.GetCustomerNameDataAccess();
        }
    }
}
