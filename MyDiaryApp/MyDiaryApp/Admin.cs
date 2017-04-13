using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiaryApp
{
    class Admin
    {
        public string Name { get; set; }
        public string Password{ get; set; }
        public string QuestionAnswer { get; set; }
        public static Admin Admin1 = new Admin();

        public Admin()
        {

            Password = string.Empty;
            Name = string.Empty;
            QuestionAnswer = string.Empty;
           
        }




        public Admin(string name, string password, string answer)
        {
            Name = name;
            Password = password;
            QuestionAnswer = answer;

            

        }
    }
}
