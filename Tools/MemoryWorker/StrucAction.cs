using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker
{
    internal class StrucAction

    {
      public  int Index, Type, Job, Icon_ID, Icon_Row, Icon_Col;
      public  string Name, Descr;

        public string menu //Nymp code
        {
            get
            {
                return this.Index.ToString() + " - " + Name;
            }
        }
    }
}
