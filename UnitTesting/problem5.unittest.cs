using Xunit;
using System.Collections.Generic;

public class IntegerManipulationTests
{
    [Fact]
    public void TestSumGreaterThan50WithVariousNumbers()
    {
        IntegerManipulation manipulator = new IntegerManipulation();

        // Case 1: Test with multiple even numbers, including some greater than 50
        List<int> numbers = new List<int> { 10, 25, 60, 80, 45, 90 };
        int result = manipulator.getSumGreaterThan50(numbers);

        // Expected output: 60 + 80 + 90 = 230
        Assert.Equal(230, result);
    }

    [Fact]
    public void TestSumGreaterThan50WithNoNumbersOver50()
    {
        IntegerManipulation manipulator = new IntegerManipulation();

        // Case 2: Test with even numbers but none greater than 50
        List<int> numbers = new List<int> { 2, 4, 18, 30, 48 };
        int result = manipulator.getSumGreaterThan50(numbers);

        // Expected output: 0 (no even numbers greater than 50)
        Assert.Equal(0, result);
    }
}
