﻿#pragma checksum "..\..\frmEscolhaComp.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8ADE697E20CE335CCF42752B66FFB7E866795DFA361F4FD755C8A4A43979B84B"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Xpf.DXBinding;
using EconomicWPF;
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


namespace EconomicWPF {
    
    
    /// <summary>
    /// frmEscolhaComp
    /// </summary>
    public partial class frmEscolhaComp : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\frmEscolhaComp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSair;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\frmEscolhaComp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMensais;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\frmEscolhaComp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnuais;
        
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
            System.Uri resourceLocater = new System.Uri("/EconomicWPFDESKTOP;component/frmescolhacomp.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\frmEscolhaComp.xaml"
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
            this.btnSair = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\frmEscolhaComp.xaml"
            this.btnSair.Click += new System.Windows.RoutedEventHandler(this.btnSair_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnMensais = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\frmEscolhaComp.xaml"
            this.btnMensais.Click += new System.Windows.RoutedEventHandler(this.btnMensais_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnAnuais = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\frmEscolhaComp.xaml"
            this.btnAnuais.Click += new System.Windows.RoutedEventHandler(this.btnAnuais_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

