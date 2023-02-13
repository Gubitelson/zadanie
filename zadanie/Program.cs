Console.Clear();
Console.WriteLine("ВВедите строки и символы через пробел и запятую");
string[] StringArray;
StringArray = Console.ReadLine().Split(new char[] { ',', ' ' });
string m ; 
Console.WriteLine();
Console.Write("Строки и числа которые 3 и меньше символов: " );
for (int i = 0; i < StringArray.Length; i++)
{
if (StringArray[i].Length <= 3)
    {
        m = StringArray[i];
       Console.Write( m + ", " );

    }
    
}
 