﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.VisualStudio.IDE.OptionsPage {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCode()]
    [System.Runtime.CompilerServices.CompilerGenerated()]
    internal class Resources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (ReferenceEquals(resourceMan, null)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Microsoft.Samples.VisualStudio.IDE.OptionsPage.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Clear Image.
        /// </summary>
        internal static string ButtonClearImageText {
            get {
                return ResourceManager.GetString("ButtonClearImageText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose &amp;Image.
        /// </summary>
        internal static string ChooseImageButtonText {
            get {
                return ResourceManager.GetString("ChooseImageButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Information.
        /// </summary>
        internal static string MessageCaption {
            get {
                return ResourceManager.GetString("MessageCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press Cancel to cancel this activation.  OK to continue.
        /// </summary>
        internal static string MessageOnActivateEntered {
            get {
                return ResourceManager.GetString("MessageOnActivateEntered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In OnApply.
        /// </summary>
        internal static string MessageOnApply {
            get {
                return ResourceManager.GetString("MessageOnApply", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press Cancel to cancel this OnApply.  OK to continue.
        /// </summary>
        internal static string MessageOnApplyEntered {
            get {
                return ResourceManager.GetString("MessageOnApplyEntered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OnClosed.
        /// </summary>
        internal static string MessageOnClosed {
            get {
                return ResourceManager.GetString("MessageOnClosed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press Cancel to cancel this deactivation.  OK to continue.
        /// </summary>
        internal static string MessageOnDeactivateEntered {
            get {
                return ResourceManager.GetString("MessageOnDeactivateEntered", resourceCulture);
            }
        }
    }
}