namespace Ruoka_annos_Generaattori_Tehtävä
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p_valids = new List<string> { "Nauta", "Kana", "Kasvikset" };
            var l_valids = new List<string> { "Peruna", "Riisi", "Pasta" };
            var k_valids = new List<string> { "Curry", "Hapanimelä", "Pippuri" };
            var ateriat = new List<string> { "" };
            int tilausnumero = 0;

            Paaraakaaine paaraakaaine = Paaraakaaine.Nauta;
            Lisuke lisuke = Lisuke.Peruna;
            Kastike kastike = Kastike.Curry;

            Console.WriteLine("Tervetuloa ravintolaan. Valitkaa annoksenne ruokaaineet:");

            while (tilausnumero < 3)
            {
                tilausnumero++;
                Console.WriteLine("Valitse pääruoka-aine: Nauta, Kana tai Kasvikset");
                string? p_valinta = Console.ReadLine();
                if(p_valinta == null || p_valids == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Jotkin muuttujat ovat nolla");
                    Console.ResetColor();
                    return;
                }
                if (!p_valids.Contains(p_valinta))
                {
                    Console.Clear();
                    Console.WriteLine($"Anamasi komento '{p_valinta}' ei ole käytössä");
                    return;
                }
                else
                {
                    paaraakaaine = (Paaraakaaine)Enum.Parse(typeof(Paaraakaaine), p_valinta);
                }

                Console.WriteLine("Valitse lisuke: Peruna, Riisi tai Pasta");
                string? l_valinta = Console.ReadLine();
                if (l_valinta == null || l_valids == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Jotkin muuttujat ovat nolla");
                    Console.ResetColor();
                    return;
                }
                if (!l_valids.Contains(l_valinta))
                {
                    Console.Clear();
                    Console.WriteLine($"Anamasi komento '{l_valinta}' ei ole käytössä");
                    return;
                }
                else
                {
                    lisuke = (Lisuke)Enum.Parse(typeof(Lisuke), l_valinta);
                }

                Console.WriteLine("Valitse kastike: Curry, Hapanimelä tai Pippuri");
                string? k_valinta = Console.ReadLine();
                if (k_valinta == null || k_valids == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Jotkin muuttujat ovat nolla");
                    Console.ResetColor();
                    return;
                }
                if (!k_valids.Contains(k_valinta))
                {
                    Console.Clear();
                    Console.WriteLine($"Anamasi komento '{k_valinta}' ei ole käytössä");
                    return;
                }
                else
                {
                    kastike = (Kastike)Enum.Parse(typeof(Kastike), k_valinta);
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                ateriat.Add($"Ateria: {tilausnumero}, {paaraakaaine} ja  {lisuke}, {kastike}-kastikkeella.");
                Console.WriteLine($"Ateriasi on tallennettu listaan. Valitsit {paaraakaaine} ja {lisuke} {kastike}-kastikkeella");
                Console.ResetColor();
            }

            if (tilausnumero == 3)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.Clear();
                foreach (string ateria in ateriat)
                {
                    Console.WriteLine(ateria);
                }
                Console.ResetColor();
            }

        }

        public enum Paaraakaaine
        {
            Nauta,
            Kana,
            Kasvikset
        }
        public enum Lisuke
        {
            Peruna,
            Riisi,
            Pasta
        }
        public enum Kastike
        {
            Curry,
            Hapanimelä,
            Pippuri
        }

    }
}
