﻿#pragma checksum "C:\Users\Wulff\source\repos\Kommandobogen\KommandoBogApp\View\HubTest.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A3E064E95409F63A05D2931D4DAD55DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KommandoBogApp.View
{
    partial class HubTest : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.OverskriftBar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.MenuBar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.NavigationBar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.NavigationBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.BrugerNavn = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.HjemKnap = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 7:
                {
                    this.Arbejdstid = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 8:
                {
                    this.Overblik = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 9:
                {
                    this.Hjælp = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 10:
                {
                    this.Leder = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.Merarbejde = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 12:
                {
                    this.Statistik = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 13:
                {
                    this.Admin = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.Opret_bruger = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 113 "..\..\..\View\HubTest.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Opret_bruger).Click += this.NavigateToPageOpretBruger;
                    #line default
                }
                break;
            case 15:
                {
                    this.Rediger_bruger = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 16:
                {
                    this.Logout = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 17:
                {
                    this.MAFraloginTest = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.NavnFraLoginTest = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19:
                {
                    global::Windows.UI.Xaml.Controls.Button element19 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 21 "..\..\..\View\HubTest.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element19).Click += this.MonthMinusOne;
                    #line default
                }
                break;
            case 20:
                {
                    global::Windows.UI.Xaml.Controls.Button element20 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\View\HubTest.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element20).Click += this.iOneUp;
                    #line default
                }
                break;
            case 21:
                {
                    this.MonthShownTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 25 "..\..\..\View\HubTest.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.MonthShownTextBox).TextChanged += this.MonthShownTextBox_OnTextChanged;
                    #line default
                }
                break;
            case 22:
                {
                    this.YearShownTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 26 "..\..\..\View\HubTest.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.YearShownTextBox).TextChanged += this.YearShownTextBox_OnTextChanged;
                    #line default
                }
                break;
            case 23:
                {
                    this.MonthYearError = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 24:
                {
                    global::Windows.UI.Xaml.Controls.Button element24 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 28 "..\..\..\View\HubTest.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element24).Click += this.MonthPlusOne;
                    #line default
                }
                break;
            case 25:
                {
                    this.Users = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 26:
                {
                    this.Days = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 27:
                {
                    this.Activities = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

