using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyServices
{
    public class ServiceProvider
    {
        public Registrar Registrar { get; set; }
        private ServiceProvider() { }

        private static readonly ServiceProvider instance = new ServiceProvider();
        
        public static ServiceProvider Instance
        {
            get { return instance; }
        }

    }
}
