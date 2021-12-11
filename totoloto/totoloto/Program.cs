
using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {


            menu1();
            /*Ler N números, determinar o maior, o menor e a média dos N números lidos.4v*/
           /* int rand, rand2, num = 5, num1 = 1; //declara a variavel tipo inteiro
            

            Random r = new Random();
            //Console.WriteLine("Insira o numero de numeros"); //pedir ao utilizador o valor 
            //num = int.Parse(Console.ReadLine()); //ler e armazenar na variavel num 
            Console.WriteLine("Os numeros são:");
            for (int i = 1; i <= num; i++) //fazer um ciclo for como o num escolhido 
            {
                rand = r.Next(1, 50);
                Console.WriteLine(rand); //print 
            }
            
            Random s = new Random();

            Console.WriteLine("A estrela é :");

            for (int i = 1; i <= num1; i++) //fazer um ciclo for como o num escolhido 
            {
                rand2 = s.Next(1, 14);
                Console.WriteLine(rand2); //print 
            }*/
             
        }

        private static void menu1()
        {
            
            int opcao = 1;
            Console.WriteLine("Escolha uma das seguintes opções :\n 1 - Totoloto \n 2 - Sair"); //imprimir o numero de opçoes possiveis 
            opcao = int.Parse(Console.ReadLine());

            while (opcao != 0 )
            {
                if(opcao == 1)
                {
                    totoloto();
                }
                else  if (opcao ==2 )
                {
                    Environment.Exit(0); //sair dirretamente da consola
                }
                else if  (opcao >=3)
                {
                    Console.WriteLine("Não existe este menu. Tente outro ");//imprimir se houver algum erro
                    Thread.Sleep(2000); //tempo de espera de 2.0s
                    Console.Clear();//apagar no que esta na consola
                    menu1();//ir para o menu 1 
                }
            }


        }

        private static void totoloto()
        {
            int rand2 = 0, num = 4, num1 = 1; //declara a variavel tipo inteiro

            Console.Clear();
           

            var rand = new Random();
            List<int> listNumbers = new List<int>();
            int numbers = rand.Next(1, 50);

            //Console.WriteLine("Insira o numero de numeros"); //pedir ao utilizador o valor 
            //num = int.Parse(Console.ReadLine()); //ler e armazenar na variavel num 
            Console.WriteLine("Os numeros são:");


            for (int i = 0; i <= num; i++) //fazer um ciclo for como o num escolhido 
            {
                numbers = rand.Next(1, 50);
                listNumbers.Add(numbers);         
                //Console.WriteLine(listNumbers);
                
            }
            listNumbers.ForEach(Console.WriteLine);





            Random s = new Random();

            Console.WriteLine("A estrela é :");

            for (int i = 1; i <= num1; i++) //fazer um ciclo for como o num escolhido 
            {
                rand2 = s.Next(1, 14);
                Console.WriteLine(rand2); //print 
            }
            Thread.Sleep(5000); //tempo de espera de 2.0s
            Console.Clear();//apagar no que esta na consola
            menu1();//ir para o menu 1 
        }

    }

}
