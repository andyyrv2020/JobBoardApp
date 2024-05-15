using System;

public abstract class JobOffer
{
    private string jobTitle;
    private string company;
    private double salary;

    protected JobOffer(string jobTitle, string company, double salary)
    {
        this.JobTitle = jobTitle;
        this.Company = company;
        this.Salary = salary;
    }

    public string JobTitle
    {
        get => jobTitle;
        private set
        {
            if (value.Length < 3 || value.Length > 30)
                throw new ArgumentException("Job Title should be between 3 and 30 characters!");
            jobTitle = value;
        }
    }

    public string Company
    {
        get => company;
        private set
        {
            if (value.Length < 3 || value.Length > 30)
                throw new ArgumentException("Company should be between 3 and 30 characters!");
            company = value;
        }
    }

    public double Salary
    {
        get => salary;
        private set
        {
            if (value < 0)
                throw new ArgumentException("Salary should be 0 or positive!");
            salary = value;
        }
    }

    public override string ToString()
    {
        return $"Job Title: {JobTitle}\nCompany: {Company}\nSalary: {Salary:F2} BGN";
    }
}
