// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.tMeshObject
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using System.Collections.Generic;
using System.Linq;

namespace LcDevPack_TeamDamonA
{
  public class tMeshObject
  {
    public uint FaceCount { get; set; }

    public tFace[] Faces { get; set; }

    public uint FromVert { get; set; }

    public byte[] JData { get; set; }

    public uint JValue { get; set; }

    public byte[] MaterialName { get; set; }

    public tMeshShaderData ShaderData { get; set; }

    public uint ShaderFlag { get; set; }

    public tMeshShaderInfo ShaderInfo { get; set; }

    public tMeshTexture[] Textures { get; set; }

    public uint ToVert { get; set; }

    public uint Value1 { get; set; }

    public short[] GetFaces()
    {
      List<short> shortList = new List<short>();
      for (int index = 0; index < ((IEnumerable<tFace>)Faces).Count<tFace>(); ++index)
      {
        shortList.Add(Faces[index].A);
        shortList.Add(Faces[index].B);
        shortList.Add(Faces[index].C);
      }
      return shortList.ToArray();
    }
  }
}
