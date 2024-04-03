namespace ATV6_CJ3021912
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exercicio;
            Console.WriteLine("escolha o numero do exercicio de 1 a 7");
            exercicio = int.Parse(Console.ReadLine());
            switch (exercicio)
            {
                case 1:
                    //exercicio 1
                    Console.WriteLine("exercicio 1");
                    int num, valor = 1;
                    Console.WriteLine("insira um numero");
                    num = int.Parse(Console.ReadLine());
                    while(num > 0 && valor <= num)
                    {
                        Console.WriteLine(valor);
                        valor++;
                    }break;


                    case 2:
                    //exercicio 2
                    Console.WriteLine("exercicio 2");
                    int num1, valor1 = 1;
                    Console.WriteLine("insira um numero");
                    num1 = int.Parse(Console.ReadLine());
                    while(num1 > 0 && valor1 <= num1)
                    {
                        if (valor1 % 2 == 0) {
                            Console.WriteLine(valor1);
                        }
                        valor1++;
                        
                    }break;

                case 3:
                    break; 
                


            }
        }
    }
}
