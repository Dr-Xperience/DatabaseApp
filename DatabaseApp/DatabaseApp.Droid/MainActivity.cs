using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using DependencyServices.Droid;
using DependencyServices;

namespace DatabaseApp.Droid
{
    [Activity(Label = "DatabaseApp", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            ServiceProvider.Instance.Registrar = new RegistrarDroid();
            ServiceProvider.Instance.Registrar.register();
            LoadApplication(new App());
        }
    }
}

