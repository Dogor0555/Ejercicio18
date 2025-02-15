using System;

class Program
{
    // Método que recibe un string y lo imprime en reversa
    static void ImprimirReversa(string texto)
    {
        char[] caracteres = texto.ToCharArray();
        Array.Reverse(caracteres);
        Console.WriteLine(new string(caracteres));
    }

    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese un texto
        Console.Write("Ingrese un texto: ");
        string texto = Console.ReadLine();

        // Llamar al método para imprimir el texto en reversa
        ImprimirReversa(texto);
    }
}
