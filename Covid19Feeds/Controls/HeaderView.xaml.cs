using System;
using System.Collections.Generic;
using System.ComponentModel;
using Covid19Feeds.ViewModels;
using Xamarin.Forms;

namespace Covid19Feeds.Controls
{
    public partial class HeaderView : ContentView, INotifyPropertyChanged
    {
        public HeaderView()
        {
            InitializeComponent();
            
        }
        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
                 nameof(Text),
                 typeof(string),
                 typeof(Label),defaultValue:string.Empty,
                propertyChanged: TitleTextPropertyChanged);

        private static void TitleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (HeaderView)bindable;
            control.label.Text = newValue as string;
        }





      






        private bool _moveImageLeftSide;
        public bool MoveImageLeftSide
        {
            get { return _moveImageLeftSide; }
            set
            {
                _moveImageLeftSide = value;
                OnPropertyChanged();
            }
        }

        public static readonly BindableProperty MoveImageLeftSideProperty = BindableProperty.Create(
                 nameof(MoveImageLeftSide),
                 typeof(bool),
                 typeof(Label),
                 false, propertyChanged: MoveImageLeftSidePropertyChanged);

        private static void MoveImageLeftSidePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (HeaderView)bindable;
            var val=(bool)newValue;
            if (val)
            {
                control.label.HorizontalTextAlignment = TextAlignment.Start;
                control.label.VerticalTextAlignment = TextAlignment.Start;
                //control.image.IsVisible = false;

            }
            else
            {
                control.label.HorizontalTextAlignment = TextAlignment.Center;
                control.label.VerticalTextAlignment = TextAlignment.Center;
               // control.image.IsVisible = true;

            }

            // var x= newValue.ToString();
        }


        private string headerImage;
        public string HeaderImage
        {
            get { return headerImage; }
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }

        public static readonly BindableProperty HeaderImageProperty = BindableProperty.Create(
                 nameof(HeaderImage),
                 typeof(string),
                 typeof(Image), defaultValue: "https://cdn2.iconfinder.com/data/icons/covid-19-solid/64/virus-06-512.png",
                propertyChanged: HeaderImagePropertyChanged);

        private static void HeaderImagePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (HeaderView)bindable;
            control.image.Source = newValue as string;
        }




        private bool isHeaderImageVisible;
        public bool IsHeaderImageVisible
        {
            get { return isHeaderImageVisible; }
            set
            {
                isHeaderImageVisible = value;
                OnPropertyChanged();
            }
        }

       
    }
}
