using SlimDX;
using SlimDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools
{
    public partial class MobPicker : Form //dethunter12 6/14/2018
    {
        public List<string> MenuList = new List<string>();
        public List<string> MenuListSearch = new List<string>();
        public static Connection connection = new Connection(); //dethunter12 add
        private DatabaseHandle databaseHandle = new DatabaseHandle(); //dethunter12 add
        private string Host = SkillEditor.connection.ReadSettings("Host"); //dethunter12 add
        private string User = SkillEditor.connection.ReadSettings("User"); //dethunter12 add
        private string Password = SkillEditor.connection.ReadSettings("Password"); //dethunter12 add
        private string Database = SkillEditor.connection.ReadSettings("Database"); //dethunter12 add
        public string _ClientPath = SkillEditor.connection.ReadSettings("ClientPath"); //dethunter12 add
        public string[] menuArray = new string[2] //dethunter12 add
    {
      "a_index",
      "a_name_usa"
    };
        public Direct3D _Direct3D;
        public Device _Device;
        public float _Zoom;
        public float _LeftRight;
        public float _Rotation;
        public float _UpDown = -1f;
        public List<tMesh> _Models;
        public int MobIndex = -1; //dethunter12 add
        public int MobCount = 1; //dethunter12 add 
        private ASCIIEncoding _Enc = new ASCIIEncoding();
        public MobPicker()
        {
            InitializeComponent();
        }
        private void MobPicker_Load(object sender, EventArgs e)
        {
            MenuList.Clear();
            for (int index = 0; index < NpcList.List.Count<tNpc>(); ++index)
                MenuList.Add("" + NpcList.List[index].ItemID.ToString() + " - " + NpcList.List[index].Name.ToString());
            listBox1.DataSource = MenuList;
            InitializeDevice();
        }
        private void MakeLCModels(string SMCFile)
        {
            System.Collections.Generic.List<float> source1 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> source2 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> source3 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> floatList1 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> floatList2 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> floatList3 = new System.Collections.Generic.List<float>();
            _Models = new System.Collections.Generic.List<tMesh>();
            try
            {
                System.Collections.Generic.List<smcMesh> source4 = SMCReader.ReadFile(SMCFile);
                for (int index1 = 0; index1 < source4.Count(); ++index1)
                {
                    if (LCMeshReader.ReadFile(source4[index1].FileName))
                    {
                        tMeshContainer pMesh = LCMeshReader.pMesh;
                        source1.Add((pMesh.Vertices).Max((p => p.X)));
                        source2.Add((pMesh.Vertices).Max((p => p.Y)));
                        source3.Add((pMesh.Vertices).Max((p => p.Z)));
                        floatList1.Add((pMesh.Vertices).Min((p => p.X)));
                        floatList2.Add((pMesh.Vertices).Min((p => p.Y)));
                        floatList3.Add((pMesh.Vertices).Min(p => p.Z));
                        for (int index2 = 0; index2 < (pMesh.Objects).Count(); ++index2)
                        {
                            int toVert = (int)pMesh.Objects[index2].ToVert;
                            int faceCount = (int)pMesh.Objects[index2].FaceCount;
                            short[] faces = pMesh.Objects[index2].GetFaces();
                            CustomVertex.PositionNormalTextured[] data = new CustomVertex.PositionNormalTextured[toVert];
                            int fromVert = (int)pMesh.Objects[index2].FromVert;
                            for (int index3 = 0; index3 < pMesh.Objects[index2].ToVert; ++index3)
                            {
                                data[index3].Position = new Vector3(pMesh.Vertices[fromVert].X, pMesh.Vertices[fromVert].Y, pMesh.Vertices[fromVert].Z);
                                data[index3].Normal = new Vector3(pMesh.Normals[fromVert].X, pMesh.Normals[fromVert].Y, pMesh.Normals[fromVert].Z);
                                try
                                {
                                    data[index3].Texture = new Vector2(pMesh.UVMaps[0].Coords[fromVert].U, pMesh.UVMaps[0].Coords[fromVert].V);
                                }
                                catch
                                {
                                    data[index3].Texture = new Vector2(0.0f, 0.0f);
                                }
                                ++fromVert;
                            }
                            VertexBuffer vertexBuffer = new VertexBuffer(_Device, (data).Count() * 32, Usage.None, VertexFormat.PositionNormal | VertexFormat.Texture1, Pool.Default);
                            Mesh mesh = new Mesh(_Device, (faces).Count() / 3, (data).Count(), MeshFlags.Managed, VertexFormat.PositionNormal | VertexFormat.Texture1);
                            DataStream dataStream1;
                            using (dataStream1 = mesh.VertexBuffer.Lock(0, (data).Count() * 32, LockFlags.None))
                            {
                                dataStream1.WriteRange(data);
                                mesh.VertexBuffer.Unlock();
                            }
                            DataStream dataStream2;
                            using (dataStream2 = mesh.IndexBuffer.Lock(0, (faces).Count() * 2, LockFlags.None))
                            {
                                dataStream2.WriteRange(faces);
                                mesh.IndexBuffer.Unlock();
                            }
                            if ((uint)(pMesh.Weights).Count() > 0U)
                            {
                                string[] strArray = new string[(pMesh.Weights).Count()];
                                System.Collections.Generic.List<int>[] intListArray = new System.Collections.Generic.List<int>[(pMesh.Weights).Count()];
                                System.Collections.Generic.List<float>[] floatListArray = new System.Collections.Generic.List<float>[(pMesh.Weights).Count()];
                                for (int index3 = 0; index3 < (pMesh.Weights).Count(); ++index3)
                                {
                                    strArray[index3] = _Enc.GetString(pMesh.Weights[index3].JointName);
                                    intListArray[index3] = new System.Collections.Generic.List<int>();
                                    floatListArray[index3] = new System.Collections.Generic.List<float>();
                                    for (int index4 = 0; index4 < (pMesh.Weights[index3].WeightsMap).Count(); ++index4)
                                    {
                                        intListArray[index3].Add(pMesh.Weights[index3].WeightsMap[index4].Index);
                                        floatListArray[index3].Add(pMesh.Weights[index3].WeightsMap[index4].Weight);
                                    }
                                }
                                mesh.SkinInfo = new SkinInfo((data).Count(), VertexFormat.PositionNormal | VertexFormat.Texture1, (int)pMesh.HeaderInfo.JointCount);
                                for (int bone = 0; bone < (intListArray).Count(); ++bone)
                                {
                                    mesh.SkinInfo.SetBoneName(bone, strArray[bone]);
                                    mesh.SkinInfo.SetBoneInfluence(bone, intListArray[bone].ToArray(), floatListArray[bone].ToArray());
                                }
                            }
                            mesh.GenerateAdjacency(0.5f);
                            mesh.ComputeNormals();
                            Texture texture = null;
                            string objName = _Enc.GetString(pMesh.Objects[index2].Textures[0].InternalName);
                            int index5 = source4[index1].Object.FindIndex(x => x.Name.Equals(objName));
                            if (index5 != -1)
                                texture = GetTextureFromFile(source4[index1].Object[index5].Texture);
                            _Models.Add(new tMesh(mesh, texture));
                        }
                    }
                }
            }
            catch
            {
            }
            try
            {
                _Zoom = (new float[3]
                {
          source1.Max(),
          source2.Max(),
          source3.Max()
                }).Max() * 3f;
            }
            catch
            {
            }
            slideZoom.Value = (int)_Zoom * 100;
        }

        private void InitializeDevice()
        {
            //you mest do private void example() and with all the code from panel1 (working) and call the example() to start form for example..
            _Direct3D = new Direct3D();
            Direct3D direct3D = _Direct3D;
            int adapter = 0;
            int num1 = 1;
            IntPtr handle1 = Handle;
            int num2 = 32;
            PresentParameters[] presentParametersArray = new PresentParameters[1];
            int index = 0;
            PresentParameters presentParameters = new PresentParameters();
            presentParameters.SwapEffect = SwapEffect.Discard;
            IntPtr handle2 = panel3DView.Handle;
            presentParameters.DeviceWindowHandle = handle2;
            int num3 = 1;
            presentParameters.Windowed = num3 != 0;
            int width = panel3DView.Width;
            presentParameters.BackBufferWidth = width;
            int height = panel3DView.Height;
            presentParameters.BackBufferHeight = height;
            int num4 = 21;
            presentParameters.BackBufferFormat = (SlimDX.Direct3D9.Format)num4;
            presentParametersArray[index] = presentParameters;
            _Device = new Device(direct3D, adapter, (DeviceType)num1, handle1, (CreateFlags)num2, presentParametersArray);
            _Device.SetRenderState<Cull>(RenderState.CullMode, Cull.None);
            _Device.SetRenderState<FillMode>(RenderState.FillMode, FillMode.Solid);
            _Device.SetRenderState(RenderState.Lighting, false);
            CameraPositioning();
        }

        private void CameraPositioning()
        {
            _Device.SetTransform(TransformState.Projection, Matrix.PerspectiveFovLH(100f, 1f, 1f, 450f));
            _Device.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0.0f, 0.0f, -5f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 1f, 0.0f)));
            _Device.SetTransform(TransformState.World, Matrix.RotationYawPitchRoll(0.0f, 0.0f, 0.0f));
        }

        private void Render()
        {
            _Device.Viewport = new Viewport(0, 0, panel3DView.Width, panel3DView.Height);
            _Device.Clear(ClearFlags.ZBuffer | ClearFlags.Target, new Color4(Color.FromKnownColor(KnownColor.Control)), 1f, 0);
            _Device.BeginScene();
            _Device.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0.0f, 0.0f, _Zoom), new Vector3(_LeftRight, _UpDown, 0.0f), new Vector3(0.0f, 1f, 0.0f)));
            _Device.SetTransform(TransformState.World, Matrix.RotationYawPitchRoll(_Rotation, 3.1f, 0.0f));
            if (_Models != null && (uint)_Models.Count() > 0U)
            {
                for (int index = 0; index < _Models.Count(); ++index)
                {
                    if (_Models[index].TexData != null)
                        _Device.SetTexture(0, _Models[index].TexData);
                    for (int subset = 0; subset < 1000; ++subset)
                        _Models[index].MeshData.DrawSubset(subset);
                }
            }
            _Device.EndScene();
            _Device.Present();
            _Rotation = _Rotation - 0.03f;
        }
     
        private SlimDX.Direct3D9.Format ConvFormat(texFormat tFormat)
        {
            SlimDX.Direct3D9.Format format = SlimDX.Direct3D9.Format.Unknown;
            switch (tFormat)
            {
                case texFormat.RGB:
                    return SlimDX.Direct3D9.Format.R8G8B8;
                case texFormat.ARGB:
                    return SlimDX.Direct3D9.Format.A8R8G8B8;
                case texFormat.DXT1:
                    return SlimDX.Direct3D9.Format.Dxt1;
                case texFormat.DXT3:
                    return SlimDX.Direct3D9.Format.Dxt3;
                default:
                    return format;
            }
        }

        private Texture BuildTexture(byte[] imageData, SlimDX.Direct3D9.Format imageFormat, int width, int height)
        {
            if (imageFormat == SlimDX.Direct3D9.Format.R8G8B8)
            {
                MemoryStream memoryStream;
                using (memoryStream = new MemoryStream())
                {
                    Tex.makeRGB8(imageData, width, height).Save((Stream)memoryStream, ImageFormat.Bmp);
                    memoryStream.Write(imageData, 0, imageData.Length);
                    memoryStream.Position = 0L;
                    return Texture.FromStream(_Device, (Stream)memoryStream, width, height, 0, Usage.SoftwareProcessing, SlimDX.Direct3D9.Format.A8B8G8R8, Pool.Default, Filter.None, Filter.None, 0);
                }
            }
            else if (imageFormat == SlimDX.Direct3D9.Format.A8R8G8B8)
            {
                MemoryStream memoryStream;
                using (memoryStream = new MemoryStream())
                {
                    Tex.makeRGB(imageData, width, height).Save((Stream)memoryStream, ImageFormat.Bmp);
                    memoryStream.Write(imageData, 0, imageData.Length);
                    memoryStream.Position = 0L;
                    return Texture.FromStream(_Device, (Stream)memoryStream, width, height, 0, Usage.SoftwareProcessing, SlimDX.Direct3D9.Format.A8B8G8R8, Pool.Default, Filter.None, Filter.None, 0);
                }
            }
            else
            {
                Texture texture = new Texture(_Device, width, height, 0, Usage.None, imageFormat, Pool.Managed);
                using (Stream data = (Stream)texture.LockRectangle(0, LockFlags.None).Data)
                {
                    data.Write(imageData, 0, ((IEnumerable<byte>)imageData).Count<byte>());
                    texture.UnlockRectangle(0);
                }
                return texture;
            }
        }

        private Texture GetTextureFromFile(string FileName)
        {
            Texture texture = null;
            if (File.Exists(FileName))
            {
                Tex.ReadFile(FileName);
                SlimDX.Direct3D9.Format imageFormat = ConvFormat(Tex.GetFormat());
                texture = BuildTexture(Tex.lcTex.imageData[0], imageFormat, (int)Tex.lcTex.Header.Width, (int)Tex.lcTex.Header.Height);
            }
            return texture;
        }



        public bool SearchString(string s)
        {
            return s.ToUpper().Contains(textBox1.Text.ToUpper());
        }
        public int GetIndexByComboBox(string comboBox) //dethunter12 add
        {
            try
            {
                return Convert.ToInt32(comboBox.Split(' ')[0]);
            }
            catch
            {
                return 0;
            }
        }
        private int GetID()
        {
            int result = -1;
            int.TryParse(listBox1.Text.Split(' ')[0], out result);
            return result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MenuListSearch = MenuList.FindAll(new Predicate<string>(SearchString));
            listBox1.DataSource = MenuListSearch;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MobIndex = GetID();
            if (MobIndex == -1)
                return;
            tNpc tNpc = NpcList.List.Find((Predicate<tNpc>)(p => p.ItemID.Equals(MobIndex)));
            if (tNpc == null)
                return;
            MobIndex = tNpc.ItemID;
            textBox2.Text = tNpc.Name;
            textBox3.Text = tNpc.SMCPath;
            if (chk3D.Checked && File.Exists(_ClientPath + textBox3.Text))
            {
                Console.WriteLine("Create Model > " + _ClientPath + textBox3.Text);
                MakeLCModels(_ClientPath + textBox3.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            MobIndex = GetID();
            if (TbMobCount.Text == "")
                MobCount = 1;
            else 
            MobCount = Convert.ToInt16(TbMobCount.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MobIndex = -1;

            DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            Render();
        }

        private void slideZoom_Scroll(object sender, EventArgs e)
        {
            _Zoom = slideZoom.Value / 100f;
        }

        private void slideUpDown_Scroll(object sender, EventArgs e)
        {
            _UpDown = slideUpDown.Value / 1000f;
        }

        private void slideLeftRight_Scroll(object sender, EventArgs e)
        {
            _LeftRight = slideLeftRight.Value / 1000f;
        }
    }
}
