using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку с IP-адресом: ");
        string input = Console.ReadLine();
        input = input.Replace(" ", "");

        string patternIPv4 = @"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";

        string patternIPv6 = @"^(([0-9A-Fa-f]{1,4}:){7}[0-9A-Fa-f]{1,4}|([0-9A-Fa-f]{1,4}:){1,7}:|([0-9A-Fa-f]{1,4}:){1,6}:[0-9A-Fa-f]{1,4}|([0-9A-Fa-f]{1,4}:){1,5}(:[0-9A-Fa-f]{1,4}){1,2}|([0-9A-Fa-f]{1,4}:){1,4}(:[0-9A-Fa-f]{1,4}){1,3}|([0-9A-Fa-f]{1,4}:){1,3}(:[0-9A-Fa-f]{1,4}){1,4}|([0-9A-Fa-f]{1,4}:){1,2}(:[0-9A-Fa-f]{1,4}){1,5}|[0-9A-Fa-f]{1,4}:((:[0-9A-Fa-f]{1,4}){1,6}|:)|:((:[0-9A-Fa-f]{1,4}){1,7})|(::))$";

        Match matchIPv4 = Regex.Match(input, patternIPv4);

        Match matchIPv6 = Regex.Match(input, patternIPv6);

        if (matchIPv4.Success)
        {
            Console.WriteLine("Найден IPv4-адрес: " + matchIPv4.Value);
        }
        else if (matchIPv6.Success)
        {
            Console.WriteLine("Найден IPv6-адрес: " + matchIPv6.Value);
        }
        else
        {
            Console.WriteLine("IP-адрес не найден.");
        }

        Console.ReadLine();
    }
}
