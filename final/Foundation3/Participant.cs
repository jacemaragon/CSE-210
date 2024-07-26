using System;

class Participant
{
    private string _name;
    private string _email;

    public Participant(string name, string email)
    {
        _name = name;
        _email = email;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetEmail()
    {
        return _email;
    }
}