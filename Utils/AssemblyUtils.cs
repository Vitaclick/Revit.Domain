using System;
using System.IO;
using System.Reflection;

namespace Revit.Domain.Utils
{
  public static class AssemblyUtils
  {
    public static string GetAssemblyDirectory()
    {
      var codebase = Assembly.GetExecutingAssembly().CodeBase;

      // remove File:// at the beginning
      var uri = new UriBuilder(codebase);
      var path = Uri.UnescapeDataString(uri.Path);
      return Path.GetDirectoryName(path);
    }
  }
}
