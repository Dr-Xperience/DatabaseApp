using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DatabaseApp
{
    public partial class ContactFormPage : ContentPage
    {
        public ContactFormPage()
        {
            InitializeComponent();
            DependencyServices.ServiceProvider.Instance.Registrar.Database.init();
        }

        public void DatabaseInsertHandler(object sender, EventArgs args)
        {
            PlatformAPI.IDatabase vDb=DependencyServices.ServiceProvider.Instance.Registrar.Database;
            int result=vDb.insert(Name.Text, Address.Text, Phone.Text, Email.Text, URL.Text, Age.Text, Description.Text);
            if (result >= 1)
            {
                Status.Text = "Successfull "+result;
                Status.TextColor = Color.Green;
            }
            else
            {
                Status.Text = "UnSuccessfull";
                Status.TextColor = Color.Red;
            }
        }
    }
}
