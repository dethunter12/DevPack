// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.MessageHandle
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using System.Windows.Forms;

namespace LcDevPack_TeamDamonA
{
  public class MessageHandle
  {
    public void SuccessFileMessage()
    {
      int num = (int) MessageBox.Show("Your file success saved!", "Success");
    }

    public void FailedFileMessage()
    {
      int num = (int) MessageBox.Show("Your file can't saved!", "Failed");
    }

    public void WelcomeMessage()
    {
      int num = (int) MessageBox.Show("This program use the ExportLod DLL by DamonA.", "Welcome devloper!");
    }
  }
}
