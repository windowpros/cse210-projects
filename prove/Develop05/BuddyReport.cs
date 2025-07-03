using System.Security.Cryptography.X509Certificates;

class BuddyReport
{
    List<string> _myReports;
    string _buddy;
    String _conversation;
    string _fullBuddyReport;

    public BuddyReport(string buddy, string conversation, string fullbudgetreport)
    {
        _buddy = buddy;
        _conversation = conversation;
        _myReports = new List<string>();
        _fullBuddyReport = fullbudgetreport;
    }

    public BuddyReport()
    {
        _myReports = new List<string>();

    }

    public string GetName()
    {
        Console.WriteLine("Who did you meet with? ");
        _buddy = Console.ReadLine();
        return _buddy;
    }
    public void SetName(string name)
    {
        _buddy = name;
    }

    public string GetConversation()
    {
        Console.WriteLine("What did you discuss ");
        _conversation = Console.ReadLine();
        return _conversation;
    }
    public void SetConversation(string conversation)
    {
        _conversation = conversation;
    }
    public void CreateReport()
    {
        _fullBuddyReport = $"Name: {_buddy}, Conversation: {_conversation}";
    }

    public void AddReportToList()
    {
        _myReports.Add(_fullBuddyReport);
    }

    public void DisplayAllReports()
    {
        foreach (string report in _myReports)
        {
            Console.WriteLine(report);
        }
    }
}