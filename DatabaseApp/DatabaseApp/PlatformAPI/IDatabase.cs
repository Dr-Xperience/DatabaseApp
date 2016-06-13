using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformAPI
{
    public interface IDatabase
    {
        
        void init();

        int insert(params string[] value);

    }
}
