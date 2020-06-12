using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projecte_RevealButton
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RevealButton : ContentView
    {
        public ObservableCollection<BottomItem> BottomViews
        {
            get { return (ObservableCollection<BottomItem>)GetValue(BottomViewsProperty); }
            set { SetValue(BottomViewsProperty, value); }
        }

        public static readonly BindableProperty BottomViewsProperty =
            BindableProperty.Create(nameof(BottomViews), typeof(ObservableCollection<BottomItem>), typeof(RevealButton));


        public RevealButton()
        {
            InitializeComponent();
            BottomViews = new ObservableCollection<BottomItem>();
            BottomViews.CollectionChanged += BottomViews_CollectionChanged;
        }

        private void BottomViews_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            foreach (BottomItem v in e.NewItems)
            {
                BottomCollection.ColumnDefinitions.Add(new ColumnDefinition());
                BottomCollection.Children.Add(new Frame()
                {
                    BackgroundColor = Color.FromHex("#2e249E"),
                    BorderColor = Color.DarkBlue,
                    Content = new Label()
                    {
                        Text = v.Title,
                        TextColor = Color.GhostWhite,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.Center,
                    }
                }, BottomCollection.ColumnDefinitions.Count() - 1, 0);
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await ExteriorFrame.FadeTo(0);
            ExteriorFrame.IsVisible = false;
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            ExteriorFrame.IsVisible = true;
            await ExteriorFrame.FadeTo(1);
        }
    }

    public class BottomItem : INotifyPropertyChanged
    {
        private string title { get; set; }
        public string Title
        {
            get => title;
            set
            {
                title = value; OnPropertyChanged(nameof(Title));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}