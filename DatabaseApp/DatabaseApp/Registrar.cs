using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyServices
{
    public abstract class Registrar
    {
        public PlatformAPI.IDatabase Database { get; set; }
        public PlatformAPI.IDeviceInfo DeviceInfo { get; set; }
        public abstract void register();
    }
}
