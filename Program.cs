using System;

namespace Primeiralista
{
    class Exercicios
    {
  

   
         static void Exercicio01()
        {
			//Crie um programa que imprima:
           //Os números de 1 a 10 de forma crescente
           //Os números de 1 a 10 de forma descrecente
           //Os números de 1 a 10 de forma crescente, mas apenas aqueles
           //que forem par.
            var increment = 1;

			System.Console.WriteLine("numeros em ordem crescente");
			while (increment < 11)
			{
				System.Console.WriteLine(increment);
				increment++;
			}
             var decrement = 10;

			System.Console.WriteLine("numeros em ordem decrescente");
			while (decrement > 0)
			{
				System.Console.WriteLine(decrement);
				decrement--;
			}
              var counter = 2;
			System.Console.WriteLine("apenas os numeros  pares");
			while (counter < 11)
			{
				if (counter % 2 == 0)
				{
					System.Console.WriteLine(counter);
				}
				counter++;
			}
		}	
         static void Exercicio02()
        
        {
           //Imprimir a soma dos números inteiros de 1 a 100.

            var counter = 1;
			var sum = 0;

			while (counter < 101)
			{
				sum += counter;
				counter++;
			}

         System.Console.WriteLine("a soma dos números inteiros entre 1 e 100 é");
			System.Console.WriteLine(sum);
        }
    	 static void Exercicio03()
 {
         //)Imprimir todo os números ímpares menores de 200.

           Console.WriteLine("todos os numeros impares");
           var counter = 1;

			while (counter < 200)
			{
				if (counter % 2 == 1)
				{
					System.Console.WriteLine(counter);
				}
				counter++;
        } }
         static void Exercicio04()
            {
                //Calcular a média de idade de uma turma qualquer. O algoritmo deve parar 
                //quando for digitada a idade igual a zero.

			var sum = 0.0;
			var counter = 0.0;

			while (true)
			{
				System.Console.WriteLine("Digite uma idade");
				var result = Console.ReadLine();

				if (result == "0")
				{
					break;
				}
				
				counter++;
				
				sum += Double.Parse(result);
			}

			System.Console.WriteLine("A média da turma é:");
			System.Console.WriteLine((sum / counter).ToString("0.00"));
		}
         static void Exercicio05()


