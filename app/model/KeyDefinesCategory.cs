using System.Collections;
using yhb_war3_custom_keys.res;

namespace yhb_war3_custom_keys.model {
    public static class KeyDefinesCategory {

        /// <summary>
        /// Entry in the <see cref="Category"/>.
        /// </summary>
        public readonly struct Entry {

            /*
             // Flare
             [Afla]
             Tip=|cffffcc00F|rlare
             Hotkey=F

             Above contents in the CustomKeys.txt.

            SectionName is "Afla"
             Descripotion is "Flare"
            */

            public readonly string SectionName;
            public readonly string Description;

            public Entry(string secitonName, string caption) {
                this.SectionName = secitonName;
                this.Description = caption;
            }
        }

        /// <summary>
        /// Category or Race. Human, Orc, Undead, Night Elf, Neutral ...
        /// </summary>
        public class Category : IEnumerable<Entry[]> {

            /// <summary>
            /// Name of the race, like "Human", "兽人", ....
            /// </summary>
            public readonly string Name;

            private readonly List<Entry[]> _list = new List<Entry[]>(24);
            public int KindCount => _list.Count;

            /// <summary>
            /// Construct by race name.
            /// </summary>
            /// <param name="name">Category or race name, like "Human", "兽人" ...</param>
            public Category(string name) {
                this.Name = name;
            }

            public void Add(Entry[] entries) {
                _list.Add(entries);
            }

            public IEnumerator<Entry[]> GetEnumerator() {
                return _list.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator() {
                return _list.GetEnumerator();
            }
        };

        private static readonly List<Category> CATEGORY_LIST = new(8);
        public static IEnumerable<Category> CategoryList => CATEGORY_LIST;

