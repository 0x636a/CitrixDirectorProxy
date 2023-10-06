namespace TeamLong.Citrix.Director.Results;

public class FailedRDSMachinesDataResult
{
    /// <summary>
    /// </summary>
    public FailedRDSMachinesData GetFailedRDSMachinesDataResult { get; set; }

    public class RDSFailuresByType
    {
        /// <summary>
        /// </summary>
        public int FailedToStart { get; set; }

        /// <summary>
        /// </summary>
        public int StuckOnBoot { get; set; }

        /// <summary>
        /// </summary>
        public int Unregistered { get; set; }

        /// <summary>
        /// </summary>
        public int MaxLoad { get; set; }

        /// <summary>
        /// </summary>
        public int Any { get; set; }
    }

    public class FailedRDSMachinesData
    {
        /// <summary>
        /// </summary>
        public long CurrentTime { get; set; }

        /// <summary>
        /// </summary>
        public RDSFailuresByType FailuresByType { get; set; }

        /// <summary>
        /// </summary>
        public string SiteId { get; set; }
    }
}