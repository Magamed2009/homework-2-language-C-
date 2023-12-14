int a=Convert.ToInt32(Console.ReadLine());
int[] arr = new int [a];
for (int i = 0; i < a; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
Array.Reverse(arr);
for (int i = 1; i < a; i++)
{
    if(arr[i]>0 && arr[i-1]>0 || arr[i]<0 && arr[i-1]<0) {System.Console.WriteLine($"{arr[i]} {arr[i-1]}"); return ;}
}