// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.epvp_hwid
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace LcDevPack_TeamDamonA
{
  public class epvp_hwid
  {
    [DllImport("advapi32.dll", SetLastError = true)]
    private static extern bool GetCurrentHwProfile(IntPtr lpHwProfileInfo);

    [DllImport("kernel32.dll")]
    private static extern long GetVolumeInformation(string PathName, StringBuilder VolumeNameBuffer, uint VolumeNameSize, ref uint VolumeSerialNumber, ref uint MaximumComponentLength, ref uint FileSystemFlags, StringBuilder FileSystemNameBuffer, uint FileSystemNameSize);

    public string strHWID()
    {
      return md5(ProfileInfo().szHwProfileGuid.ToString() + GetVolumeSerial("C"));
    }

    public static string[] GetHWID(string HWID)
    {
      string end = new StreamReader(WebRequest.Create("http://elitepvpers.com/api/hwid.php?hash=" + HWID).GetResponse().GetResponseStream()).ReadToEnd();
      return new string[6]
      {
        epvp_hwid.StringBetween("<userid>", "</userid>", end, false, false)[0],
        epvp_hwid.StringBetween("<username>", "</username>", end, false, false)[0],
        epvp_hwid.StringBetween("<joindate>", "</joindate>", end, false, false)[0],
        epvp_hwid.StringBetween("<posts>", "</posts>", end, false, false)[0],
        epvp_hwid.StringBetween("<thanks>", "</thanks>", end, false, false)[0],
        epvp_hwid.StringBetween("<usergroup>", "</usergroup>", end, false, false)[0]
      };
    }

    private string md5(string input)
    {
      byte[] hash = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(input));
      StringBuilder stringBuilder = new StringBuilder();
      for (int index = 0; index < hash.Length; ++index)
        stringBuilder.Append(hash[index].ToString("X2"));
      return stringBuilder.ToString();
    }

    private static string[] StringBetween(string strBegin, string strEnd, string strSource, bool includeBegin, bool includeEnd)
    {
      string[] strArray = new string[2]{ "", "" };
      int num = strSource.IndexOf(strBegin);
      if (num != -1)
      {
        if (includeBegin)
          num -= strBegin.Length;
        strSource = strSource.Substring(num + strBegin.Length);
        int length = strSource.IndexOf(strEnd);
        if (length != -1)
        {
          if (includeEnd)
            length += strEnd.Length;
          strArray[0] = strSource.Substring(0, length);
          if (length + strEnd.Length < strSource.Length)
            strArray[1] = strSource.Substring(length + strEnd.Length);
        }
      }
      else
        strArray[1] = strSource;
      return strArray;
    }

    private epvp_hwid.HW_PROFILE_INFO ProfileInfo()
    {
      IntPtr num = IntPtr.Zero;
      try
      {
        epvp_hwid.HW_PROFILE_INFO hwProfileInfo = new epvp_hwid.HW_PROFILE_INFO();
        num = Marshal.AllocHGlobal(Marshal.SizeOf( hwProfileInfo));
        Marshal.StructureToPtr( hwProfileInfo, num, false);
        if (!epvp_hwid.GetCurrentHwProfile(num))
          throw new Exception("Error cant get current hw profile!");
        Marshal.PtrToStructure(num,  hwProfileInfo);
        return hwProfileInfo;
      }
      catch (Exception ex)
      {
        throw new Exception(ex.ToString());
      }
      finally
      {
        if (num != IntPtr.Zero)
          Marshal.FreeHGlobal(num);
      }
    }

    private string GetVolumeSerial(string strDriveLetter)
    {
      uint VolumeSerialNumber = 0;
      uint MaximumComponentLength = 0;
      StringBuilder VolumeNameBuffer = new StringBuilder(256);
      uint FileSystemFlags = 0;
      StringBuilder FileSystemNameBuffer = new StringBuilder(256);
      strDriveLetter += ":\\";
      epvp_hwid.GetVolumeInformation(strDriveLetter, VolumeNameBuffer, (uint) VolumeNameBuffer.Capacity, ref VolumeSerialNumber, ref MaximumComponentLength, ref FileSystemFlags, FileSystemNameBuffer, (uint) FileSystemNameBuffer.Capacity);
      return Convert.ToString(VolumeSerialNumber);
    }

    public static string[] GetWhiteList()
    {
      return new string[3]
      {
        "damona",
        "kravens",
        "LastWhisper"
      };
    }

    [Flags]
    private enum DockInfo
    {
      DOCKINFO_DOCKED = 2,
      DOCKINFO_UNDOCKED = 1,
      DOCKINFO_USER_SUPPLIED = 4,
      DOCKINFO_USER_DOCKED = DOCKINFO_USER_SUPPLIED | DOCKINFO_UNDOCKED,
      DOCKINFO_USER_UNDOCKED = DOCKINFO_USER_SUPPLIED | DOCKINFO_DOCKED,
    }

    [StructLayout(LayoutKind.Sequential)]
    private class HW_PROFILE_INFO
    {
      [MarshalAs(UnmanagedType.U4)]
      public int dwDockInfo;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 39)]
      public string szHwProfileGuid;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
      public string szHwProfileName;
    }
  }
}
