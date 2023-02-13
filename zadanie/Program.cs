Console.Clear();
string[] StringArray;
StringArray = Console.ReadLine().Split(new char[] { ',', ' ' });
for (int i = 0; i < StringArray.Length; i++)
{
if (StringArray[i].Length <= 3)
    {
        string m = StringArray[i];
        Console.Write(m + ", " );

    }
}
