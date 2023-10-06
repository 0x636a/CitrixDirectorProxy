using System.Collections.Generic;

namespace TeamLong.Citrix.Director.Results;

public class FailedRDSMachinesDetailsByTypeResult
{
    /// <summary>
    /// </summary>
    public GetFailedRDSMachinesDetailsByType GetFailedRDSMachinesDetailsByTypeResult { get; set; }

    public class DeliveryGroupsFailuresData
    {
        /// <summary>
        /// </summary>
        public string DeliveryGroupId { get; set; }

        /// <summary>
        ///     虚拟应用（测试）
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
        public long Date { get; set; }

        /// <summary>
        /// </summary>
        public int Number { get; set; }
    }

    public class GetFailedRDSMachinesDetailsByType
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
    }
}