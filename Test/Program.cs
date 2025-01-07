
int[] numbers = { 1, 2, 3 };
Console.WriteLine("Array Elements: ");

foreach (int num in numbers)
{
    Console.WriteLine(Math.Pow(num,2));
}

Console.WriteLine("----------------------------------------");

string[] names = { "Muhammad", "Nurullo", "Test" };
foreach (var name in names)
{
    Console.WriteLine(name);
}
