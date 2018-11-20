using System;


namespace ArraynamuDarbai
{
    class Program
    {
        static void Main(string[] args)
        {

            //Starting number
            int skaicius = 100000;

            //initial values
            int[] Converted = new int[6];
            bool isMagic = false;
            // loop throuth numbers starting from 100 000
            do
            {
                //Converting number to Array
                Converted = Masyvas(skaicius);

                //Check for dublicates, return true if found
                bool Hasdubs = CheckForDubs(Converted);

                if (Hasdubs)
                {
                    Console.WriteLine("Array has dubs, skipping " + skaicius);
                    //increment the starting number and continue
                    skaicius++;
                    continue;
                }
                else
                {
                    // if number has no dublicates, try to check for magic number, returns true if found
                    bool IsMagic = MagicNumber(Converted, skaicius);

                    if (IsMagic)
                    {
                        IsMagic = true;
                        Console.WriteLine("Magic number found: " + skaicius);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong number, continue " + skaicius);
                        //if isMagic return false, increment number and continue
                        skaicius++;
                    }
                }

            } while (isMagic == false);
            // to see output
            Console.ReadLine();
        }


        private static int[] Masyvas(int number)
        {
            int[] masyvas = new int[6];
            string numberis = Convert.ToString(number);
            for (int i = 0; i < masyvas.Length; i++)
            {
                masyvas[i] = Convert.ToInt32(numberis.Substring(i, 1));
            }
            return masyvas;
        }

        private static bool CheckForDubs(int[] masyvas)
        {
            bool HasDubs = false;
            for (int i = 0; i < masyvas.Length; i++)
            {
                for (int j = 1; j < masyvas.Length; j++)
                {
                    if (masyvas[i] == masyvas[j] && i != j)
                    {
                        HasDubs = true;
                        break;
                    }
                    else
                    {
                        HasDubs = false;
                        continue;
                    }
                }
            }
            return HasDubs;
        }

        private static bool MagicNumber(int[] masyvas, int num)
        {
            bool IsMagic = false;

            int num2 = num * 2;
            int num3 = num * 3;
            int num4 = num * 4;
            int num5 = num * 5;
            int num6 = num * 6;

            int[] ArrNum2 = new int[6];
            int[] ArrNum3 = new int[6];
            int[] ArrNum4 = new int[6];
            int[] ArrNum5 = new int[6];
            int[] ArrNum6 = new int[6];

            ArrNum2 = Masyvas(num2);
            ArrNum3 = Masyvas(num3);
            ArrNum4 = Masyvas(num4);
            ArrNum5 = Masyvas(num5);
            ArrNum6 = Masyvas(num6);

            Array.Sort<int>(masyvas);
            Array.Sort<int>(ArrNum2);
            Array.Sort<int>(ArrNum3);
            Array.Sort<int>(ArrNum4);
            Array.Sort<int>(ArrNum5);
            Array.Sort<int>(ArrNum6);

            //Ugly
            if (masyvas[0] == ArrNum2[0] && masyvas[0] == ArrNum3[0] && masyvas[0] == ArrNum4[0] && masyvas[0] == ArrNum5[0] && masyvas[0] == ArrNum6[0])
            {
                if ((masyvas[1] == ArrNum2[1] && masyvas[1] == ArrNum3[1] && masyvas[1] == ArrNum4[1] && masyvas[1] == ArrNum5[1] && masyvas[1] == ArrNum6[1]))
                {
                    if ((masyvas[5] == ArrNum2[5] && masyvas[5] == ArrNum3[5] && masyvas[5] == ArrNum4[5] && masyvas[5] == ArrNum5[5] && masyvas[5] == ArrNum6[5]))
                    {
                        IsMagic = true;
                    }
                }
            }
            return IsMagic;
        }
    }
}
