// See https://aka.ms/new-console-template for more information
Console.Write("Qual o saldo da aplicação? ");
double saldo = double.Parse(Console.ReadLine());
saldo = saldo + (saldo * (15.0 / 100.0));
Console.WriteLine(("O novo saldo é R$ ") + saldo.ToString("F2"));
