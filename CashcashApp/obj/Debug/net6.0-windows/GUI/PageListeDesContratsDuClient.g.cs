﻿#pragma checksum "..\..\..\..\GUI\PageListeDesContratsDuClient.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A838C689D90A5F62BA8F43C3C9CEB8131495D52B"
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
    /// PageListeDesContratsDuClient
    /// </summary>
    public partial class PageListeDesContratsDuClient : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\GUI\PageListeDesContratsDuClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbTitre;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\GUI\PageListeDesContratsDuClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRafraichir;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\GUI\PageListeDesContratsDuClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgContrats;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\GUI\PageListeDesContratsDuClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNouveau;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\GUI\PageListeDesContratsDuClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgMateriels;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\GUI\PageListeDesContratsDuClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAffecter;
        
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
            System.Uri resourceLocater = new System.Uri("/CashcashApp;component/gui/pagelistedescontratsduclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\GUI\PageListeDesContratsDuClient.xaml"
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
            
            #line 10 "..\..\..\..\GUI\PageListeDesContratsDuClient.xaml"
            ((CashcashApp.PageListeDesContratsDuClient)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbTitre = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btnRafraichir = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\GUI\PageListeDesContratsDuClient.xaml"
            this.btnRafraichir.Click += new System.Windows.RoutedEventHandler(this.btnRafraichir_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgContrats = ((System.Windows.Controls.DataGrid)(target));
            
            #line 26 "..\..\..\..\GUI\PageListeDesContratsDuClient.xaml"
            this.dgContrats.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgContrats_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnNouveau = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\GUI\PageListeDesContratsDuClient.xaml"
            this.btnNouveau.Click += new System.Windows.RoutedEventHandler(this.btnNouveau_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgMateriels = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.btnAffecter = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\GUI\PageListeDesContratsDuClient.xaml"
            this.btnAffecter.Click += new System.Windows.RoutedEventHandler(this.btnAffecter_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
