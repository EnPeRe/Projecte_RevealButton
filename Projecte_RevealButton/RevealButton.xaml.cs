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
            BindableProperty.Create(nameof(BottomViews), typeof(ObservableCollection<BottomItem>), typeof(RevealButton),
                propertyChanged: OnBottomsViewsPropertyChanged);

        private static void OnBottomsViewsPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is ObservableCollection<BottomItem> bottomCollection)
            {
                control.BottomCollection.ItemsSource = bottomCollection;
                if(bottomCollection.Any())
                    control.BottomCollection.ItemsLayout = new GridItemsLayout(bottomCollection.Count(), ItemsLayoutOrientation.Horizontal);
            }
        }

        public RevealButton()
        {
            InitializeComponent();
            BottomViews = new ObservableCollection<BottomItem>();
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