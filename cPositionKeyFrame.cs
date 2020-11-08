using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LcDevPack_TeamDamonA
{
    internal struct cPositionKeyFrame
    {
        public short Frame;
        public short Flags;
        public float x;
        public float y;
        public float z;

        public cPositionKeyFrame(short Frame, short Flags, float x, float y, float z)
        {
            this.Frame = Frame;
            this.Flags = Flags;
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
