﻿#pragma checksum "..\..\..\..\GUI\PageAuthentification.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8CF7C17871C99325DBFD6FEFFAF2E6A8F07B7996"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using CashcashApp;
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


namespace CashcashApp {
    
    
    /// <summary>
    /// PageAuthentification
    /// </summary>
    public partial class PageAuthentification : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\GUI\PageAuthentification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbTitre;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\GUI\PageAuthentification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbBdd;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\GUI\PageAuthentification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbUtilisateur;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\GUI\PageAuthentification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMdp;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\GUI\PageAuthentification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConnexion;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\GUI\PageAuthentification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuitter;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\GUI\PageAuthentification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border connMessage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CashcashApp;component/gui/pageauthentification.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\GUI\PageAuthentification.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tbTitre = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.cbBdd = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\..\GUI\PageAuthentification.xaml"
            this.cbBdd.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbBdd_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbUtilisateur = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbMdp = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnConnexion = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\GUI\PageAuthentification.xaml"
            this.btnConnexion.Click += new System.Windows.RoutedEventHandler(this.btnConnexion_ClickAsync);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnQuitter = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\GUI\PageAuthentification.xaml"
            this.btnQuitter.Click += new System.Windows.RoutedEventHandler(this.btnQuitter_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.connMessage = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
