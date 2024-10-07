class IntegerManipulation
{

    public IntegerManipulation()
    {


    }

    public int getSumGreaterThan50(List<int> numbers)
    {

        var even_Numbers = numbers.Where(n => n % 2 == 0);

        // Console.WriteLine(String.Join(", ", even_Numbers));

        var sorted_in_descending = even_Numbers.OrderByDescending(n => n);

        // Console.WriteLine(String.Join(", ", sorted_in_descending));

        int sum_greater_50 = sorted_in_descending.Where(n => n > 50).Sum();



        return sum_greater_50;
    }
}