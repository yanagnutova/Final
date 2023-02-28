// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна 3-м символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

string InputString(string msg) 
{
    System.Console.Write(msg + " ");
    return Convert.ToString(Console.ReadLine());
}

void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputString("Введите значение элемента");
    }
}

void LengthSimw(string[] array, int numb) 
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numb) 
        Console.Write($"{array[i]} "); 
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.Write($"-> ");
}

int numb = 3;
string[] array = new string[4];
InputArray(array);
PrintArray(array);
LengthSimw(array, numb);
