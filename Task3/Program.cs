int a=Convert.ToInt32(Console.ReadLine());
int cnt=-999999999,ctr=0;
int[] arr = new int [a];
for (int i = 0; i < a; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
    if(arr[i]>cnt) {cnt=arr[i]; ctr=i;}
}
System.Console.WriteLine(ctr);