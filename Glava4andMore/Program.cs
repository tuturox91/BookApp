using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glava4andMore
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            TestedScript(4, 5, ref i);
            Console.WriteLine("I: {0}", i);

            string[] StringArray = { "One", "Two", "Three" };
            int pos = 1;
            Console.WriteLine("=> Use Simple Return");
            Console.WriteLine("Before: {0}, {1}, {2}", StringArray[0], StringArray[1], StringArray[2]);
            ref var output = ref BackString(StringArray, pos);
            output = "new";
            Console.WriteLine("After: {0}, {1}, {2}", StringArray[0], StringArray[1], StringArray[2]);
            double avarage;
            avarage = BackLengthOfDoubleArr(5.0, 5.0, 2.0);
            Console.WriteLine("Avarage data: {0}", avarage);

            Console.WriteLine("Add more numbers: {0}", Add(35, 33, 22, 15, 500));
            Console.WriteLine("Add more double numbers: {0}", Add(3.2,13.1,22.3));

            string here;
            here = Console.ReadLine();
            var values = SplitName(here);
            Console.WriteLine(values.first);
            Console.WriteLine(values.midle);
            Console.WriteLine(values.last);


            Console.ReadLine();
        }

        static double BackLengthOfDoubleArr(params double[] values)
        {
            
            double sum = 0;
            if(values.Length == 0)
            {
                return sum;
            }
            for(int i = 0; i<values.Length; i++)
            {
                sum += values[i];
            }
            return sum/values.Length;
        }


        static int Add(params int[] values)
        {
            int sum = 0;
            if(values.Length == 0)
            {
                return sum;
            } 
            for(int i = 0; i<values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        }
        static double Add(params double[] values)
        {
            double sum = 0;
            if (values.Length == 0)
            {
                return sum;
            }
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        }

        static ref string BackString(string[] ArrayString, int position)
        {
            return ref ArrayString[position];
        }


        static void TestedScript(int x, int y, ref int k)
        {
            k = x + y;
        }

        //ст. 174 Кортеж
        static (string first, string midle, string last) SplitNames(string FullName)
        {
            string first = null, second = null, third = null;
            //пишем все до пробела
            for(int i = 0; i<FullName.Length; i++)
            {
                if(FullName[i] != ' ')
                {
                    first += FullName[i];
                } else
                {
                    //если нашли пробел заканчиваем записывать имя пишем отчество
                    for(int j = i+1; j<FullName.Length; j++)
                    {
                        if (FullName[j] != ' ')
                        {
                            second += FullName[j];
                        }
                        else
                        {
                            //дошли до пробела записываем фамилию
                            for(int d = j+1; d<FullName.Length; d++)
                            {
                                third += FullName[d];

                            }
                            break;
                        }
                    }
                    break;
                }
            }
            return (first, second, third);

        }
        //То же только правильно! 
        static (string last, string first, string midle) SplitName(string FullName)
        {
            var partsName = FullName.Split(' ');
            return (partsName[0], partsName[1], partsName[2]);
        }
        //
        
        //Вариации создания кортежа
        static void Keklol()
        {
            (string, int, string) value = ("a", 55, "c");
            var values = ("gj", 55, 33);
        }
    }
}
