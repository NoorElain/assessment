﻿#pragma checksum "..\..\Sign Up.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E35D96C47FABF344B5FFE1C5D8F131502257108E77310D8CF2FD6CA9F4E3AA2C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NoorElain_0522069_Day1;
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


namespace NoorElain_0522069_Day1 {
    
    
    /// <summary>
    /// Sign_Up
    /// </summary>
    public partial class Sign_Up : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\Sign Up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox User_T;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Sign Up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pass_T;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Sign Up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Age_T;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Sign Up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioFem;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Sign Up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phone_T;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\Sign Up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\Sign Up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo_gender;
        
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
            System.Uri resourceLocater = new System.Uri("/NoorElain 0522069 Day1;component/sign%20up.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Sign Up.xaml"
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
            this.User_T = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.pass_T = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.Age_T = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 42 "..\..\Sign Up.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.Radiomal_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 43 "..\..\Sign Up.xaml"
            ((System.Windows.Controls.RichTextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RichTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.radioFem = ((System.Windows.Controls.RadioButton)(target));
            
            #line 51 "..\..\Sign Up.xaml"
            this.radioFem.Checked += new System.Windows.RoutedEventHandler(this.RadioFemale_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 52 "..\..\Sign Up.xaml"
            ((System.Windows.Controls.RichTextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RichTextBox_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.phone_T = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.combo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 63 "..\..\Sign Up.xaml"
            this.combo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 71 "..\..\Sign Up.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SignUp_Button);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 78 "..\..\Sign Up.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SignIn_Button);
            
            #line default
            #line hidden
            return;
            case 12:
            this.combo_gender = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

