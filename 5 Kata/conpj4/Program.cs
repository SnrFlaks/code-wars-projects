int i = -1;
string str = Console.ReadLine();
string[] subs = str.Split(' '), strf = new string[subs.Length];
foreach (var sub in subs)
{
    i++;
    strf[i] = sub.Substring(1);
    if (i == subs.Length && sub != "!" && sub != "?") strf[i] = String.Concat(strf[i], sub.Substring(0, 1), "ay");
    else if (i <= subs.Length && sub != "!" && sub != "?") strf[i] = String.Concat(strf[i], sub.Substring(0, 1), "ay ");
    else strf[i] = String.Concat(strf[i], sub.Substring(0, 1));
}
Console.WriteLine(String.Concat(strf));