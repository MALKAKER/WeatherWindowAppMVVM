﻿#pragma checksum "..\..\WeatherAppControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F52A84B02E57F9833D6471F17164DA51520CCE0E"
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
using Weather_;
using Weather_.ViewUserControls;


namespace Weather_ {
    
    
    /// <summary>
    /// WeatherAppControl
    /// </summary>
    public partial class WeatherAppControl : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\WeatherAppControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Weather_.ViewUserControls.ChartUserControl ChartUserControl;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\WeatherAppControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Weather_.ViewUserControls.SearchBannerUserControl SearchBannerUserControl;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\WeatherAppControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Weather_.ViewUserControls.TableUserControl TableUserControl;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\WeatherAppControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Weather_.ViewUserControls.MapUserControl MapUserControl;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\WeatherAppControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Weather_.ViewUserControls.DayWeatherUserControl DayWeatherUserControl;
        
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
            System.Uri resourceLocater = new System.Uri("/Weather_;component/weatherappcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WeatherAppControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.ChartUserControl = ((Weather_.ViewUserControls.ChartUserControl)(target));
            return;
            case 2:
            this.SearchBannerUserControl = ((Weather_.ViewUserControls.SearchBannerUserControl)(target));
            return;
            case 3:
            this.TableUserControl = ((Weather_.ViewUserControls.TableUserControl)(target));
            return;
            case 4:
            this.MapUserControl = ((Weather_.ViewUserControls.MapUserControl)(target));
            return;
            case 5:
            this.DayWeatherUserControl = ((Weather_.ViewUserControls.DayWeatherUserControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