        {

         //Criar um algoritmo que peça o nome e a idade de 5 mulheres. Após 
         //informar estes dados, o programa deve mostrar apenas porcentagem de
         // mulheres que estão com idade entre 18 e 35
        
         
            var mulheres = 0;

			var counter = 0;
			while (counter < 5)
			{
				System.Console.WriteLine("Digite o nome de uma mulher");
				Console.ReadLine();
				System.Console.WriteLine("Digite sua idade");
				var age = Int32.Parse(Console.ReadLine());

				if (age > 17 && age < 36)
				{
					mulheres++;
				}
				counter++;
			}

			System.Console.WriteLine($"A porcentagem de mulheres entre 18 à 35 anos é de {mulheres * 100 / 5}%");
			
         
        }
         static void Exercicio06()
       {
		   //Criar um algoritmo que simule uma urna eletrônica. Esta urna deve possuir 
		   //dois candidatos e possui três modos. O primeiro é o modo de CADASTRO, onde 
		   //o sistema pergunta o nome de cada um dos dois candidatos. Por medidas de 
		   //segurança, para poder cadastrar um candidato na urna o sistema deve solicitar
		   // ao usuário a senha para poder ter acesso (a senha do sistema é Pa$$w0rd). O 
		   //segundo modo é o modo de votos, onde o usuário informa 1 para votar no primeiro 
		   //candidato e 2 para votar no segundo candidato. O terceiro modo, é o modo de 
		   //apuração de votos, onde o sistema verifica qual candidato tem mais votos. Caso 
		   //o número de votos seja igual, o sistema deve imprimir a mensagem "SEGUNDO TURNO", 
		   //caso contrário deve imprimir o nome do candidato vencedor e o número de votos que ele obteve.

            var candidates = new (string name, int votes)[2];

			while (true)
			{
				System.Console.WriteLine("Selecione um dos modos a seguir:");
				System.Console.WriteLine("1 - Cadastro dos candidatos");
        		System.Console.WriteLine("2 - Vote em um candidato");
        		System.Console.WriteLine("3 - Apuração dos votos");
				var mode = Console.ReadLine();

				if (mode == "1")
				{
					var password = "";

					while (password != "Pa$$w0rd")
					{
						System.Console.WriteLine("Digite a senha");
						password = Console.ReadLine();
					}

					System.Console.WriteLine("Digite o nome do primeiro candidato");
					candidates[0].name = Console.ReadLine();

					System.Console.WriteLine("Digite o nome do segundo candidato");
					candidates[1].name = Console.ReadLine();
				}

				if (mode == "2")
				{
					System.Console.WriteLine($"Insira 1 para votar no candidato {candidates[0].name}, ou 2 para votar no candidato {candidates[1].name}");
					var result = Int32.Parse(Console.ReadLine());
					candidates[result - 1].votes++;
				}

        		if (mode == "3")
				{
					if (candidates[0].votes == candidates[1].votes)
					{
						System.Console.WriteLine("Segundo turno!");
					}
					else
					{
						var winner = (candidates[0].votes > candidates[1].votes) ? candidates[0] : candidates[1];
						System.Console.WriteLine($"O vencedor é: {winner.name}");
						System.Console.WriteLine($"Com o total de: {winner.votes} votos!");
					}
					break;
				}
			}
		}
         static void Exercicio07()
 {

	     //Calcular a quantidade de dinheiro gasta por um fumante. 
	     //Dados: o numero de anos que ele fuma, o nº de cigarros fumados por 
         //dia e o preço de uma carteira.

          Console.WriteLine("Digite o preço do maço de cigarro");
          var preçomaço = Double.Parse(Console.ReadLine());
           var cigarro = (preçomaço / 20);
           Console.WriteLine($"Cada cigarro custaR${cigarro}.");
            Console.WriteLine("Quantos cigarros você fuma por dia?");
            var cigarrodia = Double.Parse (Console.ReadLine());
            var granadia = 0.0;
            granadia = (cigarrodia * cigarro);
            var granaano = 0.0;
            granaano = (granadia * 365);
            Console.WriteLine("quantos anos você fuma?");
            var anos = Double.Parse (Console.ReadLine());
            var resultado = 0.0;
            resultado = (granaano * anos);
            Console.WriteLine($"O total gasto de dinheiro em {anos} de fumante é de R${resultado}");
            
        }  
         static void Exercicio08()
  {
	     //Ler dois números inteiros, X e Y, e apresentar mensagem 
         //informando se o X é múltiplo de Y.

              var numero1 = 0;
              var numero2 = 0;
              bool multiplo = true;

              Console.WriteLine("Digite um numero");
              numero1 = int.Parse(Console.ReadLine());
              Console.WriteLine("Digite outro numero");
              numero2 = int.Parse(Console.ReadLine());

              multiplo = numero1 % numero2 == 0;

              if (multiplo)
              {
Console.WriteLine($"{numero1} é multiplo de {numero2}");
              }
else
{
Console.WriteLine($"{numero1} não é multiplo de {numero2}");
}          
           }
         static void Exercicio09()
    {
		 //Fazer um algoritmo para ler 03 números reais do teclado e verificar se o  
		 //primeiro é maior que a soma dos outros dois.

            Double numero1 = 0;
            Double numero2 = 0;
           Double numero3 = 0;

            Console.WriteLine("Digite um numero");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero");
            numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero");
            numero3 = double.Parse(Console.ReadLine());

            if (numero1 > numero2 + numero3)
            {
                Console.WriteLine($"{numero1} é maior que {numero2}+{numero3}");
            }
            else if (numero1 == numero2 + numero3)
            {
                Console.WriteLine($"{numero1} é igual a {numero2}+{numero3}");
            }
            else
            {
                Console.WriteLine($"{numero1} é menor que {numero2}+{numero3}");
            }
        }
		 static void Exercicio10()
	    {
			//Ler 02 números reais do teclado (A e B),
			//verificar e imprimir qual deles é maior, ou a mensagem "A = B" caso sejam iguais
         var numero1 = 0;
         var numero2 = 0;
        
            Console.WriteLine("Digite um numero");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero");
            numero2 = Int32.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                 Console.WriteLine($"O numero {numero1} é maior que o numero {numero2}");
            
            
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine($"o numero {numero2} é maior que o numero {numero1}" );


            }

            else 
            {
                 Console.WriteLine($"Os numeros {numero1} e {numero2} são iguais");

            }
        
        }
         static void Exercicio11()
        {
			//Ler 02 números inteiros do teclado. Se o segundo for diferente de zero,
			// calcular e imprimir o quociente do primeiro pelo segundo. Caso contrário, 
            //imprimir a mensagem: "DIVISÃO POR ZERO".

         var numero1 = 0;
         var numero2 = 0;
        
            Console.WriteLine("Digite um numero");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero");
            numero2 = Int32.Parse(Console.ReadLine());
            
            if (numero2 != 0)
          {          
            Console.WriteLine($"{(numero1 / numero2)}");
            Console.WriteLine($"{numero1} dividido por {numero2} é igual à {(numero1 / numero2)} ");
          }
           else 
         {
         Console.WriteLine("Divisão por zero");
         }
        }
         static void Exercicio12()  
        {
            //Ler 4 números inteiros e imprimir a soma dos que forem par.
            var soma = 0;
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite um numero");
                var resultado = Int32.Parse(Console.ReadLine());
            
                if(resultado % 2 == 0)
                {
                    soma += resultado;
                }
            }

