using System;
using System.Collections.Generic;
using System.Linq;

public class Category
{
    private string name;
    private List<JobOffer> jobOffers;

    public Category(string name)
    {
        this.Name = name;
        this.jobOffers = new List<JobOffer>();
    }

    public string Name
    {
        get => name;
        private set
        {
            if (value.Length < 2 || value.Length > 40)
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            name = value;
        }
    }

    public void AddJobOffer(JobOffer offer)
    {
        jobOffers.Add(offer);
    }

    public double AverageSalary()
    {
        if (jobOffers.Count == 0) return 0;
        return jobOffers.Average(o => o.Salary);
    }

    public List<JobOffer> GetOffersAboveSalary(double salary)
    {
        return jobOffers.Where(o => o.Salary >= salary).OrderByDescending(o => o.Salary).ToList();
    }

    public List<JobOffer> GetOffersWithoutSalary()
    {
        return jobOffers.Where(o => o.Salary == 0).OrderBy(o => o.Company).ToList();
    }

    public override string ToString()
    {
        return $"Category {Name}\nTotal Offers: {jobOffers.Count}";
    }
}