        static KeyDefinesCategory() {

            #region Human
            Category category = new(Resources.S_PAGE_HUMAN);
            CATEGORY_LIST.Add(category);
            category.Add(new Entry[] {
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
            category.Add(new Entry[] {
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
            category.Add(new Entry[] {
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
            #endregion

            #region Orc
            category = new(Resources.S_PAGE_ORC);
            CATEGORY_LIST.Add(category);
            category.Add(new Entry[] {
                new("Obla", "剑圣"),
                new("AOwk", "疾步风"),
                new("AOcr", "致命一击 "),
                new("AOmi", "镜像"),
                new("AOww", "剑刃风暴"),
                new("Ofar", "先知"),
                new("AOcl", "闪电链"),
                new("AOfs", "透视"),
                new("AOsf", "野兽幽魂"),
                new("AOeq", "地震"),
                new("Oshd", "暗影猎手"),
                new("AOhw", "医疗波"),
                new("AOsw", "毒蛇守卫"),
                new("AOhx", "妖术 "),
                new("AOvd", "巫毒"),
                new("Otch", "牛头人酋长"),
                new("AOsh", "震荡波"),
                new("AOae", "耐久光环"),
                new("AOws", "战争践踏"),
                new("AOre", "重生"),
            });
            category.Add(new Entry[] {
                new("ocat", "粉碎者"),
                new("odoc", "巨魔巫医"),
                new("Aeye", "岗哨守卫"),
                new("Asta", "静止陷阱"),
                new("Ahwd", "医疗守卫"),
                new("ogru", "兽族步兵"),
                new("ohun", "巨魔猎头者"),
                new("otbk", "巨魔狂暴战士"),
                new("Absk", "狂热愤怒"),
                new("okod", "科多兽"),
                new("Adev", "吞噬魔法"),
                new("opeo", "苦工"),
                new("orai", "掠夺者"),
                new("Aens", "诱捕"),
                new("oshm", "萨满祭司"),
                new("Aprg", "净化"),
                new("Ablo", "嗜血术"),
                new("Alsh", "闪电护盾"),
                new("otau", "牛头人"),
                new("otbr", "巨魔蝙蝠骑士"),
                new("Auco", "不稳定化合物"),
                new("owyv", "风骑士"),
                new("ospm", "灵魂行者"),
                new("Aast", "先祖幽灵"),
                new("Adcn", "消魔"),
                new("Acpf", "灵肉形态"),
                new("Aetf", "虚无形态"),
                new("Aspl", "灵魂锁链"),
            });
            category.Add(new Entry[] {
                new("Rome", "近战武器升级"),
                new("Rora", "远程武器升级"),
                new("Roar", "护甲升级"),
                new("Rwdm", "战鼓"),
                new("Ropg", "掠夺"),
                new("Robs", "狂暴力量"),
                new("Rows", "粉碎"),
                new("Roen", "诱捕"),
                new("Rovs", "浸毒武器"),
                new("Rowd", "巫医训练升级"),
                new("Rost", "萨满祭司训练升级"),
                new("Rosp", "尖刺障碍升级"),
                new("Rotr", "巨魔再生升级"),
                new("Rolf", "液体炸弹升级"),
                new("Ropm", "背包技能"),
                new("Rowt", "灵魂行者训练升级"),
                new("Robk", "狂暴愤怒升级"),
                new("Rorb", "加强型防御"),
                new("Robf", "燃烧之油"),
                new("oalt", "风暴祭坛"),
                new("obar", "兵营"),
                new("obea", "兽栏"),
                new("ofor", "战争磨坊"),
                new("ofrt", "堡垒"),
                new("ogre", "大厅"),
                new("osld", "灵魂归宿"),
                new("ostr", "要塞"),
                new("otrb", "兽族地洞"),
                new("Abtl", "战备状态"),
                new("Astd", "卸载苦工"),
                new("orbr", "加强型地洞"),
                new("otto", "牛头人图腾"),
                new("ovln", "巫毒商店"),
                new("owtw", "了望塔"),
            });
            #endregion

            #region Undead
            category = new(Resources.S_PAGE_UNDEAD);
            CATEGORY_LIST.Add(category);
            category.Add(new Entry[] {
                new("Ucrl", "地穴领主"),
                new("AUim", "穿刺"),
                new("AUts", "尖刺外壳"),
                new("AUcb", "腐尸甲虫"),
                new("Abu2", "钻地（等级2）"),
                new("Abu3", "钻地（等级3）"),
                new("AUls", "蝗虫群"),
                new("Udea", "死亡骑士"),
                new("AUdc", "死亡缠绕"),
                new("AUau", "邪恶光环"),
                new("AUdp", "死亡契约"),
                new("AUan", "操纵死尸"),
                new("Udre", "恐惧魔王"),
                new("AUcs", "腐臭蜂群"),
                new("AUsl", "睡眠"),
                new("AUav", "吸血光环"),
                new("AUin", "地狱火"),
                new("Ulic", "巫妖"),
                new("AUfn", "霜冻新星"),
                new("AUfu", "霜冻护甲"),
                new("AUdr", "黑暗仪式"),
                new("AUdd", "死亡凋零"),
            });
            category.Add(new Entry[] {
                new("uaco", "侍僧"),
                new("Auns", "反召唤建筑物"),
                new("Aaha", " 采集"),
                new("Arst", "恢复"),
                new("uabo", "憎恶"),
                new("Acn2", "吞食尸体"),
                new("uban", "女妖"),
                new("Acrs", "诅咒"),
                new("Aams", "反魔法外壳"),
                new("Aam2", "反魔法外壳"),
                new("Apos", "占据"),
                new("Aps2", "占据"),
                new("ucry", "穴居恶魔"),
                new("Aweb", "蛛网"),
                new("Abur", "钻地"),
                new("ufro", "冰霜巨龙"),
                new("ugar", "石像鬼"),
                new("Astn", "石像形态"),
                new("ugho", "食尸鬼"),
                new("Acan", " 吞食尸体"),
                new("unec", "亡灵巫师"),
                new("Arai", "复活死尸"),
                new("Auhf", "邪恶狂热"),
                new("Acri", "残废"),
                new("umtw", "绞肉车"),
                new("Amel", "得到尸体"),
                new("Amed", "卸载尸体"),
                new("uobs", "十胜石雕像"),
                new("Arpm", "灵魂触摸"),
                new("Arpl", "枯萎精髓"),
                new("ubsp", "变形为破坏者"),
                new("Afak", "毁灭之球"),
                new("Advm", "吞噬魔法"),
                new("Aabs", "吸收魔法"),
            });
            category.Add(new Entry[] {
                new("Rusp", "研究破坏者形态"),
                new("Rume", "邪恶力量升级"),
                new("Rura", "生物攻击升级"),
                new("Ruar", "邪恶装甲升级"),
                new("Rucr", "生物甲壳升级"),
                new("Ruac", "吞食尸体"),
                new("Rugf", "食尸鬼狂热"),
                new("Ruwb", "蛛网"),
                new("Rusf", "石像形态"),
                new("Rune", "亡灵巫师训练升级"),
                new("Ruba", "女妖训练升级"),
                new("Rufb", "冰冻喷吐"),
                new("Rusl", "骨质增强术"),
                new("Rupc", "疾病云雾"),
                new("Rusm", "骷髅法术"),
                new("Rubu", "钻地"),
                new("Ruex", "挖掘尸体"),
                new("Rupm", "背包技能"),
                new("ubon", "埋骨地"),
                new("usap", "牺牲深渊"),
                new("Alam", "牺牲"),
                new("uslh", "屠宰场"),
                new("ugrv", "坟场"),
                new("uaod", "黑暗祭坛"),
                new("unpl", "大墓地"),
                new("unp1", "亡者大厅"),
                new("unp2", "黑色城堡"),
                new("usep", "地穴"),
                new("utod", "诅咒神庙"),
                new("utom", "古墓废墟"),
                new("ugol", "闹鬼金矿"),
                new("uzig", "通灵塔"),
                new("uzg1", "幽魂之塔"),
                new("uzg2", "蛛网怪塔"),
            });
            #endregion

            #region Night Elves
            category = new(Resources.S_PAGE_NIGHT_ELVES);
            CATEGORY_LIST.Add(category);
            category.Add(new Entry[] {
                new("Edem", "恶魔猎手"),
                new("AEmb", "法力燃烧"),
                new("AEim", "献祭 "),
                new("AEev", "闪避"),
                new("AEme", "变身"),
                new("Ekee", "丛林守护者"),
                new("AEer", "纠缠根须"),
                new("AEfn", "自然之力 "),
                new("AEah", "荆棘光环"),
                new("AEtq", "宁静"),
                new("Emoo", "月之女祭司"),
                new("AEst", "侦察"),
                new("AHfa", "灼热之箭 "),
                new("AEar", "强击光环"),
                new("AEsf", "群星坠落"),
                new("Ewar", "守望者"),
                new("AEbl", "闪烁"),
                new("AEfk", "刀阵旋风"),
                new("AEsh", "暗影突袭"),
                new("AEsv", "复仇之魂"),
                new("Avng", " 复仇之魂"),
            });
            category.Add(new Entry[] {
                new("Ashm", "隐藏"),
                new("ebal", "投刃车"),
                new("echm", "奇美拉"),
                new("edoc", "利爪德鲁伊"),
                new("Aroa", "战嚎"),
                new("Arej", "生命恢复"),
                new("Abrf", "变熊"),
                new("Ara2", "咆哮"),
                new("edot", "猛禽德鲁伊"),
                new("Afae", "精灵之火"),
                new("Acyc", "飓风"),
                new("Arav", "风暴之鸦状态"),
                new("Afa2", "精灵之火"),
                new("ewsp", "小精灵"),
                new("Aren", "更新"),
                new("Awha", "采集"),
                new("Adtn", "爆炸"),
                new("esen", "女猎手"),
                new("Aesn", "哨兵"),
                new("earc", "弓箭手"),
                new("Aco2", "骑乘角鹰兽"),
                new("Adec", "卸载弓箭手和 & 角鹰兽"),
                new("edry", "树妖"),
                new("Aadm", "驱逐魔法"),
                new("ehip", "角鹰兽"),
                new("Aco3", "搭载弓箭手"),
                new("emtg", "山岭巨人"),
                new("Agra", "拔树"),
                new("Atau", "嘲讽"),
                new("efdr", "精灵龙"),
                new("Amfl", "魔力之焰"),
                new("Apsh", "变相移动"),
            });
            category.Add(new Entry[] {
                new("Resm", "月之力量升级"),
                new("Resw", "野性力量升级"),
                new("Rema", "月之护甲升级"),
                new("Rerh", "加强隐藏升级"),
                new("Reuv", "夜视能力"),
                new("Renb", "自然的祝福"),
                new("Reib", "硬弓"),
                new("Remk", "射击术"),
                new("Resc", "哨兵"),
                new("Remg", "月刃"),
                new("Redt", "猛禽德鲁伊训练升级"),
                new("Redc", "利爪德鲁伊训练升级"),
                new("Resi", "驱散魔法"),
                new("Reht", "驯服角鹰兽"),
                new("Recb", "腐蚀喷吐"),
                new("Repb", "穿刺剑刃"),
                new("Rers", "抗性皮肤"),
                new("Rehs", "硬化皮肤"),
                new("Reeb", "利爪之痕"),
                new("Reec", "猛禽之痕"),
                new("Rews", "月井之春"),
                new("Repm", "背包技能"),
                new("Aeat", "吞食树木"),
                new("Aroo", "起立"),
                new("etrp", "远古保护者"),
                new("etol", "生命之树"),
                new("Aent", "缠绕金矿"),
                new("Aenc", "缠绕金矿（装载/卸载）"),
                new("Slo2", "装载小精灵"),
                new("Adri", " 卸载全部"),
                new("etoa", "升级到远古之树"),
                new("etoe", "升级到永恒之树"),
                new("edob", "猎手大厅"),
                new("eate", "长者祭坛"),
                new("eaoe", "知识古树"),
                new("eaom", "战争古树"),
                new("eaow", "风之古树"),
                new("eden", "奇迹古树"),
                new("edos", "奇美拉栖木"),
                new("emow", "月亮井"),
                new("Ambt", "补充魔法和生命值"),
            });
            #endregion

            #region Neutral heroes
            category = new(Resources.S_PAGE_NEUTRAL);
            CATEGORY_LIST.Add(category);
            category.Add(new Entry[] {
                new("Nngs", "娜迦女海巫"),
                new("ANms", "魔法护盾"),
                new("ANfl", "叉状闪电"),
                new("ANfa", "霜冻之箭 "),
                new("ANto", "龙卷风"),
                new("Nplh", "深渊魔王"),
                new("ANht", "恐怖嚎叫"),
                new("ANrf", "火焰雨"),
                new("ANca", "分裂攻击"),
                new("ANdo", "毁灭"),
                new("Npbm", "熊猫酒仙"),
                new("ANbf", "火焰呼吸"),
                new("ANdb", "醉拳"),
                new("ANdh", "醉酒云雾"),
                new("ANef", "火土风暴"),
                new("ANwk", "疾风步"),
                new("ACcy", "飓风"),
                new("Adsm", "驱逐魔法"),
                new("ANta", "嘲讽"),
                new("Nbst", "驯兽师"),
                new("ANsg", "熊"),
                new("ANsq", "豪猪"),
                new("ANsw", "战鹰"),
                new("ANst", "惊吓"),
                new("ANbl", "闪烁"),
                new("Nbrn", "黑暗游侠"),
                new("ANba", "黑暗之箭"),
                new("ANsi", "沉默魔法"),
                new("ANdr", "生命汲取"),
                new("ANch", "符咒"),
                new("Ntin", "修补匠"),
                new("Nrob", "修补匠（变形/机械地精）"),
                new("ANsy", "口袋工厂"),
                new("ANs1", "口袋工厂"),
                new("ANs2", "口袋工厂"),
                new("ANs3", "口袋工厂"),
                new("ANcs", "火箭群"),
                new("ANc1", "火箭群"),
                new("ANc2", "火箭群"),
                new("ANc3", "火箭群"),
                new("ANeg", "工程升级 "),
                new("ANrg", "机器人地精"),
                new("ANg1", "机器人地精"),
                new("ANg2", "机器人地精"),
                new("ANg3", "机器人地精"),
                new("ANde", "粉碎"),
                new("ANd1", "粉碎"),
                new("ANd2", "粉碎"),
                new("ANd3", "粉碎"),
                new("ANfy", "工厂"),
                new("ANf1", "工厂"),
                new("ANf2", "工厂"),
                new("ANf3", "工厂"),
                new("Asdg", "自爆！（等级1）"),
                new("Asd2", "自爆！（等级2）"),
                new("Asd3", "自爆！（等级3）"),
                new("Nalc", "炼金术士"),
                new("Nalm", "炼金术士"),
                new("Nal2", "炼金术士"),
                new("Nal3", "炼金术士"),
                new("ANhs", "医疗气雾 "),
                new("ANab", "酸性炸弹"),
                new("ANcr", "化学风暴"),
                new("ANtm", "点金术"),
                new("Nfir", "火焰巨魔"),
                new("ANic", "燃灰"),
                new("ANia", "燃灰 (Arrow)"),
                new("ANso", "灵魂燃烧"),
                new("ANlm", "召唤炎魔"),
                new("ANvc", "火山爆发"),
            });
            #endregion

            #region Common
            category = new(Resources.S_PAGE_COMMON);
            CATEGORY_LIST.Add(category);
            category.Add(new Entry[] {
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
            });
            #endregion
        }
    }
}
