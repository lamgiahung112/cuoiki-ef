﻿#pragma checksum "..\..\..\..\..\UI\Manager\AssignTaskPages\StagePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "24EC7DB9DAC2BCE706DCAE92F6971EB8BE1AAC9636E429687BD913B48E73CCBD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CUOIKI_EF.UI.Manager.AssignTaskPages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace CUOIKI_EF.UI.Manager.AssignTaskPages {
    
    
    /// <summary>
    /// StagePage
    /// </summary>
    public partial class StagePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 23 "..\..\..\..\..\UI\Manager\AssignTaskPages\StagePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddStage;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\UI\Manager\AssignTaskPages\StagePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer MyScrollViewer;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\..\UI\Manager\AssignTaskPages\StagePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back_click;
        
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
            System.Uri resourceLocater = new System.Uri("/CUOIKI-EF;component/ui/manager/assigntaskpages/stagepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Manager\AssignTaskPages\StagePage.xaml"
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
            this.BtnAddStage = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.MyScrollViewer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 5:
            this.Back_click = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\..\UI\Manager\AssignTaskPages\StagePage.xaml"
            this.Back_click.Click += new System.Windows.RoutedEventHandler(this.back_click);
            
            #line default
            #line hidden
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
            case 3:
            
            #line 37 "..\..\..\..\..\UI\Manager\AssignTaskPages\StagePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnStageItem_Click);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\..\..\UI\Manager\AssignTaskPages\StagePage.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BtnStageItem_PreviewMouseRightButtonDown);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 48 "..\..\..\..\..\UI\Manager\AssignTaskPages\StagePage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewMenuItem_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
