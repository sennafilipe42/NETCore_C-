
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int variavelTeste;
            
            variavelTeste= 123;

            bool variavelBooleana = false;

            if(variavelBooleana == false)
                variavelTeste = 765;

            var TesteInteger = 111;
            var TesteBool = true;
            var TesteString = "Aula";

                int val1, val2, total;
                val1 = 30;
                val2 = 55;
                
                //and = &&
                //or = ||
                //not = !

                bool teste1 = true;
                bool teste2 = false;

                Console.WriteLine(teste1 && teste2);
                Console.WriteLine(teste1 || teste2);


                total = val1 + val2; //aritmética
                total = total + 1;  // incremento
                total++; //Incremento
                total--; //Decremento

                if(val1 == val2){
                    Console.WriteLine("Igual");
                }
                    else {
                        Console.WriteLine("Não é Igual");
                    }

                for(int i=0; i < 10; i++){
                    Console.WriteLine(i.ToString());
                }

                int x = 0;
                while (x<10)
                {
                    x++;
                    Console.WriteLine(x);
                    
                    if ( x % 2 == 0)
                        continue;
                        
                    Console.WriteLine(x);

                    
                    if(x==7)
                        break;

                }
                
                switch (DateTime.Now.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                    case DayOfWeek.Saturday:
                     Console.WriteLine("Final da Semana");
                        break;

                    case DayOfWeek.Monday:
                        Console.WriteLine("Primeiro Dia da Semana de Trabalho");
                            break;

                    case DayOfWeek.Friday:
                        Console.WriteLine("Ultimo Dia da Semana de Trabalho");
                        break;

                    default:
                        Console.WriteLine("Meio da Semana");
                        break;
                }

            Console.WriteLine("O Valor a Variavel é {0}", variavelTeste);
            Console.WriteLine("O Valor a Variavel é {0}", TesteInteger);
            Console.WriteLine("O Valor a Variavel é {0}", TesteBool);
            Console.WriteLine("O Valor a Variavel é {0}", TesteString);
            Console.WriteLine("O Total é: {0}", total);

            Console.ReadLine();

        }
    }
}
