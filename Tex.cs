// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tex
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace LcDevPack_TeamDamonA
{
  public class Tex
  {
    public static tTexture lcTex;

    public static texFormat GetFormat()
    {
      texFormat texFormat = texFormat.UNKNOWN;
      if (Tex.lcTex.Header.Format == "FRMC")
        return (int) Tex.lcTex.Header.Bits == 4 || (int) Tex.lcTex.Header.Bits == 13 ? texFormat.DXT1 : texFormat.DXT3;
      if (!(Tex.lcTex.Header.Format == "FRMS"))
        return texFormat;
      return (int) Tex.lcTex.Header.Bits == 0 || (int) Tex.lcTex.Header.Bits == 2 ? texFormat.RGB : texFormat.ARGB;
    }

    public static Bitmap makeRGB(byte[] data2, int width, int height)
    {
      List<byte> source = new List<byte>();
      int index = 0;
      while (index < data2.Length)
      {
        source.Add(data2[index + 2]);
        source.Add(data2[index + 1]);
        source.Add(data2[index]);
        source.Add(byte.MaxValue);
        index += 4;
      }
      try
      {
        Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
        BitmapData bitmapdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, bitmap.PixelFormat);
        Marshal.Copy(source.ToArray(), 0, bitmapdata.Scan0, source.Count<byte>());
        bitmap.UnlockBits(bitmapdata);
        return bitmap;
      }
      catch
      {
        return new Bitmap(width, height);
      }
    }

    public static Bitmap makeRGB8(byte[] data2, int width, int height)
    {
      List<byte> source = new List<byte>();
      int index = 0;
      while (index < data2.Length)
      {
        source.Add(data2[index + 1]);
        source.Add(data2[index]);
        source.Add(data2[index + 2]);
        index += 3;
      }
      try
      {
        Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
        BitmapData bitmapdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, bitmap.PixelFormat);
        Marshal.Copy(source.ToArray(), 0, bitmapdata.Scan0, source.Count<byte>());
        bitmap.UnlockBits(bitmapdata);
        return bitmap;
      }
      catch
      {
        return new Bitmap(width, height);
      }
    }

    public static void ReadFile(string FileName)
    {
      ASCIIEncoding asciiEncoding = new ASCIIEncoding();
      FileStream fileStream = new FileStream(FileName, FileMode.Open);
      BinaryReader b = new BinaryReader((Stream) fileStream);
      Tex.lcTex = new tTexture();
      Tex.lcTex.Header = new tHeader();
      Tex.lcTex.Header.VersionChunk = b.ReadBytes(4);
      Tex.lcTex.Header.Version = b.ReadInt32();
      Tex.lcTex.Header.DataChunk = b.ReadBytes(4);
      Tex.lcTex.Header.Width = b.ReadUInt32() ^ 303316286U;
      Tex.lcTex.Header.Shift = b.ReadUInt32() ^ 1431797889U;
      Tex.lcTex.Header.Height = b.ReadUInt32() ^ 2560279492U;
      Tex.lcTex.Header.MipMap = b.ReadUInt32() ^ 3688695303U;
      Tex.lcTex.Header.Bits = b.ReadUInt32() ^ 505432394U;
      Tex.lcTex.Header.Unknown = b.ReadUInt32() ^ 1633913997U;
      Tex.lcTex.Header.Format = asciiEncoding.GetString(b.ReadBytes(4));
      Tex.lcTex.Header.AnimOffset = b.ReadInt32();
      Tex.lcTex.Header.Width = Tex.Shift(Tex.lcTex.Header.Width, Tex.lcTex.Header.Shift);
      Tex.lcTex.Header.Height = Tex.Shift(Tex.lcTex.Header.Height, Tex.lcTex.Header.Shift);
      if (Tex.lcTex.Header.Format == "FRMC")
        Tex.ReadFRMC(Tex.lcTex, b);
      else if (Tex.lcTex.Header.Format == "FRMS")
        Tex.ReadFRMS(Tex.lcTex, b);
      fileStream.Close();
    }

    private static void ReadFRMC(tTexture lcTex, BinaryReader b)
    {
      lcTex.imageData = new byte[(int) lcTex.Header.MipMap][];
      for (int index = 0; (long) index < (long) lcTex.Header.MipMap; ++index)
        lcTex.imageData[index] = b.ReadBytes(b.ReadInt32());
    }

    private static void ReadFRMS(tTexture lcTex, BinaryReader b)
    {
      int num = (int) lcTex.Header.Width * (int) lcTex.Header.Height;
      int count = (int) lcTex.Header.Bits == 0 || (int) lcTex.Header.Bits == 2 ? num * 3 : num * 4;
      lcTex.imageData = new byte[(int) lcTex.Header.MipMap][];
      for (int index = 0; (long) index < (long) lcTex.Header.MipMap; ++index)
        lcTex.imageData[index] = b.ReadBytes(count);
    }

    private static uint Shift(uint Val, uint Shifter)
    {
      Val >>= (int) Shifter;
      return Val;
    }
  }
}
