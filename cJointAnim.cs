using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LcDevPack_TeamDamonA
{
    internal class cJointAnim
    {
        public string JointName { get; set; }

        public int PositionCount { get; set; }

        public cPositionKeyFrame[] Positions { get; set; }

        public int RotationCount { get; set; }

        public cRotationKeyFrame[] Rotations { get; set; }

        public float Unknown { get; set; }
    }
}
