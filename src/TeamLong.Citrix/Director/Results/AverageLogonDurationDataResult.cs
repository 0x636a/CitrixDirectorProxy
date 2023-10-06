using System.Collections.Generic;

namespace TeamLong.Citrix.Director.Results;

public class AverageLogonDurationDataResult
{
    public class LogonDataByMinute
    {
        /// <summary>
        /// </summary>
        public int AverageDurationInMS { get; set; }

        /// <summary>
        /// </summary>
        public int Date { get; set; }

        /// <summary>
        /// </summary>
        public int NumberOfLogons { get; set; }
    }

    public class GetAverageLogonDurationData
    {
        /// <summary>
        /// </summary>
        public int LastHourAverageLogonDurationInMS { get; set; }

        /// <summary>
        /// </summary>
        public List<LogonDataByMinute> LogonDataByMinute { get; set; }

        /// <summary>
        /// </summary>
        public string SiteId { get; set; }
    }
}