﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    public sealed partial class CourseProgram : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the CourseProgram entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public CourseProgram()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public CourseProgram(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.CourseProgram> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.CourseProgram.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CourseProgram_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CourseProgram_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.CourseProgram.DetailsClass.GetValue(this, global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.CourseProgram.DetailsClass.SetValue(this, global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Id, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Summary
        {
            get
            {
                return global::LightSwitchApplication.CourseProgram.DetailsClass.GetValue(this, global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Summary);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Summary_Compute(ref string result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Summary_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public byte[] RowVersion
        {
            get
            {
                return global::LightSwitchApplication.CourseProgram.DetailsClass.GetValue(this, global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.RowVersion);
            }
            set
            {
                global::LightSwitchApplication.CourseProgram.DetailsClass.SetValue(this, global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.RowVersion, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Course Course
        {
            get
            {
                return global::LightSwitchApplication.CourseProgram.DetailsClass.GetValue(this, global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Course);
            }
            set
            {
                global::LightSwitchApplication.CourseProgram.DetailsClass.SetValue(this, global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Course, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Course_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Course_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Course_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Program Program
        {
            get
            {
                return global::LightSwitchApplication.CourseProgram.DetailsClass.GetValue(this, global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Program);
            }
            set
            {
                global::LightSwitchApplication.CourseProgram.DetailsClass.SetValue(this, global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Program, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Program_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Program_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Program_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.CourseProgram,
                global::LightSwitchApplication.CourseProgram.DetailsClass,
                global::LightSwitchApplication.CourseProgram.DetailsClass.IImplementation,
                global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass>.Entry
                __CourseProgramEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass>.Entry(
                    global::LightSwitchApplication.CourseProgram.DetailsClass.__CourseProgram_CreateNew,
                    global::LightSwitchApplication.CourseProgram.DetailsClass.__CourseProgram_Created,
                    global::LightSwitchApplication.CourseProgram.DetailsClass.__CourseProgram_AllowSaveWithErrors);
            private static global::LightSwitchApplication.CourseProgram __CourseProgram_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.CourseProgram> es)
            {
                return new global::LightSwitchApplication.CourseProgram(es);
            }
            private static void __CourseProgram_Created(global::LightSwitchApplication.CourseProgram e)
            {
                e.CourseProgram_Created();
            }
            private static bool __CourseProgram_AllowSaveWithErrors(global::LightSwitchApplication.CourseProgram e)
            {
                bool result = false;
                e.CourseProgram_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityComputedProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, string> Summary
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Summary) as global::Microsoft.LightSwitch.Details.Framework.EntityComputedProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, byte[]> RowVersion
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.RowVersion) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, byte[]>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, global::LightSwitchApplication.Course> Course
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Course) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, global::LightSwitchApplication.Course>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, global::LightSwitchApplication.Program> Program
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Program) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, global::LightSwitchApplication.Program>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new byte[] RowVersion { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Course { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Program { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.CourseProgram.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, int>.Data> c, global::LightSwitchApplication.CourseProgram.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.CourseProgram e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.CourseProgram e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.CourseProgram.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.CourseProgram.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.CourseProgram e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityComputedProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, string>.Entry
                    Summary = new global::Microsoft.LightSwitch.Details.Framework.EntityComputedProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, string>.Entry(
                        "Summary",
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Summary_Stub,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Summary_Validate,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Summary_ComputeValue);
                private static void _Summary_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.CourseProgram.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityComputedProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, string>.Data> c, global::LightSwitchApplication.CourseProgram.DetailsClass d, object sf)
                {
                    c(d, ref d._Summary, sf);
                }
                private static void _Summary_Validate(global::LightSwitchApplication.CourseProgram e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Summary_Validate(r);
                }
                private static string _Summary_ComputeValue(global::LightSwitchApplication.CourseProgram e)
                {
                    string value = default(string);
                    e.Summary_Compute(ref value);
                    return value;
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, byte[]>.Entry
                    RowVersion = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, byte[]>.Entry(
                        "RowVersion",
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._RowVersion_Stub,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._RowVersion_Validate,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged);
                private static void _RowVersion_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.CourseProgram.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, byte[]>.Data> c, global::LightSwitchApplication.CourseProgram.DetailsClass d, object sf)
                {
                    c(d, ref d._RowVersion, sf);
                }
                private static bool _RowVersion_ComputeIsReadOnly(global::LightSwitchApplication.CourseProgram e)
                {
                    bool result = false;
                    e.RowVersion_IsReadOnly(ref result);
                    return result;
                }
                private static void _RowVersion_Validate(global::LightSwitchApplication.CourseProgram e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.RowVersion_Validate(r);
                }
                private static byte[] _RowVersion_GetImplementationValue(global::LightSwitchApplication.CourseProgram.DetailsClass d)
                {
                    return d.ImplementationEntity.RowVersion;
                }
                private static void _RowVersion_SetImplementationValue(global::LightSwitchApplication.CourseProgram.DetailsClass d, byte[] v)
                {
                    d.ImplementationEntity.RowVersion = v;
                }
                private static void _RowVersion_OnValueChanged(global::LightSwitchApplication.CourseProgram e)
                {
                    e.RowVersion_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, global::LightSwitchApplication.Course>.Entry
                    Course = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, global::LightSwitchApplication.Course>.Entry(
                        "Course",
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Course_Stub,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Course_ComputeIsReadOnly,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Course_Validate,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Course_GetCoreImplementationValue,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Course_GetImplementationValue,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Course_SetImplementationValue,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Course_Refresh,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Course_OnValueChanged);
                private static void _Course_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.CourseProgram.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, global::LightSwitchApplication.Course>.Data> c, global::LightSwitchApplication.CourseProgram.DetailsClass d, object sf)
                {
                    c(d, ref d._Course, sf);
                }
                private static bool _Course_ComputeIsReadOnly(global::LightSwitchApplication.CourseProgram e)
                {
                    bool result = false;
                    e.Course_IsReadOnly(ref result);
                    return result;
                }
                private static void _Course_Validate(global::LightSwitchApplication.CourseProgram e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Course_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Course_GetCoreImplementationValue(global::LightSwitchApplication.CourseProgram.DetailsClass d)
                {
                    return d.ImplementationEntity.Course;
                }
                private static global::LightSwitchApplication.Course _Course_GetImplementationValue(global::LightSwitchApplication.CourseProgram.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass>(global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Course, ref d._Course);
                }
                private static void _Course_SetImplementationValue(global::LightSwitchApplication.CourseProgram.DetailsClass d, global::LightSwitchApplication.Course v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Course, ref d._Course, (i, ev) => i.Course = ev, v);
                }
                private static void _Course_Refresh(global::LightSwitchApplication.CourseProgram.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Course, ref d._Course);
                }
                private static void _Course_OnValueChanged(global::LightSwitchApplication.CourseProgram e)
                {
                    e.Course_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, global::LightSwitchApplication.Program>.Entry
                    Program = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, global::LightSwitchApplication.Program>.Entry(
                        "Program",
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Program_Stub,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Program_ComputeIsReadOnly,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Program_Validate,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Program_GetCoreImplementationValue,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Program_GetImplementationValue,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Program_SetImplementationValue,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Program_Refresh,
                        global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties._Program_OnValueChanged);
                private static void _Program_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.CourseProgram.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, global::LightSwitchApplication.Program>.Data> c, global::LightSwitchApplication.CourseProgram.DetailsClass d, object sf)
                {
                    c(d, ref d._Program, sf);
                }
                private static bool _Program_ComputeIsReadOnly(global::LightSwitchApplication.CourseProgram e)
                {
                    bool result = false;
                    e.Program_IsReadOnly(ref result);
                    return result;
                }
                private static void _Program_Validate(global::LightSwitchApplication.CourseProgram e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Program_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Program_GetCoreImplementationValue(global::LightSwitchApplication.CourseProgram.DetailsClass d)
                {
                    return d.ImplementationEntity.Program;
                }
                private static global::LightSwitchApplication.Program _Program_GetImplementationValue(global::LightSwitchApplication.CourseProgram.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Program, global::LightSwitchApplication.Program.DetailsClass>(global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Program, ref d._Program);
                }
                private static void _Program_SetImplementationValue(global::LightSwitchApplication.CourseProgram.DetailsClass d, global::LightSwitchApplication.Program v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Program, ref d._Program, (i, ev) => i.Program = ev, v);
                }
                private static void _Program_Refresh(global::LightSwitchApplication.CourseProgram.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.CourseProgram.DetailsClass.PropertySetProperties.Program, ref d._Program);
                }
                private static void _Program_OnValueChanged(global::LightSwitchApplication.CourseProgram e)
                {
                    e.Program_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityComputedProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, string>.Data _Summary;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, byte[]>.Data _RowVersion;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, global::LightSwitchApplication.Course>.Data _Course;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.CourseProgram, global::LightSwitchApplication.CourseProgram.DetailsClass, global::LightSwitchApplication.Program>.Data _Program;
            
        }
    
        #endregion
    }
    
    #endregion
}
