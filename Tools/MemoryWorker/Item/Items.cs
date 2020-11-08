using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker.Item
{
    internal class Items
    {
        public static string ISO = "ISO-8859-1";
        public static Bitmap Icon(object Item)
        {
            int ItemID = 0;
            int.TryParse(Item.ToString(), out ItemID);
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = ItemAll.ItemList.FindIndex((ItemContainer p) => p.ItemID.Equals(ItemID));
            if (num4 != -1)
            {
                num = ItemAll.ItemList[num4].TexID;
                num2 = ItemAll.ItemList[num4].TexRow;
                num3 = ItemAll.ItemList[num4].TexCol;
            }
            Image image = Image.FromFile("icons/ItemBtn" + num.ToString() + ".png");
            Bitmap bitmap = new Bitmap(32, 32);
            Graphics graphics = Graphics.FromImage(bitmap);
            int y = num2 * 32;
            int x = num3 * 32;
            Rectangle srcRect = new Rectangle(x, y, 64, 64);
            graphics.DrawImage(image, 0, 0, srcRect, GraphicsUnit.Pixel);
            graphics.Dispose();
            return bitmap;
        }

        public static Bitmap Icon(int ID, int Row, int Col)
        {
            Image image = Image.FromFile("icons/ItemBtn" + ID.ToString() + ".png");
            Bitmap bitmap = new Bitmap(32, 32);
            Graphics graphics = Graphics.FromImage(bitmap);
            int y = Row * 32;
            int x = Col * 32;
            Rectangle srcRect = new Rectangle(x, y, 64, 64);
            graphics.DrawImage(image, 0, 0, srcRect, GraphicsUnit.Pixel);
            graphics.Dispose();
            return bitmap;
        }

        public static string GetNameFromID(object ItemID)
        {
            int Item = -1;
            int.TryParse(ItemID.ToString(), out Item);
            string result = "";
            int num = ItemAll.ItemList.FindIndex((ItemContainer p) => p.ItemID.Equals(Item));
            if (num != -1)
            {
                result = ItemAll.ItemList[num].Name;
            }
            return result;
        }

        public static string GetTooltipText(int ItemID)
        {
            string result = "";
            int num = ItemAll.ItemList.FindIndex((ItemContainer p) => p.ItemID.Equals(ItemID));
            if (num != -1)
            {
                result = ItemAll.ItemList[num].Name + "\r\n\r\n" + ItemAll.ItemList[num].Description;
            }
            return result;
        }

        //TEST
        public static bool SaveFile(string FileName)
        {
            bool result;
            try
            {
                List<int> SortedIDs = new List<int>();
                for (int index = 0; index < ItemAll.ItemList.Count<ItemContainer>(); ++index)
                {
                    if (ItemAll.ItemList[index].EditFlag != 3)
                        SortedIDs.Add(ItemAll.ItemList[index].ItemID);
                }
                SortedIDs.Sort();
                MemoryStream memoryStream = new MemoryStream();
                BinaryWriter binaryWriter = new BinaryWriter((Stream)memoryStream);
                binaryWriter.Write(ItemAll.ItemList.Max<ItemContainer>((Func<ItemContainer, int>)(p => p.ItemID)));
                for (int a = 0; a < SortedIDs.Count<int>(); ++a)
                {
                    int num = ItemAll.ItemList.FindIndex((Predicate<ItemContainer>)(p => p.ItemID.Equals(SortedIDs[a])));
                    if (num != -1)
                    {
                            binaryWriter.Write(ItemAll.ItemList[num].ItemID);
                            binaryWriter.Write(ItemAll.ItemList[num].JobFlag);
                            binaryWriter.Write(ItemAll.ItemList[num].Weight);
                            binaryWriter.Write(ItemAll.ItemList[num].MaxUse);
                            binaryWriter.Write(ItemAll.ItemList[num].Level);
                            binaryWriter.Write(ItemAll.ItemList[num].Flag);
                            binaryWriter.Write(ItemAll.ItemList[num].Position);
                            binaryWriter.Write(ItemAll.ItemList[num].Type);
                            binaryWriter.Write(ItemAll.ItemList[num].SubType);
                            for (int j = 0; j < 10; j++)
                            {
                                binaryWriter.Write(ItemAll.ItemList[num].CraftItemID[j]);
                                binaryWriter.Write(ItemAll.ItemList[num].CraftItemAmount[j]);
                            }
                            binaryWriter.Write(ItemAll.ItemList[num].Need_SSkill1_Id);
                            binaryWriter.Write(ItemAll.ItemList[num].Need_SSkill1_Level);
                            binaryWriter.Write(ItemAll.ItemList[num].Need_SSkill2_Id);
                            binaryWriter.Write(ItemAll.ItemList[num].Need_SSkill2_Level);
                            binaryWriter.Write(ItemAll.ItemList[num].TexID);
                            binaryWriter.Write(ItemAll.ItemList[num].TexRow);
                            binaryWriter.Write(ItemAll.ItemList[num].TexCol);
                            binaryWriter.Write(ItemAll.ItemList[num].Num0);
                            binaryWriter.Write(ItemAll.ItemList[num].Num1);
                            binaryWriter.Write(ItemAll.ItemList[num].Num2);
                            binaryWriter.Write(ItemAll.ItemList[num].Num3);
                            binaryWriter.Write(ItemAll.ItemList[num].Price);
                            binaryWriter.Write(ItemAll.ItemList[num].Set1);
                            binaryWriter.Write(ItemAll.ItemList[num].Set2);
                            binaryWriter.Write(ItemAll.ItemList[num].Set3);
                            binaryWriter.Write(ItemAll.ItemList[num].Set4);
                            binaryWriter.Write(ItemAll.ItemList[num].Set5);          
                            //SMC
                            string str2 = ItemAll.ItemList[num].Smc;
                            byte[] buffer1 = new byte[64];
                            int length1 = str2.Length > 64 ? 64 : str2.Length;
                            Encoding.UTF8.GetBytes(str2.Substring(0, length1)).CopyTo((Array)buffer1, 0);
                            binaryWriter.Write(buffer1);
                            //EFFECT1
                            string str3 = ItemAll.ItemList[num].Effect1;
                            byte[] buffer3 = new byte[32];
                            int length3 = str3.Length > 32 ? 32 : str3.Length;
                            Encoding.UTF8.GetBytes(str3.Substring(0, length3)).CopyTo((Array)buffer3, 0);
                            binaryWriter.Write(buffer3);
                            //EFFECT2
                            string str4 = ItemAll.ItemList[num].Effect2;
                            byte[] buffer4 = new byte[32];
                            int length4 = str4.Length > 32 ? 32 : str4.Length;
                            Encoding.UTF8.GetBytes(str4.Substring(0, length4)).CopyTo((Array)buffer4, 0);
                            binaryWriter.Write(buffer4);
                            //EFFECT3
                            string str5 = ItemAll.ItemList[num].Effect3;
                            byte[] buffer5 = new byte[32];
                            int length5 = str5.Length > 32 ? 32 : str5.Length;
                            Encoding.UTF8.GetBytes(str5.Substring(0, length4)).CopyTo((Array)buffer5, 0);
                            binaryWriter.Write(buffer5);

                            binaryWriter.Write(ItemAll.ItemList[num].JewelOptionType);
                            binaryWriter.Write(ItemAll.ItemList[num].JewelOptionLevel);
                            for (int x = 0; x < 10; x++)
                            {
                                binaryWriter.Write(ItemAll.ItemList[num].rareOptionType[x]);
                            }
                            for (int y = 0; y < 10; y++)
                            {
                                binaryWriter.Write(ItemAll.ItemList[num].rareOptionChance[y]);
                            }
                            binaryWriter.Write(ItemAll.ItemList[num].syndicate_type);
                            binaryWriter.Write(ItemAll.ItemList[num].syndicate_grade);
                            binaryWriter.Write(ItemAll.ItemList[num].fortuneIndex);
                            binaryWriter.Write(ItemAll.ItemList[num].castleWar);                        
                    }
                }
                File.WriteAllBytes(FileName, memoryStream.ToArray());
                binaryWriter.Close();
                memoryStream.Close();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                result = false;
            }
            return result;
        }

        public static string[] SubTypes(int Type)
        {
            List<string> list = new List<string>();
            switch (Type)
            {
                case 0:
                    list.Add("IWEAPON_NIGHT");
                    list.Add("IWEAPON_CROSSBOW");
                    list.Add("IWEAPON_STAFF");
                    list.Add("IWEAPON_BIGSWORD");
                    list.Add("IWEAPON_AXE");
                    list.Add("IWEAPON_SHORTSTAFF");
                    list.Add("IWEAPON_BOW");
                    list.Add("IWEAPON_SHORTGUM");
                    list.Add("IWEAPON_MINING");
                    list.Add("IWEAPON_GATHERING");
                    list.Add("IWEAPON_CHARGE");
                    list.Add("IWEAPON_TWOSWORD");
                    list.Add("IWEAPON_WAND");
                    list.Add("IWEAPON_SCYTHE");
                    list.Add("IWEAPON_POLEARM");
                    list.Add("IWEAPON_SOUL");
                    break;
                case 1:
                    list.Add("IWEAR_HELMET");
                    list.Add("IWEAR_ARMOR");
                    list.Add("IWEAR_PANTS");
                    list.Add("IWEAR_GLOVE");
                    list.Add("IWEAR_SHOES");
                    list.Add("IWEAR_SHIELD");
                    list.Add("IWEAR_BACKWING");
                    list.Add("IWEAR_SUIT");
                    break;
                case 2:
                    list.Add("IONCE_WARP");
                    list.Add("IONCE_PROCESS_DOC");
                    list.Add("IONCE_MAKE_TYPE_DOC");
                    list.Add("IONCE_BOX");
                    list.Add("IONCE_MAKE_POTION_DOC");
                    list.Add("IONCE_CHANGE_DOC");
                    list.Add("IONCE_QUEST_SCROLL");
                    list.Add("IONCE_CASH");
                    list.Add("IONCE_SUMMON");
                    list.Add("IONCE_ETC");
                    list.Add("IONCE_TARGET");
                    list.Add("IONCE_TITLE");
                    list.Add("IONCE_REWARD_PACKAGE");
                    list.Add("IONCE_JUMPING_POTION");
                    list.Add("IONCE_EXTEND_CHARACTER_SLOT");
                    list.Add("IONCE_SERVER_TRANS");
                    list.Add("IONCE_REMOTE_EXPRESS");
                    break;
                case 3:
                    list.Add("ITEM_BULLET_ATTACK");
                    list.Add("ITEM_BULLET_MANA");
                    list.Add("ITEM_BULLET_ARROW");
                    break;
                case 4:
                    list.Add("IETC_QUEST");
                    list.Add("IETC_EVENT");
                    list.Add("IETC_SKILLUP");
                    list.Add("IETC_UPGRADE");
                    list.Add("IETC_MATERIAL");
                    list.Add("IETC_MONEY");
                    list.Add("IETC_PRODUCT");
                    list.Add("IETC_PROCESS");
                    list.Add("IETC_OPTION");
                    list.Add("IETC_SAMPLE");
                    list.Add("IETC_TEXTURE");
                    list.Add("IETC_MIX_TYPE1");
                    list.Add("IETC_MIX_TYPE2");
                    list.Add("IETC_MIX_TYPE3");
                    list.Add("IETC_PET_AI");
                    list.Add("IETC_QUEST_TRIGGER");
                    list.Add("IETC_JEWEL");
                    list.Add("IETC_STABILIZER");
                    list.Add("IETC_PROCESS_SCROLL");
                    list.Add("IETC_MONSTER_MERCENARY_CARD");
                    list.Add("IETC_GUILD_MARK");
                    list.Add("IETC_REFORMER");
                    list.Add("IETC_CHAOSJEWEL");
                    list.Add("IETC_FUNCTIONS");
                    break;
                case 5:
                    list.Add("IACCESSORY_CHARM");
                    list.Add("IACCESSORY_MAGICSTONE");
                    list.Add("IACCESSORY_LIGHTSTONE");
                    list.Add("IACCESSORY_EARING");
                    list.Add("IACCESSORY_RING");
                    list.Add("IACCESSORY_NECKLACE");
                    list.Add("IACCESSORY_PET");
                    list.Add("IACCESSORY_ATTACK_PET");
                    break;
                case 6:
                    list.Add("IPOTION_STATE");
                    list.Add("IPOTION_HP");
                    list.Add("IPOTION_MP");
                    list.Add("IPOTION_DUAL");
                    list.Add("IPOTION_STAT");
                    list.Add("IPOTION_ETC");
                    list.Add("IPOTION_UP");
                    list.Add("IPOTION_TEARS");
                    list.Add("IPOTION_CRYSTAL");
                    list.Add("IPOTION_NPC_PORTAL");
                    list.Add("IPOTION_HP_SPEEDUP");
                    list.Add("IPOTION_MP_SPEEDUP");
                    list.Add("IPOTION_PET_HP");
                    list.Add("IPOTION_PET_SPEEDUP");
                    break;
                default:
                    list.Add("");
                    break;
            }
            return list.ToArray();
        }

    }
}
