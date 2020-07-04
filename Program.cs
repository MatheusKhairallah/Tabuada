using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo: ");
            int numero=Convert.ToInt16(Console.ReadLine());

            Console.Clear();
            
            for (int i = 0; i <= 10; i=i+1)
            {
               Console.WriteLine(numero + " X " +i+ " = " + (numero*i)); 
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
        
            
               
            
        }
    }
}
