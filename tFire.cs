// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.tFire
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

namespace LcDevPack_TeamDamonA
{
  public class tFire
  {
    public float Delay0 { get; set; }

    public float Delay1 { get; set; }

    public float Delay2 { get; set; }

    public float Delay3 { get; set; }

    public byte DelayCount { get; set; }

    public string Effect0 { get; set; }

    public string Effect1 { get; set; }

    public string Effect2 { get; set; }

    public byte Object { get; set; }

    public float Speed { get; set; }

    public object Clone()
    {
      return MemberwiseClone();
    }
  }
}
