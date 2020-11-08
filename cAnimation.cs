using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LcDevPack_TeamDamonA
{
    internal class cAnimation
    {
        public string AnimeName { get; set; }

        public cJointAnim[] BoneAnim { get; set; }

        public int EndData { get; set; }

        public int extra_val1 { get; set; }

        public int extra_val2 { get; set; }

        public int extra_val3 { get; set; }

        public float fps { get; set; }

        public int JointCount { get; set; }

        public int last_frame { get; set; }

        public string SkaPath { get; set; }
    }
}
