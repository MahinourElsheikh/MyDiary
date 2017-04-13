using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiaryApp
{
     public class DiaryNote
    {
        
        public string Date { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
       //public static List<DiaryNote> NoteList = new List<DiaryNote>();
        public static  ObservableCollection<DiaryNote> NoteList = new ObservableCollection<DiaryNote>();
        

        public DiaryNote()
        {
            
            Body = string.Empty;
            Subject = string.Empty;
            Date = string.Empty;
        }
        public DiaryNote(string date, string subject, string body)
        {
           
            Date =date;
            Subject = subject;
            Body = body;
            
        }











    }
}
