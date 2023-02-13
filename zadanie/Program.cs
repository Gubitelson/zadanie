Console.Clear();
Console.WriteLine("ВВедите строки и символы через пробел и запятую");
string[] StringArray;
StringArray = Console.ReadLine().Split(new char[] { ',', ' ' });

Console.WriteLine();
Console.Write("Строки и числа которые в первом 3 и меньше символов: " );
for (int ij = 0; ij < StringArray.Length; ij++)
{
if (StringArray[ij].Length <= 3)
    {
        string l ; 
        l = StringArray[ij];
       Console.Write( l + ", " );

    }

}
Console.WriteLine();
 string[] StringArray2; 

StringArray2 = Console.ReadLine().Split(new char[] { ',', ' ' });

Console.Write("Строки и числа во 2 массиве которые 3 и меньше символов: " );

for (int ik = 0; ik < StringArray2.Length; ik++)
{
if (StringArray2[ik].Length <= 3)
    {
     string k ; 
        k = StringArray2[ik];
       Console.Write( k + ", " );

    }

}

Console.WriteLine();
Console.Write("Строки и числа в 3 массиве которые 3 и меньше символов: " );
string[] StringArray3 = {"sadaf", "2141", "saf", "sa111df", "sadaf", "+-+", "421", "2=+"};
for (int ij = 0; ij < StringArray3.Length; ij++)
{
if (StringArray3[ij].Length <= 3)
    {
        string l ; 
        l = StringArray3[ij];
       Console.Write( l + ", " );

    }

}