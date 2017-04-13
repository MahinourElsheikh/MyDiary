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
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private async void SignUp_Clicked(object sender, EventArgs e)
        {
            if (PasswordText1.Text != null)
            {
                if (PasswordText1.Text == PasswordText2.Text)
                {
                    Admin.Admin1.Name = usernameText2.Text;
                    Admin.Admin1.Password = PasswordText1.Text;
                    Admin.Admin1.QuestionAnswer = PassAnswer.Text;

                    await App.SaveAdmin();

                    await Navigation.PushAsync(new MyDiaryApp.SignUpConfirmation());
                }

                else
                {
                    await DisplayAlert("Alert", "Your Password isnt matched", "OK");

                }
            }

            else { await DisplayAlert("Alert", "Please choose a password ", "OK"); }
        }
    }
}
