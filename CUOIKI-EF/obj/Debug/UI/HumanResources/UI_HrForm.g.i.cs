﻿#pragma checksum "..\..\..\..\UI\HumanResources\UI_HrForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C91390F094E0BE8CE6FBC9E8E7BB11AF298A84E1771E3D3118A297F132942FF6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CUOIKI_EF.UI.HumanResources;
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


namespace CUOIKI_EF.UI.HumanResources {
    
    
    /// <summary>
    /// UI_HrForm
    /// </summary>
    public partial class UI_HrForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 69 "..\..\..\..\UI\HumanResources\UI_HrForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Information;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\UI\HumanResources\UI_HrForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_CalcSalary;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\UI\HumanResources\UI_HrForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogOut;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\UI\HumanResources\UI_HrForm.xaml"
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
            System.Uri resourceLocater = new System.Uri("/CUOIKI-EF;component/ui/humanresources/ui_hrform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\HumanResources\UI_HrForm.xaml"
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
            
            #line 22 "..\..\..\..\UI\HumanResources\UI_HrForm.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_Information = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.btn_CalcSalary = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\..\UI\HumanResources\UI_HrForm.xaml"
            this.btn_CalcSalary.Click += new System.Windows.RoutedEventHandler(this.btn_CalcSalary_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnLogOut = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\..\UI\HumanResources\UI_HrForm.xaml"
            this.btnLogOut.Click += new System.Windows.RoutedEventHandler(this.LogOut_click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.frameContent = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
