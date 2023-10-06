namespace TeamLong.Citrix.Director.Results;

public class ConnectionFailuresDataResult
{
    public ConnectionFailuresData GetConnectionFailuresDataResult { get; set; }

    public class ConnectionFailuresByType
    {
        /// <summary>
        /// </summary>
        public int ClientConnectionFailures { get; set; }

        /// <summary>
        /// </summary>
        public int MachineFailures { get; set; }

        /// <summary>
        /// </summary>
        public int UnavailableCapacity { get; set; }

        /// <summary>
        /// </summary>
        public int NoLicenseAvailable { get; set; }

        /// <summary>
        /// </summary>
        public int ConfigurationErrors { get; set; }

        /// <summary>
        /// </summary>
        public int Any { get; set; }
    }

    public class ConnectionFailuresData
    {
        /// <summary>
        /// </summary>
        public int CurrentTime { get; set; }

        /// <summary>
        /// </summary>
        public ConnectionFailuresByType FailuresByType { get; set; }

        /// <summary>
        /// </summary>
        public string SiteId { get; set; }
    }
}