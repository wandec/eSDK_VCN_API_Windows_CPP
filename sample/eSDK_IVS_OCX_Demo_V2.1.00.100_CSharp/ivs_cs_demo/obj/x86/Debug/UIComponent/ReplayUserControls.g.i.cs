﻿#pragma checksum "..\..\..\..\UIComponent\ReplayUserControls.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7C75F490D7CFBDA058D50E3CFF9DB048"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace ivs_cs_demo {
    
    
    /// <summary>
    /// ReplayUserControls
    /// </summary>
    public partial class ReplayUserControls : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 40 "..\..\..\..\UIComponent\ReplayUserControls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StartTime;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\UIComponent\ReplayUserControls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EndTime;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\UIComponent\ReplayUserControls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CameraCode;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\UIComponent\ReplayUserControls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RecordType;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\UIComponent\ReplayUserControls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RecordList;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\UIComponent\ReplayUserControls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LocalFileName;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\UIComponent\ReplayUserControls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WndID;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\UIComponent\ReplayUserControls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Speed;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\UIComponent\ReplayUserControls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox eSDKCodeTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/ivs_cs_demo;component/uicomponent/replayusercontrols.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UIComponent\ReplayUserControls.xaml"
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
            this.StartTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.EndTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.CameraCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.RecordType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.RecordList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.LocalFileName = ((System.Windows.Controls.TextBox)(target));
            
            #line 87 "..\..\..\..\UIComponent\ReplayUserControls.xaml"
            this.LocalFileName.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.LocalFileName_GotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 9:
            this.WndID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Speed = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.eSDKCodeTextBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 62 "..\..\..\..\UIComponent\ReplayUserControls.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StartReplay_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 63 "..\..\..\..\UIComponent\ReplayUserControls.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StopReplay_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

