int i = -1;
string end = "";
string input = Console.ReadLine();
string[] subs = input.Split(' ');
string[] subsf = new string[subs.Length];
foreach (var sub in subs)
{
    i++;
    if (sub.Length > 4)
    {
        char x = Convert.ToChar(sub.Substring(0, 1));
        int ser = (int)x;
        char x2 = Convert.ToChar(sub.Substring(sub.Length - 1));
        string ello = sub.Substring(1, sub.Length - 1);
        char x3 = Convert.ToChar(ello.Substring(0, 1));
        string sje1 = ello.Substring(0, ello.Length - 1);
        string sje2 = sje1.Substring(1);
        if (i + 1 == subs.Length) subsf[i] = String.Concat(ser, x2, sje2, x3, "");
        else subsf[i] = String.Concat(ser, x2, sje2, x3, " ");
    }
    else if (sub.Length <= 4 && sub.Length > 0)
    {
        char x = Convert.ToChar(sub.Substring(0, 1));
        int ser = (int)x;
        string sje = sub.Substring(1);
        char[] arr = sje.ToCharArray();
        Array.Reverse(arr);
        if (i + 1 == subs.Length) subsf[i] = String.Concat(ser, String.Concat(arr), "");
        else subsf[i] = String.Concat(ser, String.Concat(arr), " ");
    }
    else
    {
        Console.Write("");
    }
}
Console.Write(end = String.Concat(subsf));