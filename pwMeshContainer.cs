// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.pwMeshContainer
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

namespace LcDevPack_TeamDamonA
{
  public class pwMeshContainer
  {
    public pwHeaderInfo HeaderInfo { get; set; }

    public pwJoints[] Joints { get; set; }

    public pwMaterials[] Materials { get; set; }

    public pwObject[] Objects { get; set; }

    public pwTextures[] Textures { get; set; }
  }
}
