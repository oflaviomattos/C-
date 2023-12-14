using c_.Models;


int quantidadeEmEstoque = 3;
int quantidadeCompra = 11;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade de Compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

if (possivelVenda)
{
    Console.WriteLine("Venda Realizada");
}
else 
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}




// string a = "15";

// //int b = 0;
// int.TryParse(a, out int b);
// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");

// int a = 10;
// double b = a;
// Console.WriteLine(b);

// int a = 5;
// long b = a;
// Console.WriteLine(b);


// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);



//Cast - Casting
//int a = Convert.ToInt32(null);
// int a = int.Parse("5");

// Console.WriteLine(a);

// //DateTime
// DateTime dataAtual = DateTime.Now;
// DateTime dataFutura = DateTime.Now.AddDays(5);
// Console.WriteLidataAtual);
// Console.WriteLine(dataFutura);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));




// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine (apresentacao);
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variavel preco: " + preco);
// Console.WriteLine("Valor da variavel condicao: " + condicao);



//Pessoa pessoa1 = new Pessoa();
//pessoa1.Nome = "Mattos";
//pessoa1.Idade = 38;
//pessoa1.Apresentar();
