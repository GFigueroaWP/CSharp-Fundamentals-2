//1. Imprimir 1-255​
Console.WriteLine("1. Imprimir 1-255");
static void PrintNumbers()
{
    for (int i = 1; i <= 255; i++)
    {
        Console.WriteLine(i);
    }
}
PrintNumbers();
//2. Imprimir números impares entre 1-255​
Console.WriteLine("2. Imprimir números impares entre 1-255");
static void PrintOdds()
{
    for (int i = 1; i <= 255; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}
PrintOdds();
//3. Imprimir Suma​
Console.WriteLine("3. Imprimir Suma");
static void PrintSum()
{
    int sum = 0;
    for (int i = 1; i <= 255; i++)
    {
        sum += i;
        Console.WriteLine($"Nuevo numero: {i} Suma: {sum}");
    }
}
PrintSum();
//4. Iterar a través de una matriz​
Console.WriteLine("4. Iterar a través de una matriz");
static void LoopArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}
LoopArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
//5. Encuentra el valor máximo
Console.WriteLine("5. Encuentra el valor máximo");
static int FindMax(int[] numbers)
{
    int mayor = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > mayor)
        {
            mayor = numbers[i];
        }
    }
    return mayor;
}
Console.WriteLine(FindMax(new int[] { -1, 2, -3, -4, 0, 16, 7, 58, 89 }));
//6. Obtén el Promedio​
Console.WriteLine("6. Obtén el Promedio");
static void GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    float average = sum / numbers.Length;
    Console.WriteLine($"Promedio: {average}");
}
GetAverage(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
//7. Lista con números impares​
Console.WriteLine("7. Lista con números impares");
static List<int> OddList()
{
    // Write a function that creates, and then returns, a List that contains all the odd numbers between 1 to 255. 
    // When the program is done, the List should have the values of [1, 3, 5, 7, ... 255].
    List<int> oddList = new List<int>();
    for (int i = 1; i <= 255; i++)
    {
        if (i % 2 != 0)
        {
            oddList.Add(i);
        }
    }
    return oddList;
}
List<int> odds = OddList();
foreach (int odd in odds)
{
    Console.WriteLine(odd);
}
//8. Mayor que Y​
Console.WriteLine("8. Mayor que Y");
static int GreaterThanY(List<int> numbers, int y)
{
    // Write a function that takes an integer List, and an integer "y" and returns the number of values 
    // That are greater than the "y" value. 
    // For example, if our List contains 1, 3, 5, 7 and y is 3. Your function should return 2 
    // (since there are two values in the List that are greater than 3).
    int count = 0;
    foreach (int number in numbers)
    {
        if (number > y)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(GreaterThanY(new List<int> { 1, 3, 5, 7 }, 3));
//9. Haz Cuadrar los Valores​
Console.WriteLine("9. Haz Cuadrar los Valores");
static void SquareArrayValues(List<int> numbers)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        numbers[i] *= numbers[i];
    }
}
List<int> numbersList = new List<int> { 1, 5, 10, -10 };
SquareArrayValues(numbersList);
foreach (int number in numbersList)
{
    Console.WriteLine(number);
}
//10. Elimina los números negativos​
Console.WriteLine("10. Elimina los números negativos");
static void EliminateNegatives(List<int> numbers)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] < 0)
        {
            numbers[i] = 0;
        }
    }
}
List<int> numbersList2 = new List<int> { 1, -5, 10, -2 };
EliminateNegatives(numbersList2);
foreach (int number in numbersList2)
{
    Console.WriteLine(number);
}

