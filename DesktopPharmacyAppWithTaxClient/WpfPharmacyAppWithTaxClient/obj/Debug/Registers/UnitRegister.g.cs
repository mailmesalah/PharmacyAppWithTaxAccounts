﻿#pragma checksum "..\..\..\Registers\UnitRegister.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9DB9199C1A46CEF6BB84C7CC23C7F24A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ServerServiceInterface;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace WpfClientApp.Registers {
    
    
    /// <summary>
    /// UnitRegister
    /// </summary>
    public partial class UnitRegister : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Registers\UnitRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView mTreeUnitRegister;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Registers\UnitRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox mComboUnitGroups;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Registers\UnitRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mTextBoxUnit;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Registers\UnitRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mTextBoxUnitValue;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Registers\UnitRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mButtonAddGroup;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Registers\UnitRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mButtonAddItem;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Registers\UnitRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mButtonDelete;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Registers\UnitRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mButtonSave;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Registers\UnitRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mButtonClose;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Registers\UnitRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mTextBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Registers\UnitRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mButtonFindNext;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfClientApp;component/registers/unitregister.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Registers\UnitRegister.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 6 "..\..\..\Registers\UnitRegister.xaml"
            ((WpfClientApp.Registers.UnitRegister)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.Window_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mTreeUnitRegister = ((System.Windows.Controls.TreeView)(target));
            
            #line 22 "..\..\..\Registers\UnitRegister.xaml"
            this.mTreeUnitRegister.SelectedItemChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.mTreeUnitRegister_SelectedItemChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mComboUnitGroups = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.mTextBoxUnit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.mTextBoxUnitValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.mButtonAddGroup = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Registers\UnitRegister.xaml"
            this.mButtonAddGroup.Click += new System.Windows.RoutedEventHandler(this.mButtonAddGroup_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.mButtonAddItem = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Registers\UnitRegister.xaml"
            this.mButtonAddItem.Click += new System.Windows.RoutedEventHandler(this.mButtonAddItem_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mButtonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Registers\UnitRegister.xaml"
            this.mButtonDelete.Click += new System.Windows.RoutedEventHandler(this.mButtonDelete_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.mButtonSave = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Registers\UnitRegister.xaml"
            this.mButtonSave.Click += new System.Windows.RoutedEventHandler(this.mButtonSave_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.mButtonClose = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Registers\UnitRegister.xaml"
            this.mButtonClose.Click += new System.Windows.RoutedEventHandler(this.mButtonClose_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.mTextBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\Registers\UnitRegister.xaml"
            this.mTextBoxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.mTextBoxSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.mButtonFindNext = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Registers\UnitRegister.xaml"
            this.mButtonFindNext.Click += new System.Windows.RoutedEventHandler(this.mButtonFindNext_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

