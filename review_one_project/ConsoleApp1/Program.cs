using System;

class Program
{
    static void Main(string[] args)
    {
        int notaFinal = 0;
        string[] notas = { "primera", "segona", "tercera" };
        int resposta = 0;

        List<string> comarques = new List<string>();
        string comarca;
        string zipCode;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Introdueix la" + notas[i] + " nota.");
            notaFinal = notaFinal + Convert.ToInt32(Console.ReadLine());
        }

        float promig = notaFinal / 3;

        Console.WriteLine("El promig de les notes es: " + notaFinal);

        if (promig > 6)
        {
            Console.WriteLine("Aprovat");
        }
        else
        {
            Console.WriteLine("Suspès");
        }

        while (resposta == 0) {
            Console.WriteLine("¿Introduir una ciutat? (0=Si|1=No)");
            if (resposta == 0) {
                Console.WriteLine("Introdueix comarca");
                comarca = Console.ReadLine();
                Console.WriteLine("Introdueix codi postal");
                zipCode = Console.ReadLine();
                comarques.Add(comarca + ", " + zipCode);
            }
            foreach (string comarque in comarques)
            {
                Console.WriteLine(comarque);
            }
        }
    }
}

