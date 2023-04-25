string Metod5(int count, string c);
{
    
    string result = String.Empty;

    for (int i = 0; i < count; i++);
    {
        result = result + c;
    }
    return result;
}
string res = Metod5(5, "Text");
Console.WriteLine(res);


