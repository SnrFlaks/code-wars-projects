using System.Drawing;

int r = Convert.ToInt32(Console.ReadLine());
int g = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
r = r > 255 ? 255 : r < 0 ? 0 : r;
g = g > 255 ? 255 : g < 0 ? 0 : g;
b = b > 255 ? 255 : b < 0 ? 0 : b;
Color myColor = Color.FromArgb(r, g, b);
Console.WriteLine(myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2"));