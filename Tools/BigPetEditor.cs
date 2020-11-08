// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.BigPetEditor
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using MySql.Data.MySqlClient;
using SlimDX;
using SlimDX.Direct3D9;
using StringExporter;
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

namespace LcDevPack_TeamDamonA.Tools
{
    public class BigPetEditor : Form
    {
        public static Connection connection = new Connection();
        private string Host = BigPetEditor.connection.ReadSettings("Host");
        private string User = BigPetEditor.connection.ReadSettings("User");
        private string Password = BigPetEditor.connection.ReadSettings("Password");
        private string Database = BigPetEditor.connection.ReadSettings("Database");
        private DatabaseHandle databaseHandle = new DatabaseHandle();
        public string _ClientPath = BigPetEditor.connection.ReadSettings("ClientPath");
        public string rowName = "a_index";
        public string[] menuArray = new string[2]
        {
      "a_index",
      "a_name"
        };
        private ASCIIEncoding _Enc = new ASCIIEncoding();
        public float _UpDown = -1f;
        public float _Zoom;
        public float _LeftRight;
        public float _Rotation;
        public float _Rotation2;
        public Direct3D _Direct3D;
        public Direct3D _Direct3D2;
        public Device _Device;
        public Device _Device2;
        private IContainer components = (IContainer)null;
        public string name;
        public int index;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileExportToolStripMenuItem;
        private ToolStripMenuItem exportBipetlodToolStripMenuItem;
        private Label label3;
        private TextBox textBox3;
        private Timer timer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button4;
        private Label label33;
        private TextBox textBox203;
        private TextBox textBox29;
        private Label label37;
        private TextBox textBox202;
        private Label label39;
        private TextBox textBox201;
        private TextBox textBox32;
        private PictureBox pictureBox1;
        private GroupBox groupBox4;
        private TextBox textBox27;
        private Label label28;
        private TextBox textBox28;
        private Label label29;
        private TextBox textBox24;
        private Label label25;
        private TextBox textBox25;
        private Label label26;
        private TextBox textBox26;
        private Label label27;
        private TextBox textBox23;
        private Label label24;
        private TextBox textBox19;
        private Label label20;
        private TextBox textBox20;
        private Label label21;
        private TextBox textBox21;
        private Label label22;
        private TextBox textBox22;
        private Label label23;
        private TextBox textBox18;
        private Label label19;
        private TextBox textBox17;
        private Label label18;
        private TextBox textBox13;
        private TextBox textBox12;
        private Label label16;
        private Label label15;
        private TextBox textBox11;
        private Label label12;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox10;
        private Label label14;
        private Label label13;
        private Label label11;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox35;
        private TextBox textBox9;
        private Label label30;
        private Label label10;
        private Label label36;
        private TextBox textBox36;
        private GroupBox groupBox3;
        private TextBox textBox4;
        private CheckBox checkBox1;
        private Label label5;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private TextBox textBox200;
        private Label label1;
        private Label label34;
        private TextBox textBox33;
        private Label label38;
        private TextBox textBox34;
        private TextBox textBox37;
        private TextBox textBox38;
        private Label label35;
        private TabPage tabPage2;
        private TextBox textBox30;
        private Label label31;
        private TextBox textBox31;
        private Label label32;
        private TextBox textBox39;
        private Label label40;
        private TextBox textBox40;
        private Label label41;
        private TextBox textBox41;
        private Label label42;
        private TextBox textBox42;
        private Label label43;
        private TextBox textBox43;
        private Label label44;
        private TextBox textBox44;
        private Label label45;
        private TextBox textBox45;
        private Label label46;
        private TextBox textBox46;
        private Label label47;
        private GroupBox groupBox5;
        private TextBox textBox59;
        private Label label60;
        private TextBox textBox60;
        private Label label61;
        private TextBox textBox61;
        private Label label62;
        private Label label63;
        private TextBox textBox62;
        private TextBox textBox55;
        private Label label56;
        private TextBox textBox56;
        private Label label57;
        private TextBox textBox57;
        private Label label58;
        private Label label59;
        private TextBox textBox58;
        private TextBox textBox47;
        private Label label48;
        private TextBox textBox48;
        private Label label49;
        private Label label50;
        private TextBox textBox49;
        private TextBox textBox50;
        private Label label51;
        private Label label52;
        private TextBox textBox51;
        private TextBox textBox52;
        private Label label53;
        private Label label54;
        private TextBox textBox53;
        private TextBox textBox54;
        private Label label55;
        private TextBox textBox63;
        private Label label64;
        private TextBox textBox64;
        private Label label65;
        private Timer timer2;
        private Panel panel1;
        private GroupBox groupBox20;
        private CheckBox chk3D;
        private TrackBar slideLeftRight;
        private TrackBar slideUpDown;
        private TrackBar slideZoom;
        private Panel panel3DView;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
        private TextBox textBox16;
        private Label label17;
        private TextBox tbEnable;
        private PictureBox PbSelectID1;
        private ToolStripMenuItem usaToolStripMenuItem;
        private ToolStripMenuItem frenchToolStripMenuItem;
        private ToolStripMenuItem thaiToolStripMenuItem;
        private ToolStripMenuItem germanToolStripMenuItem;
        private ToolStripMenuItem mexicanToolStripMenuItem;
        private ToolStripMenuItem polandToolStripMenuItem;
        private ToolStripMenuItem italianToolStripMenuItem;
        private ToolStripMenuItem spanishToolStripMenuItem;
        private ToolStripMenuItem bigPetStringToolStripMenuItem;
        public List<tMesh> _Models;

