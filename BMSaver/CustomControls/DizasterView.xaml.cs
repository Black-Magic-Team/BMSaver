using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace BMSaver.CustomControls
{
    public partial class DizasterView : ContentView
    {
        public static readonly BindableProperty ImageProperty = BindableProperty.Create(
            propertyName: nameof(Image),
            returnType: typeof(string),
            declaringType: typeof(DizasterView),
            propertyChanged: OnImagePropertyChanged);

        public static readonly BindableProperty InfoCommandProperty = BindableProperty.Create(
            propertyName: nameof(InfoCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(DizasterView),
            propertyChanged: OnInfoCommandProperyChanged);

        public static readonly BindableProperty CommandProperty = BindableProperty.Create(
            propertyName: nameof(Command),
            returnType: typeof(ICommand),
            declaringType: typeof(DizasterView),
            propertyChanged: OnCommandPropertyChanged);

        public static readonly BindableProperty ColorProperty = BindableProperty.Create(
            propertyName: nameof(Color),
            returnType: typeof(Color),
            declaringType: typeof(DizasterView),
            defaultValue: Color.Transparent,
            propertyChanged: OnColorPropertyChanged);

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            propertyName: nameof(Text),
            returnType: typeof(string),
            declaringType: typeof(DizasterView),
            propertyChanged: OnTextPropertyChanged);

        private static void OnTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null) return;
            if (bindable is DizasterView)
            {
                DizasterView dizasterView = bindable as DizasterView;
                dizasterView.DizasterLabel.Text = newValue.ToString();
            }
        }

        private static void OnColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null) return;
            if (bindable is DizasterView)
            {
                DizasterView dizasterView = bindable as DizasterView;
                dizasterView.CardLayout.BackgroundColor = (Xamarin.Forms.Color)newValue;
            }

        }

        private static void OnCommandPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null) return;
            if (bindable is DizasterView)
            {
                DizasterView dizasterView = bindable as DizasterView;

                TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Command = newValue as ICommand;

                dizasterView.GestureRecognizers.Add(tapGestureRecognizer);
            }

        }

        private static void OnInfoCommandProperyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null) return;
            if (bindable is DizasterView)
            {
                DizasterView dizasterView = bindable as DizasterView;

                TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Command = newValue as ICommand;

                dizasterView.InfoButton.GestureRecognizers.Add(tapGestureRecognizer);
            }
        }

        private static void OnImagePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null) return;
            if (bindable is DizasterView)
            {
                DizasterView dizasterView = bindable as DizasterView;
                dizasterView.DizasterButton.Source = ImageSource.FromFile(newValue.ToString());
            }
        }

        public DizasterView()
        {
            InitializeComponent();
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public Color Color
        {
            get { return (Xamarin.Forms.Color)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        public ICommand Command
        {
            get { return (System.Windows.Input.ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public ICommand InfoCommand
        {
            get { return (System.Windows.Input.ICommand)GetValue(InfoCommandProperty); }
            set { SetValue(InfoCommandProperty, value); }
        }

        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

    }
}
