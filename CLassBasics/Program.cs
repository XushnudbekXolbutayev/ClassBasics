using CLassBasics.Class;

namespace CLassBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kitobning bozordagi narxi: ");
            double costs = Convert.ToDouble(Console.ReadLine());

            Book books = new Book("Harry Potter", costs, 12000);
            books.Author = "J.K.Rowling";

            Console.WriteLine($"Kitobning nomi: {books.name}");
            Console.WriteLine($"Kitobning muallifi: {books.Author}");
            Console.WriteLine($"Kitobning asl narxi: {books.orginalCost}");

            // just for my learmimg
            Console.WriteLine();

            object[] objects = new object[] { "O'tkan kunlar", "Muallif", 45000 };
            Print(objects);

            Console.WriteLine();

            string _name = " Hasan";
            string _namee = "Husan";

            Swapp(ref _name, ref _namee);

            Console.WriteLine(_name + _namee);

            Console.WriteLine();

            string frontWord1 = "Harry";
            string backWord1 = " Potter";
            fullName(frontWord1, backWord1, out string Name);

            Console.WriteLine(Name);

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
