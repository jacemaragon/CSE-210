using System;
using System.Collections.Generic;

class Event
{
    private string _eventName;
    private DateTime _eventDate;
    private List<Participant> _participants;

    public Event(string eventName, DateTime eventDate)
    {
        _eventName = eventName;
        _eventDate = eventDate;
        _participants = new List<Participant>();
    }

    public string GetEventName()
    {
        return _eventName;
    }

    public DateTime GetEventDate()
    {
        return _eventDate;
    }

    public void AddParticipant(Participant participant)
    {
        _participants.Add(participant);
    }

    public List<Participant> GetParticipants()
    {
        return _participants;
    }
}