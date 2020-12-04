using System;

namespace ExamOne
{
    class Program
    {

        public static void Exercicio1()
        {
            int celsius = 21; // celsius
            int kelvin = celsius + 273;// formula for convert celsius to kelvin
            float fahrenheit = celsius * 18 / 10 + 32; // for convert to fahrenheit

        }

        public static void Exercicio2()
        {
            Console.WriteLine("Escribe primer numero entero");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            if(firstNumber == 0)
                Console.WriteLine("El producto de 0 por cualquier numero es 0");
           else
            {
                Console.WriteLine("Escribe secumdo numero entero");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                int resultado = firstNumber * secondNumber;
                Console.WriteLine("El resultado es {0}", resultado);
            }

        }

        public static void Exercicio3()
        {
            Console.WriteLine("Escribe primer numero entero");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe secundo numero entero");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe tercer numero entero");
            int threeNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber && firstNumber > threeNumber)
                Console.WriteLine(firstNumber );
            else if (secondNumber > firstNumber && secondNumber > threeNumber)
                Console.WriteLine(secondNumber);
            else
                Console.WriteLine(threeNumber);

        }

        public static void Exercicio4()
        {
            Console.WriteLine("Escribe  numero de 1 a 5");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("uno");
                    break;
                case 2:
                    Console.WriteLine("dos");
                    break;
                case 3:
                    Console.WriteLine("tres");
                    break;
                case 4:
                    Console.WriteLine("cuantro");
                    break;
                case 5:
                    Console.WriteLine("cinco");
                    break;
                default:
                    Console.WriteLine("Numero desconocido");
                    break;

            }
        }

        public static void Exercicio6()
        {

            int number;

            while(true)
            {
                Console.WriteLine("Escribe un numero para ver su cuadrado");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                    break;
                int result = number * 2;
                Console.WriteLine("resultado {0}", result);
            }

        }

        public static void Exercicio7()
        {
            Console.WriteLine("Escribe un primer numero para ver devisores comunes");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe un secundo numero para ver divisores comunes");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= firstNumber; i++)
            {
                if(firstNumber % i == 0)
                {
                    if(secondNumber % i == 0)
                        Console.Write(i + " ");
                }
            }
        }

        public static void Exercicio9()
        {
            Console.WriteLine("Escribe un numero");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int i = 2;
   ;


            while (firstNumber > 1)
            {
                if (firstNumber % i == 0)
                {
                    
                    firstNumber /= i;
                    i = 2;
                }
                else
                    i++;
                Console.WriteLine(i);
            }
            

        }
        public static void Exercicio10()
        {
            int n = 6;
            for(int i = 0; i < n * 2; i++)
            {   
                Console.Write(" ");
                for(int j = 0; j < n * 2; j++)
                {
                    if (i >= j)
                    Console.Write(" ");
                    Console.Write(" ");

                   
                }

                Console.WriteLine("+");
            }
        }

        static void Main(string[] args)
        {
            Exercicio2();
            Exercicio3();
            Exercicio4();
            Exercicio6();
            Exercicio7();
            Exercicio9();


        }
    }
}
