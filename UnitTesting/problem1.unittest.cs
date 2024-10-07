using Xunit;

public class PrimeOrNotTests
{
    [Fact]
    public void TestPrimeAndNonPrimeNumbers()
    {
        PrimeOrNot primeChecker = new PrimeOrNot();
        int[] testNumbers = { 11, 12, 13, 14, 15 };
        bool[] expectedResults = { true, false, true, false, false };

        for (int i = 0; i < testNumbers.Length; i++)
        {
            bool result = primeChecker.CheckPrime(testNumbers[i]);
            Assert.Equal(expectedResults[i], result); // Check multiple numbers for prime or non-prime
        }
    }

    [Fact]
    public void TestGetAllPrimesInRangeForEdgeCases()
    {
        PrimeOrNot primeChecker = new PrimeOrNot();

        // Case 1: Primes for positive number 20
        string resultPositive = primeChecker.getAllPrimesInRange(20);
        Assert.Equal("2 3 5 7 11 13 17 19", resultPositive);

        // Case 2: Empty result for 0 (no primes)
        string resultZero = primeChecker.getAllPrimesInRange(0);
        Assert.Equal("", resultZero);
    }
}
