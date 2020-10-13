using System.Collections.Generic;

namespace Revit.Domain.RevitServer
{
  public class RsnServers
  {
    public Dictionary<int, List<string>> RsnServerList { get; set; }
    public Dictionary<int, List<string>> RsnServerRegex { get; set; }
  }
}
