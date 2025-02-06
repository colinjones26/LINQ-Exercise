namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creating list of video games
            List<string> videoGames = new List<string>
            {
                "Halo", "FIFA", "GTA", "Little Big World"
            };

            //Ordering games by length
            var orderedGames = videoGames.OrderBy(game => game.Length).ToList();

            //Print the ordered list of games
            Console.WriteLine("List of games in order by length:");
            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }

            //Ordering games with more than 10 characters
            var longNamedGames = videoGames.Where(game => game.Length > 10).ToList();

            //Print the games with 10 or more characters
            Console.WriteLine("\nGames with more than 10 characters:");
            foreach (var game in longNamedGames)
            {
                Console.WriteLine(game);
            }

            //Extract the first letter from each game using Select
            var firstLetters = videoGames.Select(game => game[0]).ToList();

            //Print the letters
            Console.WriteLine("\nFirst letter of each game:");
            foreach(var letter in firstLetters)
            {
                Console.WriteLine(letter);
            }


        }
    }
}
            


