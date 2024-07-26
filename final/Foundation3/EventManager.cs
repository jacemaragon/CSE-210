using System;
using System.Collections.Generic;

class EventManager
{
    private List<Event> _events;

    public EventManager()
    {
        _events = new List<Event>();
    }

    public void AddEvent(Event eventItem)
    {
        _events.Add(eventItem);
    }

    public List<Event> GetEvents()
    {
        return _events;
    }

    public void DisplayEvents()
    {
        foreach (var eventItem in _events)
        {
            Console.WriteLine($"Event: {eventItem.GetEventName()} on {eventItem.GetEventDate()}");
            foreach (var participant in eventItem.GetParticipants())
            {
                Console.WriteLine($"- {participant.GetName()} ({participant.GetEmail()})");
            }
            Console.WriteLine();
        }
    }
}