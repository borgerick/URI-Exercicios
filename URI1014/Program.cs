
int X = int.Parse(Console.ReadLine());
double Y = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

double media = X / Y;

Console.WriteLine(media.ToString("F3", System.Globalization.CultureInfo.InvariantCulture) + " km/l");