
string[] dadosPeca1 = Console.ReadLine().Split(' ');
int CodPeca1 = int.Parse(dadosPeca1[0]);
int NumPeca1 = int.Parse(dadosPeca1[1]);
double ValPeca1 = double.Parse(dadosPeca1[2], System.Globalization.CultureInfo.InvariantCulture);

string[] dadosPeca2 = Console.ReadLine().Split(' ');
int CodPeca2 = int.Parse(dadosPeca2[0]);
int NumPeca2 = int.Parse(dadosPeca2[1]);
double ValPeca2 = double.Parse(dadosPeca2[2], System.Globalization.CultureInfo.InvariantCulture);

double total = (NumPeca1 * ValPeca1) + (NumPeca2 * ValPeca2);

Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", System.Globalization.CultureInfo.InvariantCulture));