using System.Linq;

namespace Revit.Domain.Extensions
{
  public static class StringUtils
  {
    public static bool ContainsAny(this string pile, params string[] needles)
    {
      return needles.Any(pile.Contains);
    }
  }
}
