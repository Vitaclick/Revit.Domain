using System.Runtime.InteropServices;
using System.Text;

namespace Revit.Domain.IO
{
  public class IniReader
  {
    [DllImport("kernel32")]
    private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal,
      int size, string filePath);

    public static void WriteValue(string path, string Section, string Key, string Value)
    {
      WritePrivateProfileString(Section, Key, Value, path);
    }

    public static string ReadValue(string path, string Section, string Key)
    {
      var temp = new StringBuilder(255);
      var i = GetPrivateProfileString(Section, Key, "", temp, 255, path);
      return temp.ToString();
    }
  }
}
