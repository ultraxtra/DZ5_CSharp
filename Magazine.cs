using System;
using static System.Console;

namespace DZ5_CSharp
{
    public class Magazine
    {
        public string? name { get; set; }
        public string? year { get; set; }
        public string? phone { get; set; }
        public string? email { get; set; }
        public int workeramount { get; set; }

        public Magazine()
        {
            name = null;
            year = null;
            phone = null; ;
            email = null;
            workeramount = 0;
        }

        public Magazine(string name, string year, string phone, string email,  int workeramount)
        {
            this.name = name;
            this.year = year;
            this.phone = phone;
            this.email = email;
            this.workeramount = workeramount;

        }

        public void FillInfo()
        {
            WriteLine("Write info:");
            this.name = EnterString("Enter name:");
            this.year = EnterString("Enter year:");
            this.phone = EnterString("Enter phone:");
            this.email = EnterString("Enter email:");
            Write("Enter workers amount: ");
            this.workeramount = Convert.ToInt32(ReadLine());
        }


       


      public static Magazine operator +(Magazine s, int n)
      {
          s.workeramount+=n;
          return s;
      }

      public static Magazine operator -(Magazine s, int n)
      {
          s.workeramount -= n;
          return s;
      }

      public static bool operator ==(Magazine m1, Magazine m2)
      {
          
          return m1.workeramount == m2.workeramount;
      }

      public static bool operator !=(Magazine m1, Magazine m2)
      {
      
          return m1.workeramount != m2.workeramount;
      }
      
      public static bool operator >(Magazine m1, Magazine m2)
      {
      
          return m1.workeramount > m2.workeramount;
      }
      
      public static bool operator <(Magazine m1, Magazine m2)
      {
      
          return m1.workeramount < m2.workeramount;
      }



        public static string EnterString(string prompt)
        {
            Console.Write($"\t{prompt}: ");
            string str = Console.ReadLine();
            str = str.Trim();//Видалення пробілів зпочатку та кінця
            return str;
        }

        public void PrintInfo()
        {
            WriteLine($"Name:{name}\n Year:{year}\n Phone:{phone}\n Email:{email}\n  Worker amount{workeramount}");
        }


       

    }
}


