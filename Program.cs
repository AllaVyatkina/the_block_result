string[] arrayNew1 = new string[7] {"hello", "123", "54", "world", "result", "pic", "333"};
string[] arrayNew2 = new string[arrayNew1.Length];
void SecondArrayWithIF(string[] aarrayNew1, string[] arrayNew2)
{
    int count = 0;
    for (int i = 0; i < arrayNew1.Length; i++)
    {
    if(arrayNew1[i].Length <= 3)
        {
        arrayNew2[count] = arrayNew1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(arrayNew1, arrayNew2);
PrintArray(arrayNew2);