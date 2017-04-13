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
    public partial class ConfirmAdmin : ContentPage
    {
        public ConfirmAdmin()
        {
            InitializeComponent();
        }

        private async  void check_Clicked(object sender, EventArgs e)
        {
            if (Admin.Admin1.QuestionAnswer == PassAnswer1.Text)
            {
                await Navigation.PushAsync(new MyDiaryApp.ResetPassword());
            }
            else {

                await DisplayAlert("Alert", "Your Answer isnt matched", "OK");
            }

        }
    }
}
