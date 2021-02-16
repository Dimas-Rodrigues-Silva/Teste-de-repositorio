using System;

namespace Viagem
{   
    class Gastos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quão longa é a viagem(em horas)?");
            int tempo=int.Parse(Console.ReadLine());
            Console.WriteLine("qual a velocidade do seu carro(em km/h)?");
            int velocidade=int.Parse(Console.ReadLine());
            float litrosporhora=12;
            float litrostotais=(tempo*velocidade/litrosporhora);
            double litrosporviagem=(Math.Round(litrostotais, 3));
            Console.WriteLine("Você necessitará de " + litrosporviagem + " litros de gasolina");
        }

    
    }
}