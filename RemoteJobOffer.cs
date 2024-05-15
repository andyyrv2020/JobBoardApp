public class RemoteJobOffer : JobOffer
{
    public bool FullyRemote { get; private set; }

    public RemoteJobOffer(string jobTitle, string company, double salary, bool fullyRemote)
        : base(jobTitle, company, salary)
    {
        this.FullyRemote = fullyRemote;
    }

    public override string ToString()
    {
        string fullyRemoteString = FullyRemote ? "yes" : "no";
        return base.ToString() + $"\nFully Remote: {fullyRemoteString}";
    }
}
