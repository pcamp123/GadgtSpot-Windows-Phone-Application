// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   UnityContainer.tt
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using IIoc=WPAppStudio.Ioc.Interfaces;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Microsoft.Practices.Unity;
using Repositories=WPAppStudio.Repositories;
using RepositoriesBase=WPAppStudio.Repositories.Base;
using Services=WPAppStudio.Services;
using ViewModels=WPAppStudio.ViewModel;

namespace WPAppStudio.Ioc
{
    //
    // Unity 2.1
    // http://msdn.microsoft.com/en-us/library/hh237493.aspx
    //
    // patterns & practices - Unity
    // http://unity.codeplex.com/
    //
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public class Container : IIoc.IContainer
    {
        private readonly IUnityContainer _currentContainer;

        public Container()
        {
            _currentContainer = new UnityContainer();

            _currentContainer.RegisterType<IServices.ILiveTileService, Services.LiveTileService>();
			_currentContainer.RegisterType<IServices.ILockScreenService, Services.LockScreenService>();
			_currentContainer.RegisterType<IServices.IProximityService, Services.ProximityService>();
            _currentContainer.RegisterType<IServices.IDialogService, Services.DialogService>();
            _currentContainer.RegisterType<IServices.IShareService, Services.ShareService>();
			
            _currentContainer.RegisterType<IServices.ISpeechService, Services.SpeechService>();
            _currentContainer.RegisterType<IServices.INavigationService, Services.NavigationService>();
			
		
		    _currentContainer.RegisterType<IServices.IStorageService, Services.StorageService>();
			_currentContainer.RegisterType<IServices.IInternetService, Services.InternetService>(new ContainerControlledLifetimeManager());
			_currentContainer.RegisterType<RepositoriesBase.IXmlDataSource, RepositoriesBase.XmlDataSource>();
			_currentContainer.RegisterType<RepositoriesBase.IYoutubeDataSource, RepositoriesBase.YoutubeDataSource>();
            _currentContainer.RegisterType<IViewModels.IMain_NewsViewModel, ViewModels.Main_NewsViewModel>();
            _currentContainer.RegisterType<IViewModels.IVideos_DetailVideosViewModel, ViewModels.Videos_DetailVideosViewModel>();
            _currentContainer.RegisterType<IViewModels.IEditorialFeed_DetailViewModel, ViewModels.EditorialFeed_DetailViewModel>();
            _currentContainer.RegisterType<IViewModels.IGiveawaysFeed_DetailViewModel, ViewModels.GiveawaysFeed_DetailViewModel>();
            _currentContainer.RegisterType<IViewModels.IReviewsFeed_DetailViewModel, ViewModels.ReviewsFeed_DetailViewModel>();
            _currentContainer.RegisterType<IViewModels.INewsFeed_DetailViewModel, ViewModels.NewsFeed_DetailViewModel>();
            _currentContainer.RegisterType<IViewModels.IMain_DetailViewModel, ViewModels.Main_DetailViewModel>();

			_currentContainer.RegisterType<IViewModels.IAboutViewModel, ViewModels.AboutViewModel>(new ContainerControlledLifetimeManager());
			_currentContainer.RegisterType<IViewModels.ILicenseViewModel, ViewModels.LicenseViewModel>(new ContainerControlledLifetimeManager());
			
			if (!System.ComponentModel.DesignerProperties.IsInDesignTool)
            {
				_currentContainer.RegisterType<Repositories.IMain_mainrssfeed, Repositories.Main_mainrssfeed>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Repositories.INewsFeed_NewsFeed, Repositories.NewsFeed_NewsFeed>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Repositories.IReviewsFeed_ReviewsFeed, Repositories.ReviewsFeed_ReviewsFeed>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Repositories.IGiveawaysFeed_GiveawaysFeed, Repositories.GiveawaysFeed_GiveawaysFeed>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Repositories.IEditorialFeed_EditorialFeed, Repositories.EditorialFeed_EditorialFeed>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Repositories.IVideos_Videos, Repositories.Videos_Videos>(new ContainerControlledLifetimeManager());
			}
			else
			{
				_currentContainer.RegisterType<Repositories.IMain_mainrssfeed, Repositories.FakeMain_mainrssfeed>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Repositories.INewsFeed_NewsFeed, Repositories.FakeNewsFeed_NewsFeed>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Repositories.IReviewsFeed_ReviewsFeed, Repositories.FakeReviewsFeed_ReviewsFeed>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Repositories.IGiveawaysFeed_GiveawaysFeed, Repositories.FakeGiveawaysFeed_GiveawaysFeed>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Repositories.IEditorialFeed_EditorialFeed, Repositories.FakeEditorialFeed_EditorialFeed>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Repositories.IVideos_Videos, Repositories.FakeVideos_Videos>(new ContainerControlledLifetimeManager());
			
			}
        }

        public T Resolve<T>()
        {
            return _currentContainer.Resolve<T>();
        }
    }
}