            Console.WriteLine($"A soma dos numeros pares é {soma}");
        }
         static void Exercicio13()
   
        {
            //Ler 10 valores e determinar o maior dentre eles.
           var maiorNum = double.MinValue;
           var numAtual = 0.0;
   

              
          for (int i = 0; i < 10; i++)
           {
             Console.WriteLine("Digite um numero");
              numAtual = Double.Parse(Console.ReadLine());

             if (numAtual > maiorNum)
             {
                maiorNum = numAtual;
             }
            }
               Console.WriteLine($"O maior numero é {maiorNum}");


        }
         static void Exercicio14()      
        {
            //Ler três valores e colocá-los em ordem.
          var menor = Double.MinValue;
          var meio = Double.MinValue;
          var maior = Double.MinValue;
           for (int i = 0; i < 3; i++)
           {
            Console.WriteLine("Digite um numero");
               var numero = Double.Parse(Console.ReadLine());
           if ( numero > maior)
           {
               menor = meio;
               meio = maior;
               maior = numero;
           }
           else if (numero > meio)
           {
               menor = meio;
               meio = numero;
           }
           else 
           {
               menor = numero;
           }
           }
           Console.WriteLine($"O maior numero é {maior}");
           Console.WriteLine($"O numero mediano é {meio}");
           Console.WriteLine($"O menor numero é {menor}");
        }
   static void Exercicio15()
{
            //Ler 10 números e imprimir quantos são múltiplos de 3 e quantos são múltiplos de 5.
        
         var numero = 0;
         var Mult3 = 0;
         var Mult5 = 0;
         for (int i = 0; i < 10; i++)
         {
           Console.WriteLine("Digite um numero.");
           numero = Int32.Parse(Console.ReadLine());  
         if (numero % 3 == 0)
         {
           Mult3 ++;
           
         }
          if (numero % 5 == 0)
          {
              Mult5 ++;
            
              
          }
         } 
          Console.WriteLine($"Os numeros multiplos de 3 são {Mult3}");
          Console.WriteLine($"Os numero multiplos de 5 são {Mult5}");
          
        }
   static void Exercicio16() 
  {
            // Ler o salário de uma pessoa e imprimir o Salário Líquido de acordo com a 
            // redução do imposto descrito ao lado:
            // Menor ou igual a R$ 600,00 - ISENTO
            // Maior que R$ 600,00 e menor ou igual a 100 - 20% desconto
            // Maior que R$ 1.200,00 e menor ou igual a R$2000 - 25% desconto
            // Maior que R$ 2.000,00 - 30% desconto
           var salario = 0.0;
           Console.WriteLine("Qual o valor do seu salario?");
           salario = Double.Parse(Console.ReadLine());
           if (salario <= 600)
           {
               Console.WriteLine("Insento de imposto");
           }
           else if (salario > 600 && salario <= 1200)
           {
               Console.WriteLine($"O valor total com desconto é de R${(salario * 0.8)}");
           }
           else if (salario > 1200 && salario <= 2000)
           {
               Console.WriteLine($"O valor total com desconto é de R${(salario * 0.75)}");
           }
           else if (salario > 2000)
           {
               Console.WriteLine($"O valor total com desconto é de R${(salario * 0.7)}");
           }
        }   
   static void Exercicio17()
        {
            while (true)
            {
             var numero = 0;
              Console.WriteLine("Digite o numero da tabuada");
               numero = Int32.Parse(Console.ReadLine());
               if (numero == -1)
               {
                   Console.WriteLine("Fim da aplicação");
                   break;
               }
             for (int i = 1; i < 11; i++)
             {
                Console.WriteLine($"{numero}x{i}={(numero*i)}"); 
              }
            }  
        } 
    static void Exercicio18()
     {
            // As maçãs custam R$ 1,30 cada se forem compradas menos 
            // de uma dúzia, e R$ 1,00 se forem
            // compradas pelo menos 12. Escreva um programa que leia 
            // o número de maçãs compradas, calcule e
            // escreva o custo total da compra. 
         var maçãs = 0.0;
         Console.WriteLine("Digite o numero de mação que você deseja comprar");
         maçãs = Double.Parse(Console.ReadLine());
         if (maçãs <= 11)
         {
         Console.WriteLine($"O preço total das maças é de R${(maçãs * 1.3)}");
         }
         else if (maçãs >= 12) 
         {
         Console.WriteLine($"O preço total das maçãs é de R${(maçãs * 1)}");
         }

        }
    }
}

    
        
        
    

