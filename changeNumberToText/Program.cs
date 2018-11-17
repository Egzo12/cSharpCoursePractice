using System;


namespace _20181112MethodsNamuDarbai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            String StartNumber = Console.ReadLine();
            Boolean Isnumeric = CheckIfNumber(StartNumber);
            String Zero = "0";

            if (StartNumber == Zero)
            {
                Console.WriteLine("Nulis");
            }

            if (Isnumeric)
            {
                int ConvertedStartnumber = ConvertToInt(StartNumber);
                Boolean Range = CheckRange(ConvertedStartnumber);
                if (Range)
                {
                    Boolean isNegative = ConvertedStartnumber.ToString().Contains("-");
                    if (isNegative)
                    {
                        String NegativeNumber = ConvertedStartnumber.ToString().Substring(1);
                        ConvertedStartnumber = Convert.ToInt32(NegativeNumber);
                        String Numeros = ConvertToTextFULL(NegativeNumber);
                        Console.WriteLine("Minus " + Numeros);
                    }
                    else
                    {
                        String Numeros = ConvertToTextFULL(StartNumber);
                        Console.WriteLine(Numeros);
                    }
                }
                else
                {
                    Console.WriteLine("Number is not in Range");
                }
            }
            else
            {
                Console.WriteLine("String is not a number");
            }
            Console.ReadLine();
        }
        static Boolean CheckIfNumber(String isnumber)
        {
            foreach (var item in isnumber)
            {
                if (!char.IsDigit(item) && item != '-')
                {
                    return false;
                }
            }
            return true;
        }
        static int ConvertToInt(String Startnumber)
        {
            int number = Convert.ToInt32(Startnumber);
            return number;
        }
        static Boolean CheckRange(int number)
        {
            if (number >= -999999 && number <= 999999)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static String ConvertToTextOnes(String number)
        {
            String NumberInWords = "";
            int _number = Convert.ToInt32(number);
            switch (_number)
            {
                case 1:
                    NumberInWords = "Vienas";
                    break;
                case 2:
                    NumberInWords = "Du";
                    break;
                case 3:
                    NumberInWords = "Trys";
                    break;
                case 4:
                    NumberInWords = "Keturi";
                    break;
                case 5:
                    NumberInWords = "Penki";
                    break;
                case 6:
                    NumberInWords = "Sesi";
                    break;
                case 7:
                    NumberInWords = "Septyni";
                    break;
                case 8:
                    NumberInWords = "Astuoni";
                    break;
                case 9:
                    NumberInWords = "Devyni";
                    break;
                default:
                    break;
            }
            return NumberInWords;
        }
        static String ConvertToTextTens(String number)
        {
            if (number.Substring(0, 1) == "0")
            {
                number = number.TrimStart('0');
            }
            int _number = Convert.ToInt32(number);
            String NumberInWords = "";
            switch (_number)
            {
                case 10:
                    NumberInWords = "Desimt";
                    break;
                case 11:
                    NumberInWords = "Vienuolika";
                    break;
                case 12:
                    NumberInWords = "Dvylika";
                    break;
                case 13:
                    NumberInWords = "Trylika";
                    break;
                case 14:
                    NumberInWords = "Keturiolika";
                    break;
                case 15:
                    NumberInWords = "Penkiolika";
                    break;
                case 16:
                    NumberInWords = "Sesiolioka";
                    break;
                case 17:
                    NumberInWords = "Septyniolika";
                    break;
                case 18:
                    NumberInWords = "Astuoniolika";
                    break;
                case 19:
                    NumberInWords = "Devyniolika";
                    break;
                case 20:
                    NumberInWords = "Dvidesimt";
                    break;
                case 30:
                    NumberInWords = "Trisdesimt";
                    break;
                case 40:
                    NumberInWords = "Keturiasdesimt";
                    break;
                case 50:
                    NumberInWords = "Penkiasdesimt";
                    break;
                case 60:
                    NumberInWords = "Sesiasdesimt";
                    break;
                case 70:
                    NumberInWords = "Septyniasdesimt";
                    break;
                case 80:
                    NumberInWords = "Astuoniasdesimt";
                    break;
                case 90:
                    NumberInWords = "Devyniasdesimt";
                    break;
                default:
                    String dealwith0 = number.Substring(1);
                    if (String.IsNullOrEmpty(dealwith0))
                    {
                        NumberInWords = ConvertToTextOnes(number.Substring(0));
                        break;
                    }
                    NumberInWords = ConvertToTextTens(number.Substring(0, 1) + "0") + " " + ConvertToTextOnes(number.Substring(1));
                    break;
            }
            return NumberInWords;
        }
        static String ConvertToTextHundrets(String number)
        {
            int _number = Convert.ToInt32(number);
            String NumberInWords = "";
            if (number.Substring(0, 1) == "1")
            {
                if (number == "100")
                {
                    NumberInWords = "Simtas";
                }
                else
                {
                    NumberInWords = "Simtas" + " " + ConvertToTextTens(number.Substring(1));
                }
            }
            else if (number.Substring(0, 1) == "0")
            {
                NumberInWords = ConvertToTextTens(number.Substring(1));
            }
            else
            {
                NumberInWords = ConvertToTextOnes(number.Substring(0, 1)) + " Simtai " + ConvertToTextTens(number.Substring(1));
            }
            return NumberInWords;
        }
        static String ConvertToTextTousends(String number)
        {
            int _number = Convert.ToInt32(number);
            String NumberInWords = "";
            if (number.Substring(0, 1) == "1")
            {
                NumberInWords = "Tukstantis" + " " + ConvertToTextHundrets(number.Substring(1));
            }
            else
            {
                NumberInWords = ConvertToTextOnes(number.Substring(0, 1)) + " " + "Tukstanciai" + " " + ConvertToTextHundrets(number.Substring(1));
            }
            return NumberInWords;
        }
        static String ConvertToTextTenThousends(String number)
        {
            int _number = Convert.ToInt32(number);
            String NumberInWords = "";
            NumberInWords = ConvertToTextTens(number.Substring(0, 2)) + " " + "Tukstanciu" + " " + ConvertToTextHundrets(number.Substring(2));
            return NumberInWords;
        }
        static String ConvertToTextHundThousends(String number)
        {
            int _number = Convert.ToInt32(number);
            String NumberInWords = "";
            if (number.Substring(0, 1) == "1" && number.Substring(2, 1) == "1")
            {
                NumberInWords = ConvertToTextHundrets(number.Substring(0, 3)) + " " + "Tukstantis" + " " + ConvertToTextHundrets(number.Substring(3));
            }
            else if (number.Substring(2, 1) == "0")
            {
                if (number == "100000")
                {
                    NumberInWords = "Simtas Tukstanciu";
                }
                else
                {
                    NumberInWords = ConvertToTextHundrets(number.Substring(0, 3)) + " " + "Tukstantciu" + " " + ConvertToTextHundrets(number.Substring(3));
                }
            }
            else
            {
                NumberInWords = ConvertToTextHundrets(number.Substring(0, 3)) + " " + "Tukstanciai" + " " + ConvertToTextHundrets(number.Substring(3, 3));
            }
            return NumberInWords;
        }

        static String ConvertToTextFULL(String number)
        {
            int length = number.ToString().Length;
            String NumberInWords = "";
            switch (length)
            {
                case 1:
                    NumberInWords = ConvertToTextOnes(number);
                    break;
                case 2:
                    NumberInWords = ConvertToTextTens(number);
                    break;
                case 3:
                    NumberInWords = ConvertToTextHundrets(number);
                    break;
                case 4:
                    NumberInWords = ConvertToTextTousends(number);
                    break;
                case 5:
                    NumberInWords = ConvertToTextTenThousends(number);
                    break;
                case 6:
                    NumberInWords = ConvertToTextHundThousends(number);
                    break;
                default:
                    break;
            }
            return NumberInWords;
        }
    }
}
