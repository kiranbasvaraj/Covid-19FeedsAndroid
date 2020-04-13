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
            // cv.SelectionChanged += Cv_SelectionChanged;

            
        }

       
    }
}
