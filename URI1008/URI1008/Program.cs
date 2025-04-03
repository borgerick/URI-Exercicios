
using static System.Runtime.InteropServices.JavaScript.JSType;

int NumFuncionarios = int.Parse(Console.ReadLine());
int NumHoras = int.Parse(Console.ReadLine());
double Hora = double.Parse(Console.ReadLine());

double Salario = NumHoras * Hora;

Console.WriteLine("NUMBER = " + NumFuncionarios);
Console.WriteLine("SALARY = U$ " + Salario.ToString("F2", System.Globalization.CultureInfo.InvariantCulture));