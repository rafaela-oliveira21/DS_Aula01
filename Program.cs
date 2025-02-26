using System;

namespace Aula01Variaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalcularMedia();
            VerificarAulaEtec();
            ConcatenarPalavras();
            DetalharData();
            CalcularDescontoINSS();
        }

        
              public static void CalcularMedia()
        {
            Console.WriteLine("");
            Console.WriteLine("Digite a primeira nota");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Digite a segunda nota");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) /2;
            Console.WriteLine($"A média é {media}");
            Console.WriteLine("");

            if(media >=7)
                Console.WriteLine("Aprovado");
            else if(media < 7 && media >= 4)
                Console.WriteLine("Recuperação");
            else
                Console.WriteLine("Reprovado");

        }
    


            public static void VerificarAulaEtec()
        {
            Console.WriteLine("");
            Console.WriteLine("Digite a data ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if(data.DayOfWeek == DayOfWeek.Saturday  || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje não tem aula! Revisarei exerecícios.");
            }

            else
            {
                Console.WriteLine("Dia de semana! Bora pra Etec!");
            }

            Console.WriteLine("");
                    
        }



        public static void ConcatenarPalavras()
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();

            string frase1 = $"Olá {nome}, hoje é {DateTime.Now}";
            Console.WriteLine("Frase1 ");
            Console.WriteLine("");


            Console.WriteLine("Quanto custa um dólar em reais? ");
            decimal valorDolarReais = decimal.Parse(Console.ReadLine());
            string frase2 = string.Format ("Hoje é {0:dddd}, o dólar está custando {1:c2}", DateTime.Now, valorDolarReais);
            Console.WriteLine("");
            string cabecalho = string.Format ("{0:dddd}, {0:dd} de {0:MMMM} de {0:yyyy} - {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine("");
            Console.WriteLine(cabecalho.ToUpper());
            Console.WriteLine("");
        }



        // Exercício no Teams 
        /*Criar um método chamado DetalharData que apresente a mensagem para o usuário digitar uma data e 
        armazene em uma variável compatível. Você deverá usar formatação para imprimir na tela qual o dia da 
        Semana (Segunda, Terça...etc) e qual o nome do mês por extenso (Janeiro, Fevereiro etc). Comparar o 
        dia da semana da data, se ela for um domingo, imprimir na tela a hora atual com os minutos (Ex: 14:35)*/

        public static void DetalharData()
        {
            Console.WriteLine("");
            Console.WriteLine("Digite a data");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                string frase = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yyyy} - {0:HH:mm:ss}", data);
                Console.WriteLine(frase);
            }
            else
            {
                 string frase = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yyyy}", data);
                Console.WriteLine(frase);
            }

        }



        /*Criar um método chamado CalcularDescontoINSS que apresente a mensagem que solicite para o usuário digitar o valor do salário e armazene em uma variável compatível. 
        Você deverá observar a tabela em anexo e apresentar ao usuário o valor de INSS que ele terá que pagar e qual o valor do salário descontado o INSS.  
        Você pode declarar a quantidade de variáveis que quiser para fazer os cálculos. */

        public static void CalcularDescontoINSS()
        {
            Console.WriteLine("");
            Console.WriteLine("Digite o valor salarial: ");
            double salario = double.Parse(Console.ReadLine());
            double desconto = 0 ;
            double salarioDescontado = 0;

            if(salario <= 1212)
            {
                desconto = salario * 0.075;
                salarioDescontado = salario - desconto;
            }
            else if(salario >= 1212.01 && salario <=2427.35)
            {
                desconto = salario * 0.09;
                salarioDescontado = salario - desconto;
            }
            else if(salario >= 2427.35 && salario <=3641.03)
            {
                desconto = salario * 0.12;
                salarioDescontado = salario - desconto;
            }
            else
            {
                desconto = salario * 0.14;
                salarioDescontado = salario - desconto;
            }

                Console.WriteLine("");
                string frase = string.Format("O valor do desconto é {0:c2}. O salário descontando o INSS é {1:c2}", desconto, salarioDescontado);
                Console.WriteLine(frase);
                Console.WriteLine("");

            }









    }
}
