﻿#pragma checksum "..\..\..\vehicle\Profit_Viewer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6B08DC9769A6FAC9A5A9BC7B8D186B32"
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


namespace Project_Transport {
    
    
    /// <summary>
    /// Profit_Viewer
    /// </summary>
    public partial class Profit_Viewer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\vehicle\Profit_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Month_chkbox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\vehicle\Profit_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Year_chkbox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\vehicle\Profit_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox vehicle_cmbbox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\vehicle\Profit_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox month_cmbbox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\vehicle\Profit_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox year_cmbbox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\vehicle\Profit_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Reporting.WinForms.ReportViewer ReportView;
        
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
            System.Uri resourceLocater = new System.Uri("/Project_Transport;component/vehicle/profit_viewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\vehicle\Profit_Viewer.xaml"
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
            this.Month_chkbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 12 "..\..\..\vehicle\Profit_Viewer.xaml"
            this.Month_chkbox.Checked += new System.Windows.RoutedEventHandler(this.Profit_Viewer_Month_Checked);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\vehicle\Profit_Viewer.xaml"
            this.Month_chkbox.Unchecked += new System.Windows.RoutedEventHandler(this.Profit_Viewer_Month_Unchecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Year_chkbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 13 "..\..\..\vehicle\Profit_Viewer.xaml"
            this.Year_chkbox.Checked += new System.Windows.RoutedEventHandler(this.Profit_Viewer_Year_Checked);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\vehicle\Profit_Viewer.xaml"
            this.Year_chkbox.Unchecked += new System.Windows.RoutedEventHandler(this.Profit_Viewer_Year_Unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.vehicle_cmbbox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\vehicle\Profit_Viewer.xaml"
            this.vehicle_cmbbox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Profit_View_Vehicle_Number_PreviewKeydown);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\vehicle\Profit_Viewer.xaml"
            this.vehicle_cmbbox.GotFocus += new System.Windows.RoutedEventHandler(this.vehicle_cmbbox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.month_cmbbox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\vehicle\Profit_Viewer.xaml"
            this.month_cmbbox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Profit_View_Month_PreviewKeydown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.year_cmbbox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 47 "..\..\..\vehicle\Profit_Viewer.xaml"
            this.year_cmbbox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Profit_View_Year_PreviewKeydown);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 56 "..\..\..\vehicle\Profit_Viewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ReportView = ((Microsoft.Reporting.WinForms.ReportViewer)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
