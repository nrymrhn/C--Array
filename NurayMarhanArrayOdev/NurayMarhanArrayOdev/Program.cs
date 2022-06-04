using System;

namespace NurayMarhanArrayOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aynı tipteki verileri bir arada tutmamızı sağlayan nesnelerdir.Dizilerdeki elemanların isimleri ortaktır.Ayırt edici özellikleri bellekteki yerleridir.
            //Dizi tanımlama: Veri tipi[] diziDegiskenAdi={Değer1,Değer2,Değer3...} eleman sayısını belirlemeden tanımlanan dizilerdir.
            // Veri tipi[] diziDegiskenAdi=new VeriTipi [dizide olacak değer sayısı]{Değer1,Değer2,Değer3...} eleman sayısı baştan belli olacak şekilde dizi tanıladır.
            // Dizi Örnek 3:  Klavyeden kullanıcı tarafından girilen 5 ismi alfabetik olarak sıralayan programı dizi kullanarak yazınız.
            //klavyeden kullanıcı tarafından girilen 5 sayıdan en büyüğünü bulan programı dizi kullanarak yazınız
            //int[] numbers = new int[5];
            //for (int i =0; i <5; i++)
            //{
            //    Console.WriteLine("{0}. sayıyı giriniz:",i+1);
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int theBiggest = numbers[0];
            //for (int i = 1; i <5; i++)//burda 1 den başlatmamızın amacı 0.indexi en büyük değere atadık çünkü
            //{
            //    if (numbers[i]>theBiggest)
            //    {
            //        theBiggest = numbers[i];
            //    }
            //}
            //Console.WriteLine("The biggest number:"+theBiggest);

            //Klavyeden kullanıcı tarafından 5 sayıyı büyükten küçüğe doğru sıralayanız
            //int[] numbers = new int[5];
            //int change;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("{0}. sayıyı giriniz:", i + 1);
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i <=4; i++)
            //{
            //    for (int j =i+1; j < 5; j++)
            //    {
            //        if (numbers[i] < numbers[j])
            //        {
            //            change = numbers[i];
            //            numbers[i] = numbers[j];
            //            numbers[j] = change;
            //        }
            //    }

            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("{0}.en büyük sayı:{1}",i+1,numbers[i]);
            //}


            // Dizi Örnek 3:  Klavyeden kullanıcı tarafından girilen 5 ismi alfabetik olarak sıralayan programı dizi kullanarak yazınız.

            string[] names = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}.enter the name:", i + 1);
                names[i] = Console.ReadLine();
            }
            Array.Sort(names);
            Console.WriteLine();
            Console.WriteLine("A-Z Arrangement:");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("*************************************************");
            // Dizi Örnek 4: Klavyeden kullanıcı tarafından girilen, beş elemanlı bir sayı dizisinde, son rakamı 0(sıfır) olan sayıların sayısını bulan programı yazınız.

            int[] numbers = new int[5];
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}.enter the number:", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] % 10 == 0)
                {
                    total++;
                }
            }
            Console.WriteLine("Total number ending with 0: " + total);

            Console.WriteLine("*************************************************");
            // Dizi Örnek 5: 10 elemanlı bir dizinin elemanları 1-1000 arasında bilgisayar tarafından rastgele atanacaktır. Bu dizideki 500-600 arasındaki sayıların toplamı ile 100-500 arasındaki sayıların sayısını bulan programı yazınız.

            Random rnd = new Random();
            int total1 = 0;
            int step = 0;
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(1, 1001);
            }
            for (int i = 0; i < 10; i++)
            {
                if (array[i] >= 500 && array[i] <= 600)
                {
                    total1 += array[i];
                }
                if (array[i] >= 100 && array[i] < 500)
                {
                    step++;
                }
            }
            Console.WriteLine("Sum of numbers between 500-600:" + total);
            Console.WriteLine("Number of numbers between 100-500:" + step);

            Console.WriteLine("*************************************************");
            // Dizi Örnek 6: Sayısal loto programı yazınız. (Kullanıcının oynamak istediği kolon sayısına göre, otomatik rastgele sayı atama gibi düşünebilirsiniz. Sayısal Loto makinelerinin otomatik numara doldurması gibi. En az 1 en fazla 8 kolon oynanabilir.)

            int[] numberss = new int[6];
            Random rn = new Random();
            Console.WriteLine("How many columns do you want to play");
            int column = Convert.ToInt32(Console.ReadLine());
            if (column >= 1 && column <= 8)
            {
                for (int j = 0; j < column; j++)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        numberss[i] = rn.Next(1, 50);
                    }
                    Array.Sort(numberss);
                    for (int i = 0; i < 6; i++)
                    {
                        Console.Write(numberss[i] + " ");
                    }
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine("You can play at least 1 and at most 8 columns.");
            }
        }


    }
}
