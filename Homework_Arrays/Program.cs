
// Create an array of 3 names. Ask user which number to select.
// When user gives you a number, return that name.
// Check for invalid numbers.

string[] names = new string[] { "Bob", "Jack", "Sparrow" };
int num;
do
{
	Console.Write($"Enter a number between 1 and {names.Length}: ");
	int.TryParse(Console.ReadLine(), out num);

	if (num > 0 && num <= names.Length)
	{
		Console.WriteLine(names[num - 1]);
	}
	else
	{
		Console.WriteLine("Invalid number.");
	} 
} while (!(num > 0 && num <= names.Length));
