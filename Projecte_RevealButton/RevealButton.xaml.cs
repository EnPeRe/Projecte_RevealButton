using Projecte_RevealButton.Projecte_InnerShadowLayout;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projecte_RevealButton
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RevealButton : ContentView
    {
        #region .: Properties :.

        #region Collections

        public ObservableCollection<BottomItem> BottomViews
        {
            get { return (ObservableCollection<BottomItem>)GetValue(BottomViewsProperty); }
            set { SetValue(BottomViewsProperty, value); }
        }

        #endregion

        #region Back

        public double BackFontSize
        {
            get { return (double)GetValue(BackFontSizeProperty); }
            set { SetValue(BackFontSizeProperty, value); }
        }

        public Thickness BackMargin
        {
            get { return (Thickness)GetValue(BackMarginProperty); }
            set { SetValue(BackMarginProperty, value); }
        }

        public string BackText
        {
            get { return (string)GetValue(BackTextProperty); }
            set { SetValue(BackTextProperty, value); }
        }

        public Color BackTextColor
        {
            get { return (Color)GetValue(BackTextColorProperty); }
            set { SetValue(BackTextColorProperty, value); }
        }

        #endregion

        public float CornerRadius
        {
            get { return (float)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        #region Exterior

        public Color ExteriorBackGroundColor
        {
            get { return (Color)GetValue(ExteriorBackGroundColorProperty); }
            set { SetValue(ExteriorBackGroundColorProperty, value); }
        }

        public double ExteriorFontSize
        {
            get { return (double)GetValue(ExteriorFontSizeProperty); }
            set { SetValue(ExteriorFontSizeProperty, value); }
        }

        public Thickness ExteriorMargin
        {
            get { return (Thickness)GetValue(ExteriorMarginProperty); }
            set { SetValue(ExteriorMarginProperty, value); }
        }

        public string ExteriorText
        {
            get { return (string)GetValue(ExteriorTextProperty); }
            set { SetValue(ExteriorTextProperty, value); }
        }

        public Color ExteriorTextColor
        {
            get { return (Color)GetValue(ExteriorTextColorProperty); }
            set { SetValue(ExteriorTextColorProperty, value); }
        }


        #endregion

        #region Interior

        public Color InteriorBackGroundColor
        {
            get { return (Color)GetValue(InteriorBackGroundColorProperty); }
            set { SetValue(InteriorBackGroundColorProperty, value); }
        }

        public float InteriorCornerRadius
        {
            get { return (float)GetValue(InteriorCornerRadiusProperty); }
            set { SetValue(InteriorCornerRadiusProperty, value); }
        }

        public Thickness InteriorPadding
        {
            get { return (Thickness)GetValue(InteriorPaddingProperty); }
            set { SetValue(InteriorPaddingProperty, value); }
        }

        #endregion

        #region Button

        public Color ButtonBackgroundColor
        {
            get { return (Color)GetValue(ButtonBackgroundColorProperty); }
            set { SetValue(ButtonBackgroundColorProperty, value); }
        }

        public ICommand ButtonCommand
        {
            get { return (ICommand)GetValue(ButtonCommandProperty); }
            set { SetValue(ButtonCommandProperty, value); }
        }

        public object ButtonCommandParameter
        {
            get { return (object)GetValue(ButtonCommandParameterProperty); }
            set { SetValue(ButtonCommandParameterProperty, value); }
        }

        public Color ButtonPressedColor
        {
            get { return (Color)GetValue(ButtonPressedColorProperty); }
            set { SetValue(ButtonPressedColorProperty, value); }
        }

        public float ButtonShadowSize
        {
            get { return (float)GetValue(ButtonShadowSizeProperty); }
            set { SetValue(ButtonShadowSizeProperty, value); }
        }

        public float ButtonShadowMargin
        {
            get { return (float)GetValue(ButtonShadowMarginProperty); }
            set { SetValue(ButtonShadowMarginProperty, value); }
        }

        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        public double ButtonFontSize
        {
            get { return (double)GetValue(ButtonFontSizeProperty); }
            set { SetValue(ButtonFontSizeProperty, value); }
        }

        public Color ButtonTextColor
        {
            get { return (Color)GetValue(ButtonTextColorProperty); }
            set { SetValue(ButtonTextColorProperty, value); }
        }

        #endregion

        #region .: BindableProperties :.

        #region Collections

        public static readonly BindableProperty BottomViewsProperty =
            BindableProperty.Create(nameof(BottomViews), typeof(ObservableCollection<BottomItem>), typeof(RevealButton));

        #endregion

        #region Back

        public static readonly BindableProperty BackFontSizeProperty =
            BindableProperty.Create(nameof(BackFontSize), typeof(double), typeof(RevealButton), 0.0,
                propertyChanged: OnBackFontSizePropertyChanged);

        public static readonly BindableProperty BackMarginProperty =
            BindableProperty.Create(nameof(BackMargin), typeof(Thickness), typeof(RevealButton), new Thickness(0, 0, 0, 0),
                propertyChanged: OnBackMarginPropertyChanged);

        public static readonly BindableProperty BackTextProperty =
            BindableProperty.Create(nameof(BackText), typeof(string), typeof(RevealButton), string.Empty,
                propertyChanged: OnBackTextPropertyChanged);

        public static readonly BindableProperty BackTextColorProperty =
            BindableProperty.Create(nameof(BackTextColor), typeof(Color), typeof(RevealButton), null,
                propertyChanged: OnBackTextColorPropertyChanged);

        #endregion

        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create(nameof(CornerRadius), typeof(float), typeof(RevealButton), 0.0f,
                propertyChanged: OnCornerRadiusPropertyChanged);

        #region Exterior

        public static readonly BindableProperty ExteriorBackGroundColorProperty =
            BindableProperty.Create(nameof(ExteriorBackGroundColor), typeof(Color), typeof(RevealButton), null,
                propertyChanged: OnExteriorBackGroundColorPropertyChanged);

        public static readonly BindableProperty ExteriorFontSizeProperty =
            BindableProperty.Create(nameof(ExteriorFontSize), typeof(double), typeof(RevealButton), 0.0,
                propertyChanged: OnExteriorFontSizePropertyChanged);

        public static readonly BindableProperty ExteriorMarginProperty =
            BindableProperty.Create(nameof(ExteriorMargin), typeof(Thickness), typeof(RevealButton), new Thickness(0, 0, 0, 0),
                propertyChanged: OnExteriorMarginPropertyChanged);

        public static readonly BindableProperty ExteriorTextProperty =
            BindableProperty.Create(nameof(ExteriorText), typeof(string), typeof(RevealButton), string.Empty,
                propertyChanged: OnExteriorTextPropertyChanged);

        public static readonly BindableProperty ExteriorTextColorProperty =
            BindableProperty.Create(nameof(ExteriorTextColor), typeof(Color), typeof(RevealButton), null,
                propertyChanged: OnExteriorTextColorPropertyChanged);

        #endregion

        #region Interior

        public static readonly BindableProperty InteriorBackGroundColorProperty =
            BindableProperty.Create(nameof(InteriorBackGroundColor), typeof(Color), typeof(RevealButton), null,
                propertyChanged: OnInteriorBackGroundColorPropertyChanged);

        public static readonly BindableProperty InteriorCornerRadiusProperty =
            BindableProperty.Create(nameof(InteriorCornerRadius), typeof(float), typeof(RevealButton), 0.0f,
                propertyChanged: OnInteriorCornerRadiusPropertyChanged);

        public static readonly BindableProperty InteriorPaddingProperty =
            BindableProperty.Create(nameof(InteriorPadding), typeof(Thickness), typeof(RevealButton), new Thickness(0, 0, 0, 0),
                propertyChanged: OnInteriorPaddingPropertyChanged);

        #endregion

        #region Button

        public static readonly BindableProperty ButtonBackgroundColorProperty =
            BindableProperty.Create(nameof(ButtonBackgroundColor), typeof(Color), typeof(RevealButton), null,
                propertyChanged: OnButtonBackgroundColorPropertyChanged);

        public static readonly BindableProperty ButtonCommandProperty =
            BindableProperty.Create(nameof(ButtonCommand), typeof(ICommand), typeof(InnerShadowLayout), null,
                propertyChanged: OnButtonCommandPropertyChanged);

        public static readonly BindableProperty ButtonCommandParameterProperty =
            BindableProperty.Create(nameof(ButtonCommandParameter), typeof(object), typeof(InnerShadowLayout), null,
                propertyChanged: OnButtonCommandParameterPropertyChanged);

        public static readonly BindableProperty ButtonPressedColorProperty =
            BindableProperty.Create(nameof(ButtonPressedColor), typeof(Color), typeof(RevealButton), null,
                propertyChanged: OnButtonPressedColorPropertyChanged);

        public static readonly BindableProperty ButtonShadowSizeProperty =
            BindableProperty.Create(nameof(ButtonShadowSize), typeof(float), typeof(RevealButton), 0.0f,
                propertyChanged: OnButtonShadowSizePropertyChanged);

        public static readonly BindableProperty ButtonShadowMarginProperty =
            BindableProperty.Create(nameof(ButtonShadowMargin), typeof(float), typeof(RevealButton), 0.0f,
                propertyChanged: OnButtonShadowMarginPropertyChanged);

        public static readonly BindableProperty ButtonTextProperty =
            BindableProperty.Create(nameof(ButtonText), typeof(string), typeof(RevealButton), string.Empty,
                propertyChanged: OnButtonTextPropertyChanged);

        public static readonly BindableProperty ButtonFontSizeProperty =
            BindableProperty.Create(nameof(ButtonFontSize), typeof(double), typeof(RevealButton), 0.0,
                propertyChanged: OnButtonFontSizePropertyChanged);

        public static readonly BindableProperty ButtonTextColorProperty =
            BindableProperty.Create(nameof(ButtonTextColor), typeof(Color), typeof(RevealButton), null,
                propertyChanged: OnButtonTextColorPropertyChanged);

        #endregion

        #endregion

        #endregion

        #region .: Constructor :.

        public RevealButton()
        {
            InitializeComponent();
            BottomViews = new ObservableCollection<BottomItem>();
            BottomViews.CollectionChanged += BottomViews_CollectionChanged;
        }

        #endregion

        #region .: Property Changed's :.

        #region Collections

        private void BottomViews_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            foreach (BottomItem v in e.NewItems)
            {
                BottomCollection.ColumnDefinitions.Add(new ColumnDefinition());
                BottomCollection.Children.Add(v, BottomCollection.ColumnDefinitions.Count() - 1, 0);
            }
            if (BottomCollection.Children.Any() && !PlusSignus.IsVisible)
            {
                PlusSignus.IsVisible = true;
                ExteriorOneButton.IsVisible = false;
            }
        }

        #endregion

        #region Back

        private static void OnBackFontSizePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is double fontSize)
            {
                control.BackLabel.FontSize = fontSize;
            }
        }

        private static void OnBackMarginPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is Thickness margin)
            {
                control.BackLayout.Margin = margin;
            }
        }

        private static void OnBackTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is string text)
            {
                control.BackLabel.Text = text;
            }
        }
        private static void OnBackTextColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is Color color)
            {
                control.BackLabel.TextColor = color;
            }
        }

        #endregion

        private static void OnCornerRadiusPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is float cornerRadius)
            {
                control.InteriorBorderFrame.CornerRadius = cornerRadius;
                control.ExteriorFrame.CornerRadius = cornerRadius;
                control.ExteriorOneButton.CornerRadius = (int)cornerRadius;
            }
        }

        #region Exterior

        private static void OnExteriorBackGroundColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is Color color)
            {
                control.ExteriorFrame.BackgroundColor = color;
                control.ExteriorFrame.BorderColor = color;
                control.ExteriorOneButton.BackgroundColor = color;
                control.ExteriorOneButton.BorderColor = color;
            }
        }

        private static void OnExteriorFontSizePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is double fontSize)
            {
                control.ExteriorTitle.FontSize = fontSize;
                control.PlusSignus.FontSize = fontSize;
                control.ExteriorOneButton.FontSize = fontSize;
            }
        }

        private static void OnExteriorMarginPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is Thickness margin)
            {
                control.PlusSignus.Margin = margin;
            }
        }

        private static void OnExteriorTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is string text)
            {
                control.ExteriorTitle.Text = text.ToUpper();
                control.ExteriorOneButton.Text = text.ToUpper();
            }
        }
        private static void OnExteriorTextColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is Color color)
            {
                control.ExteriorTitle.TextColor = color;
                control.PlusSignus.TextColor = color;
                control.ExteriorOneButton.TextColor = color;
            }
        }


        #endregion

        #region Interior

        private static void OnInteriorBackGroundColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is Color color)
            {
                control.InteriorBorderFrame.BackgroundColor = color;
                control.InteriorBorderFrame.BorderColor = color;
                control.InteriorGrid.BackgroundColor = color;
            }
        }

        private static void OnInteriorCornerRadiusPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is float cornerRadius)
            {
                control.InteriorFrame.CornerRadius = cornerRadius;
            }
        }

        private static void OnInteriorPaddingPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is Thickness padding)
            {
                control.InteriorBorderFrame.Padding = padding;
            }
        }

        #endregion

        #region Button

        private static void OnButtonBackgroundColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is Color color)
            {
                control.InteriorTopButton.BackgroundColor = color;
            }
        }

        private static void OnButtonCommandPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is ICommand command)
            {
                control.InteriorTopButton.Command = command;
                control.ExteriorOneButton.Command = command;
            }
        }

        private static void OnButtonCommandParameterPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is object commandParameter)
            {
                control.InteriorTopButton.CommandParameter = commandParameter;
                control.ExteriorOneButton.CommandParameter = commandParameter;
            }
        }

        private static void OnButtonPressedColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is Color color)
            {
                control.InteriorTopButton.PressedColor = color;
            }
        }

        private static void OnButtonShadowSizePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is float shadowSize)
            {
                control.InteriorTopButton.ShadowSize = shadowSize;
            }
        }

        private static void OnButtonShadowMarginPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is float shadowMargin)
            {
                control.InteriorTopButton.ShadowMargin = shadowMargin;
            }
        }

        private static void OnButtonTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is string text)
            {
                control.InteriorTopButton.Text = text.ToUpper();
            }
        }

        private static void OnButtonFontSizePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is double fontSize)
            {
                control.InteriorTopButton.FontSize = fontSize;
            }
        }

        private static void OnButtonTextColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RevealButton)bindable;
            if (newValue is Color color)
            {
                control.InteriorTopButton.TextColor = color;
            }
        }

        #endregion

        #endregion

        #region .: Events :.

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

        #endregion
    }

    public class BottomItem : ContentView
    {

    }
}