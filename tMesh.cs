// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.tMesh
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using SlimDX.Direct3D9;

namespace LcDevPack_TeamDamonA
{
  public class tMesh
  {
    public Mesh MeshData;
    public Texture TexData;

    public tMesh(Mesh mesh, Texture texture)
    {
            MeshData = mesh;
            TexData = texture;
    }
  }
}
