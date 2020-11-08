// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.MemoryWorker.LoadFromDatabase
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker
{
    public class LoadFromDatabase
    {
        
        public static string LoadFromDatabaseSQL = "";
        public void tPets_Import()
        {
            AllLists.tpet_MenuData.Clear();
            LoadFromDatabase.LoadFromDatabaseSQL = "SELECT * FROM t_attack_pet ORDER BY a_index";
            foreach (DataRow row in (InternalDataCollectionBase)mySQL.GetFromQuery(LoadFromDatabase.LoadFromDatabaseSQL).Rows)
            {
                t_attkpet tAttkpet = new t_attkpet();
                tAttkpet.index = Convert.ToInt32(row["a_index"]);
                tAttkpet.enable = Convert.ToInt32(row["a_enable"]);
                tAttkpet.name = Convert.ToString(row["a_name"]);
                //dethunter12 6/27/2018 pet editor test speed
                tAttkpet.type = Convert.ToInt32(row["a_type"]);
                tAttkpet.str = Convert.ToInt32(row["a_str"]);
                tAttkpet.con = Convert.ToInt32(row["a_con"]);
                tAttkpet.dex = Convert.ToInt32(row["a_dex"]);
                tAttkpet.intel = Convert.ToInt32(row["a_int"]);
                tAttkpet.itemidx = Convert.ToInt32(row["a_item_idx"]);
                tAttkpet.maxFaith = Convert.ToInt32(row["a_maxFaith"]);
                tAttkpet.maxStm = Convert.ToInt32(row["a_maxStm"]);
                tAttkpet.maxHP = Convert.ToInt32(row["a_maxHP"]);
                tAttkpet.maxMP = Convert.ToInt32(row["a_maxMP"]);
                tAttkpet.recoverHP = Convert.ToInt32(row["a_recoverHP"]);
                tAttkpet.recoverMP = Convert.ToInt32(row["a_recoverMP"]);
                tAttkpet.delay = Convert.ToInt32(row["a_delay"]);
                tAttkpet.AISlot = Convert.ToInt32(row["a_AISlot"]);
                tAttkpet.afterDead = Convert.ToInt32(row["a_after_dead"]);
                tAttkpet.attack = Convert.ToInt32(row["a_attack"]);
                tAttkpet.defense = Convert.ToInt32(row["a_defence"]);
                tAttkpet.mAttack = Convert.ToInt32(row["a_Mattack"]);
                tAttkpet.mDefense = Convert.ToInt32(row["a_Mdefence"]);
                tAttkpet.hitPoint = Convert.ToInt32(row["a_hitpoint"]);
                tAttkpet.avoidPoint = Convert.ToInt32(row["a_avoidpoint"]);
                tAttkpet.mavoidPoint = Convert.ToInt32(row["a_Mavoidpoint"]);
                tAttkpet.attackSpeed = Convert.ToInt32(row["a_attackSpeed"]);
                tAttkpet.Deadly = Convert.ToInt32(row["a_deadly"]);
                tAttkpet.Critical = Convert.ToInt32(row["a_critical"]);
                tAttkpet.awful = Convert.ToInt32(row["a_awful"]);
                tAttkpet.strong = Convert.ToInt32(row["a_strong"]);
                tAttkpet.normal = Convert.ToInt32(row["a_normal"]);
                tAttkpet.weak = Convert.ToInt32(row["a_week"]);
                tAttkpet.bagicSkill1 = Convert.ToInt32(row["a_bagic_skill1"]);
                tAttkpet.bagicSkill2 = Convert.ToInt32(row["a_bagic_skill2"]);
                tAttkpet.flag = Convert.ToInt32(row["a_flag"]);
                tAttkpet.transType = Convert.ToInt32(row["a_trans_type"]);
                tAttkpet.transStart = Convert.ToInt32(row["a_trans_start"]);
                tAttkpet.transEnd = Convert.ToInt32(row["a_trans_end"]);
                tAttkpet.smcFileName1 = Convert.ToString(row["a_smcFileName_1"]).Replace('/', '\\'); //dethunter12 7/10/2018
                tAttkpet.aniIdle1 = Convert.ToString(row["a_ani_idle1_1"]);
                tAttkpet.aniIdle1_2 = Convert.ToString(row["a_ani_idle2_1"]);
                tAttkpet.aniAttack1 = Convert.ToString(row["a_ani_attack1_1"]);
                tAttkpet.aniAttack1_2 = Convert.ToString(row["a_ani_attack2_1"]);
                tAttkpet.aniDamage1 = Convert.ToString(row["a_ani_damage_1"]);
                tAttkpet.aniDie1 = Convert.ToString(row["a_ani_die_1"]);
                tAttkpet.aniWalk1 = Convert.ToString(row["a_ani_walk_1"]);
                tAttkpet.aniRun1 = Convert.ToString(row["a_ani_run_1"]);
                tAttkpet.aniLevelup1 = Convert.ToString(row["a_ani_levelup_1"]);
                tAttkpet.mount1 = Convert.ToInt32(row["a_mount_1"]);
                tAttkpet.summonSkill1 = Convert.ToInt32(row["a_summon_skill_1"]);
                tAttkpet.speed1 = Convert.ToInt32(row["a_speed_1"]);
                tAttkpet.smcFileName2 = Convert.ToString(row["a_smcFileName_2"]).Replace('/', '\\'); //dethunter12 7/10/2018
                tAttkpet.aniIdle2 = Convert.ToString(row["a_ani_idle1_2"]);
                tAttkpet.aniIdle2_2 = Convert.ToString(row["a_ani_idle2_2"]);
                tAttkpet.aniAttack2 = Convert.ToString(row["a_ani_attack1_2"]);
                tAttkpet.aniAttack2_2 = Convert.ToString(row["a_ani_attack2_2"]);
                tAttkpet.aniDamage1_2 = Convert.ToString(row["a_ani_damage_2"]);
                tAttkpet.aniDie1_2 = Convert.ToString(row["a_ani_die_2"]);
                tAttkpet.aniWalk1_2 = Convert.ToString(row["a_ani_walk_2"]);
                tAttkpet.aniRun1_2 = Convert.ToString(row["a_ani_run_2"]);
                tAttkpet.aniLevelup1_2 = Convert.ToString(row["a_ani_levelup_2"]);
                tAttkpet.mount1_2 = Convert.ToInt32(row["a_mount_2"]);
                tAttkpet.summonSkill1_2 = Convert.ToInt32(row["a_summon_skill_2"]);
              //  tAttkpet.speed1_2 = Convert.ToInt32(row["a_speed_2"]);
                AllLists.tpet_MenuData.Add(tAttkpet);
                AllLists.tpet_Menu.Add(tAttkpet.index.ToString() + " - " + tAttkpet.name.ToString());
            }
        }

        //PetEvolution
        public void tPets_Evolution_Import()
        {
            AllLists.tpet_ev_MenuData.Clear();
            LoadFromDatabase.LoadFromDatabaseSQL = "SELECT * FROM t_attack_pet_ev ORDER BY a_pet_index";
            foreach (DataRow row in (InternalDataCollectionBase)mySQL.GetFromQuery(LoadFromDatabase.LoadFromDatabaseSQL).Rows)
            {
                BigpetEv tAttkpet_ev = new BigpetEv();
                tAttkpet_ev.APetIdx = Convert.ToInt32(row["a_pet_index"]);
                tAttkpet_ev.Level = Convert.ToInt32(row["a_level"]);
                tAttkpet_ev.Stemina = Convert.ToInt32(row["a_stemina"]);
                tAttkpet_ev.Faith = Convert.ToInt32(row["a_faith"]);
                tAttkpet_ev.a_stat1 = Convert.ToInt32(row["a_stat1"]);
                tAttkpet_ev.a_stat2 = Convert.ToInt32(row["a_stat2"]);
                tAttkpet_ev.a_ev_pet_index = Convert.ToInt32(row["a_ev_pet_index"]);
                tAttkpet_ev.a_order = Convert.ToInt32(row["a_order"]);
                AllLists.tpet_ev_MenuData.Add(tAttkpet_ev);
            }
        }

        //PetEXP
        public void tPets_Exp_Import()
        {
            AllLists.tpet_exp_MenuData.Clear();
            LoadFromDatabase.LoadFromDatabaseSQL = "SELECT * FROM t_attack_pet_exp ORDER BY a_pet_index";
            foreach (DataRow row in (InternalDataCollectionBase)mySQL.GetFromQuery(LoadFromDatabase.LoadFromDatabaseSQL).Rows)
            {
                BigpetExp tAttkpet_exp = new BigpetExp();
                tAttkpet_exp.a_pet_index = Convert.ToInt32(row["a_pet_index"]);
                tAttkpet_exp.a_max_acc_param1 = Convert.ToInt32(row["a_max_acc_param1"]);
                tAttkpet_exp.a_max_acc_param2 = Convert.ToInt32(row["a_max_acc_param2"]);
                tAttkpet_exp.a_acc_rate_param1 = Convert.ToInt32(row["a_acc_rate_param1"]);
                tAttkpet_exp.a_acc_rate_param2 = Convert.ToInt32(row["a_acc_rate_param2"]);
                tAttkpet_exp.a_cooltime = Convert.ToInt32(row["a_cooltime"]);
                tAttkpet_exp.a_cooltime_rate = Convert.ToInt32(row["a_cooltime_rate"]);
                AllLists.tpet_exp_MenuData.Add(tAttkpet_exp);
            }
        }

        //public void tLcBall_Import() //dethunter12 add test lacaball code.
        //{
        //    AllLists.tlcball_MenData.Clear();
        //    LoadFromDatabase.LoadFromDatabaseSQL = "SELECT * FROM t_lcball WHERE a_tocken_index = ";
        //    foreach (DataRow row in (InternalDataCollectionBase)mySQL.GetFromQuery(LoadFromDatabase.LoadFromDatabaseSQL).Rows)
        //    {
        //        t_lcball t_Lcball = new t_lcball();
        //        t_Lcball.a_item_order = Convert.ToInt32(row["a_item_order"]);
        //        t_Lcball.a_tocken_index = Convert.ToInt32(row["a_tocken_index"]);
        //        t_Lcball.a_course_code = Convert.ToInt32(row["a_course_code"]);
        //        t_Lcball.a_order = Convert.ToInt32(row["a_order"]);
        //        t_Lcball.a_item_index = Convert.ToInt32(row["a_item_index"]);
        //        t_Lcball.a_item_count = Convert.ToInt32(row["a_item_count"]);
        //        t_Lcball.a_item_max = Convert.ToInt32(row["a_item_max"]);
        //        t_Lcball.a_item_remain = Convert.ToInt32(row["a_item_remain"]);
        //        AllLists.tlcball_MenData.Add(t_Lcball);
        //    }
        //}

        public void treward_Import()
        {
            LoadFromDatabase.LoadFromDatabaseSQL = "SELECT * FROM t_reward_head";
            LoadFromDatabase.LoadFromDatabaseSQL = "SELECT ";
            LoadFromDatabase.LoadFromDatabaseSQL += "c.a_reward_idx, c.a_desc, c.a_rand_type,";
            LoadFromDatabase.LoadFromDatabaseSQL += "i.a_item_idx, i.a_item_flag, i.a_item_plus, i.a_item_option, i.a_item_num";
            LoadFromDatabase.LoadFromDatabaseSQL += "FROM ";
            LoadFromDatabase.LoadFromDatabaseSQL += "t_catalog c,  t_ct_item i \t";
            LoadFromDatabase.LoadFromDatabaseSQL += " WHERE ";
            LoadFromDatabase.LoadFromDatabaseSQL += "i.a_ctid = c.a_ctid";
            LoadFromDatabase.LoadFromDatabaseSQL += "   \t";
            LoadFromDatabase.LoadFromDatabaseSQL += "     ORDER BY";
            LoadFromDatabase.LoadFromDatabaseSQL += "        c.a_ctid, i.a_ctid";
            LoadFromDatabase.LoadFromDatabaseSQL += ")";
            DataTable fromQuery = mySQL.GetFromQuery(LoadFromDatabase.LoadFromDatabaseSQL);
            AllLists.treward_head_MenuData.Clear();
            AllLists.tnpc_Menu.Clear();
            AllLists.treward_data_MenuData.Clear();
            foreach (DataRow row in (InternalDataCollectionBase)fromQuery.Rows)
            {
                treward_head trewardHead = new treward_head();
                trewardHead.idx = Convert.ToInt32(row["a_reward_idx"]);
                trewardHead.desc = Convert.ToString(row["a_desc"]);
                trewardHead.randtype = Convert.ToInt32(row["a_rand_type"]);
                AllLists.treward_head_MenuData.Add(trewardHead);
                AllLists.tnpc_Menu.Add(trewardHead.idx.ToString() + " - " + trewardHead.desc.ToString());
            }
            LoadFromDatabase.LoadFromDatabaseSQL = "SELECT * FROM t_reward_data";
            foreach (DataRow row in (InternalDataCollectionBase)mySQL.GetFromQuery(LoadFromDatabase.LoadFromDatabaseSQL).Rows)
                AllLists.treward_data_MenuData.Add(new treward_data()
                {
                    PrimaryKey = Convert.ToInt32(row["a_primarykey"]),
                    RewardID = Convert.ToInt32(row["a_reward_idx"]),
                    Type = Convert.ToInt32(row["a_type"]),
                    ItemID = Convert.ToInt32(row["a_idx"]),
                    Value1 = Convert.ToInt32(row["a_value_1"]),
                    Value2 = Convert.ToInt32(row["a_value_2"]),
                    Value3 = Convert.ToInt32(row["a_value_3"]),
                    JobFlag = Convert.ToInt32(row["a_job_flag"]),
                    MinLevel = Convert.ToInt32(row["a_level_mini"]),
                    MaxLevel = Convert.ToInt32(row["a_level_maxi"]),
                    Prob = Convert.ToInt32(row["a_prob"])
                });
        }

        public void tnpc_Import()
        {
            AllLists.tnpc_MenuData.Clear();
            AllLists.tnpc_Menu.Clear();
            LoadFromDatabase.LoadFromDatabaseSQL = "SELECT * FROM t_npc";
            foreach (DataRow row in (InternalDataCollectionBase)mySQL.GetFromQuery(LoadFromDatabase.LoadFromDatabaseSQL).Rows)
            {
                tnpc tnpc = new tnpc();
                tnpc.index = Convert.ToInt32(row["a_index"]);
                tnpc.enable = Convert.ToInt32(row["a_enable"]);
                tnpc.name = Convert.ToString(row["a_name"]);
                tnpc.family = Convert.ToInt32(row["a_family"]);
                tnpc.skillmaster = Convert.ToInt32(row["a_skillmaster"]);
                tnpc.flag = Convert.ToInt32(row["a_flag"]);
                tnpc.flag1 = Convert.ToInt32(row["a_flag1"]);
                tnpc.stateflag = Convert.ToInt32(row["a_state_flag"]);
                tnpc.level = Convert.ToInt32(row["a_level"]);
                tnpc.exp = Convert.ToInt32(row["a_exp"]);
                tnpc.prize = Convert.ToInt32(row["a_prize"]);
                tnpc.sight = Convert.ToInt32(row["a_sight"]);
                tnpc.size = Convert.ToSingle(row["a_size"]);
                tnpc.movearea = Convert.ToInt32(row["a_move_area"]);
                tnpc.attackarea = Convert.ToSingle(row["a_attack_area"]);
                tnpc.skillpoint = Convert.ToInt32(row["a_skill_point"]);
                tnpc.sskillmaster = Convert.ToInt32(row["a_sskill_master"]);
                tnpc.str = Convert.ToInt32(row["a_str"]);
                tnpc.dex = Convert.ToInt32(row["a_dex"]);
                tnpc.INT = Convert.ToInt32(row["a_int"]);
                tnpc.con = Convert.ToInt32(row["a_con"]);
                tnpc.attack = Convert.ToInt32(row["a_attack"]);
                tnpc.magic = Convert.ToInt32(row["a_magic"]);
                tnpc.defense = Convert.ToInt32(row["a_defense"]);
                tnpc.resist = Convert.ToInt32(row["a_resist"]);
                tnpc.attacklevel = Convert.ToInt32(row["a_attacklevel"]);
                tnpc.defenselevel = Convert.ToInt32(row["a_defenselevel"]);
                tnpc.hp = Convert.ToInt32(row["a_hp"]);
                tnpc.mp = Convert.ToInt32(row["a_mp"]);
                tnpc.attacktype = Convert.ToInt32(row["a_attackType"]);
                tnpc.attackspeed = Convert.ToInt32(row["a_attackSpeed"]);
                tnpc.recoverhp = Convert.ToInt32(row["a_recover_hp"]);
                tnpc.recovermp = Convert.ToInt32(row["a_recover_mp"]);
                tnpc.walkspeed = Convert.ToSingle(row["a_walk_speed"]);
                tnpc.runspeed = Convert.ToSingle(row["a_run_speed"]);
                tnpc.skill0 = Convert.ToString(row["a_skill0"]);
                tnpc.skill1 = Convert.ToString(row["a_skill1"]);
                tnpc.skill2 = Convert.ToString(row["a_skill2"]);
                tnpc.skill3 = Convert.ToString(row["a_skill3"]);
                tnpc.drop0 = Convert.ToInt32(row["a_item_0"]);
                tnpc.drop1 = Convert.ToInt32(row["a_item_1"]);
                tnpc.drop2 = Convert.ToInt32(row["a_item_2"]);
                tnpc.drop3 = Convert.ToInt32(row["a_item_3"]);
                tnpc.drop4 = Convert.ToInt32(row["a_item_4"]);
                tnpc.drop5 = Convert.ToInt32(row["a_item_5"]);
                tnpc.drop6 = Convert.ToInt32(row["a_item_6"]);
                tnpc.drop7 = Convert.ToInt32(row["a_item_7"]);
                tnpc.drop8 = Convert.ToInt32(row["a_item_8"]);
                tnpc.drop9 = Convert.ToInt32(row["a_item_9"]);
                tnpc.drop10 = Convert.ToInt32(row["a_item_10"]);
                tnpc.drop11 = Convert.ToInt32(row["a_item_11"]);
                tnpc.drop12 = Convert.ToInt32(row["a_item_12"]);
                tnpc.drop13 = Convert.ToInt32(row["a_item_13"]);
                tnpc.drop14 = Convert.ToInt32(row["a_item_14"]);
                tnpc.drop15 = Convert.ToInt32(row["a_item_15"]);
                tnpc.drop16 = Convert.ToInt32(row["a_item_16"]);
                tnpc.drop17 = Convert.ToInt32(row["a_item_17"]);
                tnpc.drop18 = Convert.ToInt32(row["a_item_18"]);
                tnpc.drop19 = Convert.ToInt32(row["a_item_19"]);
                tnpc.droprate0 = Convert.ToInt32(row["a_item_percent_0"]);
                tnpc.droprate1 = Convert.ToInt32(row["a_item_percent_1"]);
                tnpc.droprate2 = Convert.ToInt32(row["a_item_percent_2"]);
                tnpc.droprate3 = Convert.ToInt32(row["a_item_percent_3"]);
                tnpc.droprate4 = Convert.ToInt32(row["a_item_percent_4"]);
                tnpc.droprate5 = Convert.ToInt32(row["a_item_percent_5"]);
                tnpc.droprate6 = Convert.ToInt32(row["a_item_percent_6"]);
                tnpc.droprate7 = Convert.ToInt32(row["a_item_percent_7"]);
                tnpc.droprate8 = Convert.ToInt32(row["a_item_percent_8"]);
                tnpc.droprate9 = Convert.ToInt32(row["a_item_percent_9"]);
                tnpc.droprate10 = Convert.ToInt32(row["a_item_percent_10"]);
                tnpc.droprate11 = Convert.ToInt32(row["a_item_percent_11"]);
                tnpc.droprate12 = Convert.ToInt32(row["a_item_percent_12"]);
                tnpc.droprate13 = Convert.ToInt32(row["a_item_percent_13"]);
                tnpc.droprate14 = Convert.ToInt32(row["a_item_percent_14"]);
                tnpc.droprate15 = Convert.ToInt32(row["a_item_percent_15"]);
                tnpc.droprate16 = Convert.ToInt32(row["a_item_percent_16"]);
                tnpc.droprate17 = Convert.ToInt32(row["a_item_percent_17"]);
                tnpc.droprate18 = Convert.ToInt32(row["a_item_percent_18"]);
                tnpc.droprate19 = Convert.ToInt32(row["a_item_percent_19"]);
                tnpc.minplus = Convert.ToInt32(row["a_minplus"]);
                tnpc.maxplus = Convert.ToInt32(row["a_maxplus"]);
                tnpc.probplus = Convert.ToInt32(row["a_probplus"]);
                tnpc.product0 = Convert.ToInt32(row["a_product0"]);
                tnpc.product1 = Convert.ToInt32(row["a_product1"]);
                tnpc.product2 = Convert.ToInt32(row["a_product2"]);
                tnpc.product3 = Convert.ToInt32(row["a_product3"]);
                tnpc.product4 = Convert.ToInt32(row["a_product4"]);
                tnpc.filesmc = Convert.ToString(row["a_file_smc"]);
                tnpc.motionwalk = Convert.ToString(row["a_motion_walk"]);
                tnpc.motionidle = Convert.ToString(row["a_motion_idle"]);
                tnpc.motiondam = Convert.ToString(row["a_motion_dam"]);
                tnpc.motionattack = Convert.ToString(row["a_motion_attack"]);
                tnpc.motiondie = Convert.ToString(row["a_motion_die"]);
                tnpc.motionrun = Convert.ToString(row["a_motion_run"]);
                tnpc.motionidle2 = Convert.ToString(row["a_motion_idle2"]);
                tnpc.motionattack2 = Convert.ToString(row["a_motion_attack2"]);
                tnpc.scale = Convert.ToSingle(row["a_scale"]);
                tnpc.attribute = Convert.ToInt32(row["a_attribute"]);
                tnpc.firedelaycount = Convert.ToInt32(row["a_fireDelayCount"]);
                tnpc.firedelay0 = Convert.ToSingle(row["a_fireDelay0"]);
                tnpc.firedelay1 = Convert.ToSingle(row["a_fireDelay1"]);
                tnpc.firedelay2 = Convert.ToSingle(row["a_fireDelay2"]);
                tnpc.firedelay3 = Convert.ToSingle(row["a_fireDelay3"]);
                tnpc.fireeffect0 = Convert.ToString(row["a_fireEffect0"]);
                tnpc.fireeffect1 = Convert.ToString(row["a_fireEffect1"]);
                tnpc.fireeffect2 = Convert.ToString(row["a_fireEffect2"]);
                tnpc.fireobject = Convert.ToInt32(row["a_fireObject"]);
                tnpc.firespeed = Convert.ToSingle(row["a_fireSpeed"]);
                tnpc.aitype = Convert.ToInt32(row["a_aitype"]);
                tnpc.aiflag = Convert.ToInt32(row["a_aiflag"]);
                tnpc.aileaderflag = Convert.ToInt32(row["a_aileader_flag"]);
                tnpc.aisummonhp = Convert.ToInt32(row["a_ai_summonHp"]);
                tnpc.aileaderidx = Convert.ToInt32(row["a_aileader_idx"]);
                tnpc.aileadercount = Convert.ToInt32(row["a_aileader_count"]);
                tnpc.npcchoicetriggercount = Convert.ToInt32(row["a_npc_choice_trigger_count"]);
                tnpc.npcchoicetriggerids = Convert.ToString(row["a_npc_choice_trigger_ids"]);
                tnpc.npcchoicetriggercount = Convert.ToInt32(row["a_npc_kill_trigger_count"]);
                tnpc.npckilltriggerids = Convert.ToString(row["a_npc_kill_trigger_ids"]);
                tnpc.createprob = Convert.ToInt32(row["a_createprob"]);
                tnpc.socketprob0 = Convert.ToInt32(row["a_socketprob_0"]);
                tnpc.socketprob1 = Convert.ToInt32(row["a_socketprob_1"]);
                tnpc.socketprob2 = Convert.ToInt32(row["a_socketprob_2"]);
                tnpc.socketprob3 = Convert.ToInt32(row["a_socketprob_3"]);
                tnpc.jewel0 = Convert.ToInt32(row["a_jewel_0"]);
                tnpc.jewel1 = Convert.ToInt32(row["a_jewel_1"]);
                tnpc.jewel2 = Convert.ToInt32(row["a_jewel_2"]);
                tnpc.jewel3 = Convert.ToInt32(row["a_jewel_3"]);
                tnpc.jewel4 = Convert.ToInt32(row["a_jewel_4"]);
                tnpc.jewel5 = Convert.ToInt32(row["a_jewel_5"]);
                tnpc.jewel6 = Convert.ToInt32(row["a_jewel_6"]);
                tnpc.jewel7 = Convert.ToInt32(row["a_jewel_7"]);
                tnpc.jewel8 = Convert.ToInt32(row["a_jewel_8"]);
                tnpc.jewel9 = Convert.ToInt32(row["a_jewel_9"]);
                tnpc.jewel10 = Convert.ToInt32(row["a_jewel_10"]);
                tnpc.jewel11 = Convert.ToInt32(row["a_jewel_11"]);
                tnpc.jewel12 = Convert.ToInt32(row["a_jewel_12"]);
                tnpc.jewel13 = Convert.ToInt32(row["a_jewel_13"]);
                tnpc.jewel14 = Convert.ToInt32(row["a_jewel_14"]);
                tnpc.jewel15 = Convert.ToInt32(row["a_jewel_15"]);
                tnpc.jewel16 = Convert.ToInt32(row["a_jewel_16"]);
                tnpc.jewel17 = Convert.ToInt32(row["a_jewel_17"]);
                tnpc.jewel18 = Convert.ToInt32(row["a_jewel_18"]);
                tnpc.jewel19 = Convert.ToInt32(row["a_jewel_19"]);
                tnpc.jeweldrop0 = Convert.ToInt32(row["a_jewel_percent_0"]);
                tnpc.jeweldrop1 = Convert.ToInt32(row["a_jewel_percent_1"]);
                tnpc.jeweldrop2 = Convert.ToInt32(row["a_jewel_percent_2"]);
                tnpc.jeweldrop3 = Convert.ToInt32(row["a_jewel_percent_3"]);
                tnpc.jeweldrop4 = Convert.ToInt32(row["a_jewel_percent_4"]);
                tnpc.jeweldrop5 = Convert.ToInt32(row["a_jewel_percent_5"]);
                tnpc.jeweldrop6 = Convert.ToInt32(row["a_jewel_percent_6"]);
                tnpc.jeweldrop7 = Convert.ToInt32(row["a_jewel_percent_7"]);
                tnpc.jeweldrop8 = Convert.ToInt32(row["a_jewel_percent_8"]);
                tnpc.jeweldrop9 = Convert.ToInt32(row["a_jewel_percent_9"]);
                tnpc.jeweldrop10 = Convert.ToInt32(row["a_jewel_percent_10"]);
                tnpc.jeweldrop11 = Convert.ToInt32(row["a_jewel_percent_11"]);
                tnpc.jeweldrop12 = Convert.ToInt32(row["a_jewel_percent_12"]);
                tnpc.jeweldrop13 = Convert.ToInt32(row["a_jewel_percent_13"]);
                tnpc.jeweldrop14 = Convert.ToInt32(row["a_jewel_percent_14"]);
                tnpc.jeweldrop15 = Convert.ToInt32(row["a_jewel_percent_15"]);
                tnpc.jeweldrop16 = Convert.ToInt32(row["a_jewel_percent_16"]);
                tnpc.jeweldrop17 = Convert.ToInt32(row["a_jewel_percent_17"]);
                tnpc.jeweldrop18 = Convert.ToInt32(row["a_jewel_percent_18"]);
                tnpc.jeweldrop19 = Convert.ToInt32(row["a_jewel_percent_19"]);
                tnpc.zoneflag = Convert.ToInt64(row["a_zone_flag"]);
                tnpc.extraflag = Convert.ToInt64(row["a_extra_flag"]);
                tnpc.rvrvalue = Convert.ToInt32(row["a_rvr_value"]);
                tnpc.rvrgrade = Convert.ToInt32(row["a_rvr_grade"]);
                tnpc.bound = Convert.ToInt32(row["a_bound"]);
                tnpc.lifetime = Convert.ToInt32(row["a_lifetime"]);
                AllLists.tnpc_MenuData.Add(tnpc);
                AllLists.tnpc_Menu.Add(tnpc.index.ToString() + " - " + tnpc.name.ToString());
            }
        }
        public void tItemCollection_Import() //dethunter12 add 7/26/2020
        {
            AllLists.tItemCollect_MenuData.Clear();
            LoadFromDatabase.LoadFromDatabaseSQL = "SELECT * FROM t_item_collection ORDER BY a_theme";
            foreach (DataRow row in (InternalDataCollectionBase)mySQL.GetFromQuery(LoadFromDatabase.LoadFromDatabaseSQL).Rows)
            {
                var itemCollection = new tItemCollection();
                itemCollection.a_theme = Convert.ToInt32(row["a_theme"]);
                itemCollection.a_category = Convert.ToInt32(row["a_category"]);
                itemCollection.a_theme_string = Convert.ToString(row["a_theme_string"]);
                itemCollection.a_descr_string = Convert.ToString(row["a_desc_string"]);
                itemCollection.a_enable = Convert.ToBoolean(row["a_enable"]);
                itemCollection.a_id = Convert.ToInt32(row["a_id"]);
                itemCollection.a_row = Convert.ToInt32(row["a_row"]);
                itemCollection.a_col = Convert.ToInt32(row["a_col"]);
                itemCollection.a_need1_type = Convert.ToInt32(row["a_need1_type"]);
                itemCollection.a_need1_index = Convert.ToInt32(row["a_need1_index"]);
                itemCollection.a_need1_num = Convert.ToInt32(row["a_need1_num"]);
                itemCollection.a_need2_type = Convert.ToInt32(row["a_need2_type"]);
                itemCollection.a_need2_index = Convert.ToInt32(row["a_need2_index"]);
                itemCollection.a_need2_num = Convert.ToInt32(row["a_need2_num"]);
                itemCollection.a_need3_type = Convert.ToInt32(row["a_need3_type"]);
                itemCollection.a_need3_index = Convert.ToInt32(row["a_need3_index"]);
                itemCollection.a_need3_num = Convert.ToInt32(row["a_need3_num"]);
                itemCollection.a_need4_type = Convert.ToInt32(row["a_need4_type"]);
                itemCollection.a_need4_index = Convert.ToInt32(row["a_need4_index"]);
                itemCollection.a_need4_num = Convert.ToInt32(row["a_need4_num"]);
                itemCollection.a_need5_type = Convert.ToInt32(row["a_need5_type"]);
                itemCollection.a_need5_index = Convert.ToInt32(row["a_need5_index"]);
                itemCollection.a_need5_num = Convert.ToInt32(row["a_need5_num"]);
                itemCollection.a_need6_type = Convert.ToInt32(row["a_need6_type"]);
                itemCollection.a_need6_index = Convert.ToInt32(row["a_need6_index"]);
                itemCollection.a_need6_num = Convert.ToInt32(row["a_need6_num"]);
                itemCollection.a_result_type = Convert.ToInt32(row["a_result_type"]);
                itemCollection.a_result_index = Convert.ToInt32(row["a_result_index"]);
                itemCollection.a_result_num = Convert.ToInt32(row["a_result_num"]);

                AllLists.tItemCollect_MenuData.Add(itemCollection);
                AllLists.tItemCollect_Menu.Add(itemCollection.a_theme.ToString() + " - " + itemCollection.a_theme_string.ToString());
            }
        }
    }
}
