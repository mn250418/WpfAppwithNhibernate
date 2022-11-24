using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppwithNhibernate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static readonly WindsorContainer container = new WindsorContainer();
        public App()
        {
            RegisterComponents();
        }
        private void RegisterComponents()
        {
            container.Register(Component.For<ICustomer>().ImplementedBy<CustomerDao>());
        }
    }
}
