void Metod1()
{
    Console.WriteLine("User name");
}

Metod1();

void Metod2(string msg)
{
    Console.WriteLine(msg);   
}

Metod2(msg: "Text messeng");

void Metod_21 (string msg, int count = 10)
{
int i =0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++;
    }
Metod_21(msg:"Text", count: 4);
}

int Metod3()
{
    return DateTime.Now.Year;
}

int yaer = Metod3();
Console.WriteLine(yaer);

string Metod4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result= result + c;
        i ++;
    }
    return result;
}
string res = Metod4(10, "Text");
Console.WriteLine(res);

