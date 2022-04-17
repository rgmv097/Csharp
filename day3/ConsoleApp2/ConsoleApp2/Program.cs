using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 eded daxil edin. Eger o eded 50den kicikdirse o edede qeder 3-e bolunen,
            //50-100 araligindadirsa o edede qeder 5e bolunen, 100den boyukdurse o edede qeder
            //8 e bolunen ededleri ayri bir arrayin icerisine elave edib, bolunen butun ededleri ekrana cixardan bir alqoritm
            int InputName = Convert.ToInt32(Console.ReadLine());
            int size = 0;
            int InccreasingNum = 0;
            if (InputName < 50)
            {
                int ModNum = 3;

                size = SizeOfArr(InputName, size, ModNum);
                Console.WriteLine("Size OF ARR: " + size);
                NewArr(size, ModNum, InccreasingNum);
            }
            if (InputName > 50 && InputName < 100)
            {
                int ModNum = 5;
                size = SizeOfArr(InputName, size, ModNum);
                Console.WriteLine("Size OF ARR: " + size);
                NewArr(size, ModNum, InccreasingNum);
            }
            if (InputName > 100)
            {
                int ModNum = 8;
                size = SizeOfArr(InputName, size, ModNum);
                Console.WriteLine("Size OF ARR: " + size);
                NewArr(size, ModNum, InccreasingNum);
            }
        }
        public static int SizeOfArr(int InputNum, int Size, int ModNum)
        {
            for (int i = 1; i < InputNum; i++)
            {
                if (i % ModNum == 0) { Size++; }

            }
            return Size;
        }
        public static void NewArr(int Size, int ModNum, int IncreasingNum)
        {
            int[] NewArr = new int[Size];
            for (int i = 0; i < Size; i++)
            {

                NewArr[i] = ModNum + IncreasingNum;
                IncreasingNum = IncreasingNum + ModNum;
                Console.Write(NewArr[i] + " ");
            }


        }


    }


}

