using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.AplicativoPetShop;

public class Servico
{
    public static void BanhoETosa(Animal animal)
    {
        if (animal is Cachorro)
        {
            Console.WriteLine($"Banho e tosa realizado realizado para {animal.Nome}.");
        }
        else
        {
            Console.WriteLine("Banho e tosa está disponível apenas para cachorros.");
        }
    }
}
