﻿#pragma checksum "..\..\..\..\UI\Staff\UI_StaffForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E1BA369A875EAF5D46FB58155BE45F3C0009BEA7290D52EB4E2BC8E9B15C627C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CUOIKI_EF.UI.Staff;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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


namespace CUOIKI_EF.UI.Staff {
    
    
    /// <summary>
    /// UI_StaffForm
    /// </summary>
    public partial class UI_StaffForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 59 "..\..\..\..\UI\Staff\UI_StaffForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Information;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\UI\Staff\UI_StaffForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_WorkSession;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\UI\Staff\UI_StaffForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ViewTask;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\UI\Staff\UI_StaffForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_LeaveOfAbsence;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\UI\Staff\UI_StaffForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogOut;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\UI\Staff\UI_StaffForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frameContent;
        
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
            System.Uri resourceLocater = new System.Uri("/CUOIKI-EF;component/ui/staff/ui_staffform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\Staff\UI_StaffForm.xaml"
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
            
            #line 15 "..\..\..\..\UI\Staff\UI_StaffForm.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_Information = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\UI\Staff\UI_StaffForm.xaml"
            this.btn_Information.Click += new System.Windows.RoutedEventHandler(this.btn_Information_click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_WorkSession = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\UI\Staff\UI_StaffForm.xaml"
            this.btn_WorkSession.Click += new System.Windows.RoutedEventHandler(this.btn_WorkSession_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_ViewTask = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\..\UI\Staff\UI_StaffForm.xaml"
            this.btn_ViewTask.Click += new System.Windows.RoutedEventHandler(this.btn_ViewTask_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_LeaveOfAbsence = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\UI\Staff\UI_StaffForm.xaml"
            this.btn_LeaveOfAbsence.Click += new System.Windows.RoutedEventHandler(this.btn_LeaveOfAbsence_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnLogOut = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\..\UI\Staff\UI_StaffForm.xaml"
            this.btnLogOut.Click += new System.Windows.RoutedEventHandler(this.LogOut_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.frameContent = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

