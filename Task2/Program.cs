int a=Convert.ToInt32(Console.ReadLine());
int cnt=1;
int[] arr = new int [a];
for (int i = 0; i < a; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
    cnt*=arr[i];
}
if(arr[0]<0) {System.Console.Write($"({arr[0]})");}
else System.Console.Write($"{arr[0]}");
for (int i = 1; i < a; i++)
{
    if(arr[i]<0) {System.Console.Write($"*({arr[i]})");}
    else {System.Console.Write($"*{arr[i]}");}
}
System.Console.Write($"={cnt}");