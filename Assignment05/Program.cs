namespace Assignment05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1,2
            static void ValueSwap(int X, int Y)
            {
                int Temp = X;
                X = Y;
                Y = Temp;
            }
            static void RefSwap(ref int X,ref int Y)
            {
                int Temp = X;
                X = Y;
                Y = Temp;
            }
            int x = 5,y = 10;
            Console.WriteLine($"x is {x} and y is {y} before value swap");
            ValueSwap(x,y);
            Console.WriteLine($"x is {x} and y is {y} After value swap");
            RefSwap(ref x,ref y);
            Console.WriteLine($"x is {x} and y is {y} After Reference swap");
            #endregion
            #region 3
            bool isInt = false;
            int num1 , num2 , num3 , num4;
            static (int, int) SumAndSub(int n1, int n2, int n3, int n4)
            {
                int n5 = n1 + n2;
                int n6 = n3 - n4;
                return (n5, n6);
            }
            Console.WriteLine("Please enter the first number : ");
            isInt = int.TryParse(Console.ReadLine(), out num1);
            while (!isInt)
            {
                Console.WriteLine("Please enter the first number : ");
                isInt = int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine();
            }
            Console.WriteLine("Please enter the second number : ");
            isInt = int.TryParse(Console.ReadLine(), out num2);
            while (!isInt)
            {
                Console.WriteLine("Please enter the second number : ");
                isInt = int.TryParse(Console.ReadLine(), out num2);
                Console.WriteLine();
            }
            Console.WriteLine("Please enter the third number : ");
            isInt = int.TryParse(Console.ReadLine(), out num3);
            while (!isInt)
            {
                Console.WriteLine("Please enter the third number : ");
                isInt = int.TryParse(Console.ReadLine(), out num3);
                Console.WriteLine();
            }
            Console.WriteLine("Please enter the fourth number : ");
            isInt = int.TryParse(Console.ReadLine(), out num4);
            while (!isInt)
            {
                Console.WriteLine("Please enter the fourth number : ");
                isInt = int.TryParse(Console.ReadLine(), out num4);
                Console.WriteLine();
            }        
            int num5, num6;
            (num5,num6) =SumAndSub(num1, num2, num3, num4);
            Console.WriteLine($"{num5} and {num6}");
            #endregion
            #region 4
            static int SumDigits(int num)
            {
                int sum = 0;
                while (num > 0)
                {
                    sum += (num % 10);
                    num /= 10;
                }
                return sum;
            }
            Console.WriteLine(SumDigits(25));
            #endregion
            #region 5
            static bool IsPrime(int num)
            {
                bool isPrime = true;
                for (int i = 1; i <= (int)Math.Sqrt(num); i++)
                {
                    if (((num % i == 0) && i != 1) || num == 1)
                    {
                        isPrime = false;
                    }
                }
                return isPrime;
            }
            int.TryParse(Console.ReadLine(), out int result);
            Console.WriteLine(IsPrime(result));
            #endregion
            #region 6
            static (int,int) MinMax(ref int[]arr)
            {
                return (arr.Min(), arr.Max());
            }
            #endregion
            #region 7
            static int Factorial(int num)
            {
                int result = 0;
                for (int i = 1;i<=num;i++)
                {
                    result += i;
                }
                return result;
            }
            #endregion
            #region 8
            static string ChangeChar(string input, int position, char newChar)
            {
                char[] charArray = input.ToCharArray();
                charArray[position] = newChar;
                return new string(charArray);
            }
            #endregion
        }
    }
}
