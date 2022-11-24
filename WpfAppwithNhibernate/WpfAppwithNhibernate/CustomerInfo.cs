using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppwithNhibernate
{
    public class CustomerInfo : IDataErrorInfo
    {
        public virtual int CustomerId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int MobileNumber { get; set; }
        public virtual string Address { get; set; }

        public virtual string Error
        {
            get
            {
                return this[string.Empty];
            }
        }

        public virtual string this[string columnName]
        {
            get
            {
                if (columnName == "FirstName")
                {
                    if (string.IsNullOrEmpty(columnName))

                    {

                        return "Name Cannot be Empty.";

                    }
                }
                return null;
            }
        }
    }
}
