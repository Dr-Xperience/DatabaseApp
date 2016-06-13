using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DependencyServices;

namespace DependencyServices.Droid
{
    class RegistrarDroid : DependencyServices.Registrar
    {
        public override void register()
        {
            Database = new PlatformAPI.Droid.DatabaseDroid();
        }
    }
}