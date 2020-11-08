// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.LCMeshReader
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using System.IO;
using System.Text;

namespace LcDevPack_TeamDamonA
{
    public class LCMeshReader
    {
        private static ASCIIEncoding Enc = new ASCIIEncoding();
        public static string OpenedFile = "";
        public static tMeshContainer pMesh;

        public static bool ReadFile(string FileName)
        {
            LCMeshReader.OpenedFile = FileName;
            LCMeshReader.pMesh = new tMeshContainer();
            BinaryReader b = new BinaryReader(new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.Read));
            pMesh.HeaderInfo = new tHeaderInfo();
            LCMeshReader.pMesh.HeaderInfo.Format = b.ReadBytes(4);
            LCMeshReader.pMesh.HeaderInfo.Version = b.ReadInt32();
            LCMeshReader.pMesh.HeaderInfo.MeshDataSize = b.ReadInt32();
            LCMeshReader.pMesh.HeaderInfo.MeshCount = b.ReadUInt32();
            LCMeshReader.pMesh.HeaderInfo.VertexCount = b.ReadUInt32();
            LCMeshReader.pMesh.HeaderInfo.JointCount = b.ReadUInt32();
            LCMeshReader.pMesh.HeaderInfo.TextureMaps = b.ReadUInt32();
            LCMeshReader.pMesh.HeaderInfo.NormalCount = b.ReadUInt32();
            LCMeshReader.pMesh.HeaderInfo.ObjCount = b.ReadUInt32();
            LCMeshReader.pMesh.HeaderInfo.UnknownCount = b.ReadUInt32();
            LCMeshReader.pMesh.FileName = b.ReadBytes(b.ReadInt32());
            LCMeshReader.pMesh.Scale = b.ReadSingle();
            LCMeshReader.pMesh.Value1 = b.ReadUInt32();
            LCMeshReader.pMesh.FilePath = FileName;
            bool flag = false;
            if (LCMeshReader.pMesh.HeaderInfo.Version == 16)
            {
                if (LCMeshReader.ReadV10(b, b.BaseStream.Position))
                    flag = true;
            }
            else if (LCMeshReader.pMesh.HeaderInfo.Version == 17 && LCMeshReader.ReadV11(b, b.BaseStream.Position))
                flag = true;
            b.Close();
            return flag;
        }

