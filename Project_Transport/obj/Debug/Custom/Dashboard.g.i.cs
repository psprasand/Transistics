﻿#pragma checksum "..\..\..\Custom\Dashboard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EF37CEEFFC35519907C5DA56DD820C4C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Controls;
using Project_Transport;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization;
using System.Windows.Controls.DataVisualization.Charting;
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


namespace Project_Transport {
    
    
    /// <summary>
    /// Dashboard
    /// </summary>
    public partial class Dashboard : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\Custom\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Custom\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl1;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Custom\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.FlowDocument tableView;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Custom\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.FlowDocument tableView1;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Custom\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel sticky;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Custom\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox rtbox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Custom\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.Chart columnChart;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Custom\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.Chart areaChart;
        
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
            System.Uri resourceLocater = new System.Uri("/Project_Transport;component/custom/dashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Custom\Dashboard.xaml"
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
            
            #line 11 "..\..\..\Custom\Dashboard.xaml"
            ((Project_Transport.Dashboard)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbl = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lbl1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.tableView = ((System.Windows.Documents.FlowDocument)(target));
            return;
            case 5:
            this.tableView1 = ((System.Windows.Documents.FlowDocument)(target));
            return;
            case 6:
            this.sticky = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.rtbox = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 62 "..\..\..\Custom\Dashboard.xaml"
            this.rtbox.GotFocus += new System.Windows.RoutedEventHandler(this.rtbox_GotFocus);
            
            #line default
            #line hidden
            
            #line 62 "..\..\..\Custom\Dashboard.xaml"
            this.rtbox.LostFocus += new System.Windows.RoutedEventHandler(this.rtbox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.columnChart = ((System.Windows.Controls.DataVisualization.Charting.Chart)(target));
            return;
            case 9:
            this.areaChart = ((System.Windows.Controls.DataVisualization.Charting.Chart)(target));
            return;
            case 10:
            
            #line 97 "..\..\..\Custom\Dashboard.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Diesel_Payment_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 115 "..\..\..\Custom\Dashboard.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Lpg_trip_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 132 "..\..\..\Custom\Dashboard.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Load_Trailer_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 149 "..\..\..\Custom\Dashboard.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Lpg_Payment_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 162 "..\..\..\Custom\Dashboard.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Load_Payment_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 175 "..\..\..\Custom\Dashboard.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Profit_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 177 "..\..\..\Custom\Dashboard.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Poweredby_Clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

