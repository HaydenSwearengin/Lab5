
int loops;

Console.WriteLine("How many prices would you like?");
loops = Convert.ToInt16(Console.ReadLine());

double final_Num = 0;
double price;
for(int i = 0;i < loops;i++)
{
    Console.Write($"Enter Price {i}: $");
    price = Convert.ToUInt16(Console.ReadLine());
    final_Num = final_Num + price;
}

Console.WriteLine($"The total amount of all prices is: ${final_Num}");