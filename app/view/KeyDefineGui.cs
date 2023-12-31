using yhb_war3_custom_keys.model;

namespace yhb_war3_custom_keys.view {
    internal class KeyDefineGui {
        private readonly ListView _listView;

        private struct Entry {
            public readonly string SectionName;
            public readonly string Description;
            public Entry(string secitonName, string caption) {
                this.SectionName = secitonName;
                this.Description = caption;
            }
        }

        private static readonly Entry[] entries = new Entry[] {
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

        public KeyDefineGui(Control parent, KeyDefines keyDefines) {
            _listView = new ListView();
            _listView.Parent = parent;
            _listView.Dock = DockStyle.Fill;
            _listView.View = View.Details;
            _listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            _listView.GridLines = true;
            _listView.FullRowSelect = true;

            _listView.Columns.Add("", -1);
            _listView.Columns.Add("Hotkey", -2);
            _listView.Columns.Add("Unhotkey", -2);
            _listView.Columns.Add("Tip", -1);

            foreach (var entry in entries) {
                var section = keyDefines.GetSection(entry.SectionName);
                if (section != null) {
                    var item = _listView.Items.Add(entry.Description);
                    item.SubItems.Add(section.Find("Hotkey"));
                    item.SubItems.Add(section.Find("Unhhotkey"));
                    item.SubItems.Add(section.Find("Tip"));
                }
            }
        }
    }
}

