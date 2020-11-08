// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.MemoryWorker.config
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using System.IO;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker
{
  public class config
  {
    public static string ConfigString;

    public static void ReadConfig()
    {
      if (!File.Exists("Config/Settings.cfg"))
      {
        int num = (int) MessageBox.Show("No Setting file exist!");
      }
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string str4 = "";
      string str5 = "";
      TextReader textReader = (TextReader) new StreamReader("Config/Settings.cfg");
      string str6;
      while ((str6 = textReader.ReadLine()) != null)
      {
        if (!str6.Contains("#") && (uint) str6.Length > 0U)
        {
          string[] strArray = str6.Split('=');
          foreach (string str7 in strArray)
          {
            if (strArray[0] == "SQL_HOST")
              str1 = strArray[1];
            if (strArray[0] == "SQL_USER")
              str2 = strArray[1];
            if (strArray[0] == "SQL_PASSWORD")
              str3 = strArray[1];
            if (strArray[0] == "SQL_DATABASE")
              str4 = strArray[1];
            if (strArray[0] == "Episode")
              str5 = strArray[1];
          }
        }
      }
      textReader.Close();
      config.ConfigString = string.Format("Data Source={0};Database={1};User ID={2};Password={3};",  str1,  str4,  str2,  str3);
    }
  }
}
