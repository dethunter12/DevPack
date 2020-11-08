using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LcDevPack_TeamDamonA
{
    internal struct cRotationKeyFrame
    {
        public short Frame;
        public short Flags;
        public float w;
        public float x;
        public float y;
        public float z;

        public cRotationKeyFrame(short Frame, short Flags, float w, float x, float y, float z)
        {
            this.Frame = Frame;
            this.Flags = Flags;
            this.w = w;
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
