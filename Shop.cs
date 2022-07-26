using System;
using static System.Console;
namespace DZ5_CSharp
{
    public class Shopp
    {
        public string? name;
        public string? adres;
        public string? description;
        public string? phone;
        public string? email;
        public int? square;

        public Shopp()
        {
            name = null;
            adres = null;
            description = null;
            phone = null;
            email = null;
            square = 0;
        }

        public Shopp(string name, string adres, string description, string phone, string email, int square)
        {
            this.name = name;
            this.adres = adres;
            this.description = description;
            this.phone = phone;
            this.email = email;
            this.square = square;
        }

        public void FillInfo()
        {
            Console.WriteLine("Info adding:");
            this.name = EnterString("Enter name of the shop");
            this.adres = EnterString("Enter adres");
            this.description = EnterString("Enter description");
            this.phone = EnterString("Enter phone");
            this.email = EnterString("Enter email");
            WriteLine("Enter square: ");
            this.square = Convert.ToInt32(ReadLine());
        }

        public void PrintInfo()
        {
            WriteLine($"Name:{name}\n Adres:{adres}\n Description:{description}, Phone:{phone}, Email:{email}, Square: {square}");
        }

        public static Shopp operator +(Shopp s, int n)
        {
            s.square += n;
            return s;
        }

        public static Shopp operator -(Shopp s, int n)
        {
            s.square -= n;
            return s;
        }

        public static bool operator ==(Shopp shp1, Shopp shp2)
        {
            return shp1.square == shp2.square;
           
        }

        public static bool operator !=(Shopp shp1, Shopp shp2)
        {
            return shp1.square != shp2.square;

        }

        public static bool operator >(Shopp shp1, Shopp shp2)
        {
            return shp1.square > shp2.square;

        }

        public static bool operator <(Shopp shp1, Shopp shp2)
        {
            return shp1.square < shp2.square;

        }



        public static string EnterString(string prompt)
        {
            Console.Write($"\t{prompt}: ");
            string str = Console.ReadLine();
            str = str.Trim();//Видалення пробілів зпочатку та кінця
            return str;
        }


    }
}

