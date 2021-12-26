using System;

namespace DoubleReversal
{
    class Program
    {
        static bool IsSameAfterReversals(int num)
        {
            char[] numArray = num.ToString().ToCharArray();
            string tempNum="";
            string doubleReversed = "";
            int reversedNum;
            bool pass = true;

            for (int i = numArray.Length-1; i >= 0; i--)
            {

                if ((pass) && (numArray[i].ToString() == "0"))
                    continue;
                else
                    pass = false;

                if(!pass)
                    tempNum += numArray[i].ToString();


            }

            for (int i = tempNum.Length - 1; i >= 0; i--)
            {
                doubleReversed += tempNum[i].ToString();


            }


            int.TryParse(doubleReversed, out reversedNum);

            if (num == reversedNum)
                return true;
            else 
                return false;
        }
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            IsSameAfterReversals(num);
        }
    }
}
