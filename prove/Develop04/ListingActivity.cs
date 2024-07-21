public class ListingActivity : BaseActivity
{
    private static readonly string[] Prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Why do you think people look for you when they're sad"
    };

    public ListingActivity()
    {
        Name = "Listing";
        Description = "This activity helps you list things in an area of positivity.";
    }

    public override void StartActivity()
    {
        Console.WriteLine($"{Name} - {Description}");
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Pause(5000);

        Random rand = new Random();
        Console.WriteLine(Prompts[rand.Next(Prompts.Length)]);
        Pause(5000);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter item: ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
        EndActivity();
    }
}