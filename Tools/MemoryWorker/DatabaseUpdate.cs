// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.MemoryWorker.DatabaseUpdate
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker
{
  public class DatabaseUpdate
  {
    public static void tnpc_Update(tnpc npc)
    {
      try
      {
        using (MySqlConnection mySqlConnection = new MySqlConnection(mySQL.ConnectionString))
        {
          MySqlCommand mySqlCommand = new MySqlCommand();
          mySqlConnection.Open();
          mySqlCommand.Connection = mySqlConnection;
          string str = "INSERT INTO t_npc (" + "a_index, " + "a_enable ," + "a_name ," + "a_family ," + "a_skillmaster ," + "a_flag ," + "a_flag1 ," + "a_state_flag ," + "a_level ," + "a_exp ," + "a_prize ," + "a_sight ," + "a_size ," + "a_move_area ," + "a_attack_area ," + "a_skill_point ," + "a_sskill_master ," + "a_str ," + "a_dex ," + "a_int ," + "a_con ," + "a_attack ," + "a_magic ," + "a_defense ," + "a_resist ," + "a_attacklevel ," + "a_defenselevel ," + "a_hp ," + "a_mp ," + "a_attackType ," + "a_attackSpeed ," + "a_recover_hp ," + "a_recover_mp ," + "a_walk_speed ," + "a_run_speed ," + "a_skill0 ," + "a_skill1 ," + "a_skill2 ," + "a_skill3 ," + "a_item_0 ," + "a_item_1 ," + "a_item_2 ," + "a_item_3 ," + "a_item_4 ," + "a_item_5 ," + "a_item_6 ," + "a_item_7 ," + "a_item_8 ," + "a_item_9 ," + "a_item_10 ," + "a_item_11 ," + "a_item_12 ," + "a_item_13 ," + "a_item_14 ," + "a_item_15 ," + "a_item_16 ," + "a_item_17 ," + "a_item_18 ," + "a_item_19 ," + "a_item_percent_0 ," + "a_item_percent_1 ," + "a_item_percent_2 ," + "a_item_percent_3 ," + "a_item_percent_4 ," + "a_item_percent_5 ," + "a_item_percent_6 ," + "a_item_percent_7 ," + "a_item_percent_8 ," + "a_item_percent_9 ," + "a_item_percent_10 ," + "a_item_percent_11 ," + "a_item_percent_12 ," + "a_item_percent_13 ," + "a_item_percent_14 ," + "a_item_percent_15 ," + "a_item_percent_16 ," + "a_item_percent_17 ," + "a_item_percent_18 ," + "a_item_percent_19 ," + "a_minplus ," + "a_maxplus ," + "a_probplus ," + "a_product0 ," + "a_product1 ," + "a_product2 ," + "a_product3 ," + "a_product4 ," + "a_file_smc ," + "a_motion_walk ," + "a_motion_idle ," + "a_motion_dam ," + "a_motion_attack ," + "a_motion_die ," + "a_motion_run ," + "a_motion_idle2 ," + "a_motion_attack2 ," + "a_scale ," + "a_attribute ," + "a_fireDelayCount ," + "a_fireDelay0 ," + "a_fireDelay1 ," + "a_fireDelay2 ," + "a_fireDelay3 ," + "a_fireEffect0 ," + "a_fireEffect1 ," + "a_fireEffect2 ," + "a_fireObject ," + "a_fireSpeed ," + "a_aitype ," + "a_aiflag ," + "a_aileader_flag ," + "a_ai_summonHp ," + "a_aileader_idx ," + "a_aileader_count ," + "a_crafting_category ," + "a_productIndex ," + "a_hit ," + "a_dodge ," + "a_magicavoid ," + "a_job_attribute ," + "a_npc_choice_trigger_count ," + "a_npc_choice_trigger_ids ," + "a_npc_kill_trigger_count ," + "a_npc_kill_trigger_ids ," + "a_createprob ," + "a_socketprob_0 ," + "a_socketprob_1 ," + "a_socketprob_2 ," + "a_socketprob_3 ," + "a_jewel_0 ," + "a_jewel_1 ," + "a_jewel_2 ," + "a_jewel_3 ," + "a_jewel_4 ," + "a_jewel_5 ," + "a_jewel_6 ," + "a_jewel_7 ," + "a_jewel_8 ," + "a_jewel_9 ," + "a_jewel_10 ," + "a_jewel_11 ," + "a_jewel_12 ," + "a_jewel_13 ," + "a_jewel_14 ," + "a_jewel_15 ," + "a_jewel_16 ," + "a_jewel_17 ," + "a_jewel_18 ," + "a_jewel_19 ," + "a_jewel_percent_0 ," + "a_jewel_percent_1 ," + "a_jewel_percent_2 ," + "a_jewel_percent_3 ," + "a_jewel_percent_4 ," + "a_jewel_percent_5 ," + "a_jewel_percent_6 ," + "a_jewel_percent_7 ," + "a_jewel_percent_8 ," + "a_jewel_percent_9 ," + "a_jewel_percent_10 ," + "a_jewel_percent_11 ," + "a_jewel_percent_12 ," + "a_jewel_percent_13 ," + "a_jewel_percent_14 ," + "a_jewel_percent_15 ," + "a_jewel_percent_16 ," + "a_jewel_percent_17 ," + "a_jewel_percent_18 ," + "a_jewel_percent_19 ," + "a_zone_flag ," + "a_extra_flag ," + "a_rvr_value ," + "a_rvr_grade ," + "a_bound ," + "a_lifetime" + ")" + "VALUES (" + "@index, " + "@enable ," + "@name ," + "@family ," + "@skillmaster ," + "@flag ," + "@flag1 ," + "@state_flag ," + "@level ," + "@exp ," + "@prize ," + "@sight ," + "@size ," + "@move_area ," + "@attack_area ," + "@skill_point ," + "@sskill_master ," + "@str ," + "@dex ," + "@int ," + "@con ," + "@attack ," + "@magic ," + "@defense ," + "@resist ," + "@attacklevel ," + "@defenselevel ," + "@hp ," + "@mp ," + "@attackType ," + "@attackSpeed ," + "@recover_hp ," + "@recover_mp ," + "@walk_speed ," + "@run_speed ," + "@skill0 ," + "@skill1 ," + "@skill2 ," + "@skill3 ," + "@item_0 ," + "@item_1 ," + "@item_2 ," + "@item_3 ," + "@item_4 ," + "@item_5 ," + "@item_6 ," + "@item_7 ," + "@item_8 ," + "@item_9 ," + "@item_10 ," + "@item_11 ," + "@item_12 ," + "@item_13 ," + "@item_14 ," + "@item_15 ," + "@item_16 ," + "@item_17 ," + "@item_18 ," + "@item_19 ," + "@item_percent_0 ," + "@item_percent_1 ," + "@item_percent_2 ," + "@item_percent_3 ," + "@item_percent_4 ," + "@item_percent_5 ," + "@item_percent_6 ," + "@item_percent_7 ," + "@item_percent_8 ," + "@item_percent_9 ," + "@item_percent_10 ," + "@item_percent_11 ," + "@item_percent_12 ," + "@item_percent_13 ," + "@item_percent_14 ," + "@item_percent_15 ," + "@item_percent_16 ," + "@item_percent_17 ," + "@item_percent_18 ," + "@item_percent_19 ," + "@minplus ," + "@maxplus ," + "@probplus ," + "@product0 ," + "@product1 ," + "@product2 ," + "@product3 ," + "@product4 ," + "@file_smc ," + "@motion_walk ," + "@motion_idle ," + "@motion_dam ," + "@motion_attack ," + "@motion_die ," + "@motion_run ," + "@motion_idle2 ," + "@motion_attack2 ," + "@scale ," + "@attribute ," + "@fireDelayCount ," + "@fireDelay0 ," + "@fireDelay1 ," + "@fireDelay2 ," + "@fireDelay3 ," + "@fireEffect0 ," + "@fireEffect1 ," + "@fireEffect2 ," + "@fireObject ," + "@fireSpeed ," + "@aitype ," + "@aiflag ," + "@aileader_flag ," + "@ai_summonHp ," + "@aileader_idx ," + "@aileader_count ," + "@crafting_category ," + "@productIndex ," + "@hit ," + "@dodge ," + "@magicavoid ," + "@job_attribute ," + "@npc_choice_trigger_count ," + "@npc_choice_trigger_ids ," + "@npc_kill_trigger_count ," + "@npc_kill_trigger_ids ," + "@createprob ," + "@socketprob_0 ," + "@socketprob_1 ," + "@socketprob_2 ," + "@socketprob_3 ," + "@jewel_0 ," + "@jewel_1 ," + "@jewel_2 ," + "@jewel_3 ," + "@jewel_4 ," + "@jewel_5 ," + "@jewel_6 ," + "@jewel_7 ," + "@jewel_8 ," + "@jewel_9 ," + "@jewel_10 ," + "@jewel_11 ," + "@jewel_12 ," + "@jewel_13 ," + "@jewel_14 ," + "@jewel_15 ," + "@jewel_16 ," + "@jewel_17 ," + "@jewel_18 ," + "@jewel_19 ," + "@jewel_percent_0 ," + "@jewel_percent_1 ," + "@jewel_percent_2 ," + "@jewel_percent_3 ," + "@jewel_percent_4 ," + "@jewel_percent_5 ," + "@jewel_percent_6 ," + "@jewel_percent_7 ," + "@jewel_percent_8 ," + "@jewel_percent_9 ," + "@jewel_percent_10 ," + "@jewel_percent_11 ," + "@jewel_percent_12 ," + "@jewel_percent_13 ," + "@jewel_percent_14 ," + "@jewel_percent_15 ," + "@jewel_percent_16 ," + "@jewel_percent_17 ," + "@jewel_percent_18 ," + "@jewel_percent_19 ," + "@zone_flag ," + "@extraflag ," + "@rvr_value ," + "@rvr_grade ," + "@bound ," + "@lifetime " + ")";
          mySqlCommand.CommandText = str;
          mySqlCommand.Prepare();
          mySqlCommand.Parameters.AddWithValue("@index",  npc.index);
          mySqlCommand.Parameters.AddWithValue("@enable",  npc.enable);
          mySqlCommand.Parameters.AddWithValue("@name",  npc.name);
          mySqlCommand.Parameters.AddWithValue("@family",  npc.family);
          mySqlCommand.Parameters.AddWithValue("@skillmaster",  npc.skillmaster);
          mySqlCommand.Parameters.AddWithValue("@flag",  npc.flag);
          mySqlCommand.Parameters.AddWithValue("@flag1",  npc.flag1);
          mySqlCommand.Parameters.AddWithValue("@state_flag",  npc.stateflag);
          mySqlCommand.Parameters.AddWithValue("@level",  npc.level);
          mySqlCommand.Parameters.AddWithValue("@exp",  npc.exp);
          mySqlCommand.Parameters.AddWithValue("@prize",  npc.prize);
          mySqlCommand.Parameters.AddWithValue("@sight",  npc.sight);
          mySqlCommand.Parameters.AddWithValue("@size",  npc.size);
          mySqlCommand.Parameters.AddWithValue("@move_area",  npc.movearea);
          mySqlCommand.Parameters.AddWithValue("@attack_area",  npc.attackarea);
          mySqlCommand.Parameters.AddWithValue("@skill_point",  npc.skillpoint);
          mySqlCommand.Parameters.AddWithValue("@sskill_master",  npc.sskillmaster);
          mySqlCommand.Parameters.AddWithValue("@str",  npc.str);
          mySqlCommand.Parameters.AddWithValue("@dex",  npc.dex);
          mySqlCommand.Parameters.AddWithValue("@int",  npc.INT);
          mySqlCommand.Parameters.AddWithValue("@con",  npc.con);
          mySqlCommand.Parameters.AddWithValue("@attack",  npc.attack);
          mySqlCommand.Parameters.AddWithValue("@magic",  npc.magic);
          mySqlCommand.Parameters.AddWithValue("@defense",  npc.defense);
          mySqlCommand.Parameters.AddWithValue("@resist",  npc.resist);
          mySqlCommand.Parameters.AddWithValue("@attacklevel",  npc.attacklevel);
          mySqlCommand.Parameters.AddWithValue("@defenselevel",  npc.defenselevel);
          mySqlCommand.Parameters.AddWithValue("@hp",  npc.hp);
          mySqlCommand.Parameters.AddWithValue("@mp",  npc.mp);
          mySqlCommand.Parameters.AddWithValue("@attackType",  npc.attacktype);
          mySqlCommand.Parameters.AddWithValue("@attackSpeed",  npc.attackspeed);
          mySqlCommand.Parameters.AddWithValue("@recover_hp",  npc.recoverhp);
          mySqlCommand.Parameters.AddWithValue("@recover_mp",  npc.recovermp);
          mySqlCommand.Parameters.AddWithValue("@walk_speed",  npc.walkspeed);
          mySqlCommand.Parameters.AddWithValue("@run_speed",  npc.runspeed);
          mySqlCommand.Parameters.AddWithValue("@skill0",  npc.skill0);
          mySqlCommand.Parameters.AddWithValue("@skill1",  npc.skill1);
          mySqlCommand.Parameters.AddWithValue("@skill2",  npc.skill2);
          mySqlCommand.Parameters.AddWithValue("@skill3",  npc.skill3);
          mySqlCommand.Parameters.AddWithValue("@item_0",  npc.drop0);
          mySqlCommand.Parameters.AddWithValue("@item_1",  npc.drop1);
          mySqlCommand.Parameters.AddWithValue("@item_2",  npc.drop2);
          mySqlCommand.Parameters.AddWithValue("@item_3",  npc.drop3);
          mySqlCommand.Parameters.AddWithValue("@item_4",  npc.drop4);
          mySqlCommand.Parameters.AddWithValue("@item_5",  npc.drop5);
          mySqlCommand.Parameters.AddWithValue("@item_6",  npc.drop6);
          mySqlCommand.Parameters.AddWithValue("@item_7",  npc.drop7);
          mySqlCommand.Parameters.AddWithValue("@item_8",  npc.drop8);
          mySqlCommand.Parameters.AddWithValue("@item_9",  npc.drop9);
          mySqlCommand.Parameters.AddWithValue("@item_10",  npc.drop10);
          mySqlCommand.Parameters.AddWithValue("@item_11",  npc.drop11);
          mySqlCommand.Parameters.AddWithValue("@item_12",  npc.drop12);
          mySqlCommand.Parameters.AddWithValue("@item_13",  npc.drop13);
          mySqlCommand.Parameters.AddWithValue("@item_14",  npc.drop14);
          mySqlCommand.Parameters.AddWithValue("@item_15",  npc.drop15);
          mySqlCommand.Parameters.AddWithValue("@item_16",  npc.drop16);
          mySqlCommand.Parameters.AddWithValue("@item_17",  npc.drop17);
          mySqlCommand.Parameters.AddWithValue("@item_18",  npc.drop18);
          mySqlCommand.Parameters.AddWithValue("@item_19",  npc.drop19);
          mySqlCommand.Parameters.AddWithValue("@item_percent_0",  npc.droprate0);
          mySqlCommand.Parameters.AddWithValue("@item_percent_1",  npc.droprate1);
          mySqlCommand.Parameters.AddWithValue("@item_percent_2",  npc.droprate2);
          mySqlCommand.Parameters.AddWithValue("@item_percent_3",  npc.droprate3);
          mySqlCommand.Parameters.AddWithValue("@item_percent_4",  npc.droprate4);
          mySqlCommand.Parameters.AddWithValue("@item_percent_5",  npc.droprate5);
          mySqlCommand.Parameters.AddWithValue("@item_percent_6",  npc.droprate6);
          mySqlCommand.Parameters.AddWithValue("@item_percent_7",  npc.droprate7);
          mySqlCommand.Parameters.AddWithValue("@item_percent_8",  npc.droprate8);
          mySqlCommand.Parameters.AddWithValue("@item_percent_9",  npc.droprate9);
          mySqlCommand.Parameters.AddWithValue("@item_percent_10",  npc.droprate10);
          mySqlCommand.Parameters.AddWithValue("@item_percent_11",  npc.droprate11);
          mySqlCommand.Parameters.AddWithValue("@item_percent_12",  npc.droprate12);
          mySqlCommand.Parameters.AddWithValue("@item_percent_13",  npc.droprate13);
          mySqlCommand.Parameters.AddWithValue("@item_percent_14",  npc.droprate14);
          mySqlCommand.Parameters.AddWithValue("@item_percent_15",  npc.droprate15);
          mySqlCommand.Parameters.AddWithValue("@item_percent_16",  npc.droprate16);
          mySqlCommand.Parameters.AddWithValue("@item_percent_17",  npc.droprate17);
          mySqlCommand.Parameters.AddWithValue("@item_percent_18",  npc.droprate18);
          mySqlCommand.Parameters.AddWithValue("@item_percent_19",  npc.droprate19);
          mySqlCommand.Parameters.AddWithValue("@minplus",  npc.minplus);
          mySqlCommand.Parameters.AddWithValue("@maxplus",  npc.maxplus);
          mySqlCommand.Parameters.AddWithValue("@probplus",  npc.probplus);
          mySqlCommand.Parameters.AddWithValue("@product0",  npc.product0);
          mySqlCommand.Parameters.AddWithValue("@product1",  npc.product1);
          mySqlCommand.Parameters.AddWithValue("@product2",  npc.product2);
          mySqlCommand.Parameters.AddWithValue("@product3",  npc.product3);
          mySqlCommand.Parameters.AddWithValue("@product4",  npc.product4);
          mySqlCommand.Parameters.AddWithValue("@file_smc",  npc.filesmc);
          mySqlCommand.Parameters.AddWithValue("@motion_walk",  npc.motionwalk);
          mySqlCommand.Parameters.AddWithValue("@motion_idle",  npc.motionidle);
          mySqlCommand.Parameters.AddWithValue("@motion_dam",  npc.motiondam);
          mySqlCommand.Parameters.AddWithValue("@motion_attack",  npc.motionattack);
          mySqlCommand.Parameters.AddWithValue("@motion_die",  npc.motiondie);
          mySqlCommand.Parameters.AddWithValue("@motion_run",  npc.motionrun);
          mySqlCommand.Parameters.AddWithValue("@motion_idle2",  npc.motionidle2);
          mySqlCommand.Parameters.AddWithValue("@motion_attack2",  npc.motionattack2);
          mySqlCommand.Parameters.AddWithValue("@scale",  npc.scale);
          mySqlCommand.Parameters.AddWithValue("@attribute",  npc.attribute);
          mySqlCommand.Parameters.AddWithValue("@fireDelayCount",  npc.firedelaycount);
          mySqlCommand.Parameters.AddWithValue("@fireDelay0",  npc.firedelay0);
          mySqlCommand.Parameters.AddWithValue("@fireDelay1",  npc.firedelay1);
          mySqlCommand.Parameters.AddWithValue("@fireDelay2",  npc.firedelay2);
          mySqlCommand.Parameters.AddWithValue("@fireDelay3",  npc.firedelay3);
          mySqlCommand.Parameters.AddWithValue("@fireEffect0",  npc.fireeffect0);
          mySqlCommand.Parameters.AddWithValue("@fireEffect1",  npc.fireeffect1);
          mySqlCommand.Parameters.AddWithValue("@fireEffect2",  npc.fireeffect2);
          mySqlCommand.Parameters.AddWithValue("@fireObject",  npc.fireobject);
          mySqlCommand.Parameters.AddWithValue("@fireSpeed",  npc.firespeed);
          mySqlCommand.Parameters.AddWithValue("@aitype",  npc.aitype);
          mySqlCommand.Parameters.AddWithValue("@aiflag",  npc.aiflag);
          mySqlCommand.Parameters.AddWithValue("@aileader_flag",  npc.aileaderflag);
          mySqlCommand.Parameters.AddWithValue("@ai_summonHp",  npc.aisummonhp);
          mySqlCommand.Parameters.AddWithValue("@aileader_idx",  npc.aileaderidx);
          mySqlCommand.Parameters.AddWithValue("@aileader_count",  npc.aileadercount);
          mySqlCommand.Parameters.AddWithValue("@crafting_category",  npc.craftingcategory);
          mySqlCommand.Parameters.AddWithValue("@productIndex",  npc.productindex);
          mySqlCommand.Parameters.AddWithValue("@hit",  npc.hit);
          mySqlCommand.Parameters.AddWithValue("@dodge",  npc.dodge);
          mySqlCommand.Parameters.AddWithValue("@magicavoid",  npc.magicavoid);
          mySqlCommand.Parameters.AddWithValue("@job_attribute",  npc.jobattribute);
          mySqlCommand.Parameters.AddWithValue("@npc_choice_trigger_count",  npc.npcchoicetriggercount);
          mySqlCommand.Parameters.AddWithValue("@npc_choice_trigger_ids",  npc.npcchoicetriggerids);
          mySqlCommand.Parameters.AddWithValue("@npc_kill_trigger_count",  npc.npckilltriggercount);
          mySqlCommand.Parameters.AddWithValue("@npc_kill_trigger_ids",  npc.npckilltriggerids);
          mySqlCommand.Parameters.AddWithValue("@createprob",  npc.createprob);
          mySqlCommand.Parameters.AddWithValue("@socketprob_0",  npc.socketprob0);
          mySqlCommand.Parameters.AddWithValue("@socketprob_1",  npc.socketprob1);
          mySqlCommand.Parameters.AddWithValue("@socketprob_2",  npc.socketprob2);
          mySqlCommand.Parameters.AddWithValue("@socketprob_3",  npc.socketprob3);
          mySqlCommand.Parameters.AddWithValue("@jewel_0",  npc.jewel0);
          mySqlCommand.Parameters.AddWithValue("@jewel_1",  npc.jewel1);
          mySqlCommand.Parameters.AddWithValue("@jewel_2",  npc.jewel2);
          mySqlCommand.Parameters.AddWithValue("@jewel_3",  npc.jewel3);
          mySqlCommand.Parameters.AddWithValue("@jewel_4",  npc.jewel4);
          mySqlCommand.Parameters.AddWithValue("@jewel_5",  npc.jewel5);
          mySqlCommand.Parameters.AddWithValue("@jewel_6",  npc.jewel6);
          mySqlCommand.Parameters.AddWithValue("@jewel_7",  npc.jewel7);
          mySqlCommand.Parameters.AddWithValue("@jewel_8",  npc.jewel8);
          mySqlCommand.Parameters.AddWithValue("@jewel_9",  npc.jewel9);
          mySqlCommand.Parameters.AddWithValue("@jewel_10",  npc.jewel0);
          mySqlCommand.Parameters.AddWithValue("@jewel_11",  npc.jewel1);
          mySqlCommand.Parameters.AddWithValue("@jewel_12",  npc.jewel2);
          mySqlCommand.Parameters.AddWithValue("@jewel_13",  npc.jewel3);
          mySqlCommand.Parameters.AddWithValue("@jewel_14",  npc.jewel4);
          mySqlCommand.Parameters.AddWithValue("@jewel_15",  npc.jewel5);
          mySqlCommand.Parameters.AddWithValue("@jewel_16",  npc.jewel6);
          mySqlCommand.Parameters.AddWithValue("@jewel_17",  npc.jewel7);
          mySqlCommand.Parameters.AddWithValue("@jewel_18",  npc.jewel8);
          mySqlCommand.Parameters.AddWithValue("@jewel_19",  npc.jewel9);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_0",  npc.jeweldrop0);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_1",  npc.jeweldrop1);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_2",  npc.jeweldrop2);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_3",  npc.jeweldrop3);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_4",  npc.jeweldrop4);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_5",  npc.jeweldrop5);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_6",  npc.jeweldrop6);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_7",  npc.jeweldrop7);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_8",  npc.jeweldrop8);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_9",  npc.jeweldrop9);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_10",  npc.jeweldrop10);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_11",  npc.jeweldrop11);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_12",  npc.jeweldrop12);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_13",  npc.jeweldrop13);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_14",  npc.jeweldrop14);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_15",  npc.jeweldrop15);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_16",  npc.jeweldrop16);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_17",  npc.jeweldrop17);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_18",  npc.jeweldrop18);
          mySqlCommand.Parameters.AddWithValue("@jewel_percent_19",  npc.jeweldrop19);
          mySqlCommand.Parameters.AddWithValue("@zone_flag",  npc.zoneflag);
          mySqlCommand.Parameters.AddWithValue("@extraflag",  npc.extraflag);
          mySqlCommand.Parameters.AddWithValue("@rvr_value",  npc.rvrvalue);
          mySqlCommand.Parameters.AddWithValue("@rvr_grade",  npc.rvrgrade);
          mySqlCommand.Parameters.AddWithValue("@bound",  npc.bound);
          mySqlCommand.Parameters.AddWithValue("@lifetime",  npc.lifetime);
          mySqlCommand.ExecuteNonQuery();
          mySqlConnection.Close();
        }
      }
      catch (MySqlException ex)
      {
        int num = (int) MessageBox.Show(ex.Message.ToString());
      }
    }

        public static void tattkpet_Update(t_attkpet attkpet)
        {
            try
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection(mySQL.ConnectionString)) //dethunter12 7/9/2018 update pet insert query
                {
                    MySqlCommand mySqlCommand = new MySqlCommand();
                    mySqlConnection.Open();
                    mySqlCommand.Connection = mySqlConnection;
                    string str = "INSERT INTO t_attack_pet (" + "a_index, " + "a_enable ," + "a_type ," + "a_name ," + "a_str ," + "a_con ," + "a_dex ," + "a_int ," + "a_item_idx ," + "a_maxFaith ," + "a_maxStm ," + "a_maxHP ," + "a_maxMP ," + "a_recoverHP ," + "a_recoverMP ," + "a_delay ," + "a_AISlot ," + "a_after_dead ," + "a_attack ," + "a_defence ," + "a_Mattack ," + "a_Mdefence ," + "a_hitpoint ," + "a_avoidpoint ," + "a_Mavoidpoint ," + "a_attackSpeed ," + "a_deadly ," + "a_critical ," + "a_awful ," + "a_normal ," + "a_week ," + "a_bagic_skill1 ," + "a_bagic_skill2 ," + "a_flag ," + "a_trans_type ," + "a_trans_start ," + "a_trans_end ," + "a_smcFileName_1 ," + "a_ani_idle1_1 ," + "a_ani_idle2_1 ," + "a_ani_attack1_1 ," + "a_ani_attack2_1 ," + "a_ani_damage_1 ," + "a_ani_die_1 ," + "a_ani_walk_1 ," + "a_ani_run_1 ," + "a_ani_levelup_1 ," + "a_mount_1 ," + "a_summon_skill_1 ," + "a_speed_1 ," + "a_smcFileName_2 ," + "a_ani_idle1_2 ," + "a_ani_idle2_2 ," + "a_ani_attack1_2 ," + "a_ani_attack2_2 ," + "a_ani_damage_2 ," + "a_ani_die_2 ," + "a_ani_walk_2 ," + "a_ani_run_2 ," + "a_ani_levelup_2 ," + "a_summon_skill_2 ," + "a_speed_2 ," + ")" + "VALUES ("  + "@index, " + "@enable ," + "@type ," + "@name ," + "@str ," + "@con ," + "@dex ," + "@intel ," + "@itemidx ," + "@maxFaith ," + "@maxStm ," + "@maxHP ," + "@maxMP ," + "@recoverHP ," + "@recoverMP ," + "@delay ," + "@AISlot ," + "@afterDead ," + "@attack ," + "@defense ," + "@mAttack ," + "@mDefense ," + "@hitPoint ," + "@avoidPoint ," + "@mavoidPoint ," + "@attackSpeed ," + "@Deadly ," + "@Critical ," + "@awful ," + "@strong ," + "@normal ," + "@weak ," + "@bagicSkill1 ," + "@bagicSkill2 ," + "@flag ," + "@transType ," + "@transStart ," + "@transEnd ," + "@smcFileName1 ," + "@aniIdle1 ," + "@aniIdle2 ," + "@aniAttack1 ," + "@aniAttack2 ," + "@aniDamage1 ," + "@aniDie1 ," + "@aniWalk1 ," + "@aniRun1 ," + "@aniLevelup1 ," + "@mount1 ," + "@summonSkill1 ," + "@speed1 ," + "@smcFileName2 ," + "@aniIdle1_2 ," + "@aniIdle2_2 ," + "@aniAttack1_2 ," + "@aniAttack2_2 ," + "@aniDamage1_2 ," + "@aniDie1_2 ," + "@aniWalk1_2 ," + "@aniRun1_2 ," + "@aniLevelup1_2 ," + "@mount1_2 ," + "@summonSkill1_2 ," + "@speed1_2 ," + ")";
                    mySqlCommand.CommandText = str;
                    mySqlCommand.Prepare();
                    mySqlCommand.Parameters.AddWithValue("@index", attkpet.index);
                    mySqlCommand.Parameters.AddWithValue("@enable", attkpet.enable);
                    mySqlCommand.Parameters.AddWithValue("@type", attkpet.type);
                    mySqlCommand.Parameters.AddWithValue("@name", attkpet.name);
                    mySqlCommand.Parameters.AddWithValue("@str", attkpet.str);
                    mySqlCommand.Parameters.AddWithValue("@con", attkpet.con);
                    mySqlCommand.Parameters.AddWithValue("@dex", attkpet.dex);
                    mySqlCommand.Parameters.AddWithValue("@intel", attkpet.intel);
                    mySqlCommand.Parameters.AddWithValue("@itemidx", attkpet.itemidx);
                    mySqlCommand.Parameters.AddWithValue("@maxFaith", attkpet.maxFaith);
                    mySqlCommand.Parameters.AddWithValue("@maxStm", attkpet.maxStm);
                    mySqlCommand.Parameters.AddWithValue("@maxHP", attkpet.maxHP);
                    mySqlCommand.Parameters.AddWithValue("@maxMP", attkpet.maxMP);
                    mySqlCommand.Parameters.AddWithValue("@recoverHP", attkpet.recoverHP);
                    mySqlCommand.Parameters.AddWithValue("@recoverMP", attkpet.recoverMP);
                    mySqlCommand.Parameters.AddWithValue("@delay", attkpet.delay);
                    mySqlCommand.Parameters.AddWithValue("@AISlot", attkpet.AISlot);
                    mySqlCommand.Parameters.AddWithValue("@afterDead", attkpet.afterDead);
                    mySqlCommand.Parameters.AddWithValue("@attack", attkpet.attack);
                    mySqlCommand.Parameters.AddWithValue("@defense", attkpet.defense);
                    mySqlCommand.Parameters.AddWithValue("@mAttack", attkpet.mAttack);
                    mySqlCommand.Parameters.AddWithValue("@mDefense", attkpet.mDefense);
                    mySqlCommand.Parameters.AddWithValue("@hitPoint", attkpet.hitPoint);
                    mySqlCommand.Parameters.AddWithValue("@avoidPoint", attkpet.avoidPoint);
                    mySqlCommand.Parameters.AddWithValue("@mavoidPoint", attkpet.mavoidPoint);
                    mySqlCommand.Parameters.AddWithValue("@attackSpeed", attkpet.attackSpeed);
                    mySqlCommand.Parameters.AddWithValue("@Deadly", attkpet.Deadly);
                    mySqlCommand.Parameters.AddWithValue("@Critical", attkpet.Critical);
                    mySqlCommand.Parameters.AddWithValue("@awful", attkpet.awful);
                    mySqlCommand.Parameters.AddWithValue("@strong", attkpet.strong);
                    mySqlCommand.Parameters.AddWithValue("@normal", attkpet.normal);
                    mySqlCommand.Parameters.AddWithValue("@weak", attkpet.weak);
                    mySqlCommand.Parameters.AddWithValue("@bagicSkill1", attkpet.bagicSkill1);
                    mySqlCommand.Parameters.AddWithValue("@bagicSkill2", attkpet.bagicSkill2);
                    mySqlCommand.Parameters.AddWithValue("@flag", attkpet.flag);
                    mySqlCommand.Parameters.AddWithValue("@transType", attkpet.transType);
                    mySqlCommand.Parameters.AddWithValue("@transStart", attkpet.transStart);
                    mySqlCommand.Parameters.AddWithValue("@transEnd", attkpet.transEnd);
                    mySqlCommand.Parameters.AddWithValue("@smcFileName1", attkpet.smcFileName1);
                    mySqlCommand.Parameters.AddWithValue("@aniIdle1", attkpet.aniIdle1);
                    mySqlCommand.Parameters.AddWithValue("@aniIdle2", attkpet.aniIdle2);
                    mySqlCommand.Parameters.AddWithValue("@aniAttack1", attkpet.aniAttack1);
                    mySqlCommand.Parameters.AddWithValue("@aniAttack2", attkpet.aniAttack2);
                    mySqlCommand.Parameters.AddWithValue("@aniDamage1", attkpet.aniDamage1);
                    mySqlCommand.Parameters.AddWithValue("@aniDie1", attkpet.aniDie1);
                    mySqlCommand.Parameters.AddWithValue("@aniWalk1", attkpet.aniWalk1);
                    mySqlCommand.Parameters.AddWithValue("@aniRun1", attkpet.aniRun1);
                    mySqlCommand.Parameters.AddWithValue("@aniLevelup1", attkpet.aniLevelup1);
                    mySqlCommand.Parameters.AddWithValue("@mount1", attkpet.mount1);
                    mySqlCommand.Parameters.AddWithValue("@summonSkill1", attkpet.summonSkill1);
                    mySqlCommand.Parameters.AddWithValue("@speed1", attkpet.speed1);
                    mySqlCommand.Parameters.AddWithValue("@smcFileName2", attkpet.smcFileName2);
                    mySqlCommand.Parameters.AddWithValue("@aniIdle1_2", attkpet.aniIdle1_2);
                    mySqlCommand.Parameters.AddWithValue("@aniIdle2_2", attkpet.aniIdle2_2);
                    mySqlCommand.Parameters.AddWithValue("@aniAttack1_2", attkpet.aniAttack1_2);
                    mySqlCommand.Parameters.AddWithValue("@aniAttack2_2", attkpet.aniAttack2_2);
                    mySqlCommand.Parameters.AddWithValue("@aniDamage1_2", attkpet.aniDamage1_2);
                    mySqlCommand.Parameters.AddWithValue("@aniDie1_2", attkpet.aniDie1_2);
                    mySqlCommand.Parameters.AddWithValue("@aniWalk1_2", attkpet.aniWalk1_2);
                    mySqlCommand.Parameters.AddWithValue("@aniRun1_2", attkpet.aniRun1_2);
                    mySqlCommand.Parameters.AddWithValue("@aniLevelup1_2", attkpet.aniLevelup1_2);
                    mySqlCommand.Parameters.AddWithValue("@mount1_2", attkpet.mount1_2);
                    mySqlCommand.Parameters.AddWithValue("@summonSkill1_2", attkpet.summonSkill1_2);
                    mySqlCommand.Parameters.AddWithValue("@speed1_2", attkpet.speed1_2);
                    mySqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                }
            }
            catch (MySqlException ex)
            {
                int num = (int)MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
