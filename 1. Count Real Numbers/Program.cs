List<double> numbers = Console.ReadLine()
    .Split(" ")
    .Select(double.Parse)
    .ToList();

var dictionary = new SortedDictionary<double, double>();

foreach(var number in numbers)
{

    if (dictionary.ContainsKey(number))
    {
        dictionary[number]++;
     
    }
    else 
    {
        dictionary[number] = 1;
    }
  }
foreach(var number in dictionary)
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}
