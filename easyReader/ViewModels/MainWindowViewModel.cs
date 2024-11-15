using easyReader.Services;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace easyReader.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly FeedService feedService;

        public ICommand AddNewFeedCommand { get; }

        private bool _isNewFeedError = false;
        public bool IsNewFeedError
        {
            get => _isAddFeedOpen;
            set => this.RaiseAndSetIfChanged(ref _isNewFeedError, value);
        }

        private string _newFeedError = string.Empty;
        public string NewFeedError
        {
            get => _newFeedError;
            set => this.RaiseAndSetIfChanged(ref _newFeedError, value);
        }

        private bool _isAddFeedOpen = false;
        public bool IsAddFeedOpen
        {
            get => _isAddFeedOpen;
            set => this.RaiseAndSetIfChanged(ref _isAddFeedOpen, value);
        }

        private string _newFeedUrl = string.Empty;

        public string NewFeedUrl
        {
            get => _newFeedUrl;
            set => this.RaiseAndSetIfChanged(ref _newFeedUrl, value);
        }

        public ObservableCollection<FeedViewModel> Feeds { get; }

        public MainWindowViewModel(FeedService feedService)
        {
            AddNewFeedCommand = ReactiveCommand.Create(AddNewFeedHandler);

            Feeds = new ObservableCollection<FeedViewModel>
            {
                new FeedViewModel
                {
                    Title = "The Dollop",
                    Description = "Comedians Dave Anthony and Gareth Reynolds picks a subject from history and examine it"
                },
                new FeedViewModel
                {
                    Title = "No Such Thing as a Fish"
                },
                new FeedViewModel
                {
                    Title = "We're Here to Help"
                },
                new FeedViewModel
                {
                    Title = "Buried Bones"
                },
            };
            this.feedService = feedService;
        }

        private async void AddNewFeedHandler()
        {
            IsNewFeedError = false;
            NewFeedError = string.Empty;

            var feedUrl = NewFeedUrl;

            if(!feedService.CheckValidURL(feedUrl))
            {
                IsNewFeedError = true;
                NewFeedError = "Invalid URL";
                return;
            }

            if (!await feedService.CanReachURL(feedUrl))
            {
                IsNewFeedError = true;
                NewFeedError = "Cannot reach URL";
                return;
            }

            if(!await feedService.TryAddFeed(feedUrl))
            {
                IsNewFeedError = true;
                NewFeedError = "Failed to add feed";
                return;
            }

            //await UpdateFeedList();
        }

        private async Task UpdateFeedList()
        {
            
        }
    }
}
