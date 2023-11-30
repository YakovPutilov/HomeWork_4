//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


void Request_number(){
    Console.WriteLine("Enter number: ");
    string number = Console.ReadLine();
    if (number == "q"){
        Console.WriteLine();
    }
    else{
        int num = Convert.ToInt32(number);
        int count = 0;
        while(num > 0){
            count = count + num % 10;
            num = num / 10;
        }
        if (count % 2 != 0){
            Request_number();
        }
        else{
            Console.WriteLine();
        }
    }

}
Request_number();