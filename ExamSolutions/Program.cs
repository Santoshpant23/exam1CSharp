

// PrimeOrNot pm = new PrimeOrNot();
// Console.WriteLine("Hello, Please Enter a Number:");
// string input = Console.ReadLine();
// int number = Convert.ToInt32(input);

// Console.WriteLine(pm.CheckPrime(number));
// Console.WriteLine(pm.getAllPrimesInRange(number));


// LikeSystem ls = new LikeSystem();
// string[] arr = { "Alex", "Jacob", "Mark", "Max"};
// Console.WriteLine(ls.getLikes(arr));


SearchInArray sa = new SearchInArray();

string[] parents = { "home", "milk", "Mercury", "fish" };
string child = "me";
string[] array = sa.searchParts(parents, child);
Console.WriteLine(String.Join(", ", array));
