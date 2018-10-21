using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BMSaver.CustomControls
{
    public partial class CardView : ContentView
    {
        public static readonly BindableProperty ImageProperty = BindableProperty.Create(
            propertyName: nameof(Image),
            returnType: typeof(string),
            declaringType: typeof(CardView),
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: OnImagePropertyChanged);

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            propertyName: nameof(Text),
            returnType: typeof(string),
            declaringType: typeof(CardView),
            defaultBindingMode: BindingMode.Default,
            propertyChanged: OnTextPropertyChanged);


        public static readonly BindableProperty BarColorProperty = BindableProperty.Create(
            propertyName: nameof(BarColor),
            returnType: typeof(Color),
            declaringType: typeof(CardView),
            defaultValue: Color.Transparent,
            defaultBindingMode: BindingMode.Default,
            propertyChanged: OnBarColorPropertyChanged);

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create(
            propertyName: nameof(TextColor),
            returnType: typeof(Color),
            declaringType: typeof(CardView),
            defaultValue: Color.Blue,
            defaultBindingMode: BindingMode.Default,
            propertyChanged: OnTextColorPropertyChanged);



        public CardView()
        {
            InitializeComponent();
        }

        #region Image binding region

        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        private static void OnImagePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null) return;
            if (bindable is CardView)
            {
                CardView cardView = (BMSaver.CustomControls.CardView)bindable;
                cardView.BackgroundImage.Source = ImageSource.FromFile(newValue.ToString());
            }
        }
        #endregion

        #region Text binding region
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        private static void OnTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null) return;
            if (bindable is CardView)
            {
                CardView cardView = (BMSaver.CustomControls.CardView)bindable;
                cardView.CardLabel.Text = newValue.ToString();
            }
        }


        #endregion

        #region CardBar Color 
        public Color BarColor
        {
            get { return (Xamarin.Forms.Color)GetValue(BarColorProperty); }
            set { SetValue(BarColorProperty, value); }
        }

        private static void OnBarColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null) return;
            if (bindable is CardView)
            {
                CardView cardView = (BMSaver.CustomControls.CardView)bindable;
                cardView.CardBar.BackgroundColor = (Xamarin.Forms.Color)newValue;
            }
        }

        #endregion

        #region TextColor 
        public Color TextColor
        {
            get { return (Xamarin.Forms.Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        private static void OnTextColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null) return;
            if (bindable is CardView)
            {
                CardView cardView = (BMSaver.CustomControls.CardView)bindable;
                cardView.CardLabel.TextColor = (Xamarin.Forms.Color)newValue;
            }
        }
        #endregion

    }
}
