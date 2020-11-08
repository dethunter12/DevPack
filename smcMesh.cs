// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.smcMesh
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using System.Collections.Generic;

namespace LcDevPack_TeamDamonA
{
  public struct smcMesh
  {
    public string FileName;
    public List<smcObject> Object;

    public smcMesh(string FileName)
    {
      this.FileName = FileName;
            Object = new List<smcObject>();
    }
  }
}
