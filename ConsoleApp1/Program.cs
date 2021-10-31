using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;

            CentralizarMensagem("Este programa fará a soma de dois valores dentro de limites estabelecidos!", 1);
  
            n1 = EntrarInt("Digite o valor de n1 que seja entre 5 à 10: ", 4, 25, 5, 10);  
            n2 = EntrarInt("Digite o valor de n2 que seja entre 10 à 20: ", 6, 25, 10, 20);

            mostrarMensagem("Saída", 8, 25);
            Console.WriteLine("Resultado da soma {0} com {1} é igual {2}", n1, n2, Calcular(n1, n2));

            CentralizarMensagem("Encerrando o Programa!", 11);
            CentralizarMensagem("+------+", 13);
            CentralizarMensagem("| FIM! |", 14);
            CentralizarMensagem("+------+", 15);
        }
        static int EntrarInt(string msg, int linha, int coluna, int li, int ls) 
        {                                                
            int r; 
            {
                mostrarMensagem(msg, linha, coluna);
                r = int.Parse(Console.ReadLine()); 
            }
            while (r < li || r > ls); 
            return r; 
        }
        static int Calcular(int x, int y) 
        {
            int r; 
            r = x + y;
            return r;
        }
        static void CentralizarMensagem(string msg, int linha) 
        {
            int coluna;
            coluna = ((120 - msg.Length) / 2) + 1; 
            mostrarMensagem(msg, linha, coluna);
        }
        static void mostrarMensagem(string msg, int linha, int coluna) 
        {

            Console.SetCursorPosition(coluna, linha);
            Console.Write(msg);
        }
    }
}