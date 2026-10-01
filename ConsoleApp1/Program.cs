int number_ne_dvoich = 0;
Console.Write("Введите число ");
number_ne_dvoich = Convert.ToInt32(Console.ReadLine());
int old_number = number_ne_dvoich;
Console.Write($"число {number_ne_dvoich} в двоичной степени: ");
int count_first = 0;
while (number_ne_dvoich !=0)
{   
   int time_number = number_ne_dvoich % 2;
    number_ne_dvoich = number_ne_dvoich / 2;
    Console.Write(time_number);  
    count_first++;  
}
Console.WriteLine();
Console.WriteLine("Если прибавить 1");
old_number = old_number+1;
Console.Write($"число {old_number} в двоичной степени: ");
int count_second = 0;
while (old_number != 0)
{
    int time_number = old_number % 2;
    old_number = old_number / 2;
    Console.Write(time_number);
    count_second++;
}

int count_third = count_second - count_first;
Console.WriteLine($"\nРазница в разрядности {count_third}");



