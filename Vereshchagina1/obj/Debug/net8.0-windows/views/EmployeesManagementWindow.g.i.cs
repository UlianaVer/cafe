﻿#pragma checksum "..\..\..\..\views\EmployeesManagementWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94092A3A3B38FB2BD1EEEB869629979692348DF1"
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
using System.Windows.Controls.Ribbon;
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
using Vereshchagina1;


namespace Vereshchagina1 {
    
    
    /// <summary>
    /// EmployeesManagementWindow
    /// </summary>
    public partial class EmployeesManagementWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\views\EmployeesManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EmployeesGrid;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\views\EmployeesManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteEmployButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\views\EmployeesManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoAddEmployButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\views\EmployeesManagementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Vereshchagina1;component/views/employeesmanagementwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\views\EmployeesManagementWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.EmployeesGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.DeleteEmployButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\views\EmployeesManagementWindow.xaml"
            this.DeleteEmployButton.Click += new System.Windows.RoutedEventHandler(this.DeleteEmployButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GoAddEmployButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\views\EmployeesManagementWindow.xaml"
            this.GoAddEmployButton.Click += new System.Windows.RoutedEventHandler(this.GoAddEmployButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\views\EmployeesManagementWindow.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

