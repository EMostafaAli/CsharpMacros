﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CsharpMacros.Test.Macros.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CsharpMacros.Test.Macros.Properties.TestCases", typeof(TestCases).Assembly);
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
        ///    class UserDTO
        ///    {
        ///        public string FirstName { get; set; }
        ///        public string LastName { get; set; }
        ///        public int Age { get; set; }
        ///    }
        ///
        ///    class _001_ObjectWithOwnProperties
        ///    {
        ///
        ///        public void DoSth()
        ///        {
        ///            var user = new UserDTO()
        ///            {
        ///                FirstName = &quot;John&quot;,
        ///                LastName = &quot;Doe&quot;,
        ///                Age = 32
        ///            };
        ///            //[|macro(x in prop [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _001_ObjectWithOwnProperties {
            get {
                return ResourceManager.GetString("_001_ObjectWithOwnProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace CsharpMacros.Test.Macros.Properties.TestData
        ///{
        ///    class UserDTO
        ///    {
        ///        public string FirstName { get; set; }
        ///        public string LastName { get; set; }
        ///        public int Age { get; set; }
        ///    }
        ///
        ///    class _001_ObjectWithOwnProperties
        ///    {
        ///
        ///        public void DoSth()
        ///        {
        ///            var user = new UserDTO()
        ///            {
        ///                FirstName = &quot;John&quot;,
        ///                LastName = &quot;Doe&quot;,
        ///                Age = 32
        ///            };
        ///            Assert.AreNotEqual( [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _001_ObjectWithOwnProperties_FIXED {
            get {
                return ResourceManager.GetString("_001_ObjectWithOwnProperties_FIXED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace CsharpMacros.Test.Macros.Properties.TestData
        ///{
        ///    class BaseDTO
        ///    {
        ///        public int Id {get; set;}
        ///    }
        ///
        ///    class UserDTO: BaseDTO
        ///    {
        ///        public string FirstName { get; set; }
        ///        public string LastName { get; set; }
        ///        public int Age { get; set; }
        ///    }
        ///
        ///    class _001_ObjectWithOwnProperties
        ///    {
        ///
        ///        public void DoSth()
        ///        {
        ///            var user = new UserDTO()
        ///            {
        ///                FirstName = &quot;John&quot;,
        ///                LastName = &quot;D [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _002_ObjectWithInheritedProperties {
            get {
                return ResourceManager.GetString("_002_ObjectWithInheritedProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace CsharpMacros.Test.Macros.Properties.TestData
        ///{
        ///    class BaseDTO
        ///    {
        ///        public int Id {get; set;}
        ///    }
        ///
        ///    class UserDTO: BaseDTO
        ///    {
        ///        public string FirstName { get; set; }
        ///        public string LastName { get; set; }
        ///        public int Age { get; set; }
        ///    }
        ///
        ///    class _001_ObjectWithOwnProperties
        ///    {
        ///
        ///        public void DoSth()
        ///        {
        ///            var user = new UserDTO()
        ///            {
        ///                FirstName = &quot;John&quot;,
        ///                LastName = &quot;D [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _002_ObjectWithInheritedProperties_FIXED {
            get {
                return ResourceManager.GetString("_002_ObjectWithInheritedProperties_FIXED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace CsharpMacros.Test.Macros.Properties.TestData
        ///{
        ///    class GenericType&lt;T&gt;
        ///    {
        ///        public int Id { get; set; }
        ///        public T GenericProperty { get; set; }
        ///    }
        ///
        ///    class _001_ObjectWithOwnProperties
        ///    {
        ///
        ///        public void DoSth()
        ///        {
        ///            var user = new UserDTO()
        ///            {
        ///                FirstName = &quot;John&quot;,
        ///                LastName = &quot;Doe&quot;,
        ///                Age = 32
        ///            };
        ///            //[|macro(x in properties(GenericType&lt;string&gt;))|]
        ///        [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _003_GemericType {
            get {
                return ResourceManager.GetString("_003_GemericType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace CsharpMacros.Test.Macros.Properties.TestData
        ///{
        ///    class GenericType&lt;T&gt;
        ///    {
        ///        public int Id { get; set; }
        ///        public T GenericProperty { get; set; }
        ///    }
        ///
        ///    class _001_ObjectWithOwnProperties
        ///    {
        ///
        ///        public void DoSth()
        ///        {
        ///            var user = new UserDTO()
        ///            {
        ///                FirstName = &quot;John&quot;,
        ///                LastName = &quot;Doe&quot;,
        ///                Age = 32
        ///            };
        ///            Assert.AreNotEqual(default(int), user.Id)
        ///            Ass [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _003_GemericType_FIXED {
            get {
                return ResourceManager.GetString("_003_GemericType_FIXED", resourceCulture);
            }
        }
    }
}