        private static bool ReadV10(BinaryReader b, long Pos)
        {
            tHeaderInfo tHeaderInfo = new tHeaderInfo();
            tHeaderInfo headerInfo = LCMeshReader.pMesh.HeaderInfo;
            headerInfo.NormalCount = LCMeshReader.pMesh.HeaderInfo.UnknownCount;
            headerInfo.JointCount = LCMeshReader.pMesh.HeaderInfo.NormalCount;
            headerInfo.UnknownCount = LCMeshReader.pMesh.HeaderInfo.TextureMaps;
            headerInfo.ObjCount = LCMeshReader.pMesh.HeaderInfo.ObjCount;
            headerInfo.TextureMaps = LCMeshReader.pMesh.HeaderInfo.JointCount;
            LCMeshReader.pMesh.HeaderInfo = headerInfo;
            LCMeshReader.pMesh.Vertices = new tVertex3f[(int)LCMeshReader.pMesh.HeaderInfo.VertexCount];
            for (int index = 0; (long)index < (long)LCMeshReader.pMesh.HeaderInfo.VertexCount; ++index)
                LCMeshReader.pMesh.Vertices[index] = new tVertex3f(b.ReadSingle(), b.ReadSingle(), b.ReadSingle());
            LCMeshReader.pMesh.Normals = new tVertex3f[(int)LCMeshReader.pMesh.HeaderInfo.VertexCount];
            for (int index = 0; (long)index < (long)LCMeshReader.pMesh.HeaderInfo.VertexCount; ++index)
                LCMeshReader.pMesh.Normals[index] = new tVertex3f(b.ReadSingle(), b.ReadSingle(), b.ReadSingle());
            if (LCMeshReader.pMesh.HeaderInfo.TextureMaps > 0U)
            {
                LCMeshReader.pMesh.UVMaps = new tMeshUVMap[(int)LCMeshReader.pMesh.HeaderInfo.TextureMaps];
                for (int index1 = 0; (long)index1 > (long)LCMeshReader.pMesh.HeaderInfo.TextureMaps; ++index1)
                {
                    LCMeshReader.pMesh.UVMaps[index1] = new tMeshUVMap();
                    LCMeshReader.pMesh.UVMaps[index1].Name = b.ReadBytes(b.ReadInt32());
                    LCMeshReader.pMesh.UVMaps[index1].Coords = new tTextCoord[(int)LCMeshReader.pMesh.HeaderInfo.VertexCount];
                    for (int index2 = 0; (long)index2 < (long)LCMeshReader.pMesh.HeaderInfo.VertexCount; ++index2)
                        LCMeshReader.pMesh.UVMaps[index1].Coords[index2] = new tTextCoord(b.ReadSingle(), b.ReadSingle());
                }
            }
            LCMeshReader.pMesh.Objects = new tMeshObject[(int)LCMeshReader.pMesh.HeaderInfo.ObjCount];
            for (int index1 = 0; (long)index1 < (long)LCMeshReader.pMesh.HeaderInfo.ObjCount; ++index1)
            {
                tMeshObject tMeshObject = new tMeshObject();
                tMeshObject.MaterialName = b.ReadBytes(b.ReadInt32());
                tMeshObject.Value1 = b.ReadUInt32();
                tMeshObject.FromVert = b.ReadUInt32();
                tMeshObject.ToVert = b.ReadUInt32();
                tMeshObject.FaceCount = b.ReadUInt32();
                tMeshObject.Faces = new tFace[(int)tMeshObject.FaceCount];
                for (int index2 = 0; (long)index2 < (long)tMeshObject.FaceCount; ++index2)
                    tMeshObject.Faces[index2] = new tFace(b.ReadInt16(), b.ReadInt16(), b.ReadInt16());
                tMeshObject.JValue = b.ReadUInt32();
                tMeshObject.JData = new byte[(int)tMeshObject.JValue];
                for (int index2 = 0; (long)index2 < (long)tMeshObject.JValue; ++index2)
                    tMeshObject.JData[index2] = b.ReadByte();
                tMeshObject.ShaderFlag = b.ReadUInt32();
                if (tMeshObject.ShaderFlag > 0U)
                {
                    tMeshObject.ShaderInfo = new tMeshShaderInfo();
                    tMeshObject.ShaderInfo.cParam1 = b.ReadUInt32();
                    tMeshObject.ShaderInfo.cParamFloats = b.ReadUInt32();
                    tMeshObject.ShaderInfo.cTextureUnits = b.ReadUInt32();
                    tMeshObject.ShaderInfo.cParam2 = b.ReadUInt32();
                    tMeshObject.ShaderInfo = new tMeshShaderInfo()
                    {
                        cTextureUnits = tMeshObject.ShaderInfo.cParam1,
                        cParamFloats = tMeshObject.ShaderInfo.cParamFloats,
                        cParam1 = tMeshObject.ShaderInfo.cParam2,
                        cParam2 = tMeshObject.ShaderInfo.cTextureUnits
                    };
                    tMeshObject.ShaderData = new tMeshShaderData();
                    tMeshObject.ShaderData.ShaderName = b.ReadBytes(b.ReadInt32());
                    tMeshObject.Textures = new tMeshTexture[(int)tMeshObject.ShaderInfo.cTextureUnits];
                    for (int index2 = 0; (long)index2 < (long)tMeshObject.ShaderInfo.cTextureUnits; ++index2)
                        tMeshObject.Textures[index2] = new tMeshTexture(b.ReadBytes(b.ReadInt32()));
                    if (tMeshObject.ShaderInfo.cParam1 > 0U)
                        tMeshObject.ShaderData.Param1 = new uint[(int)tMeshObject.ShaderInfo.cParam1];
                    if (tMeshObject.ShaderInfo.cParamFloats > 0U)
                        tMeshObject.ShaderData.ParamFloats = new float[(int)tMeshObject.ShaderInfo.cParamFloats];
                    if (tMeshObject.ShaderInfo.cParam2 > 0U)
                        tMeshObject.ShaderData.Param2 = new uint[(int)tMeshObject.ShaderInfo.cParam2];
                    tMeshObject.ShaderData.cParam0 = b.ReadUInt32();
                    for (int index2 = 0; (long)index2 < (long)tMeshObject.ShaderInfo.cParam2; ++index2)
                        tMeshObject.ShaderData.Param2[index2] = b.ReadUInt32();
                    for (int index2 = 0; (long)index2 < (long)tMeshObject.ShaderInfo.cParamFloats; ++index2)
                        tMeshObject.ShaderData.ParamFloats[index2] = b.ReadSingle();
                    for (int index2 = 0; (long)index2 < (long)tMeshObject.ShaderInfo.cParam1; ++index2)
                        tMeshObject.ShaderData.Param1[index2] = b.ReadUInt32();
                    LCMeshReader.pMesh.Objects[index1] = tMeshObject;
                }
            }
            LCMeshReader.pMesh.Weights = new tMeshJointWeights[(int)LCMeshReader.pMesh.HeaderInfo.JointCount];
            for (int index1 = 0; (long)index1 < (long)LCMeshReader.pMesh.HeaderInfo.JointCount; ++index1)
            {
                LCMeshReader.pMesh.Weights[index1] = new tMeshJointWeights();
                LCMeshReader.pMesh.Weights[index1].JointName = b.ReadBytes(b.ReadInt32());
                LCMeshReader.pMesh.Weights[index1].Count = b.ReadUInt32();
                LCMeshReader.pMesh.Weights[index1].WeightsMap = new tMeshWeightsMap[(int)LCMeshReader.pMesh.Weights[index1].Count];
                for (int index2 = 0; (long)index2 < (long)LCMeshReader.pMesh.Weights[index1].Count; ++index2)
                    LCMeshReader.pMesh.Weights[index1].WeightsMap[index2] = new tMeshWeightsMap(b.ReadInt32(), b.ReadSingle());
            }
            LCMeshReader.pMesh.MorphMap = new tMeshMorphMap[(int)LCMeshReader.pMesh.HeaderInfo.VertexCount];
            for (int index = 0; (long)index < (long)LCMeshReader.pMesh.HeaderInfo.VertexCount; ++index)
                LCMeshReader.pMesh.MorphMap[index] = new tMeshMorphMap(b.ReadBytes(4), b.ReadBytes(4));
            return b.BaseStream.Position == (long)(LCMeshReader.pMesh.HeaderInfo.MeshDataSize + 8);
        }

