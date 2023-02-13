Console.Clear();
string[] StringArray;
StringArray = Console.ReadLine().Split(new char[] { ',', ' ' });
string m = "слова и цифры в массиве которые в тексте 3 и меньше символа"; 
for (int i = 0; i < StringArray.Length; i++)
{
if (StringArray[i].Length <= 3)
    {
        m = StringArray[i];
       Console.Write( m + "," );

    }
    
}
 