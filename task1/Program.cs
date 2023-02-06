// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3 

System.Console.WriteLine("Введите числа через пробел");
string numlist = Console.ReadLine();

string[] SplitList = numlist.Split(' ');
int[] ConvertNumList(string[] arr)
{
    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        // result[i] = int.Parse(arr[i]!);
        result[i] = Convert.ToInt32(arr[i]);
    }
    return result;
}

int CountNumAbove0(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            result++;
        }
    }
    return result;
}
System.Console.WriteLine(CountNumAbove0(ConvertNumList(SplitList)));