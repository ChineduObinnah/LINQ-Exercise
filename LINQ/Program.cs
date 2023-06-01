namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videogames = new List<string>() { " Mario Kart,", "The Witcher", "Dark Souls", "Smash Bros.", "Fighters Z" };

            var longnames = videogames.OrderBy(videogames => videogames).ToList();

            foreach (var name in longnames)
            {
                Console.WriteLine(name);
            }
        }
    }
}