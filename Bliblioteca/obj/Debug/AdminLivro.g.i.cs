﻿#pragma checksum "..\..\AdminLivro.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7DC949950FB9BE82E41E97B866C3ADFD24F2452A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Biblioteca;
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


namespace Biblioteca {
    
    
    /// <summary>
    /// AdminLivro
    /// </summary>
    public partial class AdminLivro : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\AdminLivro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tittle;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AdminLivro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxPesquisarLivros;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AdminLivro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVoltarAdmin;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AdminLivro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxLivros;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\AdminLivro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdicionarLivro;
        
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
            System.Uri resourceLocater = new System.Uri("/Biblioteca;component/adminlivro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminLivro.xaml"
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
            this.Tittle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.textBoxPesquisarLivros = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 36 "..\..\AdminLivro.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnVoltarAdmin = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\AdminLivro.xaml"
            this.btnVoltarAdmin.Click += new System.Windows.RoutedEventHandler(this.BtnVoltarAdmin_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.listBoxLivros = ((System.Windows.Controls.ListBox)(target));
            
            #line 42 "..\..\AdminLivro.xaml"
            this.listBoxLivros.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBoxLivros_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAdicionarLivro = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\AdminLivro.xaml"
            this.btnAdicionarLivro.Click += new System.Windows.RoutedEventHandler(this.BtnAdicionarLivro_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

