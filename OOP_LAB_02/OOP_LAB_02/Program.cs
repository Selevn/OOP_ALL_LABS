using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_02
{
    //В языке C# есть следующие примитивные типы данных: bool byte sbyte short ushort int uint  
    //long ulong float double decimal char string object

    class Program
    {
        
        static void Main(string[] args)
        {
            bool b1 = true;
            byte bb1 = 240;
            sbyte sbb2 = -120;
            short sh1 = -32767;
            ushort sh2 = 64000;
            int i1 = 12345432;
            uint i2 = 123454322;
            long l1 = 0xFFFFFFFF;
            ulong l2 = 0xFFFFFFFF;
            float f1 = 2e32f;
            double f2 = 56e4;
            decimal dd = 3.141592653589793238462643383279502884197M;
            char ch = 'A';
            string str = "Дерево";
            object obj = "hello code";



            //неявное приведение - в целочисленных меньшее к большему приводится
            sh1 = bb1;
            i1 = sh1;
            l1 = i1;
            l1 = l1;
            i1 = bb1;
            
            //явное приведение
            sh1= (short)ch;
            f1 = (float)f2;
            i1 = Convert.ToInt32(l1);
            sh1 = (short)l1;
            sh1 = (short)ch;


            //CLR - общеязыковая среда выполнения
            //упаковка и распаковка значимых(?) типов
            object o = i1;
            int _i2 = (int)o;
            o = sh1;
            short _sh2 = (short)o;
            o = bb1;
            byte bb2 = (byte)o;
            o = l1;
            long _l2 = (long)o;

            //неявная типизация
            var foo = 5;
            i1 = foo;

            foo++;

            int? z = null;
            Nullable<bool> enabled = null;
            if (z.HasValue)
                Console.WriteLine(z.Value);
            else
                Console.WriteLine("z is equal to null");
            z = 5;
            if (z.HasValue)
                Console.WriteLine(z.Value);
            else
                Console.WriteLine("z is equal to null");
            z = 5;

            var q = 5;
            //q = 3.4; - после неявной типизации q получило тип int, а в int нельзя записывать числа с плавающей точкйо

            //Строки
            string str1 = "Hello";
            string str1_1 = "Hello";
            string str2 = "world";

            Console.WriteLine("Strings");
            Console.WriteLine(str1 == str2);                //false
            Console.WriteLine(str1 == str1_1);              //true
            Console.WriteLine(String.Compare(str1,str2));   //-1
            Console.WriteLine(String.Compare(str1,str1_1)); //0



            /*Создайте три строки на основе String.
             * Выполните: сцепление,
             * копирование,
             * выделение подстроки,
             * разделение строки на слова,
             * вставки подстроки в заданную позицию,
             * удаление заданной подстроки. */

            string s1 = "Hello ";
            string s2 = "World";
            string s3 = "Never gonna give up";

            Console.WriteLine("Strings concat");
            Console.WriteLine(s1+s2);                   //Hello World
            Console.WriteLine(String.Concat(s1,s2));    //Hello World

            string s4 = String.Copy(s3);
            Console.WriteLine("Strings copy");
            Console.WriteLine(String.Compare(s4,s3));   //0

            Console.WriteLine("Strings substring (s3:3-7)");
            Console.WriteLine(s3.Substring(3,7));       //er gonn

            Console.WriteLine("Strings dividing on words");
            string[] words = s3.Split(' ');
            foreach (var i in words)
            {
                Console.WriteLine(i);       //*divided words*
            }
            
            Console.WriteLine("Strings inserting");
            s3 = s3.Insert(16," you");
            Console.WriteLine(s3);       //Never gonna give you up

            Console.WriteLine("Strings cutting down");
            s3 = s3.Substring(1,19);
            Console.WriteLine(s3);       //ever gonna give you

            Console.WriteLine($"{s3} - interpolled string");

            string emp1 = "";
            string emp2 = null;
            Console.WriteLine(String.Compare(emp1,emp2)); //1
            Console.WriteLine(emp1 == emp2); //false
            Console.WriteLine(String.Concat(emp1, s2)); //World
            Console.WriteLine(String.Concat(emp2, s2)); //World


            StringBuilder sb = new StringBuilder("Казнить, нельзя помиловать");
            sb = sb.Remove(7, 1);
            sb.Insert(14, ",");
            Console.WriteLine(sb);          //Казнить нельзя, помиловать
            sb.Insert(0, "К слову, ");
            sb.Insert(sb.Length,"!");
            Console.WriteLine(sb);          //К слову, Казнить нельзя, помиловать!

            //Массивы

            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i,j]+" ");
                }
                Console.WriteLine();
            }


            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            foreach (var i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("\nВведите позицию для замены: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите на что заменить: ");
            int val = Convert.ToInt32(Console.ReadLine());
            arr[pos] = val;
            Console.Write("Новый массив: ");
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            float[][] myArr = new float[3][];
            myArr[0] = new float[2];
            myArr[1] = new float[3];
            myArr[2] = new float[4];
            Console.WriteLine("Вводите данные для массива: ");
            for (var i = 0; i < myArr.Length; i++)
                for(var j=0;j<myArr[i].Length;j++) 
                    myArr[i][j] = (float)Convert.ToDouble(Console.ReadLine());
            for (var i = 0; i < myArr.Length; i++)
            {
                for (var j = 0; j < myArr[i].Length; j++)
                    Console.Write(myArr[i][j] + " ");
                Console.WriteLine();
            }


            var for_array = new object[0];
            var for_str = "";

            //Кортежи

            (int first, string second, char third, string fourth,  ulong fifth) tuple = (5, "num",'c',"four",123321123321);


            Console.WriteLine("tuple is "+tuple);
            Console.WriteLine($"tuple 1,3,4 {tuple.first} {tuple.third} {tuple.fourth}");
            var (a, b, c, d, e) = tuple;
            var (_, _, _, _, ull) = tuple;      // _ - пустая переменная    

            var firstTuple = (9, 3);
            var secondTuple = (9, 3);
            Console.WriteLine(firstTuple.CompareTo(secondTuple));

            

            (int, int, int, int) function(int[] _array, string s)
            {
                (int min, int max, int sum, char letter) _tuple;

                _tuple.max = _array.Max();
                _tuple.min = _array.Min();
                _tuple.sum = _array.Sum();
                _tuple.letter = (char)s[0];

                return (_tuple);
            };

            int[] tmpArr = { 1, 2, 3, 4, -6 };
            Console.WriteLine("function");
            Console.WriteLine(function(tmpArr, "sobaka"));

            void Unchecked(int max_value)
            {
                Console.Write("\nUnchecked owerflow\n");
                try
                {
                    int overflow = unchecked(max_value + 10);
                }
                catch (System.OverflowException err)
                {
                    Console.Write($"\nCatched exception: {err}\n");
                    return;
                }
                Console.Write("\nThere's no exception\n");
                return;
            }

            void Checked(int max_value)
            {
                Console.Write("\nChecked owerflow\n");
                try
                {
                    int overflow = checked(max_value + 10);
                }
                catch (System.OverflowException err)
                {
                    Console.Write($"\nCatched exception {err}\n");
                    return;
                }
                Console.Write("\nThere's no exception\n");
                return;
            }
            int max_int_value = 2147483647;
            Unchecked(max_int_value);
            Checked(max_int_value);


            Console.Read();

        }


        
    }
}
