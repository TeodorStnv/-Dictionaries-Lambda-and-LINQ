using System.Collections.Generic;

int num = int.Parse(Console.ReadLine());
var ListOfSyn = new Dictionary<string, List<string>>();

for (int i = 0; i < num; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if(!ListOfSyn.ContainsKey(word))
    {
        ListOfSyn.Add(word, new List<string> {synonym}); 
    }
    else
    {
        ListOfSyn[word].Add(synonym);
    }
}
foreach (var word in ListOfSyn)
{
    Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
}