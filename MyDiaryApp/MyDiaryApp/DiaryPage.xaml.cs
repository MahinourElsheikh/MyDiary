using Org.W3c.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace MyDiaryApp
{
    
    public partial class Page3 : ContentPage

    {
        public DiaryNote NoteEdited;
        public Page3()
        {
            InitializeComponent();
             
        }

      
        public Page3(DiaryNote N )
        {
           InitializeComponent();
            DateEntry.Text = N.Date;
            subjectText.Text = N.Subject;
            editor1.Text = N.Body;
            NoteEdited = N;

        }




       void EditorCompleted(object sender, EventArgs e)
        {
            var text = ((Editor)sender).Text; // sender is cast to an Editor to enable reading the `Text` property of the view.
        }
        void EditorTextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }

        private  async void Save_Clicked(object sender, EventArgs e)
        {
            
            String date = DateEntry.Text;
            String editor = editor1.Text;
            String subject = subjectText.Text;

            DiaryNote Note = new DiaryNote(date,subject,editor);

            DiaryNote.NoteList.Add(Note);
            DiaryNote.NoteList.Remove(NoteEdited);
            DiaryNote.NoteList.Reverse();
            await App.SaveNotes();


            await  Navigation.PopAsync();


        }

        private  async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateEntry.Text = e.NewDate.ToString();
        }
    }
}
