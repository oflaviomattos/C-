using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using c_.Models;

int [] arrayInteiros =  new int[3];

arrayInteiros[0] =72;
arrayInteiros[1] =64;
arrayInteiros[2] =50;
arrayInteiros[3] =1;

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição no {contador} - {arrayInteiros[contador]}");
}







// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a opção: ");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Apagar Cliente");
//     Console.WriteLine("4 - Sair");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//         Console.WriteLine("Cadastro de Cliente");
//         break;

//         case "2":
//         Console.WriteLine("Buscar Cliente");
//         break;

//         case "3":
//         Console.WriteLine("Apagar cliente");
//         break;

//         case "4":
//         Console.WriteLine("Sair");
//         //Sair do programa e não executa mais nada
//         //Environment.Exit(0);
//         //Sair apenas do menu
//         exibirMenu = false; 
//         break;

//         default:
//         Console.WriteLine("Opcao Inválida.");
//         break;
//     }
// }

// Console.WriteLine("Programa Encerrado!");



// int soma = 0, numero = 0;

// do 
// {
//     Console.WriteLine("Digite um numero( 0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");








// int numero = 5;
// int contador = 0;

// while (contador <=10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador ==6)
//     {
//         break;
//     }
// }


// int numero = 5;
// //Estuturas de Repeticoes for
// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }










//Calculadora calc = new Calculadora();

// calc.Somar(10,30);
// calc.Subtrair(10,50);
// calc.Multiplicar(15,45);
// calc.Dividir(2,2);
//calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

//calc.RaizQuadrada(9);

// bool possuiPresencaMinima = false;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado.");
// }
// else 
// {
//     Console.WriteLine("Reprovado.");
// }






// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada Liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não Liberada");
// }








// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// //switch - Quando tem ifs aninhando é mais adequado usar.
// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("vogal");
//         break;

//     default:
//         Console.WriteLine("Não é vogal");
//         break;
// }



// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }else{
//     Console.WriteLine("Não é Vogal.");
// }



//usand o IF
// if (letra == "a")
// {
//     Console.WriteLine("Vogal!");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal!");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal!");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal!");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal!");
// }
// else 
// {
//     Console.WriteLine("Não é uma vogal!");
// }




// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 11;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade de Compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

// if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada");
// }
// else 
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }




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
