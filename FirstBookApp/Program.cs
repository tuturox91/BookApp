using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FirstBookApp
{
    class Program
    {
        static int Main(string[] args)
        {
            //ст. 90
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            //
            //ст. 86-88
            for (int i = 0; i<args.Length; i++)
            {
                Console.WriteLine("Arg: {0}", args[i]);
                if (args[i] == "-showallinfo")
                    ShowAllEnvironmentInfo();
            }
            //
            //
            SportCar First = new SportCar();
            Console.Title = "Tested First App from BOOK";
            double a1 = 530.40, a2 = 300.25, a3 = 0;
            //
            //Страница 92-93
            Console.WriteLine("You have: {0:C}", a1);
            Console.WriteLine("Sub: {0:c}", a2);
            a3 = a1 - a2;
            Console.WriteLine("Now you have: {0:C}", a3);
            //
            //

           // char kek = Convert.ToChar(Console.Read());
           // CharFunc(kek);





            string testeds = Console.ReadLine();
            SearchPunctuation(testeds);

            ParseFromString();

            UseDateTimes();


            MessageBox.Show(First.GetPetName());
            return -1;
            //
        }

        //ст. 88-90
        static void ShowAllEnvironmentInfo()
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".Net Version: {0}", Environment.Version);
            Console.WriteLine("Is 64bit system?: {0}", Environment.Is64BitOperatingSystem);
            Console.WriteLine("Machine name: {0}", Environment.MachineName);
            Console.WriteLine("Hello: {0}", Environment.UserName);
            Console.Beep(3000,30);
        }
        //
        //ст. 100
        static void CharFunc(char t)
        {
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Char число?: {0}", char.IsDigit(t));
            Console.WriteLine("Char буковка?: {0}", char.IsLetter(t));
            Console.WriteLine("Char прробел, в строке?: ('Hello There', 5'): {0}", char.IsWhiteSpace("Hello Threre", 5));
            Console.WriteLine("Char знак?: {0}", char.IsPunctuation(t));
            Console.WriteLine();
        }
        //
        //к ст. 100 от себя
        static void SearchPunctuation(string str)
        {
            for(int i = 0; i<str.Length; i++)
            {
                if(char.IsPunctuation(str[i]))
                {
                    Console.WriteLine("Знак пунктуации {0} в строке.", i);
                    break;
                }
            }
        }
        //
        //ст. 101
        static void ParseFromString()
        {
            Console.WriteLine("Parsing: ");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of bool from str: {0}", b);
            double d = double.Parse("99,884");
            Console.WriteLine("Value of double from str: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of int from str: {0}", i);
            char c = char.Parse("w");
            Console.WriteLine("Value of char from str: {0}", c);
            Console.WriteLine();
        }
        //
        //ст. 102
        static void UseDateTimes()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dates and Times: ");
            DateTime dt = new DateTime(2013, 10, 21);
            //Какой день месяца
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            //
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight saving: {0}", dt.IsDaylightSavingTime());
            TimeSpan ts = new TimeSpan(4, 30, 22);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
        }
        //
    }
}
