﻿#pragma checksum "C:\DoWapp\Jobs\252036.mzekrd\src\WP8App\View\Main_News.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2E9BDC95317B5BF0B46F1B65B1A77709"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using MyToolkit.Paging;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using WPAppStudio.Controls;


namespace WPAppStudio.View {
    
    
    public partial class Main_News : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal MyToolkit.Paging.BindableApplicationBarIconButton PanoramaMain_News0RefreshBtn;
        
        internal MyToolkit.Paging.BindableApplicationBarIconButton PanoramaMain_News0SetLockScreenBtn;
        
        internal MyToolkit.Paging.BindableApplicationBarMenuItem PanoramaMain_News0AboutBtn;
        
        internal MyToolkit.Paging.BindableApplicationBarIconButton PanoramaMain_News1RefreshBtn;
        
        internal MyToolkit.Paging.BindableApplicationBarIconButton PanoramaMain_News2RefreshBtn;
        
        internal MyToolkit.Paging.BindableApplicationBarIconButton PanoramaMain_News3RefreshBtn;
        
        internal MyToolkit.Paging.BindableApplicationBarIconButton PanoramaMain_News4RefreshBtn;
        
        internal MyToolkit.Paging.BindableApplicationBarIconButton PanoramaMain_News5RefreshBtn;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Panorama PanoramaMain_News;
        
        internal Microsoft.Phone.Controls.PanoramaItem PanoramaMain_News0;
        
        internal WPAppStudio.Controls.LongListSelector Main_NewsListControl;
        
        internal Microsoft.Phone.Controls.PanoramaItem PanoramaMain_News1;
        
        internal WPAppStudio.Controls.LongListSelector NewsFeed_NewsListControl;
        
        internal Microsoft.Phone.Controls.PanoramaItem PanoramaMain_News2;
        
        internal WPAppStudio.Controls.LongListSelector ReviewsFeed_NewsListControl;
        
        internal Microsoft.Phone.Controls.PanoramaItem PanoramaMain_News3;
        
        internal WPAppStudio.Controls.LongListSelector GiveawaysFeed_NewsListControl;
        
        internal Microsoft.Phone.Controls.PanoramaItem PanoramaMain_News4;
        
        internal WPAppStudio.Controls.LongListSelector EditorialFeed_NewsListControl;
        
        internal Microsoft.Phone.Controls.PanoramaItem PanoramaMain_News5;
        
        internal WPAppStudio.Controls.LongListSelector Videos_videosListControl;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WPAppStudio;component/View/Main_News.xaml", System.UriKind.Relative));
            this.PanoramaMain_News0RefreshBtn = ((MyToolkit.Paging.BindableApplicationBarIconButton)(this.FindName("PanoramaMain_News0RefreshBtn")));
            this.PanoramaMain_News0SetLockScreenBtn = ((MyToolkit.Paging.BindableApplicationBarIconButton)(this.FindName("PanoramaMain_News0SetLockScreenBtn")));
            this.PanoramaMain_News0AboutBtn = ((MyToolkit.Paging.BindableApplicationBarMenuItem)(this.FindName("PanoramaMain_News0AboutBtn")));
            this.PanoramaMain_News1RefreshBtn = ((MyToolkit.Paging.BindableApplicationBarIconButton)(this.FindName("PanoramaMain_News1RefreshBtn")));
            this.PanoramaMain_News2RefreshBtn = ((MyToolkit.Paging.BindableApplicationBarIconButton)(this.FindName("PanoramaMain_News2RefreshBtn")));
            this.PanoramaMain_News3RefreshBtn = ((MyToolkit.Paging.BindableApplicationBarIconButton)(this.FindName("PanoramaMain_News3RefreshBtn")));
            this.PanoramaMain_News4RefreshBtn = ((MyToolkit.Paging.BindableApplicationBarIconButton)(this.FindName("PanoramaMain_News4RefreshBtn")));
            this.PanoramaMain_News5RefreshBtn = ((MyToolkit.Paging.BindableApplicationBarIconButton)(this.FindName("PanoramaMain_News5RefreshBtn")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PanoramaMain_News = ((Microsoft.Phone.Controls.Panorama)(this.FindName("PanoramaMain_News")));
            this.PanoramaMain_News0 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("PanoramaMain_News0")));
            this.Main_NewsListControl = ((WPAppStudio.Controls.LongListSelector)(this.FindName("Main_NewsListControl")));
            this.PanoramaMain_News1 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("PanoramaMain_News1")));
            this.NewsFeed_NewsListControl = ((WPAppStudio.Controls.LongListSelector)(this.FindName("NewsFeed_NewsListControl")));
            this.PanoramaMain_News2 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("PanoramaMain_News2")));
            this.ReviewsFeed_NewsListControl = ((WPAppStudio.Controls.LongListSelector)(this.FindName("ReviewsFeed_NewsListControl")));
            this.PanoramaMain_News3 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("PanoramaMain_News3")));
            this.GiveawaysFeed_NewsListControl = ((WPAppStudio.Controls.LongListSelector)(this.FindName("GiveawaysFeed_NewsListControl")));
            this.PanoramaMain_News4 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("PanoramaMain_News4")));
            this.EditorialFeed_NewsListControl = ((WPAppStudio.Controls.LongListSelector)(this.FindName("EditorialFeed_NewsListControl")));
            this.PanoramaMain_News5 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("PanoramaMain_News5")));
            this.Videos_videosListControl = ((WPAppStudio.Controls.LongListSelector)(this.FindName("Videos_videosListControl")));
        }
    }
}

