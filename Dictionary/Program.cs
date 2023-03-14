// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Dictionary
//Allows us to pair keys and values
//referred to as maps or hashtables

Dictionary<int ,string> libraryBooks = new Dictionary<int ,string>();

//Keys cannot be null and needs to be unique

libraryBooks.Add(345, "Gone Girl");
//Add(key, value)
libraryBooks.Add(654, "Altruism");
libraryBooks.Add(349, "The Witcher");
libraryBooks.Remove(345); //Remove based on the Key

foreach(KeyValuePair<int, string> libraryBook in libraryBooks)
{
    Console.WriteLine(libraryBook.Value);
    Console.WriteLine(libraryBook.Key);
}


Console.WriteLine(libraryBooks.Count);
bool answer = libraryBooks.ContainsKey(333);
Console.WriteLine(answer);
bool answer2 = libraryBooks.ContainsValue("The Witcher");
Console.WriteLine(answer2);


Console.WriteLine(libraryBooks[349)]; // use the key not index
libraryBooks.Clear();

libraryBooks.Add(34, "Curious George");

foreach (KeyValuePair<int, string> libraryBook in libraryBooks)
{
    Console.WriteLine(libraryBook.Value);
    Console.WriteLine(libraryBook.Key);
}


//Values can be repeated, Keys cannot

//What is an object?
//what is a property?
//how would you describe a class?
//what is a method?
//What is a variable?




