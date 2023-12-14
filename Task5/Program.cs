int a=Convert.ToInt32(Console.ReadLine());
int[] arr = new int [a];
int cnt=999999999,ctr=0;
for (int i = 0; i < a; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
    if(arr[i]<cnt) {cnt=arr[i]; ctr=i;}
}
System.Console.WriteLine(ctr);