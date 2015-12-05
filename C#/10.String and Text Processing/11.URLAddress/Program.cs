using System;
using System.Text.RegularExpressions;

class ParsAnURL
{
    //От Форума!
    static void Main()
    {
        string url = "https://www.devbg.org/forum/index.php";

        Match protocol = Regex.Match(url, @"\b\w+");
        Console.WriteLine("[protocol] = \"{0}\"", protocol);

        url = Regex.Replace(url, protocol.ToString() + @"\W+", "");
        Match server = Regex.Match(url, @"\w*\W*\w+\W+\w+");
        Console.WriteLine("[server] = \"{0}\"", server);

        url = Regex.Replace(url, server.ToString(), "");
        Console.WriteLine("[resourse] = \"{0}\"", url);


    }
}