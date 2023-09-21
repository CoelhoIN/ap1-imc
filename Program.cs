string? continuar;

do
{
    Console.WriteLine("Informe seu nome: ");
    string? nome = Console.ReadLine();
    Console.WriteLine("Informe sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe sua altura: ");
    double altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Informe seu peso: ");
    double peso = Convert.ToDouble(Console.ReadLine());

    //cálculo do imc

    double imc = peso / (altura * altura);

    //definir o imc da pessoa

    string imc_valor;
    if (imc <= 18.4)
    {
        imc_valor = "Abaixo do peso.";
    }
    else if (imc >= 18.5 && imc <= 24.9)
    {
        imc_valor = "Peso normal.";
    }
    else if (imc >= 25 && imc <= 29.9)
    {
        imc_valor = "Acima do peso.";
    }
    else
    {
        imc_valor = "Obeso.";
    }

    //definir a faixa etária da pessoa

    string faixa_etaria;
    if (idade <= 12)
    {
        faixa_etaria = "Criança.";
    }
    else if (idade >= 13 && idade <= 18)
    {
        faixa_etaria = "Adolescente.";
    }
    else if (idade >= 19 && idade <= 59)
    {
        faixa_etaria = "Adulto.";
    }
    else
    {
        faixa_etaria = "Idoso.";
    }
 
    //gerar o relatório

    Console.WriteLine("\nRELATÓRIO IMC E IDADE");
    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Idade: {idade}");
    Console.WriteLine($"IMC: {imc} - {imc_valor}");
    Console.WriteLine($"Faixa etária: {faixa_etaria}");

    //perguntar pra continuar

    Console.WriteLine("\nDeseja gerar um novo relatório? (s/n): ");
    continuar = Console.ReadLine().ToLower();

}while(continuar == "s");

Console.WriteLine("Obrigado por utilizar nosso sistema!");