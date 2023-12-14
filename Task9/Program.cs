int a=Convert.ToInt32(Console.ReadLine());
int b,c;
int[] arr = new int [a];
for (int i = 0; i < a; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
b=Convert.ToInt32(Console.ReadLine());
c=Convert.ToInt32(Console.ReadLine());
for (int i = b+1; i < c; i++)
{
    System.Console.Write($"{arr[i]} ");
}