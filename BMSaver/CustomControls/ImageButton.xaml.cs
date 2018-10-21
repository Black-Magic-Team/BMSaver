using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace BMSaver.CustomControls
{
    public partial class ImageButton : ContentView
    {
        public static readonly BindableProperty ImageProperty = BindableProperty.Create(
            propertyName: nameof(Image),
            returnType: typeof(string),
            declaringType: typeof(ImageButton),
            propertyChanged: OnImagePropertyChanged);

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            propertyName: nameof(Text),
            returnType: typeof(string),
            declaringType: typeof(ImageButton),
            propertyChanged: OnTextPropertyChanged);

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create(
            propertyName: nameof(FontSize),
            returnType: typeof(double),
            defaultValue: 12d,
            declaringType: typeof(ImageButton),
            propertyChanged: OnFontSizePropertyChanged);

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create(
            propertyName: nameof(TextColor),
            returnType: typeof(Color),
            declaringType: typeof(ImageButton),
            defaultValue: Color.White,
            propertyChanged: OnTextColorPropertyChanged
        );


        public static readonly BindableProperty CommandProperty = BindableProperty.Create(
            propertyName: nameof(Command),
            returnType: typeof(ICommand),
            declaringType: typeof(ImageButton),
            defaultBindingMode: BindingMode.OneWay,
            defaultValue: null,
            propertyChanged: OnCommandPropertyChanged);

        private static void OnCommandPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null) return;
            if (bindable is ImageButton)
            {
                ImageButton imageButton = bindable as ImageButton;
                TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Command = newValue as ICommand;
                imageButton.GestureRecognizers.Add(tapGestureRecognizer);
            }
        }

        private static void OnTextColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null) return;
            if (bindable is ImageButton)
            {
                ImageButton imageButton = bindable as ImageButton;
                imageButton.ButtonText.TextColor = (Xamarin.Forms.Color)newValue;
            }
        }

        private static void OnFontSizePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null) return;
            if (bindable is ImageButton)
            {
                ImageButton imageButton = bindable as ImageButton;
                imageButton.ButtonText.FontSize = (double)newValue;
            }
        }

        private static void OnTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null) return;
            if (bindable is ImageButton)
            {
                ImageButton imageButton = bindable as ImageButton;
                imageButton.ButtonText.Text = newValue.ToString();
            }
        }

        private static void OnImagePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null) return;
            if (bindable is ImageButton)
            {
                ImageButton imageButton = bindable as ImageButton;
                imageButton.ButtonImage.Source = ImageSource.FromFile(newValue.ToString());
            }
        }

        public ImageButton()
        {
            InitializeComponent();
        }

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }


    }
}
