using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2_Type_mas_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool _bool = false;
            //byte _byte = 5;
            //sbyte _sbyte = 6;
            //char _char = 'c';
            //decimal _decimal = 9;
            //double _double = 3.14;
            //float _float = 6.1f;
            //int _int = 1;
            //uint _uint = 7;
            //long _long = -9999999;
            //ulong _ulong = 9999999;
            //short _short = 4;
            //ushort _ushort = 17;
            //object _object = 7;
            //// object   string  dynamic
            //Console.WriteLine($"{_bool} {_byte} {_sbyte} {_char} {_decimal} {_double} ");
            //Console.WriteLine( $"{_float} {_int} {_uint} {_long} {_ulong} {_short} {_ushort} {_object} ");

            //dynamic din = "dinam";
            //// string s1 = o;
            //string s2 = din;
            //Console.WriteLine(s2);
            //Console.WriteLine("Implicit");
            //int num = 2147483647;
            //long bigNum = num;
            //byte a1 = 4;
            //ushort b1 = a1;
            //Console.WriteLine(bigNum);
            //Console.WriteLine(b1);
            //Console.WriteLine("Explicit");
            //double a = 22.94;
            //int b_1;
            //b_1 = (int)a;
            //byte b_2 = 32;
            //sbyte s = (sbyte)b_2;
            //Console.WriteLine(b_1);
            //Console.WriteLine(s);
            //// e <---

            //Console.WriteLine("Convert");
            //bool b = false;
            //double d = Convert.ToDouble(b);
            //Console.WriteLine($" d={d}");

            //Console.WriteLine("Boxin");
            //int x = 5; 
            //Object o = x;   // упаковка
            //                    // Когда любой значимый тип присваивается к ссылочному типу данных, значение перемещается
            //                    // из области стека в кучу.Эта операция называется упаковкой.
            //                    // Когда любой ссылочный тип присваивается к значимому типу данных, значение перемещается 
            //                     // из области кучи в стек.Это называется распаковкой.

            //byte m = (byte)(int)o; // расспаковка 
            //Console.WriteLine(m);
            //Console.WriteLine("Implicitly typed variables");
            //var t = 13;
            //Type t_t = t.GetType();
            //Console.WriteLine(t_t);
            //Nullable<int> a_ = 5; // индентично int? a_ = 5;
            //Console.WriteLine($"{a_}");
            //// var
            ///
            //Console.WriteLine("Srting \t literal");

            //Console.WriteLine("A < B"); // тут должно быть сравнение 
            //Console.WriteLine("Concatenation");
            //string one = " one";
            //string two = "two";
            //string three = " three four and five";
            //string one_two = one + two;
            //string copy = three;
            //Console.WriteLine($"{one_two}");
            //Console.WriteLine($"COPY: {copy}");
            //string[] sep = three.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries); // говорит, что надо удалить все пустые подстроки.
            //foreach (string i in sep)
            //{


            //    Console.WriteLine($"{i}");
            //}
            //three = three.Insert(6, one);
            //Console.WriteLine($"Insert: {three}");
            //int ind = three.Length;
            //three = three.Remove(6, 4);
            //Console.WriteLine($"Remove: {three}");
            //// интерполирование строк.
            //string _null = null; 
            //string space = "";
            //bool cheak = string.IsNullOrEmpty(_null);
            //Console.WriteLine($"{cheak}");
            //cheak = string.IsNullOrEmpty(space);
            //Console.WriteLine($"{cheak}");
            ////Продемонстрируйте что еще можно выполнить с такими строками
            //StringBuilder str = new StringBuilder("ABCDEFG"); // по умолчанию 16
            //Console.WriteLine($"{str}");
            //str.Remove(0, 2);
            //Console.WriteLine($"{str}");
            //str.Insert(0, "123");
            //str.AppendFormat("!!!");
            //Console.WriteLine($"{str}");


            //Console.WriteLine("\t Array");
            //int[,] arr = { { 1, 2, 3 } ,{ 4, 5, 6 } };
            //for(int i = 0; i < arr.GetLength(0); ++i)
            //{
            //    for(int j = 0; j < arr.GetLength(1); ++j)
            //    {
            //        Console.Write($"{arr[i, j]}");
            //    }
            //    Console.WriteLine();
            //}
            //////////////////////////
            //      string elem; // ----------------
            //      string[] day = { "Sunday", "Monday", "Tuersday",
            //"Wednesday", "Thirsday", "Friday", "Saturday" };
            //      foreach(string i in day)
            //      {
            //          Console.Write($"{i} ");
            //      }
            //      Console.WriteLine();
            //      Console.WriteLine($"Size: {day.Length}");
            //      Console.WriteLine("Posiation: ");
            //      int pos = Console.Read();
            //      Console.WriteLine("Enter new element: ");
            //      elem = Console.ReadLine();
            //      for (int i = 0; i < day.Length; ++i)
            //      {
            //          if (i == pos)
            //          {
            //              day[i] = elem;
            //              Console.WriteLine($"Elem: {elem}");
            //          }
            //      }
            //      foreach (string i in day)
            //      {
            //          Console.Write($"{i} ");
            //      }
            //      Console.WriteLine();
            ///////////////////////////////
            //int[][] mas = { new int[2], new int[3], new int[4] };

            //for(int i = 0; i < mas.Length; ++i)
            //{
            //    for(int j = 0; j < mas[i].Length; ++j)
            //    {
            //        while(true)
            //        {
            //            Console.Write($"Enter [{i},{j}]:");
            //            try
            //            {
            //                mas[i][j] = Convert.ToInt32(Console.ReadLine());//
            //                break;
            //            }
            //            catch(FormatException)
            //            {
            //                Console.WriteLine("Wrong input date.");
            //            }
            //        }
            //    }
            //}
            //foreach ( int[] i in mas)
            //{
            //    foreach (int j in i)
            //        Console.Write("\t" + j);

            //    Console.WriteLine();
            //}
            //Console.WriteLine("Press any buttom to continue.");
            //Console.ReadKey();
            //Console.WriteLine("Var array");
            //var imp = new[] { 1, 2, 3, 4 };
            //var C = new[] { 'A', ';', '\'', '\n', '5', 'z' }; // тип элементов char, количество - 6
            //Console.WriteLine("\tTuples");
            //(int t_1, string t_2, char t_3, string t_4, ulong t_5) tuples = (10, "String one", 'c', "String two", 9999999);
            //Console.WriteLine($"{tuples.Item1}, {tuples.Item3}, {tuples.Item4}");
            ////Задайтекортеж из 5 элементов с типами int, string, char, string, ulong.
            //Console.WriteLine("All tuples:");
            //Console.WriteLine($"{tuples}");
            //Console.WriteLine("Unpacking tuples");
            //(var a, var b) = ("123", 456);
            //Console.WriteLine($"{a} {b}");
            ////(_)
            //Console.WriteLine("== or !=");
            //(int a, byte b) left = (5, 10);
            //(long a, int b) right = (5, 10);
            //Console.WriteLine(left.b == right.b);  
            //Console.WriteLine(left != right); 
            
            Console.WriteLine("\tFunction");

            int[] mas_int = new int[] { 1, 2, 10, 55, 2, -1, 0 };
            string[] mas_str = new string[] { "one", "two", "three" };

             Function(mas_int, mas_str);

           


            // функция_1
            static (int, int, int, string) Function( int[] mas_int, string[] mas_str)
            {
                int max = 0, min = 0 , sum = 0;
                for(int i = 0; i < mas_int.Length; ++i)
                {
                    if(max < mas_int[i])
                    {
                        max = mas_int[i];
                    }
                    if(min > mas_int[i])
                    {
                        min = mas_int[i];
                    }
                    sum = sum + mas_int[i];
                }
                string one = mas_str[0];
                one = one.Substring(0,1);

                (int, int, int, string) tuples_2 = (max, min , sum, one);
                Console.WriteLine($"{tuples_2}");
                return tuples_2;
            }

            Console.WriteLine("checked/unchecked:");
            int ch = 2147483647;
            //static int Cheked(int ch)
            //{
            //    checked
            //    {
            //        ch = ch + 3;
            //        Console.WriteLine($"ch = {ch}");
            //    }
            //    return 1;
            //}
            //static int Uncheked(int ch)
            //{
            //    unchecked
            //    {
            //        ch = ch + 3;
            //        Console.WriteLine($"ch = {ch}");
            //    }
            //    return 1;
            //}
            Console.WriteLine("Cheked Function");
            //Cheked(ch);
            Console.WriteLine("Uncheked Function");
            //Uncheked(ch);
        }
    }
}
