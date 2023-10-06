using System.Collections.Generic;

namespace TeamLong.Citrix.Director.Results;

public class FailedVDIMachinesDetailsByTypeResult
{
    public class DeliveryGroupsFailuresData
    {
        /// <summary>
        /// </summary>
        public string DeliveryGroupId { get; set; }

        /// <summary>
        ///     MCS-Win10-数智立方
        /// </summary>
        public string DeliveryGroupName { get; set; }

        /// <summary>
        /// </summary>
        public int NumberOfFailures { get; set; }
    }

    public class NumberOfFailuresByMinute
    {
        /// <summary>
        /// </summary>
        public int Date { get; set; }

        /// <summary>
        /// </summary>
        public int Number { get; set; }
    }

    public class GetFailedVDIMachinesDetailsByTypeResult
    {
        /// <summary>
        /// </summary>
        public List<DeliveryGroupsFailuresData> DeliveryGroupsFailuresData { get; set; }

        /// <summary>
        /// </summary>
        public string FailureType { get; set; }

        /// <summary>
        /// </summary>
        public List<NumberOfFailuresByMinute> NumberOfFailuresByMinute { get; set; }

        /// <summary>
        /// </summary>
        public string SiteId { get; set; }
    }
}