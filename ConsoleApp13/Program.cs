Console.WriteLine("Digite o valor atual do salário:");
double salarioatual = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do salário com acréscimo:");
double salarioacrescimo = double.Parse(Console.ReadLine());

double aumento = salarioacrescimo - salarioatual;

double porcentagemaumento = (aumento / salarioatual) * 100;

Consol