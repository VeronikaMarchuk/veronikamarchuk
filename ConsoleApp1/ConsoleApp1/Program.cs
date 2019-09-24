using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool perem1 = true;
            byte bit = 19; //  хранит целое число от 0 до 255 и занимает 1 байт.
            sbyte bit2 = -19; //  хранит целое число от -128 до 127 и занимает 1 байт. 
            short number1 = 65; // хранит целое число от -32768 до 32767 и занимает 2 байта.
            ushort number2 = 58354; // хранит целое число от 0 до 65535 и занимает 2 байта.
            int number3 = 0b101; // хранит целое число от -2147483648 до 2147483647 и занимает 4 байта.
            uint number4 = 46847867; // хранит целое число от 0 до 4294967295 и занимает 4 байта.
            long number5 = -98952585534; // хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.
            ulong number6 = 54584845888; // хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт.
            float namber7 = 3; //хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта. 
            double namber8 = -2.5; //хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта.
            decimal namber9 = Convert.ToInt32(Math.Pow(10, -23)); //хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт.
            char a = 'V'; //хранит одиночный символ в кодировке Unicode и занимает 2 байта.
            string name = "Veronika"; //хранит набор символов Unicode.
            object k = 5, b = "red", c = 32.5; //может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе. 
            ////////
            //неявные числовые преобрaзования
            int num = 2147483647;  byte bt = 25;    short sh = -3569;  float fl = 258;  char ch = '7';
            long bigNum = num;     short bt1 = bt;  float sh1 = sh;    double fl1 = fl;  int ch1 = ch;
            //явные числовые преобрaзования
            double x = 1234.7;  char ch3;         ushort ush = 6589;   char ch4 = '6';   float fl5 = 589;
            int al;             sbyte sb = 5;     short ush1;          byte ch5;         long fl6;
            al = (int)x;        ch3 = (char)sb;   ush1 = (short)ush;   ch5 = (byte)ch4;  fl6 = (long)fl5;
            //////
            //Упаковка это преобразование value(значимого) типа в Object тип 
            int price = 39;
            Object obj = price;
            //Распаковка это преобразование Object типа в value(значимый) тип 
            int price2 = (int)obj;
            /////
            //var указывает только на то, что компилятор определяет и назначает наиболее подходящий тип.
            // ia is compiled as an int
            var ia = 5;
            // s is compiled as a string
            var s = "Hello";
            // assa is compiled as int[]
            var assa = new[] { 0, 1, 2 };
            ///
            //////Стандартный пример - работа с базой данных, которая может содержать значения null. И мы можем заранее не знать,
            ///что мы получим из базы данных - какое-то определенное значение или же null.
            int? vc = null;

            // vd = vc, if vc is not null, vd = -1 if vc is null.
            int vd = vc ?? -1;
            int? aa = 10;
            int? bb = null;
            int? cc = 10;

            aa++;        // a is 11.
            aa = aa * cc;  // a is 110.
            aa = aa + bb;  // a is null.
            //////////
            //С помощью метода String.Equals можно легко определить идентичность двух строк. Этот метод учитывает
            //регистр и возвращает логическое значение true или false .
            string string1 = "Hello World";
            string string2 = "Hello World";
            Console.WriteLine(String.Equals(string1, string2));
            ////////
            string s1 = "Я строка левая";
            string s2 = "А я строка правая";
            string s3 = "Выбирай на чьей ты стороне";
            Console.WriteLine(s1+" "+s2+" "+s3);//сцепление
            string s4 = String.Copy(s3);//Copy МетодString возвращает объект, который имеет то же значение, 
                                        //что и исходная строка, но представляет другую ссылку на объект. Он отличается от операции присваивания, 
                                        //которая назначает существующую строку ссылки на дополнительную объектную переменную.
            Console.WriteLine(s4);
            string s5 = s2.Substring(11);
            Console.WriteLine(s5);
            string[] words = s3.Split(' ');
            foreach (string ss in words)
            {
                Console.WriteLine(ss);
            }
            s3 = s3.Insert(7,  s5);
            Console.WriteLine(s3);
            s3 = s3.Remove(7, s5.Length);
            Console.WriteLine(s3);
            /////
            string nullStr = null;//вы можете использовать строки NULL в операциях объединения и сравнения с другими строками
            string emptyStr = String.Empty; //Пустая строка — это экземпляр объекта System.String, который содержит нуль символов
            bool boo = (emptyStr == nullStr);
            Console.WriteLine(boo);
            string newStr = emptyStr + nullStr;
            Console.WriteLine(newStr);
            Console.WriteLine(emptyStr.Length);
            Console.WriteLine(newStr.Length);
            /////
            //Класс StringBuilder создает строковый буфер, который ускоряет работу, если программа выполняет много операций 
            //над строками. Строка StringBuilder также позволяет заново присваивать отдельные символы, что не поддерживает
            //встроенный строковый тип данных. Например, этот код изменяет содержимое строки без создания новой строки
            StringBuilder sbs = new StringBuilder("Привет мир");
            sbs.Append("!");//добавляет в конец
            sbs.Insert(0, "!");
            Console.WriteLine(sbs);
            // заменяем слово
            sbs.Replace("мир", "world");
            Console.WriteLine(sbs);
            // удаляем 6 символов, начиная с 7-го
            sbs.Remove(7, 6);
            Console.WriteLine(sbs);
            // получаем строку из объекта StringBuilder
            string sk = sbs.ToString();
            Console.WriteLine(sk);
            /////
            //И с помощью выражения mas.GetUpperBound(0) + 1 
            //можно получить количество строк таблицы, представленной двухмерным
            //массивом. А через mas.Length / rows можно получить количество элементов в каждой строке
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            // или так
            // int columns = mas.GetUpperBound(1) + 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
            /////
            string[] words1 = { "one", "two", "three", "four", "five", "six" };
            for (int i = 0; i < words1.GetLength(0); i++)
            {
                    Console.Write(words1[i] + " "); 
            }
            Console.WriteLine();
            Console.WriteLine("Длина массива: " + words1.Length);
            string t, tt;
            for (int i = 0; i < words1.GetLength(0); i++) 
            {
                if (i == 4)
                { t = words1[4];
                    tt = words1[i - 2];
                    words1[i] = tt;
                    words1[i - 2] = t;
                }
            }
            for (int i = 0; i < words1.GetLength(0); i++)
            {
                Console.Write(words1[i] + " ");
            }
            Console.WriteLine();
            ///////
            int[][] numbers = new int[3][];
            numbers[0] = new int[2];
            numbers[1] = new int[3];
            numbers[2] = new int[4];
            Console.WriteLine("Введите числа массива");
            for (int i= 0; i < numbers[0].Length; i++) 
            {
                numbers[0][i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers[1].Length; i++)
            {
                numbers[1][i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers[2].Length; i++)
            {
                numbers[2][i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < numbers[0].Length; i++)
            {
                Console.Write("{0}\t", numbers[0][i]);
            }
            Console.WriteLine();
            for (int i = 0; i < numbers[1].Length; i++)
            {
                Console.Write("{0}\t", numbers[1][i]);
            }
            Console.WriteLine();
            for (int i = 0; i < numbers[2].Length; i++)
            {
                Console.Write("{0}\t", numbers[2][i]);
            }
            Console.WriteLine();
            //////
            Console.WriteLine();
            var strg = new[] { 1, 2, 3, 4 };
            for (int i=0; i<strg.Length; i++)
            {
                Console.Write("{0}\t", strg[i]);
            }
            Console.WriteLine();
            var strg1 = new[] { "Marinette", "Adrian", "Luke", "Ala" };
            for (int i = 0; i < strg1.Length; i++)
            {
                Console.Write("{0}\t", strg1[i]);
            }
            Console.WriteLine();
            ////////
            //Кортежи в C# — эти типы, которые определяются с помощью упрощенного 
            //синтаксиса. Преимущества: более простой синтаксис, правила преобразований 
            //с учетом количества (так называемой кратности) и типов элементов, а также 
            //единые правила для копий, тестов на равенство и назначений. 
            var tuple = new Tuple<int, string, char, string, ulong>( 5, "Tom", 'K', "Ver",  8008278);
           
            Console.Write("{0}\t", tuple.Item1);
            Console.Write("{0}\t", tuple.Item2);
            Console.Write("{0}\t", tuple.Item3);
            Console.Write("{0}\t", tuple.Item4);
            Console.Write("{0}\t", tuple.Item5);
            Console.WriteLine();
            Console.Write("{0}\t", tuple.Item1);
            Console.Write("{0}\t", tuple.Item3);
            Console.Write("{0}\t", tuple.Item4);
            Console.WriteLine();
            /////
            var left = (a: 5, b: 10);
            var right = (a: 5, b: 10);
            Console.WriteLine(left == right); // displays 'true'
            /////
            int[] arr = new int[] { 7, 5, 0, 9, 7, 7, 8 };
            (int, int, int, char) func(int[] array, string stk) // Локальная функция
            {
                int max = 1, sum = 0;
                int[] array1 = array;
                for (int i = 0; i < array1.Length; i++)
                {
                    sum = sum + array1[i];
                    if (array1[i] > max)
                    {
                        max = array1[i];
                    }
                }
                int min = 99;
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] < min)
                    {
                        min = array1[i];
                    }
                }
                string stk1 = stk;
                char chr1 = stk[0];
                (int, int, int,  char) Tuple2 = (max, min, sum, chr1);
                return Tuple2;
            }
            string stk0 = "gfhtfcfgdfc";
            var nextTuple = func(arr, stk0);
            Console.WriteLine("Максимальный элемент: ", nextTuple.Item1);
            Console.WriteLine("Минимальный элемент: ", nextTuple.Item2);
            Console.WriteLine("Сумма: ", nextTuple.Item3);
            Console.WriteLine("Первая буква строки: ", nextTuple.Item4);

        }

    }
}
