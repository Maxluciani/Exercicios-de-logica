using System;

namespace Primeiralista
{

    class Prova
    {

    //Prova25/08
         static void Main(string[] args)
        {
            Prova_06();
        }
        static void Prova_01()
        {
            //Solicite ao usuário que informe quantas horas e minutos 
            //ele trabalha por dia e qual o valor/hora de seu serviço.
           //Imprima quanto dinheiro ele ganha ao 
           //longo de um dia trabalhado. A mensagem impressa ao usuário 
           //deve ter, no máximo, duas casas após a vírgula.
           var horastrabalhadas = 0;
           var minutos = 0.0;
           System.Console.WriteLine("Quantas horas você trabalha por dia?");
           horastrabalhadas = Int32.Parse(Console.ReadLine());
           System.Console.WriteLine("Quantos minutos você trabalha por dia?");
           minutos = double.Parse(Console.ReadLine());
           var totaltempo = horastrabalhadas + (minutos /60);
           System.Console.WriteLine("Quanto você ganha por hora?");
           var valorPHora = double.Parse(Console.ReadLine());
           var valorPDia = (valorPHora * totaltempo).ToString("0.00");
           System.Console.WriteLine($"Você ganha R${valorPDia} por dia trabalhado");

        }
        static void Prova_02()
        {
            //Solicite ao usuário que informe uma palavra qualquer, 
            //porém ele deve digitar uma letra por vez.
            //Quando o usuário informar a palavra “Finalizar”, a aplicação 
            //deve apresentar a palavra inteira.
            var palavra = "";
            var letra = "";
            while (true)
            {

            System.Console.WriteLine("Digite uma letra");
            letra = Console.ReadLine();
            if (letra == "Finalizar")
            {
                break;
            }
                palavra += letra;
            }
            System.Console.WriteLine($"A palavra formada é {palavra}");
            
        }
         static void Prova_03()
         {
            //Solicite para 5 usuários que informem seus nomes e se são solteiros.
           //Ao final apresente o nome de todos os usuários solteiros  
           var solteiro = "" ;
           var nome = "";
           var solteiros ="";
           for (int i = 0; i < 5; i++)
           {
              System.Console.WriteLine("Qual o seu nome?"); 
              nome = Console.ReadLine();
              System.Console.WriteLine("Você é solteiro?");
              solteiro = Console.ReadLine();
              if (solteiro == "sim")
              {
                  solteiros += nome;
              }
           }
           System.Console.WriteLine($"Os Solteiros são {solteiros}");
         }
         static void Prova_04()
         {
             //Solicite ao usuário seu ano de nascimento e imprima 
             //se ele é ou não maior de idade.
             //Caso o usuário digite um valor inválido, a aplicação
             //deve pedir que ele digite novamente.
             var ano = 0;
             System.Console.WriteLine("Em que ano você nasceu?");
             while (true)
             {
                 
             try
             {
             ano = Int32.Parse(Console.ReadLine());
                 break;
             }
             catch (System.Exception)
             {
                 
               System.Console.WriteLine(("Comando invalido,digite um numero real"));
             }
             
             }
             if (ano > 2002)
             {
                 System.Console.WriteLine("Você é menor de idade");
             }
             else 
             {
                 System.Console.WriteLine("Você é maior de idade");
             }
         }
         static void Prova_05()
         {
            //  Solicite ao usuário que informe 5 números e armazene em um array.
            //  Toda vez que o usuário digitar um valor inválido, 
            //  a aplicação deverá armazenas “null” no índice correspondente.
            //  Ao final, imprimir apenas os números válidos.
            var a = new double?[5];
            for (int i = 0; i < a.Length; i++)
            {
               System.Console.WriteLine($"Digite o {i+1}º numero ");
               try
               {
                   a[i] = double.Parse(Console.ReadLine());
               }
               catch (System.Exception)
               {} 
            }
               System.Console.WriteLine("Lista de numeros do array");
               foreach (var number in a)
               {
                   if (number != null)
                   {
                   System.Console.WriteLine(number);
                       
                   }
               }
               
         }
         static void Prova_06()
         {
            //  Calcule e apresente a média salarial dos 
            //  funcionários de uma empresa qualquer.
            //  A aplicação será encerrada quando o usuário 
            //  digitar a palavra "calcular".
            //  Caso o usuário digite um valor negativo então a 
            //  aplicação deve pedir seu salário novamente
            
            var valortotal = 0.0;
            var funcionarios = 0;
            while (true)
            {
                System.Console.WriteLine("Qual o seu salario");
                var input = Console.ReadLine();
                if (input == "calcular")
                {
                  break;
                }
                var salarios = Double.Parse(input);
                if (salarios < 0)
                {
                  continue;
                }
                funcionarios ++;
                valortotal += Double.Parse(input);

            }
            var media = (valortotal / funcionarios);
            System.Console.WriteLine($"A média salarial é R${media}");
         }
    }
}