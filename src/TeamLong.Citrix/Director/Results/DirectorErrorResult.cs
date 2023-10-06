namespace TeamLong.Citrix.Director.Results;

public class DirectorErrorResult
{
    /// <summary>
    /// </summary>
    public ErrorResult Error { get; set; }

    public class ErrorResult
    {
        /// <summary>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// </summary>
        public string SubErrorCode { get; set; }

        /// <summary>
        /// </summary>
        public string NumberOfFailures { get; set; }

        /// <summary>
        /// </summary>
        public string NumberOfSuccesses { get; set; }

        /// <summary>
        /// </summary>
        public string IncompatibleDataSource { get; set; }
    }
}