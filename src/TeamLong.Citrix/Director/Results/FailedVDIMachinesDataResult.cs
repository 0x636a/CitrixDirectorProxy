namespace TeamLong.Citrix.Director.Results;

public class FailedVDIMachinesDataResult
{
    /// <summary>
    /// </summary>
    public FailedVDIMachinesData GetFailedVDIMachinesDataResult { get; set; }

    public class VDIFailuresByType
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
        public int Any { get; set; }
    }

    public class FailedVDIMachinesData
    {
        /// <summary>
        /// </summary>
        public long CurrentTime { get; set; }

        /// <summary>
        /// </summary>
        public VDIFailuresByType FailuresByType { get; set; }

        /// <summary>
        /// </summary>
        public string SiteId { get; set; }
    }
}