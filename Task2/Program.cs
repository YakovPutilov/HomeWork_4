//Задача 2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int [] CreateArray(int min, int max, int size)
{

    int [] array = new int [size];
    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array; 
}

void ShowArray(int [] array){
    
    for(int i = 0; i<array.Length;i++){
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

void ShowEven(int [] array)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
       if(array[i] % 2 == 0)
       {
        count ++;
       }
    }
    Console.WriteLine("answer is " + count);
}
int [] newarray = CreateArray(100, 999, 10);
ShowArray(newarray);
ShowEven(newarray);