        public BigPetEditor()
        {
            InitializeComponent();
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
                        source3.Add(( pMesh.Vertices).Max((p => p.Z)));
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
  /*  private void InitializeDevice2()//But When  i make a second of this one it freeack out first 3dpanel dont stay and shows in second
        {
            _Direct3D2= new Direct3D();//maby this?
            Direct3D direct3D = _Direct3D2;
            int adapter = 1;
            int num1 = 1;
            IntPtr handle1 = Handle;
            int num2 = 32;
            PresentParameters[] presentParametersArray = new PresentParameters[1];
            int index2= 0;
            PresentParameters presentParameters2= new PresentParameters();
            presentParameters2.SwapEffect = SwapEffect.Discard;
            IntPtr handle2 = panel2.Handle;
            presentParameters2.DeviceWindowHandle = handle2;
            int num3 = 1;
            presentParameters2.Windowed = num3 != 0;
            int width2= panel2.Width;
            presentParameters2.BackBufferWidth = width2;
            int height2= panel2.Height;
            presentParameters2.BackBufferHeight = height2;
            int num4 = 21;
            presentParameters2.BackBufferFormat = (SlimDX.Direct3D9.Format)num4;
            presentParametersArray[index2]= presentParameters2;
            _Device2= new Device(direct3D, adapter, (DeviceType)num1, handle1, (CreateFlags)num2, presentParametersArray);
            _Device2.SetRenderState<Cull>(RenderState.CullMode, Cull.None);
            _Device2.SetRenderState<FillMode>(RenderState.FillMode, FillMode.Solid);
            _Device2.SetRenderState(RenderState.Lighting, false);
            CameraPositionin2();
        }
        */
        private void CameraPositioning()
        {
            _Device.SetTransform(TransformState.Projection, Matrix.PerspectiveFovLH(100f, 1f, 1f, 450f));
            _Device.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0.0f, 0.0f, -5f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 1f, 0.0f)));
            _Device.SetTransform(TransformState.World, Matrix.RotationYawPitchRoll(0.0f, 0.0f, 0.0f));
        }
        private void CameraPositionin2()
        {
            _Device2.SetTransform(TransformState.Projection, Matrix.PerspectiveFovLH(100f, 1f, 1f, 450f));
            _Device2.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0.0f, 0.0f, -5f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 1f, 0.0f)));
            _Device2.SetTransform(TransformState.World, Matrix.RotationYawPitchRoll(0.0f, 0.0f, 0.0f));
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
    /*  private void Render2()
        {
            _Device2.Viewport = new Viewport(0, 0, panel2.Width, panel2.Height);
            _Device2.Clear(ClearFlags.ZBuffer | ClearFlags.Target, new Color4(Color.FromKnownColor(KnownColor.Control)), 1f, 0);
            _Device2.BeginScene();
            _Device2.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0.0f, 0.0f, _Zoom), new Vector3(_LeftRight, _UpDown, 0.0f), new Vector3(0.0f, 1f, 0.0f)));
            _Device2.SetTransform(TransformState.World, Matrix.RotationYawPitchRoll(_Rotation, 3.1f, 0.0f));
            if (_Models != null && (uint)_Models.Count() > 0U)
            {
                for (int index = 0; index < _Models.Count(); ++index)
                {
                    if (_Models[index].TexData != null)
                        _Device2.SetTexture(0, _Models[index].TexData);
                    for (int subset = 0; subset < 1000; ++subset)
                        _Models[index].MeshData.DrawSubset(subset);
                }
            }
            _Device2.EndScene();
            _Device2.Present();
            _Rotation2= _Rotation - 0.03f;
        }
        */
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


        private void timer1_Tick(object sender, EventArgs e)
        {
            Render();
          //Render2();
        }

        private void slideZoom_Scroll(object sender, EventArgs e)
        {
            _Zoom = (float)slideZoom.Value / 100f;
        }

        private void slideUpDown_Scroll(object sender, EventArgs e)
        {
            _UpDown = (float)slideUpDown.Value / 1000f;
        }

        private void slideLeftRight_Scroll(object sender, EventArgs e)
        {
            _LeftRight = (float)slideLeftRight.Value / 1000f;
        }
        private void LoadListBox()
        {
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_attack_pet ORDER BY a_index;");
        }

        public void SearchList(string searchString)
        {
            searchString = searchString.Replace("\\", "\\\\").Replace("'", "\\'");
            string lower = searchString.ToLower();
            string upper = searchString.ToUpper();
            string str = "";
            if (searchString.Length > 1)
                str = char.ToUpper(searchString[0]).ToString() + searchString.Substring(1);
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_attack_pet WHERE a_name LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");
        }

        public int GetIndex()
        {
            try
            {
                return Convert.ToInt32(listBox1.Text.Split(' ')[0]);
            }
            catch
            {
                return 0;
            }
        }

      /*  public void LoadMisc()
        {
            checkBox1.Checked = textBox3.Text == "True";
            int num = comboBox1.FindString(textBox4.Text);
            try
            {
                comboBox1.SelectedIndex = num;
            }
            catch
            {
            }
        }*/

        private void IconPet()
        {
            string Query = "select a_index, a_texture_id, a_texture_row, a_texture_col FROM t_item WHERE a_index ='" + textBox9.Text + "';";
            string[] rows = new string[4]
            {
                "a_index",
                "a_texture_id",
                "a_texture_row",
                "a_texture_col"
            };
            Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
            textBox201.Text = strArray[1];
            textBox202.Text = strArray[2];
            textBox203.Text = strArray[3];
        }

        private void ClearPicture()
        {
            if (!(textBox201.Text == ""))
                return;
            pictureBox1.Image = (Image)null;
        }

        private void BigPetEditor_Load(object sender, EventArgs e)
        {
            try
            {
              //InitializeDevice2();
                InitializeDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("test", ex.Message);
            }      
            LoadListBox();
            LoadStartupString();
            SelectBoxes();
            //LoadMisc();
            IconPet();
            ClearPicture();
           
        }
        private void ResetTextComboBox() //dethunter12 add
        {
            comboBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox9.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox7.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            textBox14.BackColor = Color.White;
            textBox15.BackColor = Color.White;
            textBox10.BackColor = Color.White;
            textBox11.BackColor = Color.White;
            textBox12.BackColor = Color.White;
            textBox13.BackColor = Color.White;
            textBox18.BackColor = Color.White;
            textBox17.BackColor = Color.White;
            textBox22.BackColor = Color.White;
            textBox25.BackColor = Color.White;
            textBox26.BackColor = Color.White;
            textBox24.BackColor = Color.White;
            textBox27.BackColor = Color.White;
            textBox19.BackColor = Color.White;
            textBox20.BackColor = Color.White;
            textBox21.BackColor = Color.White;
            textBox23.BackColor = Color.White;
            textBox28.BackColor = Color.White;
            textBox33.BackColor = Color.White;
            textBox29.BackColor = Color.White;
            textBox38.BackColor = Color.White;
            textBox32.BackColor = Color.White;
            textBox37.BackColor = Color.White;
            textBox34.BackColor = Color.White;
            textBox35.BackColor = Color.White;
            textBox36.BackColor = Color.White;
            textBox39.BackColor = Color.White;
            textBox30.BackColor = Color.White;
            textBox43.BackColor = Color.White;
            textBox44.BackColor = Color.White;
            textBox45.BackColor = Color.White;
            textBox53.BackColor = Color.White;
            textBox16.BackColor = Color.White;
            textBox42.BackColor = Color.White;
            textBox31.BackColor = Color.White;
            textBox63.BackColor = Color.White;
            textBox52.BackColor = Color.White;
            textBox50.BackColor = Color.White;
            textBox47.BackColor = Color.White;
            textBox57.BackColor = Color.White;
            textBox49.BackColor = Color.White;
            textBox54.BackColor = Color.White;
            textBox48.BackColor = Color.White;
            textBox58.BackColor = Color.White;
            textBox56.BackColor = Color.White;
            textBox62.BackColor = Color.White;
            textBox51.BackColor = Color.White;
            textBox57.BackColor = Color.White;
            textBox55.BackColor = Color.White;
            textBox64.BackColor = Color.White;
            textBox61.BackColor = Color.White;
            textBox59.BackColor = Color.White;
            textBox60.BackColor = Color.White;
            textBox46.BackColor = Color.White;
            textBox40.BackColor = Color.White;
            textBox41.BackColor = Color.White;
            
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                textBox1.Text = GetIndex().ToString();
            string Query = "SELECT * FROM t_attack_pet WHERE a_index ='" + textBox1.Text + "';";

            string[] rows = new string[63]
            {
        "a_name",
        "a_enable",
        "a_type",
        "a_str",
        "a_dex",
        "a_int",
        "a_con",
        "a_item_idx",
        "a_maxFaith",
        "a_maxStm",
        "a_maxHP",
        "a_maxMP",
        "a_recoverHP",
        "a_recoverMP",
        "a_delay",
        "a_AISlot",
        "a_after_dead",
        "a_attack",
        "a_defence",
        "a_Mattack",
        "a_Mdefence",
        "a_hitpoint",
        "a_avoidpoint",
        "a_Mavoidpoint",
        "a_attackSpeed",
        "a_deadly",
        "a_critical",
        "a_awful",
        "a_strong",
        "a_normal",
        "a_week",
        "a_bagic_skill1",
        "a_bagic_skill2",
        "a_flag",
        "a_smcFileName_1",
        "a_trans_type",
        "a_trans_start",
        "a_trans_end",
        "a_ani_idle1_1",
        "a_ani_idle2_1",
        "a_ani_attack1_1",
        "a_ani_attack2_1",
        "a_ani_damage_1",
        "a_ani_die_1",
        "a_ani_walk_1",
        "a_ani_run_1",
        "a_ani_levelup_1",
        "a_mount_1",
        "a_summon_skill_1",
        "a_speed_1",
        "a_smcFileName_2",
        "a_ani_idle1_2",
        "a_ani_idle2_2",
        "a_ani_attack1_2",
        "a_ani_attack2_2",
        "a_ani_damage_2",
        "a_ani_die_2",
        "a_ani_walk_2",
        "a_ani_run_2",
        "a_ani_levelup_2",
        "a_mount_2",
        "a_summon_skill_2",
        "a_speed_2"
            };
            Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
            if (chk3D.Checked && File.Exists(_ClientPath + strArray[34]))
            {
                Console.WriteLine("Create Model > " + _ClientPath + strArray[34]);
                MakeLCModels(_ClientPath + strArray[34]);//Main
            }
            textBox2.Text = strArray[0];
            // textBox3.Text = strArray[1];
            tbEnable.Text = strArray[1];
            textBox4.Text = strArray[2];
            textBox5.Text = strArray[3];
            textBox6.Text = strArray[4];
            textBox7.Text = strArray[5];
            textBox8.Text = strArray[6];
            textBox9.Text = strArray[7];
            textBox10.Text = strArray[8];
            textBox11.Text = strArray[9];
            textBox14.Text = strArray[10];
            textBox15.Text = strArray[11];
            textBox12.Text = strArray[12];
            textBox13.Text = strArray[13];
            textBox17.Text = strArray[14];//Delay
            textBox18.Text = strArray[15];//a_AISlot
            textBox22.Text = strArray[16];//a_after_dead
            textBox19.Text = strArray[17];//a_attack
            textBox20.Text = strArray[18];//a_defence
            textBox21.Text = strArray[19];//a_Mattack
            textBox23.Text = strArray[20];//a_Mdefence
            textBox25.Text = strArray[21];//a_hitpoint
            textBox26.Text = strArray[22];//a_avoidpoint
            textBox24.Text = strArray[23];//a_Mavoidpoint
            textBox27.Text = strArray[24];// a_attackSpeed
            textBox28.Text = strArray[25];//a_deadly
            textBox38.Text = strArray[26];//a_critical
            textBox35.Text = strArray[27];//a_awful
            textBox32.Text = strArray[28];//a_strong
            textBox36.Text = strArray[29];//a_normal
            textBox33.Text = strArray[30];//a_week
            textBox37.Text = strArray[31];//a_bagic_skill1
            textBox34.Text = strArray[32];//a_bagic_skill2
            textBox29.Text = strArray[33];//a_flag
            textBox16.Text = strArray[34];//a_smcFileName_1
            textBox46.Text = strArray[35];//a_trans_type
            textBox40.Text = strArray[36];//a_trans_start
            textBox41.Text = strArray[37];//a_trans_end
            textBox39.Text = strArray[38];//a_ani_idle1_1
            textBox30.Text = strArray[39];//a_ani_idle2_1
            textBox43.Text = strArray[40];//a_ani_attack1_1
            textBox44.Text = strArray[41];//a_ani_attack2_1
            textBox63.Text = strArray[42];//a_ani_damage_1
            textBox45.Text = strArray[43];//a_ani_die_1
            textBox42.Text = strArray[44];//a_ani_walk_1
            textBox31.Text = strArray[45];//a_ani_run_1
            textBox52.Text = strArray[46];//a_ani_levelup_1
            textBox53.Text = strArray[47];//a_mount_1
            textBox50.Text = strArray[48];//a_summon_skill_1
            textBox47.Text = strArray[49];//a_speed_1
            textBox51.Text = strArray[50];//a_smcFileName_2
            textBox49.Text = strArray[51];//a_ani_idle1_2
            textBox54.Text = strArray[52];//a_ani_idle2_2
            textBox48.Text = strArray[53];//a_ani_attack1_2
            textBox58.Text = strArray[54];//a_ani_attack2_2
            textBox64.Text = strArray[55];//a_ani_damage_2
            textBox56.Text = strArray[56];//a_ani_die_2
            textBox57.Text = strArray[57];//a_ani_walk_2
            textBox55.Text = strArray[58];//a_ani_run_2
            textBox61.Text = strArray[59];//a_ani_levelup_2
            textBox62.Text = strArray[60];//a_mount_2
            textBox59.Text = strArray[61];//a_summon_skill_2
            textBox60.Text = strArray[62];//a_speed_2
            IconPet();
            ClearPicture();
            SelectBoxes(); //dethunter12 add
            ResetTextComboBox(); //dethunter12 add
            try
            {
                pictureBox1.Image = databaseHandle.IconItem(int.Parse(textBox201.Text), int.Parse(textBox202.Text), int.Parse(textBox203.Text));
            }
            catch
            {
            }
        }
        private void LoadStartupString() //dethunter12 add
        {
            comboBox1.Items.AddRange(new object[3]
                {
                    "1 - Human",
                    "2 - Beast",
                     "3 - Demon"
     
                 });
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

        private void SelectBoxes() //dethunter12 add
        {
            checkBox1.Checked = tbEnable.Text == "1"; //state of the check is determined by textBox3's Value
            int num1 = comboBox1.FindString(textBox4.Text);
            comboBox1.SelectedIndex = num1;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BigPetEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportBipetlodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mexicanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PbSelectID1 = new System.Windows.Forms.PictureBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.chk3D = new System.Windows.Forms.CheckBox();
            this.slideLeftRight = new System.Windows.Forms.TrackBar();
            this.slideUpDown = new System.Windows.Forms.TrackBar();
            this.slideZoom = new System.Windows.Forms.TrackBar();
            this.panel3DView = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox203 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox202 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox201 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox200 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label51 = new System.Windows.Forms.Label();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tbEnable = new System.Windows.Forms.TextBox();
            this.bigPetStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).BeginInit();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideLeftRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileExportToolStripMenuItem
            // 
            this.fileExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportBipetlodToolStripMenuItem,
            this.bigPetStringToolStripMenuItem});
            this.fileExportToolStripMenuItem.Name = "fileExportToolStripMenuItem";
            this.fileExportToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.fileExportToolStripMenuItem.Text = "File Export";
            // 
            // exportBipetlodToolStripMenuItem
            // 
            this.exportBipetlodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usaToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.thaiToolStripMenuItem,
            this.germanToolStripMenuItem,
            this.mexicanToolStripMenuItem,
            this.polandToolStripMenuItem,
            this.italianToolStripMenuItem,
            this.spanishToolStripMenuItem});
            this.exportBipetlodToolStripMenuItem.Name = "exportBipetlodToolStripMenuItem";
            this.exportBipetlodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportBipetlodToolStripMenuItem.Text = "Export bipet.lod";
            this.exportBipetlodToolStripMenuItem.Click += new System.EventHandler(this.exportBipetlodToolStripMenuItem_Click);
            // 
            // usaToolStripMenuItem
            // 
            this.usaToolStripMenuItem.Name = "usaToolStripMenuItem";
            this.usaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usaToolStripMenuItem.Text = "usa";
            this.usaToolStripMenuItem.Click += new System.EventHandler(this.usaToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.frenchToolStripMenuItem.Text = "French";
            // 
            // thaiToolStripMenuItem
            // 
            this.thaiToolStripMenuItem.Name = "thaiToolStripMenuItem";
            this.thaiToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.thaiToolStripMenuItem.Text = "Thai";
            // 
            // germanToolStripMenuItem
            // 
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            this.germanToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.germanToolStripMenuItem.Text = "German";
            // 
            // mexicanToolStripMenuItem
            // 
            this.mexicanToolStripMenuItem.Name = "mexicanToolStripMenuItem";
            this.mexicanToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mexicanToolStripMenuItem.Text = "Mexican";
            // 
            // polandToolStripMenuItem
            // 
            this.polandToolStripMenuItem.Name = "polandToolStripMenuItem";
            this.polandToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.polandToolStripMenuItem.Text = "Poland";
            // 
            // italianToolStripMenuItem
            // 
            this.italianToolStripMenuItem.Name = "italianToolStripMenuItem";
            this.italianToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.italianToolStripMenuItem.Text = "Italian";
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.spanishToolStripMenuItem.Text = "Spanish";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enable:";
            this.label3.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(573, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(853, 519);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PbSelectID1);
            this.tabPage1.Controls.Add(this.groupBox20);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.textBox203);
            this.tabPage1.Controls.Add(this.textBox29);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.textBox202);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.textBox201);
            this.tabPage1.Controls.Add(this.textBox32);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.textBox35);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.textBox36);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.textBox33);
            this.tabPage1.Controls.Add(this.label38);
            this.tabPage1.Controls.Add(this.textBox34);
            this.tabPage1.Controls.Add(this.textBox37);
            this.tabPage1.Controls.Add(this.textBox38);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(845, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Big Pet Edit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PbSelectID1
            // 
            this.PbSelectID1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID1.Location = new System.Drawing.Point(773, 11);
            this.PbSelectID1.Name = "PbSelectID1";
            this.PbSelectID1.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID1.TabIndex = 107;
            this.PbSelectID1.TabStop = false;
            this.PbSelectID1.Click += new System.EventHandler(this.PbSelectID1_Click);
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.chk3D);
            this.groupBox20.Controls.Add(this.slideLeftRight);
            this.groupBox20.Controls.Add(this.slideUpDown);
            this.groupBox20.Controls.Add(this.slideZoom);
            this.groupBox20.Controls.Add(this.panel3DView);
            this.groupBox20.Location = new System.Drawing.Point(562, 35);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(279, 313);
            this.groupBox20.TabIndex = 92;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "3D View";
            // 
            // chk3D
            // 
            this.chk3D.AutoSize = true;
            this.chk3D.Checked = true;
            this.chk3D.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk3D.Location = new System.Drawing.Point(180, 0);
            this.chk3D.Name = "chk3D";
            this.chk3D.Size = new System.Drawing.Size(99, 17);
            this.chk3D.TabIndex = 38;
            this.chk3D.Text = "Enable 3D View";
            this.chk3D.UseVisualStyleBackColor = true;
            // 
            // slideLeftRight
            // 
            this.slideLeftRight.AutoSize = false;
            this.slideLeftRight.Location = new System.Drawing.Point(188, 284);
            this.slideLeftRight.Maximum = 10000;
            this.slideLeftRight.Minimum = -10000;
            this.slideLeftRight.Name = "slideLeftRight";
            this.slideLeftRight.Size = new System.Drawing.Size(85, 25);
            this.slideLeftRight.TabIndex = 3;
            this.slideLeftRight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideLeftRight.Scroll += new System.EventHandler(this.slideLeftRight_Scroll);
            // 
            // slideUpDown
            // 
            this.slideUpDown.AutoSize = false;
            this.slideUpDown.Location = new System.Drawing.Point(95, 284);
            this.slideUpDown.Maximum = 10000;
            this.slideUpDown.Minimum = -10000;
            this.slideUpDown.Name = "slideUpDown";
            this.slideUpDown.Size = new System.Drawing.Size(85, 25);
            this.slideUpDown.TabIndex = 2;
            this.slideUpDown.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideUpDown.Scroll += new System.EventHandler(this.slideUpDown_Scroll);
            // 
            // slideZoom
            // 
            this.slideZoom.AutoSize = false;
            this.slideZoom.Location = new System.Drawing.Point(7, 284);
            this.slideZoom.Maximum = 10000;
            this.slideZoom.Minimum = -10000;
            this.slideZoom.Name = "slideZoom";
            this.slideZoom.Size = new System.Drawing.Size(85, 25);
            this.slideZoom.TabIndex = 1;
            this.slideZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideZoom.Scroll += new System.EventHandler(this.slideZoom_Scroll);
            // 
            // panel3DView
            // 
            this.panel3DView.Location = new System.Drawing.Point(7, 20);
            this.panel3DView.Name = "panel3DView";
            this.panel3DView.Size = new System.Drawing.Size(266, 258);
            this.panel3DView.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(762, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 91;
            this.button4.Text = "SAVE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(570, 429);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(41, 13);
            this.label33.TabIndex = 86;
            this.label33.Text = "Strong:";
            // 
            // textBox203
            // 
            this.textBox203.Location = new System.Drawing.Point(749, -22);
            this.textBox203.Name = "textBox203";
            this.textBox203.Size = new System.Drawing.Size(26, 20);
            this.textBox203.TabIndex = 73;
            this.textBox203.Visible = false;
            // 
            // textBox29
            // 
            this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox29.Location = new System.Drawing.Point(617, 376);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(68, 20);
            this.textBox29.TabIndex = 89;
            this.textBox29.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox29_KeyPress);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(720, 429);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(43, 13);
            this.label37.TabIndex = 78;
            this.label37.Text = "Normal:";
            // 
            // textBox202
            // 
            this.textBox202.Location = new System.Drawing.Point(717, -22);
            this.textBox202.Name = "textBox202";
            this.textBox202.Size = new System.Drawing.Size(26, 20);
            this.textBox202.TabIndex = 72;
            this.textBox202.Visible = false;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(570, 403);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(41, 13);
            this.label39.TabIndex = 74;
            this.label39.Text = "Critical:";
            // 
            // textBox201
            // 
            this.textBox201.Location = new System.Drawing.Point(685, -22);
            this.textBox201.Name = "textBox201";
            this.textBox201.Size = new System.Drawing.Size(26, 20);
            this.textBox201.TabIndex = 71;
            this.textBox201.Visible = false;
            // 
            // textBox32
            // 
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox32.Location = new System.Drawing.Point(617, 428);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(68, 20);
            this.textBox32.TabIndex = 87;
            this.textBox32.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox32_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(801, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox27);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.textBox28);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.textBox24);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.textBox25);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.textBox26);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.textBox23);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.textBox19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.textBox20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.textBox21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.textBox22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.textBox18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.textBox17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Controls.Add(this.textBox12);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBox15);
            this.groupBox4.Controls.Add(this.textBox14);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(256, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 344);
            this.groupBox4.TabIndex = 67;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Habilities";
            // 
            // textBox27
            // 
            this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox27.Location = new System.Drawing.Point(81, 313);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(68, 20);
            this.textBox27.TabIndex = 41;
            this.textBox27.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox27_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(0, 316);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(75, 13);
            this.label28.TabIndex = 40;
            this.label28.Text = "Attack Speed:";
            // 
            // textBox28
            // 
            this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox28.Location = new System.Drawing.Point(233, 313);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(68, 20);
            this.textBox28.TabIndex = 39;
            this.textBox28.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox28_KeyPress);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(185, 315);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 13);
            this.label29.TabIndex = 38;
            this.label29.Text = "Deadly:";
            // 
            // textBox24
            // 
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox24.Location = new System.Drawing.Point(81, 287);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(68, 20);
            this.textBox24.TabIndex = 37;
            this.textBox24.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox24_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 290);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 13);
            this.label25.TabIndex = 36;
            this.label25.Text = "Magic Avoid:";
            // 
            // textBox25
            // 
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox25.Location = new System.Drawing.Point(81, 235);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(68, 20);
            this.textBox25.TabIndex = 35;
            this.textBox25.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox25_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(25, 238);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 13);
            this.label26.TabIndex = 34;
            this.label26.Text = "Hit Point:";
            // 
            // textBox26
            // 
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox26.Location = new System.Drawing.Point(81, 261);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(68, 20);
            this.textBox26.TabIndex = 33;
            this.textBox26.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox26_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(41, 264);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 13);
            this.label27.TabIndex = 32;
            this.label27.Text = "Avoid";
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox23.Location = new System.Drawing.Point(233, 287);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(68, 20);
            this.textBox23.TabIndex = 31;
            this.textBox23.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox23_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(145, 289);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 13);
            this.label24.TabIndex = 30;
            this.label24.Text = "Magic Defence:";
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox19.Location = new System.Drawing.Point(233, 209);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(68, 20);
            this.textBox19.TabIndex = 29;
            this.textBox19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox19_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(187, 212);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Attack:";
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox20.Location = new System.Drawing.Point(233, 235);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(68, 20);
            this.textBox20.TabIndex = 27;
            this.textBox20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox20_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(179, 237);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "defence:";
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox21.Location = new System.Drawing.Point(233, 261);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(68, 20);
            this.textBox21.TabIndex = 25;
            this.textBox21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox21_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(155, 263);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 13);
            this.label22.TabIndex = 24;
            this.label22.Text = "Magic Attack:";
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox22.Location = new System.Drawing.Point(81, 209);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(68, 20);
            this.textBox22.TabIndex = 23;
            this.textBox22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox22_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 211);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "After Dead:";
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Location = new System.Drawing.Point(233, 131);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(68, 20);
            this.textBox18.TabIndex = 21;
            this.textBox18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox18_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(187, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "AI Slot:";
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Location = new System.Drawing.Point(233, 157);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(68, 20);
            this.textBox17.TabIndex = 19;
            this.textBox17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox17_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(191, 159);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Delay:";
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(233, 105);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(68, 20);
            this.textBox13.TabIndex = 15;
            this.textBox13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox13_KeyPress);
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(233, 79);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(68, 20);
            this.textBox12.TabIndex = 14;
            this.textBox12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox12_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(179, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Rcv MP:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(180, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Rcv HP:";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(81, 157);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(68, 20);
            this.textBox11.TabIndex = 11;
            this.textBox11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox11_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "MaxStm:";
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.Location = new System.Drawing.Point(81, 105);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(68, 20);
            this.textBox15.TabIndex = 11;
            this.textBox15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox15_KeyPress);
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Location = new System.Drawing.Point(81, 79);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(68, 20);
            this.textBox14.TabIndex = 10;
            this.textBox14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox14_KeyPress);
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(81, 131);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(68, 20);
            this.textBox10.TabIndex = 9;
            this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox10_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "MaxMP:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "MaxHP:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "MaxFaith:";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(252, 53);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(49, 20);
            this.textBox8.TabIndex = 7;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(195, 53);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(49, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(139, 53);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(49, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Con:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Int:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Dex:";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(81, 53);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(49, 20);
            this.textBox5.TabIndex = 1;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Str:";
            // 
            // textBox35
            // 
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox35.Location = new System.Drawing.Point(769, 401);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(68, 20);
            this.textBox35.TabIndex = 81;
            this.textBox35.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox35_KeyPress);
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(705, 11);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(63, 20);
            this.textBox9.TabIndex = 69;
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(581, 376);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 13);
            this.label30.TabIndex = 88;
            this.label30.Text = "Flag:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(643, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "ItemIndex:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(727, 403);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(36, 13);
            this.label36.TabIndex = 80;
            this.label36.Text = "Awful:";
            // 
            // textBox36
            // 
            this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox36.Location = new System.Drawing.Point(769, 427);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(68, 20);
            this.textBox36.TabIndex = 79;
            this.textBox36.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox36_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(265, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 110);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Basic";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(165, 9);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(27, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(93, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 - Human"});
            this.comboBox1.Location = new System.Drawing.Point(198, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Index:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(48, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(48, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(2, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 421);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pets";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(170, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(87, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Copy to new";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 368);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox200);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 68);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // textBox200
            // 
            this.textBox200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox200.Location = new System.Drawing.Point(43, 30);
            this.textBox200.Name = "textBox200";
            this.textBox200.Size = new System.Drawing.Size(205, 20);
            this.textBox200.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(575, 352);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(36, 13);
            this.label34.TabIndex = 84;
            this.label34.Text = "Week";
            // 
            // textBox33
            // 
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox33.Location = new System.Drawing.Point(617, 350);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(68, 20);
            this.textBox33.TabIndex = 85;
            this.textBox33.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox33_KeyPress);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(699, 352);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(64, 13);
            this.label38.TabIndex = 76;
            this.label38.Text = "Basic Skill 1";
            // 
            // textBox34
            // 
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox34.Location = new System.Drawing.Point(769, 375);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(68, 20);
            this.textBox34.TabIndex = 83;
            this.textBox34.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox34_KeyPress);
            // 
            // textBox37
            // 
            this.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox37.Location = new System.Drawing.Point(769, 349);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(68, 20);
            this.textBox37.TabIndex = 77;
            this.textBox37.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox37_KeyPress);
            // 
            // textBox38
            // 
            this.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox38.Location = new System.Drawing.Point(617, 402);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(68, 20);
            this.textBox38.TabIndex = 75;
            this.textBox38.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox38_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(699, 376);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(64, 13);
            this.label35.TabIndex = 82;
            this.label35.Text = "Basic Skill 2";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(845, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Animations Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label51);
            this.groupBox7.Controls.Add(this.textBox64);
            this.groupBox7.Controls.Add(this.textBox51);
            this.groupBox7.Controls.Add(this.label65);
            this.groupBox7.Controls.Add(this.textBox49);
            this.groupBox7.Controls.Add(this.label49);
            this.groupBox7.Controls.Add(this.textBox54);
            this.groupBox7.Controls.Add(this.label54);
            this.groupBox7.Controls.Add(this.textBox55);
            this.groupBox7.Controls.Add(this.label56);
            this.groupBox7.Controls.Add(this.textBox59);
            this.groupBox7.Controls.Add(this.textBox57);
            this.groupBox7.Controls.Add(this.textBox48);
            this.groupBox7.Controls.Add(this.label58);
            this.groupBox7.Controls.Add(this.label60);
            this.groupBox7.Controls.Add(this.label50);
            this.groupBox7.Controls.Add(this.textBox61);
            this.groupBox7.Controls.Add(this.label62);
            this.groupBox7.Controls.Add(this.textBox60);
            this.groupBox7.Controls.Add(this.textBox58);
            this.groupBox7.Controls.Add(this.label61);
            this.groupBox7.Controls.Add(this.label59);
            this.groupBox7.Controls.Add(this.textBox56);
            this.groupBox7.Controls.Add(this.label57);
            this.groupBox7.Controls.Add(this.label63);
            this.groupBox7.Controls.Add(this.textBox62);
            this.groupBox7.Location = new System.Drawing.Point(489, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(350, 208);
            this.groupBox7.TabIndex = 64;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Animation 2";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(11, 177);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(30, 13);
            this.label51.TabIndex = 64;
            this.label51.Text = "SMC";
            // 
            // textBox64
            // 
            this.textBox64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox64.Location = new System.Drawing.Point(229, 71);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(107, 20);
            this.textBox64.TabIndex = 97;
            this.textBox64.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox64_KeyPress);
            // 
            // textBox51
            // 
            this.textBox51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox51.Location = new System.Drawing.Point(64, 175);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(271, 20);
            this.textBox51.TabIndex = 65;
            this.textBox51.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox51_KeyPress);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(176, 75);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(47, 13);
            this.label65.TabIndex = 96;
            this.label65.Text = "Damage";
            // 
            // textBox49
            // 
            this.textBox49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox49.Location = new System.Drawing.Point(50, 19);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(120, 20);
            this.textBox49.TabIndex = 63;
            this.textBox49.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox49_KeyPress);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(11, 21);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(33, 13);
            this.label49.TabIndex = 62;
            this.label49.Text = "Idle 1";
            // 
            // textBox54
            // 
            this.textBox54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox54.Location = new System.Drawing.Point(50, 45);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(120, 20);
            this.textBox54.TabIndex = 67;
            this.textBox54.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox54_KeyPress);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(11, 47);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(33, 13);
            this.label54.TabIndex = 66;
            this.label54.Text = "Idle 2";
            // 
            // textBox55
            // 
            this.textBox55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox55.Location = new System.Drawing.Point(211, 45);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(125, 20);
            this.textBox55.TabIndex = 85;
            this.textBox55.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox55_KeyPress);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(176, 47);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(27, 13);
            this.label56.TabIndex = 84;
            this.label56.Text = "Run";
            // 
            // textBox59
            // 
            this.textBox59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox59.Location = new System.Drawing.Point(251, 123);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(84, 20);
            this.textBox59.TabIndex = 93;
            this.textBox59.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox59_KeyPress);
            // 
            // textBox57
            // 
            this.textBox57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox57.Location = new System.Drawing.Point(211, 19);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(125, 20);
            this.textBox57.TabIndex = 81;
            this.textBox57.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox57_KeyPress);
            // 
            // textBox48
            // 
            this.textBox48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox48.Location = new System.Drawing.Point(64, 71);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(106, 20);
            this.textBox48.TabIndex = 75;
            this.textBox48.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox48_KeyPress);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(176, 21);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(32, 13);
            this.label58.TabIndex = 80;
            this.label58.Text = "Walk";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(176, 130);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(70, 13);
            this.label60.TabIndex = 92;
            this.label60.Text = "Skill Summon";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(11, 73);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(47, 13);
            this.label50.TabIndex = 74;
            this.label50.Text = "Attack 1";
            // 
            // textBox61
            // 
            this.textBox61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox61.Location = new System.Drawing.Point(228, 97);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(107, 20);
            this.textBox61.TabIndex = 89;
            this.textBox61.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox61_KeyPress);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(176, 104);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(51, 13);
            this.label62.TabIndex = 88;
            this.label62.Text = "Level UP";
            // 
            // textBox60
            // 
            this.textBox60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox60.Location = new System.Drawing.Point(229, 149);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(106, 20);
            this.textBox60.TabIndex = 91;
            this.textBox60.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox60_KeyPress);
            // 
            // textBox58
            // 
            this.textBox58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox58.Location = new System.Drawing.Point(64, 97);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(106, 20);
            this.textBox58.TabIndex = 79;
            this.textBox58.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox58_KeyPress);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(176, 151);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(38, 13);
            this.label61.TabIndex = 90;
            this.label61.Text = "Speed";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(11, 99);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(47, 13);
            this.label59.TabIndex = 78;
            this.label59.Text = "Attack 2";
            // 
            // textBox56
            // 
            this.textBox56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox56.Location = new System.Drawing.Point(64, 123);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(106, 20);
            this.textBox56.TabIndex = 83;
            this.textBox56.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox56_KeyPress);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(11, 125);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(23, 13);
            this.label57.TabIndex = 82;
            this.label57.Text = "Die";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(11, 151);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(37, 13);
            this.label63.TabIndex = 86;
            this.label63.Text = "Mount";
            // 
            // textBox62
            // 
            this.textBox62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox62.Location = new System.Drawing.Point(64, 149);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(106, 20);
            this.textBox62.TabIndex = 87;
            this.textBox62.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox62_KeyPress);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.textBox44);
            this.groupBox6.Controls.Add(this.label44);
            this.groupBox6.Controls.Add(this.textBox47);
            this.groupBox6.Controls.Add(this.label48);
            this.groupBox6.Controls.Add(this.textBox63);
            this.groupBox6.Controls.Add(this.label45);
            this.groupBox6.Controls.Add(this.textBox50);
            this.groupBox6.Controls.Add(this.label64);
            this.groupBox6.Controls.Add(this.textBox43);
            this.groupBox6.Controls.Add(this.label52);
            this.groupBox6.Controls.Add(this.textBox30);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Controls.Add(this.textBox53);
            this.groupBox6.Controls.Add(this.label55);
            this.groupBox6.Controls.Add(this.textBox39);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.textBox45);
            this.groupBox6.Controls.Add(this.textBox42);
            this.groupBox6.Controls.Add(this.label43);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.label46);
            this.groupBox6.Controls.Add(this.textBox31);
            this.groupBox6.Controls.Add(this.textBox52);
            this.groupBox6.Controls.Add(this.label53);
            this.groupBox6.Location = new System.Drawing.Point(8, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(359, 207);
            this.groupBox6.TabIndex = 63;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Animations 1";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Location = new System.Drawing.Point(59, 175);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(290, 20);
            this.textBox16.TabIndex = 66;
            this.textBox16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox16_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 65;
            this.label17.Text = "SMC:";
            // 
            // textBox44
            // 
            this.textBox44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox44.Location = new System.Drawing.Point(59, 97);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(106, 20);
            this.textBox44.TabIndex = 47;
            this.textBox44.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox44_KeyPress);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 74);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(47, 13);
            this.label44.TabIndex = 48;
            this.label44.Text = "Attack 1";
            // 
            // textBox47
            // 
            this.textBox47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox47.Location = new System.Drawing.Point(224, 148);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(125, 20);
            this.textBox47.TabIndex = 77;
            this.textBox47.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox47_KeyPress);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(171, 151);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(38, 13);
            this.label48.TabIndex = 76;
            this.label48.Text = "Speed";
            // 
            // textBox63
            // 
            this.textBox63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox63.Location = new System.Drawing.Point(224, 71);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(125, 20);
            this.textBox63.TabIndex = 95;
            this.textBox63.TextChanged += new System.EventHandler(this.textBox63_TextChanged);
            this.textBox63.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox63_KeyPress);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 100);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(47, 13);
            this.label45.TabIndex = 46;
            this.label45.Text = "Attack 2";
            // 
            // textBox50
            // 
            this.textBox50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox50.Location = new System.Drawing.Point(247, 123);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(102, 20);
            this.textBox50.TabIndex = 73;
            this.textBox50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox50_KeyPress);
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(171, 73);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(47, 13);
            this.label64.TabIndex = 94;
            this.label64.Text = "Damage";
            // 
            // textBox43
            // 
            this.textBox43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox43.Location = new System.Drawing.Point(59, 71);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(106, 20);
            this.textBox43.TabIndex = 49;
            this.textBox43.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox43_KeyPress);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(171, 125);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(70, 13);
            this.label52.TabIndex = 72;
            this.label52.Text = "Skill Summon";
            // 
            // textBox30
            // 
            this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox30.Location = new System.Drawing.Point(45, 45);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(120, 20);
            this.textBox30.TabIndex = 61;
            this.textBox30.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox30_KeyPress);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 19);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(33, 13);
            this.label40.TabIndex = 56;
            this.label40.Text = "Idle 1";
            // 
            // textBox53
            // 
            this.textBox53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox53.Location = new System.Drawing.Point(59, 149);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(106, 20);
            this.textBox53.TabIndex = 69;
            this.textBox53.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox53_KeyPress);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 155);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(37, 13);
            this.label55.TabIndex = 68;
            this.label55.Text = "Mount";
            // 
            // textBox39
            // 
            this.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox39.Location = new System.Drawing.Point(45, 19);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(120, 20);
            this.textBox39.TabIndex = 57;
            this.textBox39.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox39_KeyPress);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 45);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(33, 13);
            this.label31.TabIndex = 60;
            this.label31.Text = "Idle 2";
            // 
            // textBox45
            // 
            this.textBox45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox45.Location = new System.Drawing.Point(59, 123);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(106, 20);
            this.textBox45.TabIndex = 45;
            this.textBox45.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox45_KeyPress);
            // 
            // textBox42
            // 
            this.textBox42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox42.Location = new System.Drawing.Point(209, 19);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(140, 20);
            this.textBox42.TabIndex = 51;
            this.textBox42.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox42_KeyPress);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(171, 21);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(32, 13);
            this.label43.TabIndex = 50;
            this.label43.Text = "Walk";
            this.label43.Click += new System.EventHandler(this.label43_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(171, 47);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(27, 13);
            this.label32.TabIndex = 58;
            this.label32.Text = "Run";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 127);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(23, 13);
            this.label46.TabIndex = 44;
            this.label46.Text = "Die";
            // 
            // textBox31
            // 
            this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox31.Location = new System.Drawing.Point(209, 45);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(140, 20);
            this.textBox31.TabIndex = 59;
            this.textBox31.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox31_KeyPress);
            // 
            // textBox52
            // 
            this.textBox52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox52.Location = new System.Drawing.Point(228, 98);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(121, 20);
            this.textBox52.TabIndex = 71;
            this.textBox52.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox52_KeyPress);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(171, 99);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(51, 13);
            this.label53.TabIndex = 70;
            this.label53.Text = "Level UP";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label47);
            this.groupBox5.Controls.Add(this.textBox46);
            this.groupBox5.Controls.Add(this.textBox40);
            this.groupBox5.Controls.Add(this.label41);
            this.groupBox5.Controls.Add(this.textBox41);
            this.groupBox5.Controls.Add(this.label42);
            this.groupBox5.Location = new System.Drawing.Point(8, 219);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(144, 208);
            this.groupBox5.TabIndex = 62;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Trans";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(10, 36);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(64, 13);
            this.label47.TabIndex = 42;
            this.label47.Text = "Trans Type:";
            // 
            // textBox46
            // 
            this.textBox46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox46.Location = new System.Drawing.Point(105, 35);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(33, 20);
            this.textBox46.TabIndex = 43;
            this.textBox46.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox46_KeyPress);
            // 
            // textBox40
            // 
            this.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox40.Location = new System.Drawing.Point(105, 61);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(33, 20);
            this.textBox40.TabIndex = 55;
            this.textBox40.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox40_KeyPress);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(10, 62);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(62, 13);
            this.label41.TabIndex = 54;
            this.label41.Text = "Trans Start:";
            // 
            // textBox41
            // 
            this.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox41.Location = new System.Drawing.Point(105, 87);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(33, 20);
            this.textBox41.TabIndex = 53;
            this.textBox41.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox41_KeyPress);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(10, 88);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(56, 13);
            this.label42.TabIndex = 52;
            this.label42.Text = "Trans End";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tbEnable
            // 
            this.tbEnable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEnable.Location = new System.Drawing.Point(573, 4);
            this.tbEnable.Name = "tbEnable";
            this.tbEnable.Size = new System.Drawing.Size(46, 20);
            this.tbEnable.TabIndex = 8;
            this.tbEnable.Visible = false;
            // 
            // bigPetStringToolStripMenuItem
            // 
            this.bigPetStringToolStripMenuItem.Name = "bigPetStringToolStripMenuItem";
            this.bigPetStringToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bigPetStringToolStripMenuItem.Text = "BigPet String";
            this.bigPetStringToolStripMenuItem.Click += new System.EventHandler(this.bigPetStringToolStripMenuItem_Click);
            // 
            // BigPetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 543);
            this.Controls.Add(this.tbEnable);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BigPetEditor";
            this.Text = "BigPetEditor";
            this.Load += new System.EventHandler(this.BigPetEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).EndInit();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideLeftRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void exportBipetlodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LodExporter.FormExport E = new LodExporter.FormExport();
            E.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_attack_pet DEFAULT VALUES");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_attack_pet WHERE a_index = '" + textBox1.Text + "'");
            LoadListBox();
            listBox1.SelectedIndex = selectedIndex - 1;
            int num4 = (int)new CustomMessage("Deleted :O").ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DROP TABLE IF EXISTS tempTable;" + "CREATE TEMPORARY TABLE tempTable ENGINE=MEMORY SELECT * FROM t_attack_pet WHERE a_index=" + textBox1.Text + ";" + "SELECT a_index FROM tempTable;" + "UPDATE tempTable SET a_index=(SELECT a_index from t_attack_pet ORDER BY a_index DESC LIMIT 1)+1; " + "SELECT a_index FROM tempTable;" + "INSERT INTO t_attack_pet SELECT * FROM tempTable;");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            int num4 = (int)new CustomMessage("Copying Complete!!").ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_attack_pet SET "
                + "a_index = '" + textBox1.Text + "', " 
                + "a_enable = '" + tbEnable.Text + "', " 
                + "a_name = '" + textBox2.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', " 
                + "a_type = '" + comboBox1.Text + "', " + "a_str = '" + textBox5.Text + "', " 
                + "a_con = '" + textBox8.Text + "', " 
                + "a_dex = '" + textBox6.Text + "', " 
                + "a_int = '" + textBox7.Text + "', " 
                + "a_item_idx = '" + textBox9.Text + "', " 
                + "a_maxFaith = '" + textBox10.Text + "', " 
                + "a_maxStm = '" + textBox11.Text + "', " 
                + "a_maxHP = '" + textBox14.Text + "', " 
                + "a_maxMP = '" + textBox15.Text + "', " 
                + "a_recoverHP = '" + textBox12.Text + "', " 
                + "a_recoverMP = '" + textBox13.Text + "', " 
                + "a_delay = '" + textBox17.Text + "', " 
                + "a_AISlot = '" + textBox18.Text + "', " 
                + "a_after_dead = '" + textBox22.Text + "', " 
                + "a_attack = '" + textBox19.Text + "', " 
                + "a_defence = '" + textBox20.Text + "', " 
                + "a_Mattack = '" + textBox21.Text + "', " 
                + "a_Mdefence = '" + textBox23.Text + "', " 
                + "a_hitpoint = '" + textBox25.Text + "', " 
                + "a_avoidpoint = '" + textBox26.Text + "', " 
                + "a_Mavoidpoint = '" + textBox24.Text + "', " 
                + "a_attackSpeed = '" + textBox27.Text + "', " 
                + "a_deadly = '" + textBox28.Text + "', " 
                + "a_critical = '" + textBox38.Text + "', " 
                + "a_awful = '" + textBox35.Text + "', " 
                + "a_strong = '" + textBox32.Text + "', " 
                + "a_normal = '" + textBox36.Text + "', " 
                + "a_week = '" + textBox33.Text + "', " 
                + "a_bagic_skill1 = '" + textBox37.Text + "', " 
                + "a_bagic_skill2 = '" + textBox34.Text + "', " 
                + "a_flag = '" + textBox29.Text + "', " 
                + "a_trans_type = '" + textBox46.Text + "', " 
                + "a_trans_start = '" + textBox40.Text + "', " 
                + "a_trans_end = '" + textBox41.Text + "', " 
                + "a_smcFileName_1 = '" + textBox16.Text.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'") + "', " 
                + "a_ani_idle1_1 = '" + textBox39.Text + "', " 
                + "a_ani_idle2_1 = '" + textBox30.Text + "', " 
                + "a_ani_attack1_1 = '" + textBox43.Text + "', " 
                + "a_ani_attack2_1 = '" + textBox44.Text + "', " 
                + "a_ani_damage_1 = '" + textBox63.Text + "', " 
                + "a_ani_die_1 = '" + textBox45.Text + "', " 
                + "a_ani_walk_1 = '" + textBox42.Text + "', " 
                + "a_ani_run_1 = '" + textBox31.Text + "', " 
                + "a_ani_levelup_1 = '" + textBox52.Text + "', " 
                + "a_mount_1 = '" + textBox53.Text + "', " 
                + "a_summon_skill_1 = '" + textBox50.Text + "', " 
                + "a_speed_1 = '" + textBox47.Text + "', " 
                + "a_smcFileName_2 = '" + textBox51.Text.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'") + "', " 
                + "a_ani_idle1_2 = '" + textBox49.Text + "', " 
                + "a_ani_idle2_2 = '" + textBox54.Text + "', " 
                + "a_ani_attack1_2 = '" + textBox48.Text + "', " 
                + "a_ani_attack2_2 = '" + textBox58.Text + "', " 
                + "a_ani_damage_2 = '" + textBox64.Text + "', " 
                + "a_ani_die_2 = '" + textBox56.Text + "', " 
                + "a_ani_walk_2 = '" + textBox5.Text + "', " 
                + "a_ani_run_2 = '" + textBox55.Text + "', " 
                + "a_ani_levelup_2 = '" + textBox61.Text + "', " 
                + "a_mount_2 = '" + textBox62.Text + "', " 
                + "a_summon_skill_2 = '" + textBox59.Text + "', " 
                + "a_speed_2 = '" + textBox60.Text + "' " 
                + "WHERE a_index = '" + textBox1.Text + "'");
            int selectedIndex = listBox1.SelectedIndex;
            int num4 = (int)new CustomMessage("Done :)").ShowDialog();
            if (textBox200.Text != "")
                SearchList(textBox200.Text);
            else
                LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
        }

        private void chk3D_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 
        {
            textBox4.Text = GetIndexByComboBox(comboBox1.Text).ToString(); // sets the text box value equal to index of combo box 1
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) //dethunter12 add
            {
                tbEnable.Text = "1";
                checkBox1.BackColor = Color.Lime;
            }
            else
            {
                tbEnable.Text = "0";
                checkBox1.BackColor = Color.Red;
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox5.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox6.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox7.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox8.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox14.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox15.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox10.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox11.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox12.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox13.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox18.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox17.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox22.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox25.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox26.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox24.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox27.BackColor = Color.PaleTurquoise; //dethunter12 a dd
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox19.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox20.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox21.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox23.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox28.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox33_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox33.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox29.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox38_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox38.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox32.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox37_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox37.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox34_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox34.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox35_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox35.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox36_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox36.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox9.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox39_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox39.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox30.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox43_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox43.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox44_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox44.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox45_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox45.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox53_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox53.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox16.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox42_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox42.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox31.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox63_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox63.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox52_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox52.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox50_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox50.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox47_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox47.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox49_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox49.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox57_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox57.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox54_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox54.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox55_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox55.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox48_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox48.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox64_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox64.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox58_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox58.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox61_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox61.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox56_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox56.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox59_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox59.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox62_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox62.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox60_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox60.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox51_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox51.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox46_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox46.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox40_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox40.BackColor = Color.PaleTurquoise; //dethunter12 add
        }

        private void textBox41_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox41.BackColor = Color.PaleTurquoise; //dethunter12 add 
        }

        private void PbSelectID1_Click(object sender, EventArgs e) //dethunter12 6/10/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox9.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void usaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text1 = "apet";
            string text2 = "path_ship";
            string text3 = "usa";
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

        private void bigPetStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExport f2 = new FormExport();
            f2.ShowDialog(); // Shows Form2
        }
    }


}
