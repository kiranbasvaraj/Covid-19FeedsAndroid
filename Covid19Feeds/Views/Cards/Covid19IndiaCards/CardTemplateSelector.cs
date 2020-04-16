using System;
using Covid19Feeds.Models;
using Xamarin.Forms;

namespace Covid19Feeds.Views.Cards.Covid19IndiaCards
{
    public class CardTemplateSelector
    : DataTemplateSelector
    {
        public DataTemplate dashboardcard;
        public DataTemplate listcard;
        public CardTemplateSelector()
        {
            this.dashboardcard = new DataTemplate(typeof(StateDashBoardCard));
            this.listcard = new DataTemplate(typeof(StateCardView));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var val = item as Statewise;
            if (val == null)
                return null;
            if (val.state.ToLower()=="total")
            {
                return dashboardcard;
            }
            else
            {
                return listcard;
            }

        }
    }

}
