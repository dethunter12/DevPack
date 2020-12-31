using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker
{
    internal class StrucAction

    {
      public  int index, type, job, iconID, iconRow, iconCol;

      public  string name, descr;
         
      

        public string menu //Nymp code
        {
            get
            {
                return this.index.ToString() + " - " + name;
            }
        }
    }
}
