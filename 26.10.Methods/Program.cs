using System;

namespace _26._10.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1


            // Console.WriteLine(SumAndMulti(5, 10));


            #endregion

            #region Task 2

            //Console.WriteLine(sumRange(5,9));




            #endregion
            #region Taks 3

            //Console.WriteLine(SumTwo(2,4));
            #endregion
            #region Taks 4

            Console.WriteLine(task(4,5,6));

            #endregion

        }
        static string SumAndMulti(int a, int b)
        {
            string result = $"sumi {a + b}  multi si {a * b}";
            return result;


        }

        static int sumRange(int a, int b)
        {

            int sum = 0;
             for (int i=a; i <= b; i++)
            {
                sum += i;
            }
            
            return sum;
        }

        static int SumTwo(int a,int b) 
        {

           int sum = a + b;

            return sum;
        }

        static string task(int a,int b,int c)
        {

            string result = $"multi {a * b * c} cixma {a - b - c} mix {a * b - c} mixs {a + b / a * c}";


            return result;
        }

    }
}
