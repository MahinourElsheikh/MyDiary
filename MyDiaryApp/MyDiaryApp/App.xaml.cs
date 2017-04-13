using Newtonsoft.Json;
using PCLStorage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDiaryApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        static int Flag = 0;
        public static async Task SaveNotes()
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;

            IFile file = await rootFolder.CreateFileAsync("DiaryNotes", CreationCollisionOption.ReplaceExisting);

            string SerializedNotes = JsonConvert.SerializeObject(DiaryNote.NoteList);

            await file.WriteAllTextAsync(SerializedNotes);
        }

        public static void LoadNotes()
        {
            // get hold of the file system
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            if (rootFolder.CheckExistsAsync("DiaryNotes").Result == ExistenceCheckResult.FileExists)
            {
                IFile file = rootFolder.GetFileAsync("DiaryNotes").Result;
                var SerializedNotes = JsonConvert.DeserializeObject<ObservableCollection<DiaryNote>>(file.ReadAllTextAsync().Result);
                DiaryNote.NoteList = SerializedNotes;
                Flag = 1;
            }
        }

            public static async Task SaveAdmin()
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;

            IFile file = await rootFolder.CreateFileAsync("DiaryAdmin", CreationCollisionOption.ReplaceExisting);

            string SerializedAdmin = JsonConvert.SerializeObject(Admin.Admin1);

            await file.WriteAllTextAsync(SerializedAdmin);
        }

        public static void LoadAdmin()
        {
            // get hold of the file system
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            if (rootFolder.CheckExistsAsync("DiaryAdmin").Result == ExistenceCheckResult.FileExists)
            {
                IFile file = rootFolder.GetFileAsync("DiaryAdmin").Result;
                var SerializedAdmin = JsonConvert.DeserializeObject<Admin>(file.ReadAllTextAsync().Result);
                Admin.Admin1 = SerializedAdmin;
                Flag = 1;
            }

        }
        public App()
        {
           InitializeComponent();
            LoadNotes();
            LoadAdmin();

            if (Flag == 0)
            { MainPage = new NavigationPage(new MyDiaryApp.SignUp()); }
            else
            {
                MainPage = new NavigationPage(new MyDiaryApp.SignIn());
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected async override void OnSleep()
        {
            // Handle when your app sleeps
            await App.SaveNotes();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
