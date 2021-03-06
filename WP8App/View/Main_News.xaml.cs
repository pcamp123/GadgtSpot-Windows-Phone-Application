// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   PageCS.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Entities=WPAppStudio.Entities;
using Ioc=WPAppStudio.Ioc;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MyToolkit.Paging;
using Repositories=WPAppStudio.Repositories;
using WPAppStudio;

namespace WPAppStudio.View
{
    /// <summary>
    /// Phone application page for Main_News.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class Main_News : PhoneApplicationPage
    {       
        /// <summary>
        /// Initializes the phone application page for Main_News and all its components.
        /// </summary>
        public Main_News()
        {
            InitializeComponent();        
			if (Resources.Contains("PanoramaMain_News0AppBar"))
				PhonePage.SetApplicationBar(this, Resources["PanoramaMain_News0AppBar"] as BindableApplicationBar);                            
		}
		
        private void panoramaMain_News_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {		
			InitializeAppBarpanoramaMain_News(PanoramaMain_News.SelectedItem as PanoramaItem);
        }
		
		private void InitializeAppBarpanoramaMain_News(PanoramaItem panoramaItem)        
        {
			if (Resources.Contains(panoramaItem.Name + "AppBar"))
			{
				PhonePage.SetApplicationBar(this, Resources[panoramaItem.Name + "AppBar"] as BindableApplicationBar);            
				ApplicationBar.IsVisible = true;
            }
		    else if(ApplicationBar != null)
		        ApplicationBar.IsVisible = false;
        }
 
        /// <summary>
        /// Called when the page becomes the active page.
        /// </summary>
        /// <param name="e">Contains information about the navigation done.</param>
        protected override  void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
		
            Main_NewsListControl.SelectedItem = null;
		
            NewsFeed_NewsListControl.SelectedItem = null;
		
            ReviewsFeed_NewsListControl.SelectedItem = null;
		
            GiveawaysFeed_NewsListControl.SelectedItem = null;
		
            EditorialFeed_NewsListControl.SelectedItem = null;
		
            Videos_videosListControl.SelectedItem = null;
		}
    }
}
