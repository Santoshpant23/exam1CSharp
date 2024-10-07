using System;

// Write a C# program that takes an integer input and prints whether it is prime or not. 
// Additionally, display all prime numbers up to that input number.

class PrimeOrNot
{

    public PrimeOrNot()
    {

    }
    public string getAllPrimesInRange(int number)
    {
        string allPrimes = "";

        bool isNeg = false;
        if (number < 0)
        {
            number = number * -1;
            isNeg = true;

        }

        for (int i = 2; i <= number; i++)
        {
            if (CheckPrime(i))
            {
                if (isNeg)
                {
                    allPrimes += "-" + i + " ";
                }
                else
                {
                    allPrimes += i + " ";
                }
            }
        }
        allPrimes = allPrimes.Substring(0, allPrimes.Length - 1);
        return allPrimes;
    }

    public bool CheckPrime(int number)
    {
        int completeDivisions = 0;
        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                completeDivisions++;
            }
        }
        if (completeDivisions > 0)
        {
            // Console.WriteLine("This is not a prime number");
            return false;
        }
        else
        {
            return true;
        }
    }
}
