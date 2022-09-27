﻿#pragma checksum "..\..\..\Barcode\ConfigureBarcode.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4C28138CAE56CE0D21D5F0ED5AD203AB"
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


namespace WpfClientApp.Barcode {
    
    
    /// <summary>
    /// ConfigureBarcode
    /// </summary>
    public partial class ConfigureBarcode : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Barcode\ConfigureBarcode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mTextBoxWidth;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Barcode\ConfigureBarcode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mTextBoxHeight;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Barcode\ConfigureBarcode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mTextBoxStartAtX;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Barcode\ConfigureBarcode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mTextBoxStartAtY;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Barcode\ConfigureBarcode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mTextBoxHBarcodeGap;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Barcode\ConfigureBarcode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mTextBoxVBarcodeGap;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Barcode\ConfigureBarcode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mButtonClose;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Barcode\ConfigureBarcode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas mCanvasBarcodesPreview;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfClientApp;component/barcode/configurebarcode.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Barcode\ConfigureBarcode.xaml"
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
            this.mTextBoxWidth = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\Barcode\ConfigureBarcode.xaml"
            this.mTextBoxWidth.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.mTextBoxWidth_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mTextBoxHeight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.mTextBoxStartAtX = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.mTextBoxStartAtY = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.mTextBoxHBarcodeGap = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.mTextBoxVBarcodeGap = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.mButtonClose = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Barcode\ConfigureBarcode.xaml"
            this.mButtonClose.Click += new System.Windows.RoutedEventHandler(this.mButtonClose_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mCanvasBarcodesPreview = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

