﻿#pragma checksum "..\..\KinectDiagnosticViewer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FED3F19B1F22FAA7E0DD4FC1B9059950"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Samples.Kinect.WpfViewers;
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


namespace Microsoft.Samples.Kinect.WpfViewers {
    
    
    /// <summary>
    /// KinectDiagnosticViewer
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class KinectDiagnosticViewer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        /// <summary>
        /// kinectColorViewer Name Field
        /// </summary>
        
        #line 12 "..\..\KinectDiagnosticViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public Microsoft.Samples.Kinect.WpfViewers.KinectColorViewer kinectColorViewer;
        
        #line default
        #line hidden
        
        /// <summary>
        /// kinectDepthViewer Name Field
        /// </summary>
        
        #line 17 "..\..\KinectDiagnosticViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public Microsoft.Samples.Kinect.WpfViewers.KinectDepthViewer kinectDepthViewer;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\KinectDiagnosticViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel skeletonPanel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\KinectDiagnosticViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas skeletonCanvas;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\KinectDiagnosticViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock frameRate;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\KinectDiagnosticViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock kinectIndex;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\KinectDiagnosticViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox kinectName;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\KinectDiagnosticViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock kinectStatus;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Microsoft.Samples.Kinect.WpfViewers;component/kinectdiagnosticviewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\KinectDiagnosticViewer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.kinectColorViewer = ((Microsoft.Samples.Kinect.WpfViewers.KinectColorViewer)(target));
            return;
            case 2:
            this.kinectDepthViewer = ((Microsoft.Samples.Kinect.WpfViewers.KinectDepthViewer)(target));
            return;
            case 3:
            this.skeletonPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.skeletonCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 5:
            this.frameRate = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.kinectIndex = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.kinectName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.kinectStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

