﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace yhb_war3_custom_keys {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("yhb_war3_custom_keys.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //////////////////////////////////////////////////////
        /////这个文件包含所有的单位、英雄、
        /////升级、建筑物和技能。请
        /////参考CustomKeyInfo.txt来获取关于如何使用
        /////这个文件的信息。
        /////////////////////////////////////////////////////////
        ///
        ///
        ////////////////////////////////
        /////共享的命令（攻击等）
        ////////////////////////////////
        ///
        /////移动
        ///[CmdMove]
        ///Tip=(|cffffcc00M|r)移动
        ///Hotkey=M
        ///
        /////攻击
        ///[CmdAttack]
        ///Tip=(|cffffcc00A|r)攻击
        ///Hotkey=A
        ///
        /////攻击地面
        ///[CmdAttackGround]
        ///Tip= (|cffffcc00G|r)攻击地面
        ///Hotkey=G
        ///
        /////建造建筑物（一般的）
        ///[CmdBuild]
        ///Tip=(|cffffcc00B|r)建造建筑物
        ///Hotkey=B
        ///
        /////建造建 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CustomKeysSample {
            get {
                return ResourceManager.GetString("CustomKeysSample", resourceCulture);
            }
        }
    }
}
