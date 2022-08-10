Console.Write("Enter the size of the array please: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] inputArray = new string[size];
int counter = 0;

FillArray(inputArray);
PrintArray(inputArray);

string[] resultArray = GetResultArray(inputArray);
Console.Write($"Resulting array is: [ {string.Join("; ", resultArray)} ]");

void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Enter the string please: ");
        arr[i] = Console.ReadLine();
        if (arr[i].Length <= 3) counter++;
    }
}

void PrintArray(string[] ar)
{
    Console.WriteLine($"Your array is: [ {string.Join("; ", ar)} ]");
}

string[] GetResultArray(string[] arr)
{
    string[] resultArray = new string[counter];
    int j = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            resultArray[j] = arr[i];
            j++;
        }
    }

    return resultArray;
}
