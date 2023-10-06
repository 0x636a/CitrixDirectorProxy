using System.Collections.Generic;

namespace TeamLong.Citrix.Director.Results;

public class SiteInfrastructureDataResult
{
    public Root GetSiteInfrastructureDataResult { get; set; }

    public class BrokerStatuses
    {
        /// <summary>
        /// </summary>
        public string DBAccessStatus { get; set; }

        /// <summary>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        public string LicensesStatus { get; set; }

        /// <summary>
        /// </summary>
        public string LoggingDBStatus { get; set; }

        /// <summary>
        /// </summary>
        public string MonitoringDBStatus { get; set; }

        /// <summary>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        public string OnlineStatus { get; set; }

        /// <summary>
        /// </summary>
        public List<string> ServiceAlerts { get; set; }
    }

    public class HypervisorStatuses
    {
        /// <summary>
        /// </summary>
        public List<string> Alerts { get; set; }

        /// <summary>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        public string Name { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// </summary>
        public List<BrokerStatuses> BrokerStatuses { get; set; }

        /// <summary>
        /// </summary>
        public List<HypervisorStatuses> HypervisorStatuses { get; set; }

        /// <summary>
        /// </summary>
        public string SiteId { get; set; }
    }
}