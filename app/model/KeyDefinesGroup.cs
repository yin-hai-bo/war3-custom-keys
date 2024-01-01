﻿using System.Diagnostics;

namespace yhb_war3_custom_keys.model {
    public static class KeyDefinesGroup {

        public struct Entry {
            public readonly string SectionName;
            public readonly string Description;
            public Entry(string secitonName, string caption) {
                this.SectionName = secitonName;
                this.Description = caption;
            }
        }

        public static readonly Entry[] COMMON_ENTRIES = new Entry[] {
            new("CmdMove", "移动"),
            new("CmdAttack", "攻击"),
            new("CmdAttackGround", "攻击地面"),
            new("CmdBuild", "建造建筑物（一般的）"),
            new("CmdBuildHuman", "建造建筑物（人类）"),
            new("CmdBuildOrc", "建造建筑物（兽族）"),
            new("CmdBuildNightElf", "建造建筑物（暗夜精灵）"),
            new("CmdBuildUndead", "召唤建筑物（亡灵）"),
            new("CmdCancel", "取消"),
            new("CmdCancelBuild", "取消建造"),
            new("CmdCancelTrain", "取消训练"),
            new("CmdCancelRevive", "取消复活"),
            new("CmdHoldPos", "保持原位"),
            new("CmdPatrol", "巡逻"),
            new("CmdRally", "设集结点"),
            new("CmdSelectSkill", "英雄技能"),
            new("CmdStop", "停止"),
            new("Ahar", "采集"),
            new("Ahrl", "采集木材"),
            new("Arep", "农民修理技能"),
            new("Anei", "中立单位的互动（选择用户命令）"),
            new("Aloa", "装载"),
            new("Adro", "卸载全部"),
            new("Sdro", "卸载（海上运输工具）"),
        };

        public static readonly List<Entry[]>[] RACE_ENTRIES = new [] {
            new List<Entry[]>(3),
            new List<Entry[]>(3),
            new List<Entry[]>(3),
            new List<Entry[]>(3),
        };

        static KeyDefinesGroup() {
            var race = RACE_ENTRIES[0];
            race.Add(new Entry[] {
                new("Hblm", "血法师"),
                new("AHdr", "魔法吸吮"),
                new("AHfs", "烈焰风暴"),
                new("AHbn", "驱散"),
                new("AHpx", "凤凰"),
                new("Hamg", "大魔法师"),
                new("AHbz", "暴风雪"),
                new("AHwe", "召唤水元素"),
                new("AHab", "辉煌光环 "),
                new("AHmt", "群体传送"),
                new("Hmkg", "山丘之王"),
                new("AHtb", "风暴之锤"),
                new("AHtc", "雷霆一击"),
                new("AHbh", "重击 "),
                new("AHav", "天神下凡"),
                new("Hpal", "圣骑士"),
                new("AHhb", "神圣之光"),
                new("AHds", "神圣护甲"),
                new("AHad", "专注光环"),
                new("AHre", "复活"),
            });
            race.Add(new Entry[] {
                new("hdhw", "龙鹰骑士 "),
                new("Amls", "空中锁镣"),
                new("Aclf", "乌云"),
                new("hfoo", "步兵"),
                new("Adef", "防御"),
                new("hgyr", "飞行机器 "),
                new("hkni", "骑士"),
                new("hmpr", "牧师"),
                new("Ainf", "心灵之火"),
                new("Ahea", "医疗"),
                new("Adis", "驱逐魔法"),
                new("hmtm", "迫击炮小队"),
                new("Afla", "照明弹"),
                new("hpea", "农民"),
                new("Amil", "战斗号召（一个或者多个农民）"),
                new("Amic", "战斗号召（让城镇大厅附近的农民都集合到一起）"),
                new("hrif", "矮人火枪手"),
                new("hsor", "女妖"),
                new("Aslo", "减速"),
                new("Aply", "变形术"),
                new("Aivs", "隐形术"),
                new("hspt", "魔法破坏者"),
                new("Asps", "魔法盗取"),
                new("Acmg", "控制魔法"),
                new("hmtt", "蒸汽机车（不带弹幕攻击）"),
                new("hrtt", "蒸汽机车（带弹幕攻击）"),
                new("hgry", "狮鹫骑士"),
            });
            race.Add(new Entry[] {
                new("Rhss", "魔法控制"),
                new("Rhme", "剑术升级"),
                new("Rhra", "火药升级"),
                new("Rhar", "护甲升级"),
                new("Rhla", "皮甲升级"),
                new("Rhac", "石工技术升级"),
                new("Rhgb", "飞行机器炸弹"),
                new("Rhlh", "改进伐木效率"),
                new("Rhde", "防御升级"),
                new("Rhan", "动物作战训练"),
                new("Rhpt", "牧师训练升级"),
                new("Rhst", "女巫训练升级"),
                new("Rhri", "长管火枪升级"),
                new("Rhse", "魔法岗哨升级"),
                new("Rhfl", "照明弹"),
                new("Rhhb", "风暴战锤"),
                new("Rhrt", "弹幕攻击"),
                new("Rhpm", "背包技能"),
                new("Rhfc", "高射炮火"),
                new("Rhfs", "碎片攻击"),
                new("Rhcd", "乌云"),
                new("halt", "国王祭坛"),
                new("harm", "车间"),
                new("hars", "神秘圣地"),
                new("hbar", "兵营"),
                new("hbla", "铁匠铺"),
                new("hcas", "城堡"),
                new("hhou", "农场"),
                new("hgra", "狮鹫笼"),
                new("hctw", "炮塔"),
                new("hgtw", "防御塔"),
                new("hwtw", "哨塔"),
                new("hatw", "神秘之塔"),
                new("AHta", "显示"),
                new("hvlt", "神秘藏宝室"),
                new("hlum", "伐木场"),
                new("hkee", "主城"),
                new("htow", "城镇大厅"),
            });
        }
    }
}
