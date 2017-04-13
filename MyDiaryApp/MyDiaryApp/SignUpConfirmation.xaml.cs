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
    public partial class SignUpConfirmation : ContentPage
    {
        public SignUpConfirmation()
        {
            InitializeComponent();
        }

        private async void GoToAPP_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyDiaryApp.MainPage());
            var existingPages = Navigation.NavigationStack.ToList();
            foreach (var page in existingPages)
            {
                Navigation.RemovePage(page);
            }
           
        }
    }
}
