namespace ATV5_CJ3022439
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========MENU DO MARQUESITO========");

            Console.WriteLine("Digite 1 para o exercício 1");

            Console.WriteLine("Digite 2 para o exercício 2");

            Console.WriteLine("Digite 3 para o exercício 3");

            Console.WriteLine("Digite 4 para o exercício 4");

            Console.WriteLine("Digite 5 para o exercício 5");

            Console.WriteLine("Digite 6 para o exercício 6");

            Console.WriteLine("Digite 7 para o exercício 7");

            Console.WriteLine("Digite 0 para sair");

            Console.WriteLine("=====================================");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 0:

                    Console.WriteLine("obrigado por utilizar o programa");
                    break;

                case 1:

                    // Atividade 1

                    int n, i;

                    Console.WriteLine("Digite um número:");
                    i = int.Parse(Console.ReadLine());


                    for (n = 1; n <= i; n++)
                    {




                        Console.WriteLine(n);
                    }


                    break;


                case 2:

                    // Atividade 2

                    int r, j;

                    Console.WriteLine("Digite um número:");
                    j = int.Parse(Console.ReadLine());


                    for (r = 1; r <= j; r++)
                    {
                        if (r % 2 == 0)
                        {
                            Console.WriteLine(r);


                        }
                    }

                    break;

                case 3:

                    //Atividade 3

                    int p, l;

                    Console.WriteLine("Digite um número até 1000:");
                    l = int.Parse(Console.ReadLine());

                    for (p = l; p < 1000; p++)
                    {
                        if (p % 2 == 0)
                        {
                            Console.WriteLine(p);
                        }
                    }

                    break;

                case 4:

                    //Atividade 4

                    int n1, a1;

                    int soma = 200;

                    Console.WriteLine("Digite um número");
                    n1 = int.Parse(Console.ReadLine());

                    for (a1 = 1; a1 < soma; a1++)
                    {
                        if (n1 < 0)
                        {
                            Console.WriteLine("número inválido");
                        }

                        else

                            Console.WriteLine(a1);
                    }

                    break;

                    case 5:

                   // Atividade 5

                    int v, p1;

                    Console.WriteLine("Digite um número:");
                    v = int.Parse(Console.ReadLine());

                    for (p1 = 0; p1 <= v; p1++)
                    {
                        if (v % p1 == 0)
                        {
                            Console.WriteLine(p1);
                        }

                    }
                    break;
                    

                case 6:

                    // Atividade 6

                    int j1, v2;
                    
                    for ( j1 = 0; j1< 11; j1++)
                    {
                        Console.WriteLine("Digite um valor");
                        v2 = int.Parse(Console.ReadLine());

                        if (v2 < v2)
                        {
                            Console.WriteLine("o número maior é = {0}",v2);

                        }


                        if (v2 > v2)
                        {
                          Console.WriteLine("o número menor é = {0}",v2);
                        }


                    }

                    break;

                case 7:

                   // Atividade 7

                    int t, l3;
                    int r1 = 0, p3 = 0;
         
                    for (t = 0; t < 10; t++)
                    {
                        Console.WriteLine("Digite um valor");
                        l3 = int.Parse(Console.ReadLine());

                        if (l3 <= 0)

                            break;

                        if (t % 2 != 0)
                        {
                            r1 = r1 + t;
                        }

                        if (t % 2 == 0)
                        {
                            p3 = p3 + t;
                        }
                        Console.WriteLine("soma dos números ímpares = {0}", r1, p3, "soma dos números pares {1}", p3);
                    }


                    break; 

                   

            }
        }
    }
}
