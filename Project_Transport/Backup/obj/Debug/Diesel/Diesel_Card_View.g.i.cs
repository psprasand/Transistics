﻿#pragma checksum "..\..\..\Diesel\Diesel_Card_View.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "87164F1936DBA09BF0DD076589D24AFA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Reporting.WinForms;
using Microsoft.Windows.Controls;
using Project_Transport;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WpfTools;


namespace Project_Transport {
    
    
    /// <summary>
    /// Diesel_Card_View
    /// </summary>
    public partial class Diesel_Card_View : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Diesel\Diesel_Card_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel diesel_detail_view_panel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Diesel\Diesel_Card_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox card_view;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Diesel\Diesel_Card_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker From;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Diesel\Diesel_Card_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker To;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Diesel\Diesel_Card_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label diesel_balance;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Diesel\Diesel_Card_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox trip_diesel_balance;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Diesel\Diesel_Card_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Reporting.WinForms.ReportViewer Report_Viewer;
        
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
            System.Uri resourceLocater = new System.Uri("/Project_Transport;component/diesel/diesel_card_view.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Diesel\Diesel_Card_View.xaml"
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
            this.diesel_detail_view_panel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.card_view = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\Diesel\Diesel_Card_View.xaml"
            this.card_view.KeyDown += new System.Windows.Input.KeyEventHandler(this.unique_card_view);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\Diesel\Diesel_Card_View.xaml"
            this.card_view.GotFocus += new System.Windows.RoutedEventHandler(this.card_view_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.From = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.To = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.diesel_balance = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.trip_diesel_balance = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\Diesel\Diesel_Card_View.xaml"
            this.trip_diesel_balance.KeyDown += new System.Windows.Input.KeyEventHandler(this.trip_diesel_balance_keydown);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 42 "..\..\..\Diesel\Diesel_Card_View.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.card_details_view_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 43 "..\..\..\Diesel\Diesel_Card_View.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.deposit_view_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 44 "..\..\..\Diesel\Diesel_Card_View.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.diesel_entry_view_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 45 "..\..\..\Diesel\Diesel_Card_View.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.deposit_diesel_entry_view_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Report_Viewer = ((Microsoft.Reporting.WinForms.ReportViewer)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

