//Задача 3: Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

int [] CreateArray(int min, int max, int size)
{
    int [] array = new int [size];
    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array; 
}

void ShowArray(int [] array)
{
    for(int i = 0; i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

void ShowRevArray(int [] array)
{    
    for(int i = 0; i<array.Length;i++)
    {
        Console.Write(array[array.Length-i-1]+" ");
    }
    Console.WriteLine();
}



Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int max = Convert.ToInt32(Console.ReadLine());

int [] newarray = CreateArray(min, max, size);
ShowArray(newarray);
ShowRevArray(newarray);