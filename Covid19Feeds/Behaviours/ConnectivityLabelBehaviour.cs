using System;
using Xamarin.Forms;
using Plugin.Connectivity;
using System.Threading.Tasks;

namespace Covid19Feeds.Behaviours
{
    public class ConnectivityLabelBehaviour : Behavior<Label>
    {
        Label mlabel;

        protected override void OnAttachedTo(Label bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.IsVisible = Plugin.Connectivity.CrossConnectivity.Current.IsConnected ? false : true;
            mlabel = bindable;
            Plugin.Connectivity.CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;

        }

        private async void Current_ConnectivityChanged(object sender, Plugin.Connectivity.Abstractions.ConnectivityChangedEventArgs e)
        {
            if (Plugin.Connectivity.CrossConnectivity.Current.IsConnected)
            {
                AnimateWhenConnected();
            }
            else
            {
                AnimateWhenDisConnected();
            }




        }
       

        protected override void OnDetachingFrom(BindableObject bindable)
        {
            base.OnDetachingFrom(bindable);
            Plugin.Connectivity.CrossConnectivity.Current.ConnectivityChanged -= Current_ConnectivityChanged;

        }

        async void AnimateWhenConnected()
        {
            await mlabel.TranslateTo(0, -30, 450, Easing.Linear);
            mlabel.IsVisible = false;
            await mlabel.TranslateTo(0, 0, 0, null);

        }

        async void AnimateWhenDisConnected()
        {

            mlabel.IsVisible = true;
            await mlabel.TranslateTo(0, -30, 0, null);
            await mlabel.TranslateTo(0, 0, 450, Easing.Linear);
            //await Task.Delay(3);
            //await mlabel.TranslateTo(0, 0, 300, Easing.CubicInOut);

        }
    }
}
