﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScoutHelper.Localization {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ScoutHelper.Localization.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Bear Toolkit.
        /// </summary>
        internal static string BearButton {
            get {
                return ResourceManager.GetString("BearButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generate a Bear Toolkit link from the Hunt Helper train recorder..
        /// </summary>
        internal static string BearButtonTooltip {
            get {
                return ResourceManager.GetString("BearButtonTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At this time there are no configurable settings for Scout Helper, but there will be in the future. Please use command `/scouth` to open the Scout Helper window..
        /// </summary>
        internal static string ConfigWindowContent {
            get {
                return ResourceManager.GetString("ConfigWindowContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scout Helper Settings.
        /// </summary>
        internal static string ConfigWindowTitle {
            get {
                return ResourceManager.GetString("ConfigWindowTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scout Helper.
        /// </summary>
        internal static string MainWindowTitle {
            get {
                return ResourceManager.GetString("MainWindowTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Siren Hunts.
        /// </summary>
        internal static string SirenButton {
            get {
                return ResourceManager.GetString("SirenButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Siren Hunts is not yet implemented. Coming soon!.
        /// </summary>
        internal static string SirenButtonTooltip {
            get {
                return ResourceManager.GetString("SirenButtonTooltip", resourceCulture);
            }
        }
    }
}
