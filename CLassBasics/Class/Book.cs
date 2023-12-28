using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLassBasics.Class
{
    internal class Book
    {
        private string author;
        public string name { get; set; }
        public double orginalCost { get; set; }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public Book(string name, double presentCost, double profitCost)
        {
            orginalCost = presentCost - profitCost;
            //bu shunchaki this kalit so'zini ishlatish uchun edi
            this.name = name;
        }

        // params 
        public static void Print(params object[] fullInfoBook)
        {
            for (int i = 0; i < fullInfoBook.Length; i++)
            {
                Console.WriteLine(fullInfoBook[i]);
            }
        }

        // ref kalit so'zi
        public static void Swapp(ref string name1, ref string name2)
        {
            string variable = name1;
            name1 = name2;
            name2 = variable;
        }

        // out kalit so'zi
        public static void fullName(string frontWord, string backWord, out string Name)
        {
            Name = string.Concat(frontWord, backWord);
        }
    }
}
