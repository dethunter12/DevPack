// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.pwObject
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

namespace LcDevPack_TeamDamonA
{
  public class pwObject
  {
    public pwBoneIndex[] BoneIndex { get; set; }

    public byte[] ExtraData { get; set; }

    public pwFaces[] Faces { get; set; }

    public int FaceVertsCount { get; set; }

    public int MaterialIndex { get; set; }

    public byte[] MeshName { get; set; }

    public pwNormal[] Normals { get; set; }

    public int TextureIndex { get; set; }

    public pwUV[] UVs { get; set; }

    public int VertexCount { get; set; }

    public pwVertexWeight[] VertexWeight { get; set; }

    public pwVertex[] Vertices { get; set; }
  }
}
