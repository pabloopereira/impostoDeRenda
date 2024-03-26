
using impostoDeRenda;

Console.Write("Digite sua renda mensal:");
        float salario = float.Parse(Console.ReadLine());

var impostoDeRenda = new impostoLeao();

Console.WriteLine($"O salário após o desconto é: {impostoDeRenda.CalculoImposto(salario)}");