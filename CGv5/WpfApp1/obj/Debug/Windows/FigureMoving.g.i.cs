﻿#pragma checksum "..\..\..\Windows\FigureMoving.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "51D6844E520982ECAEED016C06151E0AC19000D379F83BFDE3E06B0DD316B320"
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// FigureMoving
    /// </summary>
    public partial class FigureMoving : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 82 "..\..\..\Windows\FigureMoving.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox X1TextBox;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Windows\FigureMoving.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Y1TextBox;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Windows\FigureMoving.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox X2TextBox;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Windows\FigureMoving.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Y2TextBox;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Windows\FigureMoving.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RotateStepTextBox;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Windows\FigureMoving.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VerticalMovingStepTextBox;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Windows\FigureMoving.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TimeStepTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/windows/figuremoving.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\FigureMoving.xaml"
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
            this.X1TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Y1TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.X2TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Y2TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.RotateStepTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.VerticalMovingStepTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TimeStepTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 108 "..\..\..\Windows\FigureMoving.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

