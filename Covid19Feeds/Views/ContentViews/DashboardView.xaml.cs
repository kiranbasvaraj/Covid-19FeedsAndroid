using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Covid19Feeds.Views.ContentViews
{
    public partial class DashboardView : ContentView
    {
        public static event EventHandler ItemTappedHandler;
        public DashboardView()
        {
            InitializeComponent();
            cv.SelectionChanged += Cv_SelectionChanged;


        }

        private void Cv_SelectionChanged(object s, SelectionChangedEventArgs e)
        {
            ItemTappedHandler?.Invoke(s, e);
        }
    }
}
