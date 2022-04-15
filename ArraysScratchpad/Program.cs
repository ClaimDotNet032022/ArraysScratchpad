int[] myIntArray = new int[7];

myIntArray[3] = 27;
myIntArray[5] = 35;

int sum = myIntArray[3] + myIntArray[5];

string[] myStringArray = new string[2];

myStringArray[0] = "Hello";
myStringArray[1] = "World";

Console.WriteLine(myStringArray[1]);
Console.WriteLine(myStringArray[0]);



int[] literalArray;

//literalArray = new int[5];
//literalArray[0] = 27;
//literalArray[1] = 31;
//literalArray[2] = 97;
//literalArray[3] = 100;
//literalArray[4] = 35;


literalArray = new int[] { 27, 31, 97, 100, 35, 80 };



literalArray[6] = 7;

for (int i = 0; i < literalArray.Length; ++i)
{
    Console.WriteLine(literalArray[i]);
}

//////////////////////////////////////////////////////////////

// Get 3 strings from the user.
// Print them in reverse order.


// DRY:
// Don't
// Repeat
// Yourself

Console.WriteLine("How many strings?");
string numberAsString = Console.ReadLine();
int number = int.Parse(numberAsString);

string[] inputs = new string[number];

for(int i = 0; i < inputs.Length; ++i)
{
    Console.WriteLine("Enter a string:");
    inputs[i] = Console.ReadLine();
}

for(int i = inputs.Length - 1; i >= 0; --i)
{
    Console.WriteLine(inputs[i]);
}

foreach(string input in inputs)
{
    Console.WriteLine(input);
}


////////////

List<int> myList = new List<int>();
myList.Add(6);
myList.Add(21);
myList.Add(45);

myList[2] = 91;
Console.WriteLine(myList[0]);

for(int i = 1; i < myList.Count; ++i)
{
    Console.WriteLine(myList[i]);
}

foreach(int element in myList)
{
    Console.WriteLine(element);
}




Console.ReadKey();