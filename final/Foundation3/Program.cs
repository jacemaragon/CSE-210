using System;

class Program
{
    static void Main(string[] args)
    {
        EventManager eventManager = new EventManager();

        Event event1 = new Event("Conference", new DateTime(2024, 8, 10));
        Event event2 = new Event("Workshop", new DateTime(2024, 9, 15));

        Participant participant1 = new Participant("Jacem", "Jacembyu@gmail.com");
        Participant participant2 = new Participant("Alberto", "Alberto@gmail.com.com");

        

        event1.AddParticipant(participant1);
        event1.AddParticipant(participant2);

        event2.AddParticipant(participant2);

        eventManager.AddEvent(event1);
        eventManager.AddEvent(event2);

        eventManager.DisplayEvents();
    }
}