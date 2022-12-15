/*Написать программу, которая из имеющегося массива
строк формирует новый массив из строк, длина которых
меньше, либо равна 3 символам. Первоначальный массив 
можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

void PrintArray(string[] array)
{

    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write(array[i] + " ");

    }
    Console.Write("]");

}
string[] GetNewArray(string[] array)
{
    int length = array.Length;
    string[] newArray = new string[length];
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref newArray, count);
    return newArray;
}
string[] array = { "Hello", "2", "world", ":-)" };
PrintArray(array);
Console.WriteLine();
string[] newArray = GetNewArray(array);
PrintArray(newArray);