using System;

namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1="", num2="";
            double num1D = 0f, num2D = 0f;
            double resultSuma = 0f, resultResta = 0f, resultMult = 0f, resultDiv = 0f;
            Console.WriteLine("INGRESE EL PRIMER NÚMERO");
            num1 = Console.ReadLine();
            Console.WriteLine("INGRESE EL SEGUNDO NÚMERO");
            num2 = Console.ReadLine();
            //CONVERSIÓN
            num1D = Double.Parse(num1);
            num2D = Double.Parse(num2);
            Console.WriteLine("");
            Console.WriteLine("RESULTADOS: ");
            Console.WriteLine("");
            //SUMA
            resultSuma = num1D + num2D;
            Console.WriteLine("SUMA: " + resultSuma);
            //RESTA
            resultResta = num1D - num2D;
            Console.WriteLine("RESTA: " + resultResta);
            //MULTIPLICACIÓN            
            resultMult = num1D * num2D;
            Console.WriteLine("MULTIPLICACIÓN: " + resultMult);
            //DIVISIÓN
            resultDiv = num1D / num2D;
            Console.WriteLine("DIVISIÓN: " + resultDiv);
        }
    }
}
