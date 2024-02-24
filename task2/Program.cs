int ack(int m, int n) 
{ 
    if (m == 0)
    { 
        return n + 1; 
    } 
    else if((n == 0))
    { 
        return ack(m - 1, 1); 
    } 
    else return ack(m - 1, ack(m, n - 1));
} 
  
Console.Write("Введите число m: ");
 int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ack(m, n)); 