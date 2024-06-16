string GetLettersFromString(string s)
{
    string letters = "";
    foreach(char e in s)
    {
        if(char.IsAsciiLetter(e) == true) // буква ли это?
        {
            letters = letters + e;
        }
    }
    return letters;
}


string str = Console.ReadLine();
string result = GetLettersFromString(str);
System.Console.WriteLine(result);
