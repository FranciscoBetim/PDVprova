// Updated by XamlIntelliSenseFileGenerator 29/07/2023 16:23:25
#pragma checksum "..\..\..\..\Views\UserControl2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E4766816A46887608540D753915F28A534666282"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using PDVprova.Views;
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


namespace PDVprova.Views
{


    /// <summary>
    /// UserControl2
    /// </summary>
    public partial class UserControl2 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 22 "..\..\..\..\Views\UserControl2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListaProdutos;

#line default
#line hidden


#line 35 "..\..\..\..\Views\UserControl2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BuscaProduto;

#line default
#line hidden


#line 38 "..\..\..\..\Views\UserControl2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox1;

#line default
#line hidden


#line 45 "..\..\..\..\Views\UserControl2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main1;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PDVprova;V1.0.0.0;component/views/usercontrol2.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\Views\UserControl2.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.PaginaPDV = ((PDVprova.Views.UserControl2)(target));

#line 8 "..\..\..\..\Views\UserControl2.xaml"
                    this.PaginaPDV.KeyDown += new System.Windows.Input.KeyEventHandler(this.BotaoPressionado);

#line default
#line hidden
                    return;
                case 2:

#line 21 "..\..\..\..\Views\UserControl2.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.ListaProdutos = ((System.Windows.Controls.ListView)(target));
                    return;
                case 4:
                    this.BuscaProduto = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:

#line 36 "..\..\..\..\Views\UserControl2.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.TextBox1 = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.Main1 = ((System.Windows.Controls.Frame)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.UserControl PaginaPDV;
    }
}

