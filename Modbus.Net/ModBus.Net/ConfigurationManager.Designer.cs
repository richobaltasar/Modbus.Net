﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModBus.Net {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ConfigurationManager {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConfigurationManager() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ModBus.Net.ConfigurationManager", typeof(ConfigurationManager).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 COM1 的本地化字符串。
        /// </summary>
        public static string COM {
            get {
                return ResourceManager.GetString("COM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 opcda://localhost/FBoxOpcServer 的本地化字符串。
        /// </summary>
        public static string FBoxOpcDaHost {
            get {
                return ResourceManager.GetString("FBoxOpcDaHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 192.168.1.1 的本地化字符串。
        /// </summary>
        public static string IP {
            get {
                return ResourceManager.GetString("IP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 5000 的本地化字符串。
        /// </summary>
        public static string IPConnectionTimeout {
            get {
                return ResourceManager.GetString("IPConnectionTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 502 的本地化字符串。
        /// </summary>
        public static string ModbusPort {
            get {
                return ResourceManager.GetString("ModbusPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 opcda://localhost/... 的本地化字符串。
        /// </summary>
        public static string OpcDaHost {
            get {
                return ResourceManager.GetString("OpcDaHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 102 的本地化字符串。
        /// </summary>
        public static string SiemensPort {
            get {
                return ResourceManager.GetString("SiemensPort", resourceCulture);
            }
        }
    }
}
