namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your favourite subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {

                case "english":
                  Console.WriteLine("English is Amazing!");
                    break;
                case "science":
                    Console.WriteLine("Science is rocks!");
                    break;
                case "physics":
                    Console.WriteLine("Physics is tough but awesome!");
                    break;
                case "physical education":
                    Console.WriteLine("Physical Education is my favorite!");
                    break;

                case "math":
                    Console.WriteLine("Math sucks but i'll manage it!");
                    break;


                default:
                    Console.WriteLine("Dont like that subject!");
                    break;
        }
        }
    }
}