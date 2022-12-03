Console.Clear();
string[] array = { "GeekBrains", "hello", "12.2022", "555" };
Console.WriteLine(String.Join(' ', array));
Console.WriteLine();
string[] final = NewString(array);
Console.WriteLine(String.Join(' ', final));

string[] NewString(string[] massiv)
{
    string[] result;
    string temp = String.Empty;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i].Length < 4) temp = temp + massiv[i] + " ";
    }
    result = temp.Split(' ');
    return result;  
}