using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppwithNhibernate
{
    class CustomerDao : ICustomer
    {
        string resultMsg = string.Empty;
        public string AddCustomer(CustomerInfo conInfo)
        {
            using (ISession session = SessionFactory.OpenSession)
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(conInfo);
                        transaction.Commit();
                        resultMsg = "New contact added successfully.";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        resultMsg = ex.Message;
                    }
                }
            }
            return resultMsg;
        }
        public string UpdateCustomer(CustomerInfo conInfo)
        {
            using (ISession session = SessionFactory.OpenSession)
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(conInfo);
                        transaction.Commit();
                        resultMsg = "Contact updated successfully.";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        resultMsg = ex.Message;
                    }
                }
            }
            return resultMsg;
        }
        public string DeleteCustomer(CustomerInfo conInfo)
        {
            using (ISession session = SessionFactory.OpenSession)
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {

                        session.Delete(conInfo); //delete the record 
                        transaction.Commit(); //commit it 
                        resultMsg = "Contact deleted successfully.";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        resultMsg = ex.Message;
                    }
                }
            }
            return resultMsg;
        }
        public IList GetCustomers()
        {
            using (ISession session = SessionFactory.OpenSession)
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var contactList = session.Query<CustomerInfo>().ToList();
                    return contactList;
                }
            }
        }
    }
}
