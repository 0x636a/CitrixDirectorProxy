using System;

namespace TeamLong.Citrix.Director.Implements;

public class DirectorSite : IDirectorSite
{
    public Guid Id { get; set; }
    public string LogOnUrl { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Domain { get; set; }
}