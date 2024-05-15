using System;
using System.Collections.Generic;

public class Controller
{
    private Dictionary<string, Category> categories;

    public Controller()
    {
        this.categories = new Dictionary<string, Category>();
    }

    public string AddCategory(List<string> args)
    {
        string name = args[0];
        categories.Add(name, new Category(name));
        return $"Created Category {name}!";
    }

    public string AddJobOffer(List<string> args)
    {
        string category = args[0];
        string jobTitle = args[1];
        string company = args[2];
        double salary = double.Parse(args[3]);
        string type = args[4];

        JobOffer offer;

        if (type == "onsite")
        {
            string city = args[5];
            offer = new OnSiteJobOffer(jobTitle, company, salary, city);
        }
        else
        {
            bool fullyRemote = bool.Parse(args[5]);
            offer = new RemoteJobOffer(jobTitle, company, salary, fullyRemote);
        }

        categories[category].AddJobOffer(offer);
        return $"Created JobOffer {jobTitle} in Category {category}!";
    }

    public string GetAverageSalary(List<string> args)
    {
        string name = args[0];
        double averageSalary = categories[name].AverageSalary();
        return $"The average salary is: {averageSalary:F2} BGN";
    }

    public string GetOffersAboveSalary(List<string> args)
    {
        string name = args[0];
        double salary = double.Parse(args[1]);
        var offers = categories[name].GetOffersAboveSalary(salary);
        return string.Join("\n", offers);
    }

    public string GetOffersWithoutSalary(List<string> args)
    {
        string name = args[0];
        var offers = categories[name].GetOffersWithoutSalary();
        return string.Join("\n", offers);
    }
}
