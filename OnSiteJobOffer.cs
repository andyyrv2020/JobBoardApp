using System;

public class OnSiteJobOffer : JobOffer
{
    private string city;

    public OnSiteJobOffer(string jobTitle, string company, double salary, string city)
        : base(jobTitle, company, salary)
    {
        this.City = city;
    }

    public string City
    {
        get => city;
        private set
        {
            if (value.Length < 3 || value.Length > 30)
                throw new ArgumentException("City should be between 3 and 30 characters!");
            city = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"\nCity: {City}";
    }
}
