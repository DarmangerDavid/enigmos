﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cpln.Enigmos.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Cpln.Enigmos.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; standalone=&quot;no&quot; ?&gt;
        ///&lt;enigmas&gt;
        ///  &lt;enigma title=&quot;C&apos;est simple&quot;&gt;
        ///    &lt;answer&gt;simple&lt;/answer&gt;
        ///    &lt;hint&gt;Pas d&apos;indice, la solution est simple !&lt;/hint&gt;
        ///  &lt;/enigma&gt;
        ///  &lt;enigma title=&quot;Puzzle&quot;&gt;
        ///    &lt;answer&gt;jongleur&lt;/answer&gt;
        ///    &lt;hint&gt;Remettez les pièces à leur place.&lt;/hint&gt;
        ///  &lt;/enigma&gt;
        ///  &lt;enigma title=&quot;9 Points&quot;&gt;
        ///    &lt;answer&gt;9.&lt;/answer&gt;
        ///    &lt;hint&gt;Tracé les 9 points en 4 traits&lt;/hint&gt;
        ///  &lt;/enigma&gt;
        ///&lt;/enigmas&gt;
        ///.
        /// </summary>
        internal static string enigmas {
            get {
                return ResourceManager.GetString("enigmas", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap NinePoints {
            get {
                object obj = ResourceManager.GetObject("NinePoints", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
