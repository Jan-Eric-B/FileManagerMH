﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileManager.Resources.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
    internal sealed partial class SearchFilters : global::System.Configuration.ApplicationSettingsBase {
        
        private static SearchFilters defaultInstance = ((SearchFilters)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new SearchFilters())));
        
        public static SearchFilters Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\")]
        public string MainPath {
            get {
                return ((string)(this["MainPath"]));
            }
            set {
                this["MainPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SearchOptionsCaseSensitive {
            get {
                return ((bool)(this["SearchOptionsCaseSensitive"]));
            }
            set {
                this["SearchOptionsCaseSensitive"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SearchOptionsFileContent {
            get {
                return ((bool)(this["SearchOptionsFileContent"]));
            }
            set {
                this["SearchOptionsFileContent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SearchOptionsFileName {
            get {
                return ((bool)(this["SearchOptionsFileName"]));
            }
            set {
                this["SearchOptionsFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SearchOptionsSubdirectories {
            get {
                return ((bool)(this["SearchOptionsSubdirectories"]));
            }
            set {
                this["SearchOptionsSubdirectories"] = value;
            }
        }
    }
}