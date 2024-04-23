

using System;

public class FinalTasks {
    static public void Main(string[] args) {
        //Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
        // длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
        // либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
        // лучше обойтись исключительно массивами.
        string[] arraySource = new string[5] {"1asdasd23", "2d3", "hello", "world", "123"};
        getResult(arraySource);
    }

    public static void getResult(string[] arraySource)
    {
        string[] arrayNew = new string[arraySource.Length];
        int count = 0;
        for (int i = 0; i < arraySource.Length; i++) {
            if(arraySource[i].Length <= 3) {
                arrayNew[count] = arraySource[i];
                count++;
            }
        }
        printArray(arrayNew);
    }

    public static void printArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++) {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
}