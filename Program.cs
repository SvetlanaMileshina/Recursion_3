//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
void ShowReverseArray(int[] array, int j)
{
    if (j == 0) //Условие выхода их рекурсии
    {
        Console.Write($"{array[j]}"); // Печать последнего элемента массива и завершение печати
        return;
    }
    Console.Write($"{array[j] + "  "}"); //Печатаем последний элемент
    ShowReverseArray(array, j - 1); //Переход к индексу следующего с конца элемента.   
}

int[] array = { 1, 2, 0, 10, 34 };
int j = array.Length - 1;
ShowReverseArray(array, j);


