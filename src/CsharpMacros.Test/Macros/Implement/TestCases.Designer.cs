﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CsharpMacros.Test.Macros.Implement {
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
    internal class TestCases {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestCases() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CsharpMacros.Test.Macros.Implement.TestCases", typeof(TestCases).Assembly);
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
        ///   Looks up a localized string similar to namespace CsharpMacros.Test.Macros.Properties.TestData
        ///{
        ///    public interface ICustomInterface { }
        ///    class ImplementedDirectly1: ICustomInterface { }
        ///    class ImplementedDirectly2: ICustomInterface { }
        ///    class ImplementedInDirectly: ImplementedDirectly1 { }
        ///    public interface IOtherInterface: ICustomInterface { }
        ///
        ///    class _001_ObjectWithOwnMethods
        ///    {
        ///        public void Register&lt;T1, T2&gt;()
        ///        {
        ///
        ///        }
        ///
        ///        public void DoSth()
        ///        {
        ///            //[|macro(x in impl [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _001_CustomInterface {
            get {
                return ResourceManager.GetString("_001_CustomInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace CsharpMacros.Test.Macros.Properties.TestData
        ///{
        ///    public interface ICustomInterface { }
        ///    class ImplementedDirectly1: ICustomInterface { }
        ///    class ImplementedDirectly2: ICustomInterface { }
        ///    class ImplementedInDirectly: ImplementedDirectly1 { }
        ///    public interface IOtherInterface: ICustomInterface { }
        ///
        ///    class _001_ObjectWithOwnMethods
        ///    {
        ///        public void Register&lt;T1, T2&gt;()
        ///        {
        ///
        ///        }
        ///
        ///        public void DoSth()
        ///        {
        ///            this.Register&lt;Imple [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _001_CustomInterface_FIXED {
            get {
                return ResourceManager.GetString("_001_CustomInterface_FIXED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace CsharpMacros.Test.Macros.Properties.TestData
        ///{
        ///    public interface ICustomInterface&lt;T&gt; { }
        ///    class ImplementedDirectly1: ICustomInterface&lt;string&gt; { }
        ///    class ImplementedDirectly2: ICustomInterface&lt;int&gt; { }
        ///    class ImplementedInDirectly: ImplementedDirectly1 { }
        ///    public interface IOtherInterface: ICustomInterface { }
        ///
        ///    class _001_ObjectWithOwnMethods
        ///    {
        ///        public void Register&lt;T1, T2&gt;()
        ///        {
        ///
        ///        }
        ///
        ///        public void DoSth()
        ///        {
        ///            //[ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _002_GenericInterface {
            get {
                return ResourceManager.GetString("_002_GenericInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace CsharpMacros.Test.Macros.Properties.TestData
        ///{
        ///    public interface ICustomInterface&lt;T&gt; { }
        ///    class ImplementedDirectly1: ICustomInterface&lt;string&gt; { }
        ///    class ImplementedDirectly2: ICustomInterface&lt;int&gt; { }
        ///    class ImplementedInDirectly: ImplementedDirectly1 { }
        ///    public interface IOtherInterface: ICustomInterface { }
        ///
        ///    class _001_ObjectWithOwnMethods
        ///    {
        ///        public void Register&lt;T1, T2&gt;()
        ///        {
        ///
        ///        }
        ///
        ///        public void DoSth()
        ///        {
        ///            thi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _002_GenericInterface_FIXED {
            get {
                return ResourceManager.GetString("_002_GenericInterface_FIXED", resourceCulture);
            }
        }
    }
}
