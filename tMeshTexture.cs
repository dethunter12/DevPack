// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.tMeshTexture
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

namespace LcDevPack_TeamDamonA
{
  public struct tMeshTexture
  {
    public byte[] InternalName;
    public int Reserverd;

    public tMeshTexture(byte[] Name)
    {
            InternalName = Name;
            Reserverd = 0;
    }
  }
}
