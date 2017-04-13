using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyDiaryApp
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            NoteList1.ItemsSource = DiaryNote.NoteList;
            usersname.Text = Admin.Admin1.Name + "'s Diary";

            


        }



        private async void GoToAPP_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyDiaryApp.Page3());

        }
       
        public   void OnDelete(object sender, EventArgs e)
        {
            var menuItem = ((MenuItem)sender);
            DiaryNote NoteDeleted = ((DiaryNote)menuItem.CommandParameter);
            
            DiaryNote.NoteList.Remove(NoteDeleted);

        }

        public async void OnEdit(object sender, EventArgs e)
        {
            var menuItem = ((MenuItem)sender);
               DiaryNote NoteEdited = ((DiaryNote)menuItem.CommandParameter);

            await Navigation.PushAsync(new MyDiaryApp.Page3(NoteEdited));
            




        }

        private async void ResetPassword_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyDiaryApp.ResetPassword());
        }
    }
}
