﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace w {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CustomMenu {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CustomMenu() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("w.CustomMenu", typeof(CustomMenu).Assembly);
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
        ///   Looks up a localized string similar to &lt;customUI onLoad=&quot;AddinInitialize&quot; xmlns=&quot;http://schemas.microsoft.com/office/2009/07/customui&quot;&gt;
        ///  &lt;ribbon startFromScratch=&quot;false&quot;&gt;
        ///    &lt;tabs&gt;
        ///      &lt;tab id=&quot;Office_tab&quot;
        ///           label=&quot;Экспорт таблицы Excel&quot;
        ///           visible=&quot;true&quot;&gt;
        ///        &lt;group id=&quot;group1&quot;
        ///               visible=&quot;true&quot;
        ///               label=&quot;Выборка данных&quot;&gt;
        ///          &lt;button id=&quot;button_settings&quot; label=&quot;Вставить таблицу&quot; size=&quot;large&quot; getImage=&quot;GetInsertTableBtnImage&quot; onAction=&quot;InsertTableBtn_Click&quot;/&gt;
        ///        &lt;/group&gt;
        ///     [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string customUI {
            get {
                return ResourceManager.GetString("customUI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap insertTable {
            get {
                object obj = ResourceManager.GetObject("insertTable", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
