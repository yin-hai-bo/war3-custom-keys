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

        public static readonly Entry[] HUMAN_HERO_ENTRIES = new Entry[] {
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
        };
    }
}
