// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.SMCReader
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LcDevPack_TeamDamonA
{
  public class SMCReader
  {
    public static List<smcMesh> ReadFile(string FileName)
    {
      string[] strArray1 = Path.GetDirectoryName(FileName).Split('\\');
      string str = "";
      bool flag = true;
      for (int index = 0; index < (strArray1).Count<string>(); ++index)
      {
        if (strArray1[index].ToUpper() == "DATA")
          flag = false;
        if (flag)
          str = str + strArray1[index] + "\\";
      }
      List<string> list = ( File.ReadAllLines(FileName)).ToList<string>();
      for (int index = list.Count<string>() - 1; index >= 0; --index)
      {
        list[index] = list[index].Trim();
        list[index] = list[index].Replace("TFNM", "");
        if (list[index].Contains("{") || list[index].Contains("}") || (list[index].Contains(",") || list[index].Contains("NAME")) || (list[index].Contains("COLISION") || list[index].Contains("TEXTURES") || (list[index].Contains("ANIM") || list[index].Contains("SKELETON"))) || list[index].Contains("_TAG"))
          list.RemoveAt(index);
      }
      int index1 = -1;
      List<smcMesh> smcMeshList = new List<smcMesh>();
      for (int index2 = 0; index2 < list.Count<string>(); ++index2)
      {
        if (list[index2].Substring(0, 4) == "MESH")
        {
          ++index1;
          string[] strArray2 = list[index2].Split('"');
          smcMeshList.Add(new smcMesh(str + strArray2[1]));
        }
        else
        {
          string[] strArray2 = list[index2].Split('"');
          smcMeshList[index1].Object.Add(new smcObject(strArray2[1], str + strArray2[3]));
        }
      }
      return smcMeshList;
    }
  }
}
