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
    public partial class SignIn : ContentPage
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private async void SignIn1_Clicked(object sender, EventArgs e)
        {
            if (Admin.Admin1.Password == PasswordText3.Text)
            {
                await Navigation.PushAsync(new MyDiaryApp.MainPage());
                var existingPages = Navigation.NavigationStack.ToList();
                foreach (var page in existingPages)
                {
                    Navigation.RemovePage(page);
                }

            }

            else {
                await DisplayAlert("Alert", "Your Password isnt matched", "OK");

            }
        }

        private async  void ForgetPassword_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyDiaryApp.ConfirmAdmin());
        }
    }
}
