using System;
using System.Collections;
using System.Diagnostics;

class Program
{
     static List<string> anotacoes = new List<string>();

    static void Perguntar()
    {
        do
        {
            // Seu código para realizar contas aqui

            Console.WriteLine("Deseja continuar realizando contas? (S/N): ");
            string continuar = Console.ReadLine();
            if (continuar.ToUpper() == "S")
            {
                Console.WriteLine("Qual dessas operações você quer?");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                int escolha = Convert.ToInt32(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Adição");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Digite um numero:");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite outro numero:");
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        int resultado = n1 + n2;
                        Console.WriteLine(" O resultado é: " + resultado);

                        break;
                    case 2:
                        Console.WriteLine("Subtração");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Digite um numero:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite outro numero:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        resultado = n1 - n2;
                        Console.WriteLine(" O resultado é: " + resultado);

                        break;
                    case 3:
                        Console.WriteLine("Multiplicação");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Digite um numero:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite outro numero:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        resultado = n1 * n2;
                        Console.WriteLine(" O resultado é: " + resultado);

                        break;
                    case 4:
                        Console.WriteLine("DIvisão");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Digite um numero:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite outro numero:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        resultado = n1 / n2;
                        Console.WriteLine(" O resultado é: " + resultado);
                        break;
                }
            }

            if (continuar.ToUpper() == "N")
            {
                Console.WriteLine("Encerrando o programa. Até mais!");
                break;
            }

        } while (true);

    }

    static void Main(string[] args)
    {
        Console.WriteLine("Qual dessas opções você quer?");
        Console.WriteLine("1 - Calculadora");
        Console.WriteLine("2 - Anotações");
        Console.WriteLine("3 - Vou pensar");
        Console.WriteLine("4 - Sair");

        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)


        //Tentar criar um método para voltar ao começo do menu de operação ;-
        //tentar criar outro metodo com o mesmo switch e depois chamar la embaixo, é uma gambiarra mas deve funcionar

        {
            case 1:
                Console.WriteLine("Qual dessas operações você quer?");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");



                int escolhacalc = Convert.ToInt32(Console.ReadLine());
                double n1, n2, resultado = 0;
                switch (escolhacalc)
                {
                    case 1:
                        Console.WriteLine("Adição");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Digite um numero:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite outro numero:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        resultado = n1 + n2;
                        Console.WriteLine(" O resultado é: " + resultado);

                        break;
                    case 2:
                        Console.WriteLine("Subtração");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Digite um numero:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite outro numero:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        resultado = n1 - n2;
                        Console.WriteLine(" O resultado é: " + resultado);

                        break;
                    case 3:
                        Console.WriteLine("Multiplicação");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Digite um numero:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite outro numero:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        resultado = n1 * n2;
                        Console.WriteLine(" O resultado é: " + resultado);

                        break;
                    case 4:
                        Console.WriteLine("DIvisão");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Digite um numero:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite outro numero:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        resultado = n1 / n2;
                        Console.WriteLine(" O resultado é: " + resultado);
                        break;



                }
                Perguntar();
                //calculadora pronta!
                break;
            case 2:
         //anotações
    do{
      
      Console.WriteLine("Digite uma anotação");
         string anotação = Console.ReadLine();
         anotacoes.Add(anotação);
         Console.WriteLine("Adicionado com sucesso");
             Console.WriteLine("Anotações:");
        foreach (var anotacao in anotacoes)
        {
            Console.WriteLine(anotacao);
        }
         Console.WriteLine("Deseja continuar realizando contas? (S/N): ");
            string continuar = Console.ReadLine();
            if(continuar.ToUpper() == "N"){
                Console.WriteLine("Saindo até mais!!");
                break;
            }
    }while(true);
 //anotações pronta!         
                break;

            case 3:
            Console.WriteLine("");
             Random rnd = new Random();
           //jogo da mega sena usar estrutura do do while para manter o codigo  funcionando e usar if para exibir a mensagem de vitoria!!
                 

           
                break;

            case 4:
                Console.WriteLine("Saindo! Até mais!");
                break;
        }
    }
}


