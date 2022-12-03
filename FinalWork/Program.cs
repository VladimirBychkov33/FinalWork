Console.Clear();
string[] array = { "GeekBrains", "hello", "12.2022", "555" };
Console.WriteLine(String.Join(' ', array)); 
Console.WriteLine();
string temp = String.Empty;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4) temp = temp + array[i] + " ";          
}
string[] result = temp.Split(' ');
Console.WriteLine(String.Join(' ', result));