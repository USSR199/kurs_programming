void arrSumNum()
{
int col=8;
int[] myArr = new int[col];
for (int i=0;i< col;i++)
{
    myArr[i] = new Random().Next(0,1000);
}
Console.WriteLine("Старый массив: "+ String.Join(", ",myArr));

for (int i=0;i< myArr.Length;i++)
{int sum=0;
while(myArr[i]!=0)
{ sum= sum + myArr[i]%10;
    myArr[i] = myArr[i]/10;}
  myArr[i]=sum;
}
Console.WriteLine("Новый массив: "+ String.Join(", ",myArr));}
arrSumNum();
