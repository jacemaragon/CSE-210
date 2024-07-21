public class BreathingActivity : BaseActivity
{
    public BreathingActivity()
    {
        Name = "Breathing";
        Description = "This activity will help you relax by guiding you through breathing exercises.";
    }

    public override void StartActivity()
    {
        Console.WriteLine($"{Name} - {Description}");
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Pause(5000);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Pause(4000);
            Console.WriteLine("Breathe out...");
            Pause(4000);
        }
        EndActivity();
    }
}