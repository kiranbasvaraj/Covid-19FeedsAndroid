using System;
using Xamarin.Forms;

namespace Covid19Feeds.Behaviours
{
    public class ImageAnimBehaviour: Behavior<View>
    {
       

        protected override void OnAttachedTo(View bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.BindingContextChanged += Bindable_BindingContextChanged;

        }

        private void Bindable_BindingContextChanged(object sender, EventArgs e)
        {
            ContentView mContentView =  sender as ContentView;
            if (mContentView.IsVisible)
            {
                mContentView.TranslateTo(10,20,100,Easing.BounceIn);
            }
            else
            {
                mContentView.TranslateTo(102, 230, 100, Easing.BounceIn);
            }
        }

        protected override void OnDetachingFrom(BindableObject bindable)
        {
            base.OnDetachingFrom(bindable); bindable.BindingContextChanged -= Bindable_BindingContextChanged;
        }
    }
}
