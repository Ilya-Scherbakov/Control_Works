// Программа, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

void createArr(string[] arr) // создание массива из введенных элементов
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элеммент массива: ");
        arr[i] = Console.ReadLine();
    }
}

void createNewArr(string[] arr) // извлечение элементов массива удовлетворяющих условию задачи
{
    string[] newarr = new string[arr.Length]; //Новый массив
    int count = 0;                            //Счетчик элементов в новом массиве             
    for (int i = 0; i < arr.Length; i++)      //Перебор оригинального массива, и присвоение выбранных элемнтов новому массиву
    {
        if (arr[i].Length <= 3)
        {
            newarr[count] = arr[i];
            count++;
        }
    }
    Console.WriteLine("Новый массив");        //Вывод  сформированного массива
    Console.WriteLine(string.Join(" ", newarr));
}

void PrintArray(string[] arr)          // Метод печатает массив
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

Console.Write("Задайте количество строк: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string[length];
createArr(array);
PrintArray(array);
Console.WriteLine();
createNewArr(array);
