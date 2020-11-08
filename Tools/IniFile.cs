// Decompiled with JetBrains decompiler
// Type: LastChaos_DailyLogin.IniFile
// Assembly: LastChaos OX Quiz Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 20625953-EDD4-4EA3-8293-1D2AEA3DCDDB
// Assembly location: C:\Users\iIKENIi\Desktop\GS editor\LastChaos OX Quiz Editor\LastChaos OX Quiz Editor.exe

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace LcDevPack_TeamDamonA.Tools
{
  internal class IniFile
  {
    public string path;

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool WritePrivateProfileString(
      string lpAppName,
      string lpKeyName,
      string lpString,
      string lpFileName);

    [DllImport("kernel32.dll")]
    private static extern int GetPrivateProfileString(
      string section,
      string key,
      string def,
      StringBuilder retVal,
      int size,
      string filePath);

    public IniFile(string INIPath)
    {
      this.path = INIPath;
    }

    public void IniWriteValue(string Section, string Key, string Value)
    {
      IniFile.WritePrivateProfileString(Section, Key, Value, this.path);
    }

    public string IniReadValue(string Section, string Key)
    {
      StringBuilder retVal = new StringBuilder((int) byte.MaxValue);
      IniFile.GetPrivateProfileString(Section, Key, "", retVal, (int) byte.MaxValue, this.path);
      return Convert.ToString((object) retVal);
    }
  }
}
