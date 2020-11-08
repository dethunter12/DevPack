using SlimDX;
using SlimDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker.Item
{
    public partial class ItemAll : Form
    {
        public ItemAll()
        {
            InitializeComponent();
        }
        private Direct3D mD3d;
        public static List<ItemContainer> ItemList = new List<ItemContainer>();
        public static Connection connection = new Connection();
        private string Host = ItemAll.connection.ReadSettings("Host");
        private string User = ItemAll.connection.ReadSettings("User");
        private string Password = ItemAll.connection.ReadSettings("Password");
        private string Database = ItemAll.connection.ReadSettings("Database");
        private DatabaseHandle databaseHandle = new DatabaseHandle();
        private ExportLodHandle exportLodHandle = new ExportLodHandle();
        public string _ClientPath = LcDevPack_TeamDamonA.Tools.MobEditor.connection.ReadSettings("ClientPath");
        private bool CaptureChanges;
        private Device device;
        private ASCIIEncoding Enc = new ASCIIEncoding();
        private float zoom;
        private List<tMesh> models;
        private float rotation;
        private float leftright;
        private float updown = -0.9f;
        private void InitializeDevice()
        {
            this.mD3d = new Direct3D();
            PresentParameters presentParameters = new PresentParameters
            {
                SwapEffect = SwapEffect.Discard,
                DeviceWindowHandle = this.panel3DView.Handle,
                Windowed = true,
                BackBufferWidth = this.panel3DView.Width,
                BackBufferHeight = this.panel3DView.Height,
                BackBufferFormat = Format.A8R8G8B8
            };
            this.device = new Device(this.mD3d, 0, DeviceType.Hardware, base.Handle, CreateFlags.SoftwareVertexProcessing, new PresentParameters[]
            {
                presentParameters
            });
            this.device.SetRenderState<Cull>(RenderState.CullMode, Cull.None);
            this.device.SetRenderState<FillMode>(RenderState.FillMode, FillMode.Solid);
            this.device.SetRenderState(RenderState.Lighting, false);
            this.CameraPositioning();
        }
        public static string OpenedFile;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Abrir itemAll.lod";
            openFile.InitialDirectory = _ClientPath;
            openFile.Filter = "itemAll.lod|itemAll.lod|All|*.*";
            if (openFile.ShowDialog() != DialogResult.Cancel)
            {
                OpenFileDialog openFile2 = new OpenFileDialog();
                openFile2.Title = "Abrir strItem_br.lod";
                openFile2.InitialDirectory = "";
                openFile2.Filter = "strItem_*.lod|strItem_*.lod|All|*.*";
                if (openFile2.ShowDialog() != DialogResult.Cancel)
                {
                    ItemList.Clear();
                    ItemListBox.Items.Clear();
                    ReadItem(openFile.FileName);
                    OpenedFile = openFile.FileName;
                    ReadItemName(openFile2.FileName);
                    makelist();
                    tabControl2.Enabled = true;
                }
            }
        }

        private void ReadItem(string itemsource)
        {
            using (BinaryReader b = new BinaryReader(File.Open(itemsource, FileMode.Open)))
            {
                int totalid = b.ReadInt32();
                while (b.BaseStream.Position < b.BaseStream.Length)
                {
                    if (b.BaseStream.Length - 25L > b.BaseStream.Position)
                    {
                        ItemContainer itemContainer = new ItemContainer();
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

        private void ReadItemName(string itemnamesource)
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

        private void makelist()
        {
            ItemList.OrderBy(x => x.ItemID);
            List<ItemContainer> newList = ItemList.OrderBy(o => o.ItemID).ToList();
            int sk = newList.Count();
            for (int i = 0; i < sk; i++)
            {
                int ID = newList[i].ItemID;
                string Name = newList[i].Name;
                string lv = newList[i].Level.ToString();
                ItemListBox.Items.Add(ID + " - " + Name + " (Lv " + lv + ")");
                
            }
            this.status.Text = "Found " + ItemList.Count + " items";
        }

        private void ItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.ViewItem();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            makelist();
        }

        public int GetIDFromList()
        {
            int result;
            try
            {
                result = Convert.ToInt32(this.ItemListBox.Text.Split(new char[]
                {
                    ' '
                })[0]);
            }
            catch
            {
                result = 2;
            }
            return result;
        }

        public void ViewItem()
        {

            this.CaptureChanges = false;
            int ID = this.GetIDFromList();
            int num = ItemList.FindIndex((ItemContainer p) => p.ItemID.Equals(ID));
            if (num == -1)
            {
                new CustomMessage("Cannot find ItemID " + ID).Show();
                return;
            }
            this.t_ItemID.Text = ItemList[num].ItemID.ToString();
            this.t_ItemName.Text = ItemList[num].Name;
            this.t_Description.Text = ItemList[num].Description;
            this.t_SMC.Text = ItemList[num].Smc;
            this.t_IconID.Text = ItemList[num].TexID.ToString();
            this.t_IconRow.Text = ItemList[num].TexRow.ToString();
            this.t_IconColumn.Text = ItemList[num].TexCol.ToString();
            this.t_EffectNormal.Text = ItemList[num].Effect1;
            this.t_EffectAttack.Text = ItemList[num].Effect2;
            this.t_EffectDamage.Text = ItemList[num].Effect3;
            this.t_Num0.Text = ItemList[num].Num0.ToString();
            this.t_Num1.Text = ItemList[num].Num1.ToString();
            this.t_Num2.Text = ItemList[num].Num2.ToString();
            this.t_Num3.Text = ItemList[num].Num3.ToString();
            this.t_Level.Text = ItemList[num].Level.ToString();
            this.t_Weight.Text = ItemList[num].Weight.ToString();
            this.t_Price.Text = ItemList[num].Price.ToString();
            this.t_Set1.Text = ItemList[num].Set1.ToString();
            this.t_Set2.Text = ItemList[num].Set2.ToString();
            this.t_Set3.Text = ItemList[num].Set3.ToString();
            this.t_Set4.Text = ItemList[num].Set4.ToString();
            this.t_Set5.Text = ItemList[num].Set5.ToString();
            this.t_Type.Text = ItemList[num].Type.ToString();
            this.t_SubType.Text = ItemList[num].SubType.ToString();
            this.t_Class.Text = ItemList[num].JobFlag.ToString();
            this.t_WearingPos.Text = ItemList[num].Position.ToString();
            this.t_Flag.Text = ItemList[num].Flag.ToString();
            this.t_maxuse.Text = ItemList[num].MaxUse.ToString();
            this.t_RareOptionID.Text = ItemList[num].RareOption.ToString();
            this.t_RareOptionRate.Text = ItemList[num].RareChance.ToString();
            this.t_CraftSkill1ID.Text = ItemList[num].Need_SSkill1_Id.ToString();
            this.t_CraftSkill1Level.Text = ItemList[num].Need_SSkill1_Level.ToString();
            this.t_CraftSkill2ID.Text = ItemList[num].Need_SSkill2_Id.ToString();
            this.t_CraftSkill2Level.Text = ItemList[num].Need_SSkill2_Level.ToString();
            this.t_CraftItemID1.Text = ItemList[num].CraftItemID[0].ToString();
            this.t_CraftItemAmount1.Text = ItemList[num].CraftItemAmount[0].ToString();
            this.t_CraftItemID2.Text = ItemList[num].CraftItemID[1].ToString();
            this.t_CraftItemAmount2.Text = ItemList[num].CraftItemAmount[1].ToString();
            this.t_CraftItemID3.Text = ItemList[num].CraftItemID[2].ToString();
            this.t_CraftItemAmount3.Text = ItemList[num].CraftItemAmount[2].ToString();
            this.t_CraftItemID4.Text = ItemList[num].CraftItemID[3].ToString();
            this.t_CraftItemAmount4.Text = ItemList[num].CraftItemAmount[3].ToString();
            this.t_CraftItemID5.Text = ItemList[num].CraftItemID[4].ToString();
            this.t_CraftItemAmount5.Text = ItemList[num].CraftItemAmount[4].ToString();
            this.t_CraftItemID6.Text = ItemList[num].CraftItemID[5].ToString();
            this.t_CraftItemAmount6.Text = ItemList[num].CraftItemAmount[5].ToString();
            this.t_CraftItemID7.Text = ItemList[num].CraftItemID[6].ToString();
            this.t_CraftItemAmount7.Text = ItemList[num].CraftItemAmount[6].ToString();
            this.t_CraftItemID8.Text = ItemList[num].CraftItemID[7].ToString();
            this.t_CraftItemAmount8.Text = ItemList[num].CraftItemAmount[7].ToString();
            this.t_CraftItemID9.Text = ItemList[num].CraftItemID[8].ToString();
            this.t_CraftItemAmount9.Text = ItemList[num].CraftItemAmount[8].ToString();
            this.t_CraftItemID10.Text = ItemList[num].CraftItemID[9].ToString();
            this.t_CraftItemAmount10.Text = ItemList[num].CraftItemAmount[9].ToString();
            //this.dgFortune.Rows.Clear();
            //if (Items.ItemList[num].FortuneData != null)
            //{
            //	foreach (FortuneContainer current in Items.ItemList[num].FortuneData)
            //	{
            //		this.dgFortune.Rows.Add(new object[]
            //		{
            //			current.SkillID,
            //			current.SkillLevel,
            //			current.StringID,
            //			current.Prob
            //		});
            //	}
            //}
            this.BuildCraftGrid();
            this.CaptureChanges = true;
            string str = Path.GetDirectoryName(OpenedFile).Replace("Data", "").Replace("data", "");
            if (this.chk3D.Checked && File.Exists(str + this.t_SMC.Text))
            {
                this.models = new List<tMesh>();
                int jobFlag = ItemList[num].JobFlag;
                if (jobFlag <= 32)
                {
                    if (jobFlag <= 8)
                    {
                        switch (jobFlag)
                        {
                            case 1:
                                this.MakeLCModels(str + "Data\\Character\\Titan\\ti.smc");
                                break;
                            case 2:
                                this.MakeLCModels(str + "Data\\Character\\Knight\\ni.smc");
                                break;
                            case 3:
                                break;
                            case 4:
                                this.MakeLCModels(str + "Data\\Character\\Healer\\hw.smc");
                                break;
                            default:
                                if (jobFlag == 8)
                                {
                                    this.MakeLCModels(str + "Data\\Character\\Mage\\ma.smc");
                                }
                                break;
                        }
                    }
                    else if (jobFlag != 16)
                    {
                        if (jobFlag == 32)
                        {
                            this.MakeLCModels(str + "Data\\Character\\Sorcerer\\so.smc");
                        }
                    }
                    else
                    {
                        this.MakeLCModels(str + "Data\\Character\\Rogue\\ro.smc");
                    }
                }
                else if (jobFlag <= 128)
                {
                    if (jobFlag != 64)
                    {
                        if (jobFlag == 128)
                        {
                            this.MakeLCModels(str + "Data\\Character\\Rogue\\ro.smc");
                        }
                    }
                    else
                    {
                        this.MakeLCModels(str + "Data\\Character\\NightShadow\\ns.smc");
                    }
                }
                else if (jobFlag != 144)
                {
                    if (jobFlag != 256)
                    {
                        if (jobFlag == 264)
                        {
                            this.MakeLCModels(str + "Data\\Character\\Mage\\ma.smc");
                        }
                    }
                    else
                    {
                        this.MakeLCModels(str + "Data\\Character\\Mage\\ma.smc");
                    }
                }
                else
                {
                    this.MakeLCModels(str + "Data\\Character\\Rogue\\ro.smc");
                }
                this.MakeLCModels(str + this.t_SMC.Text);
            }
        }

        private void MakeLCModels(string SMCFile)
        {
            int num = -1;
            int ID = this.GetIDFromList();
            int num2 = ItemList.FindIndex((ItemContainer p) => p.ItemID.Equals(ID));
            if (num2 != -1)
            {
                int arg_42_0 = ItemList[num2].JobFlag;
                num = ItemList[num2].Position;
            }
            try
            {
                List<smcMesh> list = SMCReader.ReadFile(SMCFile);
                for (int i = 0; i < list.Count<smcMesh>(); i++)
                {
                    bool flag = (num != 0 || !list[i].FileName.Contains("_hair_000")) && (num != 1 || !list[i].FileName.Contains("_bu_000")) && (num != 3 || !list[i].FileName.Contains("_bd_000")) && (num != 5 || !list[i].FileName.Contains("_hn_000")) && (num != 6 || !list[i].FileName.Contains("_ft_000"));
                    if (flag && LCMeshReader.ReadFile(list[i].FileName))
                    {
                        tMeshContainer pMesh = LCMeshReader.pMesh;
                        for (int j = 0; j < pMesh.Objects.Count<tMeshObject>(); j++)
                        {
                            int toVert = (int)pMesh.Objects[j].ToVert;
                            uint arg_16B_0 = pMesh.Objects[j].FaceCount;
                            short[] faces = pMesh.Objects[j].GetFaces();
                            CustomVertex.PositionNormalTextured[] array = new CustomVertex.PositionNormalTextured[toVert];
                            int num3 = (int)pMesh.Objects[j].FromVert;
                            int k = 0;
                            while ((long)k < (long)((ulong)pMesh.Objects[j].ToVert))
                            {
                                array[k].Position = new Vector3(pMesh.Vertices[num3].X, pMesh.Vertices[num3].Y, pMesh.Vertices[num3].Z);
                                array[k].Normal = new Vector3(pMesh.Normals[num3].X, pMesh.Normals[num3].Y, pMesh.Normals[num3].Z);
                                try
                                {
                                    array[k].Texture = new Vector2(pMesh.UVMaps[0].Coords[num3].U, pMesh.UVMaps[0].Coords[num3].V);
                                }
                                catch
                                {
                                    array[k].Texture = new Vector2(0f, 0f);
                                }
                                num3++;
                                k++;
                            }
                            new VertexBuffer(this.device, array.Count<CustomVertex.PositionNormalTextured>() * 32, Usage.None, VertexFormat.Position | VertexFormat.Texture1 | VertexFormat.Normal, Pool.Default);
                            Mesh mesh = new Mesh(this.device, faces.Count<short>() / 3, array.Count<CustomVertex.PositionNormalTextured>(), MeshFlags.Managed, VertexFormat.Position | VertexFormat.Texture1 | VertexFormat.Normal);
                            DataStream dataStream2;
                            DataStream dataStream = dataStream2 = mesh.VertexBuffer.Lock(0, array.Count<CustomVertex.PositionNormalTextured>() * 32, LockFlags.None);
                            try
                            {
                                dataStream.WriteRange<CustomVertex.PositionNormalTextured>(array);
                                mesh.VertexBuffer.Unlock();
                            }
                            finally
                            {
                                if (dataStream2 != null)
                                {
                                    ((IDisposable)dataStream2).Dispose();
                                }
                            }
                            DataStream dataStream3;
                            dataStream = (dataStream3 = mesh.IndexBuffer.Lock(0, faces.Count<short>() * 2, LockFlags.None));
                            try
                            {
                                dataStream.WriteRange<short>(faces);
                                mesh.IndexBuffer.Unlock();
                            }
                            finally
                            {
                                if (dataStream3 != null)
                                {
                                    ((IDisposable)dataStream3).Dispose();
                                }
                            }
                            if (pMesh.Weights.Count<tMeshJointWeights>() != 0)
                            {
                                string[] array2 = new string[pMesh.Weights.Count<tMeshJointWeights>()];
                                List<int>[] array3 = new List<int>[pMesh.Weights.Count<tMeshJointWeights>()];
                                List<float>[] array4 = new List<float>[pMesh.Weights.Count<tMeshJointWeights>()];
                                for (int l = 0; l < pMesh.Weights.Count<tMeshJointWeights>(); l++)
                                {
                                    array2[l] = this.Enc.GetString(pMesh.Weights[l].JointName);
                                    array3[l] = new List<int>();
                                    array4[l] = new List<float>();
                                    for (int m = 0; m < pMesh.Weights[l].WeightsMap.Count<tMeshWeightsMap>(); m++)
                                    {
                                        array3[l].Add(pMesh.Weights[l].WeightsMap[m].Index);
                                        array4[l].Add(pMesh.Weights[l].WeightsMap[m].Weight);
                                    }
                                }
                                mesh.SkinInfo = new SkinInfo(array.Count<CustomVertex.PositionNormalTextured>(), VertexFormat.Position | VertexFormat.Texture1 | VertexFormat.Normal, (int)pMesh.HeaderInfo.JointCount);
                                for (k = 0; k < array3.Count<List<int>>(); k++)
                                {
                                    mesh.SkinInfo.SetBoneName(k, array2[k]);
                                    mesh.SkinInfo.SetBoneInfluence(k, array3[k].ToArray(), array4[k].ToArray());
                                }
                            }
                            mesh.GenerateAdjacency(0.5f);
                            mesh.ComputeNormals();
                            Texture texture = null;
                            string objName = this.Enc.GetString(pMesh.Objects[j].Textures[0].InternalName);
                            int num4 = list[i].Object.FindIndex((smcObject x) => x.Name.Equals(objName));
                            if (num4 != -1)
                            {
                                texture = this.GetTextureFromFile(list[i].Object[num4].Texture);
                            }
                            this.models.Add(new tMesh(mesh, texture));
                        }
                    }
                }
            }
            catch
            {
            }
            this.zoom = 4f;
        }

        private Texture GetTextureFromFile(string FileName)
        {
            Texture result = null;
            if (File.Exists(FileName))
            {
                Tex.ReadFile(FileName);
                Format imageFormat = this.ConvFormat(Tex.GetFormat());
                result = this.BuildTexture(Tex.lcTex.imageData[0], imageFormat, (int)Tex.lcTex.Header.Width, (int)Tex.lcTex.Header.Height);
            }
            return result;
        }

        private Texture BuildTexture(byte[] imageData, Format imageFormat, int width, int height)
        {
            Texture texture = null;
            if (imageFormat == Format.R8G8B8)
            {
                MemoryStream memoryStream2;
                MemoryStream memoryStream = memoryStream2 = new MemoryStream();
                try
                {
                    Tex.makeRGB8(imageData, width, height).Save(memoryStream, ImageFormat.Bmp);
                    memoryStream.Write(imageData, 0, imageData.Length);
                    memoryStream.Position = 0L;
                    Texture result = Texture.FromStream(this.device, memoryStream, width, height, 0, Usage.SoftwareProcessing, Format.A8B8G8R8, Pool.Default, Filter.None, Filter.None, 0);
                    return result;
                }
                finally
                {
                    if (memoryStream2 != null)
                    {
                        ((IDisposable)memoryStream2).Dispose();
                    }
                }
            }
            if (imageFormat == Format.A8R8G8B8)
            {
                MemoryStream memoryStream3;
                MemoryStream memoryStream = memoryStream3 = new MemoryStream();
                try
                {
                    Tex.makeRGB(imageData, width, height).Save(memoryStream, ImageFormat.Bmp);
                    memoryStream.Write(imageData, 0, imageData.Length);
                    memoryStream.Position = 0L;
                    Texture result = Texture.FromStream(this.device, memoryStream, width, height, 0, Usage.SoftwareProcessing, Format.A8B8G8R8, Pool.Default, Filter.None, Filter.None, 0);
                    return result;
                }
                finally
                {
                    if (memoryStream3 != null)
                    {
                        ((IDisposable)memoryStream3).Dispose();
                    }
                }
            }
            texture = new Texture(this.device, width, height, 0, Usage.None, imageFormat, Pool.Managed);
            using (Stream data = texture.LockRectangle(0, LockFlags.None).Data)
            {
                data.Write(imageData, 0, imageData.Count<byte>());
                texture.UnlockRectangle(0);
            }
            return texture;
        }

        private Format ConvFormat(texFormat tFormat)
        {
            Format result = Format.Unknown;
            switch (tFormat)
            {
                case texFormat.RGB:
                    return Format.R8G8B8;
                case texFormat.ARGB:
                    return Format.A8R8G8B8;
                case texFormat.DXT1:
                    return Format.Dxt1;
                case texFormat.DXT3:
                    return Format.Dxt3;
                default:
                    return result;
            }
        }

        public void BuildCraftGrid()
        {
            this.CraftGrid.Rows.Clear();
            if (Convert.ToInt32(this.t_CraftItemID1.Text) != -1)
            {
                this.CraftGrid.Rows.Add(new object[]
                {
                    Items.Icon(this.t_CraftItemID1.Text),
                    this.t_CraftItemID1.Text,
                    Items.GetNameFromID(this.t_CraftItemID1.Text),
                    this.t_CraftItemAmount1.Text
                });
            }
            if (Convert.ToInt32(this.t_CraftItemID2.Text) != -1)
            {
                this.CraftGrid.Rows.Add(new object[]
                {
                    Items.Icon(this.t_CraftItemID2.Text),
                    this.t_CraftItemID2.Text,
                    Items.GetNameFromID(this.t_CraftItemID2.Text),
                    this.t_CraftItemAmount2.Text
                });
            }
            if (Convert.ToInt32(this.t_CraftItemID3.Text) != -1)
            {
                this.CraftGrid.Rows.Add(new object[]
                {
                    Items.Icon(this.t_CraftItemID3.Text),
                    this.t_CraftItemID3.Text,
                    Items.GetNameFromID(this.t_CraftItemID3.Text),
                    this.t_CraftItemAmount3.Text
                });
            }
            if (Convert.ToInt32(this.t_CraftItemID4.Text) != -1)
            {
                this.CraftGrid.Rows.Add(new object[]
                {
                    Items.Icon(this.t_CraftItemID4.Text),
                    this.t_CraftItemID4.Text,
                    Items.GetNameFromID(this.t_CraftItemID4.Text),
                    this.t_CraftItemAmount4.Text
                });
            }
            if (Convert.ToInt32(this.t_CraftItemID5.Text) != -1)
            {
                this.CraftGrid.Rows.Add(new object[]
                {
                    Items.Icon(this.t_CraftItemID5.Text),
                    this.t_CraftItemID5.Text,
                    Items.GetNameFromID(this.t_CraftItemID5.Text),
                    this.t_CraftItemAmount5.Text
                });
            }
            if (Convert.ToInt32(this.t_CraftItemID6.Text) != -1)
            {
                this.CraftGrid.Rows.Add(new object[]
                {
                    Items.Icon(this.t_CraftItemID6.Text),
                    this.t_CraftItemID6.Text,
                    Items.GetNameFromID(this.t_CraftItemID6.Text),
                    this.t_CraftItemAmount6.Text
                });
            }
            if (Convert.ToInt32(this.t_CraftItemID7.Text) != -1)
            {
                this.CraftGrid.Rows.Add(new object[]
                {
                    Items.Icon(this.t_CraftItemID7.Text),
                    this.t_CraftItemID7.Text,
                    Items.GetNameFromID(this.t_CraftItemID7.Text),
                    this.t_CraftItemAmount7.Text
                });
            }
            if (Convert.ToInt32(this.t_CraftItemID8.Text) != -1)
            {
                this.CraftGrid.Rows.Add(new object[]
                {
                    Items.Icon(this.t_CraftItemID8.Text),
                    this.t_CraftItemID8.Text,
                    Items.GetNameFromID(this.t_CraftItemID8.Text),
                    this.t_CraftItemAmount8.Text
                });
            }
            if (Convert.ToInt32(this.t_CraftItemID9.Text) != -1)
            {
                this.CraftGrid.Rows.Add(new object[]
                {
                    Items.Icon(this.t_CraftItemID9.Text),
                    this.t_CraftItemID9.Text,
                    Items.GetNameFromID(this.t_CraftItemID9.Text),
                    this.t_CraftItemAmount9.Text
                });
            }
            if (Convert.ToInt32(this.t_CraftItemID10.Text) != -1)
            {
                this.CraftGrid.Rows.Add(new object[]
                {
                    Items.Icon(this.t_CraftItemID10.Text),
                    this.t_CraftItemID10.Text,
                    Items.GetNameFromID(this.t_CraftItemID10.Text),
                    this.t_CraftItemAmount10.Text
                });
            }
        }

        private void chk3D_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk3D.Checked)
            {
                this.panel3DView.Visible = true;
                return;
            }
            this.panel3DView.Visible = false;
        }

        private void CameraPositioning()
        {
            this.device.SetTransform(TransformState.Projection, Matrix.PerspectiveFovLH(100f, 1f, 1f, 450f));
            this.device.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0f, 0f, -5f), new Vector3(0f, 0f, 0f), new Vector3(0f, 1f, 0f)));
            this.device.SetTransform(TransformState.World, Matrix.RotationYawPitchRoll(0f, 0f, 0f));
        }

        private void ItemAll_Load(object sender, EventArgs e)
        {
            InitializeDevice();
        }

        private void Render()
        {
            Viewport viewport = new Viewport(0, 0, this.panel3DView.Width, this.panel3DView.Height);
            this.device.Viewport = viewport;
            this.device.Clear(ClearFlags.ZBuffer | ClearFlags.Target, new Color4(Color.FromKnownColor(KnownColor.Control)), 1f, 0);
            this.device.BeginScene();
            this.device.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0f, 0f, this.zoom), new Vector3(this.leftright, this.updown, 0f), new Vector3(0f, 1f, 0f)));
            this.device.SetTransform(TransformState.World, Matrix.RotationYawPitchRoll(this.rotation, 3.1f, 0f));
            if (this.models != null && this.models.Count<tMesh>() != 0)
            {
                for (int i = 0; i < this.models.Count<tMesh>(); i++)
                {
                    if (this.models[i].TexData != null)
                    {
                        this.device.SetTexture(0, this.models[i].TexData);
                    }
                    for (int j = 0; j < 1000; j++)
                    {
                        this.models[i].MeshData.DrawSubset(j);
                    }
                }
            }
            this.device.EndScene();
            this.device.Present();
            this.rotation -= 0.03f;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Render();
            Application.DoEvents();
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            if (this.CaptureChanges)
            {
                if (sender is TextBox)
                {
                    (sender as TextBox).BackColor = Color.FromArgb(224, 255, 168);
                }
                if (sender is ComboBox)
                {
                    (sender as ComboBox).BackColor = Color.FromArgb(224, 255, 168);
                }
                if (sender is DataGrid)
                {
                    (sender as DataGrid).BackColor = Color.FromArgb(224, 255, 168);
                }
                this.ModPanel.Visible = true;
                this.menuStrip1.Enabled = false;
            }
        }

        private void slideZoom_Scroll(object sender, EventArgs e)
        {
            this.zoom = (float)this.slideZoom.Value / 100f;
        }

        private void slideUpDown_Scroll(object sender, EventArgs e)
        {
            this.updown = (float)this.slideUpDown.Value / 1000f;
        }

        private void slideLeftRight_Scroll(object sender, EventArgs e)
        {
            this.leftright = (float)this.slideLeftRight.Value / 1000f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = Path.GetDirectoryName(OpenedFile).Replace("Data", "").Replace("data", "") + this.t_SMC.Text;
            if (File.Exists(text))
            {
                new TextEditor(text).Show();
                return;
            }
            new CustomMessage("File not found").Show();
        }

        public void ShowItemIcon()
        {
            try
            {
                this.t_Icon.Image = Items.Icon(Convert.ToInt32(this.t_IconID.Text), Convert.ToInt32(this.t_IconRow.Text), Convert.ToInt32(this.t_IconColumn.Text));
            }
            catch
            {
            }
        }

        private void t_IconID_TextChanged(object sender, EventArgs e)
        {
            this.ShowItemIcon();
            this.ValueChanged(sender, e);
        }

        private void t_IconRow_TextChanged(object sender, EventArgs e)
        {
            this.ShowItemIcon();
            this.ValueChanged(sender, e);
        }

        private void t_IconColumn_TextChanged(object sender, EventArgs e)
        {
            this.ShowItemIcon();
            this.ValueChanged(sender, e);
        }

        private void t_Type_TextChanged(object sender, EventArgs e)
        {
            this.SetTypeCombo();
            this.SetSubTypeCombo();
            this.ValueChanged(sender, e);
        }

        public void SetTypeCombo()
        {
            int num = -1;
            int.TryParse(this.t_Type.Text, out num);
            if (num > -1 && num < 7)
            {
                this.t_TypeCombo.SelectedIndex = num;
                return;
            }
            this.t_TypeCombo.Text = "Unknown Type";
        }

        public void SetSubTypeCombo()
        {
            int num = -1;
            int.TryParse(this.t_Type.Text, out num);
            int num2 = -1;
            int.TryParse(this.t_SubType.Text, out num2);
            if (num > -1 && num < 7)
            {
                if (num2 == -1)
                {
                    this.t_SubTypeCombo.Text = "Unknown Subtype";
                    return;
                }
                try
                {
                    this.t_SubTypeCombo.SelectedIndex = num2;
                    return;
                }
                catch
                {
                    this.t_SubTypeCombo.Text = "Unknown Subtype";
                    return;
                }
            }
            this.t_SubTypeCombo.Text = "Unknown Subtype";
        }

        private void t_SubType_TextChanged(object sender, EventArgs e)
        {
            this.SetSubTypeCombo();
            this.ValueChanged(sender, e);
        }

        private void t_Class_TextChanged(object sender, EventArgs e)
        {
            int num = 127;
            int.TryParse(this.t_Class.Text, out num);
            for (int i = 0; i < 9; i++)
            {
                (base.Controls.Find("checkBox_class" + i, true)[0] as CheckBox).Checked = Convert.ToBoolean(num & 1 << i);
            }
            this.ValueChanged(sender, e);
        }

        private void t_TypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.t_SubTypeCombo.Items.Clear();
            this.t_SubTypeCombo.Items.AddRange(Items.SubTypes(this.t_TypeCombo.SelectedIndex));
            if (Convert.ToInt32(this.t_Type.Text) != this.t_TypeCombo.SelectedIndex)
            {
                this.t_Type.Text = this.t_TypeCombo.SelectedIndex.ToString();
            }
            this.ValueChanged(sender, e);
        }

        private void t_SubTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.t_SubType.Text) != this.t_SubTypeCombo.SelectedIndex)
            {
                this.t_SubType.Text = this.t_SubTypeCombo.SelectedIndex.ToString();
            }
            this.ValueChanged(sender, e);
        }

        private void checkBox_class_CheckedChanged(object sender, EventArgs e)
        {
            int num = 0;
            for (int i = 0; i < 9; i++)
            {
                if ((base.Controls.Find("checkBox_class" + i, true)[0] as CheckBox).Checked)
                {
                    num += 1 << i;
                }
            }
            this.t_Class.Text = num.ToString();
        }

        private void t_WearingPos_TextChanged(object sender, EventArgs e)
        {
            int num = -1;
            int.TryParse(this.t_WearingPos.Text, out num);
            this.t_WearingPosCombo.SelectedIndex = num + 1;
        }
    }
}
