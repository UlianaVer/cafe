﻿#pragma checksum "..\..\..\..\waiter\OrdersWaiterWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D50BF723DE168295DE64392317F23E56093704F7"
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
using Vereshchagina1.waiter;


namespace Vereshchagina1.waiter {
    
    
    /// <summary>
    /// OrdersWaiterWindow
    /// </summary>
    public partial class OrdersWaiterWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\waiter\OrdersWaiterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateOnDatePicker;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\waiter\OrdersWaiterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid OrdersGrid;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\waiter\OrdersWaiterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeStatusOrderButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\waiter\OrdersWaiterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddOrderButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\waiter\OrdersWaiterWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Vereshchagina1;component/waiter/orderswaiterwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\waiter\OrdersWaiterWindow.xaml"
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
            this.DateOnDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.OrdersGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.ChangeStatusOrderButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.AddOrderButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\waiter\OrdersWaiterWindow.xaml"
            this.AddOrderButton.Click += new System.Windows.RoutedEventHandler(this.AddOrderButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\waiter\OrdersWaiterWindow.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