        private static bool ReadV11(BinaryReader b, long Pos)
        {
            b.BaseStream.Position = Pos;
            Decoder.Reset();
            LCMeshReader.pMesh.HeaderInfo.MeshCount = Decoder.Decode(LCMeshReader.pMesh.HeaderInfo.MeshCount);
            LCMeshReader.pMesh.HeaderInfo.VertexCount = Decoder.Decode(LCMeshReader.pMesh.HeaderInfo.VertexCount);
            LCMeshReader.pMesh.HeaderInfo.JointCount = Decoder.Decode(LCMeshReader.pMesh.HeaderInfo.JointCount);
            LCMeshReader.pMesh.HeaderInfo.TextureMaps = Decoder.Decode(LCMeshReader.pMesh.HeaderInfo.TextureMaps);
            LCMeshReader.pMesh.HeaderInfo.NormalCount = Decoder.Decode(LCMeshReader.pMesh.HeaderInfo.NormalCount);
            LCMeshReader.pMesh.HeaderInfo.ObjCount = Decoder.Decode(LCMeshReader.pMesh.HeaderInfo.ObjCount);
            LCMeshReader.pMesh.HeaderInfo.UnknownCount = Decoder.Decode(LCMeshReader.pMesh.HeaderInfo.UnknownCount);
            LCMeshReader.pMesh.Value1 = Decoder.Decode(LCMeshReader.pMesh.Value1);
            LCMeshReader.pMesh.Vertices = new tVertex3f[(int)LCMeshReader.pMesh.HeaderInfo.VertexCount];
            for (int index = 0; (long)index < (long)LCMeshReader.pMesh.HeaderInfo.VertexCount; ++index)
                LCMeshReader.pMesh.Vertices[index] = new tVertex3f(b.ReadSingle(), b.ReadSingle(), b.ReadSingle());
            LCMeshReader.pMesh.Normals = new tVertex3f[(int)LCMeshReader.pMesh.HeaderInfo.NormalCount];
            for (int index = 0; (long)index < (long)LCMeshReader.pMesh.HeaderInfo.NormalCount; ++index)
                LCMeshReader.pMesh.Normals[index] = new tVertex3f(b.ReadSingle(), b.ReadSingle(), b.ReadSingle());
            if (LCMeshReader.pMesh.HeaderInfo.TextureMaps > 0U)
            {
                LCMeshReader.pMesh.UVMaps = new tMeshUVMap[(int)LCMeshReader.pMesh.HeaderInfo.TextureMaps];
                for (int index1 = 0; (long)index1 < (long)LCMeshReader.pMesh.HeaderInfo.TextureMaps; ++index1)
                {
                    tMeshUVMap tMeshUvMap = new tMeshUVMap();
                    tMeshUvMap.Name = b.ReadBytes(b.ReadInt32());
                    tMeshUvMap.Coords = new tTextCoord[(int)LCMeshReader.pMesh.HeaderInfo.VertexCount];
                    for (int index2 = 0; (long)index2 < (long)LCMeshReader.pMesh.HeaderInfo.VertexCount; ++index2)
                        tMeshUvMap.Coords[index2] = new tTextCoord(b.ReadSingle(), b.ReadSingle());
                    LCMeshReader.pMesh.UVMaps[index1] = tMeshUvMap;
                }
            }
            LCMeshReader.pMesh.Objects = new tMeshObject[(int)LCMeshReader.pMesh.HeaderInfo.ObjCount];
            for (int index1 = 0; (long)index1 < (long)LCMeshReader.pMesh.HeaderInfo.ObjCount; ++index1)
            {
                tMeshObject tMeshObject = new tMeshObject();
                tMeshObject.FromVert = Decoder.Decode(b.ReadUInt32());
                tMeshObject.ToVert = Decoder.Decode(b.ReadUInt32());
                tMeshObject.FaceCount = Decoder.Decode(b.ReadUInt32());
                tMeshObject.Faces = new tFace[(int)tMeshObject.FaceCount];
                for (int index2 = 0; (long)index2 < (long)tMeshObject.FaceCount; ++index2)
                    tMeshObject.Faces[index2] = new tFace(b.ReadInt16(), b.ReadInt16(), b.ReadInt16());
                tMeshObject.MaterialName = b.ReadBytes(b.ReadInt32());
                tMeshObject.Value1 = Decoder.Decode(b.ReadUInt32());
                tMeshObject.JValue = Decoder.Decode(b.ReadUInt32());
                tMeshObject.JData = new byte[(int)tMeshObject.JValue];
                for (int index2 = 0; (long)index2 < (long)tMeshObject.JValue; ++index2)
                    tMeshObject.JData[index2] = b.ReadByte();
                tMeshObject.ShaderFlag = Decoder.Decode(b.ReadUInt32());
                if (tMeshObject.ShaderFlag > 0U)
                {
                    tMeshObject.ShaderInfo = new tMeshShaderInfo();
                    tMeshObject.ShaderInfo.cParam1 = Decoder.Decode(b.ReadUInt32());
                    tMeshObject.ShaderInfo.cParamFloats = Decoder.Decode(b.ReadUInt32());
                    tMeshObject.ShaderInfo.cTextureUnits = Decoder.Decode(b.ReadUInt32());
                    tMeshObject.ShaderInfo.cParam2 = Decoder.Decode(b.ReadUInt32());
                    tMeshObject.ShaderData = new tMeshShaderData();
                    tMeshObject.ShaderData.ShaderName = b.ReadBytes(b.ReadInt32());
                    tMeshObject.Textures = new tMeshTexture[(int)tMeshObject.ShaderInfo.cTextureUnits];
                    for (int index2 = 0; (long)index2 < (long)tMeshObject.ShaderInfo.cTextureUnits; ++index2)
                    {
                        tMeshObject.Textures[index2] = new tMeshTexture();
                        tMeshObject.Textures[index2].InternalName = b.ReadBytes(b.ReadInt32());
                    }
                    if (tMeshObject.ShaderInfo.cParam2 > 0U)
                        tMeshObject.ShaderData.Param1 = new uint[(int)tMeshObject.ShaderInfo.cParam1];
                    if (tMeshObject.ShaderInfo.cParamFloats > 0U)
                        tMeshObject.ShaderData.ParamFloats = new float[(int)tMeshObject.ShaderInfo.cParamFloats];
                    if (tMeshObject.ShaderInfo.cParam1 > 0U)
                        tMeshObject.ShaderData.Param2 = new uint[(int)tMeshObject.ShaderInfo.cParam2];
                    tMeshObject.ShaderData.cParam0 = Decoder.Decode(b.ReadUInt32());
                    for (int index2 = 0; (long)index2 < (long)tMeshObject.ShaderInfo.cParam2; ++index2)
                        tMeshObject.ShaderData.Param2[index2] = Decoder.Decode(b.ReadUInt32());
                    for (int index2 = 0; (long)index2 < (long)tMeshObject.ShaderInfo.cParamFloats; ++index2)
                        tMeshObject.ShaderData.ParamFloats[index2] = b.ReadSingle();
                    for (int index2 = 0; (long)index2 < (long)tMeshObject.ShaderInfo.cParam1; ++index2)
                        tMeshObject.ShaderData.Param1[index2] = Decoder.Decode(b.ReadUInt32());
                }
                LCMeshReader.pMesh.Objects[index1] = tMeshObject;
            }
            LCMeshReader.pMesh.Weights = new tMeshJointWeights[(int)LCMeshReader.pMesh.HeaderInfo.JointCount];
            for (int index1 = 0; (long)index1 < (long)LCMeshReader.pMesh.HeaderInfo.JointCount; ++index1)
            {
                LCMeshReader.pMesh.Weights[index1] = new tMeshJointWeights();
                LCMeshReader.pMesh.Weights[index1].JointName = b.ReadBytes(b.ReadInt32());
                LCMeshReader.pMesh.Weights[index1].Count = Decoder.Decode(b.ReadUInt32());
                LCMeshReader.pMesh.Weights[index1].WeightsMap = new tMeshWeightsMap[(int)LCMeshReader.pMesh.Weights[index1].Count];
                for (int index2 = 0; (long)index2 < (long)LCMeshReader.pMesh.Weights[index1].Count; ++index2)
                    LCMeshReader.pMesh.Weights[index1].WeightsMap[index2] = new tMeshWeightsMap(b.ReadInt32(), b.ReadSingle());
            }
            LCMeshReader.pMesh.MorphMap = new tMeshMorphMap[(int)LCMeshReader.pMesh.HeaderInfo.VertexCount];
            for (int index = 0; (long)index < (long)LCMeshReader.pMesh.HeaderInfo.VertexCount; ++index)
                LCMeshReader.pMesh.MorphMap[index] = new tMeshMorphMap(b.ReadBytes(4), b.ReadBytes(4));
            Pos = b.BaseStream.Position;
            return Pos == (long)(LCMeshReader.pMesh.HeaderInfo.MeshDataSize + 8);
        }
    }

}
