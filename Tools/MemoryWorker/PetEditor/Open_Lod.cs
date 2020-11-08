using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker.PetEditor
{
    public class Open_Lod
    {
        public string _ClientPath = LcDevPack_TeamDamonA.Tools.MobEditor.connection.ReadSettings("ClientPath");
        public static List<LcDevPack_TeamDamonA.Tools.MemoryWorker.Item.ItemContainer> ItemList = new List<LcDevPack_TeamDamonA.Tools.MemoryWorker.Item.ItemContainer>();

        internal static void ReadItem(string itemsource)
        {
            using (BinaryReader b = new BinaryReader(File.Open(itemsource, FileMode.Open)))
            {
                int totalid = b.ReadInt32();
                while (b.BaseStream.Position < b.BaseStream.Length)
                {
                    if (b.BaseStream.Length - 25L > b.BaseStream.Position)
                    {
                        LcDevPack_TeamDamonA.Tools.MemoryWorker.Item.ItemContainer itemContainer = new LcDevPack_TeamDamonA.Tools.MemoryWorker.Item.ItemContainer();
                        itemContainer.ItemID = b.ReadInt32();
                        itemContainer.JobFlag = b.ReadInt32();
                        itemContainer.Weight = b.ReadInt32();
                        itemContainer.MaxUse = b.ReadInt32();
                        itemContainer.Level = b.ReadInt32();
                        itemContainer.Flag = b.ReadInt64();
                        itemContainer.Position = b.ReadInt32();
                        itemContainer.Type = b.ReadInt32();
                        itemContainer.SubType = b.ReadInt32();
                        int[] array = new int[10];
                        int[] array2 = new int[10];
                        for (int i = 0; i < 10; i++)
                        {
                            array[i] = b.ReadInt32();
                            array2[i] = b.ReadInt32();
                        }
                        itemContainer.CraftItemID = array;
                        itemContainer.CraftItemAmount = array2;
                        itemContainer.Need_SSkill1_Id = b.ReadInt32();
                        itemContainer.Need_SSkill1_Level = b.ReadInt32();
                        itemContainer.Need_SSkill2_Id = b.ReadInt32();
                        itemContainer.Need_SSkill2_Level = b.ReadInt32();
                        itemContainer.TexID = b.ReadInt32();
                        itemContainer.TexRow = b.ReadInt32();
                        itemContainer.TexCol = b.ReadInt32();
                        itemContainer.Num0 = b.ReadInt32();
                        itemContainer.Num1 = b.ReadInt32();
                        itemContainer.Num2 = b.ReadInt32();
                        itemContainer.Num3 = b.ReadInt32();
                        itemContainer.Price = b.ReadInt32();
                        itemContainer.Set1 = b.ReadInt32();
                        itemContainer.Set2 = b.ReadInt32();
                        itemContainer.Set3 = b.ReadInt32();
                        itemContainer.Set4 = b.ReadInt32();
                        itemContainer.Set5 = b.ReadInt32();
                        itemContainer.Smc = Encoding.GetEncoding("ISO-8859-1").GetString(b.ReadBytes(64));
                        itemContainer.Effect1 = Encoding.GetEncoding("ISO-8859-1").GetString(b.ReadBytes(32));
                        itemContainer.Effect2 = Encoding.GetEncoding("ISO-8859-1").GetString(b.ReadBytes(32));
                        itemContainer.Effect3 = Encoding.GetEncoding("ISO-8859-1").GetString(b.ReadBytes(32));
                        itemContainer.JewelOptionType = b.ReadInt32();
                        itemContainer.JewelOptionLevel = b.ReadInt32();
                        int[] array3 = new int[10];
                        int[] array4 = new int[10];
                        for (int x = 0; x < 10; x++)
                        {
                            array3[x] = b.ReadInt32();

                        }
                        for (int y = 0; y < 10; y++)
                        {
                            array4[y] = b.ReadInt32();
                        }
                        itemContainer.rareOptionType = array3;
                        itemContainer.rareOptionChance = array4;
                        itemContainer.syndicate_type = b.ReadInt32();
                        itemContainer.syndicate_grade = b.ReadInt32();
                        itemContainer.fortuneIndex = b.ReadInt32();
                        itemContainer.castleWar = b.ReadByte();
                        ItemList.Add(itemContainer);
                    }
                    else
                    {
                        b.BaseStream.Position = b.BaseStream.Length;
                    }
                }
            }
        }

        internal static void ReadItemName(string itemnamesource)
        {
            using (BinaryReader b = new BinaryReader(File.Open(itemnamesource, FileMode.Open)))
            {
                int lastid = b.ReadInt32();
                int lastid2 = b.ReadInt32();
                while (b.BaseStream.Position < b.BaseStream.Length)
                {
                    int ID = b.ReadInt32();
                    int it = ItemList.FindIndex(p => p.ItemID.Equals(ID));
                    string name = Encoding.GetEncoding("ISO-8859-1").GetString(b.ReadBytes(b.ReadInt32()));
                    string desc = Encoding.GetEncoding("ISO-8859-1").GetString(b.ReadBytes(b.ReadInt32()));
                    if (it != -1)
                    {
                        ItemList[it].Name = name;
                        ItemList[it].Description = desc;
                    }
                }
                b.Close();
                b.Dispose();
            }
        }

    }
}
