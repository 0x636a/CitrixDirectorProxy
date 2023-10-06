using System.Linq;

namespace TeamLong.Citrix.Director.Results;

public class LogOnPageParams
{
    public string VIEWSTATE { get; set; }
    public string VIEWSTATEGENERATOR { get; set; }
    public string EVENTVALIDATION { get; set; }
    public string Submit { get; set; }

    public bool Validate()
    {
        var arr = new string[4] { VIEWSTATE, VIEWSTATEGENERATOR, EVENTVALIDATION, Submit };
        return arr.Any(p => string.IsNullOrWhiteSpace(p)) == false;
    }
}