// int[] GetArray(int size, int minValue, int maxValue) // size , minValue, maxValue
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// // Вызов функции

// int[] newArray = GetArray(12, -9, 9);

// Console.WriteLine(String.Join(", ", newArray));

// int positiveResult = 0;
// int negativeResult = 0;

// for (int i = 0; i < newArray.Length; i++)
// {
//     if (newArray[i] > 0)
//     {
//         positiveResult += newArray[i];
//     }
//     else negativeResult += newArray[i];
// }

// for (int i = 0; i < newArray.Length; i++)
// {
//     positiveResult += newArray[i] > 0 ? newArray[i] : 0;
//     negativeResult += newArray[i] < 0 ? newArray[i] : 0;
// }

// Console.WriteLine($"Сумма отрицательных чисел: {negativeResult}, сумма положительных чисел: {positiveResult}");

// int[] ReverseArray (int[] array)
// {
//     int size = array.Length;
//     for (int i = 0; i < size; i++)
//     {
//         array[i] *= (-1);
//     }
//     return array;
// }

// Console.WriteLine($"Reverse array: {String.Join(", ", ReverseArray(newArray))}");

// int [] array = {1, 2, 3, 4, 5};
// int find = new Random().Next(1,11);
// int size = array.Length;
// bool result = false;


// for (int i = 0; i < size; i++)
// {
//     if (array[i] == find)
//     {
//         result = true;
//         break;
//     } 
// }

// if (result) {
//     Console.WriteLine($"Элемент {find} найден ");
// } else Console.WriteLine($"Элемент {find} не найден ");

// int [] array = {1, 2, 3, 4, 5};
// int find = new Random().Next(1,11);
// int size = array.Length;
// string result = "отсутствует";


// for (int i = 0; i < size; i++)
// {
//     if (array[i] == find)
//     {
//         result = "присутствует";
//         break;
//     }
// }

// Console.WriteLine($"Элемент {find} в массиве {result}");

int[] array = new int[123];
int sum = 0;
int size = array.Length;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1,100);
        if (array[i] >= 10 && array[i] <= 100)
        {
            sum += 1;
        }
}
Console.WriteLine($"\n{String.Join(", ", array)} -> {sum}");



int GetCountElements(int[] inputArray, int minRange, int maxRange)
{
    int count = 0;
    foreach (var item in inputArray)
    {
        if(item >= minRange && item <= maxRange)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(GetCountElements(array, 10, 100));