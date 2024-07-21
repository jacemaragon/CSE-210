public class ReflectionActivity : BaseActivity
{
    private static readonly string[] Prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "remember when your friends needed you and you where there",
    };

    private static readonly string[] Questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "do you think you can have that peace again?",
    };

    public ReflectionActivity()
    {
        Name = "Reflection";
        Description = "This activity helps you reflect on personal strengths and resilience.";
    }

    public override void StartActivity()
    {
        Console.WriteLine($"{Name} - {Description}");
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Pause(5000);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        Random rand = new Random();

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(Prompts[rand.Next(Prompts.Length)]);
            Pause(3000);

            foreach (var question in Questions)
            {
                Console.WriteLine(question);
                Pause(3000);
            }
        }
        EndActivity();
    }
}