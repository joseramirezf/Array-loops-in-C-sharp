Console.WriteLine("Array Loop");

//Size
Console.WriteLine("Add Amount of numbers:");
int[] number = new int[Int32.Parse(Console.ReadLine() ?? "0")];

//string amount = Console.ReadLine() ?? "0";
//int size = Int32.Parse(amount);
//int[] number = new int[size];

//const int size = 5;
//int[] number = new int[size];

//Fill
for (int i = 0; i < number.Length; i++)
{
Console.WriteLine("Add a Number:");
string input = Console.ReadLine() ?? "0";
number[i] = Int32.Parse(input);
}

for (int i = 0; i < number.Length; i++)
{
Console.WriteLine(number[i]);
}

//Sum
int total = 0; 
for (int i = 0; i < number.Length; i++)
{
total = total + number[i];
}

//Print
Console.WriteLine("Total:" + total);


//Long Version

//Console.WriteLine("Add a Number:");
//string input0 = Console.ReadLine() ?? "0";
//number[0] = Int32.Parse(input0);
//Console.WriteLine("Add a Number:");
//string input1 = Console.ReadLine() ?? "0";
//number[0] = Int32.Parse(input1);
//Console.WriteLine("Add a Number:");
//string input2 = Console.ReadLine() ?? "0";
//number[0] = Int32.Parse(input2);
//Console.WriteLine("Add a Number:");
//string input3 = Console.ReadLine() ?? "0";
//number[0] = Int32.Parse(input3);
//Console.WriteLine("Add a Number:");
//string input4 = Console.ReadLine() ?? "0";
//number[0] = Int32.Parse(input4);

//Console.WriteLine(number[0]);
//Console.WriteLine(number[1]);
//Console.WriteLine(number[2]);
//Console.WriteLine(number[3]);
//Console.WriteLine(number[4]);



