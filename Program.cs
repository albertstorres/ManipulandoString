using System;
namespace ManipulandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste ";
            Console.WriteLine(texto.Replace("Este", "Isto"));//SUBSTITUI "ESTE" POR "ISTO"
            Console.WriteLine(texto.Replace("e", "X"));//SUBSTITUI "e" POR "X"

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);//ESTE
            Console.WriteLine(divisao[1]);//TEXTO
            Console.WriteLine(divisao[2]);//É
            Console.WriteLine(divisao[3]);//UM
            Console.WriteLine(divisao[4]);//TESTE

            var resultado = texto.Substring(5, 4);//PEGA 4 ÍNDICES A PARTIR DO QUINTO ÍNDICE. "TEXT"
            Console.WriteLine(resultado);
            Console.WriteLine(texto.Trim());//REMOVE ESPAÇO EM BRANCO NO INÍCIO E NO FINAL DA STRING. IGUAL AO JS
        }
    }
}
