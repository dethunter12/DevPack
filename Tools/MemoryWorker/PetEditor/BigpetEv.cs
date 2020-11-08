using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LcDevPack_TeamDamonA
{
    public class BigpetEv
    {
        public int APetIdx;//to lod        
        public int Level;//to lod
        public int Stemina;//to lod
        public int Faith;//to lod
        //Only DB
        public int a_stat1;
        public int a_stat2;
        public int a_ev_pet_index;
        public int a_order;
    }

    public class BigpetExp
    {
        public int a_pet_index;//Only DB
        public int a_max_acc_param1;//to lod
        public int a_max_acc_param2;//to lod
        public int a_acc_rate_param1;//to lod        
        public int a_acc_rate_param2;//to lod
        public int a_cooltime;//Only DB
        public int a_cooltime_rate;//Only DB
    }
}
