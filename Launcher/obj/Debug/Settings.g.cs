﻿#pragma checksum "..\..\Settings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12C37295520439602CF84E8A60E97430195151AC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace Launcher {
    
    
    /// <summary>
    /// Settings
    /// </summary>
    public partial class Settings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 4 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Launcher.Settings window;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox path;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button resetPath;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox autologin;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox user;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pass;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_del;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox progressType;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox speedValue;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox speedType;
        
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
            System.Uri resourceLocater = new System.Uri("/%YourName%;component/settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Settings.xaml"
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
            this.window = ((Launcher.Settings)(target));
            
            #line 5 "..\..\Settings.xaml"
            this.window.Loaded += new System.Windows.RoutedEventHandler(this.window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.path = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 36 "..\..\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.resetPath = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\Settings.xaml"
            this.resetPath.Click += new System.Windows.RoutedEventHandler(this.resetPath_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.autologin = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.user = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.pass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.btn_del = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\Settings.xaml"
            this.btn_del.Click += new System.Windows.RoutedEventHandler(this.btn_del_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.progressType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.speedValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 95 "..\..\Settings.xaml"
            this.speedValue.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.speedValue_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 11:
            this.speedType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            
            #line 106 "..\..\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

