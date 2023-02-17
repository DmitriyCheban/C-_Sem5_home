/* Задача 37:Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6]-> 36 21 */

Console.Clear();
Console.Write("Введите количество элементов в массиве: ");

int num = int.Parse(Console.ReadLine());

int[] array = GetBinArray(num);

Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetBinArray(int size){

    int[] result = new int[size];
    for (int i = 0; i < size; i++){
       result[i] = new Random().Next(10);

   
    }
    return result;
    
}



int[] result = ResultArray(num);


  
int[] ResultArray(int size){

       size = (array.Length + 1)/ 2;
//    if (array.Length % 2 == 1) size++;

    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];    


    return result;
}

Console.WriteLine($"Произведение элементов в массиве [{String.Join(", ", result)}]");