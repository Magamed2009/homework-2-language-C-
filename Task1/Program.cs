double a=Convert.ToDouble(Console.ReadLine());
double cnt=0,b=0;
b=a;
cnt=a/100;
if(a<100) {cnt+=cnt*0.5;}
else if(a<=200) {cnt+=cnt*0.7;}
else {cnt=cnt*0.1;}
cnt=cnt*100;
System.Console.WriteLine(b+cnt);