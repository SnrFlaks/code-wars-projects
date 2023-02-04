int seconds = Convert.ToInt32(Console.ReadLine());
string final = "";
int[] hms = { seconds / (60 * 60), seconds / 60 % 60, seconds % 60 };
Console.WriteLine(final = String.Concat(hms[0], ":", hms[1], ":", hms[2]));