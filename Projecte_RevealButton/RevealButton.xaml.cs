using System;
using System.Collections.ObjectModel;
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
                BottomCollection.Children.Add(v, BottomCollection.ColumnDefinitions.Count() - 1, 0);
            }
        }

        private async void ExteriorFrame_Tapped(object sender, EventArgs e)
        {
            await ExteriorFrame.FadeTo(0);
            ExteriorFrame.IsVisible = false;
        }

        private async void BackTitleStack_Tapped(object sender, EventArgs e)
        {
            ExteriorFrame.IsVisible = true;
            await ExteriorFrame.FadeTo(1);
        }
    }

    public class BottomItem : ContentView
    {

    }
}