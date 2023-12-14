int cnt=0;
int a=Convert.ToInt32(Console.ReadLine());
int[] arr= new int[a];
for (int i = 0; i < a; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
Array.Sort(arr);
for (int i = 0; i < a; i++)
{
    cnt=0;
    for (int j = 0; j < a; j++)
    {
        if(arr[i]==arr[j]) {cnt++;}
    }
    if(cnt==1) {System.Console.Write($"{arr[i]} ");}
}