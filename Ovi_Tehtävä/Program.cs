namespace Ovi_Tehtävä
{
    public class Program
    {
        static void Main(string[] args)
        {
            var validCommands = new List<string> { "Avaa", "Sulje", "Sulje Lukko", "Avaa Lukko", "avaa", "sulje", "sulje lukko", "avaa lukko" };
            DoorStates doorStates = DoorStates.Open;
            while (true)
            {
                Console.WriteLine("Hyväksytyt komennot: 'Avaa', 'Sulje', 'Sulje Lukko', 'Avaa Lukko'");
                Console.WriteLine("Ovi on nyt: " + doorStates.ToString());
                Console.WriteLine("Anna komento: ");
                string? command = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(command) || !validCommands.Contains(command))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Virheellinen komento: " + command);
                    Console.ResetColor();
                }

                //AUKI
                if (command == "Avaa" || command == "avaa")
                {
                    Console.Clear();

                    if (doorStates == DoorStates.Closed)
                    {
                        doorStates = DoorStates.Open;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ovi on nyt auki");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ovi joko on jo halutussa asennossa tai ovi ei ole halutussa tilassa toiminnon suorittamiseksi");
                        Console.ResetColor();
                    }
                }

                //KIINNI
                if (command == "Sulje" || command == "sulje")
                {
                    Console.Clear();

                    if (doorStates == DoorStates.Open)
                    {
                        doorStates = DoorStates.Closed;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ovi on nyt suljettu");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ovi joko on jo halutussa asennossa tai ovi ei ole halutussa tilassa toiminnon suorittamiseksi");
                        Console.ResetColor();
                    }
                }

                //LUKITSE
                if (command == "Sulje Lukko" || command == "sulje lukko")
                {
                    Console.Clear();

                    if (doorStates == DoorStates.Closed)
                    {
                        doorStates = DoorStates.Locked;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ovi on nyt lukittu");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ovi joko on jo halutussa asennossa tai ovi ei ole halutussa tilassa toiminnon suorittamiseksi");
                        Console.ResetColor();
                    }
                }

                //AVAA LUKKO
                if (command == "Avaa Lukko" || command == "avaa lukko")
                {
                    Console.Clear();

                    if (doorStates == DoorStates.Locked)
                    {
                        doorStates = DoorStates.Closed;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ovi on nyt avattu lukosta");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ovi joko on jo halutussa asennossa tai ovi ei ole halutussa tilassa toiminnon suorittamiseksi");
                        Console.ResetColor();
                    }
                }

            }
        }

        public enum DoorStates
        {
            Open,
            Closed,
            Locked
        }
    }
}