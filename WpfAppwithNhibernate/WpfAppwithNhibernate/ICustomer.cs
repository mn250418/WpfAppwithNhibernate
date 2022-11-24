using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppwithNhibernate
{
    public interface ICustomer
    {
        string AddCustomer(CustomerInfo cInfo);
        string UpdateCustomer(CustomerInfo cInfo);
        string DeleteCustomer(CustomerInfo cInfo);
        IList GetCustomers();
    }
}
