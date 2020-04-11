using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Covid19Feeds.ViewModels
{
    public class BaseViewModel:INotifyPropertyChanged
    {
        public BaseViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyChage([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
