using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDiaryApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResetPassword : ContentPage
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private async void Reset_Clicked(object sender, EventArgs e)
        {

            if (NewPasswordText1.Text != null)
            {
                if (NewPasswordText1.Text == NewPasswordText2.Text)
                {
                    Admin.Admin1.Password = NewPasswordText2.Text;
                    await App.SaveAdmin();
                    await Navigation.PushAsync(new MyDiaryApp.MainPage());
                    var existingPages = Navigation.NavigationStack.ToList();
                    foreach (var page in existingPages)
                    {
                        Navigation.RemovePage(page);
                    }
                }
                else { await DisplayAlert("Alert", "Your New Password doesn't match", "OK"); }




            }
            else {  { await DisplayAlert("Alert", "Your New Password isnt decided", "OK"); } }
        }
           
    }
}
